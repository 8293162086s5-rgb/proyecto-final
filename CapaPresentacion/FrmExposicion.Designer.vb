<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExposicion
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
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblDescripcion = New Label()
        Me.txtDescripcion = New TextBox()
        Me.lblFechaInicio = New Label()
        Me.dtpFechaInicio = New DateTimePicker()
        Me.lblFechaFin = New Label()
        Me.dtpFechaFin = New DateTimePicker()
        Me.lblSala = New Label()
        Me.cboSala = New ComboBox()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
        Me.lblResponsable = New Label()
        Me.txtResponsable = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvExposiciones = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(142, 36, 170)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Gestion de Exposiciones"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 420)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblNombre.Text = "Nombre *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(15, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(15, 35) : Me.txtNombre.Size = New Size(460, 28) : Me.txtNombre.Font = inputFont

        Me.lblDescripcion.Text = "Descripcion" : Me.lblDescripcion.Font = labelFont : Me.lblDescripcion.Location = New Point(15, 80) : Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 100) : Me.txtDescripcion.Size = New Size(460, 55) : Me.txtDescripcion.Font = inputFont : Me.txtDescripcion.Multiline = True

        Me.lblFechaInicio.Text = "Fecha Inicio *" : Me.lblFechaInicio.Font = labelFont : Me.lblFechaInicio.Location = New Point(15, 170) : Me.lblFechaInicio.AutoSize = True
        Me.dtpFechaInicio.Location = New Point(15, 190) : Me.dtpFechaInicio.Size = inputSize : Me.dtpFechaInicio.Font = inputFont : Me.dtpFechaInicio.Format = DateTimePickerFormat.Short

        Me.lblFechaFin.Text = "Fecha Fin *" : Me.lblFechaFin.Font = labelFont : Me.lblFechaFin.Location = New Point(255, 170) : Me.lblFechaFin.AutoSize = True
        Me.dtpFechaFin.Location = New Point(255, 190) : Me.dtpFechaFin.Size = inputSize : Me.dtpFechaFin.Font = inputFont : Me.dtpFechaFin.Format = DateTimePickerFormat.Short

        Me.lblSala.Text = "Sala *" : Me.lblSala.Font = labelFont : Me.lblSala.Location = New Point(15, 235) : Me.lblSala.AutoSize = True
        Me.cboSala.Location = New Point(15, 255) : Me.cboSala.Size = inputSize : Me.cboSala.Font = inputFont : Me.cboSala.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(255, 235) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 255) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblResponsable.Text = "Responsable *" : Me.lblResponsable.Font = labelFont : Me.lblResponsable.Location = New Point(15, 300) : Me.lblResponsable.AutoSize = True
        Me.txtResponsable.Location = New Point(15, 320) : Me.txtResponsable.Size = inputSize : Me.txtResponsable.Font = inputFont

        Me.pnlFormulario.Controls.AddRange({Me.lblNombre, Me.txtNombre, Me.lblDescripcion, Me.txtDescripcion,
                                             Me.lblFechaInicio, Me.dtpFechaInicio, Me.lblFechaFin, Me.dtpFechaFin,
                                             Me.lblSala, Me.cboSala, Me.lblEstado, Me.cboEstado,
                                             Me.lblResponsable, Me.txtResponsable})

        Me.pnlBotones.Location = New Point(10, 495)
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

        Me.btnEliminar.Size = btnSize : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = btnFont : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = btnSize : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = btnFont : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        Me.lblBuscar.Text = "Buscar:" : Me.lblBuscar.Font = labelFont : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inputFont

        Me.dgvExposiciones.Location = New Point(520, 125)
        Me.dgvExposiciones.Size = New Size(460, 420)
        Me.dgvExposiciones.AllowUserToAddRows = False
        Me.dgvExposiciones.ReadOnly = True
        Me.dgvExposiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvExposiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExposiciones.BackgroundColor = Color.White
        Me.dgvExposiciones.BorderStyle = BorderStyle.None
        Me.dgvExposiciones.RowHeadersVisible = False
        Me.dgvExposiciones.Font = New Font("Segoe UI", 9)
        Me.dgvExposiciones.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvExposiciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(142, 36, 170)
        Me.dgvExposiciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvExposiciones.EnableHeadersVisualStyles = False
        Me.dgvExposiciones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 240, 255)

        Me.ClientSize = New Size(1000, 560)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvExposiciones})
        Me.Text = "Gestion de Exposiciones"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblSala As Label
    Friend WithEvents cboSala As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblResponsable As Label
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvExposiciones As DataGridView

End Class
