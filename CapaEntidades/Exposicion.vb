Public Class Exposicion
    Public Property IdExposicion As Integer
    Public Property IdSala       As Integer  ' FK → Sala
    Public Property NombreSala   As String   ' se llena via JOIN al listar
    Public Property Nombre       As String
    Public Property Descripcion  As String
    Public Property FechaInicio  As Date
    Public Property FechaFin     As Date
    Public Property Estado       As String
    Public Property Responsable  As String
End Class
