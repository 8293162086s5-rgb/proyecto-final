Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmVisitante

    Dim bl As New VisitanteBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmVisitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGenero.Items.AddRange({"Masculino", "Femenino", "Otro"})
        cboGenero.SelectedIndex = 0
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarTabla()
        Try
            dgvVisitantes.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar visitantes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtApellido.Clear()
        txtDocumento.Clear()
        txtEdad.Clear()
        txtNacionalidad.Clear()
        txtEmail.Clear()
        cboGenero.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim vis As New Visitante With {
                .Nombre = txtNombre.Text.Trim(),
                .Apellido = txtApellido.Text.Trim(),
                .DocumentoIdentidad = txtDocumento.Text.Trim(),
                .Edad = Convert.ToInt32(If(txtEdad.Text.Trim() = "", "0", txtEdad.Text.Trim())),
                .Genero = cboGenero.Text,
                .Nacionalidad = txtNacionalidad.Text.Trim(),
                .Email = txtEmail.Text.Trim()
            }
            If modoEdicion Then
                vis.IdVisitante = idSeleccionado
                bl.Actualizar(vis)
                MessageBox.Show("Visitante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(vis)
                MessageBox.Show("Visitante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvVisitantes.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un visitante para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvVisitantes.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdVisitante").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtApellido.Text = fila.Cells("Apellido").Value.ToString()
        txtDocumento.Text = fila.Cells("DocumentoIdentidad").Value.ToString()
        txtEdad.Text = fila.Cells("Edad").Value.ToString()
        cboGenero.Text = fila.Cells("Genero").Value.ToString()
        txtNacionalidad.Text = fila.Cells("Nacionalidad").Value.ToString()
        txtEmail.Text = fila.Cells("Email").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvVisitantes.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un visitante para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvVisitantes.SelectedRows(0).Cells("IdVisitante").Value)
        If MessageBox.Show("¿Desea eliminar este visitante?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Visitante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            dgvVisitantes.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class