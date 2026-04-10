Public Class Empleado
    Public Property IdEmpleado   As Integer
    Public Property Nombre       As String
    Public Property Apellido     As String
    Public Property Cargo        As String
    Public Property FechaIngreso As Date
    Public Property Telefono     As String
    Public Property Email        As String
    Public Property Estado       As String
    Public ReadOnly Property NombreCompleto As String
        Get
            Return Nombre & " " & Apellido
        End Get
    End Property
End Class
