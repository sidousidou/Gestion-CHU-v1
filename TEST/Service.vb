Imports System.Data.OleDb
Public Class Service
    Private Function verifier() As Boolean
        If (TxtNomService.Text = "" OrElse TxtNbrLits.Text = "") Then
            MsgBox("SVP, il faut tout d'abord indiquer un nom pour service et un nombre de lits", MsgBoxStyle.Exclamation)
            Return False
        ElseIf Not IsNumeric(TxtNbrLits.Text) Then
            MsgBox("SVP,il faut selectionner une valeur numerique pour le champ nombre de lits", MsgBoxStyle.Critical)
            Return False
        ElseIf (TxtNbrLits.Text < 0) Then
            MsgBox("Svp , Saisie une valeur positive pour le nombre des lits", MsgBoxStyle.Critical)
            Return False
        ElseIf (cbDepartement.Text = "") Then
            MsgBox("Svp,selectionner  Un departement ", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function






    Public Sub DataGridView1(Optional ByVal iddept As Long = 0)

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim dm As New OleDbDataAdapter
        If (iddept = 0) Then
            dm = New OleDbDataAdapter("select id_ser, Nom_Service,  Nom_Departement, nbre_lits from Service, Departement where Service.id_departement = Departement.id_departement", cnt)
        Else
            dm = New OleDbDataAdapter("select id_ser, Nom_Service,  Nom_Departement, nbre_lits from Service, Departement where Service.id_departement = Departement.id_departement and Service.id_departement=" & iddept, cnt)
        End If
        dm.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Columns(0).HeaderText = "Id service"
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).HeaderText = "Nom de service"
        DataGridView2.Columns(2).HeaderText = "Nom de département"
        DataGridView2.Columns(3).HeaderText = "Nombre des lits"

    End Sub


    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''CONSTRUCT DATAGRIDVIEW

        Call fillCbDepartement()

        Call DataGridView1()




    End Sub

    Public Sub fillCbDepartement()
        Dim query As String = "Select Nom_departement from Departement "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        cbDepartement.Items.Clear()
        cbDep1.Items.Clear()
        While (reader.Read)
            cbDepartement.Items.Add(reader("nom_departement"))
            cbDep1.Items.Add(reader("nom_departement"))
        End While
        reader.Close()
        cmd = Nothing
    End Sub



    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub BtnDashboard3_Click(sender As Object, e As EventArgs) Handles BtnDashboard3.Click
        Home.Show()




        cbDep1.Text = String.Empty
        cbDepartement.Text = String.Empty

        Call fillCbDepartement()

        Me.Hide()
    End Sub

    Private Sub cbDepartement_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub






    Private Sub TxtNomService_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbDepartement_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnDel_Click_1(sender As Object, e As EventArgs) Handles BtnDel.Click
        If (IsNothing(DataGridView2.CurrentRow) OrElse DataGridView2.CurrentRow.Index < 0) Then
            MsgBox("SVP, il faut tout d’abord sélectionner un Service !", MsgBoxStyle.Exclamation)
        Else
            Dim ind As Integer
            ind = DataGridView2.CurrentRow.Index
            Dim nomser As String
            nomser = DataGridView2.Rows(ind).Cells(1).Value
            Dim id As Long
            id = ServiceDB.getIdSer(nomser)
            If (VerifierActINSer(id) = True) Then
                MsgBox("Attention, il y a des activity affectés à le Service sélectionné ", MsgBoxStyle.Critical)
            Else
                Dim reponse As Integer = MsgBox("Voulez-vous vraiment supprimer cet département ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If (reponse = MsgBoxResult.No) Then
                    Exit Sub
                ElseIf (reponse = MsgBoxResult.Yes)
                    Call ServiceDB.DeleteService(nomser)
                    Call fillCbDepartement()

                    Call Statistics.fillCbDepartement2()

                    Call Activity.fillCbDepartement1()

                    Call Mouvement.fillCbDepartement1()
                    Call PersonnelMed.fillCmbBoxDepPer()
                    Call Pathologie.fillCbDepartement3()
                    Call DataGridView1()
                    MsgBox("Le Service sélectionné est supprimé avec succès.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                End If

            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click_1(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If (IsNothing(DataGridView2.CurrentRow) OrElse DataGridView2.CurrentRow.Index < 0) Then
            MsgBox("SVP, il faut tout d'abord sélectionner un Service!", MsgBoxStyle.Exclamation)
        Else
            Dim FrMod As New FmModifie
            Dim ind As Integer
            ind = DataGridView2.CurrentRow.Index
            FrMod.ref = Me
            FrMod.lblDepartement.Text = DataGridView2.Rows(ind).Cells(2).Value
            FrMod.lblService.Text = DataGridView2.Rows(ind).Cells(1).Value
            FrMod.txtNbrlit.Text = DataGridView2.Rows(ind).Cells(3).Value
            FrMod.ShowDialog()


            Call DataGridView1()

        End If
    End Sub

    Private Sub cbDep1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbDep1.SelectedIndexChanged
        Dim id As Long
        id = DepartementDB.getId(cbDep1.Items(cbDep1.SelectedIndex))
        Me.cbDep1.Refresh()
        Call DataGridView1(id)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If (verifier() = True) Then
            If (ServiceDB.VerifieExist(TxtNomService.Text)) Then

                MsgBox("Cet  sevice est toujeur existe", MsgBoxStyle.Critical)
            Else
                Dim reponse As Integer = MsgBox("Voulez-vous vraiment ajouter cet Service ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If (reponse = MsgBoxResult.No) Then
                    Exit Sub
                ElseIf (reponse = MsgBoxResult.Yes)
                    Dim Id_departement As Long
                    Id_departement = DepartementDB.getId(cbDepartement.Text)
                    Call ServiceDB.AjouteService(TxtNomService.Text, CInt(TxtNbrLits.Text), Id_departement)
                    MsgBox("Le Service Est Ajoutée Avec succée", MsgBoxStyle.Information)
                    TxtNbrLits.Text = String.Empty
                    TxtNomService.Text = String.Empty
                    Call DataGridView1()
                    Call fillCbDepartement()
                    Call Statistics.fillCbDepartement2()

                    Call Activity.fillCbDepartement1()

                    Call Mouvement.fillCbDepartement1()
                    Call PersonnelMed.fillCmbBoxDepPer()
                    Call Pathologie.fillCbDepartement3()
                End If
            End If
        End If
    End Sub

    Private Sub cbDepartement_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles cbDepartement.SelectedIndexChanged

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub TabSerList_Click(sender As Object, e As EventArgs) Handles TabSerList.Click

        cbDepartement.Text = String.Empty
        Me.cbDepartement.Refresh()



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub TabSerAdd_Click(sender As Object, e As EventArgs) Handles TabSerAdd.Click
        cbDep1.Text = String.Empty

        Me.cbDep1.Refresh()

    End Sub
End Class