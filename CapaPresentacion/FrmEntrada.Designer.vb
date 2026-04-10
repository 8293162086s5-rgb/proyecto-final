<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntrada
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
        Me.lblVisitante = New Label()
        Me.cboVisitante = New ComboBox()
        Me.lblTipo = New Label()
        Me.cboTipo = New ComboBox()
        Me.lblPrecio = New Label()
        Me.txtPrecio = New TextBox()
        Me.lblCantidad = New Label()
        Me.txtCantidad = New TextBox()
        Me.lblFecha = New Label()
        Me.dtpFecha = New DateTimePicker()
        Me.lblMetodoPago = New Label()
        Me.cboMetodoPago = New ComboBox()
        Me.lblObservaciones = New Label()
        Me.txtObservaciones = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvEntradas = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Venta y Control de Entradas"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 400)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblVisitante.Text = "Visitante *" : Me.lblVisitante.Font = labelFont : Me.lblVisitante.Location = New Point(15, 15) : Me.lblVisitante.AutoSize = True
        Me.cboVisitante.Location = New Point(15, 35) : Me.cboVisitante.Size = inputSize : Me.cboVisitante.Font = inputFont : Me.cboVisitante.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblTipo.Text = "Tipo de Entrada *" : Me.lblTipo.Font = labelFont : Me.lblTipo.Location = New Point(255, 15) : Me.lblTipo.AutoSize = True
        Me.cboTipo.Location = New Point(255, 35) : Me.cboTipo.Size = inputSize : Me.cboTipo.Font = inputFont : Me.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblPrecio.Text = "Precio (RD$) *" : Me.lblPrecio.Font = labelFont : Me.lblPrecio.Location = New Point(15, 80) : Me.lblPrecio.AutoSize = True
        Me.txtPrecio.Location = New Point(15, 100) : Me.txtPrecio.Size = inputSize : Me.txtPrecio.Font = inputFont

        Me.lblCantidad.Text = "Cantidad *" : Me.lblCantidad.Font = labelFont : Me.lblCantidad.Location = New Point(255, 80) : Me.lblCantidad.AutoSize = True
        Me.txtCantidad.Location = New Point(255, 100) : Me.txtCantidad.Size = inputSize : Me.txtCantidad.Font = inputFont

        Me.lblFecha.Text = "Fecha de Visita *" : Me.lblFecha.Font = labelFont : Me.lblFecha.Location = New Point(15, 145) : Me.lblFecha.AutoSize = True
        Me.dtpFecha.Location = New Point(15, 165) : Me.dtpFecha.Size = inputSize : Me.dtpFecha.Font = inputFont : Me.dtpFecha.Format = DateTimePickerFormat.Short

        Me.lblMetodoPago.Text = "Metodo de Pago *" : Me.lblMetodoPago.Font = labelFont : Me.lblMetodoPago.Location = New Point(255, 145) : Me.lblMetodoPago.AutoSize = True
        Me.cboMetodoPago.Location = New Point(255, 165) : Me.cboMetodoPago.Size = inputSize : Me.cboMetodoPago.Font = inputFont : Me.cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblObservaciones.Text = "Observaciones" : Me.lblObservaciones.Font = labelFont : Me.lblObservaciones.Location = New Point(15, 210) : Me.lblObservaciones.AutoSize = True
        Me.txtObservaciones.Location = New Point(15, 230) : Me.txtObservaciones.Size = New Size(460, 60) : Me.txtObservaciones.Font = inputFont
        Me.txtObservaciones.Multiline = True : Me.txtObservaciones.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange({Me.lblVisitante, Me.cboVisitante, Me.lblTipo, Me.cboTipo,
                                             Me.lblPrecio, Me.txtPrecio, Me.lblCantidad, Me.txtCantidad,
                                             Me.lblFecha, Me.dtpFecha, Me.lblMetodoPago, Me.cboMetodoPago,
                                             Me.lblObservaciones, Me.txtObservaciones})

        Me.pnlBotones.Location = New Point(10, 475)
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

        Me.btnEliminar.Size = btnSize : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "Anular"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = btnFont : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = btnSize : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = btnFont : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        Me.lblBuscar.Text = "Buscar:" : Me.lblBuscar.Font = labelFont : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inputFont

        Me.dgvEntradas.Location = New Point(520, 125)
        Me.dgvEntradas.Size = New Size(460, 410)
        Me.dgvEntradas.AllowUserToAddRows = False
        Me.dgvEntradas.ReadOnly = True
        Me.dgvEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEntradas.BackgroundColor = Color.White
        Me.dgvEntradas.BorderStyle = BorderStyle.None
        Me.dgvEntradas.RowHeadersVisible = False
        Me.dgvEntradas.Font = New Font("Segoe UI", 9)
        Me.dgvEntradas.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvEntradas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvEntradas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvEntradas.EnableHeadersVisualStyles = False
        Me.dgvEntradas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Me.ClientSize = New Size(1000, 540)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvEntradas})
        Me.Text = "Venta y Control de Entradas"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblVisitante As Label
    Friend WithEvents cboVisitante As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblMetodoPago As Label
    Friend WithEvents cboMetodoPago As ComboBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEntradas As DataGridView

End Class
