Imports IBM.Data.DB2

Public Class FrmEmployee
    Private EmpConn As Common.DbConnection
    Dim TxtEmpID As Object

    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            EmpConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            EmpConn.Open()

            DGVEmp.ColumnCount = 5

            With DGVEmp
                .Columns(0).Name = "Employee ID"
                .Columns(1).Name = "Employee Name"
                .Columns(2).Name = "Employee Job"
                .Columns(3).Name = "Employee Contact #"
                .Columns(4).Name = "Employee Password"

                .Columns(0).Width = 100
                .Columns(1).Width = 130
                .Columns(2).Width = 120
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                'If samp = ent Then
                '.Columns(4).Visible = True
                'End If

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Refresh_Datagrid()
        Dim RdrEmp As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from employee"
        cmdRetrieve = New DB2Command(SelectStr, EmpConn)
        RdrEmp = cmdRetrieve.ExecuteReader
        Me.DGVEmp.Rows.Clear()

        While RdrEmp.Read
            row = New String() {RdrEmp.GetString(0), RdrEmp.GetString(1), RdrEmp.GetString(2), RdrEmp.GetString(3), RdrEmp.GetString(4)}
            DGVEmp.Rows.Add(row)
        End While

        RdrEmp.Close()

    End Sub

    Private Sub AddEmp_Click(sender As Object, e As EventArgs) Handles AddEmp.Click
        FrmAddEmployee.Show()

    End Sub

    Private Sub DelEmp_Click(sender As Object, e As EventArgs) Handles DelEmp.Click
        Try

            Dim DeleteStr As String
            Dim CmdDelete As DB2Command

            DeleteStr = "delete from employee where empid = '" & Me.TxtEmpID2.Text & "'"

            If MsgBox("Are you sure you want to Delete Employee Record '" & Me.TxtEmpID2.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                CmdDelete = New DB2Command(DeleteStr, EmpConn)
                CmdDelete.ExecuteNonQuery()
                MsgBox("Record was successfully deleted...")
                Call Refresh_Datagrid()
                TxtEmpID2.Clear()
            Else
                MsgBox("Delete Aborted")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVEmp_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVEmp.MouseUp
        Me.TxtEmpID2.Text = Me.DGVEmp.CurrentRow.Cells(0).Value()
    End Sub

    Private Sub UpdtEmp_Click(sender As Object, e As EventArgs) Handles UpdtEmp.Click
        Try

            FrmUpdEmp.TxtEmpID.Text = Me.DGVEmp.CurrentRow.Cells(0).Value
            FrmUpdEmp.TxtEmpName.Text = Me.DGVEmp.CurrentRow.Cells(1).Value
            FrmUpdEmp.TxtEmpJob.Text = Me.DGVEmp.CurrentRow.Cells(2).Value
            FrmUpdEmp.TxtEmpContNum.Text = Me.DGVEmp.CurrentRow.Cells(3).Value
            FrmUpdEmp.TxtEmpPass.Text = Me.DGVEmp.CurrentRow.Cells(4).Value

            FrmUpdEmp.Show()

            Call Refresh_Datagrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
