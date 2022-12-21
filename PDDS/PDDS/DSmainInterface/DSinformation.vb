Imports IBM.Data.DB2
Public Class FrmDSinformation
    Private DSConn As Common.DbConnection

    Private Sub DSinformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DSConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        DSConn.Open()
        Me.TxtStoreID.Text = FrmDSmainInt.TxtStoreID.Text

        Dim RdrEmp As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String

        SelectStr = "select * from drugstore where storeid='" & TxtStoreID.Text & "'"
        cmdRetrieve = New DB2Command(SelectStr, DSConn)
        RdrEmp = cmdRetrieve.ExecuteReader

        While RdrEmp.Read
            Me.TxtStoreName.Text = RdrEmp.GetString(1)
            Me.TxtStoreLoc.Text = RdrEmp.GetString(2)
            Me.TxtOwnerName.Text = RdrEmp.GetString(3)
            Me.TxtContNum.Text = RdrEmp.GetString(4)
            Me.TxtPassbefore.Text = RdrEmp.GetString(5)
        End While

        RdrEmp.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try

            Dim VStoreID As String
            Dim VOwnerName As String
            Dim VStoreName As String
            Dim VStoreLoc As String
            Dim VContNum As String
            Dim VPass As String
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Call checkpass()

            If TxtPassError.Visible = True Then
                MsgBox("Cannot proceed if there are errros")
            Else
                VStoreID = Me.TxtStoreID.Text()
                VOwnerName = Me.TxtOwnerName.Text
                VStoreName = Me.TxtStoreName.Text
                VStoreLoc = Me.TxtStoreLoc.Text
                VContNum = Me.TxtContNum.Text
                VPass = Me.TxtPassbefore.Text

                StrUpdate = "update drugstore set storename = '" & VStoreName & "', location = '" & VStoreLoc & "', ownername = '" & VOwnerName & "', contactnum = '" & VContNum & "', storepassword = '" & VPass & "' where StoreID='" & VStoreID & "'"
                CmdUpdate = New DB2Command(StrUpdate, DSConn)
                CmdUpdate.ExecuteNonQuery()
                MsgBox("Record was updated successfully...")
                Me.Close()
                FrmDSmainInt.BtnUserDrop.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmDSmainInt.BtnUserDrop.Enabled = True
        Me.Close()
    End Sub

    Private Sub TxtPassbefore_GotFocus(sender As Object, e As EventArgs) Handles TxtPassbefore.GotFocus
        LConfirm.Visible = True
        Txtpass.Visible = True
    End Sub


    Private Sub checkpass()
        Dim p1 As String = TxtPassbefore.Text
        Dim p2 As String = Txtpass.Text

        If LConfirm.Visible = True Then
            If String.Compare(p1, p2) = 1 Then
                TxtPassError.Visible = True
            Else
                TxtPassError.Visible = False
            End If
        End If
        
    End Sub


End Class