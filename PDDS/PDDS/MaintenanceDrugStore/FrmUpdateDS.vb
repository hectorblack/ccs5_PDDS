Imports IBM.Data.DB2

Public Class FrmUpdateDS
    Private DrgConn As Common.DbConnection

    Private Sub UpdDrgStrFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrgConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        DrgConn.Open()

    End Sub

    Private Sub UpdBttn_Click(sender As Object, e As EventArgs) Handles UpdBttn.Click
        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command
            Dim VDrgStrID As String
            Dim VDrgStrName As String
            Dim VDrgStrLoc As String
            Dim VDrgStrOwn As String
            Dim VDrgStrCont As String
            Dim VDrgStrPass As String

            VDrgStrID = Me.DrgStrID.Text()
            VDrgStrName = Me.DrgStrName.Text
            VDrgStrLoc = Me.DrgStrLoc.Text
            VDrgStrOwn = Me.DrgStrOwn.Text
            VDrgStrCont = Me.DrgStrCont.Text
            VDrgStrPass = Me.DrgStrPass.Text

            StrUpdate = "update drugstore set storeid = '" & VDrgStrID & "', storename = '" & VDrgStrName & "', location = '" & VDrgStrLoc & "', ownername = '" & VDrgStrOwn & "', contactnum = '" & VDrgStrCont & "', storepassword = '" & VDrgStrPass & "' where storeid='" & VDrgStrID & "'"
            CmdUpdate = New DB2Command(StrUpdate, DrgConn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            Call FrmMaintDS.Refresh_Datagrid()

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CnclBttn_Click(sender As Object, e As EventArgs) Handles CnclBttn.Click
        Call FrmMaintDS.Refresh_Datagrid()
        Me.Close()
    End Sub

    Public Sub ClearEntry()

        Me.DrgStrID.Clear()
        Me.DrgStrName.Clear()
        Me.DrgStrLoc().Clear()
        Me.DrgStrOwn.Clear()
        Me.DrgStrCont.Clear()
        Me.DrgStrPass.Clear()

        Me.DrgStrID.Focus()

    End Sub

End Class