<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisitante
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
        Me.lblApellido = New Label()
        Me.txtApellido = New TextBox()
        Me.lblDocumento = New Label()
        Me.txtDocumento = New TextBox()
        Me.lblEdad = New Label()
        Me.txtEdad = New TextBox()
        Me.lblGenero = New Label()
        Me.cboGenero = New ComboBox()
        Me.lblNacionalidad = New Label()
        Me.txtNacionalidad = New TextBox()
        Me.lblEmail = New Label()
        Me.txtEmail = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvVisitantes = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        ' pnlTitulo
        Me.pnlTitulo.BackColor = Color.FromArgb(251, 140, 0)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "👥  Gestión de Visitantes"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        ' pnlFormulario
        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 360)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        ' Nombre
        Me.lblNombre.Text = "Nombre *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(15, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(15, 35) : Me.txtNombre.Size = inputSize : Me.txtNombre.Font = inputFont

        ' Apellido
        Me.lblApellido.Text = "Apellido *" : Me.lblApellido.Font = labelFont : Me.lblApellido.Location = New Point(255, 15) : Me.lblApellido.AutoSize = True
        Me.txtApellido.Location = New Point(255, 35) : Me.txtApellido.Size = inputSize : Me.txtApellido.Font = inputFont

        ' Documento
        Me.lblDocumento.Text = "Documento de Identidad *" : Me.lblDocumento.Font = labelFont : Me.lblDocumento.Location = New Point(15, 80) : Me.lblDocumento.AutoSize = True
        Me.txtDocumento.Location = New Point(15, 100) : Me.txtDocumento.Size = inputSize : Me.txtDocumento.Font = inputFont

        ' Edad
        Me.lblEdad.Text = "Edad *" : Me.lblEdad.Font = labelFont : Me.lblEdad.Location = New Point(255, 80) : Me.lblEdad.AutoSize = True
        Me.txtEdad.Location = New Point(255, 100) : Me.txtEdad.Size = inputSize : Me.txtEdad.Font = inputFont

        ' Género
        Me.lblGenero.Text = "Género *" : Me.lblGenero.Font = labelFont : Me.lblGenero.Location = New Point(15, 145) : Me.lblGenero.AutoSize = True
        Me.cboGenero.Location = New Point(15, 165) : Me.cboGenero.Size = inputSize : Me.cboGenero.Font = inputFont : Me.cboGenero.DropDownStyle = ComboBoxStyle.DropDownList

        ' Nacionalidad
        Me.lblNacionalidad.Text = "Nacionalidad *" : Me.lblNacionalidad.Font = labelFont : Me.lblNacionalidad.Location = New Point(255, 145) : Me.lblNacionalidad.AutoSize = True
        Me.txtNacionalidad.Location = New Point(255, 165) : Me.txtNacionalidad.Size = inputSize : Me.txtNacionalidad.Font = inputFont

        ' Email
        Me.lblEmail.Text = "Email" : Me.lblEmail.Font = labelFont : Me.lblEmail.Location = New Point(15, 210) : Me.lblEmail.AutoSize = True
        Me.txtEmail.Location = New Point(15, 230) : Me.txtEmail.Size = inputSize : Me.txtEmail.Font = inputFont

        Me.pnlFormulario.Controls.AddRange({Me.lblNombre, Me.txtNombre, Me.lblApellido, Me.txtApellido,
                                             Me.lblDocumento, Me.txtDocumento, Me.lblEdad, Me.txtEdad,
                                             Me.lblGenero, Me.cboGenero, Me.lblNacionalidad, Me.txtNacionalidad,
                                             Me.lblEmail, Me.txtEmail})

        ' pnlBotones
        Me.pnlBotones.Location = New Point(10, 435)
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
        Me.dgvVisitantes.Location = New Point(520, 125)
        Me.dgvVisitantes.Size = New Size(460, 360)
        Me.dgvVisitantes.AllowUserToAddRows = False
        Me.dgvVisitantes.ReadOnly = True
        Me.dgvVisitantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvVisitantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVisitantes.BackgroundColor = Color.White
        Me.dgvVisitantes.BorderStyle = BorderStyle.None
        Me.dgvVisitantes.RowHeadersVisible = False
        Me.dgvVisitantes.Font = New Font("Segoe UI", 9)
        Me.dgvVisitantes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvVisitantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(251, 140, 0)
        Me.dgvVisitantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvVisitantes.EnableHeadersVisualStyles = False
        Me.dgvVisitantes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 240)

        ' FrmVisitante
        Me.ClientSize = New Size(1000, 500)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvVisitantes})
        Me.Text = "Gestión de Visitantes"
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
    Friend WithEvents lblDocumento As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblGenero As Label
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvVisitantes As DataGridView

End Class
