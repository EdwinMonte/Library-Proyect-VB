
Imports System.IO
Imports Library_Proyect_VB.Proyecto_Library_POO

Partial Public Class Form1
    Inherits Form
    Public Property NombreUsuario As String
    Public Property CorreoUsuario As String
    Private biblioteca As Biblioteca

    Public Sub New()
        InitializeComponent()
        biblioteca = New Biblioteca()
        ConfigurarListView()
        ' Configurar columnas del ListView
        lstvLibros.View = View.Details
        lstvLibros.Columns.Add("Título", 150)
        lstvLibros.Columns.Add("Autor", 150)
        lstvLibros.Columns.Add("Páginas", 70)
        lstvLibros.Columns.Add("Precio", 70)
        lstvLibros.Columns.Add("Sucursal", 100)

        ' Asociar evento click del botón Ver Usuario
        AddHandler btnVerUsuario.Click, AddressOf btnVerUsuario_Click
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreUsuario.Text = $"Nombre: {NombreUsuario}"
        lblCorreoUsuario.Text = $"Correo: {CorreoUsuario}"
        MessageBox.Show($"Bienvenido, {NombreUsuario} ({CorreoUsuario})", "Bienvenido")
    End Sub

    Private Sub ConfigurarListView()
        AddHandler lstvLibros.MouseDoubleClick, AddressOf lstvLibros_MouseDoubleClick
    End Sub



    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnaddbook.Click
        Dim titulo As String = txtTitulo.Text
        Dim autor As String = txtAutor.Text
        Dim sucursal As String = txtSucursal.Text
        Dim paginas As Integer
        Dim precio As Decimal

        If Integer.TryParse(txtPaginas.Text, paginas) AndAlso Decimal.TryParse(txtPrice.Text, precio) Then
            Dim libro As New Libro(titulo, autor, paginas, precio, sucursal)
            biblioteca.AgregarLibro(libro)
            ActualizarListaLibros()
        Else
            MessageBox.Show("Por favor, ingrese datos válidos para páginas y precio.")
        End If
    End Sub


    Private Sub ActualizarListaLibros()
        lstvLibros.Items.Clear()
        For Each libro In biblioteca.ObtenerLibros()
            Dim item As New ListViewItem(New String() {libro.Titulo, libro.Autor, libro.Paginas.ToString(), libro.Precio.ToString("C"), libro.Sucursal})
            lstvLibros.Items.Add(item)
        Next
    End Sub

    Private Sub LimpiarCampos()
        txtTitulo.Clear()
        txtAutor.Clear()
        txtPaginas.Clear()
        txtPrice.Clear()
        txtSucursal.Clear() ' Limpiar también la sucursal
    End Sub

    Private Sub btnExportJSON_Click(sender As Object, e As EventArgs) Handles btnExportJSON.Click
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos JSON (*.json)|*.json"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Biblioteca.ExportarAJson(biblioteca, saveFileDialog.FileName)
            MessageBox.Show("Biblioteca exportada exitosamente.")
            Process.Start(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportWord_Click(sender As Object, e As EventArgs) Handles btnExportWord.Click
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos Word (*.docx)|*.docx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Exportador.ExportarADocx(biblioteca, saveFileDialog.FileName)
            MessageBox.Show("Biblioteca exportada exitosamente a Word.")
            Process.Start(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Exportador.ExportarAExcel(saveFileDialog.FileName, biblioteca.ObtenerLibros())
            MessageBox.Show("Datos exportados exitosamente a Excel.")
            Process.Start(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnChargingtxt_Click(sender As Object, e As EventArgs) Handles btnChargingtxt.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                CargarDesdeTxt(openFileDialog.FileName)
                MessageBox.Show("Biblioteca cargada exitosamente desde el archivo TXT.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar desde el archivo TXT: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSavetxt_Click(sender As Object, e As EventArgs) Handles btnSavetxt.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                GuardarATxt(saveFileDialog.FileName)
                MessageBox.Show("Biblioteca guardada exitosamente en el archivo TXT.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar en el archivo TXT: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDesdeTxt(rutaArchivo As String)
        biblioteca = New Biblioteca()
        Dim lineas() As String = File.ReadAllLines(rutaArchivo)
        For Each linea As String In lineas
            Dim partes() As String = linea.Split(";"c)
            If partes.Length = 5 Then
                Dim titulo As String = partes(0)
                Dim autor As String = partes(1)
                Dim paginas As Integer
                Dim precio As Decimal
                If Integer.TryParse(partes(2), paginas) AndAlso Decimal.TryParse(partes(3), precio) Then
                    Dim sucursal As String = partes(4)
                    Dim libro As New Libro(titulo, autor, paginas, precio, sucursal)
                    biblioteca.AgregarLibro(libro)
                End If
            End If
        Next
        ActualizarListaLibros()
    End Sub

    Private Sub GuardarATxt(rutaArchivo As String)
        Dim lineas As New List(Of String)()
        For Each libro As Libro In biblioteca.ObtenerLibros()
            lineas.Add($"{libro.Titulo};{libro.Autor};{libro.Paginas};{libro.Precio};{libro.Sucursal}")
        Next
        File.WriteAllLines(rutaArchivo, lineas)
    End Sub

    Private Sub lstvLibros_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Dim item As ListViewItem = lstvLibros.GetItemAt(e.X, e.Y)
        If item IsNot Nothing Then
            Dim libro As Libro = biblioteca.ObtenerLibros().FirstOrDefault(Function(l) l.Titulo = item.SubItems(0).Text AndAlso l.Autor = item.SubItems(1).Text AndAlso l.Paginas.ToString() = item.SubItems(2).Text AndAlso l.Precio.ToString("C") = item.SubItems(3).Text AndAlso l.Sucursal = item.SubItems(4).Text)
            If libro IsNot Nothing Then
                Dim formActionBook As New FormActionBook(libro)
                If formActionBook.ShowDialog() = DialogResult.OK Then
                    biblioteca.EliminarLibro(libro)
                    ActualizarListaLibros()
                End If
            End If
        End If
    End Sub

    Private Sub btnVerUsuario_Click(sender As Object, e As EventArgs)
        MessageBox.Show($"Nombre: {NombreUsuario}{Environment.NewLine}Correo: {CorreoUsuario}", "Información de Usuario")
    End Sub
End Class


