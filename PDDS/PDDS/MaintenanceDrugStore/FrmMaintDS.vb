Imports IBM.Data.DB2

Public Class FrmMaintDS
    Private DrgConn As Common.DbConnection
    Dim TxtDrg As Object

    Private Sub DrgStrFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DrgConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            DrgConn.Open()

            DGVDrg.ColumnCount = 6

            With DGVDrg
                .Columns(0).Name = "Drug Store ID"
                .Columns(1).Name = "Drug Store Name"
                .Columns(2).Name = "Drug Store Location"
                .Columns(3).Name = "Drug Store Owner"
                .Columns(4).Name = "Drug Store Contact Number"
                .Columns(5).Name = "Drug Store Password"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Refresh_Datagrid()
        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from drugstore"
        cmdRetrieve = New DB2Command(SelectStr, DrgConn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.DGVDrg.Rows.Clear()

        While RdrDrg.Read
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4), RdrDrg.GetString(5)}
            DGVDrg.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub


    Private Sub DelBttn_Click(sender As Object, e As EventArgs) Handles DelBttn.Click
        Try
            If String.IsNullOrEmpty(Me.TxtDrgStrID.Text) Then
                MsgBox("Please select an item from the table above first...")
            Else

                Dim DeleteStr As String
                Dim CmdDelete As DB2Command

                DeleteStr = "delete from drugstore where storeID= '" & Me.TxtDrgStrID.Text & "'"

                If MsgBox("Are you sure you want to Delete Drug Store Record '" & Me.TxtDrgStrID.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, DrgConn)
                    CmdDelete.ExecuteNonQuery()
                    MsgBox("Record was successfully deleted...")
                    Call Refresh_Datagrid()
                    TxtDrgStrID.Clear()
                Else
                    MsgBox("Delete Aborted")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVEmp_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVDrg.MouseUp
        Me.TxtDrgStrID.Text = Me.DGVDrg.CurrentRow.Cells(0).Value()
    End Sub

    Private Sub UpdInfBttn_Click(sender As Object, e As EventArgs) Handles UpdInfBttn.Click
        Try

            FrmUpdateDS.DrgStrID.Text = Me.DGVDrg.CurrentRow.Cells(0).Value
            FrmUpdateDS.DrgStrName.Text = Me.DGVDrg.CurrentRow.Cells(1).Value
            FrmUpdateDS.DrgStrLoc.Text = Me.DGVDrg.CurrentRow.Cells(2).Value
            FrmUpdateDS.DrgStrOwn.Text = Me.DGVDrg.CurrentRow.Cells(3).Value
            FrmUpdateDS.DrgStrCont.Text = Me.DGVDrg.CurrentRow.Cells(4).Value
            FrmUpdateDS.DrgStrPass.Text = Me.DGVDrg.CurrentRow.Cells(5).Value

            FrmUpdateDS.Show()

            Call Refresh_Datagrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
    End Sub
End Class
