Imports System.Data.OleDb
Public Class Activity

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartement.SelectedIndexChanged
        Call fillCbNameService(DepartementDB.getId(cbDepartement.Items(cbDepartement.SelectedIndex)))
        CmbBoxM.Text = String.Empty
        MaskedTextBox1.Text = String.Empty
        Me.cbDepartement.Refresh()

    End Sub




    Private Sub Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCbDepartement1()

    End Sub
    Public Sub fillCbDepartement1()
        Dim query As String = "Select Nom_departement from Departement "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        cbDepartement.Items.Clear()

        While (reader.Read)
            cbDepartement.Items.Add(reader("nom_departement"))
        End While
        reader.Close()
        cmd = Nothing
    End Sub

    Public Sub fillCbNameService(ByVal iddept As Long)

        Dim qu As String = "select nom_service from service, departement where service.id_departement = departement.id_departement and service.id_departement=?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(qu, cnt)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("?", iddept)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxSer.Items.Clear()

        While (reader.Read)
            CmbBoxSer.Items.Add(reader("nom_service"))
        End While
        reader.Close()
        cmd = Nothing


    End Sub
    Private Function verifierCon() As Boolean
        If (cbDepartement.Text = "" OrElse CmbBoxSer.Text = "" OrElse CmbBoxM.Text = "" OrElse MaskedTextBox1.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ")
            Return False
        ElseIf (TxtBoxH.Text = "" OrElse TxtBoxF.Text = "" OrElse TxtBoxE.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Consultation pour Chaque genre Svp !")
            Return False

        ElseIf Not IsNumeric(TxtBoxH.Text) OrElse TxtBoxH.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique  et positive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxF.Text) OrElse TxtBoxF.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique et positive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxE.Text) OrElse TxtBoxE.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique et positive pour les champs")
            Return False
        End If
        Return True
    End Function
    Private Function verifierActe() As Boolean
        If (cbDepartement.Text = "" OrElse CmbBoxSer.Text = "" OrElse CmbBoxM.Text = "" OrElse MaskedTextBox1.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ")
            Return False
        ElseIf (TxtBoxAh.Text = "" OrElse TxtBoxAf.Text = "" OrElse TxtBoxAe.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Acte Opératoire pour Chaque genre Svp !")
            Return False

        ElseIf Not IsNumeric(TxtBoxAh.Text) OrElse TxtBoxAh.Text < 0 Then
            MsgBox(" il faut selectionner des valeur nummérique  et positive pour les champs ")
            Return False
        ElseIf Not IsNumeric(TxtBoxAf.Text) OrElse TxtBoxAf.Text < 0 Then
            MsgBox(" il faut selectionner des valeur nummérique  et positive pour les champs ")
            Return False
        ElseIf Not IsNumeric(TxtBoxAe.Text) OrElse TxtBoxAe.Text < 0 Then
            MsgBox(" il faut selectionner des valeur nummérique  et positive pour les champs ")
            Return False
        End If
        Return True
    End Function
    Private Function verifierExam() As Boolean
        If (cbDepartement.Text = "" OrElse CmbBoxSer.Text = "" OrElse CmbBoxM.Text = "" OrElse MaskedTextBox1.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ")
            Return False
        ElseIf (TxtBoxEh.Text = "" OrElse TxtBoxEf.Text = "" OrElse TxtBoxEe.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Exams pour Chaque genre Svp !")
            Return False

        ElseIf Not IsNumeric(TxtBoxEh.Text) OrElse TxtBoxEh.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique et positive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxEf.Text) OrElse TxtBoxEf.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique  et positive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxEe.Text) OrElse TxtBoxEe.Text < 0 Then
            MsgBox("il faut selectionner des valeur nummérique et positive pour les champs")
            Return False

        End If
        Return True
    End Function
    Private Sub CmbBoxSer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxSer.SelectedIndexChanged

    End Sub

    Private Sub BtnDashAct_Click(sender As Object, e As EventArgs) Handles BtnDashAct.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub BtnVal_Click(sender As Object, e As EventArgs) Handles BtnVal.Click
        If (verifierCon() = False) Then

        ElseIf (verifierActe() = False) Then

        ElseIf (verifierExam() = False) Then

        Else



            Dim month_year As String
            month_year = (CmbBoxM.Text) & "_" & (MaskedTextBox1.Text)
            Dim Id As Integer
            Id = ServiceDB.getIdSer(CmbBoxSer.Items(CmbBoxSer.SelectedIndex))
            If (ActivityDB.VerifieExist(month_year, Id)) Then
                Call ActivityDB.UpdateActivity(CInt(TxtBoxH.Text), CInt(TxtBoxAh.Text), CInt(TxtBoxEh.Text), month_year, Id, "Homme")
                Call ActivityDB.UpdateActivity(CInt(TxtBoxF.Text), CInt(TxtBoxAf.Text), CInt(TxtBoxEf.Text), month_year, Id, "Femme")
                Call ActivityDB.UpdateActivity(CInt(TxtBoxE.Text), CInt(TxtBoxAe.Text), CInt(TxtBoxEe.Text), month_year, Id, "Enfant")
                MsgBox("L'activité est Modifée", MsgBoxStyle.Information)


            Else
                Call ActivityDB.AddActivity(CInt(TxtBoxH.Text), "Homme", CInt(TxtBoxAh.Text), CInt(TxtBoxEh.Text), month_year, Id)
                Call ActivityDB.AddActivity(CInt(TxtBoxF.Text), "Femme", CInt(TxtBoxAf.Text), CInt(TxtBoxEf.Text), month_year, Id)
                Call ActivityDB.AddActivity(CInt(TxtBoxE.Text), "Enfant", CInt(TxtBoxAe.Text), CInt(TxtBoxEe.Text), month_year, Id)

                MsgBox("L'activité Est Ajoutée", MsgBoxStyle.Information)
            End If


        End If

    End Sub






    Private Sub CmbBoxM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxM.SelectedIndexChanged
        Dim month_year As String
        month_year = (CmbBoxM.Text) & "_" & (MaskedTextBox1.Text)
        Dim Id As Integer
        Id = ServiceDB.getIdSer(CmbBoxSer.Items(CmbBoxSer.SelectedIndex))
        TxtBoxH.Text = ActivityDB.nbreconsultation(Id, month_year, "Homme")
        TxtBoxF.Text = ActivityDB.nbreconsultation(Id, month_year, "Femme")
        TxtBoxE.Text = ActivityDB.nbreconsultation(Id, month_year, "Enfant")
        TxtBoxAh.Text = ActivityDB.nbreacteoperatoir(Id, month_year, "Homme")
        TxtBoxAf.Text = ActivityDB.nbreacteoperatoir(Id, month_year, "Femme")
        TxtBoxAe.Text = ActivityDB.nbreacteoperatoir(Id, month_year, "Enfant")
        TxtBoxEh.Text = ActivityDB.nbreexam(Id, month_year, "Homme")
        TxtBoxEf.Text = ActivityDB.nbreexam(Id, month_year, "Femme")
        TxtBoxEe.Text = ActivityDB.nbreexam(Id, month_year, "Enfant")
    End Sub

    Private Sub GrpBox1_Enter(sender As Object, e As EventArgs) Handles GrpBox1.Enter

    End Sub
End Class