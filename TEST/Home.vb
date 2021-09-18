Public Class Home

    Private Sub BtnManagePat_Click(sender As Object, e As EventArgs) Handles BtnManagePat.Click
        PersonnelMed.Show()
        Me.Hide()
    End Sub

    Private Sub BtnManageDep_Click_1(sender As Object, e As EventArgs) Handles BtnManageDep.Click
        ManageDep.Show()
        Me.Hide()


    End Sub

    Private Sub BtnDashBoard1_Click(sender As Object, e As EventArgs) Handles BtnDashBoard1.Click
        Me.Show()
    End Sub

    Private Sub BtnManageSer_Click(sender As Object, e As EventArgs) Handles BtnManageSer.Click
        Service.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Module1.connectDB()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnActivity.Click
        Activity.Show()
        Me.Hide()





        Call Service.fillCbDepartement()
    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        Mouvement.Show()
        Me.Hide()

    End Sub

    Private Sub BtnStat_Click(sender As Object, e As EventArgs) Handles BtnStat.Click
        Statistics.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPatient_Click(sender As Object, e As EventArgs) Handles BtnPatient.Click
        Pathologie.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reponse As Integer = MsgBox("Voulez-vous vraiment déconnecté ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If (reponse = MsgBoxResult.No) Then
            Exit Sub
        ElseIf (reponse = MsgBoxResult.Yes) Then

            Me.Close()
        End If
    End Sub
End Class