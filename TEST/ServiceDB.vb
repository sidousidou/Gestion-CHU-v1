Imports System.Data.OleDb

Public Module ServiceDB
    Public Sub AjouteService(ByVal NomService As String, ByVal NbrLits As Integer, ByVal Id_departement As Long)

        Dim query As String
        query = "insert into Service (Nom_Service , nbre_lits, Id_departement) values (?,?,?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", NomService)
        Command.Parameters.AddWithValue("?", NbrLits)
        Command.Parameters.AddWithValue("?", Id_departement)
        Command.ExecuteNonQuery()
    End Sub

    Public Function VerifieExist(ByVal NomService As String) As Boolean
        Dim resultat As Boolean
        Dim query As String
        query = " Select id_ser From Service Where Nom_Service = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", NomService)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.HasRows) Then
            resultat = True
        Else
            resultat = False
        End If
        reader.Close()

        Return resultat
    End Function

    Public Sub DeleteService(ByVal nomService As String)
        Dim query As String
        query = "delete from Service where Nom_Service=?"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nomService)
        Command.ExecuteNonQuery()

    End Sub
    Public Sub UpdateService(ByVal nomService As String, ByVal nbrelits As Integer)
        Dim query As String
        query = "Update Service Set nbre_lits=? where Nom_Service = ?"
        Dim cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", nbrelits)
        cmd.Parameters.AddWithValue("?", nomService)
        cmd.ExecuteNonQuery()
    End Sub
    Public Function getIdSer(ByVal nomSer As String) As Long
        Dim Resultat As Long
        Dim query As String
        query = "select id_Ser from Service where Nom_Service = ? "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nomSer)
        Dim Reader As OleDbDataReader
        Reader = Command.ExecuteReader()
        If (Reader.Read) Then
            Resultat = Reader("id_ser")
        Else
            Resultat = 0
        End If
        Reader.Close()
        Return Resultat

    End Function
    Public Function VerifierActINSer(ByVal idService As Long) As Boolean
        Dim query As String
        query = "select id_activity from Activity where id_Service = ? "
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", idService)
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
    Function get_nom_service(ByVal id As Integer) As String
        Dim nom As String
        Dim query As String = "select nom_service from service where id_ser = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)


        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If reader.Read() Then
            nom = reader("nom_service")

        Else
            nom = 0
        End If
        Return nom

    End Function
    Function get_nbre_lits(ByVal id As Integer) As Integer
        Dim res As Integer
        Dim query As String = "select nbre_lits from service where id_ser = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)


        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If reader.Read() Then
            res = CInt(reader("nbre_lits"))
        Else
            res = 0
        End If
        Return res
    End Function
End Module
