Public Class Evento
    Public Property IdEvento        As Integer
    Public Property IdSala          As Integer  ' FK → Sala
    Public Property NombreSala      As String   ' se llena via JOIN al listar
    Public Property Nombre          As String
    Public Property Tipo            As String
    Public Property Responsable     As String
    Public Property CapacidadMaxima As Integer
    Public Property FechaInicio     As Date
    Public Property FechaFin        As Date
    Public Property Estado          As String
    Public Property Descripcion     As String
End Class
