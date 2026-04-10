Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmSala

    Dim bl As New SalaBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarTipos()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Disponible", "Ocupada", "En Mantenimiento", "Cerrada"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Exposición Permanente", "Exposición Temporal", "Auditorio", "Sala Educativa", "Depósito", "Administrativa"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            Dim lista = bl.Listar()
            dgvSalas.DataSource = lista
        Catch ex As Exception
            MessageBox.Show("Error al cargar salas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtCapacidad.Clear()
        txtUbicacion.Clear()
        cboTipo.SelectedIndex = 0
        cboEstado.SelectedIndex = 0
        txtDescripcion.Clear()
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim sala As New Sala With {
                .Nombre      = txtNombre.Text.Trim(),
                .Capacidad   = If(String.IsNullOrWhiteSpace(txtCapacidad.Text), 0, Convert.ToInt32(txtCapacidad.Text)),
                .Ubicacion   = txtUbicacion.Text.Trim(),
                .Tipo        = cboTipo.Text,
                .Estado      = cboEstado.Text,
                .Descripcion = txtDescripcion.Text.Trim()
            }
            If modoEdicion Then
                sala.IdSala = idSeleccionado
                bl.Actualizar(sala)
                MessageBox.Show("Sala actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(sala)
                MessageBox.Show("Sala registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvSalas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una sala para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvSalas.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdSala").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtCapacidad.Text = fila.Cells("Capacidad").Value.ToString()
        txtUbicacion.Text = fila.Cells("Ubicacion").Value.ToString()
        cboTipo.Text = fila.Cells("Tipo").Value.ToString()
        cboEstado.Text = fila.Cells("Estado").Value.ToString()
        txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvSalas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una sala para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvSalas.SelectedRows(0).Cells("IdSala").Value)
        Dim nombre = dgvSalas.SelectedRows(0).Cells("Nombre").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar la sala '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Sala eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                                                          x.Ubicacion.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvSalas.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
