Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmMantenimiento
    Dim bl         As New MantenimientoBL()
    Dim blEmpleado As New EmpleadoBL()
    Dim blSala     As New SalaBL()
    Dim modoEdicion    As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpleados() : CargarSalas() : CargarTipos() : CargarEstados() : CargarTabla() : ModoNuevo()
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

    Private Sub CargarSalas()
        Try
            Dim lista = blSala.Listar()
            cboSala.DataSource    = lista
            cboSala.DisplayMember = "Nombre"
            cboSala.ValueMember   = "IdSala"
            cboSala.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar salas: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarTipos()
        cboTipo.Items.Clear()
        cboTipo.Items.AddRange({"Preventivo", "Correctivo", "Emergencia"})
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange({"Pendiente", "En Proceso", "Completado", "Cancelado"})
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvMantenimiento.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar mantenimientos: " & ex.Message)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False : idSeleccionado = 0
        txtDescripcion.Clear() : txtCosto.Clear() : txtObservaciones.Clear()
        cboTipo.SelectedIndex = 0 : cboEstado.SelectedIndex = 0
        cboEmpleado.SelectedIndex = -1 : cboSala.SelectedIndex = -1
        dtpInicio.Value = Date.Today : dtpFin.Value = Date.Today
        btnGuardar.Text = "💾  Guardar" : btnCancelar.Visible = False
        txtDescripcion.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim m As New Mantenimiento With {
                .TipoMantenimiento = cboTipo.Text,
                .Descripcion       = txtDescripcion.Text.Trim(),
                .FechaInicio       = dtpInicio.Value,
                .FechaFin          = dtpFin.Value,
                .Costo             = Decimal.Parse(If(String.IsNullOrWhiteSpace(txtCosto.Text), "0", txtCosto.Text.Trim())),
                .Estado            = cboEstado.Text,
                .Observaciones     = txtObservaciones.Text.Trim(),
                .IdEmpleado        = If(cboEmpleado.SelectedIndex >= 0, Convert.ToInt32(cboEmpleado.SelectedValue), 0),
                .IdSala            = If(cboSala.SelectedIndex >= 0,     Convert.ToInt32(cboSala.SelectedValue),     0)
            }
            If modoEdicion Then
                m.IdMantenimiento = idSeleccionado
                bl.Actualizar(m)
                MessageBox.Show("Mantenimiento actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(m)
                MessageBox.Show("Mantenimiento registrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla() : ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvMantenimiento.SelectedRows.Count = 0 Then MessageBox.Show("Seleccione un registro.") : Return
        Dim f = dgvMantenimiento.SelectedRows(0)
        modoEdicion = True : idSeleccionado = Convert.ToInt32(f.Cells("IdMantenimiento").Value)
        cboTipo.Text          = f.Cells("TipoMantenimiento").Value.ToString()
        txtDescripcion.Text   = f.Cells("Descripcion").Value.ToString()
        dtpInicio.Value       = Convert.ToDateTime(f.Cells("FechaInicio").Value)
        dtpFin.Value          = Convert.ToDateTime(f.Cells("FechaFin").Value)
        txtCosto.Text         = f.Cells("Costo").Value.ToString()
        cboEstado.Text        = f.Cells("Estado").Value.ToString()
        txtObservaciones.Text = f.Cells("Observaciones").Value.ToString()
        Dim idEmp = f.Cells("IdEmpleado").Value
        If idEmp IsNot DBNull.Value AndAlso Convert.ToInt32(idEmp) > 0 Then cboEmpleado.SelectedValue = Convert.ToInt32(idEmp) Else cboEmpleado.SelectedIndex = -1
        Dim idSala = f.Cells("IdSala").Value
        If idSala IsNot DBNull.Value AndAlso Convert.ToInt32(idSala) > 0 Then cboSala.SelectedValue = Convert.ToInt32(idSala) Else cboSala.SelectedIndex = -1
        btnGuardar.Text = "✏️  Actualizar" : btnCancelar.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvMantenimiento.SelectedRows.Count = 0 Then MessageBox.Show("Seleccione un registro.") : Return
        Dim id = Convert.ToInt32(dgvMantenimiento.SelectedRows(0).Cells("IdMantenimiento").Value)
        If MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            dgvMantenimiento.DataSource = bl.Listar().FindAll(Function(x)
                Return x.Descripcion.ToLower.Contains(txtBuscar.Text.ToLower) OrElse
                x.NombreSala.ToLower.Contains(txtBuscar.Text.ToLower) OrElse
                x.NombreEmpleado.ToLower.Contains(txtBuscar.Text.ToLower)
            End Function)
        Catch : End Try
    End Sub
End Class
