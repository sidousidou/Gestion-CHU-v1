Imports System.Data.OleDb
Module ActivityDB


    Public Sub AddActivity(ByVal nbrCons1 As Integer, ByVal sexe As String, ByVal nbrAop As Integer, ByVal nbrE As Integer, ByVal Mois_Année As String, ByVal idSer As Integer)
        Dim query As String
        query = "Insert into Activity (nbr_consultation ,sexe ,nbr_actOperatoir ,nbrExam , mois_annee ,id_service) values(?,?,?,?,?,?)"
        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nbrCons1)
        Command.Parameters.AddWithValue("?", sexe)
        Command.Parameters.AddWithValue("?", nbrAop)
        Command.Parameters.AddWithValue("?", nbrE)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", idSer)
        Command.ExecuteNonQuery()

    End Sub


    Public Sub UpdateActivity(ByVal nbrCons1 As Long, ByVal nbrAop As Integer, ByVal nbrE As Integer, ByVal Mois_Année As String, ByVal id As Integer, ByVal sexe As String)
        Dim query As String
        query = "update Activity set nbr_consultation=?, nbr_actOperatoir=?, nbrExam=? where mois_annee=? and id_service = ? and sexe=?"

        Dim Command As OleDbCommand
        Command = New OleDbCommand(query, cnt)
        Command.Parameters.AddWithValue("?", nbrCons1)
        Command.Parameters.AddWithValue("?", nbrAop)
        Command.Parameters.AddWithValue("?", nbrE)
        Command.Parameters.AddWithValue("?", Mois_Année)
        Command.Parameters.AddWithValue("?", id)
        Command.Parameters.AddWithValue("?", sexe)
        Command.ExecuteNonQuery()

    End Sub
    Public Function VerifieExist(ByVal mois_annee As String, ByVal id As Integer) As Boolean

        Dim query As String
        query = "select mois_annee from Activity where mois_annee = ? and id_service = ?"
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
    Public Function nbreconsultation(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select nbr_consultation from activity where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrecons As Integer
        If (reader.Read) Then
            nbrecons = reader("nbr_consultation")
        Else
            nbrecons = 0
        End If
        reader.Close()
        Return nbrecons



    End Function
    Public Function nbreacteoperatoir(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select nbr_actoperatoir from activity where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrecons As Integer
        If (reader.Read) Then
            nbrecons = reader("nbr_actoperatoir")
        Else
            nbrecons = 0
        End If
        reader.Close()
        Return nbrecons



    End Function
    Public Function nbreexam(ByVal id As Integer, ByVal mois_annee As String, ByVal sexe As String) As Integer
        Dim query As String
        query = "Select nbrexam from activity where id_service=? and mois_annee=? and sexe = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", mois_annee)
        cmd.Parameters.AddWithValue("?", sexe)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Dim nbrecons As Integer
        If (reader.Read) Then
            nbrecons = reader("nbrexam")
        Else
            nbrecons = 0
        End If
        reader.Close()
        Return nbrecons



    End Function
    Function Sum_consultation(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim con As Integer
        Dim query As String = "select sum(nbr_consultation) as nbrc from activity where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbrc"))) Then
            con = 0
        Else
            con = CInt(reader("nbrc"))

        End If
        Return con
    End Function
    Function Sum_Actes(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim con As Integer
        Dim query As String = "select sum(nbr_actOperatoir) as nbrc from activity where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbrc"))) Then
            con = 0
        Else
            con = CInt(reader("nbrc"))

        End If
        Return con
    End Function
    Function Sum_exam(ByVal id As Integer, ByVal month_year As String) As Integer
        Dim con As Integer
        Dim query As String = "select sum(nbrexam) as nbrc from activity where id_service = ? and mois_annee = ?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        cmd.Parameters.AddWithValue("?", id)
        cmd.Parameters.AddWithValue("?", month_year)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If (reader.Read() = False OrElse IsDBNull(reader("nbrc"))) Then
            con = 0
        Else
            con = CInt(reader("nbrc"))

        End If
        Return con
    End Function

End Module
