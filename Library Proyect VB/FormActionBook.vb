Partial Public Class FormActionBook
    Inherits Form

    Public Property LibroSeleccionado As Libro

    Public Sub New(libro As Libro)
        InitializeComponent()
        LibroSeleccionado = libro
        lblTitle.Text = libro.Titulo
        lblPrice.Text = libro.Precio.ToString("C")
        lblSucursal.Text = libro.Sucursal
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnToLend.Click
        ' Lógica para prestar el libro
        MessageBox.Show("Libro prestado.")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        ' Lógica para vender el libro
        MessageBox.Show("Libro vendido.")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
