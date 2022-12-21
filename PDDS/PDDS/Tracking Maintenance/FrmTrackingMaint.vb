Imports IBM.Data.DB2

Public Class FrmTrackingMaint
    Private TrackingConn As Common.DbConnection

    Private Sub FrmTrackingMaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackingConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        TrackingConn.Open()
        Try

            Dim RdrBox As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String

            SelectStr = "select * from employee where EmpJob='Delivery Guy'"
            cmdRetrieve = New DB2Command(SelectStr, TrackingConn)
            RdrBox = cmdRetrieve.ExecuteReader

            While RdrBox.Read
                Me.ComBoxEmployee.Items.Add(RdrBox.GetString(0))
            End While

            DatePickerETA.CustomFormat = "MM/dd/yy"
            DatePickerETA.Format = DateTimePickerFormat.Custom

            Me.ComBoxStatus.Items.Add("Processing")
            Me.ComBoxStatus.Items.Add("On The Way")
            Me.ComBoxStatus.Items.Add("Delivered")

            DGVtoprocess.ColumnCount = 5

            With DGVtoprocess
                .Columns(0).Name = "Tracking Num"
                .Columns(1).Name = "Employee ID"
                .Columns(2).Name = "ETA"
                .Columns(3).Name = "Status"
                .Columns(4).Name = "Store ID"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            DGVotw.ColumnCount = 5

            With DGVotw
                .Columns(0).Name = "Tracking Num"
                .Columns(1).Name = "Employee ID"
                .Columns(2).Name = "ETA"
                .Columns(3).Name = "Status"
                .Columns(4).Name = "Store ID"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            DGVdelivered.ColumnCount = 5

            With DGVdelivered
                .Columns(0).Name = "Tracking Num"
                .Columns(1).Name = "Employee ID"
                .Columns(2).Name = "ETA"
                .Columns(3).Name = "Status"
                .Columns(4).Name = "Store ID"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_DGVtoprocess()
            Call Refresh_DGVotw()
            Call Refresh_DGVdelivered()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Refresh_DGVtoprocess()
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from tracking where status= 'Processing'"
        cmdRetrieve = New DB2Command(SelectStr, TrackingConn)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVtoprocess.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3), RdrMed.GetString(4)}
            DGVtoprocess.Rows.Add(row)
        End While
        RdrMed.Close()

    End Sub

    Private Sub Refresh_DGVotw() 'change later to private
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from tracking where status= 'On The Way'"
        cmdRetrieve = New DB2Command(SelectStr, TrackingConn)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVotw.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3), RdrMed.GetString(4)}
            DGVotw.Rows.Add(row)
        End While
        RdrMed.Close()

    End Sub

    Private Sub Refresh_DGVdelivered() 'change later to private
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from tracking where status= 'Delivered'"
        cmdRetrieve = New DB2Command(SelectStr, TrackingConn)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVdelivered.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3), RdrMed.GetString(4)}
            DGVdelivered.Rows.Add(row)
        End While
        RdrMed.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command
            Dim VTrackingNum As String
            Dim VEmpID As String
            Dim VETA As String
            Dim VStatus As String

            DatePickerETA.CustomFormat = "MM/dd/yy"
            DatePickerETA.Format = DateTimePickerFormat.Custom

            VTrackingNum = Me.TxtTrackingNum.Text
            VEmpID = Me.ComBoxEmployee.Text
            VETA = Me.DatePickerETA.Text
            VStatus = Me.ComBoxStatus.Text

            StrUpdate = "update tracking set status='" & VStatus & "', eta='" & VETA & "', empid='" & VEmpID & "' where trackingnum='" & VTrackingNum & "'"
            CmdUpdate = New DB2Command(StrUpdate, TrackingConn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            Call ClearScreen()
            Call Refresh_DGVtoprocess()
            Call Refresh_DGVotw()
            Call Refresh_DGVdelivered()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearScreen()
        Me.TxtTrackingNum.Clear()
        Me.ComBoxEmployee.ResetText()
        Me.ComBoxStatus.ResetText()
        Me.DatePickerETA.Refresh()
    End Sub

    Private Sub DGVtoprocess_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVtoprocess.MouseUp
        Me.TxtTrackingNum.Text = Me.DGVtoprocess.CurrentRow.Cells(0).Value()
        Me.ComBoxStatus.Text = Me.DGVtoprocess.CurrentRow.Cells(3).Value()
    End Sub

    Private Sub DGVotw_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVotw.MouseUp
        Me.TxtTrackingNum.Text = Me.DGVotw.CurrentRow.Cells(0).Value()
        Me.ComBoxEmployee.Text = Me.DGVotw.CurrentRow.Cells(1).Value()
        'Me.DatePickerETA.Text = Me.DGVotw.CurrentRow.Cells(2).Value()
        Me.ComBoxStatus.Text = Me.DGVotw.CurrentRow.Cells(3).Value()
    End Sub

    Private Sub DGVdelivered_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVdelivered.MouseUp
        Me.TxtTrackingNum.Text = Me.DGVdelivered.CurrentRow.Cells(0).Value()
        'there is a possibility the order will be reprocessed again if there are some issues in the delivery
        Me.ComBoxEmployee.Text = Me.DGVdelivered.CurrentRow.Cells(1).Value()

        Me.ComBoxStatus.Text = Me.DGVdelivered.CurrentRow.Cells(3).Value()
    End Sub


End Class
