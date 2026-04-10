Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmProveedor

    Dim bl As New ProveedorBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarCategorias()
        cboCategoria.Items.Clear()
        cboCategoria.Items.AddRange({"Restauración", "Seguridad", "Limpieza", "Tecnología", "Transporte", "Otro"})
        cboCategoria.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Inactivo")
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvProveedores.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtRazonSocial.Clear()
        txtRNC.Clear()
        txtContacto.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtDireccion.Clear()
        cboCategoria.SelectedIndex = 0
        cboEstado.SelectedIndex = 0
        dtpFechaRegistro.Value = Date.Today
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtRazonSocial.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim p As New Proveedor With {
                .RazonSocial = txtRazonSocial.Text.Trim(),
                .RNC = txtRNC.Text.Trim(),
                .Contacto = txtContacto.Text.Trim(),
                .Telefono = txtTelefono.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .Direccion = txtDireccion.Text.Trim(),
                .Categoria = cboCategoria.Text,
                .Estado = cboEstado.Text,
                .FechaRegistro = dtpFechaRegistro.Value
            }
            If modoEdicion Then
                p.IdProveedor = idSeleccionado
                bl.Actualizar(p)
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(p)
                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvProveedores.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un proveedor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvProveedores.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdProveedor").Value)
        txtRazonSocial.Text = fila.Cells("RazonSocial").Value.ToString()
        txtRNC.Text = fila.Cells("RNC").Value.ToString()
        txtContacto.Text = fila.Cells("Contacto").Value.ToString()
        txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
        txtEmail.Text = fila.Cells("Email").Value.ToString()
        txtDireccion.Text = fila.Cells("Direccion").Value.ToString()
        cboCategoria.Text = fila.Cells("Categoria").Value.ToString()
        cboEstado.Text = fila.Cells("Estado").Value.ToString()
        dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells("FechaRegistro").Value)
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtRazonSocial.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProveedores.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un proveedor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvProveedores.SelectedRows(0).Cells("IdProveedor").Value)
        Dim nombre = dgvProveedores.SelectedRows(0).Cells("RazonSocial").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar al proveedor '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x)
                                                 Return x.RazonSocial.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                        x.RNC.ToLower().Contains(txtBuscar.Text.ToLower())
                                             End Function)
            dgvProveedores.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
