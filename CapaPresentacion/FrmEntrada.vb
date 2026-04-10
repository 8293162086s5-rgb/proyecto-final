Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmEntrada

    Dim bl          As New EntradaBL()
    Dim blVisitante As New VisitanteBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVisitantes()
        CargarTipos()
        CargarMetodosPago()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarVisitantes()
        Try
            Dim lista = blVisitante.Listar()
            cboVisitante.DataSource    = lista
            cboVisitante.DisplayMember = "NombreCompleto"
            cboVisitante.ValueMember   = "IdVisitante"
            cboVisitante.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar visitantes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"General", "Estudiante", "Adulto Mayor", "Niño (menor de 12)", "Discapacitado", "Gratuita"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarMetodosPago()
        cboMetodoPago.Items.Clear()
        cboMetodoPago.Items.AddRange({"Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito", "Transferencia", "Cortesía"})
        cboMetodoPago.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvEntradas.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar entradas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboVisitante.SelectedIndex = -1
        cboTipo.SelectedIndex      = 0
        txtPrecio.Clear()
        txtCantidad.Clear()
        dtpFecha.Value = Date.Today
        cboMetodoPago.SelectedIndex = 0
        txtObservaciones.Clear()
        btnGuardar.Text    = "💾  Guardar"
        btnCancelar.Visible = False
        cboVisitante.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cboVisitante.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un visitante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim ent As New Entrada With {
                .IdVisitante   = Convert.ToInt32(cboVisitante.SelectedValue),
                .Tipo          = cboTipo.Text,
                .Precio        = If(String.IsNullOrWhiteSpace(txtPrecio.Text), 0D, Convert.ToDecimal(txtPrecio.Text)),
                .Cantidad      = If(String.IsNullOrWhiteSpace(txtCantidad.Text), 1, Convert.ToInt32(txtCantidad.Text)),
                .Fecha         = dtpFecha.Value,
                .MetodoPago    = cboMetodoPago.Text,
                .Observaciones = txtObservaciones.Text.Trim()
            }
            If modoEdicion Then
                ent.IdEntrada = idSeleccionado
                bl.Actualizar(ent)
                MessageBox.Show("Entrada actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(ent)
                MessageBox.Show("Entrada registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvEntradas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una entrada para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvEntradas.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdEntrada").Value)
        cboVisitante.SelectedValue = fila.Cells("IdVisitante").Value
        cboTipo.Text               = fila.Cells("Tipo").Value.ToString()
        txtPrecio.Text             = fila.Cells("Precio").Value.ToString()
        txtCantidad.Text           = fila.Cells("Cantidad").Value.ToString()
        dtpFecha.Value             = Convert.ToDateTime(fila.Cells("Fecha").Value)
        cboMetodoPago.Text         = fila.Cells("MetodoPago").Value.ToString()
        txtObservaciones.Text      = fila.Cells("Observaciones").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvEntradas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una entrada para anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id       = Convert.ToInt32(dgvEntradas.SelectedRows(0).Cells("IdEntrada").Value)
        Dim visitante = dgvEntradas.SelectedRows(0).Cells("NombreVisitante").Value.ToString()
        If MessageBox.Show($"¿Desea anular la entrada de '{visitante}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Entrada anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                ModoNuevo()
            Catch ex As Exception
                MessageBox.Show("Error al anular: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoNuevo()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim filtro = bl.Listar().FindAll(Function(x) x.NombreVisitante.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.Tipo.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvEntradas.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
