<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo      = New System.Windows.Forms.Panel()
        Me.lblTitulo      = New System.Windows.Forms.Label()
        Me.lblSubtitulo   = New System.Windows.Forms.Label()
        Me.pnlCard        = New System.Windows.Forms.Panel()
        Me.lblTipoAcceso  = New System.Windows.Forms.Label()
        Me.pnlRoles       = New System.Windows.Forms.Panel()
        Me.rbAdmin        = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado     = New System.Windows.Forms.RadioButton()
        Me.lblUsuario     = New System.Windows.Forms.Label()
        Me.txtUsuario     = New System.Windows.Forms.TextBox()
        Me.lblContrasena  = New System.Windows.Forms.Label()
        Me.txtContrasena  = New System.Windows.Forms.TextBox()
        Me.btnIngresar    = New System.Windows.Forms.Button()
        Me.btnCancelar    = New System.Windows.Forms.Button()
        Me.lblIntentos    = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.pnlRoles.SuspendLayout()
        Me.SuspendLayout()

        ' ──────────────────────────────────────────
        ' pnlTitulo
        ' ──────────────────────────────────────────
        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Controls.Add(Me.lblSubtitulo)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 90

        Me.lblTitulo.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(30, 12)
        Me.lblTitulo.Size = New Size(440, 40)
        Me.lblTitulo.Text = "🏛  Sistema de Gestión - Museo"

        Me.lblSubtitulo.Font = New Font("Segoe UI", 10)
        Me.lblSubtitulo.ForeColor = Color.FromArgb(180, 210, 255)
        Me.lblSubtitulo.Location = New Point(34, 55)
        Me.lblSubtitulo.Size = New Size(440, 22)
        Me.lblSubtitulo.Text = "Inicie sesión para continuar"

        ' ──────────────────────────────────────────
        ' pnlCard  (tarjeta blanca centrada)
        ' ──────────────────────────────────────────
        Me.pnlCard.BackColor = Color.White
        Me.pnlCard.Size = New Size(360, 340)
        Me.pnlCard.Location = New Point(70, 115)

        ' lblTipoAcceso
        Me.lblTipoAcceso.Text = "Tipo de acceso"
        Me.lblTipoAcceso.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTipoAcceso.ForeColor = Color.FromArgb(80, 80, 80)
        Me.lblTipoAcceso.Location = New Point(20, 18)
        Me.lblTipoAcceso.Size = New Size(320, 20)

        ' pnlRoles
        Me.pnlRoles.BackColor = Color.FromArgb(240, 244, 255)
        Me.pnlRoles.Location = New Point(20, 40)
        Me.pnlRoles.Size = New Size(320, 48)
        Me.pnlRoles.Controls.Add(Me.rbAdmin)
        Me.pnlRoles.Controls.Add(Me.rbEmpleado)

        Me.rbAdmin.Text = "👔  Administrador"
        Me.rbAdmin.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.rbAdmin.ForeColor = Color.FromArgb(30, 60, 114)
        Me.rbAdmin.Location = New Point(15, 12)
        Me.rbAdmin.Size = New Size(155, 24)
        Me.rbAdmin.Cursor = Cursors.Hand

        Me.rbEmpleado.Text = "👤  Empleado"
        Me.rbEmpleado.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.rbEmpleado.ForeColor = Color.FromArgb(30, 114, 60)
        Me.rbEmpleado.Location = New Point(185, 12)
        Me.rbEmpleado.Size = New Size(130, 24)
        Me.rbEmpleado.Cursor = Cursors.Hand

        ' lblUsuario / txtUsuario
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblUsuario.ForeColor = Color.FromArgb(80, 80, 80)
        Me.lblUsuario.Location = New Point(20, 105)
        Me.lblUsuario.Size = New Size(320, 18)

        Me.txtUsuario.Font = New Font("Segoe UI", 11)
        Me.txtUsuario.Location = New Point(20, 126)
        Me.txtUsuario.Size = New Size(320, 30)
        Me.txtUsuario.BorderStyle = BorderStyle.FixedSingle

        ' lblContrasena / txtContrasena
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblContrasena.ForeColor = Color.FromArgb(80, 80, 80)
        Me.lblContrasena.Location = New Point(20, 170)
        Me.lblContrasena.Size = New Size(320, 18)

        Me.txtContrasena.Font = New Font("Segoe UI", 11)
        Me.txtContrasena.Location = New Point(20, 191)
        Me.txtContrasena.Size = New Size(320, 30)
        Me.txtContrasena.BorderStyle = BorderStyle.FixedSingle
        Me.txtContrasena.PasswordChar = "●"c

        ' btnIngresar
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnIngresar.BackColor = Color.FromArgb(30, 60, 114)
        Me.btnIngresar.ForeColor = Color.White
        Me.btnIngresar.FlatStyle = FlatStyle.Flat
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.Location = New Point(20, 242)
        Me.btnIngresar.Size = New Size(155, 40)
        Me.btnIngresar.Cursor = Cursors.Hand

        ' btnCancelar
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Font = New Font("Segoe UI", 11)
        Me.btnCancelar.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.Location = New Point(185, 242)
        Me.btnCancelar.Size = New Size(155, 40)
        Me.btnCancelar.Cursor = Cursors.Hand

        ' lblIntentos
        Me.lblIntentos.Text = ""
        Me.lblIntentos.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblIntentos.ForeColor = Color.OrangeRed
        Me.lblIntentos.Location = New Point(20, 295)
        Me.lblIntentos.Size = New Size(320, 20)
        Me.lblIntentos.Visible = False

        ' Agregar controles al pnlCard
        Me.pnlCard.Controls.Add(Me.lblTipoAcceso)
        Me.pnlCard.Controls.Add(Me.pnlRoles)
        Me.pnlCard.Controls.Add(Me.lblUsuario)
        Me.pnlCard.Controls.Add(Me.txtUsuario)
        Me.pnlCard.Controls.Add(Me.lblContrasena)
        Me.pnlCard.Controls.Add(Me.txtContrasena)
        Me.pnlCard.Controls.Add(Me.btnIngresar)
        Me.pnlCard.Controls.Add(Me.btnCancelar)
        Me.pnlCard.Controls.Add(Me.lblIntentos)

        ' FrmLogin
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ClientSize = New Size(500, 500)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema - Museo"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlRoles.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo     As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo     As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo  As System.Windows.Forms.Label
    Friend WithEvents pnlCard       As System.Windows.Forms.Panel
    Friend WithEvents lblTipoAcceso As System.Windows.Forms.Label
    Friend WithEvents pnlRoles      As System.Windows.Forms.Panel
    Friend WithEvents rbAdmin       As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpleado    As System.Windows.Forms.RadioButton
    Friend WithEvents lblUsuario    As System.Windows.Forms.Label
    Friend WithEvents txtUsuario    As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar   As System.Windows.Forms.Button
    Friend WithEvents btnCancelar   As System.Windows.Forms.Button
    Friend WithEvents lblIntentos   As System.Windows.Forms.Label

End Class
