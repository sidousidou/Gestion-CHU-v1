Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Statistics


    Private Sub CmbBoxStDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxStDep.SelectedIndexChanged

        GdStat.Rows.Clear()



    End Sub
    Public Sub fillCbDepartement2()
        Dim query As String = "Select Nom_departement from Departement"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, cnt)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        CmbBoxStDep.Items.Clear()
        While (reader.Read)
            CmbBoxStDep.Items.Add(reader("nom_departement"))

        End While
        reader.Close()
        cmd = Nothing
    End Sub
    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCbDepartement2()

    End Sub

    Private Sub Datagridviewstat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GdStat.CellContentClick

    End Sub
    Private Sub MskedTxtBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskedTxtBox1.MaskInputRejected
        GdStat.Rows.Clear()
        CmbBoxMonth.Text = String.Empty
    End Sub

    Private Sub CmbBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxMonth.SelectedIndexChanged
        If (CmbBoxStDep.Text = String.Empty OrElse MskedTxtBox1.Text = String.Empty) Then
            MsgBox("Selectioner Departement et L'annee SVP !")
        Else
            GdStat.Rows.Clear()
            Dim month_year As String = ((CmbBoxMonth.Text) & "_" & (MskedTxtBox1.Text))
            Dim id As Long
            id = DepartementDB.getId(CmbBoxStDep.Items(CmbBoxStDep.SelectedIndex))
            Dim query As String = "select id_ser from service where id_departement = ?"
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, cnt)
            cmd.Parameters.AddWithValue("?", id)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader

            Dim i As Integer = 0
            While (reader.Read)
                Dim idser As Long
                idser = CInt(reader("id_ser"))
                GdStat.Rows.Add()
                GdStat.Rows(i).Cells(0).Value = ServiceDB.get_nom_service(idser)
                GdStat.Rows(i).Cells(1).Value = ServiceDB.get_nbre_lits(idser)
                GdStat.Rows(i).Cells(2).Value = MouvementDB.sum_admission(idser, month_year)
                If (MouvementDB.sum_admission(idser, month_year) - (MouvementDB.sum_Sortie(idser, month_year) + MouvementDB.sum_transfere(idser, month_year) + MouvementDB.sum_deces(idser, month_year)) > 0) Then


                    GdStat.Rows(i).Cells(3).Value = MouvementDB.sum_admission(idser, month_year) - ((MouvementDB.sum_Sortie(idser, month_year) + MouvementDB.sum_transfere(idser, month_year) + MouvementDB.sum_deces(idser, month_year)))
                Else
                    GdStat.Rows(i).Cells(3).Value = 0
                End If

                GdStat.Rows(i).Cells(4).Value = ActivityDB.Sum_consultation(idser, month_year)
                GdStat.Rows(i).Cells(5).Value = MouvementDB.sum_deces(idser, month_year)
                GdStat.Rows(i).Cells(6).Value = PersonnelDB1.nbrChiru(idser, month_year) + PersonnelDB1.nbrePara(idser, month_year) + PersonnelDB1.nbrMed(idser, month_year)
                GdStat.Rows(i).Cells(7).Value = ActivityDB.Sum_Actes(idser, month_year)
                GdStat.Rows(i).Cells(8).Value = ActivityDB.Sum_exam(idser, month_year)
                GdStat.Rows(i).Cells(9).Value = MouvementDB.sum_Sortie(idser, month_year)
                GdStat.Rows(i).Cells(10).Value = MouvementDB.sum_transfere(idser, month_year)
                GdStat.Rows(i).Cells(11).Value = (MouvementDB.nbrJourne(idser, month_year) * 100) / (ServiceDB.get_nbre_lits(idser) * 30)
                GdStat.Rows(i).Cells(12).Value = MouvementDB.nbrJourne(idser, month_year)
                GdStat.Rows(i).Cells(13).Value = (GdStat.Rows(i).Cells(3).Value * 100) / GdStat.Rows(i).Cells(1).Value
                GdStat.Rows(i).Cells(14).Value = (GdStat.Rows(i).Cells(5).Value * 100) / GdStat.Rows(i).Cells(2).Value
                GdStat.Rows(i).Cells(15).Value = (GdStat.Rows(i).Cells(2).Value) / GdStat.Rows(i).Cells(1).Value
                GdStat.Rows(i).Cells(16).Value = (GdStat.Rows(i).Cells(12).Value) / GdStat.Rows(i).Cells(2).Value
                i = i + 1

            End While
        End If



    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Me.Hide()
        Home.Show()
        Call fillCbDepartement2()

    End Sub


    Private Sub BtnExporter_Click(sender As Object, e As EventArgs) Handles BtnExporter.Click
        Dim sheetIndex As Integer
        Dim Ex As Object
        Dim Wb As Object
        Dim Ws As Object
        Ex = CreateObject("Excel.Application")
        Wb = Ex.workbooks.add


        Dim col, row As Integer

        Dim rawData(GdStat.Rows.Count, GdStat.Columns.Count - 1) As Object

        For col = 0 To GdStat.Columns.Count - 1
            rawData(0, col) = GdStat.Columns(col).HeaderText.ToUpper

        Next

        For col = 0 To GdStat.Columns.Count - 1
            For row = 0 To GdStat.Rows.Count - 1
                rawData(row + 1, col) = GdStat.Rows(row).Cells(col).Value

            Next
        Next

        Dim finalColLetter As String = String.Empty
        finalColLetter = ExcelColName(GdStat.Columns.Count)


        sheetIndex += 1
        Ws = Wb.Worksheets(sheetIndex)

        Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, GdStat.Rows.Count + 1)

        Ws.Range(excelRange, Type.Missing).Value2 = rawData
        Ws = Nothing


        Wb.SaveAs("c:\Users\Anonyme\Documents\Test10.xlsx", Type.Missing, Type.Missing,
     Type.Missing, Type.Missing, Type.Missing, Type.Missing,
     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
        Wb.Close(True, Type.Missing, Type.Missing)
        Wb = Nothing

        Ex.Quit()
        Ex = Nothing

        GC.Collect()
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)
    End Sub

    Public Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function
End Class