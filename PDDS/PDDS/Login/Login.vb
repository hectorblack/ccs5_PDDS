Imports IBM.Data.DB2
Public Class RegLoginWindow
    Private LoginConn As Common.DbConnection
    Private null As Integer

   

    Private Sub RegisterTextBox_Validating(sender As Object, e As EventArgs)
        Try
            'If fields are empty
            If RegNameTextBox.Text = "" Or regpasstxt.Text = "" Or locationtxt.Text = "" Or ownernametxt.Text = "" Or contnumtxt.Text = "" Then
                BtnRegister.Enabled = False
            Else
                BtnRegister.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.PanelSignIN.Show()
        Me.PanelSignUP.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.PanelSignUP.Show()
        Me.PanelSignIN.Hide()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.BtnRegister.Cursor = Cursors.Default
        Try
            If String.IsNullOrEmpty(ownernametxt.Text) Or String.IsNullOrEmpty(regpasstxt.Text) Or String.IsNullOrEmpty(RegNameTextBox.Text) Or String.IsNullOrEmpty(locationtxt.Text) Or String.IsNullOrEmpty(contnumtxt.Text) Then
                MsgBox("Please fill up all the fields")
            End If

            If (InStr(locationtxt.Text, ",")) = 1 Or (InStr(RegNameTextBox.Text, "'")) = 1 Then
                MsgBox("Single Quotes(') and Commas (,) are not allowed")
            Else
                Dim storeentry As Integer = 1001
                Dim last2cont As Integer = Me.contnumtxt.Text.Substring(Me.contnumtxt.Text.Length - 2, 2)
                Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)
                Dim db2storeid As String = "select * from  drugstore"
                Dim CmdLogin As DB2Command = New DB2Command(db2storeid, LoginConn)
                Dim RdrLogin As DB2DataReader = CmdLogin.ExecuteReader

                While RdrLogin.Read()
                    storeentry = storeentry + 1
                End While

                Dim storeid As String = (last2yr & "-" & storeentry & "-" & last2cont)
                db2storeid = "select * from  drugstore  where storeid='" & storeid & "' "
                CmdLogin = New DB2Command(db2storeid, LoginConn)

                Dim register As String = "insert into drugstore (storeid,storename,location,ownername,contactnum,storepassword) values ('" & storeid &
                                                    "','" & Me.RegNameTextBox.Text & "','" & Me.locationtxt.Text & "','" & Me.ownernametxt.Text &
                                                    "','" & Me.contnumtxt.Text & "','" & Me.regpasstxt.Text & "')"
                CmdLogin = New DB2Command(register, LoginConn)
                If (CmdLogin.ExecuteNonQuery().Equals(1)) Then
                    MsgBox("Information stored in database")
                    MsgBox("Your Store ID is '" & storeid & "' Please note this down as this is what you will use to login")
                    Call clearegister()
                    Me.PanelSignIN.Show()
                    Me.PanelSignUP.Hide()
                    'JAY'S CODE HERE---------------

                Else
                    MsgBox("Not stored in database")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clearegister()
        ownernametxt.Clear()
        RegNameTextBox.Clear()
        locationtxt.Clear()
        contnumtxt.Clear()
        regpasstxt.Clear()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        
        Dim StrLogin As String
        Dim CmdLogin As DB2Command
        Dim RdrLogin As DB2DataReader
        Dim VUserName As String
        Dim VUserPass As String

        Try
            If Me.ComboBox1.Text = "Employee" Then
                StrLogin = "select * from  employee where empid='" & Me.LogUserNameTextBox.Text & "' " _
                                        & "And emppass ='" & Me.LogPasswordTextBox.Text & "'"
                CmdLogin = New DB2Command(StrLogin, LoginConn)
                RdrLogin = CmdLogin.ExecuteReader
                RdrLogin.Read()
                If RdrLogin.HasRows Then
                    VUserName = RdrLogin.GetString(0)
                    VUserPass = RdrLogin.GetString(4)
                    'MsgBox(VUserName.ToString & VUserPass.ToString)

                    FrmEAmainInterface.Show()
                    Me.Hide()

                Else
                    MsgBox("Username and/or password are invalid...")
                End If
            ElseIf Me.ComboBox1.Text = "Drugstore" Then
                StrLogin = "select * from  drugstore  where storeid='" & Me.LogUserNameTextBox.Text & "' " _
                                        & "And storepassword ='" & Me.LogPasswordTextBox.Text & "'"
                CmdLogin = New DB2Command(StrLogin, LoginConn)
                RdrLogin = CmdLogin.ExecuteReader
                RdrLogin.Read()
                If RdrLogin.HasRows Then
                    VUserName = RdrLogin.GetString(0)
                    VUserPass = RdrLogin.GetString(5)
                    'MsgBox(VUserName.ToString & VUserPass.ToString & " Storename: " & RdrLogin.GetString(1))

                    FrmDSmainInt.TxtStoreID.Text = VUserName
                    FrmDSmainInt.Show()
                    Me.Hide()
                    'JAY'S CODE HERE---------------

                Else
                    MsgBox("Username and/or password are invalid...")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RegLoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin;")
        LoginConn.Open()
    End Sub
End Class
