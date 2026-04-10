<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporte
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

        ' ── Controles principales ────────────────────────────────────────
        Me.pnlTitulo             = New Panel()
        Me.lblTituloForm         = New Label()
        Me.lblUltimaActualizacion = New Label()
        Me.btnActualizar         = New Button()
        Me.pnlContenido          = New Panel()

        ' ── Tarjetas fila 1 ─────────────────────────────────────────────
        Me.pnlVisitantes         = New Panel()
        Me.lblIconVisitantes     = New Label()
        Me.lblTxtVisitantes      = New Label()
        Me.lblTotalVisitantes    = New Label()

        Me.pnlEntradas           = New Panel()
        Me.lblIconEntradas       = New Label()
        Me.lblTxtEntradas        = New Label()
        Me.lblTotalEntradas      = New Label()

        Me.pnlIngresos           = New Panel()
        Me.lblIconIngresos       = New Label()
        Me.lblTxtIngresos        = New Label()
        Me.lblTotalIngresos      = New Label()

        Me.pnlExposiciones       = New Panel()
        Me.lblIconExposiciones   = New Label()
        Me.lblTxtExposiciones    = New Label()
        Me.lblTotalExposiciones  = New Label()
        Me.lblTxtExpoActivas     = New Label()
        Me.lblExposicionesActivas = New Label()

        ' ── Tarjetas fila 2 ─────────────────────────────────────────────
        Me.pnlPiezas             = New Panel()
        Me.lblIconPiezas         = New Label()
        Me.lblTxtPiezas          = New Label()
        Me.lblTotalPiezas        = New Label()
        Me.lblTxtValorPiezas     = New Label()
        Me.lblValorPiezas        = New Label()

        Me.pnlManten             = New Panel()
        Me.lblIconManten         = New Label()
        Me.lblTxtManten          = New Label()
        Me.lblTxtPendientes      = New Label()
        Me.lblMantenimientosPendientes  = New Label()
        Me.lblTxtEnProceso       = New Label()
        Me.lblMantenimientosEnProceso   = New Label()
        Me.lblTxtCompletados     = New Label()
        Me.lblMantenimientosCompletados = New Label()

        Me.pnlEventos            = New Panel()
        Me.lblIconEventos        = New Label()
        Me.lblTxtEventos         = New Label()
        Me.lblTotalEventos       = New Label()
        Me.lblTxtEventosActivos  = New Label()
        Me.lblEventosActivos     = New Label()

        Me.pnlPrestamos          = New Panel()
        Me.lblIconPrestamos      = New Label()
        Me.lblTxtPrestamos       = New Label()
        Me.lblTxtPrestActivos    = New Label()
        Me.lblPrestamosActivos   = New Label()
        Me.lblTxtPrestVencidos   = New Label()
        Me.lblPrestamosVencidos  = New Label()

        ' ── Mes actual ──────────────────────────────────────────────────
        Me.pnlMes                = New Panel()
        Me.lblIconMes            = New Label()
        Me.lblTxtMes             = New Label()
        Me.lblTxtEntMes          = New Label()
        Me.lblEntradasMes        = New Label()
        Me.lblTxtIngMes          = New Label()
        Me.lblIngresosMes        = New Label()

        ' ── Filtro y tabla ──────────────────────────────────────────────
        Me.pnlFiltro             = New Panel()
        Me.lblTxtDesde           = New Label()
        Me.dtpDesde              = New DateTimePicker()
        Me.lblTxtHasta           = New Label()
        Me.dtpHasta              = New DateTimePicker()
        Me.btnFiltrar            = New Button()
        Me.lblResultadoFiltro    = New Label()
        Me.dgvResumen            = New DataGridView()

        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════════════
        ' PANEL TÍTULO
        ' ════════════════════════════════════════════════════════════════
        Me.pnlTitulo.BackColor = Color.FromArgb(69, 39, 160)
        Me.pnlTitulo.Dock      = DockStyle.Top
        Me.pnlTitulo.Height    = 60

        Me.lblTituloForm.Text      = "📊  Dashboard — Museo"
        Me.lblTituloForm.Font      = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTituloForm.ForeColor = Color.White
        Me.lblTituloForm.Location  = New Point(15, 13)
        Me.lblTituloForm.AutoSize  = True

        Me.lblUltimaActualizacion.Text      = ""
        Me.lblUltimaActualizacion.Font      = New Font("Segoe UI", 8)
        Me.lblUltimaActualizacion.ForeColor = Color.FromArgb(200, 200, 255)
        Me.lblUltimaActualizacion.Location  = New Point(15, 42)
        Me.lblUltimaActualizacion.AutoSize  = True

        Me.btnActualizar.Text             = "🔄  Actualizar"
        Me.btnActualizar.Font             = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnActualizar.BackColor        = Color.FromArgb(100, 70, 200)
        Me.btnActualizar.ForeColor        = Color.White
        Me.btnActualizar.FlatStyle        = FlatStyle.Flat
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.Size             = New Size(130, 34)
        Me.btnActualizar.Location         = New Point(850, 13)
        Me.btnActualizar.Cursor           = Cursors.Hand

        Me.pnlTitulo.Controls.AddRange(New Control() {
            Me.lblTituloForm, Me.lblUltimaActualizacion, Me.btnActualizar})

        ' ════════════════════════════════════════════════════════════════
        ' PANEL CONTENIDO (scroll)
        ' ════════════════════════════════════════════════════════════════
        Me.pnlContenido.Dock        = DockStyle.Fill
        Me.pnlContenido.AutoScroll  = True
        Me.pnlContenido.BackColor   = Color.FromArgb(240, 238, 248)
        Me.pnlContenido.Padding     = New Padding(20, 15, 20, 15)

        ' ════════════════════════════════════════════════════════════════
        ' HELPER: crea tarjeta base
        ' ════════════════════════════════════════════════════════════════
        Dim cardW As Integer = 215
        Dim cardH As Integer = 110
        Dim row1Y  As Integer = 10
        Dim row2Y  As Integer = row1Y + cardH + 15
        Dim row3Y  As Integer = row2Y + cardH + 15

        ' ── Visitantes ──────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlVisitantes, New Point(10, row1Y), New Size(cardW, cardH),
                          Color.FromArgb(25, 118, 210))
        Me.lblIconVisitantes.Text      = "👥"
        Me.lblIconVisitantes.Font      = New Font("Segoe UI", 22)
        Me.lblIconVisitantes.ForeColor = Color.White
        Me.lblIconVisitantes.Location  = New Point(10, 10)
        Me.lblIconVisitantes.AutoSize  = True
        Me.lblTxtVisitantes.Text       = "Visitantes"
        Me.lblTxtVisitantes.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtVisitantes.ForeColor  = Color.FromArgb(200, 230, 255)
        Me.lblTxtVisitantes.Location   = New Point(10, 55)
        Me.lblTxtVisitantes.AutoSize   = True
        Me.lblTotalVisitantes.Text     = "0"
        Me.lblTotalVisitantes.Font     = New Font("Segoe UI", 24, FontStyle.Bold)
        Me.lblTotalVisitantes.ForeColor = Color.White
        Me.lblTotalVisitantes.Location = New Point(120, 20)
        Me.lblTotalVisitantes.AutoSize = True
        Me.pnlVisitantes.Controls.AddRange(New Control() {
            Me.lblIconVisitantes, Me.lblTxtVisitantes, Me.lblTotalVisitantes})

        ' ── Entradas ────────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlEntradas, New Point(240, row1Y), New Size(cardW, cardH),
                          Color.FromArgb(0, 137, 123))
        Me.lblIconEntradas.Text      = "🎟"
        Me.lblIconEntradas.Font      = New Font("Segoe UI", 22)
        Me.lblIconEntradas.ForeColor = Color.White
        Me.lblIconEntradas.Location  = New Point(10, 10)
        Me.lblIconEntradas.AutoSize  = True
        Me.lblTxtEntradas.Text       = "Entradas"
        Me.lblTxtEntradas.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtEntradas.ForeColor  = Color.FromArgb(200, 255, 245)
        Me.lblTxtEntradas.Location   = New Point(10, 55)
        Me.lblTxtEntradas.AutoSize   = True
        Me.lblTotalEntradas.Text     = "0"
        Me.lblTotalEntradas.Font     = New Font("Segoe UI", 24, FontStyle.Bold)
        Me.lblTotalEntradas.ForeColor = Color.White
        Me.lblTotalEntradas.Location = New Point(120, 20)
        Me.lblTotalEntradas.AutoSize = True
        Me.pnlEntradas.Controls.AddRange(New Control() {
            Me.lblIconEntradas, Me.lblTxtEntradas, Me.lblTotalEntradas})

        ' ── Ingresos ────────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlIngresos, New Point(470, row1Y), New Size(cardW, cardH),
                          Color.FromArgb(46, 125, 50))
        Me.lblIconIngresos.Text      = "💰"
        Me.lblIconIngresos.Font      = New Font("Segoe UI", 22)
        Me.lblIconIngresos.ForeColor = Color.White
        Me.lblIconIngresos.Location  = New Point(10, 10)
        Me.lblIconIngresos.AutoSize  = True
        Me.lblTxtIngresos.Text       = "Ingresos Totales"
        Me.lblTxtIngresos.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtIngresos.ForeColor  = Color.FromArgb(200, 255, 200)
        Me.lblTxtIngresos.Location   = New Point(10, 55)
        Me.lblTxtIngresos.AutoSize   = True
        Me.lblTotalIngresos.Text     = "RD$ 0"
        Me.lblTotalIngresos.Font     = New Font("Segoe UI", 13, FontStyle.Bold)
        Me.lblTotalIngresos.ForeColor = Color.White
        Me.lblTotalIngresos.Location = New Point(10, 75)
        Me.lblTotalIngresos.AutoSize = True
        Me.pnlIngresos.Controls.AddRange(New Control() {
            Me.lblIconIngresos, Me.lblTxtIngresos, Me.lblTotalIngresos})

        ' ── Exposiciones ────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlExposiciones, New Point(700, row1Y), New Size(cardW, cardH),
                          Color.FromArgb(173, 20, 87))
        Me.lblIconExposiciones.Text      = "🖼"
        Me.lblIconExposiciones.Font      = New Font("Segoe UI", 22)
        Me.lblIconExposiciones.ForeColor = Color.White
        Me.lblIconExposiciones.Location  = New Point(10, 8)
        Me.lblIconExposiciones.AutoSize  = True
        Me.lblTxtExposiciones.Text       = "Exposiciones"
        Me.lblTxtExposiciones.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtExposiciones.ForeColor  = Color.FromArgb(255, 200, 220)
        Me.lblTxtExposiciones.Location   = New Point(10, 45)
        Me.lblTxtExposiciones.AutoSize   = True
        Me.lblTotalExposiciones.Text     = "0"
        Me.lblTotalExposiciones.Font     = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblTotalExposiciones.ForeColor = Color.White
        Me.lblTotalExposiciones.Location = New Point(130, 12)
        Me.lblTotalExposiciones.AutoSize = True
        Me.lblTxtExpoActivas.Text        = "Activas:"
        Me.lblTxtExpoActivas.Font        = New Font("Segoe UI", 8)
        Me.lblTxtExpoActivas.ForeColor   = Color.FromArgb(255, 200, 220)
        Me.lblTxtExpoActivas.Location    = New Point(10, 68)
        Me.lblTxtExpoActivas.AutoSize    = True
        Me.lblExposicionesActivas.Text   = "0"
        Me.lblExposicionesActivas.Font   = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblExposicionesActivas.ForeColor = Color.White
        Me.lblExposicionesActivas.Location  = New Point(65, 66)
        Me.lblExposicionesActivas.AutoSize  = True
        Me.pnlExposiciones.Controls.AddRange(New Control() {
            Me.lblIconExposiciones, Me.lblTxtExposiciones, Me.lblTotalExposiciones,
            Me.lblTxtExpoActivas, Me.lblExposicionesActivas})

        ' ── Piezas ──────────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlPiezas, New Point(10, row2Y), New Size(cardW, cardH),
                          Color.FromArgb(230, 81, 0))
        Me.lblIconPiezas.Text      = "🏺"
        Me.lblIconPiezas.Font      = New Font("Segoe UI", 22)
        Me.lblIconPiezas.ForeColor = Color.White
        Me.lblIconPiezas.Location  = New Point(10, 8)
        Me.lblIconPiezas.AutoSize  = True
        Me.lblTxtPiezas.Text       = "Piezas"
        Me.lblTxtPiezas.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtPiezas.ForeColor  = Color.FromArgb(255, 220, 180)
        Me.lblTxtPiezas.Location   = New Point(10, 45)
        Me.lblTxtPiezas.AutoSize   = True
        Me.lblTotalPiezas.Text     = "0"
        Me.lblTotalPiezas.Font     = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblTotalPiezas.ForeColor = Color.White
        Me.lblTotalPiezas.Location = New Point(130, 12)
        Me.lblTotalPiezas.AutoSize = True
        Me.lblTxtValorPiezas.Text  = "Valor estimado:"
        Me.lblTxtValorPiezas.Font  = New Font("Segoe UI", 8)
        Me.lblTxtValorPiezas.ForeColor = Color.FromArgb(255, 220, 180)
        Me.lblTxtValorPiezas.Location  = New Point(10, 68)
        Me.lblTxtValorPiezas.AutoSize  = True
        Me.lblValorPiezas.Text         = "RD$ 0"
        Me.lblValorPiezas.Font         = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblValorPiezas.ForeColor    = Color.White
        Me.lblValorPiezas.Location     = New Point(10, 82)
        Me.lblValorPiezas.AutoSize     = True
        Me.pnlPiezas.Controls.AddRange(New Control() {
            Me.lblIconPiezas, Me.lblTxtPiezas, Me.lblTotalPiezas,
            Me.lblTxtValorPiezas, Me.lblValorPiezas})

        ' ── Mantenimientos ──────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlManten, New Point(240, row2Y), New Size(cardW, cardH),
                          Color.FromArgb(74, 20, 140))
        Me.lblIconManten.Text      = "🔧"
        Me.lblIconManten.Font      = New Font("Segoe UI", 22)
        Me.lblIconManten.ForeColor = Color.White
        Me.lblIconManten.Location  = New Point(10, 8)
        Me.lblIconManten.AutoSize  = True
        Me.lblTxtManten.Text       = "Mantenimientos"
        Me.lblTxtManten.Font       = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblTxtManten.ForeColor  = Color.FromArgb(220, 190, 255)
        Me.lblTxtManten.Location   = New Point(90, 8)
        Me.lblTxtManten.AutoSize   = True
        Me.lblTxtPendientes.Text   = "⏳ Pendientes:"
        Me.lblTxtPendientes.Font   = New Font("Segoe UI", 8)
        Me.lblTxtPendientes.ForeColor = Color.FromArgb(255, 200, 100)
        Me.lblTxtPendientes.Location  = New Point(10, 38)
        Me.lblTxtPendientes.AutoSize  = True
        Me.lblMantenimientosPendientes.Text     = "0"
        Me.lblMantenimientosPendientes.Font     = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblMantenimientosPendientes.ForeColor = Color.White
        Me.lblMantenimientosPendientes.Location  = New Point(105, 38)
        Me.lblMantenimientosPendientes.AutoSize  = True
        Me.lblTxtEnProceso.Text    = "⚙ En Proceso:"
        Me.lblTxtEnProceso.Font    = New Font("Segoe UI", 8)
        Me.lblTxtEnProceso.ForeColor = Color.FromArgb(150, 220, 255)
        Me.lblTxtEnProceso.Location  = New Point(10, 58)
        Me.lblTxtEnProceso.AutoSize  = True
        Me.lblMantenimientosEnProceso.Text     = "0"
        Me.lblMantenimientosEnProceso.Font     = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblMantenimientosEnProceso.ForeColor = Color.White
        Me.lblMantenimientosEnProceso.Location  = New Point(105, 58)
        Me.lblMantenimientosEnProceso.AutoSize  = True
        Me.lblTxtCompletados.Text  = "✅ Completados:"
        Me.lblTxtCompletados.Font  = New Font("Segoe UI", 8)
        Me.lblTxtCompletados.ForeColor = Color.FromArgb(150, 255, 180)
        Me.lblTxtCompletados.Location  = New Point(10, 78)
        Me.lblTxtCompletados.AutoSize  = True
        Me.lblMantenimientosCompletados.Text     = "0"
        Me.lblMantenimientosCompletados.Font     = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblMantenimientosCompletados.ForeColor = Color.White
        Me.lblMantenimientosCompletados.Location  = New Point(105, 78)
        Me.lblMantenimientosCompletados.AutoSize  = True
        Me.pnlManten.Controls.AddRange(New Control() {
            Me.lblIconManten, Me.lblTxtManten,
            Me.lblTxtPendientes,  Me.lblMantenimientosPendientes,
            Me.lblTxtEnProceso,   Me.lblMantenimientosEnProceso,
            Me.lblTxtCompletados, Me.lblMantenimientosCompletados})

        ' ── Eventos ─────────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlEventos, New Point(470, row2Y), New Size(cardW, cardH),
                          Color.FromArgb(2, 119, 189))
        Me.lblIconEventos.Text      = "📅"
        Me.lblIconEventos.Font      = New Font("Segoe UI", 22)
        Me.lblIconEventos.ForeColor = Color.White
        Me.lblIconEventos.Location  = New Point(10, 8)
        Me.lblIconEventos.AutoSize  = True
        Me.lblTxtEventos.Text       = "Eventos"
        Me.lblTxtEventos.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtEventos.ForeColor  = Color.FromArgb(180, 230, 255)
        Me.lblTxtEventos.Location   = New Point(10, 45)
        Me.lblTxtEventos.AutoSize   = True
        Me.lblTotalEventos.Text     = "0"
        Me.lblTotalEventos.Font     = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblTotalEventos.ForeColor = Color.White
        Me.lblTotalEventos.Location = New Point(130, 12)
        Me.lblTotalEventos.AutoSize = True
        Me.lblTxtEventosActivos.Text   = "Vigentes:"
        Me.lblTxtEventosActivos.Font   = New Font("Segoe UI", 8)
        Me.lblTxtEventosActivos.ForeColor = Color.FromArgb(180, 230, 255)
        Me.lblTxtEventosActivos.Location  = New Point(10, 68)
        Me.lblTxtEventosActivos.AutoSize  = True
        Me.lblEventosActivos.Text      = "0"
        Me.lblEventosActivos.Font      = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblEventosActivos.ForeColor = Color.White
        Me.lblEventosActivos.Location  = New Point(65, 66)
        Me.lblEventosActivos.AutoSize  = True
        Me.pnlEventos.Controls.AddRange(New Control() {
            Me.lblIconEventos, Me.lblTxtEventos, Me.lblTotalEventos,
            Me.lblTxtEventosActivos, Me.lblEventosActivos})

        ' ── Préstamos ───────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlPrestamos, New Point(700, row2Y), New Size(cardW, cardH),
                          Color.FromArgb(130, 119, 23))
        Me.lblIconPrestamos.Text      = "📦"
        Me.lblIconPrestamos.Font      = New Font("Segoe UI", 22)
        Me.lblIconPrestamos.ForeColor = Color.White
        Me.lblIconPrestamos.Location  = New Point(10, 8)
        Me.lblIconPrestamos.AutoSize  = True
        Me.lblTxtPrestamos.Text       = "Préstamos"
        Me.lblTxtPrestamos.Font       = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblTxtPrestamos.ForeColor  = Color.FromArgb(255, 240, 150)
        Me.lblTxtPrestamos.Location   = New Point(90, 8)
        Me.lblTxtPrestamos.AutoSize   = True
        Me.lblTxtPrestActivos.Text    = "✅ Activos:"
        Me.lblTxtPrestActivos.Font    = New Font("Segoe UI", 8)
        Me.lblTxtPrestActivos.ForeColor = Color.FromArgb(200, 255, 200)
        Me.lblTxtPrestActivos.Location  = New Point(10, 40)
        Me.lblTxtPrestActivos.AutoSize  = True
        Me.lblPrestamosActivos.Text   = "0"
        Me.lblPrestamosActivos.Font   = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblPrestamosActivos.ForeColor = Color.White
        Me.lblPrestamosActivos.Location  = New Point(85, 40)
        Me.lblPrestamosActivos.AutoSize  = True
        Me.lblTxtPrestVencidos.Text   = "⚠ Vencidos:"
        Me.lblTxtPrestVencidos.Font   = New Font("Segoe UI", 8)
        Me.lblTxtPrestVencidos.ForeColor = Color.FromArgb(255, 180, 150)
        Me.lblTxtPrestVencidos.Location  = New Point(10, 65)
        Me.lblTxtPrestVencidos.AutoSize  = True
        Me.lblPrestamosVencidos.Text  = "0"
        Me.lblPrestamosVencidos.Font  = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblPrestamosVencidos.ForeColor = Color.FromArgb(255, 100, 100)
        Me.lblPrestamosVencidos.Location  = New Point(85, 65)
        Me.lblPrestamosVencidos.AutoSize  = True
        Me.pnlPrestamos.Controls.AddRange(New Control() {
            Me.lblIconPrestamos, Me.lblTxtPrestamos,
            Me.lblTxtPrestActivos, Me.lblPrestamosActivos,
            Me.lblTxtPrestVencidos, Me.lblPrestamosVencidos})

        ' ── Mes actual ──────────────────────────────────────────────────
        ConfigurarTarjeta(Me.pnlMes, New Point(10, row3Y), New Size(910, 80),
                          Color.FromArgb(21, 101, 192))
        Me.lblIconMes.Text      = "📆"
        Me.lblIconMes.Font      = New Font("Segoe UI", 20)
        Me.lblIconMes.ForeColor = Color.White
        Me.lblIconMes.Location  = New Point(10, 18)
        Me.lblIconMes.AutoSize  = True
        Me.lblTxtMes.Text       = "MES ACTUAL  (" & Date.Today.ToString("MMMM yyyy").ToUpper() & ")"
        Me.lblTxtMes.Font       = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblTxtMes.ForeColor  = Color.FromArgb(180, 220, 255)
        Me.lblTxtMes.Location   = New Point(50, 10)
        Me.lblTxtMes.AutoSize   = True
        Me.lblTxtEntMes.Text    = "Entradas:"
        Me.lblTxtEntMes.Font    = New Font("Segoe UI", 9)
        Me.lblTxtEntMes.ForeColor = Color.FromArgb(200, 235, 255)
        Me.lblTxtEntMes.Location  = New Point(50, 38)
        Me.lblTxtEntMes.AutoSize  = True
        Me.lblEntradasMes.Text  = "0"
        Me.lblEntradasMes.Font  = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblEntradasMes.ForeColor = Color.White
        Me.lblEntradasMes.Location  = New Point(115, 34)
        Me.lblEntradasMes.AutoSize  = True
        Me.lblTxtIngMes.Text    = "Ingresos:"
        Me.lblTxtIngMes.Font    = New Font("Segoe UI", 9)
        Me.lblTxtIngMes.ForeColor = Color.FromArgb(200, 235, 255)
        Me.lblTxtIngMes.Location  = New Point(300, 38)
        Me.lblTxtIngMes.AutoSize  = True
        Me.lblIngresosMes.Text  = "RD$ 0"
        Me.lblIngresosMes.Font  = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblIngresosMes.ForeColor = Color.White
        Me.lblIngresosMes.Location  = New Point(365, 34)
        Me.lblIngresosMes.AutoSize  = True
        Me.pnlMes.Controls.AddRange(New Control() {
            Me.lblIconMes, Me.lblTxtMes,
            Me.lblTxtEntMes, Me.lblEntradasMes,
            Me.lblTxtIngMes, Me.lblIngresosMes})

        ' ── Panel de filtro ─────────────────────────────────────────────
        Me.pnlFiltro.Location    = New Point(10, row3Y + 95)
        Me.pnlFiltro.Size        = New Size(910, 50)
        Me.pnlFiltro.BackColor   = Color.White
        Me.pnlFiltro.BorderStyle = BorderStyle.FixedSingle

        Me.lblTxtDesde.Text      = "Desde:"
        Me.lblTxtDesde.Font      = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtDesde.Location  = New Point(10, 15)
        Me.lblTxtDesde.AutoSize  = True
        Me.dtpDesde.Location     = New Point(60, 11)
        Me.dtpDesde.Size         = New Size(160, 28)
        Me.dtpDesde.Format       = DateTimePickerFormat.Short
        Me.dtpDesde.Value        = Date.Today.AddMonths(-1)

        Me.lblTxtHasta.Text      = "Hasta:"
        Me.lblTxtHasta.Font      = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblTxtHasta.Location  = New Point(240, 15)
        Me.lblTxtHasta.AutoSize  = True
        Me.dtpHasta.Location     = New Point(290, 11)
        Me.dtpHasta.Size         = New Size(160, 28)
        Me.dtpHasta.Format       = DateTimePickerFormat.Short
        Me.dtpHasta.Value        = Date.Today

        Me.btnFiltrar.Text       = "🔍 Filtrar"
        Me.btnFiltrar.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnFiltrar.BackColor  = Color.FromArgb(69, 39, 160)
        Me.btnFiltrar.ForeColor  = Color.White
        Me.btnFiltrar.FlatStyle  = FlatStyle.Flat
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.Location   = New Point(470, 10)
        Me.btnFiltrar.Size       = New Size(110, 30)
        Me.btnFiltrar.Cursor     = Cursors.Hand

        Me.lblResultadoFiltro.Text      = ""
        Me.lblResultadoFiltro.Font      = New Font("Segoe UI", 8, FontStyle.Italic)
        Me.lblResultadoFiltro.ForeColor = Color.FromArgb(69, 39, 160)
        Me.lblResultadoFiltro.Location  = New Point(595, 15)
        Me.lblResultadoFiltro.AutoSize  = True

        Me.pnlFiltro.Controls.AddRange(New Control() {
            Me.lblTxtDesde, Me.dtpDesde,
            Me.lblTxtHasta, Me.dtpHasta,
            Me.btnFiltrar,  Me.lblResultadoFiltro})

        ' ── DataGridView ────────────────────────────────────────────────
        Me.dgvResumen.Location     = New Point(10, row3Y + 155)
        Me.dgvResumen.Size         = New Size(910, 220)
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.ReadOnly     = True
        Me.dgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResumen.BackgroundColor = Color.White
        Me.dgvResumen.BorderStyle  = BorderStyle.None
        Me.dgvResumen.RowHeadersVisible = False
        Me.dgvResumen.Font         = New Font("Segoe UI", 9)
        Me.dgvResumen.ColumnHeadersDefaultCellStyle.Font     = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvResumen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(69, 39, 160)
        Me.dgvResumen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvResumen.EnableHeadersVisualStyles = False
        Me.dgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 255)

        ' ════════════════════════════════════════════════════════════════
        ' AGREGAR TODO AL PANEL CONTENIDO
        ' ════════════════════════════════════════════════════════════════
        Me.pnlContenido.Controls.AddRange(New Control() {
            Me.pnlVisitantes, Me.pnlEntradas, Me.pnlIngresos, Me.pnlExposiciones,
            Me.pnlPiezas, Me.pnlManten, Me.pnlEventos, Me.pnlPrestamos,
            Me.pnlMes, Me.pnlFiltro, Me.dgvResumen})

        ' ════════════════════════════════════════════════════════════════
        ' FORM
        ' ════════════════════════════════════════════════════════════════
        Me.ClientSize      = New Size(990, 720)
        Me.Controls.AddRange(New Control() {Me.pnlContenido, Me.pnlTitulo})
        Me.Text            = "Dashboard — Museo"
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.BackColor       = Color.FromArgb(240, 238, 248)
        Me.ResumeLayout(False)
    End Sub

    ''' <summary>
    ''' Aplica estilo visual uniforme a todas las tarjetas del dashboard.
    ''' </summary>
    Private Sub ConfigurarTarjeta(pnl As Panel, loc As Point, sz As Size, color As Color)
        pnl.Location    = loc
        pnl.Size        = sz
        pnl.BackColor   = color
        pnl.BorderStyle = BorderStyle.None
        ' Sombra simulada con padding
        pnl.Padding     = New Padding(2)
    End Sub

    ' ── Declaraciones ────────────────────────────────────────────────────
    Friend WithEvents pnlTitulo              As Panel
    Friend WithEvents lblTituloForm          As Label
    Friend WithEvents lblUltimaActualizacion As Label
    Friend WithEvents btnActualizar          As Button
    Friend WithEvents pnlContenido           As Panel

    Friend WithEvents pnlVisitantes          As Panel
    Friend WithEvents lblIconVisitantes      As Label
    Friend WithEvents lblTxtVisitantes       As Label
    Friend WithEvents lblTotalVisitantes     As Label

    Friend WithEvents pnlEntradas            As Panel
    Friend WithEvents lblIconEntradas        As Label
    Friend WithEvents lblTxtEntradas         As Label
    Friend WithEvents lblTotalEntradas       As Label

    Friend WithEvents pnlIngresos            As Panel
    Friend WithEvents lblIconIngresos        As Label
    Friend WithEvents lblTxtIngresos         As Label
    Friend WithEvents lblTotalIngresos       As Label

    Friend WithEvents pnlExposiciones        As Panel
    Friend WithEvents lblIconExposiciones    As Label
    Friend WithEvents lblTxtExposiciones     As Label
    Friend WithEvents lblTotalExposiciones   As Label
    Friend WithEvents lblTxtExpoActivas      As Label
    Friend WithEvents lblExposicionesActivas As Label

    Friend WithEvents pnlPiezas              As Panel
    Friend WithEvents lblIconPiezas          As Label
    Friend WithEvents lblTxtPiezas           As Label
    Friend WithEvents lblTotalPiezas         As Label
    Friend WithEvents lblTxtValorPiezas      As Label
    Friend WithEvents lblValorPiezas         As Label

    Friend WithEvents pnlManten              As Panel
    Friend WithEvents lblIconManten          As Label
    Friend WithEvents lblTxtManten           As Label
    Friend WithEvents lblTxtPendientes       As Label
    Friend WithEvents lblMantenimientosPendientes  As Label
    Friend WithEvents lblTxtEnProceso        As Label
    Friend WithEvents lblMantenimientosEnProceso   As Label
    Friend WithEvents lblTxtCompletados      As Label
    Friend WithEvents lblMantenimientosCompletados As Label

    Friend WithEvents pnlEventos             As Panel
    Friend WithEvents lblIconEventos         As Label
    Friend WithEvents lblTxtEventos          As Label
    Friend WithEvents lblTotalEventos        As Label
    Friend WithEvents lblTxtEventosActivos   As Label
    Friend WithEvents lblEventosActivos      As Label

    Friend WithEvents pnlPrestamos           As Panel
    Friend WithEvents lblIconPrestamos       As Label
    Friend WithEvents lblTxtPrestamos        As Label
    Friend WithEvents lblTxtPrestActivos     As Label
    Friend WithEvents lblPrestamosActivos    As Label
    Friend WithEvents lblTxtPrestVencidos    As Label
    Friend WithEvents lblPrestamosVencidos   As Label

    Friend WithEvents pnlMes                 As Panel
    Friend WithEvents lblIconMes             As Label
    Friend WithEvents lblTxtMes              As Label
    Friend WithEvents lblTxtEntMes           As Label
    Friend WithEvents lblEntradasMes         As Label
    Friend WithEvents lblTxtIngMes           As Label
    Friend WithEvents lblIngresosMes         As Label

    Friend WithEvents pnlFiltro              As Panel
    Friend WithEvents lblTxtDesde            As Label
    Friend WithEvents dtpDesde               As DateTimePicker
    Friend WithEvents lblTxtHasta            As Label
    Friend WithEvents dtpHasta               As DateTimePicker
    Friend WithEvents btnFiltrar             As Button
    Friend WithEvents lblResultadoFiltro     As Label
    Friend WithEvents dgvResumen             As DataGridView

End Class
