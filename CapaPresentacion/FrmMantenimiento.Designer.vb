<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimiento
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
        Me.lblTipo          = New Label()
        Me.cboTipo          = New ComboBox()
        Me.lblDescripcion   = New Label()
        Me.txtDescripcion   = New TextBox()
        Me.lblEmpleado      = New Label()
        Me.cboEmpleado      = New ComboBox()
        Me.lblSala          = New Label()
        Me.cboSala          = New ComboBox()
        Me.lblInicio        = New Label()
        Me.dtpInicio        = New DateTimePicker()
        Me.lblFin           = New Label()
        Me.dtpFin           = New DateTimePicker()
        Me.lblCosto         = New Label()
        Me.txtCosto         = New TextBox()
        Me.lblEstado        = New Label()
        Me.cboEstado        = New ComboBox()
        Me.lblObservaciones = New Label()
        Me.txtObservaciones = New TextBox()
        Me.btnNuevo         = New Button()
        Me.btnGuardar       = New Button()
        Me.btnEditar        = New Button()
        Me.btnEliminar      = New Button()
        Me.btnCancelar      = New Button()
        Me.lblBuscar        = New Label()
        Me.txtBuscar        = New TextBox()
        Me.dgvMantenimiento = New DataGridView()
        Me.SuspendLayout()

        Dim lf  As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inf As New Font("Segoe UI", 10)
        Dim is_ As New Size(220, 28)
        Dim iw  As New Size(460, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(121, 85, 72)
        Me.pnlTitulo.Dock = DockStyle.Top : Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.lblTitulo.Text = "🔧  Gestión de Mantenimiento" : Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White : Me.lblTitulo.Location = New Point(15, 12) : Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65) : Me.pnlFormulario.Size = New Size(500, 510)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle : Me.pnlFormulario.BackColor = Color.White

        Me.lblTipo.Text = "Tipo *" : Me.lblTipo.Font = lf : Me.lblTipo.Location = New Point(15, 15) : Me.lblTipo.AutoSize = True
        Me.cboTipo.Location = New Point(15, 35) : Me.cboTipo.Size = iw : Me.cboTipo.Font = inf : Me.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblDescripcion.Text = "Descripción *" : Me.lblDescripcion.Font = lf : Me.lblDescripcion.Location = New Point(15, 80) : Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 100) : Me.txtDescripcion.Size = iw : Me.txtDescripcion.Font = inf

        Me.lblEmpleado.Text = "Empleado responsable" : Me.lblEmpleado.Font = lf : Me.lblEmpleado.Location = New Point(15, 145) : Me.lblEmpleado.AutoSize = True
        Me.cboEmpleado.Location = New Point(15, 165) : Me.cboEmpleado.Size = is_ : Me.cboEmpleado.Font = inf : Me.cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblSala.Text = "Sala afectada" : Me.lblSala.Font = lf : Me.lblSala.Location = New Point(255, 145) : Me.lblSala.AutoSize = True
        Me.cboSala.Location = New Point(255, 165) : Me.cboSala.Size = is_ : Me.cboSala.Font = inf : Me.cboSala.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblInicio.Text = "Fecha Inicio *" : Me.lblInicio.Font = lf : Me.lblInicio.Location = New Point(15, 210) : Me.lblInicio.AutoSize = True
        Me.dtpInicio.Location = New Point(15, 230) : Me.dtpInicio.Size = is_ : Me.dtpInicio.Font = inf : Me.dtpInicio.Format = DateTimePickerFormat.Short

        Me.lblFin.Text = "Fecha Fin" : Me.lblFin.Font = lf : Me.lblFin.Location = New Point(255, 210) : Me.lblFin.AutoSize = True
        Me.dtpFin.Location = New Point(255, 230) : Me.dtpFin.Size = is_ : Me.dtpFin.Font = inf : Me.dtpFin.Format = DateTimePickerFormat.Short

        Me.lblCosto.Text = "Costo (RD$)" : Me.lblCosto.Font = lf : Me.lblCosto.Location = New Point(15, 275) : Me.lblCosto.AutoSize = True
        Me.txtCosto.Location = New Point(15, 295) : Me.txtCosto.Size = is_ : Me.txtCosto.Font = inf

        Me.lblEstado.Text = "Estado" : Me.lblEstado.Font = lf : Me.lblEstado.Location = New Point(255, 275) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 295) : Me.cboEstado.Size = is_ : Me.cboEstado.Font = inf : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblObservaciones.Text = "Observaciones" : Me.lblObservaciones.Font = lf : Me.lblObservaciones.Location = New Point(15, 340) : Me.lblObservaciones.AutoSize = True
        Me.txtObservaciones.Location = New Point(15, 360) : Me.txtObservaciones.Size = New Size(460, 100) : Me.txtObservaciones.Font = inf
        Me.txtObservaciones.Multiline = True : Me.txtObservaciones.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange(New Control() {
            Me.lblTipo, Me.cboTipo, Me.lblDescripcion, Me.txtDescripcion,
            Me.lblEmpleado, Me.cboEmpleado, Me.lblSala, Me.cboSala,
            Me.lblInicio, Me.dtpInicio, Me.lblFin, Me.dtpFin,
            Me.lblCosto, Me.txtCosto, Me.lblEstado, Me.cboEstado,
            Me.lblObservaciones, Me.txtObservaciones})

        Dim bf As New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnNuevo.Text = "➕  Nuevo" : Me.btnNuevo.Location = New Point(10, 585) : Me.btnNuevo.Size = New Size(170, 38)
        Me.btnNuevo.Font = bf : Me.btnNuevo.BackColor = Color.FromArgb(67, 160, 71) : Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat : Me.btnNuevo.FlatAppearance.BorderSize = 0 : Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Text = "💾  Guardar" : Me.btnGuardar.Location = New Point(190, 585) : Me.btnGuardar.Size = New Size(170, 38)
        Me.btnGuardar.Font = bf : Me.btnGuardar.BackColor = Color.FromArgb(30, 136, 229) : Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat : Me.btnGuardar.FlatAppearance.BorderSize = 0 : Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Text = "✏️  Editar" : Me.btnEditar.Location = New Point(10, 633) : Me.btnEditar.Size = New Size(170, 38)
        Me.btnEditar.Font = bf : Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0) : Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat : Me.btnEditar.FlatAppearance.BorderSize = 0 : Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Text = "🗑  Eliminar" : Me.btnEliminar.Location = New Point(190, 633) : Me.btnEliminar.Size = New Size(170, 38)
        Me.btnEliminar.Font = bf : Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Text = "✖  Cancelar" : Me.btnCancelar.Location = New Point(10, 681) : Me.btnCancelar.Size = New Size(350, 38)
        Me.btnCancelar.Font = bf : Me.btnCancelar.BackColor = Color.Gray : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.lblBuscar.Text = "🔍  Buscar:" : Me.lblBuscar.Font = lf : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inf

        Me.dgvMantenimiento.Location = New Point(520, 125) : Me.dgvMantenimiento.Size = New Size(460, 600)
        Me.dgvMantenimiento.AllowUserToAddRows = False : Me.dgvMantenimiento.ReadOnly = True
        Me.dgvMantenimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvMantenimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMantenimiento.BackgroundColor = Color.White : Me.dgvMantenimiento.BorderStyle = BorderStyle.None
        Me.dgvMantenimiento.RowHeadersVisible = False : Me.dgvMantenimiento.Font = New Font("Segoe UI", 9)
        Me.dgvMantenimiento.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvMantenimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(121, 85, 72)
        Me.dgvMantenimiento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvMantenimiento.EnableHeadersVisualStyles = False
        Me.dgvMantenimiento.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 242)

        Me.ClientSize = New Size(1000, 740)
        Me.Controls.AddRange(New Control() {
            Me.pnlTitulo, Me.pnlFormulario,
            Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar,
            Me.lblBuscar, Me.txtBuscar, Me.dgvMantenimiento})
        Me.Text = "Gestión de Mantenimiento" : Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo        As Panel
    Friend WithEvents lblTitulo        As Label
    Friend WithEvents pnlFormulario    As Panel
    Friend WithEvents lblTipo          As Label
    Friend WithEvents cboTipo          As ComboBox
    Friend WithEvents lblDescripcion   As Label
    Friend WithEvents txtDescripcion   As TextBox
    Friend WithEvents lblEmpleado      As Label
    Friend WithEvents cboEmpleado      As ComboBox
    Friend WithEvents lblSala          As Label
    Friend WithEvents cboSala          As ComboBox
    Friend WithEvents lblInicio        As Label
    Friend WithEvents dtpInicio        As DateTimePicker
    Friend WithEvents lblFin           As Label
    Friend WithEvents dtpFin           As DateTimePicker
    Friend WithEvents lblCosto         As Label
    Friend WithEvents txtCosto         As TextBox
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
    Friend WithEvents dgvMantenimiento As DataGridView
End Class
