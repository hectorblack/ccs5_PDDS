Imports IBM.Data.DB2

Public Class FrmUpdateP
    Private PharmaConn As Common.DbConnection

    Private Sub FrmUpdateP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PharmaConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        PharmaConn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Dim VPharmaID As String
            Dim VPharmaName As String
            Dim VPharmaEmail As String
            Dim VPharmaContNum As String


            VPharmaID = Me.TxtPharmaID.Text
            VPharmaName = Me.TxtPharmaName.Text
            VPharmaEmail = Me.TxtPharmaEmail.Text
            VPharmaContNum = Me.TxtPharmaContNum.Text

            StrUpdate = "update pharmaceutical set pharmaname = '" & VPharmaName & "', pharmaemail = '" & VPharmaEmail & "', pharmacontnum = '" & VPharmaContNum & "' where pharmaid='" & VPharmaID & "'"
            CmdUpdate = New DB2Command(StrUpdate, PharmaConn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Call FrmPharmaceutical.Refresh_Datagrid()
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.TxtPharmaID.Text = FrmPharmaceutical.DGVPharma.CurrentRow.Cells(0).Value
        Me.TxtPharmaName.Text = FrmPharmaceutical.DGVPharma.CurrentRow.Cells(1).Value
        Me.TxtPharmaEmail.Text = FrmPharmaceutical.DGVPharma.CurrentRow.Cells(2).Value
        Me.TxtPharmaContNum.Text = FrmPharmaceutical.DGVPharma.CurrentRow.Cells(3).Value
    End Sub

End Class