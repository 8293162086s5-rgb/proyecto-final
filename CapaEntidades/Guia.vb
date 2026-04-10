Public Class Guia
    Public Property IdGuia         As Integer
    Public Property Nombre         As String
    Public Property Apellido       As String
    Public Property Telefono       As String
    Public Property Email          As String
    Public Property Idioma         As String
    Public Property Estado         As String
    Public Property IdEmpleado     As Integer  ' FK Empleado
    Public Property NombreEmpleado As String   ' JOIN
End Class
