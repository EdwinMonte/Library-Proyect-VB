Partial Public Class FormBienvenida
    Inherits Form

    Public Property NombreUsuario As String
    Public Property CorreoUsuario As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        NombreUsuario = txtNombre.Text
        CorreoUsuario = txtCorreo.Text

        If Not String.IsNullOrEmpty(NombreUsuario) AndAlso Not String.IsNullOrEmpty(CorreoUsuario) Then
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Por favor, ingrese ambos campos.")
        End If
    End Sub
End Class
