Imports IBM.Data.DB2

Public Class FrmMedications
    Private MedConn As Common.DbConnection

    Private Sub FrmMedications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            MedConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            MedConn.Open()

            DGVMed.ColumnCount = 7

            With DGVMed
                .Columns(0).Name = "Item ID"
                .Columns(1).Name = "Generic Name"
                .Columns(1).Width = 230

                .Columns(2).Name = "Pharma ID"

                .Columns(3).Name = "Therapeutic Category"
                .Columns(3).Width = 300

                .Columns(4).Name = "Dosage Strength"
                .Columns(4).Width = 230

                .Columns(5).Name = "Retail Price"
                .Columns(5).Width = 70

                .Columns(6).Name = "Wholesale Price"
                .Columns(6).Width = 70

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Refresh_Datagrid() 'change later to private
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from medicationsupply"
        cmdRetrieve = New DB2Command(SelectStr, MedConn)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVMed.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3), RdrMed.GetString(4), RdrMed.GetString(5), RdrMed.GetString(6)}
            DGVMed.Rows.Add(row)
        End While

        RdrMed.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        MedConn.Close()
        Me.Close()
    End Sub

    Private Sub TxtSearchM_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchM.TextChanged

        Try
            Dim StrSeach As String
            Dim CmdSeach As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim StrSearch2 As String
            Dim row As String()

            StrSearch2 = Me.TxtSearchM.Text + "%"
            StrSeach = "select * from medicationsupply where genericname like '" & StrSearch2 & "'"
            CmdSeach = New DB2Command(StrSeach, MedConn)
            RdrSearch = CmdSeach.ExecuteReader
            Me.DGVMed.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5), RdrSearch.GetString(6)}
                Me.DGVMed.Rows.Add(row)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAddMS_Click(sender As Object, e As EventArgs) Handles BtnAddMS.Click
        FrmAddMS.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If String.IsNullOrEmpty(Me.TxtItemID.Text) Then
                MsgBox("Please select an item from the table above first...")
            Else
                Dim DeleteStr As String
                Dim CmdDelete As DB2Command

                DeleteStr = "delete from medicationsupply where itemid = '" & Me.TxtItemID.Text & "'"

                If MsgBox("Are you sure you want to delete Record '" & Me.TxtItemID.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, MedConn)
                    CmdDelete.ExecuteNonQuery()
                    MsgBox("Record was successfully deleted...")
                    Call Refresh_Datagrid()
                    TxtItemID.Clear()
                Else
                    MsgBox("Delete Aborted")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVMED_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVMed.MouseUp
        Me.TxtItemID.Text = Me.DGVMed.CurrentRow.Cells(0).Value
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            FrmUpdateMS.TxtItemID1.Text = Me.DGVMed.CurrentRow.Cells(0).Value
            FrmUpdateMS.TxtPharmaID1.Text = Me.DGVMed.CurrentRow.Cells(1).Value
            FrmUpdateMS.TxtGenName1.Text = Me.DGVMed.CurrentRow.Cells(2).Value
            FrmUpdateMS.TxtTherCat1.Text = Me.DGVMed.CurrentRow.Cells(3).Value
            FrmUpdateMS.TxtDosage1.Text = Me.DGVMed.CurrentRow.Cells(4).Value
            FrmUpdateMS.TxtRetail1.Text = Me.DGVMed.CurrentRow.Cells(5).Value
            FrmUpdateMS.TxtWholePrice1.Text = Me.DGVMed.CurrentRow.Cells(6).Value

            FrmUpdateMS.Show()

            Call Refresh_Datagrid()
            'Call ClearEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
