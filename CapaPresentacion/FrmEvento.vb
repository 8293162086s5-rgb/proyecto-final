Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmEvento

    Dim bl     As New EventoBL()
    Dim blSala As New SalaBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSalas()
        CargarTipos()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarSalas()
        Try
            Dim lista = blSala.Listar()
            cboSala.DataSource    = lista
            cboSala.DisplayMember = "Nombre"
            cboSala.ValueMember   = "IdSala"
            cboSala.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar salas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Conferencia", "Taller Educativo", "Exposición Especial", "Concierto", "Visita Nocturna", "Actividad Infantil", "Presentación de Libro", "Otro"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Planificado", "Confirmado", "En Curso", "Finalizado", "Cancelado"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvEventos.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar eventos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboSala.SelectedIndex   = -1
        txtNombre.Clear()
        cboTipo.SelectedIndex   = 0
        txtResponsable.Clear()
        txtCapacidadMaxima.Clear()
        dtpFechaInicio.Value    = Date.Today
        dtpFechaFin.Value       = Date.Today
        cboEstado.SelectedIndex = 0
        txtDescripcion.Clear()
        btnGuardar.Text    = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cboSala.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una sala.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim ev As New Evento With {
                .IdSala          = Convert.ToInt32(cboSala.SelectedValue),
                .Nombre          = txtNombre.Text.Trim(),
                .Tipo            = cboTipo.Text,
                .Responsable     = txtResponsable.Text.Trim(),
                .CapacidadMaxima = If(String.IsNullOrWhiteSpace(txtCapacidadMaxima.Text), 0, Convert.ToInt32(txtCapacidadMaxima.Text)),
                .FechaInicio     = dtpFechaInicio.Value,
                .FechaFin        = dtpFechaFin.Value,
                .Estado          = cboEstado.Text,
                .Descripcion     = txtDescripcion.Text.Trim()
            }
            If modoEdicion Then
                ev.IdEvento = idSeleccionado
                bl.Actualizar(ev)
                MessageBox.Show("Evento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(ev)
                MessageBox.Show("Evento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvEventos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un evento para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvEventos.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdEvento").Value)
        cboSala.SelectedValue    = fila.Cells("IdSala").Value
        txtNombre.Text           = fila.Cells("Nombre").Value.ToString()
        cboTipo.Text             = fila.Cells("Tipo").Value.ToString()
        txtResponsable.Text      = fila.Cells("Responsable").Value.ToString()
        txtCapacidadMaxima.Text  = fila.Cells("CapacidadMaxima").Value.ToString()
        dtpFechaInicio.Value     = Convert.ToDateTime(fila.Cells("FechaInicio").Value)
        dtpFechaFin.Value        = Convert.ToDateTime(fila.Cells("FechaFin").Value)
        cboEstado.Text           = fila.Cells("Estado").Value.ToString()
        txtDescripcion.Text      = fila.Cells("Descripcion").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvEventos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un evento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id     = Convert.ToInt32(dgvEventos.SelectedRows(0).Cells("IdEvento").Value)
        Dim nombre = dgvEventos.SelectedRows(0).Cells("Nombre").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar el evento '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Evento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x) x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.NombreSala.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvEventos.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
