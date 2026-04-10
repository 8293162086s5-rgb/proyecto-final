<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEvento
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
        Me.lblSala = New Label()
        Me.cboSala = New ComboBox()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblTipo = New Label()
        Me.cboTipo = New ComboBox()
        Me.lblResponsable = New Label()
        Me.txtResponsable = New TextBox()
        Me.lblCapacidadMaxima = New Label()
        Me.txtCapacidadMaxima = New TextBox()
        Me.lblFechaInicio = New Label()
        Me.dtpFechaInicio = New DateTimePicker()
        Me.lblFechaFin = New Label()
        Me.dtpFechaFin = New DateTimePicker()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
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
        Me.dgvEventos = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Gestion de Eventos Especiales"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 460)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblSala.Text = "Sala *" : Me.lblSala.Font = labelFont : Me.lblSala.Location = New Point(15, 15) : Me.lblSala.AutoSize = True
        Me.cboSala.Location = New Point(15, 35) : Me.cboSala.Size = inputSize : Me.cboSala.Font = inputFont : Me.cboSala.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblNombre.Text = "Nombre del Evento *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(255, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(255, 35) : Me.txtNombre.Size = inputSize : Me.txtNombre.Font = inputFont

        Me.lblTipo.Text = "Tipo de Evento *" : Me.lblTipo.Font = labelFont : Me.lblTipo.Location = New Point(15, 80) : Me.lblTipo.AutoSize = True
        Me.cboTipo.Location = New Point(15, 100) : Me.cboTipo.Size = inputSize : Me.cboTipo.Font = inputFont : Me.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblResponsable.Text = "Responsable *" : Me.lblResponsable.Font = labelFont : Me.lblResponsable.Location = New Point(255, 80) : Me.lblResponsable.AutoSize = True
        Me.txtResponsable.Location = New Point(255, 100) : Me.txtResponsable.Size = inputSize : Me.txtResponsable.Font = inputFont

        Me.lblCapacidadMaxima.Text = "Capacidad Maxima" : Me.lblCapacidadMaxima.Font = labelFont : Me.lblCapacidadMaxima.Location = New Point(15, 145) : Me.lblCapacidadMaxima.AutoSize = True
        Me.txtCapacidadMaxima.Location = New Point(15, 165) : Me.txtCapacidadMaxima.Size = inputSize : Me.txtCapacidadMaxima.Font = inputFont

        Me.lblFechaInicio.Text = "Fecha de Inicio *" : Me.lblFechaInicio.Font = labelFont : Me.lblFechaInicio.Location = New Point(255, 145) : Me.lblFechaInicio.AutoSize = True
        Me.dtpFechaInicio.Location = New Point(255, 165) : Me.dtpFechaInicio.Size = inputSize : Me.dtpFechaInicio.Font = inputFont : Me.dtpFechaInicio.Format = DateTimePickerFormat.Short

        Me.lblFechaFin.Text = "Fecha de Fin *" : Me.lblFechaFin.Font = labelFont : Me.lblFechaFin.Location = New Point(15, 210) : Me.lblFechaFin.AutoSize = True
        Me.dtpFechaFin.Location = New Point(15, 230) : Me.dtpFechaFin.Size = inputSize : Me.dtpFechaFin.Font = inputFont : Me.dtpFechaFin.Format = DateTimePickerFormat.Short

        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(255, 210) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(255, 230) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblDescripcion.Text = "Descripcion" : Me.lblDescripcion.Font = labelFont : Me.lblDescripcion.Location = New Point(15, 275) : Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 295) : Me.txtDescripcion.Size = New Size(460, 100) : Me.txtDescripcion.Font = inputFont
        Me.txtDescripcion.Multiline = True : Me.txtDescripcion.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange({Me.lblSala, Me.cboSala, Me.lblNombre, Me.txtNombre,
                                             Me.lblTipo, Me.cboTipo, Me.lblResponsable, Me.txtResponsable,
                                             Me.lblCapacidadMaxima, Me.txtCapacidadMaxima,
                                             Me.lblFechaInicio, Me.dtpFechaInicio, Me.lblFechaFin, Me.dtpFechaFin,
                                             Me.lblEstado, Me.cboEstado, Me.lblDescripcion, Me.txtDescripcion})

        Me.pnlBotones.Location = New Point(10, 535)
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

        Me.dgvEventos.Location = New Point(520, 125)
        Me.dgvEventos.Size = New Size(460, 460)
        Me.dgvEventos.AllowUserToAddRows = False
        Me.dgvEventos.ReadOnly = True
        Me.dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEventos.BackgroundColor = Color.White
        Me.dgvEventos.BorderStyle = BorderStyle.None
        Me.dgvEventos.RowHeadersVisible = False
        Me.dgvEventos.Font = New Font("Segoe UI", 9)
        Me.dgvEventos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvEventos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvEventos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvEventos.EnableHeadersVisualStyles = False
        Me.dgvEventos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Me.ClientSize = New Size(1000, 600)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvEventos})
        Me.Text = "Gestion de Eventos Especiales"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblSala As Label
    Friend WithEvents cboSala As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblResponsable As Label
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents lblCapacidadMaxima As Label
    Friend WithEvents txtCapacidadMaxima As TextBox
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
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
    Friend WithEvents dgvEventos As DataGridView

End Class
