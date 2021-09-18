Imports System.Data.OleDb
Public Class PersonnelMed
    Public Property PersonnelDB As Object

    Private Sub PersonnelMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCmbBoxDepPer()
    End Sub
    Public Sub fillCmbBoxDepPer()
        Dim query As String = "Select Nom_departement from Departement "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxDepPer.Items.Clear()

        While (reader.Read)
            CmbBoxDepPer.Items.Add(reader("nom_departement"))
        End While
        reader.Close()
        cmd = Nothing
    End Sub
    Public Sub fillCmbBoxPerSer(ByVal iddept As Long)

        Dim qu As String = "select nom_service from service, departement where service.id_departement = departement.id_departement and service.id_departement=?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(qu, cnt)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("?", iddept)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxPerSer.Items.Clear()

        While (reader.Read)
            CmbBoxPerSer.Items.Add(reader("nom_service"))
        End While
        reader.Close()
        cmd = Nothing


    End Sub

    Private Sub CmbBoxDepPer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxDepPer.SelectedIndexChanged
        Call fillCmbBoxPerSer(DepartementDB.getId(CmbBoxDepPer.Items(CmbBoxDepPer.SelectedIndex)))
        Me.CmbBoxDepPer.Refresh()
    End Sub
    Private Function verifyPer() As Boolean
        If (CmbBoxDepPer.Text = "" OrElse CmbBoxPerSer.Text = "" OrElse CmbBoxMonthP.Text = "" OrElse MskdTxtPerYear.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ")
            Return False
        ElseIf (TxtBoxMED.Text = "" OrElse TxtBoxNbrChiru.Text = "" OrElse TxtBoxPara.Text = "") Then
            MsgBox("SVP,le champ est vide : Enter les valeurs des Consultation pour Chaque genre Svp !")
            Return False

        ElseIf Not IsNumeric(TxtBoxMED.Text) OrElse TxtBoxMED.Text < 0 Then
            MsgBox("SVP ,il faut selectionner des valeur nummérique Et postive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxNbrChiru.Text) OrElse TxtBoxNbrChiru.Text < 0 Then
            MsgBox("SVP, il faut selectionner des valeur nummérique Et postive pour les champs")
            Return False
        ElseIf Not IsNumeric(TxtBoxPara.Text) OrElse TxtBoxPara.Text < 0 Then
            MsgBox("SVP, il faut selectionner des valeur nummérique Et postive pour les champs")
            Return False
        End If
        Return True
    End Function

    Private Sub BtnValP_Click(sender As Object, e As EventArgs) Handles BtnValP.Click
        If (verifyPer() = False) Then
        Else
            Dim Mois_annee As String
            Mois_annee = (CmbBoxMonthP.Text) & "_" & (MskdTxtPerYear.Text)
            Dim Id As Integer
            Id = ServiceDB.getIdSer(CmbBoxPerSer.Items(CmbBoxPerSer.SelectedIndex))
            If (PersonnelDB1.VerifyExist(Mois_annee, Id)) Then
                Call PersonnelDB1.UpdatePer(CInt(TxtBoxNbrChiru.Text), CInt(TxtBoxMED.Text), CInt(TxtBoxPara.Text), Mois_annee, Id)

                MsgBox("L'activité est Modifée")

            Else
                Call PersonnelDB1.AddPersonne(CInt(TxtBoxNbrChiru.Text), CInt(TxtBoxMED.Text), CInt(TxtBoxPara.Text), Mois_annee, Id)

                MsgBox("Ajoutée")
            End If


        End If



    End Sub

    Private Sub CmbBoxMonthP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxMonthP.SelectedIndexChanged
        Dim month_year As String
        month_year = (CmbBoxMonthP.Text) & "_" & (MskdTxtPerYear.Text)
        Dim Id As Integer
        Id = ServiceDB.getIdSer(CmbBoxPerSer.Items(CmbBoxPerSer.SelectedIndex))
        TxtBoxNbrChiru.Text = PersonnelDB1.nbrChiru(Id, month_year)
        TxtBoxMED.Text = PersonnelDB1.nbrMed(Id, month_year)
        TxtBoxPara.Text = PersonnelDB1.nbrePara(Id, month_year)
    End Sub

    Private Sub BtnDashP_Click(sender As Object, e As EventArgs) Handles BtnDashP.Click
        Me.Hide()
        Home.Show()
    End Sub


End Class