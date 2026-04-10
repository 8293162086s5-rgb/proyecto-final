Public Class Inventario
    Public Property IdInventario     As Integer
    Public Property IdEmpleado       As Integer  ' FK → Empleado (responsable)
    Public Property NombreEmpleado   As String   ' se llena via JOIN al listar
    Public Property Nombre           As String
    Public Property CodigoInventario As String
    Public Property Categoria        As String
    Public Property Epoca            As String
    Public Property Material         As String
    Public Property Ubicacion        As String
    Public Property ValorEstimado    As Decimal
    Public Property Estado           As String
    Public Property FechaIngreso     As Date
    Public Property Descripcion      As String
End Class
