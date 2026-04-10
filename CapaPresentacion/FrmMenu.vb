Public Class FrmMenu

    Private _rol As String
    Private _nombreUsuario As String

    Public Sub New(rol As String, nombreUsuario As String)
        InitializeComponent()
        _rol = rol
        _nombreUsuario = nombreUsuario
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Gestión - Museo"
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(245, 245, 245)
        lblSubtitulo.Text = $"Bienvenido, {_nombreUsuario}  |  Rol: {_rol}"
        AplicarPermisos()
    End Sub

    Private Sub AplicarPermisos()
        Dim esAdmin As Boolean = (_rol.ToLower() = "admin")

        ' Color del header según rol
        If esAdmin Then
            pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Else
            pnlTitulo.BackColor = Color.FromArgb(27, 94, 32)
        End If

        ' Mostrar/ocultar sección Admin completa
        pnlAdmin.Visible = esAdmin

        ' Reubicar sección Empleado según si Admin está visible o no
        If esAdmin Then
            pnlEmpleado.Location = New Point(30, pnlAdmin.Bottom + 20)
        Else
            pnlEmpleado.Location = New Point(30, 20)
        End If

        ' Reubicar botón Salir justo debajo de la sección Empleado
        btnSalir.Location = New Point(30, pnlEmpleado.Bottom + 20)
    End Sub

    Private Sub FrmMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Mantener botón Cambiar Sesión pegado a la derecha del header
        btnCambiarSesion.Location = New Point(pnlTitulo.Width - btnCambiarSesion.Width - 20, 27)
    End Sub

    ' ── ADMIN ────────────────────────────────────────────────────────────
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Call (New FrmEmpleado()).ShowDialog()
    End Sub
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Call (New FrmProveedor()).ShowDialog()
    End Sub
    Private Sub btnContratos_Click(sender As Object, e As EventArgs) Handles btnContratos.Click
        Call (New FrmContrato()).ShowDialog()
    End Sub
    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        Call (New FrmMantenimiento()).ShowDialog()
    End Sub
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Call (New FrmReporte()).ShowDialog()
    End Sub
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Call (New FrmInventario()).ShowDialog()
    End Sub

    ' ── EMPLEADO ─────────────────────────────────────────────────────────
    Private Sub btnGuias_Click(sender As Object, e As EventArgs) Handles btnGuias.Click
        Call (New FrmGuia()).ShowDialog()
    End Sub
    Private Sub btnVisitantes_Click(sender As Object, e As EventArgs) Handles btnVisitantes.Click
        Call (New FrmVisitante()).ShowDialog()
    End Sub
    Private Sub btnExposiciones_Click(sender As Object, e As EventArgs) Handles btnExposiciones.Click
        Call (New FrmExposicion()).ShowDialog()
    End Sub
    Private Sub btnPiezas_Click(sender As Object, e As EventArgs) Handles btnPiezas.Click
        Call (New FrmPieza()).ShowDialog()
    End Sub
    Private Sub btnSalas_Click(sender As Object, e As EventArgs) Handles btnSalas.Click
        Call (New FrmSala()).ShowDialog()
    End Sub
    Private Sub btnDonaciones_Click(sender As Object, e As EventArgs) Handles btnDonaciones.Click
        Call (New FrmDonacion()).ShowDialog()
    End Sub
    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        Call (New FrmEntrada()).ShowDialog()
    End Sub
    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        Call (New FrmEvento()).ShowDialog()
    End Sub
    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Call (New FrmPrestamo()).ShowDialog()
    End Sub
    Private Sub btnReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        Call (New FrmReserva()).ShowDialog()
    End Sub

    ' ── CAMBIAR SESIÓN ───────────────────────────────────────────────────
    Private Sub btnCambiarSesion_Click(sender As Object, e As EventArgs) Handles btnCambiarSesion.Click
        Dim resp = MessageBox.Show("¿Desea cerrar sesión y volver al inicio de sesión?",
                                   "Cambiar sesión",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            Dim login As New FrmLogin()
            Me.Hide()
            login.ShowDialog()
            Me.Close()
        End If
    End Sub

    ' ── SALIR ────────────────────────────────────────────────────────────
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir del sistema?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
