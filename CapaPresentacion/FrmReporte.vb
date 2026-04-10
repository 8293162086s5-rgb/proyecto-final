Imports CapaNegocio
Imports CapaNegocio.CapaNegocio
Imports System.Linq

Public Class FrmReporte

    Dim blEntrada       As New EntradaBL()
    Dim blVisitante     As New VisitanteBL()
    Dim blExposicion    As New ExposicionBL()
    Dim blPieza         As New PiezaBL()
    Dim blMantenimiento As New MantenimientoBL()
    Dim blEvento        As New EventoBL()
    Dim blPrestamo      As New PrestamoBL()

    Private Sub FrmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstadisticas()
    End Sub

    ''' <summary>
    ''' Carga todas las estadísticas del sistema y las muestra en los controles del dashboard.
    ''' </summary>
    Private Sub CargarEstadisticas()
        Try
            ' ── Visitantes ──────────────────────────────────────────────
            Dim visitantes = blVisitante.Listar()
            lblTotalVisitantes.Text = visitantes.Count.ToString()

            ' ── Entradas ────────────────────────────────────────────────
            Dim entradas = blEntrada.Listar()
            lblTotalEntradas.Text = entradas.Count.ToString()
            Dim ingresos As Decimal = entradas.Sum(Function(ent) ent.Precio * ent.Cantidad)
            lblTotalIngresos.Text = "RD$ " & ingresos.ToString("N2")

            ' ── Exposiciones ────────────────────────────────────────────
            Dim exposiciones = blExposicion.Listar()
            lblTotalExposiciones.Text   = exposiciones.Count.ToString()
            lblExposicionesActivas.Text = exposiciones.Where(Function(ex) ex.Estado = "Activa").Count().ToString()

            ' ── Piezas ──────────────────────────────────────────────────
            Dim piezas = blPieza.Listar()
            lblTotalPiezas.Text = piezas.Count.ToString()
            Dim valorTotal As Decimal = piezas.Sum(Function(p) p.ValorEstimado)
            lblValorPiezas.Text = "RD$ " & valorTotal.ToString("N2")

            ' ── Mantenimientos ──────────────────────────────────────────
            Dim mantenimientos = blMantenimiento.Listar()
            lblMantenimientosPendientes.Text  = mantenimientos.Where(Function(m) m.Estado = "Pendiente").Count().ToString()
            lblMantenimientosEnProceso.Text   = mantenimientos.Where(Function(m) m.Estado = "En Proceso").Count().ToString()
            lblMantenimientosCompletados.Text = mantenimientos.Where(Function(m) m.Estado = "Completado").Count().ToString()

            ' ── Eventos ─────────────────────────────────────────────────
            Dim eventos = blEvento.Listar()
            lblTotalEventos.Text   = eventos.Count.ToString()
            lblEventosActivos.Text = eventos.Where(Function(ev) ev.Estado = "Activo" OrElse ev.FechaFin >= Date.Today).Count().ToString()

            ' ── Préstamos ───────────────────────────────────────────────
            Dim prestamos = blPrestamo.Listar()
            lblPrestamosActivos.Text  = prestamos.Where(Function(pr) pr.Estado = "Activo").Count().ToString()
            lblPrestamosVencidos.Text = prestamos.Where(Function(pr) pr.Estado = "Activo" AndAlso pr.FechaDevolucion < Date.Today).Count().ToString()

            ' ── Tabla resumen de entradas recientes ─────────────────────
            Dim recientes = entradas.OrderByDescending(Function(ent) ent.Fecha).Take(10).ToList()
            dgvResumen.DataSource = recientes

            ' ── Entradas del mes actual ──────────────────────────────────
            Dim mesActual = entradas.Where(Function(ent) ent.Fecha.Month = Date.Today.Month AndAlso
                                                         ent.Fecha.Year  = Date.Today.Year).ToList()
            lblEntradasMes.Text = mesActual.Count.ToString()
            lblIngresosMes.Text = "RD$ " & mesActual.Sum(Function(ent) ent.Precio * ent.Cantidad).ToString("N2")

            lblUltimaActualizacion.Text = "Última actualización: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        Catch ex As Exception
            MessageBox.Show("Error al cargar estadísticas: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Refresca todos los indicadores del dashboard al hacer clic en el botón Actualizar.
    ''' </summary>
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarEstadisticas()
        MessageBox.Show("Dashboard actualizado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Filtra las entradas por el rango de fechas seleccionado.
    ''' </summary>
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Dim desde As Date = dtpDesde.Value.Date
            Dim hasta As Date = dtpHasta.Value.Date

            If desde > hasta Then
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim todasEntradas = blEntrada.Listar()
            Dim filtradas     = todasEntradas.Where(Function(ent) ent.Fecha.Date >= desde AndAlso
                                                                  ent.Fecha.Date <= hasta).ToList()

            dgvResumen.DataSource = filtradas

            Dim totalFiltrado As Decimal = filtradas.Sum(Function(ent) ent.Precio * ent.Cantidad)
            lblResultadoFiltro.Text = $"Período {desde:dd/MM/yyyy} – {hasta:dd/MM/yyyy}:  " &
                                      $"{filtradas.Count} entradas  |  RD$ {totalFiltrado:N2} ingresos"

        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
