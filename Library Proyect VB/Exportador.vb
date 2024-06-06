Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Library_Proyect_VB.Proyecto_Library_POO
Imports Newtonsoft.Json
Imports OfficeOpenXml
Imports Proyecto_Library_POO

Public Module Exportador
    Public Sub ExportarADocx(biblioteca As Biblioteca, filePath As String)
        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document)
            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
            mainPart.Document = New Document()
            Dim body As Body = New Body()

            For Each libro As Libro In biblioteca.ObtenerLibros()
                Dim paragraph As Paragraph = New Paragraph()
                Dim run As Run = New Run()
                run.Append(New Text($"{libro.Titulo}, {libro.Autor}, {libro.Paginas} páginas, {libro.Precio:C}, Sucursal: {libro.Sucursal}"))
                paragraph.Append(run)
                body.Append(paragraph)
            Next

            mainPart.Document.Append(body)
            mainPart.Document.Save()
        End Using

        ' Abre el archivo DOCX
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Public Sub ExportarAExcel(rutaArchivo As String, libros As List(Of Libro))
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Using package As ExcelPackage = New ExcelPackage()
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Libros")

            ' Crear encabezados de columnas
            worksheet.Cells(1, 1).Value = "Título"
            worksheet.Cells(1, 2).Value = "Autor"
            worksheet.Cells(1, 3).Value = "Páginas"
            worksheet.Cells(1, 4).Value = "Precio"
            worksheet.Cells(1, 5).Value = "Sucursal"

            ' Añadir los datos de los libros
            Dim row As Integer = 2
            For Each libro As Libro In libros
                worksheet.Cells(row, 1).Value = libro.Titulo
                worksheet.Cells(row, 2).Value = libro.Autor
                worksheet.Cells(row, 3).Value = libro.Paginas
                worksheet.Cells(row, 4).Value = libro.Precio.ToString("C", CultureInfo.CurrentCulture)
                worksheet.Cells(row, 5).Value = libro.Sucursal
                row += 1
            Next

            ' Guardar el archivo
            Dim fileInfo As FileInfo = New FileInfo(rutaArchivo)
            package.SaveAs(fileInfo)
        End Using

        ' Abrir el archivo automáticamente
        Process.Start(New ProcessStartInfo(rutaArchivo) With {.UseShellExecute = True})
    End Sub

    Public Sub ExportarAJson(biblioteca As Biblioteca, filePath As String)
        Dim json As String = JsonConvert.SerializeObject(biblioteca.ObtenerLibros(), Formatting.Indented)
        File.WriteAllText(filePath, json)

        ' Abre el archivo JSON
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub
End Module



