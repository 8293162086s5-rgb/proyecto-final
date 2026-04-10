Public Class Pieza
    Public Property IdPieza            As Integer
    Public Property Nombre             As String
    Public Property Descripcion        As String
    Public Property Epoca              As String
    Public Property Material           As String
    Public Property EstadoConservacion As String
    Public Property Ubicacion          As String
    Public Property ValorEstimado      As Decimal
    Public Property IdSala             As Integer  ' FK Sala
    Public Property NombreSala         As String   ' JOIN
End Class
