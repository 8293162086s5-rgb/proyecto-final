<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo = New Panel()
        Me.lblTitulo = New Label()
        Me.pnlFormulario = New Panel()
        Me.lblEmpleado = New Label()
        Me.cboEmpleado = New ComboBox()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblCodigoInventario = New Label()
        Me.txtCodigoInventario = New TextBox()
        Me.lblCategoria = New Label()
        Me.cboCategoria = New ComboBox()
        Me.lblEpoca = New Label()
        Me.txtEpoca = New TextBox()
        Me.lblMaterial = New Label()
        Me.txtMaterial = New TextBox()
        Me.lblUbicacion = New Label()
        Me.txtUbicacion = New TextBox()
        Me.lblValorEstimado = New Label()
        Me.txtValorEstimado = New TextBox()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
        Me.lblFechaIngreso = New Label()
        Me.dtpFechaIngreso = New DateTimePicker()
        Me.lblDescripcion = New Label()
        Me.txtDescripcion = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvInventario = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Control de Inventario"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 560)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblEmpleado.Text = "Empleado Responsable *" : Me.lblEmpleado.Font = labelFont : Me.lblEmpleado.Location = New Point(15, 15) : Me.lblEmpleado.AutoSize = True
        Me.cboEmpleado.Location = New Point(15, 35) : Me.cboEmpleado.Size = inputSize : Me.cboEmpleado.Font = inputFont : Me.cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblNombre.Text = "Nombre del Objeto *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(255, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(255, 35) : Me.txtNombre.Size = inputSize : Me.txtNombre.Font = inputFont

        Me.lblCodigoInventario.Text = "Codigo de Inventario *" : Me.lblCodigoInventario.Font = labelFont : Me.lblCodigoInventario.Location = New Point(15, 80) : Me.lblCodigoInventario.AutoSize = True
        Me.txtCodigoInventario.Location = New Point(15, 100) : Me.txtCodigoInventario.Size = inputSize : Me.txtCodigoInventario.Font = inputFont

        Me.lblCategoria.Text = "Categoria *" : Me.lblCategoria.Font = labelFont : Me.lblCategoria.Location = New Point(255, 80) : Me.lblCategoria.AutoSize = True
        Me.cboCategoria.Location = New Point(255, 100) : Me.cboCategoria.Size = inputSize : Me.cboCategoria.Font = inputFont : Me.cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEpoca.Text = "Epoca / Periodo" : Me.lblEpoca.Font = labelFont : Me.lblEpoca.Location = New Point(15, 145) : Me.lblEpoca.AutoSize = True
        Me.txtEpoca.Location = New Point(15, 165) : Me.txtEpoca.Size = inputSize : Me.txtEpoca.Font = inputFont

        Me.lblMaterial.Text = "Material" : Me.lblMaterial.Font = labelFont : Me.lblMaterial.Location = New Point(255, 145) : Me.lblMaterial.AutoSize = True
        Me.txtMaterial.Location = New Point(255, 165) : Me.txtMaterial.Size = inputSize : Me.txtMaterial.Font = inputFont

        Me.lblUbicacion.Text = "Ubicacion en Museo *" : Me.lblUbicacion.Font = labelFont : Me.lblUbicacion.Location = New Point(15, 210) : Me.lblUbicacion.AutoSize = True
        Me.txtUbicacion.Location = New Point(15, 230) : Me.txtUbicacion.Size = inputSize : Me.txtUbicacion.Font = inputFont

        Me.lblValorEstimado.Text = "Valor Estimado (RD$)" : Me.lblValorEstimado.Font = labelFont : Me.lblValorEstimado.Location = New Point(255, 210) : Me.lblValorEstimado.AutoSize = True
        Me.txtValorEstimado.Location = New Point(255, 230) : Me.txtValorEstimado.Size = inputSize : Me.txtValorEstimado.Font = inputFont

        Me.lblEstado.Text = "Estado de Conservacion *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(15, 275) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(15, 295) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblFechaIngreso.Text = "Fecha de Ingreso *" : Me.lblFechaIngreso.Font = labelFont : Me.lblFechaIngreso.Location = New Point(255, 275) : Me.lblFechaIngreso.AutoSize = True
        Me.dtpFechaIngreso.Location = New Point(255, 295) : Me.dtpFechaIngreso.Size = inputSize : Me.dtpFechaIngreso.Font = inputFont : Me.dtpFechaIngreso.Format = DateTimePickerFormat.Short

        Me.lblDescripcion.Text = "Descripcion" : Me.lblDescripcion.Font = labelFont : Me.lblDescripcion.Location = New Point(15, 340) : Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 360) : Me.txtDescripcion.Size = New Size(460, 130) : Me.txtDescripcion.Font = inputFont
        Me.txtDescripcion.Multiline = True : Me.txtDescripcion.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange({Me.lblEmpleado, Me.cboEmpleado, Me.lblNombre, Me.txtNombre,
                                             Me.lblCodigoInventario, Me.txtCodigoInventario, Me.lblCategoria, Me.cboCategoria,
                                             Me.lblEpoca, Me.txtEpoca, Me.lblMaterial, Me.txtMaterial,
                                             Me.lblUbicacion, Me.txtUbicacion, Me.lblValorEstimado, Me.txtValorEstimado,
                                             Me.lblEstado, Me.cboEstado, Me.lblFechaIngreso, Me.dtpFechaIngreso,
                                             Me.lblDescripcion, Me.txtDescripcion})

        Me.pnlBotones.Location = New Point(10, 635)
        Me.pnlBotones.Size = New Size(500, 50)

        Dim btnSize As New Size(90, 38)
        Dim btnFont As New Font("Segoe UI", 9, FontStyle.Bold)

        Me.btnNuevo.Size = btnSize : Me.btnNuevo.Location = New Point(0, 0) : Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.BackColor = Color.FromArgb(30, 136, 229) : Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat : Me.btnNuevo.FlatAppearance.BorderSize = 0 : Me.btnNuevo.Font = btnFont : Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Size = btnSize : Me.btnGuardar.Location = New Point(100, 0) : Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.BackColor = Color.FromArgb(67, 160, 71) : Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat : Me.btnGuardar.FlatAppearance.BorderSize = 0 : Me.btnGuardar.Font = btnFont : Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Size = btnSize : Me.btnEditar.Location = New Point(200, 0) : Me.btnEditar.Text = "Editar"
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0) : Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat : Me.btnEditar.FlatAppearance.BorderSize = 0 : Me.btnEditar.Font = btnFont : Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Size = btnSize : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "Dar Baja"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = btnFont : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = btnSize : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = btnFont : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        Me.lblBuscar.Text = "Buscar:" : Me.lblBuscar.Font = labelFont : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inputFont

        Me.dgvInventario.Location = New Point(520, 125)
        Me.dgvInventario.Size = New Size(460, 560)
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventario.BackgroundColor = Color.White
        Me.dgvInventario.BorderStyle = BorderStyle.None
        Me.dgvInventario.RowHeadersVisible = False
        Me.dgvInventario.Font = New Font("Segoe UI", 9)
        Me.dgvInventario.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvInventario.EnableHeadersVisualStyles = False
        Me.dgvInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Me.ClientSize = New Size(1000, 700)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvInventario})
        Me.Text = "Control de Inventario"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCodigoInventario As Label
    Friend WithEvents txtCodigoInventario As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents lblEpoca As Label
    Friend WithEvents txtEpoca As TextBox
    Friend WithEvents lblMaterial As Label
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents lblValorEstimado As Label
    Friend WithEvents txtValorEstimado As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvInventario As DataGridView

End Class
