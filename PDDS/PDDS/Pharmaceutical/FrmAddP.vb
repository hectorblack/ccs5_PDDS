Imports IBM.Data.DB2


Public Class FrmAddP
    Private MedConn As Common.DbConnection

    Private Sub AddP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        MedConn.Open()
    End Sub

    Private Sub ClearEntry()

        Me.TxtPharmaID.Clear()
        Me.TxtPharmaName.Clear()
        Me.TxtPharmaEmail.Clear()
        Me.TxtPharmaContNum.Clear()

        Me.TxtPharmaID.Focus()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim PharmaID As String
            Dim PharmaName As String
            Dim PharmaEmail As String
            Dim PharmaContNum As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            PharmaID = Me.TxtPharmaID.Text
            PharmaName = Me.TxtPharmaName.Text
            PharmaEmail = Me.TxtPharmaEmail.Text
            PharmaContNum = Me.TxtPharmaContNum.Text

            InsertStr = "insert into pharmaceutical values('" & PharmaID & "','" & PharmaName & "','" & PharmaEmail & "','" & PharmaContNum & "')"
            CmdInsert = New DB2Command(InsertStr, MedConn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")
            Call FrmPharmaceutical.Refresh_Datagrid()
            Call Me.ClearEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Call Me.ClearEntry()
    End Sub
End Class