Imports System.Data.OleDb

Module Module1
    Public cnt As OleDbConnection
    Public Sub connectDB()
        cnt = New OleDbConnection
        cnt.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data source =c:\Users\Anonyme\Documents\dbMemo2003.mdb"

        If (cnt.State = ConnectionState.Closed) Then
            cnt.Open()

        End If

    End Sub

End Module
