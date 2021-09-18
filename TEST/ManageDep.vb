Imports System.Data.OleDb
Public Class ManageDep


    Dim Connection As New OleDbConnection
    Private Sub BtnDashboard2_Click(sender As Object, e As EventArgs) Handles BtnDashboard2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub BtnaAddDep_Click_1(sender As Object, e As EventArgs) Handles BtnaAddDep.Click

        If (verifier() = True) Then
            If (VerifieExistnom(TxtBoxDepName.Text) = True) Then

                MsgBox("Cet Departement est toujeur existe", MsgBoxStyle.Critical)
            Else
                Dim reponse As Integer = MsgBox("Voulez-vous vraiment ajouter cet Departement ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If (reponse = MsgBoxResult.No) Then
                    Exit Sub
                ElseIf (reponse = MsgBoxResult.Yes)
                    Call DepartementDB.AddDepartement(TxtBoxDepName.Text)
                    Call Datagridview4()
                    TxtBoxDepName.Text = ""
                    Call Statistics.fillCbDepartement2()
                    Call Activity.fillCbDepartement1()
                    Call PersonnelMed.fillCmbBoxDepPer()
                    MsgBox("le Departement a été ajoutée avec succé")
                End If
            End If
        End If
    End Sub

    Public Sub Datagridview4()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim dm As New OleDbDataAdapter
        dm = New OleDbDataAdapter("select * FROM Departement ", cnt)
        dm.Fill(dt)
        DataGridView3.DataSource = dt.DefaultView
        DataGridView3.Columns(0).HeaderText = "Id Departement"
        DataGridView3.Columns(0).Visible = False
        DataGridView3.Columns(1).HeaderText = "Nom des Departement"
    End Sub

    Private Function verifier() As Boolean
        If (TxtBoxDepName.Text = "") Then
            MsgBox("SVP Saisez un nom pour le dapartement !")
            Return False

        End If
        Return True
    End Function



    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Call Datagridview4()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If (IsNothing(DataGridView3.CurrentRow) OrElse DataGridView3.CurrentRow.Index < 0) Then
            MsgBox("SVP, il faut tout d’abord sélectionner un département!", MsgBoxStyle.Exclamation)
        Else
            Dim nomdept As String
            Dim ind As Integer
            ind = DataGridView3.CurrentRow.Index
            nomdept = DataGridView3.Rows(ind).Cells(1).Value

            Dim idDepartement As Integer = DepartementDB.getId(nomdept)
            If (VerifierSer(idDepartement) = True) Then
                MsgBox("Attention, il y a des services affectés à le département sélectionné ", MsgBoxStyle.Critical)
            Else
                Dim reponse As Integer = MsgBox("Voulez-vous vraiment supprimer cet département ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If (reponse = MsgBoxResult.No) Then
                    Exit Sub
                ElseIf (reponse = MsgBoxResult.Yes)
                    Call DepartementDB.DeleteDepartemnt(nomdept)
                    Call Datagridview4()
                    Call Statistics.fillCbDepartement2()

                    Call Activity.fillCbDepartement1()

                    Call Mouvement.fillCbDepartement1()
                    Call PersonnelMed.fillCmbBoxDepPer()
                    Call Pathologie.fillCbDepartement3()
                    MsgBox("La département sélectionné est supprimé avec succès.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If

            End If
            End If

    End Sub

    Public Sub BtnModf_Click(sender As Object, e As EventArgs) Handles BtnModf.Click
        If (IsNothing(DataGridView3.CurrentRow) OrElse DataGridView3.CurrentRow.Index < 0) Then
            MsgBox("SVP, il faut tout d'abord sélectionner un département!", MsgBoxStyle.Exclamation)
        Else
            Dim FrmDep As New FrmUpdatedep
            Dim i As Integer

            i = DataGridView3.CurrentRow.Index
            FrmDep.Cls = Me
            FrmDep.TxtBoxDep.Text = DataGridView3.Rows(i).Cells(1).Value
            Dim idDepartement As Integer = DepartementDB.getId(DataGridView3.Rows(i).Cells(1).Value)
            FrmDep.iddepartement = idDepartement
            FrmDep.ShowDialog()

            Call Datagridview4()

        End If

    End Sub
    Private Sub ManageDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Datagridview4()
    End Sub

    Private Sub DataGridView3_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub BtnDepDep_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub BtnSerDep_Click(sender As Object, e As EventArgs) Handles BtnSerDep.Click
        Me.Hide()
        Service.Show()
    End Sub

    Private Sub TxtBoxDepName_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDepName.TextChanged

    End Sub
End Class