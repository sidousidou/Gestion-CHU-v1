Imports System.Data.OleDb
Public Class Pathologie


    Private Sub BtnAddPath_Click(sender As Object, e As EventArgs) Handles BtnAddPath.Click

        If (verifierP() = True) Then
            If (PathologieDB.VerifiePatient(TxtBoxNomPt.Text) = True) Then

                MsgBox("Cet Nom est toujeur Existe")
            Else
                Dim reponse As Integer = MsgBox("Voulez-vous vraiment Ajouter cet Pathologie ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If (reponse = MsgBoxResult.No) Then
                    Exit Sub
                ElseIf (reponse = MsgBoxResult.Yes)
                    Dim Id_Service As Integer
                    Id_Service = ServiceDB.getIdSer(CmbBoxPathSer.Text)
                    Call PathologieDB.AddPathologie(TxtBoxNomPt.Text, Id_Service)
                    Call DataGrid()

                    MsgBox("Le Pathologie Est Ajoutée Avec succée")


                End If

            End If
        End If
    End Sub
    Public Sub DataGrid(Optional ByVal idser As Long = 0)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim dm As New OleDbDataAdapter
        If (idser = 0) Then
            dm = New OleDbDataAdapter("select Numero_Malade, Nom_Maladie,  id_service from Pathologie, Service where Pathologie.id_service = Service.id_ser", cnt)
        Else
            dm = New OleDbDataAdapter("select id_service, Nom_Maladie,  Numero_Malade from Pathologie, Service where Pathologie.id_service = Service.id_ser and Pathologie.id_service=" & idser, cnt)
        End If
        dm.Fill(dt)
        DtMalade.DataSource = dt.DefaultView
        DtMalade.Columns(2).HeaderText = "Id Service"
        DtMalade.Columns(2).Visible = False
        DtMalade.Columns(1).HeaderText = "Nom des Malades"
        DtMalade.Columns(0).HeaderText = "N° De Malade"
    End Sub
    Private Sub CmbBoxPathSer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxPathSer.SelectedIndexChanged

    End Sub
    Public Sub fillCbNameService3(ByVal iddept As Long)

        Dim qu As String = "select nom_service from service, departement where service.id_departement = departement.id_departement and service.id_departement=?"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(qu, cnt)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("?", iddept)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxPathSer.Items.Clear()
        CmbPathser.Items.Clear()
        While (reader.Read)
            CmbBoxPathSer.Items.Add(reader("nom_service"))

        End While
        reader.Close()
        cmd = Nothing


    End Sub
    Public Sub fillCbDepartement3()
        Dim query As String = "Select Nom_departement from Departement "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxDepPath.Items.Clear()

        While (reader.Read)
            CmbBoxDepPath.Items.Add(reader("nom_departement"))
        End While
        reader.Close()
        cmd = Nothing
    End Sub

    Private Sub CmbBoxDepPath_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxDepPath.SelectedIndexChanged
        Call fillCbNameService3(DepartementDB.getId(CmbBoxDepPath.Items(CmbBoxDepPath.SelectedIndex)))
        Me.CmbBoxDepPath.Refresh()
        Me.CmbBoxPathSer.Refresh()
    End Sub

    Private Sub Pathologie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCmbPathser()
        Call fillCbDepartement3()
        Call DataGrid()

    End Sub
    Public Sub fillCmbPathser()
        Dim query As String = "select Nom_service from Service "
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbPathser.Items.Clear()

        While (reader.Read)
            CmbPathser.Items.Add(reader("Nom_Service"))

        End While
        reader.Close()
        cmd = Nothing
    End Sub
    Private Function verifierP() As Boolean
        If (CmbBoxDepPath.Text = "" OrElse CmbBoxPathSer.Text = "") Then
            MsgBox(" Le champ n'est pas selectionne ")
            Return False
        ElseIf (TxtBoxNomPt.Text = "") Then
            MsgBox("le champ est vide : Enter un Nom pour ton patient !")
            Return False

        End If
        Return True
    End Function

    Private Sub DtMalade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtMalade.CellContentClick
        Call DataGrid()
    End Sub

    Private Sub CmbPathser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPathser.SelectedIndexChanged
        Dim id As Long
        id = ServiceDB.getIdSer(CmbPathser.Items(CmbPathser.SelectedIndex))
        Call DataGrid(id)
        Me.CmbBoxPathSer.Refresh()
    End Sub

    Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click
        If (IsNothing(DtMalade.CurrentRow) OrElse DtMalade.CurrentRow.Index < 0) Then
            MsgBox("SVP, il faut tout d’abord sélectionner un Malade !")
        Else
            Dim reponse As Integer = MsgBox("Voulez-vous vraiment supprimer cet Malade ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If (reponse = MsgBoxResult.No) Then
                Exit Sub
            ElseIf (reponse = MsgBoxResult.Yes)
                Dim nomPatient As String

                Dim ind As Integer
                ind = DtMalade.CurrentRow.Index
                nomPatient = DtMalade.Rows(ind).Cells(1).Value
                Call PathologieDB.DeleteMalade(nomPatient)
                Call DataGrid()
                MsgBox("Le Malade sélectionné est supprimé avec succès.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)


            End If
        End If
    End Sub
End Class