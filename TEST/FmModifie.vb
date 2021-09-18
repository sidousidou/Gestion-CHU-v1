Public Class FmModifie
    Public ref As Service
    Private Sub FmModifie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If (txtNbrlit.Text = "" OrElse Not IsNumeric(txtNbrlit.Text)) Then
            MsgBox("Error : please fill the spaces correctly ")
        ElseIf (txtNbrlit.Text < 0)
            MsgBox("Svp , Saisie une valeur positive pour le nombre des lits")
        Else
            Call ServiceDB.UpdateService(lblService.Text, CInt(txtNbrlit.Text))
            MsgBox("le nombre des lits a été modifie avec succée")
            Me.Close()
        End If
    End Sub

    Private Sub FmModifie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call ref.DataGridView1()
    End Sub



    Private Sub BtnCancel2_Click(sender As Object, e As EventArgs) Handles BtnCancel2.Click
        Me.Close()

    End Sub


End Class