Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmGuia
    Dim bl         As New GuiaBL()
    Dim blEmpleado As New EmpleadoBL()
    Dim modoEdicion    As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpleados() : CargarIdiomas() : CargarEstados() : CargarTabla() : ModoNuevo()
    End Sub

    Private Sub CargarEmpleados()
        Try
            Dim lista = blEmpleado.Listar()
            cboEmpleado.DataSource    = lista
            cboEmpleado.DisplayMember = "NombreCompleto"
            cboEmpleado.ValueMember   = "IdEmpleado"
            cboEmpleado.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarIdiomas()
        cboIdioma.Items.Clear()
        cboIdioma.Items.AddRange({"Español", "Inglés", "Francés", "Español / Inglés",
                                   "Español / Francés", "Español / Portugués", "Español / Italiano", "Otro"})
        cboIdioma.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Activo", "Inactivo"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvGuias.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar guías: " & ex.Message)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False : idSeleccionado = 0
        txtNombre.Clear() : txtApellido.Clear() : txtTelefono.Clear() : txtEmail.Clear()
        cboIdioma.SelectedIndex = 0 : cboEstado.SelectedIndex = 0 : cboEmpleado.SelectedIndex = -1
        btnGuardar.Text = "💾  Guardar" : btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim guia As New Guia With {
                .Nombre     = txtNombre.Text.Trim(),
                .Apellido   = txtApellido.Text.Trim(),
                .Telefono   = txtTelefono.Text.Trim(),
                .Email      = txtEmail.Text.Trim(),
                .Idioma     = cboIdioma.Text,
                .Estado     = cboEstado.Text,
                .IdEmpleado = If(cboEmpleado.SelectedIndex >= 0, Convert.ToInt32(cboEmpleado.SelectedValue), 0)
            }
            If modoEdicion Then
                guia.IdGuia = idSeleccionado
                bl.Actualizar(guia)
                MessageBox.Show("Guía actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(guia)
                MessageBox.Show("Guía registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla() : ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvGuias.SelectedRows.Count = 0 Then MessageBox.Show("Seleccione un guía para editar.") : Return
        Dim f = dgvGuias.SelectedRows(0)
        modoEdicion = True : idSeleccionado = Convert.ToInt32(f.Cells("IdGuia").Value)
        txtNombre.Text   = f.Cells("Nombre").Value.ToString()
        txtApellido.Text = f.Cells("Apellido").Value.ToString()
        txtTelefono.Text = f.Cells("Telefono").Value.ToString()
        txtEmail.Text    = f.Cells("Email").Value.ToString()
        cboIdioma.Text   = f.Cells("Idioma").Value.ToString()
        cboEstado.Text   = f.Cells("Estado").Value.ToString()
        Dim idEmp = f.Cells("IdEmpleado").Value
        If idEmp IsNot DBNull.Value AndAlso Convert.ToInt32(idEmp) > 0 Then
            cboEmpleado.SelectedValue = Convert.ToInt32(idEmp)
        Else
            cboEmpleado.SelectedIndex = -1
        End If
        btnGuardar.Text = "✏️  Actualizar" : btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvGuias.SelectedRows.Count = 0 Then MessageBox.Show("Seleccione un guía para eliminar.") : Return
        Dim id = Convert.ToInt32(dgvGuias.SelectedRows(0).Cells("IdGuia").Value)
        If MessageBox.Show("¿Desea eliminar este guía?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Guía eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla() : ModoNuevo()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoNuevo()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            dgvGuias.DataSource = bl.Listar().FindAll(Function(x)
                Return x.Nombre.ToLower.Contains(txtBuscar.Text.ToLower) OrElse
                x.Apellido.ToLower.Contains(txtBuscar.Text.ToLower) OrElse
                x.NombreEmpleado.ToLower.Contains(txtBuscar.Text.ToLower)
            End Function)
        Catch : End Try
    End Sub
End Class
