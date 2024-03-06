Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtable = ExcelTesting.MyDT()
        ExcelTesting.CreateExcel(dtable)
    End Sub
End Class
