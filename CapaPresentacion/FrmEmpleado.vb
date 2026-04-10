Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmEmpleado

    Dim bl As New EmpleadoBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarCargos()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Inactivo")
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarCargos()
        cboCargo.Items.Clear()
        cboCargo.Items.AddRange({"Curador", "Administrador", "Seguridad", "Guía", "Mantenimiento", "Recepcionista", "Director"})
        cboCargo.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            Dim lista = bl.Listar()
            dgvEmpleados.DataSource = lista
        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtApellido.Clear()
        cboCargo.SelectedIndex = 0
        dtpFechaIngreso.Value = Date.Today
        txtTelefono.Clear()
        txtEmail.Clear()
        cboEstado.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim emp As New Empleado With {
                .Nombre = txtNombre.Text.Trim(),
                .Apellido = txtApellido.Text.Trim(),
                .Cargo = cboCargo.Text,
                .FechaIngreso = dtpFechaIngreso.Value,
                .Telefono = txtTelefono.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .Estado = cboEstado.Text
            }
            If modoEdicion Then
                emp.IdEmpleado = idSeleccionado
                bl.Actualizar(emp)
                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(emp)
                MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvEmpleados.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdEmpleado").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtApellido.Text = fila.Cells("Apellido").Value.ToString()
        cboCargo.Text = fila.Cells("Cargo").Value.ToString()
        dtpFechaIngreso.Value = Convert.ToDateTime(fila.Cells("FechaIngreso").Value)
        txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
        txtEmail.Text = fila.Cells("Email").Value.ToString()
        cboEstado.Text = fila.Cells("Estado").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvEmpleados.SelectedRows(0).Cells("IdEmpleado").Value)
        Dim nombre = dgvEmpleados.SelectedRows(0).Cells("Nombre").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar al empleado '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                                                          x.Apellido.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvEmpleados.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class