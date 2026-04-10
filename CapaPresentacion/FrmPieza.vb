Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmPieza

    Dim bl As New PiezaBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmPieza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarEstados()
        cboEstadoConservacion.Items.Clear()
        cboEstadoConservacion.Items.AddRange({"Excelente", "Bueno", "Regular", "Malo"})
        cboEstadoConservacion.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvPiezas.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar piezas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtEpoca.Clear()
        txtMaterial.Clear()
        txtUbicacion.Clear()
        txtValor.Text = "0.00"
        cboEstadoConservacion.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim pieza As New Pieza With {
                .Nombre = txtNombre.Text.Trim(),
                .Descripcion = txtDescripcion.Text.Trim(),
                .Epoca = txtEpoca.Text.Trim(),
                .Material = txtMaterial.Text.Trim(),
                .EstadoConservacion = cboEstadoConservacion.Text,
                .Ubicacion = txtUbicacion.Text.Trim(),
                .ValorEstimado = Convert.ToDecimal(If(txtValor.Text.Trim() = "", "0", txtValor.Text.Trim()))
            }
            If modoEdicion Then
                pieza.IdPieza = idSeleccionado
                bl.Actualizar(pieza)
                MessageBox.Show("Pieza actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(pieza)
                MessageBox.Show("Pieza registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvPiezas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una pieza para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvPiezas.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdPieza").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
        txtEpoca.Text = fila.Cells("Epoca").Value.ToString()
        txtMaterial.Text = fila.Cells("Material").Value.ToString()
        cboEstadoConservacion.Text = fila.Cells("EstadoConservacion").Value.ToString()
        txtUbicacion.Text = fila.Cells("Ubicacion").Value.ToString()
        txtValor.Text = fila.Cells("ValorEstimado").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvPiezas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una pieza para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvPiezas.SelectedRows(0).Cells("IdPieza").Value)
        If MessageBox.Show("¿Desea eliminar esta pieza?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Pieza eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x) x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvPiezas.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class