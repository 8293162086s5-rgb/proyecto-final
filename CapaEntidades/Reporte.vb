Public Class Reporte
    Public Property IdReporte As Integer
    Public Property Titulo As String
    Public Property Tipo As String                ' 'Visitantes' | 'Ingresos' | 'Inventario' | 'Mantenimiento' | 'Préstamos' | 'General'
    Public Property FechaGeneracion As Date
    Public Property GeneradoPor As String         ' nombre del usuario que lo generó
    Public Property PeriodoDesde As Date
    Public Property PeriodoHasta As Date
    Public Property Descripcion As String
    Public Property Estado As String              ' 'Borrador' | 'Finalizado' | 'Archivado'
End Class
