Imports System.Data.OleDb




Module PersonnelDB1
    Public Sub AddPersonne(ByVal NbrChiru As Integer, ByVal NbrMed As Integer, ByVal Nbrpara As Integer, ByVal Mois_Année As String, ByVal idSer As Integer)
        Dim query As String
        query = "Insert into  Personnel (nbr_Chirurgie ,nbr_Med ,nbr_Para , mois_annee ,id_service) values(?,?,?,?,?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)

        Command.Parameters.AddWithValue("?", NbrChiru)
        Command.Parameters.AddWithValue("?", NbrMed)
        Command.Parameters.AddWithValue("?", Nbrpara)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", idSer)
        Command.ExecuteNonQuery()

    End Sub

    Public Sub UpdatePer(ByVal NbrChiru As Integer, ByVal NbrMed As Integer, ByVal Nbrpara As Integer, ByVal Mois_Année As String, ByVal idSer As Integer)
        Dim query As String
        query = "update Personnel  set nbr_Chirurgie = ?, nbr_Med = ?, nbr_Para = ? where mois_annee = ? and id_service = ?"

        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", NbrChiru)
        Command.Parameters.AddWithValue("?", NbrMed)
        Command.Parameters.AddWithValue("?", Nbrpara)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", idSer)
        Command.ExecuteNonQuery()


    End Sub
    Public Function VerifyExist(ByVal mois_annee As String, ByVal id As Integer) As Boolean

        Dim query As String
        query = "select mois_annee from Personnel where mois_annee = ? and id_service = ?"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", mois_annee)
        Command.Parameters.AddWithValue("?", id)
        Dim Reader As OleDbDataReader
        Reader = Command.ExecuteReader()
        Dim exist As Boolean
        If (Reader.HasRows) Then
            exist = True
        Else
            exist = False
        End If
        Return exist
    End Function
    Public Function nbrChiru(ByVal id As Integer, ByVal mois_annee As String) As Integer
        Dim query As String
        query = "Select nbr_Chirurgie from Personnel where id_service= ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrech As Integer
        If (reader.Read) Then
            nbrech = reader("nbr_chirurgie")
        Else
            nbrech = 0
        End If
        Return nbrech



    End Function
    Public Function nbrMed(ByVal id As Integer, ByVal mois_annee As String) As Integer
        Dim query As String
        query = "Select nbr_Med from Personnel where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbreMed As Integer
        If (reader.Read) Then
            nbreMed = reader("nbr_Med")
        Else
            nbreMed = 0
        End If
        Return nbrMed



    End Function
    Public Function nbrePara(ByVal id As Integer, ByVal mois_annee As String) As Integer
        Dim query As String
        query = "Select nbr_Para from Personnel where id_service = ? and mois_annee = ? "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrP As Integer
        If (reader.Read) Then
            nbrP = reader("nbr_Para")
        Else
            nbrP = 0
        End If
        Return nbrP



    End Function
End Module

