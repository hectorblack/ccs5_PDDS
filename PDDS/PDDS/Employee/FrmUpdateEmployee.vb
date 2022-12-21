Imports IBM.Data.DB2

Public Class FrmUpdEmp
    Private EmpConn As Common.DbConnection

    Private Sub FrmUpdEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        EmpConn.Open()
    End Sub

    Private Sub UpdBttn_Click(sender As Object, e As EventArgs) Handles UpdBttn.Click
        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command
            Dim VEmpID As String
            Dim VEmpName As String
            Dim VEmpJob As String
            Dim VEmpContNum As String
            Dim VEmpPass As String

            VEmpID = Me.TxtEmpID.Text()
            VEmpName = Me.TxtEmpName.Text
            VEmpJob = Me.TxtEmpJob.Text
            VEmpContNum = Me.TxtEmpContNum.Text
            VEmpPass = Me.TxtEmpPass.Text

            StrUpdate = "update employee set empid = '" & VEmpID & "', empname = '" & VEmpName & "', empjob = '" & VEmpJob & "', empcontnum = '" & VEmpContNum & "', emppass = '" & VEmpPass & "' where empid='" & VEmpID & "'"
            CmdUpdate = New DB2Command(StrUpdate, EmpConn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CnclBttn_Click(sender As Object, e As EventArgs) Handles CnclBttn.Click
        Call FrmEmployee.Refresh_Datagrid()
        Me.Close()
    End Sub


End Class