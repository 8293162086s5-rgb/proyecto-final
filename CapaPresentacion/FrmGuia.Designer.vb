<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGuia
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
        Me.pnlTitulo     = New Panel()
        Me.lblTitulo     = New Label()
        Me.pnlFormulario = New Panel()
        Me.lblNombre     = New Label()
        Me.txtNombre     = New TextBox()
        Me.lblApellido   = New Label()
        Me.txtApellido   = New TextBox()
        Me.lblTelefono   = New Label()
        Me.txtTelefono   = New TextBox()
        Me.lblEmail      = New Label()
        Me.txtEmail      = New TextBox()
        Me.lblIdioma     = New Label()
        Me.cboIdioma     = New ComboBox()
        Me.lblEstado     = New Label()
        Me.cboEstado     = New ComboBox()
        Me.lblEmpleado   = New Label()
        Me.cboEmpleado   = New ComboBox()
        Me.pnlBotones    = New Panel()
        Me.btnNuevo      = New Button()
        Me.btnGuardar    = New Button()
        Me.btnEditar     = New Button()
        Me.btnEliminar   = New Button()
        Me.btnCancelar   = New Button()
        Me.lblBuscar     = New Label()
        Me.txtBuscar     = New TextBox()
        Me.dgvGuias      = New DataGridView()
        Me.SuspendLayout()

        Dim lf As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inf As New Font("Segoe UI", 10)
        Dim is_ As New Size(220, 28)
        Dim iw  As New Size(460, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(67, 160, 71)
        Me.pnlTitulo.Dock = DockStyle.Top : Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.lblTitulo.Text = "🧭  Gestión de Guías" : Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White : Me.lblTitulo.Location = New Point(15, 12) : Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65) : Me.pnlFormulario.Size = New Size(500, 400)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle : Me.pnlFormulario.BackColor = Color.White

        Me.lblNombre.Text = "Nombre *" : Me.lblNombre.Font = lf : Me.lblNombre.Location = New Point(15, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(15, 35) : Me.txtNombre.Size = is_ : Me.txtNombre.Font = inf

        Me.lblApellido.Text = "Apellido *" : Me.lblApellido.Font = lf : Me.lblApellido.Location = New Point(255, 15) : Me.lblApellido.AutoSize = True
        Me.txtApellido.Location = New Point(255, 35) : Me.txtApellido.Size = is_ : Me.txtApellido.Font = inf

        Me.lblTelefono.Text = "Teléfono" : Me.lblTelefono.Font = lf : Me.lblTelefono.Location = New Point(15, 80) : Me.lblTelefono.AutoSize = True
        Me.txtTelefono.Location = New Point(15, 100) : Me.txtTelefono.Size = is_ : Me.txtTelefono.Font = inf

        Me.lblEmail.Text = "Email" : Me.lblEmail.Font = lf : Me.lblEmail.Location = New Point(255, 80) : Me.lblEmail.AutoSize = True
        Me.txtEmail.Location = New Point(255, 100) : Me.txtEmail.Size = is_ : Me.txtEmail.Font = inf

        Me.lblIdioma.Text = "Idioma *" : Me.lblIdioma.Font = lf : Me.lblIdioma.Location = New Point(15, 145) : Me.lblIdioma.AutoSize = True
        Me.cboIdioma.Location = New Point(15, 165) : Me.cboIdioma.Size = is_ : Me.cboIdioma.Font = inf : Me.cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = lf : Me.lblEstado.Location = New Point(255, 145) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 165) : Me.cboEstado.Size = is_ : Me.cboEstado.Font = inf : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEmpleado.Text = "Empleado asociado" : Me.lblEmpleado.Font = lf : Me.lblEmpleado.Location = New Point(15, 215) : Me.lblEmpleado.AutoSize = True
        Me.cboEmpleado.Location = New Point(15, 235) : Me.cboEmpleado.Size = iw : Me.cboEmpleado.Font = inf : Me.cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.pnlFormulario.Controls.AddRange({Me.lblNombre, Me.txtNombre, Me.lblApellido, Me.txtApellido,
            Me.lblTelefono, Me.txtTelefono, Me.lblEmail, Me.txtEmail,
            Me.lblIdioma, Me.cboIdioma, Me.lblEstado, Me.cboEstado,
            Me.lblEmpleado, Me.cboEmpleado})

        Me.pnlBotones.Location = New Point(10, 475) : Me.pnlBotones.Size = New Size(500, 50)
        Dim bs As New Size(90, 38) : Dim bf As New Font("Segoe UI", 9, FontStyle.Bold)

        Me.btnNuevo.Size = bs : Me.btnNuevo.Location = New Point(0, 0) : Me.btnNuevo.Text = "➕  Nuevo"
        Me.btnNuevo.BackColor = Color.FromArgb(30, 136, 229) : Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat : Me.btnNuevo.FlatAppearance.BorderSize = 0 : Me.btnNuevo.Font = bf : Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Size = bs : Me.btnGuardar.Location = New Point(100, 0) : Me.btnGuardar.Text = "💾  Guardar"
        Me.btnGuardar.BackColor = Color.FromArgb(67, 160, 71) : Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat : Me.btnGuardar.FlatAppearance.BorderSize = 0 : Me.btnGuardar.Font = bf : Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Size = bs : Me.btnEditar.Location = New Point(200, 0) : Me.btnEditar.Text = "✏️  Editar"
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0) : Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat : Me.btnEditar.FlatAppearance.BorderSize = 0 : Me.btnEditar.Font = bf : Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Size = bs : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "🗑  Eliminar"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = bf : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = bs : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "❌  Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = bf : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False
        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        Me.lblBuscar.Text = "🔍  Buscar:" : Me.lblBuscar.Font = lf : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inf

        Me.dgvGuias.Location = New Point(520, 125) : Me.dgvGuias.Size = New Size(460, 400)
        Me.dgvGuias.AllowUserToAddRows = False : Me.dgvGuias.ReadOnly = True
        Me.dgvGuias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuias.BackgroundColor = Color.White : Me.dgvGuias.BorderStyle = BorderStyle.None
        Me.dgvGuias.RowHeadersVisible = False : Me.dgvGuias.Font = New Font("Segoe UI", 9)
        Me.dgvGuias.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvGuias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 160, 71)
        Me.dgvGuias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvGuias.EnableHeadersVisualStyles = False
        Me.dgvGuias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240)

        Me.ClientSize = New Size(1000, 545)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvGuias})
        Me.Text = "Gestión de Guías" : Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo     As Panel
    Friend WithEvents lblTitulo     As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblNombre     As Label
    Friend WithEvents txtNombre     As TextBox
    Friend WithEvents lblApellido   As Label
    Friend WithEvents txtApellido   As TextBox
    Friend WithEvents lblTelefono   As Label
    Friend WithEvents txtTelefono   As TextBox
    Friend WithEvents lblEmail      As Label
    Friend WithEvents txtEmail      As TextBox
    Friend WithEvents lblIdioma     As Label
    Friend WithEvents cboIdioma     As ComboBox
    Friend WithEvents lblEstado     As Label
    Friend WithEvents cboEstado     As ComboBox
    Friend WithEvents lblEmpleado   As Label
    Friend WithEvents cboEmpleado   As ComboBox
    Friend WithEvents pnlBotones    As Panel
    Friend WithEvents btnNuevo      As Button
    Friend WithEvents btnGuardar    As Button
    Friend WithEvents btnEditar     As Button
    Friend WithEvents btnEliminar   As Button
    Friend WithEvents btnCancelar   As Button
    Friend WithEvents lblBuscar     As Label
    Friend WithEvents txtBuscar     As TextBox
    Friend WithEvents dgvGuias      As DataGridView
End Class
