Public Class Entrada
    Public Property IdEntrada       As Integer
    Public Property IdVisitante     As Integer  ' FK → Visitante
    Public Property NombreVisitante As String   ' se llena via JOIN al listar
    Public Property Tipo            As String
    Public Property Precio          As Decimal
    Public Property Cantidad        As Integer
    Public Property Fecha           As Date
    Public Property MetodoPago      As String
    Public Property Observaciones   As String
End Class
