Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmDonacion

    Dim bl As New DonacionBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmDonacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipos()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Monetaria", "Pieza Histórica", "Material Educativo", "Obra de Arte", "Colección", "Otro"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Recibida", "En Evaluación", "Aceptada", "Rechazada"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            Dim lista = bl.Listar()
            dgvDonaciones.DataSource = lista
        Catch ex As Exception
            MessageBox.Show("Error al cargar donaciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombreDonante.Clear()
        txtEmailDonante.Clear()
        txtTelefonoDonante.Clear()
        cboTipo.SelectedIndex = 0
        txtDescripcion.Clear()
        txtValorEstimado.Clear()
        dtpFechaDonacion.Value = Date.Today
        cboEstado.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombreDonante.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim don As New Donacion With {
                .NombreDonante   = txtNombreDonante.Text.Trim(),
                .EmailDonante    = txtEmailDonante.Text.Trim(),
                .TelefonoDonante = txtTelefonoDonante.Text.Trim(),
                .Tipo            = cboTipo.Text,
                .Descripcion     = txtDescripcion.Text.Trim(),
                .ValorEstimado   = If(String.IsNullOrWhiteSpace(txtValorEstimado.Text), 0, Convert.ToDecimal(txtValorEstimado.Text)),
                .FechaDonacion   = dtpFechaDonacion.Value,
                .Estado          = cboEstado.Text
            }
            If modoEdicion Then
                don.IdDonacion = idSeleccionado
                bl.Actualizar(don)
                MessageBox.Show("Donación actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(don)
                MessageBox.Show("Donación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvDonaciones.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una donación para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvDonaciones.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdDonacion").Value)
        txtNombreDonante.Text = fila.Cells("NombreDonante").Value.ToString()
        txtEmailDonante.Text = fila.Cells("EmailDonante").Value.ToString()
        txtTelefonoDonante.Text = fila.Cells("TelefonoDonante").Value.ToString()
        cboTipo.Text = fila.Cells("Tipo").Value.ToString()
        txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
        txtValorEstimado.Text = fila.Cells("ValorEstimado").Value.ToString()
        dtpFechaDonacion.Value = Convert.ToDateTime(fila.Cells("FechaDonacion").Value)
        cboEstado.Text = fila.Cells("Estado").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombreDonante.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDonaciones.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una donación para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvDonaciones.SelectedRows(0).Cells("IdDonacion").Value)
        Dim nombre = dgvDonaciones.SelectedRows(0).Cells("NombreDonante").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar la donación de '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Donación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x) x.NombreDonante.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.Tipo.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvDonaciones.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
