Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmInventario

    Dim bl         As New InventarioBL()
    Dim blEmpleado As New EmpleadoBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpleados()
        CargarCategorias()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarEmpleados()
        Try
            Dim lista = blEmpleado.Listar()
            cboEmpleado.DataSource    = lista
            cboEmpleado.DisplayMember = "NombreCompleto"
            cboEmpleado.ValueMember   = "IdEmpleado"
            cboEmpleado.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarCategorias()
        cboCategoria.Items.Clear()
        cboCategoria.Items.AddRange({"Pintura", "Escultura", "Fotografía", "Documento Histórico", "Joya", "Cerámica", "Textil", "Arma Histórica", "Moneda", "Otro"})
        cboCategoria.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Excelente", "Bueno", "Regular", "Deteriorado", "En Restauración", "No Apto"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvInventario.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar inventario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboEmpleado.SelectedIndex = -1
        txtNombre.Clear()
        txtCodigoInventario.Clear()
        cboCategoria.SelectedIndex = 0
        txtEpoca.Clear()
        txtMaterial.Clear()
        txtUbicacion.Clear()
        txtValorEstimado.Clear()
        cboEstado.SelectedIndex = 0
        dtpFechaIngreso.Value   = Date.Today
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
            If cboEmpleado.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un empleado responsable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim inv As New Inventario With {
                .IdEmpleado       = Convert.ToInt32(cboEmpleado.SelectedValue),
                .Nombre           = txtNombre.Text.Trim(),
                .CodigoInventario = txtCodigoInventario.Text.Trim(),
                .Categoria        = cboCategoria.Text,
                .Epoca            = txtEpoca.Text.Trim(),
                .Material         = txtMaterial.Text.Trim(),
                .Ubicacion        = txtUbicacion.Text.Trim(),
                .ValorEstimado    = If(String.IsNullOrWhiteSpace(txtValorEstimado.Text), 0D, Convert.ToDecimal(txtValorEstimado.Text)),
                .Estado           = cboEstado.Text,
                .FechaIngreso     = dtpFechaIngreso.Value,
                .Descripcion      = txtDescripcion.Text.Trim()
            }
            If modoEdicion Then
                inv.IdInventario = idSeleccionado
                bl.Actualizar(inv)
                MessageBox.Show("Objeto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(inv)
                MessageBox.Show("Objeto registrado en inventario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvInventario.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un objeto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvInventario.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdInventario").Value)
        cboEmpleado.SelectedValue   = fila.Cells("IdEmpleado").Value
        txtNombre.Text              = fila.Cells("Nombre").Value.ToString()
        txtCodigoInventario.Text    = fila.Cells("CodigoInventario").Value.ToString()
        cboCategoria.Text           = fila.Cells("Categoria").Value.ToString()
        txtEpoca.Text               = fila.Cells("Epoca").Value.ToString()
        txtMaterial.Text            = fila.Cells("Material").Value.ToString()
        txtUbicacion.Text           = fila.Cells("Ubicacion").Value.ToString()
        txtValorEstimado.Text       = fila.Cells("ValorEstimado").Value.ToString()
        cboEstado.Text              = fila.Cells("Estado").Value.ToString()
        dtpFechaIngreso.Value       = Convert.ToDateTime(fila.Cells("FechaIngreso").Value)
        txtDescripcion.Text         = fila.Cells("Descripcion").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvInventario.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un objeto para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id     = Convert.ToInt32(dgvInventario.SelectedRows(0).Cells("IdInventario").Value)
        Dim nombre = dgvInventario.SelectedRows(0).Cells("Nombre").Value.ToString()
        If MessageBox.Show($"¿Desea dar de baja '{nombre}' del inventario?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Objeto eliminado del inventario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                                                          x.CodigoInventario.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.NombreEmpleado.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvInventario.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
