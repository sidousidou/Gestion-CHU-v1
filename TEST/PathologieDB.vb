Imports System.Data.OleDb

Module PathologieDB
    Public Sub AddPathologie(NomPatient As String, ByVal idSer As Integer)
        Dim query As String
        query = "insert into Pathologie(Nom_Maladie,id_service) values (?,?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", NomPatient)
        Command.Parameters.AddWithValue("?", idSer)

        Command.ExecuteNonQuery()
    End Sub
    Public Function VerifiePatient(ByVal NomPatient As String) As Boolean

        Dim query As String
        query = "select Nom_Maladie from Pathologie where Nom_Maladie = ?  "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)

        Command.Parameters.AddWithValue("?", NomPatient)

        Dim Reader As OleDbDataReader
        Reader = Command.ExecuteReader()
        Dim exist As Boolean
        If (Reader.HasRows) Then
            exist = True
        Else
            exist = False
        End If

        Reader.Close()
        Return exist
    End Function
    Public Sub DeleteMalade(ByVal nomMalade As String)
        Dim query As String
        query = "delete from Pathologie where Nom_Maladie=?"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nomMalade)
        Command.ExecuteNonQuery()

    End Sub
End Module
