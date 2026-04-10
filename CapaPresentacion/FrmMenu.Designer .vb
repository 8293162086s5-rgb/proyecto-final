<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.pnlTitulo        = New System.Windows.Forms.Panel()
        Me.lblTitulo        = New System.Windows.Forms.Label()
        Me.lblSubtitulo     = New System.Windows.Forms.Label()
        Me.btnCambiarSesion = New System.Windows.Forms.Button()

        Me.pnlAdmin         = New System.Windows.Forms.Panel()
        Me.lblSeccionAdmin  = New System.Windows.Forms.Label()
        Me.btnEmpleados     = New System.Windows.Forms.Button()
        Me.btnProveedores   = New System.Windows.Forms.Button()
        Me.btnContratos     = New System.Windows.Forms.Button()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnReportes      = New System.Windows.Forms.Button()
        Me.btnInventario    = New System.Windows.Forms.Button()

        Me.pnlEmpleado      = New System.Windows.Forms.Panel()
        Me.lblSeccionEmp    = New System.Windows.Forms.Label()
        Me.btnGuias         = New System.Windows.Forms.Button()
        Me.btnVisitantes    = New System.Windows.Forms.Button()
        Me.btnExposiciones  = New System.Windows.Forms.Button()
        Me.btnPiezas        = New System.Windows.Forms.Button()
        Me.btnSalas         = New System.Windows.Forms.Button()
        Me.btnDonaciones    = New System.Windows.Forms.Button()
        Me.btnEntradas      = New System.Windows.Forms.Button()
        Me.btnEventos       = New System.Windows.Forms.Button()
        Me.btnPrestamos     = New System.Windows.Forms.Button()
        Me.btnReservas      = New System.Windows.Forms.Button()

        Me.btnSalir  = New System.Windows.Forms.Button()
        Me.pnlScroll = New System.Windows.Forms.Panel()

        Me.pnlTitulo.SuspendLayout()
        Me.pnlAdmin.SuspendLayout()
        Me.pnlEmpleado.SuspendLayout()
        Me.pnlScroll.SuspendLayout()
        Me.SuspendLayout()

        ' ══ Dimensiones comunes ═══════════════════════════
        Dim btnW   As Integer = 210
        Dim btnH   As Integer = 90
        Dim gapX   As Integer = 18
        Dim gapY   As Integer = 15
        Dim btnFont As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim btnSize As New Size(btnW, btnH)
        Dim col1 As Integer = 0
        Dim col2 As Integer = btnW + gapX
        Dim col3 As Integer = (btnW + gapX) * 2
        Dim col4 As Integer = (btnW + gapX) * 3
        Dim panelW As Integer = col4 + btnW

        ' ══ HEADER ════════════════════════════════════════
        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Controls.Add(Me.lblSubtitulo)
        Me.pnlTitulo.Controls.Add(Me.btnCambiarSesion)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 90

        Me.lblTitulo.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(30, 10)
        Me.lblTitulo.Size = New Size(800, 45)
        Me.lblTitulo.Text = "🏛  Sistema de Gestión del Museo"

        Me.lblSubtitulo.Font = New Font("Segoe UI", 10)
        Me.lblSubtitulo.ForeColor = Color.FromArgb(200, 230, 255)
        Me.lblSubtitulo.Location = New Point(34, 57)
        Me.lblSubtitulo.Size = New Size(700, 22)
        Me.lblSubtitulo.Text = "Seleccione un módulo"

        ' Botón Cambiar Sesión — se posiciona dinámicamente en Resize
        Me.btnCambiarSesion.Text = "🔄  Cambiar Sesión"
        Me.btnCambiarSesion.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnCambiarSesion.BackColor = Color.FromArgb(230, 130, 0)
        Me.btnCambiarSesion.ForeColor = Color.White
        Me.btnCambiarSesion.FlatStyle = FlatStyle.Flat
        Me.btnCambiarSesion.FlatAppearance.BorderSize = 0
        Me.btnCambiarSesion.Size = New Size(160, 36)
        Me.btnCambiarSesion.Location = New Point(800, 27)   ' se corrige en Resize
        Me.btnCambiarSesion.Cursor = Cursors.Hand
        Me.btnCambiarSesion.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        ' ══ SCROLL PANEL ══════════════════════════════════
        Me.pnlScroll.Dock = DockStyle.Fill
        Me.pnlScroll.AutoScroll = True
        Me.pnlScroll.Padding = New Padding(0, 0, 0, 0)
        Me.pnlScroll.Controls.Add(Me.pnlAdmin)
        Me.pnlScroll.Controls.Add(Me.pnlEmpleado)
        Me.pnlScroll.Controls.Add(Me.btnSalir)

        ' ══ SECCIÓN ADMIN ═════════════════════════════════
        Dim adminH As Integer = 35 + btnH + gapY + btnH + 20
        Me.pnlAdmin.Location = New Point(30, 20)
        Me.pnlAdmin.Size = New Size(panelW, adminH)
        Me.pnlAdmin.BackColor = Color.Transparent

        Me.lblSeccionAdmin.Text = "🔐  Módulos del Administrador"
        Me.lblSeccionAdmin.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblSeccionAdmin.ForeColor = Color.FromArgb(30, 60, 114)
        Me.lblSeccionAdmin.Location = New Point(0, 0)
        Me.lblSeccionAdmin.Size = New Size(600, 28)

        Dim rA1 As Integer = 35
        ConfigurarBtn(Me.btnEmpleados,     btnSize, New Point(col1, rA1), "👤  Empleados",     Color.FromArgb(30, 136, 229), btnFont)
        ConfigurarBtn(Me.btnProveedores,   btnSize, New Point(col2, rA1), "🏢  Proveedores",   Color.FromArgb(63,  81, 181), btnFont)
        ConfigurarBtn(Me.btnContratos,     btnSize, New Point(col3, rA1), "📄  Contratos",     Color.FromArgb(0,  131, 143), btnFont)
        ConfigurarBtn(Me.btnMantenimiento, btnSize, New Point(col4, rA1), "🔧  Mantenimiento", Color.FromArgb(121, 85,  72), btnFont)

        Dim rA2 As Integer = rA1 + btnH + gapY
        ConfigurarBtn(Me.btnReportes,   btnSize, New Point(col1, rA2), "📊  Reportes",   Color.FromArgb(142, 36, 170), btnFont)
        ConfigurarBtn(Me.btnInventario, btnSize, New Point(col2, rA2), "📦  Inventario", Color.FromArgb(255, 111,   0), btnFont)

        Me.pnlAdmin.Controls.Add(Me.lblSeccionAdmin)
        Me.pnlAdmin.Controls.Add(Me.btnEmpleados)
        Me.pnlAdmin.Controls.Add(Me.btnProveedores)
        Me.pnlAdmin.Controls.Add(Me.btnContratos)
        Me.pnlAdmin.Controls.Add(Me.btnMantenimiento)
        Me.pnlAdmin.Controls.Add(Me.btnReportes)
        Me.pnlAdmin.Controls.Add(Me.btnInventario)

        ' ══ SECCIÓN EMPLEADO ══════════════════════════════
        ' Posición inicial; se ajusta en AplicarPermisos()
        Dim empH As Integer = 35 + (btnH + gapY) * 2 + btnH + 20
        Me.pnlEmpleado.Location = New Point(30, pnlAdmin.Bottom + 20)
        Me.pnlEmpleado.Size = New Size(panelW, empH)
        Me.pnlEmpleado.BackColor = Color.Transparent

        Me.lblSeccionEmp.Text = "👥  Módulos del Empleado"
        Me.lblSeccionEmp.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblSeccionEmp.ForeColor = Color.FromArgb(27, 94, 32)
        Me.lblSeccionEmp.Location = New Point(0, 0)
        Me.lblSeccionEmp.Size = New Size(600, 28)

        Dim rE1 As Integer = 35
        ConfigurarBtn(Me.btnGuias,        btnSize, New Point(col1, rE1), "🧭  Guías",        Color.FromArgb(67,  160, 71), btnFont)
        ConfigurarBtn(Me.btnVisitantes,   btnSize, New Point(col2, rE1), "👥  Visitantes",   Color.FromArgb(251, 140,  0), btnFont)
        ConfigurarBtn(Me.btnExposiciones, btnSize, New Point(col3, rE1), "🖼  Exposiciones", Color.FromArgb(142,  36, 170), btnFont)
        ConfigurarBtn(Me.btnPiezas,       btnSize, New Point(col4, rE1), "🏺  Piezas",       Color.FromArgb(0,  131, 143), btnFont)

        Dim rE2 As Integer = rE1 + btnH + gapY
        ConfigurarBtn(Me.btnSalas,      btnSize, New Point(col1, rE2), "🏛  Salas",      Color.FromArgb(0,   96, 100), btnFont)
        ConfigurarBtn(Me.btnDonaciones, btnSize, New Point(col2, rE2), "💰  Donaciones", Color.FromArgb(255, 179,   0), btnFont)
        ConfigurarBtn(Me.btnEntradas,   btnSize, New Point(col3, rE2), "🎫  Entradas",   Color.FromArgb(0,  150, 136), btnFont)
        ConfigurarBtn(Me.btnEventos,    btnSize, New Point(col4, rE2), "📅  Eventos",    Color.FromArgb(33, 150, 243), btnFont)

        Dim rE3 As Integer = rE2 + btnH + gapY
        ConfigurarBtn(Me.btnPrestamos, btnSize, New Point(col1, rE3), "🔄  Préstamos", Color.FromArgb(63,  81, 181), btnFont)
        ConfigurarBtn(Me.btnReservas,  btnSize, New Point(col2, rE3), "📋  Reservas",  Color.FromArgb(76, 175,  80), btnFont)

        Me.pnlEmpleado.Controls.Add(Me.lblSeccionEmp)
        Me.pnlEmpleado.Controls.Add(Me.btnGuias)
        Me.pnlEmpleado.Controls.Add(Me.btnVisitantes)
        Me.pnlEmpleado.Controls.Add(Me.btnExposiciones)
        Me.pnlEmpleado.Controls.Add(Me.btnPiezas)
        Me.pnlEmpleado.Controls.Add(Me.btnSalas)
        Me.pnlEmpleado.Controls.Add(Me.btnDonaciones)
        Me.pnlEmpleado.Controls.Add(Me.btnEntradas)
        Me.pnlEmpleado.Controls.Add(Me.btnEventos)
        Me.pnlEmpleado.Controls.Add(Me.btnPrestamos)
        Me.pnlEmpleado.Controls.Add(Me.btnReservas)

        ' ══ BOTÓN SALIR — posición inicial; se ajusta en AplicarPermisos ═
        Me.btnSalir.Text = "🚪  Salir del Sistema"
        Me.btnSalir.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnSalir.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnSalir.ForeColor = Color.White
        Me.btnSalir.FlatStyle = FlatStyle.Flat
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.Size = btnSize
        Me.btnSalir.Location = New Point(30, pnlEmpleado.Bottom + 20)
        Me.btnSalir.Cursor = Cursors.Hand

        ' ══ FORM ══════════════════════════════════════════
        Me.ClientSize = New Size(1100, 750)
        Me.Controls.Add(Me.pnlScroll)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "FrmMenu"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión - Museo"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlEmpleado.ResumeLayout(False)
        Me.pnlScroll.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Private Sub ConfigurarBtn(btn As Button, sz As Size, loc As Point,
                               txt As String, color As Color, fnt As Font)
        btn.Size = sz
        btn.Location = loc
        btn.Text = txt
        btn.Font = fnt
        btn.BackColor = color
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
    End Sub

    Friend WithEvents pnlTitulo        As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo        As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo     As System.Windows.Forms.Label
    Friend WithEvents btnCambiarSesion As System.Windows.Forms.Button
    Friend WithEvents pnlScroll        As System.Windows.Forms.Panel

    Friend WithEvents pnlAdmin         As System.Windows.Forms.Panel
    Friend WithEvents lblSeccionAdmin  As System.Windows.Forms.Label
    Friend WithEvents btnEmpleados     As System.Windows.Forms.Button
    Friend WithEvents btnProveedores   As System.Windows.Forms.Button
    Friend WithEvents btnContratos     As System.Windows.Forms.Button
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents btnReportes      As System.Windows.Forms.Button
    Friend WithEvents btnInventario    As System.Windows.Forms.Button

    Friend WithEvents pnlEmpleado      As System.Windows.Forms.Panel
    Friend WithEvents lblSeccionEmp    As System.Windows.Forms.Label
    Friend WithEvents btnGuias         As System.Windows.Forms.Button
    Friend WithEvents btnVisitantes    As System.Windows.Forms.Button
    Friend WithEvents btnExposiciones  As System.Windows.Forms.Button
    Friend WithEvents btnPiezas        As System.Windows.Forms.Button
    Friend WithEvents btnSalas         As System.Windows.Forms.Button
    Friend WithEvents btnDonaciones    As System.Windows.Forms.Button
    Friend WithEvents btnEntradas      As System.Windows.Forms.Button
    Friend WithEvents btnEventos       As System.Windows.Forms.Button
    Friend WithEvents btnPrestamos     As System.Windows.Forms.Button
    Friend WithEvents btnReservas      As System.Windows.Forms.Button
    Friend WithEvents btnSalir         As System.Windows.Forms.Button

End Class
