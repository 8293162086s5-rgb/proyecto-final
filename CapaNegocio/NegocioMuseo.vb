Imports CapaDatos
Imports CapaEntidades

Namespace CapaNegocio

    ' =============================================
    '  NEGOCIO: Empleado
    ' =============================================
    Public Class EmpleadoBL
        Private dao As New EmpleadoDAO()
        Public Sub Agregar(emp As Empleado)
            If String.IsNullOrWhiteSpace(emp.Nombre)    Then Throw New Exception("El nombre del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Apellido)  Then Throw New Exception("El apellido del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Cargo)     Then Throw New Exception("El cargo del empleado es obligatorio.")
            If emp.FechaIngreso > Date.Today            Then Throw New Exception("La fecha de ingreso no puede ser futura.")
            dao.Agregar(emp)
        End Sub
        Public Function Listar() As List(Of Empleado)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(emp As Empleado)
            If String.IsNullOrWhiteSpace(emp.Nombre)   Then Throw New Exception("El nombre del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Apellido) Then Throw New Exception("El apellido del empleado es obligatorio.")
            dao.Actualizar(emp)
        End Sub
        Public Sub Eliminar(idEmpleado As Integer)
            If idEmpleado <= 0 Then Throw New Exception("ID de empleado inválido.")
            dao.Eliminar(idEmpleado)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Guia
    ' =============================================
    Public Class GuiaBL
        Private dao As New GuiaDAO()
        Public Sub Agregar(guia As Guia)
            If String.IsNullOrWhiteSpace(guia.Nombre)   Then Throw New Exception("El nombre del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Apellido) Then Throw New Exception("El apellido del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Idioma)   Then Throw New Exception("El idioma del guía es obligatorio.")
            dao.Agregar(guia)
        End Sub
        Public Function Listar() As List(Of Guia)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(guia As Guia)
            If String.IsNullOrWhiteSpace(guia.Nombre)   Then Throw New Exception("El nombre del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Apellido) Then Throw New Exception("El apellido del guía es obligatorio.")
            dao.Actualizar(guia)
        End Sub
        Public Sub Eliminar(idGuia As Integer)
            If idGuia <= 0 Then Throw New Exception("ID de guía inválido.")
            dao.Eliminar(idGuia)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Visitante
    ' =============================================
    Public Class VisitanteBL
        Private dao As New VisitanteDAO()
        Public Sub Agregar(vis As Visitante)
            If String.IsNullOrWhiteSpace(vis.Nombre)            Then Throw New Exception("El nombre del visitante es obligatorio.")
            If String.IsNullOrWhiteSpace(vis.Apellido)          Then Throw New Exception("El apellido del visitante es obligatorio.")
            If String.IsNullOrWhiteSpace(vis.DocumentoIdentidad) Then Throw New Exception("El documento de identidad es obligatorio.")
            If vis.Edad < 0 OrElse vis.Edad > 120              Then Throw New Exception("La edad debe estar entre 0 y 120.")
            dao.Agregar(vis)
        End Sub
        Public Function Listar() As List(Of Visitante)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(vis As Visitante)
            If String.IsNullOrWhiteSpace(vis.Nombre) Then Throw New Exception("El nombre del visitante es obligatorio.")
            If vis.Edad < 0 OrElse vis.Edad > 120   Then Throw New Exception("La edad debe estar entre 0 y 120.")
            dao.Actualizar(vis)
        End Sub
        Public Sub Eliminar(idVisitante As Integer)
            If idVisitante <= 0 Then Throw New Exception("ID de visitante inválido.")
            dao.Eliminar(idVisitante)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Sala
    ' =============================================
    Public Class SalaBL
        Private dao As New SalaDAO()
        Public Sub Agregar(sala As Sala)
            If String.IsNullOrWhiteSpace(sala.Nombre) Then Throw New Exception("El nombre de la sala es obligatorio.")
            If sala.Capacidad <= 0 Then Throw New Exception("La capacidad debe ser mayor a cero.")
            dao.Agregar(sala)
        End Sub
        Public Function Listar() As List(Of Sala)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(sala As Sala)
            If String.IsNullOrWhiteSpace(sala.Nombre) Then Throw New Exception("El nombre de la sala es obligatorio.")
            If sala.Capacidad <= 0 Then Throw New Exception("La capacidad debe ser mayor a cero.")
            dao.Actualizar(sala)
        End Sub
        Public Sub Eliminar(idSala As Integer)
            If idSala <= 0 Then Throw New Exception("ID de sala inválido.")
            dao.Eliminar(idSala)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Pieza
    ' =============================================
    Public Class PiezaBL
        Private dao As New PiezaDAO()
        Public Sub Agregar(pieza As Pieza)
            If String.IsNullOrWhiteSpace(pieza.Nombre) Then Throw New Exception("El nombre de la pieza es obligatorio.")
            If pieza.ValorEstimado < 0 Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Agregar(pieza)
        End Sub
        Public Function Listar() As List(Of Pieza)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(pieza As Pieza)
            If String.IsNullOrWhiteSpace(pieza.Nombre) Then Throw New Exception("El nombre de la pieza es obligatorio.")
            If pieza.ValorEstimado < 0 Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Actualizar(pieza)
        End Sub
        Public Sub Eliminar(idPieza As Integer)
            If idPieza <= 0 Then Throw New Exception("ID de pieza inválido.")
            dao.Eliminar(idPieza)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Exposicion
    ' =============================================
    Public Class ExposicionBL
        Private dao As New ExposicionDAO()
        Public Sub Agregar(expo As Exposicion)
            If String.IsNullOrWhiteSpace(expo.Nombre) Then Throw New Exception("El nombre de la exposición es obligatorio.")
            If expo.IdSala <= 0                       Then Throw New Exception("Debe seleccionar una sala válida.")
            If expo.FechaFin < expo.FechaInicio       Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Agregar(expo)
        End Sub
        Public Function Listar() As List(Of Exposicion)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(expo As Exposicion)
            If String.IsNullOrWhiteSpace(expo.Nombre) Then Throw New Exception("El nombre de la exposición es obligatorio.")
            If expo.IdSala <= 0                       Then Throw New Exception("Debe seleccionar una sala válida.")
            If expo.FechaFin < expo.FechaInicio       Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Actualizar(expo)
        End Sub
        Public Sub Eliminar(idExposicion As Integer)
            If idExposicion <= 0 Then Throw New Exception("ID de exposición inválido.")
            dao.Eliminar(idExposicion)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Evento
    ' =============================================
    Public Class EventoBL
        Private dao As New EventoDAO()
        Public Sub Agregar(ev As Evento)
            If String.IsNullOrWhiteSpace(ev.Nombre)      Then Throw New Exception("El nombre del evento es obligatorio.")
            If String.IsNullOrWhiteSpace(ev.Responsable) Then Throw New Exception("El responsable del evento es obligatorio.")
            If ev.IdSala <= 0                            Then Throw New Exception("Debe seleccionar una sala válida.")
            If ev.CapacidadMaxima < 0                    Then Throw New Exception("La capacidad máxima no puede ser negativa.")
            If ev.FechaFin < ev.FechaInicio              Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Agregar(ev)
        End Sub
        Public Function Listar() As List(Of Evento)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(ev As Evento)
            If String.IsNullOrWhiteSpace(ev.Nombre)      Then Throw New Exception("El nombre del evento es obligatorio.")
            If String.IsNullOrWhiteSpace(ev.Responsable) Then Throw New Exception("El responsable del evento es obligatorio.")
            If ev.IdSala <= 0                            Then Throw New Exception("Debe seleccionar una sala válida.")
            If ev.FechaFin < ev.FechaInicio              Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Actualizar(ev)
        End Sub
        Public Sub Eliminar(idEvento As Integer)
            If idEvento <= 0 Then Throw New Exception("ID de evento inválido.")
            dao.Eliminar(idEvento)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Donacion
    ' =============================================
    Public Class DonacionBL
        Private dao As New DonacionDAO()
        Public Sub Agregar(don As Donacion)
            If String.IsNullOrWhiteSpace(don.NombreDonante) Then Throw New Exception("El nombre del donante es obligatorio.")
            If String.IsNullOrWhiteSpace(don.Descripcion)   Then Throw New Exception("La descripción de la donación es obligatoria.")
            If don.ValorEstimado < 0                        Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Agregar(don)
        End Sub
        Public Function Listar() As List(Of Donacion)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(don As Donacion)
            If String.IsNullOrWhiteSpace(don.NombreDonante) Then Throw New Exception("El nombre del donante es obligatorio.")
            If String.IsNullOrWhiteSpace(don.Descripcion)   Then Throw New Exception("La descripción es obligatoria.")
            If don.ValorEstimado < 0                        Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Actualizar(don)
        End Sub
        Public Sub Eliminar(idDonacion As Integer)
            If idDonacion <= 0 Then Throw New Exception("ID de donación inválido.")
            dao.Eliminar(idDonacion)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Entrada
    ' =============================================
    Public Class EntradaBL
        Private dao As New EntradaDAO()
        Public Sub Agregar(ent As Entrada)
            If ent.IdVisitante <= 0  Then Throw New Exception("Debe seleccionar un visitante válido.")
            If ent.Cantidad <= 0     Then Throw New Exception("La cantidad de entradas debe ser mayor a cero.")
            If ent.Precio < 0        Then Throw New Exception("El precio no puede ser negativo.")
            dao.Agregar(ent)
        End Sub
        Public Function Listar() As List(Of Entrada)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(ent As Entrada)
            If ent.IdVisitante <= 0  Then Throw New Exception("Debe seleccionar un visitante válido.")
            If ent.Cantidad <= 0     Then Throw New Exception("La cantidad de entradas debe ser mayor a cero.")
            If ent.Precio < 0        Then Throw New Exception("El precio no puede ser negativo.")
            dao.Actualizar(ent)
        End Sub
        Public Sub Eliminar(idEntrada As Integer)
            If idEntrada <= 0 Then Throw New Exception("ID de entrada inválido.")
            dao.Eliminar(idEntrada)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Reserva
    ' =============================================
    Public Class ReservaBL
        Private dao As New ReservaDAO()
        Public Sub Agregar(res As Reserva)
            If res.IdVisitante <= 0       Then Throw New Exception("Debe seleccionar un visitante válido.")
            If res.CantidadPersonas <= 0  Then Throw New Exception("La cantidad de personas debe ser mayor a cero.")
            If res.FechaReserva < Date.Today Then Throw New Exception("La fecha de reserva no puede ser anterior a hoy.")
            dao.Agregar(res)
        End Sub
        Public Function Listar() As List(Of Reserva)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(res As Reserva)
            If res.IdVisitante <= 0      Then Throw New Exception("Debe seleccionar un visitante válido.")
            If res.CantidadPersonas <= 0 Then Throw New Exception("La cantidad de personas debe ser mayor a cero.")
            dao.Actualizar(res)
        End Sub
        Public Sub Eliminar(idReserva As Integer)
            If idReserva <= 0 Then Throw New Exception("ID de reserva inválido.")
            dao.Eliminar(idReserva)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Prestamo
    ' =============================================
    Public Class PrestamoBL
        Private dao As New PrestamoDAO()
        Public Sub Agregar(pre As Prestamo)
            If pre.IdPieza <= 0                              Then Throw New Exception("Debe seleccionar una pieza válida.")
            If String.IsNullOrWhiteSpace(pre.InstitucionSolicitante) Then Throw New Exception("La institución solicitante es obligatoria.")
            If String.IsNullOrWhiteSpace(pre.Responsable)   Then Throw New Exception("El responsable es obligatorio.")
            If pre.FechaDevolucion <= pre.FechaPrestamo      Then Throw New Exception("La fecha de devolución debe ser posterior a la fecha de préstamo.")
            dao.Agregar(pre)
        End Sub
        Public Function Listar() As List(Of Prestamo)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(pre As Prestamo)
            If pre.IdPieza <= 0                              Then Throw New Exception("Debe seleccionar una pieza válida.")
            If String.IsNullOrWhiteSpace(pre.InstitucionSolicitante) Then Throw New Exception("La institución solicitante es obligatoria.")
            If pre.FechaDevolucion <= pre.FechaPrestamo      Then Throw New Exception("La fecha de devolución debe ser posterior a la fecha de préstamo.")
            dao.Actualizar(pre)
        End Sub
        Public Sub Eliminar(idPrestamo As Integer)
            If idPrestamo <= 0 Then Throw New Exception("ID de préstamo inválido.")
            dao.Eliminar(idPrestamo)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Inventario
    ' =============================================
    Public Class InventarioBL
        Private dao As New InventarioDAO()
        Public Sub Agregar(inv As Inventario)
            If String.IsNullOrWhiteSpace(inv.Nombre)           Then Throw New Exception("El nombre del objeto es obligatorio.")
            If String.IsNullOrWhiteSpace(inv.CodigoInventario) Then Throw New Exception("El código de inventario es obligatorio.")
            If String.IsNullOrWhiteSpace(inv.Ubicacion)        Then Throw New Exception("La ubicación es obligatoria.")
            If inv.IdEmpleado <= 0                             Then Throw New Exception("Debe seleccionar un empleado responsable.")
            If inv.ValorEstimado < 0                           Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Agregar(inv)
        End Sub
        Public Function Listar() As List(Of Inventario)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(inv As Inventario)
            If String.IsNullOrWhiteSpace(inv.Nombre)           Then Throw New Exception("El nombre del objeto es obligatorio.")
            If String.IsNullOrWhiteSpace(inv.CodigoInventario) Then Throw New Exception("El código de inventario es obligatorio.")
            If inv.IdEmpleado <= 0                             Then Throw New Exception("Debe seleccionar un empleado responsable.")
            If inv.ValorEstimado < 0                           Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Actualizar(inv)
        End Sub
        Public Sub Eliminar(idInventario As Integer)
            If idInventario <= 0 Then Throw New Exception("ID de inventario inválido.")
            dao.Eliminar(idInventario)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Proveedor
    ' =============================================
    Public Class ProveedorBL
        Private dao As New ProveedorDAO()
        Public Sub Agregar(prov As Proveedor)
            If String.IsNullOrWhiteSpace(prov.RazonSocial) Then Throw New Exception("La razón social del proveedor es obligatoria.")
            If String.IsNullOrWhiteSpace(prov.Categoria)   Then Throw New Exception("La categoría del proveedor es obligatoria.")
            If Not String.IsNullOrWhiteSpace(prov.Email) AndAlso Not prov.Email.Contains("@") Then
                Throw New Exception("El correo electrónico no tiene un formato válido.")
            End If
            If prov.FechaRegistro > Date.Today Then Throw New Exception("La fecha de registro no puede ser futura.")
            dao.Agregar(prov)
        End Sub
        Public Function Listar() As List(Of Proveedor)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(prov As Proveedor)
            If String.IsNullOrWhiteSpace(prov.RazonSocial) Then Throw New Exception("La razón social del proveedor es obligatoria.")
            If Not String.IsNullOrWhiteSpace(prov.Email) AndAlso Not prov.Email.Contains("@") Then
                Throw New Exception("El correo electrónico no tiene un formato válido.")
            End If
            dao.Actualizar(prov)
        End Sub
        Public Sub Eliminar(idProveedor As Integer)
            If idProveedor <= 0 Then Throw New Exception("ID de proveedor inválido.")
            dao.Eliminar(idProveedor)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Contrato
    ' =============================================
    Public Class ContratoBL
        Private dao As New ContratoDAO()
        Public Sub Agregar(cont As Contrato)
            If String.IsNullOrWhiteSpace(cont.NumeroContrato) Then Throw New Exception("El número de contrato es obligatorio.")
            If cont.IdProveedor <= 0                          Then Throw New Exception("Debe seleccionar un proveedor válido.")
            If String.IsNullOrWhiteSpace(cont.Tipo)           Then Throw New Exception("El tipo de contrato es obligatorio.")
            If cont.MontoTotal < 0                            Then Throw New Exception("El monto total no puede ser negativo.")
            If cont.FechaVencimiento <= cont.FechaInicio      Then Throw New Exception("La fecha de vencimiento debe ser posterior a la fecha de inicio.")
            dao.Agregar(cont)
        End Sub
        Public Function Listar() As List(Of Contrato)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(cont As Contrato)
            If String.IsNullOrWhiteSpace(cont.NumeroContrato) Then Throw New Exception("El número de contrato es obligatorio.")
            If cont.IdProveedor <= 0                          Then Throw New Exception("Debe seleccionar un proveedor válido.")
            If cont.MontoTotal < 0                            Then Throw New Exception("El monto total no puede ser negativo.")
            If cont.FechaVencimiento <= cont.FechaInicio      Then Throw New Exception("La fecha de vencimiento debe ser posterior a la fecha de inicio.")
            dao.Actualizar(cont)
        End Sub
        Public Sub Eliminar(idContrato As Integer)
            If idContrato <= 0 Then Throw New Exception("ID de contrato inválido.")
            dao.Eliminar(idContrato)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Mantenimiento
    ' =============================================
    Public Class MantenimientoBL
        Private dao As New MantenimientoDAO()
        Public Sub Agregar(mant As Mantenimiento)
            If String.IsNullOrWhiteSpace(mant.TipoMantenimiento) Then Throw New Exception("El tipo de mantenimiento es obligatorio.")
            If mant.FechaFin <> Nothing AndAlso mant.FechaFin < mant.FechaInicio Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            If mant.Costo < 0 Then Throw New Exception("El costo no puede ser negativo.")
            dao.Agregar(mant)
        End Sub
        Public Function Listar() As List(Of Mantenimiento)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(mant As Mantenimiento)
            If String.IsNullOrWhiteSpace(mant.TipoMantenimiento) Then Throw New Exception("El tipo de mantenimiento es obligatorio.")
            If mant.FechaFin <> Nothing AndAlso mant.FechaFin < mant.FechaInicio Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            If mant.Costo < 0 Then Throw New Exception("El costo no puede ser negativo.")
            dao.Actualizar(mant)
        End Sub
        Public Sub Eliminar(idMantenimiento As Integer)
            If idMantenimiento <= 0 Then Throw New Exception("ID de mantenimiento inválido.")
            dao.Eliminar(idMantenimiento)
        End Sub
    End Class

    ' =============================================
    '  NEGOCIO: Reporte
    ' =============================================
    Public Class ReporteBL
        Private dao As New ReporteDAO()
        Public Sub Agregar(rep As Reporte)
            If String.IsNullOrWhiteSpace(rep.Titulo)      Then Throw New Exception("El título del reporte es obligatorio.")
            If String.IsNullOrWhiteSpace(rep.Tipo)        Then Throw New Exception("El tipo de reporte es obligatorio.")
            If String.IsNullOrWhiteSpace(rep.GeneradoPor) Then Throw New Exception("El usuario que genera el reporte es obligatorio.")
            If rep.PeriodoHasta < rep.PeriodoDesde        Then Throw New Exception("La fecha 'hasta' no puede ser anterior a la fecha 'desde'.")
            If rep.FechaGeneracion = Nothing              Then rep.FechaGeneracion = Date.Today
            dao.Agregar(rep)
        End Sub
        Public Function Listar() As List(Of Reporte)
            Return dao.Listar()
        End Function
        Public Sub Actualizar(rep As Reporte)
            If String.IsNullOrWhiteSpace(rep.Titulo) Then Throw New Exception("El título del reporte es obligatorio.")
            If rep.PeriodoHasta < rep.PeriodoDesde   Then Throw New Exception("La fecha 'hasta' no puede ser anterior a la fecha 'desde'.")
            dao.Actualizar(rep)
        End Sub
        Public Sub Eliminar(idReporte As Integer)
            If idReporte <= 0 Then Throw New Exception("ID de reporte inválido.")
            dao.Eliminar(idReporte)
        End Sub
    End Class

End Namespace
