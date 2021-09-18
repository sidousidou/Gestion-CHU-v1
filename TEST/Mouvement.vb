Imports System.Data.OleDb
Public Class Mouvement
    Private Sub BtnVal2_Click(sender As Object, e As EventArgs) Handles BtnVal2.Click
        If (verifierAdmission() = False) Then

        ElseIf (verifierTransfer() = False) Then

        ElseIf (verifierDécis() = False) Then

        ElseIf (verifierSortie() = False) Then

        Else



            Dim month_year As String
            month_year = (CmbBoxMM.Text) & "_" & (MaskedTextBox2.Text)
            Dim Id As Integer
            Id = ServiceDB.getIdSer(CmbBoxMser.Items(CmbBoxMser.SelectedIndex))
            If (MouvementDB.VerifieExist(month_year, Id)) Then
                Call MouvementDB.UpdateMove(CInt(TxtBoxAHM.Text), CInt(TxtBoxTHM.Text), CInt(TxtBoxDHM.Text), CInt(TxtBoxSHM.Text), month_year, Id, "Homme", CInt(TxtBoxJournee.Text))
                Call MouvementDB.UpdateMove(CInt(TxtBoxAFM.Text), CInt(TxtBoxTFM.Text), CInt(TxtBoxDFM.Text), CInt(TxtBoxSFM.Text), month_year, Id, "Femme", CInt(TxtBoxJournee.Text))
                Call MouvementDB.UpdateMove(CInt(TxtBoxAEM.Text), CInt(TxtBoxTEM.Text), CInt(TxtBoxDEM.Text), CInt(TxtBoxSFM.Text), month_year, Id, "Enfant", CInt(TxtBoxJournee.Text))

            Else
                Call MouvementDB.AddAMove("Homme", CInt(TxtBoxAHM.Text), CInt(TxtBoxTHM.Text), CInt(TxtBoxDHM.Text), CInt(TxtBoxSHM.Text), month_year, Id, CInt(TxtBoxJournee.Text))
                Call MouvementDB.AddAMove("Femme", CInt(TxtBoxAFM.Text), CInt(TxtBoxTFM.Text), CInt(TxtBoxDFM.Text), CInt(TxtBoxSFM.Text), month_year, Id, CInt(TxtBoxJournee.Text))
                Call MouvementDB.AddAMove("Enfant", CInt(TxtBoxAEM.Text), CInt(TxtBoxTEM.Text), CInt(TxtBoxDEM.Text), CInt(TxtBoxSEM.Text), month_year, Id, CInt(TxtBoxJournee.Text))

            End If
            MsgBox("Valide", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BtnDashMouv_Click(sender As Object, e As EventArgs) Handles BtnDashMouv.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub CmbBoxMdep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxMdep.SelectedIndexChanged
        Call fillCbNameService(DepartementDB.getId(CmbBoxMdep.Items(CmbBoxMdep.SelectedIndex)))
        Me.CmbBoxMdep.Refresh()
    End Sub
    Public Sub fillCbNameService(ByVal iddept As Long)

        Dim qu As String = "select nom_service from service, departement where service.id_departement = departement.id_departement and service.id_departement=?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(qu, cnt)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("?", iddept)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxMser.Items.Clear()

        While (reader.Read)
            CmbBoxMser.Items.Add(reader("nom_service"))
        End While
        reader.Close()
        cmd = Nothing


    End Sub
    Public Sub fillCbDepartement1()
        Dim query As String = "Select Nom_departement from Departement "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxMdep.Items.Clear()

        While (reader.Read)
            CmbBoxMdep.Items.Add(reader("nom_departement"))
        End While
        reader.Close()
        cmd = Nothing
    End Sub

    Private Sub CmbBoxMM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxMM.SelectedIndexChanged
        Dim month_year As String
        month_year = (CmbBoxMM.Text) & "_" & (MaskedTextBox2.Text)
        Dim Id As Integer
        Id = ServiceDB.getIdSer(CmbBoxMser.Items(CmbBoxMser.SelectedIndex))
        TxtBoxAHM.Text = MouvementDB.nbrAdmission(Id, month_year, "Homme")
        TxtBoxAFM.Text = MouvementDB.nbrAdmission(Id, month_year, "Femme")
        TxtBoxAEM.Text = MouvementDB.nbrAdmission(Id, month_year, "Enfant")

        TxtBoxTHM.Text = MouvementDB.nbrTransfer(Id, month_year, "Homme")
        TxtBoxTFM.Text = MouvementDB.nbrTransfer(Id, month_year, "Femme")
        TxtBoxTEM.Text = MouvementDB.nbrTransfer(Id, month_year, "Enfant")
        TxtBoxDHM.Text = MouvementDB.nbrDécis(Id, month_year, "Homme")
        TxtBoxDFM.Text = MouvementDB.nbrDécis(Id, month_year, "Femme")
        TxtBoxDEM.Text = MouvementDB.nbrDécis(Id, month_year, "Enfant")
        TxtBoxSHM.Text = MouvementDB.nbrDécis(Id, month_year, "Homme")
        TxtBoxSFM.Text = MouvementDB.nbrDécis(Id, month_year, "Femme")
        TxtBoxSEM.Text = MouvementDB.nbrDécis(Id, month_year, "Enfant")
        TxtBoxJournee.Text = MouvementDB.nbrJourne(Id, month_year)


    End Sub

    Private Sub Mouvement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCbDepartement1()
    End Sub
    Private Function verifierAdmission() As Boolean
        If (CmbBoxMdep.Text = "" OrElse CmbBoxMser.Text = "" OrElse CmbBoxMM.Text = "" OrElse MaskedTextBox2.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ", MsgBoxStyle.Exclamation)
            Return False
        ElseIf (TxtBoxAHM.Text = "" OrElse TxtBoxAFM.Text = "" OrElse TxtBoxAEM.Text = "" OrElse TxtBoxJournee.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Consultation pour Chaque genre Svp !", MsgBoxStyle.Exclamation)
            Return False

        ElseIf Not IsNumeric(TxtBoxAHM.Text) OrElse TxtBoxAHM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxAFM.Text) OrElse TxtBoxAFM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxAEM.Text) OrElse TxtBoxAEM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxJournee.Text) OrElse TxtBoxJournee.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
    Private Function verifierTransfer() As Boolean
        If (CmbBoxMdep.Text = "" OrElse CmbBoxMser.Text = "" OrElse CmbBoxMM.Text = "" OrElse MaskedTextBox2.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ", MsgBoxStyle.Exclamation)
            Return False
        ElseIf (TxtBoxTHM.Text = "" OrElse TxtBoxTFM.Text = "" OrElse TxtBoxTEM.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Acte Opératoire pour Chaque genre Svp !", MsgBoxStyle.Exclamation)
            Return False


        ElseIf Not IsNumeric(TxtBoxTHM.Text) OrElse TxtBoxTHM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxTFM.Text) OrElse TxtBoxTFM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxTEM.Text) OrElse TxtBoxTEM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
    Private Function verifierDécis() As Boolean
        If (CmbBoxMdep.Text = "" OrElse CmbBoxMser.Text = "" OrElse CmbBoxMM.Text = "" OrElse MaskedTextBox2.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ", MsgBoxStyle.Exclamation)
            Return False
        ElseIf (TxtBoxDHM.Text = "" OrElse TxtBoxDFM.Text = "" OrElse TxtBoxDEM.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Exams pour Chaque genre Svp !", MsgBoxStyle.Exclamation)
            Return False


        ElseIf Not IsNumeric(TxtBoxDHM.Text) OrElse TxtBoxDHM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxDFM.Text) OrElse TxtBoxDFM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxDEM.Text) OrElse TxtBoxDEM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
    Private Function verifierSortie() As Boolean
        If (CmbBoxMdep.Text = "" OrElse CmbBoxMser.Text = "" OrElse CmbBoxMM.Text = "" OrElse MaskedTextBox2.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ", MsgBoxStyle.Exclamation)
            Return False
        ElseIf (TxtBoxSHM.Text = "" OrElse TxtBoxSFM.Text = "" OrElse TxtBoxSEM.Text = "") Then
            MsgBox("le champ est vide : Enter les valeurs des Exams pour Chaque genre Svp !", MsgBoxStyle.Exclamation)
            Return False

        ElseIf Not IsNumeric(TxtBoxSHM.Text) OrElse TxtBoxSHM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxSFM.Text) OrElse TxtBoxSFM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(TxtBoxSEM.Text) OrElse TxtBoxSEM.Text < 0 Then
            MsgBox("SVP,il faut selectionner des valeur  nummérique Et positive pour les champs", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub CmbBoxMser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxMser.SelectedIndexChanged

    End Sub


End Class