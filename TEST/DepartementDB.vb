
Imports System.Data.OleDb

Module DepartementDB
    Public Sub AddDepartement(NomDepartement As String)
        Dim query As String
        query = "insert into Departement(Nom_Departement) values (?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", NomDepartement)


        Command.ExecuteNonQuery()
    End Sub
    Public Function VerifieExistnom(ByVal NomDepartement As String) As Boolean

        Dim query As String
        query = "select Nom_Departement from Departement where Nom_Departement = ?  "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)

        Command.Parameters.AddWithValue("?", NomDepartement)

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
    Public Function VerifieExistid(ByVal id As Integer) As Boolean

        Dim query As String
        query = "select id_Departement from Departement where id_departement = ?  "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)

        Command.Parameters.AddWithValue("?", id)

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

    Public Function getId(ByVal Nom_dep As String) As Long
        Dim id_dept As Long

        Dim query As String
        query = "Select Id_Departement from Departement where Nom_Departement =?"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", Nom_dep)
        Dim Reader As OleDbDataReader
        Reader = Command.ExecuteReader()
        If (Reader.Read) Then
            id_dept = Reader("Id_Departement")
        End If
        Reader.Close()
        Command = Nothing
        Return id_dept
    End Function
    Public Sub DeleteDepartemnt(ByVal nomDepartement As String)
        Dim query As String
        query = "delete from  Departement where Nom_departement=?"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nomDepartement)
        Command.ExecuteNonQuery()

    End Sub
    Public Sub UpdateDepartement(ByVal nomDepartement As String, ByVal id As Integer)
        Dim query As String
        query = "Update Departement Set Nom_departement =? where id_departement = ?"
        Dim cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", nomDepartement)
        cmd.Parameters.AddWithValue("?", id)
        cmd.ExecuteNonQuery()
    End Sub
    Public Function VerifierSer(ByVal idDepartement As Integer) As Boolean
        Dim query As String
        query = "select id_ser from Service where Id_departement= ? "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", idDepartement)
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
End Module
