Public Class Prestamo
    Public Property IdPrestamo             As Integer
    Public Property IdPieza                As Integer  ' FK Pieza
    Public Property NombrePieza            As String   ' JOIN
    Public Property InstitucionSolicitante As String
    Public Property Responsable            As String
    Public Property Contacto               As String
    Public Property FechaPrestamo          As Date
    Public Property FechaDevolucion        As Date
    Public Property Estado                 As String
    Public Property Condiciones            As String
End Class
