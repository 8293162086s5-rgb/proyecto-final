Public Class Mantenimiento
    Public Property IdMantenimiento   As Integer
    Public Property TipoMantenimiento As String
    Public Property Descripcion       As String
    Public Property FechaInicio       As Date
    Public Property FechaFin          As Date
    Public Property Costo             As Decimal
    Public Property Estado            As String
    Public Property Observaciones     As String
    Public Property IdEmpleado        As Integer  ' FK Empleado
    Public Property IdSala            As Integer  ' FK Sala
    Public Property NombreEmpleado    As String   ' JOIN
    Public Property NombreSala        As String   ' JOIN
End Class
