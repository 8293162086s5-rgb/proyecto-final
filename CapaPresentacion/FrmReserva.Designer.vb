<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReserva
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
        Me.lblCantidadPersonas = New Label()
        Me.txtCantidadPersonas = New TextBox()
        Me.lblFechaReserva = New Label()
        Me.dtpFechaReserva = New DateTimePicker()
        Me.lblHora = New Label()
        Me.dtpHora = New DateTimePicker()
        Me.lblTipo = New Label()
        Me.cboTipo = New ComboBox()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
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
        Me.dgvReservas = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Gestion de Reservas"
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

        Me.lblCantidadPersonas.Text = "Cantidad de Personas *" : Me.lblCantidadPersonas.Font = labelFont : Me.lblCantidadPersonas.Location = New Point(255, 15) : Me.lblCantidadPersonas.AutoSize = True
        Me.txtCantidadPersonas.Location = New Point(255, 35) : Me.txtCantidadPersonas.Size = inputSize : Me.txtCantidadPersonas.Font = inputFont

        Me.lblFechaReserva.Text = "Fecha de Reserva *" : Me.lblFechaReserva.Font = labelFont : Me.lblFechaReserva.Location = New Point(15, 80) : Me.lblFechaReserva.AutoSize = True
        Me.dtpFechaReserva.Location = New Point(15, 100) : Me.dtpFechaReserva.Size = inputSize : Me.dtpFechaReserva.Font = inputFont : Me.dtpFechaReserva.Format = DateTimePickerFormat.Short

        Me.lblHora.Text = "Hora *" : Me.lblHora.Font = labelFont : Me.lblHora.Location = New Point(255, 80) : Me.lblHora.AutoSize = True
        Me.dtpHora.Location = New Point(255, 100) : Me.dtpHora.Size = inputSize : Me.dtpHora.Font = inputFont
        Me.dtpHora.Format = DateTimePickerFormat.Time : Me.dtpHora.ShowUpDown = True

        Me.lblTipo.Text = "Tipo de Visita *" : Me.lblTipo.Font = labelFont : Me.lblTipo.Location = New Point(15, 145) : Me.lblTipo.AutoSize = True
        Me.cboTipo.Location = New Point(15, 165) : Me.cboTipo.Size = inputSize : Me.cboTipo.Font = inputFont : Me.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(255, 145) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 165) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblObservaciones.Text = "Observaciones" : Me.lblObservaciones.Font = labelFont : Me.lblObservaciones.Location = New Point(15, 210) : Me.lblObservaciones.AutoSize = True
        Me.txtObservaciones.Location = New Point(15, 230) : Me.txtObservaciones.Size = New Size(460, 60) : Me.txtObservaciones.Font = inputFont
        Me.txtObservaciones.Multiline = True : Me.txtObservaciones.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange({Me.lblVisitante, Me.cboVisitante, Me.lblCantidadPersonas, Me.txtCantidadPersonas,
                                             Me.lblFechaReserva, Me.dtpFechaReserva, Me.lblHora, Me.dtpHora,
                                             Me.lblTipo, Me.cboTipo, Me.lblEstado, Me.cboEstado,
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

        Me.dgvReservas.Location = New Point(520, 125)
        Me.dgvReservas.Size = New Size(460, 410)
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservas.BackgroundColor = Color.White
        Me.dgvReservas.BorderStyle = BorderStyle.None
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.Font = New Font("Segoe UI", 9)
        Me.dgvReservas.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvReservas.EnableHeadersVisualStyles = False
        Me.dgvReservas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Me.ClientSize = New Size(1000, 540)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvReservas})
        Me.Text = "Gestion de Reservas"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblVisitante As Label
    Friend WithEvents cboVisitante As ComboBox
    Friend WithEvents lblCantidadPersonas As Label
    Friend WithEvents txtCantidadPersonas As TextBox
    Friend WithEvents lblFechaReserva As Label
    Friend WithEvents dtpFechaReserva As DateTimePicker
    Friend WithEvents lblHora As Label
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
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
    Friend WithEvents dgvReservas As DataGridView

End Class
