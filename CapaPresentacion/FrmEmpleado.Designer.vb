<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        ' --- Controles ---
        Me.pnlTitulo = New Panel()
        Me.lblTitulo = New Label()
        Me.pnlFormulario = New Panel()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblApellido = New Label()
        Me.txtApellido = New TextBox()
        Me.lblCargo = New Label()
        Me.cboCargo = New ComboBox()
        Me.lblFechaIngreso = New Label()
        Me.dtpFechaIngreso = New DateTimePicker()
        Me.lblTelefono = New Label()
        Me.txtTelefono = New TextBox()
        Me.lblEmail = New Label()
        Me.txtEmail = New TextBox()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvEmpleados = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        ' pnlTitulo
        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "👤  Gestión de Empleados"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        ' pnlFormulario
        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 380)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        ' Nombre
        Me.lblNombre.Text = "Nombre *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(15, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(15, 35) : Me.txtNombre.Size = inputSize : Me.txtNombre.Font = inputFont

        ' Apellido
        Me.lblApellido.Text = "Apellido *" : Me.lblApellido.Font = labelFont : Me.lblApellido.Location = New Point(255, 15) : Me.lblApellido.AutoSize = True
        Me.txtApellido.Location = New Point(255, 35) : Me.txtApellido.Size = inputSize : Me.txtApellido.Font = inputFont

        ' Cargo
        Me.lblCargo.Text = "Cargo *" : Me.lblCargo.Font = labelFont : Me.lblCargo.Location = New Point(15, 80) : Me.lblCargo.AutoSize = True
        Me.cboCargo.Location = New Point(15, 100) : Me.cboCargo.Size = inputSize : Me.cboCargo.Font = inputFont : Me.cboCargo.DropDownStyle = ComboBoxStyle.DropDownList

        ' Fecha Ingreso
        Me.lblFechaIngreso.Text = "Fecha de Ingreso *" : Me.lblFechaIngreso.Font = labelFont : Me.lblFechaIngreso.Location = New Point(255, 80) : Me.lblFechaIngreso.AutoSize = True
        Me.dtpFechaIngreso.Location = New Point(255, 100) : Me.dtpFechaIngreso.Size = inputSize : Me.dtpFechaIngreso.Font = inputFont : Me.dtpFechaIngreso.Format = DateTimePickerFormat.Short

        ' Teléfono
        Me.lblTelefono.Text = "Teléfono" : Me.lblTelefono.Font = labelFont : Me.lblTelefono.Location = New Point(15, 145) : Me.lblTelefono.AutoSize = True
        Me.txtTelefono.Location = New Point(15, 165) : Me.txtTelefono.Size = inputSize : Me.txtTelefono.Font = inputFont

        ' Email
        Me.lblEmail.Text = "Email" : Me.lblEmail.Font = labelFont : Me.lblEmail.Location = New Point(255, 145) : Me.lblEmail.AutoSize = True
        Me.txtEmail.Location = New Point(255, 165) : Me.txtEmail.Size = inputSize : Me.txtEmail.Font = inputFont

        ' Estado
        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(15, 210) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(15, 230) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.pnlFormulario.Controls.AddRange({Me.lblNombre, Me.txtNombre, Me.lblApellido, Me.txtApellido,
                                             Me.lblCargo, Me.cboCargo, Me.lblFechaIngreso, Me.dtpFechaIngreso,
                                             Me.lblTelefono, Me.txtTelefono, Me.lblEmail, Me.txtEmail,
                                             Me.lblEstado, Me.cboEstado})

        ' pnlBotones
        Me.pnlBotones.Location = New Point(10, 455)
        Me.pnlBotones.Size = New Size(500, 50)

        Dim btnSize As New Size(90, 38)
        Dim btnFont As New Font("Segoe UI", 9, FontStyle.Bold)

        Me.btnNuevo.Size = btnSize : Me.btnNuevo.Location = New Point(0, 0) : Me.btnNuevo.Text = "➕  Nuevo"
        Me.btnNuevo.BackColor = Color.FromArgb(30, 136, 229) : Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat : Me.btnNuevo.FlatAppearance.BorderSize = 0 : Me.btnNuevo.Font = btnFont : Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Size = btnSize : Me.btnGuardar.Location = New Point(100, 0) : Me.btnGuardar.Text = "💾  Guardar"
        Me.btnGuardar.BackColor = Color.FromArgb(67, 160, 71) : Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat : Me.btnGuardar.FlatAppearance.BorderSize = 0 : Me.btnGuardar.Font = btnFont : Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Size = btnSize : Me.btnEditar.Location = New Point(200, 0) : Me.btnEditar.Text = "✏️  Editar"
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0) : Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat : Me.btnEditar.FlatAppearance.BorderSize = 0 : Me.btnEditar.Font = btnFont : Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Size = btnSize : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "🗑  Eliminar"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = btnFont : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = btnSize : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "❌  Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = btnFont : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        ' Búsqueda
        Me.lblBuscar.Text = "🔍  Buscar:" : Me.lblBuscar.Font = labelFont : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inputFont

        ' DataGridView
        Me.dgvEmpleados.Location = New Point(520, 125)
        Me.dgvEmpleados.Size = New Size(460, 390)
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = Color.White
        Me.dgvEmpleados.BorderStyle = BorderStyle.None
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.Font = New Font("Segoe UI", 9)
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        ' FrmEmpleado
        Me.ClientSize = New Size(1000, 520)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvEmpleados})
        Me.Text = "Gestión de Empleados"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblCargo As Label
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEmpleados As DataGridView

End Class
