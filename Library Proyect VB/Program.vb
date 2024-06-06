Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet

Namespace Proyecto_Library_POO
    Friend Module Program
        Public Sub ExportarAExcel(biblioteca As Biblioteca, rutaArchivo As String)
            Using workbook As New XLWorkbook()
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Libros")

                worksheet.Cell("A1").Value = "Título"
                worksheet.Cell("B1").Value = "Autor"
                worksheet.Cell("C1").Value = "Páginas"

                Dim row As Integer = 2
                For Each libro As Libro In biblioteca.ObtenerLibros()
                    worksheet.Cell($"A{row}").Value = libro.Titulo
                    worksheet.Cell($"B{row}").Value = libro.Autor
                    worksheet.Cell($"C{row}").Value = libro.Paginas
                    row += 1
                Next

                workbook.SaveAs(rutaArchivo)
            End Using
        End Sub

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            ' Suponiendo que obtuviste el nombre y correo del usuario en FormBienvenida
            Dim nombreUsuario As String = "Nombre del Usuario"
            Dim correoUsuario As String = "correo@ejemplo.com"

            Dim form1 As New Form1 With {
                .NombreUsuario = nombreUsuario,
                .CorreoUsuario = correoUsuario
            }

            Dim bienvenidaForm As New FormBienvenida()
            If bienvenidaForm.ShowDialog() = DialogResult.OK Then
                Application.Run(New Form1())
            End If
        End Sub
    End Module
End Namespace

