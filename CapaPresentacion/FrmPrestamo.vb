Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmPrestamo

    Dim bl      As New PrestamoBL()
    Dim blPieza As New PiezaBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPiezas()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarPiezas()
        Try
            Dim lista = blPieza.Listar()
            cboPieza.DataSource    = lista
            cboPieza.DisplayMember = "Nombre"
            cboPieza.ValueMember   = "IdPieza"
            cboPieza.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar piezas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Solicitado", "Aprobado", "En Tránsito", "Entregado", "Devuelto", "Rechazado"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvPrestamos.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar préstamos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboPieza.SelectedIndex = -1
        txtInstitucionSolicitante.Clear()
        txtResponsable.Clear()
        txtContacto.Clear()
        dtpFechaPrestamo.Value  = Date.Today
        dtpFechaDevolucion.Value = Date.Today.AddMonths(1)
        cboEstado.SelectedIndex = 0
        txtCondiciones.Clear()
        btnGuardar.Text    = "💾  Guardar"
        btnCancelar.Visible = False
        cboPieza.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cboPieza.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una pieza.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim pre As New Prestamo With {
                .IdPieza                = Convert.ToInt32(cboPieza.SelectedValue),
                .InstitucionSolicitante = txtInstitucionSolicitante.Text.Trim(),
                .Responsable            = txtResponsable.Text.Trim(),
                .Contacto               = txtContacto.Text.Trim(),
                .FechaPrestamo          = dtpFechaPrestamo.Value,
                .FechaDevolucion        = dtpFechaDevolucion.Value,
                .Estado                 = cboEstado.Text,
                .Condiciones            = txtCondiciones.Text.Trim()
            }
            If modoEdicion Then
                pre.IdPrestamo = idSeleccionado
                bl.Actualizar(pre)
                MessageBox.Show("Préstamo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(pre)
                MessageBox.Show("Préstamo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvPrestamos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un préstamo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvPrestamos.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdPrestamo").Value)
        cboPieza.SelectedValue           = fila.Cells("IdPieza").Value
        txtInstitucionSolicitante.Text   = fila.Cells("InstitucionSolicitante").Value.ToString()
        txtResponsable.Text              = fila.Cells("Responsable").Value.ToString()
        txtContacto.Text                 = fila.Cells("Contacto").Value.ToString()
        dtpFechaPrestamo.Value           = Convert.ToDateTime(fila.Cells("FechaPrestamo").Value)
        dtpFechaDevolucion.Value         = Convert.ToDateTime(fila.Cells("FechaDevolucion").Value)
        cboEstado.Text                   = fila.Cells("Estado").Value.ToString()
        txtCondiciones.Text              = fila.Cells("Condiciones").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvPrestamos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un préstamo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id    = Convert.ToInt32(dgvPrestamos.SelectedRows(0).Cells("IdPrestamo").Value)
        Dim pieza = dgvPrestamos.SelectedRows(0).Cells("NombrePieza").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar el préstamo de '{pieza}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Préstamo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                ModoNuevo()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoNuevo()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim filtro = bl.Listar().FindAll(Function(x) x.NombrePieza.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.InstitucionSolicitante.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvPrestamos.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
