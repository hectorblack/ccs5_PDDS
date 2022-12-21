Imports IBM.Data.DB2

Public Class FrmAddEmployee
    Private EmpConn As Common.DbConnection

    Private Sub EmpSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        EmpConn.Open()
    End Sub

    Private Sub ClearEntry()

        Me.TxtEmpID.Clear()
        Me.TxtEmpName.Clear()
        Me.TxtEmpJob.Clear()
        Me.TxtEmpContNum.Clear()
        Me.TxtEmpPass.Clear()

        Me.TxtEmpID.Focus()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Call Me.ClearEntry()
    End Sub

    Private Sub SaveBttn_Click(sender As Object, e As EventArgs) Handles SaveBttn.Click
        Try
            Dim InsertStr As String
            Dim EmpID As String
            Dim EmpName As String
            Dim EmpJob As String
            Dim EmpContNum As String
            Dim EmpPass As String
            Dim CmdInsert As DB2Command

            EmpID = Me.TxtEmpID.Text()
            EmpName = Me.TxtEmpName.Text()
            EmpJob = Me.TxtEmpJob.Text()
            EmpContNum = Me.TxtEmpContNum.Text()
            EmpPass = Me.TxtEmpPass.Text()


            InsertStr = "insert into employee values('" & EmpID & "','" & EmpName & "','" & EmpJob & "','" & EmpContNum & "','" & EmpPass & "' )"
            CmdInsert = New DB2Command(InsertStr, EmpConn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")
            Call FrmEmployee.Refresh_Datagrid()
            Call Me.ClearEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class