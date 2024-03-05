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
End Class
