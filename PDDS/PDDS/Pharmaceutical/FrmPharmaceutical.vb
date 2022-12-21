Imports IBM.Data.DB2

Public Class FrmPharmaceutical
    Private PharmaConn As Common.DbConnection

    Private Sub FrmMedications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            PharmaConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            PharmaConn.Open()

            DGVPharma.ColumnCount = 4

            With DGVPharma
                .Columns(0).Name = "Pharma ID"
                .Columns(1).Name = "Pharma Name"
                .Columns(2).Name = "Pharma Email"
                .Columns(3).Name = "Pharma Contact #"

                .Columns(0).Width = 100
                .Columns(1).Width = 180
                .Columns(2).Width = 195
                .Columns(3).Width = 135
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Refresh_Datagrid() 'change later to private
        Dim RdrPharma As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from pharmaceutical"
        cmdRetrieve = New DB2Command(SelectStr, PharmaConn)
        RdrPharma = cmdRetrieve.ExecuteReader
        Me.DGVPharma.Rows.Clear()

        While RdrPharma.Read
            row = New String() {RdrPharma.GetString(0), RdrPharma.GetString(1), RdrPharma.GetString(2), RdrPharma.GetString(3)}
            DGVPharma.Rows.Add(row)
        End While

        RdrPharma.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PharmaConn.Close()
        Me.Close()
    End Sub

    Private Sub TxtSearchM_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchP.TextChanged

        Try
            Dim StrSeach As String
            Dim CmdSeach As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim StrSearch2 As String
            Dim row As String()

            StrSearch2 = Me.TxtSearchP.Text + "%"
            StrSeach = "select * from pharmaceutical where pharmaname like '" & StrSearch2 & "'"
            CmdSeach = New DB2Command(StrSeach, PharmaConn)
            RdrSearch = CmdSeach.ExecuteReader
            Me.DGVPharma.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DGVPharma.Rows.Add(row)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAddMS_Click(sender As Object, e As EventArgs) Handles BtnAddPharma.Click
        FrmAddP.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If String.IsNullOrEmpty(Me.TxtPharmaID.Text) Then
                MsgBox("Please select an item from the table above first...")
            Else
                Dim DeleteStr As String
                Dim CmdDelete As DB2Command

                DeleteStr = "delete from pharmaceutical where PHARMAid = '" & Me.TxtPharmaID.Text & "'"

                If MsgBox("Are you sure you want to delete Record '" & Me.TxtPharmaID.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, PharmaConn)
                    CmdDelete.ExecuteNonQuery()
                    MsgBox("Record was successfully deleted...")
                    Call Refresh_Datagrid()
                    TxtPharmaID.Clear()
                Else
                    MsgBox("Delete Aborted")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVMED_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVPharma.MouseUp
        Me.TxtPharmaID.Text = Me.DGVPharma.CurrentRow.Cells(0).Value
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            FrmUpdateP.TxtPharmaID.Text = Me.DGVPharma.CurrentRow.Cells(0).Value
            FrmUpdateP.TxtPharmaName.Text = Me.DGVPharma.CurrentRow.Cells(1).Value
            FrmUpdateP.TxtPharmaEmail.Text = Me.DGVPharma.CurrentRow.Cells(2).Value
            FrmUpdateP.TxtPharmaContNum.Text = Me.DGVPharma.CurrentRow.Cells(3).Value

            FrmUpdateP.Show()

            Call Refresh_Datagrid()
            'Call ClearEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
