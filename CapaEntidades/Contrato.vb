Public Class Contrato
    Public Property IdContrato        As Integer
    Public Property IdProveedor       As Integer  ' FK → Proveedor
    Public Property NombreProveedor   As String   ' se llena via JOIN al listar
    Public Property NumeroContrato    As String
    Public Property Descripcion       As String
    Public Property Tipo              As String   ' 'Servicio' | 'Suministro' | 'Obra' | 'Consultoría'
    Public Property MontoTotal        As Decimal
    Public Property FechaInicio       As Date
    Public Property FechaVencimiento  As Date
    Public Property Estado            As String   ' 'Activo' | 'Vencido' | 'Cancelado' | 'En Renovación'
    Public Property Observaciones     As String
End Class
