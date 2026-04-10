Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmReserva

    Dim bl          As New ReservaBL()
    Dim blVisitante As New VisitanteBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVisitantes()
        CargarEstados()
        CargarTipos()
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

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Pendiente", "Confirmada", "Cancelada", "Completada"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Visita General", "Visita Guiada", "Grupo Escolar", "Visita Privada", "Evento Especial"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvReservas.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar reservas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboVisitante.SelectedIndex  = -1
        txtCantidadPersonas.Clear()
        dtpFechaReserva.Value = Date.Today
        dtpHora.Value         = Date.Today
        cboTipo.SelectedIndex   = 0
        cboEstado.SelectedIndex = 0
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
            Dim res As New Reserva With {
                .IdVisitante      = Convert.ToInt32(cboVisitante.SelectedValue),
                .CantidadPersonas = If(String.IsNullOrWhiteSpace(txtCantidadPersonas.Text), 1, Convert.ToInt32(txtCantidadPersonas.Text)),
                .FechaReserva     = dtpFechaReserva.Value,
                .Hora             = dtpHora.Value,
                .Tipo             = cboTipo.Text,
                .Estado           = cboEstado.Text,
                .Observaciones    = txtObservaciones.Text.Trim()
            }
            If modoEdicion Then
                res.IdReserva = idSeleccionado
                bl.Actualizar(res)
                MessageBox.Show("Reserva actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(res)
                MessageBox.Show("Reserva registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvReservas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una reserva para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvReservas.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdReserva").Value)
        cboVisitante.SelectedValue  = fila.Cells("IdVisitante").Value
        txtCantidadPersonas.Text    = fila.Cells("CantidadPersonas").Value.ToString()
        dtpFechaReserva.Value       = Convert.ToDateTime(fila.Cells("FechaReserva").Value)
        dtpHora.Value               = Convert.ToDateTime(fila.Cells("Hora").Value)
        cboTipo.Text                = fila.Cells("Tipo").Value.ToString()
        cboEstado.Text              = fila.Cells("Estado").Value.ToString()
        txtObservaciones.Text       = fila.Cells("Observaciones").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvReservas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una reserva para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id       = Convert.ToInt32(dgvReservas.SelectedRows(0).Cells("IdReserva").Value)
        Dim visitante = dgvReservas.SelectedRows(0).Cells("NombreVisitante").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar la reserva de '{visitante}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Reserva eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x) x.NombreVisitante.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.Tipo.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvReservas.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
