<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContrato
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
        Me.pnlTitulo        = New Panel()
        Me.lblTitulo        = New Label()
        Me.pnlFormulario    = New Panel()
        Me.lblProveedor     = New Label()
        Me.cboProveedor     = New ComboBox()
        Me.lblNumero        = New Label()
        Me.txtNumero        = New TextBox()
        Me.lblTipo          = New Label()
        Me.cboTipo          = New ComboBox()
        Me.lblMonto         = New Label()
        Me.txtMonto         = New TextBox()
        Me.lblEstado        = New Label()
        Me.cboEstado        = New ComboBox()
        Me.lblInicio        = New Label()
        Me.dtpInicio        = New DateTimePicker()
        Me.lblVencimiento   = New Label()
        Me.dtpVencimiento   = New DateTimePicker()
        Me.lblDescripcion   = New Label()
        Me.txtDescripcion   = New TextBox()
        Me.lblObservaciones = New Label()
        Me.txtObservaciones = New TextBox()
        Me.btnNuevo         = New Button()
        Me.btnGuardar       = New Button()
        Me.btnEditar        = New Button()
        Me.btnEliminar      = New Button()
        Me.btnCancelar      = New Button()
        Me.lblBuscar        = New Label()
        Me.txtBuscar        = New TextBox()
        Me.dgvContratos     = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(0, 131, 143)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.lblTitulo.Text = "📄  Gestión de Contratos"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 490)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblProveedor.Text = "Proveedor *"
        Me.lblProveedor.Font = labelFont
        Me.lblProveedor.Location = New Point(15, 15)
        Me.lblProveedor.AutoSize = True
        Me.cboProveedor.Location = New Point(15, 35)
        Me.cboProveedor.Size = New Size(460, 28)
        Me.cboProveedor.Font = inputFont
        Me.cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblNumero.Text = "Número de Contrato *"
        Me.lblNumero.Font = labelFont
        Me.lblNumero.Location = New Point(15, 80)
        Me.lblNumero.AutoSize = True
        Me.txtNumero.Location = New Point(15, 100)
        Me.txtNumero.Size = inputSize
        Me.txtNumero.Font = inputFont

        Me.lblTipo.Text = "Tipo *"
        Me.lblTipo.Font = labelFont
        Me.lblTipo.Location = New Point(255, 80)
        Me.lblTipo.AutoSize = True
        Me.cboTipo.Location = New Point(255, 100)
        Me.cboTipo.Size = inputSize
        Me.cboTipo.Font = inputFont
        Me.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblMonto.Text = "Monto Total (RD$) *"
        Me.lblMonto.Font = labelFont
        Me.lblMonto.Location = New Point(15, 145)
        Me.lblMonto.AutoSize = True
        Me.txtMonto.Location = New Point(15, 165)
        Me.txtMonto.Size = inputSize
        Me.txtMonto.Font = inputFont

        Me.lblEstado.Text = "Estado *"
        Me.lblEstado.Font = labelFont
        Me.lblEstado.Location = New Point(255, 145)
        Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 165)
        Me.cboEstado.Size = inputSize
        Me.cboEstado.Font = inputFont
        Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblInicio.Text = "Fecha Inicio *"
        Me.lblInicio.Font = labelFont
        Me.lblInicio.Location = New Point(15, 210)
        Me.lblInicio.AutoSize = True
        Me.dtpInicio.Location = New Point(15, 230)
        Me.dtpInicio.Size = inputSize
        Me.dtpInicio.Font = inputFont
        Me.dtpInicio.Format = DateTimePickerFormat.Short

        Me.lblVencimiento.Text = "Fecha Vencimiento *"
        Me.lblVencimiento.Font = labelFont
        Me.lblVencimiento.Location = New Point(255, 210)
        Me.lblVencimiento.AutoSize = True
        Me.dtpVencimiento.Location = New Point(255, 230)
        Me.dtpVencimiento.Size = inputSize
        Me.dtpVencimiento.Font = inputFont
        Me.dtpVencimiento.Format = DateTimePickerFormat.Short

        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Font = labelFont
        Me.lblDescripcion.Location = New Point(15, 275)
        Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 295)
        Me.txtDescripcion.Size = New Size(460, 55)
        Me.txtDescripcion.Font = inputFont
        Me.txtDescripcion.Multiline = True

        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.Font = labelFont
        Me.lblObservaciones.Location = New Point(15, 365)
        Me.lblObservaciones.AutoSize = True
        Me.txtObservaciones.Location = New Point(15, 385)
        Me.txtObservaciones.Size = New Size(460, 55)
        Me.txtObservaciones.Font = inputFont
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange(New Control() { _
            Me.lblProveedor, Me.cboProveedor, _
            Me.lblNumero, Me.txtNumero, _
            Me.lblTipo, Me.cboTipo, _
            Me.lblMonto, Me.txtMonto, _
            Me.lblEstado, Me.cboEstado, _
            Me.lblInicio, Me.dtpInicio, _
            Me.lblVencimiento, Me.dtpVencimiento, _
            Me.lblDescripcion, Me.txtDescripcion, _
            Me.lblObservaciones, Me.txtObservaciones})

        Me.btnNuevo.Text = "➕  Nuevo"
        Me.btnNuevo.Location = New Point(10, 565)
        Me.btnNuevo.Size = New Size(170, 38)
        Me.btnNuevo.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnNuevo.BackColor = Color.FromArgb(67, 160, 71)
        Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Text = "💾  Guardar"
        Me.btnGuardar.Location = New Point(190, 565)
        Me.btnGuardar.Size = New Size(170, 38)
        Me.btnGuardar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnGuardar.BackColor = Color.FromArgb(30, 136, 229)
        Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Text = "✏️  Editar"
        Me.btnEditar.Location = New Point(10, 613)
        Me.btnEditar.Size = New Size(170, 38)
        Me.btnEditar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0)
        Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Text = "🗑  Eliminar"
        Me.btnEliminar.Location = New Point(190, 613)
        Me.btnEliminar.Size = New Size(170, 38)
        Me.btnEliminar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Text = "✖  Cancelar"
        Me.btnCancelar.Location = New Point(10, 661)
        Me.btnCancelar.Size = New Size(350, 38)
        Me.btnCancelar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnCancelar.BackColor = Color.Gray
        Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.lblBuscar.Text = "🔍  Buscar:"
        Me.lblBuscar.Font = labelFont
        Me.lblBuscar.Location = New Point(520, 70)
        Me.lblBuscar.AutoSize = True

        Me.txtBuscar.Location = New Point(520, 90)
        Me.txtBuscar.Size = New Size(460, 28)
        Me.txtBuscar.Font = inputFont

        Me.dgvContratos.Location = New Point(520, 125)
        Me.dgvContratos.Size = New Size(460, 580)
        Me.dgvContratos.AllowUserToAddRows = False
        Me.dgvContratos.ReadOnly = True
        Me.dgvContratos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContratos.BackgroundColor = Color.White
        Me.dgvContratos.BorderStyle = BorderStyle.None
        Me.dgvContratos.RowHeadersVisible = False
        Me.dgvContratos.Font = New Font("Segoe UI", 9)
        Me.dgvContratos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvContratos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 131, 143)
        Me.dgvContratos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvContratos.EnableHeadersVisualStyles = False
        Me.dgvContratos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255)

        Me.ClientSize = New Size(1000, 720)
        Me.Controls.AddRange(New Control() { _
            Me.pnlTitulo, Me.pnlFormulario, _
            Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar, _
            Me.lblBuscar, Me.txtBuscar, Me.dgvContratos})
        Me.Text = "Gestión de Contratos"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo        As Panel
    Friend WithEvents lblTitulo        As Label
    Friend WithEvents pnlFormulario    As Panel
    Friend WithEvents lblProveedor     As Label
    Friend WithEvents cboProveedor     As ComboBox
    Friend WithEvents lblNumero        As Label
    Friend WithEvents txtNumero        As TextBox
    Friend WithEvents lblDescripcion   As Label
    Friend WithEvents txtDescripcion   As TextBox
    Friend WithEvents lblTipo          As Label
    Friend WithEvents cboTipo          As ComboBox
    Friend WithEvents lblMonto         As Label
    Friend WithEvents txtMonto         As TextBox
    Friend WithEvents lblInicio        As Label
    Friend WithEvents dtpInicio        As DateTimePicker
    Friend WithEvents lblVencimiento   As Label
    Friend WithEvents dtpVencimiento   As DateTimePicker
    Friend WithEvents lblEstado        As Label
    Friend WithEvents cboEstado        As ComboBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btnNuevo         As Button
    Friend WithEvents btnGuardar       As Button
    Friend WithEvents btnEditar        As Button
    Friend WithEvents btnEliminar      As Button
    Friend WithEvents btnCancelar      As Button
    Friend WithEvents lblBuscar        As Label
    Friend WithEvents txtBuscar        As TextBox
    Friend WithEvents dgvContratos     As DataGridView

End Class
