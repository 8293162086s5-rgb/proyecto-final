<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProveedor
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
        Me.lblRazonSocial   = New Label()
        Me.txtRazonSocial   = New TextBox()
        Me.lblRNC           = New Label()
        Me.txtRNC           = New TextBox()
        Me.lblContacto      = New Label()
        Me.txtContacto      = New TextBox()
        Me.lblTelefono      = New Label()
        Me.txtTelefono      = New TextBox()
        Me.lblEmail         = New Label()
        Me.txtEmail         = New TextBox()
        Me.lblDireccion     = New Label()
        Me.txtDireccion     = New TextBox()
        Me.lblCategoria     = New Label()
        Me.cboCategoria     = New ComboBox()
        Me.lblEstado        = New Label()
        Me.cboEstado        = New ComboBox()
        Me.lblFechaRegistro = New Label()
        Me.dtpFechaRegistro = New DateTimePicker()
        Me.btnNuevo         = New Button()
        Me.btnGuardar       = New Button()
        Me.btnEditar        = New Button()
        Me.btnEliminar      = New Button()
        Me.btnCancelar      = New Button()
        Me.lblBuscar        = New Label()
        Me.txtBuscar        = New TextBox()
        Me.dgvProveedores   = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)
        Dim iW As New Size(460, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(63, 81, 181)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.lblTitulo.Text = "🏢  Gestión de Proveedores"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 560)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblRazonSocial.Text = "Razón Social *"
        Me.lblRazonSocial.Font = labelFont
        Me.lblRazonSocial.Location = New Point(15, 15)
        Me.lblRazonSocial.AutoSize = True
        Me.txtRazonSocial.Location = New Point(15, 35)
        Me.txtRazonSocial.Size = iW
        Me.txtRazonSocial.Font = inputFont

        Me.lblRNC.Text = "RNC"
        Me.lblRNC.Font = labelFont
        Me.lblRNC.Location = New Point(15, 80)
        Me.lblRNC.AutoSize = True
        Me.txtRNC.Location = New Point(15, 100)
        Me.txtRNC.Size = inputSize
        Me.txtRNC.Font = inputFont

        Me.lblContacto.Text = "Contacto"
        Me.lblContacto.Font = labelFont
        Me.lblContacto.Location = New Point(255, 80)
        Me.lblContacto.AutoSize = True
        Me.txtContacto.Location = New Point(255, 100)
        Me.txtContacto.Size = inputSize
        Me.txtContacto.Font = inputFont

        Me.lblTelefono.Text = "Teléfono"
        Me.lblTelefono.Font = labelFont
        Me.lblTelefono.Location = New Point(15, 145)
        Me.lblTelefono.AutoSize = True
        Me.txtTelefono.Location = New Point(15, 165)
        Me.txtTelefono.Size = inputSize
        Me.txtTelefono.Font = inputFont

        Me.lblEmail.Text = "Correo Electrónico"
        Me.lblEmail.Font = labelFont
        Me.lblEmail.Location = New Point(255, 145)
        Me.lblEmail.AutoSize = True
        Me.txtEmail.Location = New Point(255, 165)
        Me.txtEmail.Size = inputSize
        Me.txtEmail.Font = inputFont

        Me.lblDireccion.Text = "Dirección"
        Me.lblDireccion.Font = labelFont
        Me.lblDireccion.Location = New Point(15, 210)
        Me.lblDireccion.AutoSize = True
        Me.txtDireccion.Location = New Point(15, 230)
        Me.txtDireccion.Size = iW
        Me.txtDireccion.Font = inputFont

        Me.lblCategoria.Text = "Categoría *"
        Me.lblCategoria.Font = labelFont
        Me.lblCategoria.Location = New Point(15, 275)
        Me.lblCategoria.AutoSize = True
        Me.cboCategoria.Location = New Point(15, 295)
        Me.cboCategoria.Size = inputSize
        Me.cboCategoria.Font = inputFont
        Me.cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Font = labelFont
        Me.lblEstado.Location = New Point(255, 275)
        Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 295)
        Me.cboEstado.Size = inputSize
        Me.cboEstado.Font = inputFont
        Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblFechaRegistro.Text = "Fecha de Registro"
        Me.lblFechaRegistro.Font = labelFont
        Me.lblFechaRegistro.Location = New Point(15, 340)
        Me.lblFechaRegistro.AutoSize = True
        Me.dtpFechaRegistro.Location = New Point(15, 360)
        Me.dtpFechaRegistro.Size = iW
        Me.dtpFechaRegistro.Font = inputFont
        Me.dtpFechaRegistro.Format = DateTimePickerFormat.Short

        Me.pnlFormulario.Controls.AddRange(New Control() {
            Me.lblRazonSocial, Me.txtRazonSocial,
            Me.lblRNC, Me.txtRNC,
            Me.lblContacto, Me.txtContacto,
            Me.lblTelefono, Me.txtTelefono,
            Me.lblEmail, Me.txtEmail,
            Me.lblDireccion, Me.txtDireccion,
            Me.lblCategoria, Me.cboCategoria,
            Me.lblEstado, Me.cboEstado,
            Me.lblFechaRegistro, Me.dtpFechaRegistro})

        Me.btnNuevo.Text = "➕  Nuevo"
        Me.btnNuevo.Location = New Point(10, 635)
        Me.btnNuevo.Size = New Size(170, 38)
        Me.btnNuevo.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnNuevo.BackColor = Color.FromArgb(67, 160, 71)
        Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Text = "💾  Guardar"
        Me.btnGuardar.Location = New Point(190, 635)
        Me.btnGuardar.Size = New Size(170, 38)
        Me.btnGuardar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnGuardar.BackColor = Color.FromArgb(30, 136, 229)
        Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Text = "✏️  Editar"
        Me.btnEditar.Location = New Point(10, 683)
        Me.btnEditar.Size = New Size(170, 38)
        Me.btnEditar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0)
        Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Text = "🗑  Eliminar"
        Me.btnEliminar.Location = New Point(190, 683)
        Me.btnEliminar.Size = New Size(170, 38)
        Me.btnEliminar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Text = "✖  Cancelar"
        Me.btnCancelar.Location = New Point(10, 731)
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

        Me.dgvProveedores.Location = New Point(520, 125)
        Me.dgvProveedores.Size = New Size(460, 650)
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.BackgroundColor = Color.White
        Me.dgvProveedores.BorderStyle = BorderStyle.None
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.Font = New Font("Segoe UI", 9)
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181)
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 255)

        Me.ClientSize = New Size(1000, 790)
        Me.Controls.AddRange(New Control() {
            Me.pnlTitulo, Me.pnlFormulario,
            Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar,
            Me.lblBuscar, Me.txtBuscar, Me.dgvProveedores})
        Me.Text = "Gestión de Proveedores"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo        As Panel
    Friend WithEvents lblTitulo        As Label
    Friend WithEvents pnlFormulario    As Panel
    Friend WithEvents lblRazonSocial   As Label
    Friend WithEvents txtRazonSocial   As TextBox
    Friend WithEvents lblRNC           As Label
    Friend WithEvents txtRNC           As TextBox
    Friend WithEvents lblContacto      As Label
    Friend WithEvents txtContacto      As TextBox
    Friend WithEvents lblTelefono      As Label
    Friend WithEvents txtTelefono      As TextBox
    Friend WithEvents lblEmail         As Label
    Friend WithEvents txtEmail         As TextBox
    Friend WithEvents lblDireccion     As Label
    Friend WithEvents txtDireccion     As TextBox
    Friend WithEvents lblCategoria     As Label
    Friend WithEvents cboCategoria     As ComboBox
    Friend WithEvents lblEstado        As Label
    Friend WithEvents cboEstado        As ComboBox
    Friend WithEvents lblFechaRegistro As Label
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents btnNuevo         As Button
    Friend WithEvents btnGuardar       As Button
    Friend WithEvents btnEditar        As Button
    Friend WithEvents btnEliminar      As Button
    Friend WithEvents btnCancelar      As Button
    Friend WithEvents lblBuscar        As Label
    Friend WithEvents txtBuscar        As TextBox
    Friend WithEvents dgvProveedores   As DataGridView

End Class
