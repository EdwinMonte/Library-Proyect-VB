Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Text.Json
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Text = DocumentFormat.OpenXml.Wordprocessing.Text
Imports System.IO

Namespace Proyecto_Library_POO
    Public Class Biblioteca
        Private libros As List(Of Libro)

        Public Sub New()
            libros = New List(Of Libro)()
        End Sub

        Public Function ObtenerLibros() As List(Of Libro)
            Return libros
        End Function

        Public Sub AgregarLibro(libro As Libro)
            libros.Add(libro)
        End Sub

        Public Sub EliminarLibro(libro As Libro)
            libros.RemoveAll(Function(l) l.Titulo = libro.Titulo AndAlso l.Autor = libro.Autor AndAlso l.Paginas = libro.Paginas AndAlso l.Precio = libro.Precio AndAlso l.Sucursal = libro.Sucursal)
        End Sub

        Public Shared Sub ExportarAJson(biblioteca As Biblioteca, rutaArchivo As String)
            Dim json As String = JsonSerializer.Serialize(biblioteca.libros)
            File.WriteAllText(rutaArchivo, json)
        End Sub

        Public Shared Sub ExportarADocx(rutaArchivo As String, libros As List(Of Libro))
            Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(rutaArchivo, WordprocessingDocumentType.Document)
                Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
                mainPart.Document = New DocumentFormat.OpenXml.Wordprocessing.Document()
                Dim body As Body = mainPart.Document.AppendChild(New Body())

                For Each libro In libros
                    Dim para As DocumentFormat.OpenXml.Wordprocessing.Paragraph = body.AppendChild(New DocumentFormat.OpenXml.Wordprocessing.Paragraph())
                    Dim run As DocumentFormat.OpenXml.Wordprocessing.Run = para.AppendChild(New DocumentFormat.OpenXml.Wordprocessing.Run())
                    run.AppendChild(New Text($"{libro.Titulo} - {libro.Autor} - {libro.Paginas}- {libro.Precio}"))
                Next

                mainPart.Document.Save()
            End Using
        End Sub

        Public Shared Sub ExportarAExcel(rutaArchivo As String, libros As List(Of Libro))
            Using document As SpreadsheetDocument = SpreadsheetDocument.Create(rutaArchivo, SpreadsheetDocumentType.Workbook)
                Dim workbookPart As WorkbookPart = document.AddWorkbookPart()
                workbookPart.Workbook = New Workbook()
                Dim sheets As Sheets = workbookPart.Workbook.AppendChild(New Sheets())

                Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
                Dim sheetData As New SheetData()
                worksheetPart.Worksheet = New Worksheet(sheetData)

                Dim sheet As New Sheet() With {
                    .Id = workbookPart.GetIdOfPart(worksheetPart),
                    .SheetId = 1,
                    .Name = "Libros"
                }
                sheets.Append(sheet)

                Dim headerRow As New Row()
                headerRow.Append(New Cell() With {.CellValue = New CellValue("Título"), .DataType = CellValues.String})
                headerRow.Append(New Cell() With {.CellValue = New CellValue("Autor"), .DataType = CellValues.String})
                headerRow.Append(New Cell() With {.CellValue = New CellValue("Páginas"), .DataType = CellValues.String})
                headerRow.Append(New Cell() With {.CellValue = New CellValue("Año"), .DataType = CellValues.String})
                sheetData.Append(headerRow)

                For Each libro In libros
                    Dim row As New Row()
                    row.Append(New Cell() With {.CellValue = New CellValue(libro.Titulo), .DataType = CellValues.String})
                    row.Append(New Cell() With {.CellValue = New CellValue(libro.Autor), .DataType = CellValues.String})
                    row.Append(New Cell() With {.CellValue = New CellValue(libro.Paginas.ToString()), .DataType = CellValues.Number})

                    sheetData.Append(row)
                Next

                workbookPart.Workbook.Save()
            End Using
        End Sub
    End Class
End Namespace


