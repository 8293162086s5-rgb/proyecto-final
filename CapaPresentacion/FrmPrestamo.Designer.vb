<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrestamo
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
        Me.lblPieza = New Label()
        Me.cboPieza = New ComboBox()
        Me.lblInstitucionSolicitante = New Label()
        Me.txtInstitucionSolicitante = New TextBox()
        Me.lblResponsable = New Label()
        Me.txtResponsable = New TextBox()
        Me.lblContacto = New Label()
        Me.txtContacto = New TextBox()
        Me.lblFechaPrestamo = New Label()
        Me.dtpFechaPrestamo = New DateTimePicker()
        Me.lblFechaDevolucion = New Label()
        Me.dtpFechaDevolucion = New DateTimePicker()
        Me.lblEstado = New Label()
        Me.cboEstado = New ComboBox()
        Me.lblCondiciones = New Label()
        Me.txtCondiciones = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvPrestamos = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "Prestamos de Piezas"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 430)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        Me.lblPieza.Text = "Pieza *" : Me.lblPieza.Font = labelFont : Me.lblPieza.Location = New Point(15, 15) : Me.lblPieza.AutoSize = True
        Me.cboPieza.Location = New Point(15, 35) : Me.cboPieza.Size = inputSize : Me.cboPieza.Font = inputFont : Me.cboPieza.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblInstitucionSolicitante.Text = "Institucion Solicitante *" : Me.lblInstitucionSolicitante.Font = labelFont : Me.lblInstitucionSolicitante.Location = New Point(255, 15) : Me.lblInstitucionSolicitante.AutoSize = True
        Me.txtInstitucionSolicitante.Location = New Point(255, 35) : Me.txtInstitucionSolicitante.Size = inputSize : Me.txtInstitucionSolicitante.Font = inputFont

        Me.lblResponsable.Text = "Responsable *" : Me.lblResponsable.Font = labelFont : Me.lblResponsable.Location = New Point(15, 80) : Me.lblResponsable.AutoSize = True
        Me.txtResponsable.Location = New Point(15, 100) : Me.txtResponsable.Size = inputSize : Me.txtResponsable.Font = inputFont

        Me.lblContacto.Text = "Telefono / Email de Contacto" : Me.lblContacto.Font = labelFont : Me.lblContacto.Location = New Point(255, 80) : Me.lblContacto.AutoSize = True
        Me.txtContacto.Location = New Point(255, 100) : Me.txtContacto.Size = inputSize : Me.txtContacto.Font = inputFont

        Me.lblFechaPrestamo.Text = "Fecha de Prestamo *" : Me.lblFechaPrestamo.Font = labelFont : Me.lblFechaPrestamo.Location = New Point(15, 145) : Me.lblFechaPrestamo.AutoSize = True
        Me.dtpFechaPrestamo.Location = New Point(15, 165) : Me.dtpFechaPrestamo.Size = inputSize : Me.dtpFechaPrestamo.Font = inputFont : Me.dtpFechaPrestamo.Format = DateTimePickerFormat.Short

        Me.lblFechaDevolucion.Text = "Fecha de Devolucion *" : Me.lblFechaDevolucion.Font = labelFont : Me.lblFechaDevolucion.Location = New Point(255, 145) : Me.lblFechaDevolucion.AutoSize = True
        Me.dtpFechaDevolucion.Location = New Point(255, 165) : Me.dtpFechaDevolucion.Size = inputSize : Me.dtpFechaDevolucion.Font = inputFont : Me.dtpFechaDevolucion.Format = DateTimePickerFormat.Short

        Me.lblEstado.Text = "Estado *" : Me.lblEstado.Font = labelFont : Me.lblEstado.Location = New Point(15, 210) : Me.lblEstado.AutoSize = True
        Me.cboEstado.Location = New Point(15, 230) : Me.cboEstado.Size = inputSize : Me.cboEstado.Font = inputFont : Me.cboEstado.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblCondiciones.Text = "Condiciones del Prestamo" : Me.lblCondiciones.Font = labelFont : Me.lblCondiciones.Location = New Point(15, 275) : Me.lblCondiciones.AutoSize = True
        Me.txtCondiciones.Location = New Point(15, 295) : Me.txtCondiciones.Size = New Size(460, 80) : Me.txtCondiciones.Font = inputFont
        Me.txtCondiciones.Multiline = True : Me.txtCondiciones.ScrollBars = ScrollBars.Vertical

        Me.pnlFormulario.Controls.AddRange({Me.lblPieza, Me.cboPieza, Me.lblInstitucionSolicitante, Me.txtInstitucionSolicitante,
                                             Me.lblResponsable, Me.txtResponsable, Me.lblContacto, Me.txtContacto,
                                             Me.lblFechaPrestamo, Me.dtpFechaPrestamo, Me.lblFechaDevolucion, Me.dtpFechaDevolucion,
                                             Me.lblEstado, Me.cboEstado, Me.lblCondiciones, Me.txtCondiciones})

        Me.pnlBotones.Location = New Point(10, 505)
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

        Me.dgvPrestamos.Location = New Point(520, 125)
        Me.dgvPrestamos.Size = New Size(460, 430)
        Me.dgvPrestamos.AllowUserToAddRows = False
        Me.dgvPrestamos.ReadOnly = True
        Me.dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrestamos.BackgroundColor = Color.White
        Me.dgvPrestamos.BorderStyle = BorderStyle.None
        Me.dgvPrestamos.RowHeadersVisible = False
        Me.dgvPrestamos.Font = New Font("Segoe UI", 9)
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 114)
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvPrestamos.EnableHeadersVisualStyles = False
        Me.dgvPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Me.ClientSize = New Size(1000, 570)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvPrestamos})
        Me.Text = "Prestamos de Piezas"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblPieza As Label
    Friend WithEvents cboPieza As ComboBox
    Friend WithEvents lblInstitucionSolicitante As Label
    Friend WithEvents txtInstitucionSolicitante As TextBox
    Friend WithEvents lblResponsable As Label
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents lblFechaPrestamo As Label
    Friend WithEvents dtpFechaPrestamo As DateTimePicker
    Friend WithEvents lblFechaDevolucion As Label
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblCondiciones As Label
    Friend WithEvents txtCondiciones As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvPrestamos As DataGridView

End Class
