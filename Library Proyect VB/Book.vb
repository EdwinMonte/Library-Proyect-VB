Public Class Libro
    Public Property Titulo As String
    Public Property Autor As String
    Public Property Paginas As Integer
    Public Property Precio As Decimal
    Public Property Sucursal As String ' Nueva propiedad

    Public Sub New(titulo As String, autor As String, paginas As Integer, precio As Decimal, sucursal As String)
        Me.Titulo = titulo
        Me.Autor = autor
        Me.Paginas = paginas
        Me.Precio = precio
        Me.Sucursal = sucursal
    End Sub
End Class


