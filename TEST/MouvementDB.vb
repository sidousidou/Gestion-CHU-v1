Imports System.Data.OleDb
Module MouvementDB
    Public Sub AddAMove(ByVal sexe As String, ByVal nbrAdmis As Integer, ByVal nbrTrans As Integer, ByVal nbrDécis As Integer, ByVal nbrSortie As Integer, ByVal Mois_Année As String, ByVal idSer As Integer, ByVal jour As Integer)
        Dim query As String
        query = "Insert into Mouvement (Sexe ,Nbr_Admis ,Nbr_Transfer ,Nbr_Décis ,Nbr_Sortie, mois_annee ,id_service,journnee) values(?,?,?,?,?,?,?,?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", sexe)
        Command.Parameters.AddWithValue("?", nbrAdmis)
        Command.Parameters.AddWithValue("?", nbrTrans)
        Command.Parameters.AddWithValue("?", nbrDécis)
        Command.Parameters.AddWithValue("?", nbrSortie)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", idSer)
        Command.Parameters.AddWithValue("?", jour)
        Command.ExecuteNonQuery()

    End Sub


    Public Sub UpdateMove(ByVal nbrAdmis As Integer, ByVal nbrTrans As Integer, ByVal nbrDécis As Integer, ByVal nbrSortie As Integer, ByVal Mois_Année As String, ByVal id As Integer, ByVal sexe As String, ByVal jour As Integer)
        Dim query As String
        query = "Update Mouvement set Nbr_Admis =?, Nbr_Transfer=?, Nbr_Décis=? ,Nbr_Sortie=? , journnee =? where mois_annee=? and id_service = ? and sexe=?"

        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nbrAdmis)
        Command.Parameters.AddWithValue("?", nbrTrans)
        Command.Parameters.AddWithValue("?", nbrDécis)
        Command.Parameters.AddWithValue("?", nbrSortie)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", id)
        Command.Parameters.AddWithValue("?", sexe)
        Command.Parameters.AddWithValue("?", jour)
        Command.ExecuteNonQuery()

    End Sub
    Public Function VerifieExist(ByVal mois_annee As String, ByVal id As Integer) As Boolean

        Dim query As String
        query = "select mois_annee from Mouvement where mois_annee = ? and id_service = ?"
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

        Reader.Close()
        Return exist
    End Function
    Public Function nbrAdmission(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select Nbr_Admis from Mouvement where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrAdmis As Integer
        If (reader.Read) Then
            nbrAdmis = reader("Nbr_Admis")
        Else
            nbrAdmis = 0
        End If
        reader.Close()
        Return nbrAdmis



    End Function
    Public Function nbrTransfer(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select Nbr_Transfer from Mouvement where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrTrans As Integer
        If (reader.Read) Then
            nbrTrans = reader("Nbr_Transfer")
        Else
            nbrTrans = 0
        End If
        reader.Close()
        Return nbrTrans



    End Function
    Public Function nbrJourne(ByVal id As Integer, ByVal mois_annee As String) As Integer
        Dim nbr As Integer
        Dim query As String
        query = "Select journnee from Mouvement where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", "Homme")
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader

        If ((reader.Read) = False OrElse IsDBNull(reader("journnee"))) Then
            nbr = 0
        Else
            nbr = reader("journnee")

        End If
        reader.Close()
        Return nbr
    End Function
    Public Function nbrDécis(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select Nbr_Décis from Mouvement where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrDeath As Integer
        If (reader.Read) Then
            nbrDeath = reader("Nbr_Décis")
        Else
            nbrDeath = 0
        End If
        reader.Close()
        Return nbrDeath



    End Function
    Public Function nbrSortie(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select Nbr_Sortie from Mouvement where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrSort As Integer
        If (reader.Read) Then
            nbrSort = reader("Nbr_Sortie")
        Else
            nbrSort = 0
        End If
        reader.Close()
        Return nbrSort



    End Function
    Function sum_deces(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim dece As Integer
        Dim query As String = "select sum(Nbr_Décis) as nbr from mouvement where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbr"))) Then
            dece = 0
        Else
            dece = CInt(reader("nbr"))

        End If
        Return dece
    End Function
    Function sum_admission(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim dece As Integer
        Dim query As String = "select sum(Nbr_admis) as nbr from mouvement where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbr"))) Then
            dece = 0
        Else
            dece = CInt(reader("nbr"))

        End If
        Return dece
    End Function
    Function sum_Sortie(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim dece As Integer
        Dim query As String = "select sum(Nbr_sortie) as nbr from mouvement where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbr"))) Then
            dece = 0
        Else
            dece = CInt(reader("nbr"))

        End If
        Return dece
    End Function
    Function sum_transfere(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim dece As Integer
        Dim query As String = "select sum(Nbr_transfer) as nbr from mouvement where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbr"))) Then
            dece = 0
        Else
            dece = CInt(reader("nbr"))

        End If
        Return dece
    End Function

End Module
