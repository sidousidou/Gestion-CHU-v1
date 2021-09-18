Public Class FrmUpdatedep
    Public iddepartement
    Public Cls As New ManageDep
    Private Sub FrmUpdateDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If (TxtBoxDep.Text = "") Then
            MsgBox("Error : please fill the spaces correctly ")
        Else
            Call DepartementDB.UpdateDepartement(TxtBoxDep.Text, idDepartement)
            MsgBox("Updated")
            Me.Close()
        End If
    End Sub

    Private Sub FrmUpdatedep_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Cls.Datagridview4()
    End Sub

    Private Sub TxtBoxDep_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDep.TextChanged

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class