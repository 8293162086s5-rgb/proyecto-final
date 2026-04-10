Public Class Reserva
    Public Property IdReserva        As Integer
    Public Property IdVisitante      As Integer  ' FK → Visitante
    Public Property NombreVisitante  As String   ' se llena via JOIN al listar
    Public Property CantidadPersonas As Integer
    Public Property FechaReserva     As Date
    Public Property Hora             As Date
    Public Property Tipo             As String
    Public Property Estado           As String
    Public Property Observaciones    As String
End Class
