Imports System.IO

Public NotInheritable Class ExcelTesting
    Public Shared Function MyDT() As DataTable

        Dim table As DataTable = New DataTable()
        table.Columns.Add("ID")
        table.Columns.Add("Name")
        table.Columns.Add("Sex")
        table.Columns.Add("CreatedDate")
        table.Columns.Add("City")

        table.Rows.Add(25, "Devesh Omar", "M", DateTime.Now, "Noida")
        table.Rows.Add(50, "Nikhil Vats", "M", DateTime.Now, "Noida")
        table.Rows.Add(10, "Heena Sharma", "F", DateTime.Now, "Delhi")
        table.Rows.Add(21, "Nancy Sharma", "F", DateTime.Now, "Delhi")
        table.Rows.Add(100, "Avinash", "M", DateTime.Now, "Delhi")
        table.Rows.Add(25, "Devesh gupta", "M", DateTime.Now, "Delhi")
        table.Rows.Add(50, "Nikhil gupta", "M", DateTime.Now, "Noida")
        table.Rows.Add(10, "HS gupta", "F", DateTime.Now, "Delhi")
        table.Rows.Add(21, "VS gupta", "F", DateTime.Now, "Delhi")
        table.Rows.Add(100, "RJ gupta", "M", DateTime.Now, "Delhi")

        Return table
    End Function

    Public Shared Sub CreateExcel(dtable As DataTable)
        Try
            Dim ExcelApp As Object
            ExcelApp = CreateObject("Excel.Application")

            Dim wb As Object
            wb = ExcelApp.Workbooks.Add

            Dim sheet As Object
            sheet = wb.Worksheets(1)

            Dim rowAdjust As Integer = 1 'Set content next to headers
            Dim excelCell As String = "B2"

            ' Set Headers
            For col = 0 To dtable.Columns.Count - 1
                sheet.Range(excelCell).Offset(0, col).Value = dtable.Columns.Item(col).ColumnName
            Next

            ' Set the content of the datatable
            For row = 0 To dtable.Rows.Count - 1
                For col = 0 To dtable.Columns.Count - 1
                    'sheet.Cells(row + 1, col + 1).Value = dtable.Rows(row).Item(col)
                    sheet.Range(excelCell).Offset(row + rowAdjust, col).Value = dtable.Rows(row).Item(col)
                Next col
            Next row

            Dim ruta = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            wb.SaveAs(Path.Combine(ruta, "Test", "Excel.xlsx"))
            wb.Close
            ExcelApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
End Class
