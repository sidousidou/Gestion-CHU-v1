Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnt As New OleDbConnection
        cnt.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\Users\Anonyme\Documents\dbMemo2003.mdb"
        If (cnt.State = ConnectionState.Closed) Then
            cnt.Open()

        End If
    End Sub


End Class
