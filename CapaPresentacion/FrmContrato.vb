Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmContrato

    Dim bl          As New ContratoBL()
    Dim blProveedor As New ProveedorBL()
    Dim modoEdicion  As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
        CargarTipos()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarProveedores()
        Try
            Dim lista = blProveedor.Listar()
            cboProveedor.DataSource    = lista
            cboProveedor.DisplayMember = "RazonSocial"
            cboProveedor.ValueMember   = "IdProveedor"
            cboProveedor.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Servicio", "Suministro", "Obra", "Consultoría"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Activo", "Vencido", "Cancelado", "En Renovación"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvContratos.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar contratos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion    = False
        idSeleccionado = 0
        cboProveedor.SelectedIndex = -1
        txtNumero.Clear()
        txtDescripcion.Clear()
        txtObservaciones.Clear()
        txtMonto.Clear()
        cboTipo.SelectedIndex   = 0
        cboEstado.SelectedIndex = 0
        dtpInicio.Value      = Date.Today
        dtpVencimiento.Value = Date.Today.AddYears(1)
        btnGuardar.Text    = "💾  Guardar"
        btnCancelar.Visible = False
        txtNumero.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cboProveedor.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim c As New Contrato With {
                .IdProveedor      = Convert.ToInt32(cboProveedor.SelectedValue),
                .NumeroContrato   = txtNumero.Text.Trim(),
                .Descripcion      = txtDescripcion.Text.Trim(),
                .Tipo             = cboTipo.Text,
                .MontoTotal       = Decimal.Parse(txtMonto.Text.Trim()),
                .FechaInicio      = dtpInicio.Value,
                .FechaVencimiento = dtpVencimiento.Value,
                .Estado           = cboEstado.Text,
                .Observaciones    = txtObservaciones.Text.Trim()
            }
            If modoEdicion Then
                c.IdContrato = idSeleccionado
                bl.Actualizar(c)
                MessageBox.Show("Contrato actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(c)
                MessageBox.Show("Contrato registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvContratos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un contrato para editar.", "Aviso")
            Return
        End If
        Dim f = dgvContratos.SelectedRows(0)
        modoEdicion    = True
        idSeleccionado = Convert.ToInt32(f.Cells("IdContrato").Value)
        cboProveedor.SelectedValue = f.Cells("IdProveedor").Value
        txtNumero.Text             = f.Cells("NumeroContrato").Value.ToString()
        txtDescripcion.Text        = f.Cells("Descripcion").Value.ToString()
        cboTipo.Text               = f.Cells("Tipo").Value.ToString()
        txtMonto.Text              = f.Cells("MontoTotal").Value.ToString()
        dtpInicio.Value            = Convert.ToDateTime(f.Cells("FechaInicio").Value)
        dtpVencimiento.Value       = Convert.ToDateTime(f.Cells("FechaVencimiento").Value)
        cboEstado.Text             = f.Cells("Estado").Value.ToString()
        txtObservaciones.Text      = f.Cells("Observaciones").Value.ToString()
        btnGuardar.Text    = "✏️  Actualizar"
        btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvContratos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un contrato para eliminar.", "Aviso")
            Return
        End If
        Dim id = Convert.ToInt32(dgvContratos.SelectedRows(0).Cells("IdContrato").Value)
        If MessageBox.Show("¿Desea eliminar este contrato?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Contrato eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                ModoNuevo()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoNuevo()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim filtro = bl.Listar().FindAll(Function(x) x.NumeroContrato.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.NombreProveedor.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvContratos.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
