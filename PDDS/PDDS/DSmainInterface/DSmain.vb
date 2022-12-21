Imports IBM.Data.DB2

Public Class FrmDSmainInt
    Private MedConn2 As Common.DbConnection

    Private Sub customizeDesign()
        PanelSubMenu.Visible = False
    End Sub

    Private Sub hideSubMenu()
        If PanelSubMenu.Visible = True Then
            PanelSubMenu.Visible = False
        End If
    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            Call hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

  

    Private Sub FrmDSmainInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call customizeDesign()
            Call CScart()
            BtnUserDrop.Text = TxtStoreID.Text

            MedConn2 = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            MedConn2.Open()

            Call Me.generateprocessnum()

            DGVMed2.ColumnCount = 7

            With DGVMed2

                .Columns(0).Name = "Item ID"
                .Columns(1).Name = "Generic Name"
                .Columns(2).Name = "Pharma ID"
                .Columns(3).Name = "Therapeutic Category"
                .Columns(4).Name = "Dosage Strength"
                .Columns(5).Name = "Retail Price"
                .Columns(6).Name = "Wholesale Price"


                .Columns(0).Width() = 70
                .Columns(1).Width() = 200
                .Columns(3).Width() = 250
                .Columns(5).Width() = 70
                .Columns(6).Width() = 70

                .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            End With

            DGVShopCart.ColumnCount = 7

            With DGVShopCart
                .Columns(0).Name = "SMSEN"
                .Columns(0).Visible = False

                .Columns(1).Name = "ProcessNum"
                .Columns(1).Visible = False

                .Columns(2).Name = "Item ID"
                .Columns(2).Visible = False

                .Columns(3).Name = "Item Name"
                .Columns(3).Width = 250

                .Columns(4).Name = "Price"
                .Columns(5).Name = "Quantity"
                .Columns(6).Name = "Total"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure

            End With

            Call Refresh_Datagrid()
            Call Refresh_ShopCart()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Refresh_Datagrid()
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from medicationsupply"
        cmdRetrieve = New DB2Command(SelectStr, MedConn2)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVMed2.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3), RdrMed.GetString(4), RdrMed.GetString(5), RdrMed.GetString(6)}
            DGVMed2.Rows.Add(row)
        End While

        RdrMed.Close()

    End Sub

    Public Sub Refresh_ShopCart()
        Dim RdrMed2 As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()
        Dim vpn As String

        vpn = TxtProcessNum.Text
        SelectStr = "select * from store_medsup where processnum = '" & vpn & "'"
        cmdRetrieve = New DB2Command(SelectStr, MedConn2)
        RdrMed2 = cmdRetrieve.ExecuteReader
        Me.DGVShopCart.Rows.Clear()

        While RdrMed2.Read
            row = New String() {RdrMed2.GetString(0), RdrMed2.GetString(1), RdrMed2.GetString(2), RdrMed2.GetString(3), RdrMed2.GetString(4), RdrMed2.GetString(5), RdrMed2.GetString(6)}
            DGVShopCart.Rows.Add(row)
        End While

        RdrMed2.Close()

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Dim DelfromSMS As String
        Dim DelfromPO As String
        Dim CmdDelete As DB2Command

        If MsgBox("Are you sure you want to quit? Any unsubmitted items from your will be discared ", MsgBoxStyle.YesNo, ) = vbYes Then

            If hasBeenClicked = False Then

                ' MsgBox("The submit button was not clicked")

                DelfromSMS = "delete from store_medsup where processnum= '" & Me.TxtProcessNum.Text & "'"
                CmdDelete = New DB2Command(DelfromSMS, MedConn2)
                CmdDelete.ExecuteNonQuery()

                DelfromPO = "delete from processorder where processnum= '" & Me.TxtProcessNum.Text & "'"
                CmdDelete = New DB2Command(DelfromPO, MedConn2)
                CmdDelete.ExecuteNonQuery()


                'ElseIf hasBeenClicked = True Then
                'MsgBox("The submit button was clicked")
            End If

            MedConn2.Close()
            Me.Close()
            RegLoginWindow.Show()
        End If


    End Sub

    Private Sub DGVMed2_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVMed2.MouseUp
        Me.TxtItemID.Text = Me.DGVMed2.CurrentRow.Cells(0).Value
        Me.TxtItemName.Text = Me.DGVMed2.CurrentRow.Cells(1).Value
        Me.TxtWholePrice.Text = Me.DGVMed2.CurrentRow.Cells(6).Value
    End Sub

    Private Sub DGVShopCart_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVShopCart.MouseUp
        Me.TxtEntNum.Text = Me.DGVShopCart.CurrentRow.Cells(0).Value
        Me.TxtItemID.Text = Me.DGVShopCart.CurrentRow.Cells(2).Value
        Me.TxtItemName.Text = Me.DGVShopCart.CurrentRow.Cells(3).Value
        Me.TxtWholePrice.Text = Me.DGVShopCart.CurrentRow.Cells(4).Value
    End Sub

    Private Sub ClearEntry()

        Me.TxtEntNum.Clear()
        Me.TxtItemID.Clear()
        Me.TxtItemName.Clear()
        Me.TxtWholePrice.Clear()
        Me.TxtItemID.Focus()

    End Sub

    Private hasBeenClicked As Boolean
    Private Sub btn_Clicked() 'Handles BtnSubmit.Click
        ' If Not hasBeenClicked Then
        'MsgBox("It has not been clicked")
        'End If
        hasBeenClicked = False
    End Sub

    Private Sub BtnReciepts_Click(sender As Object, e As EventArgs) Handles BtnReciepts.Click
        BtnUserDrop.Enabled = False
        FrmDSOrders.Show()
        Call hideSubMenu()
    End Sub

    Private Sub BtnUserDrop_Click(sender As Object, e As EventArgs) Handles BtnUserDrop.Click
        Call showSubMenu(PanelSubMenu)
    End Sub

    Public Sub generateprocessnum()
        Try

            Dim entry As Integer = 1000
            Dim RdrProcNum As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim selectstr As String

            selectstr = "select processnum from  processorder"
            cmdRetrieve = New DB2Command(selectstr, MedConn2)
            RdrProcNum = cmdRetrieve.ExecuteReader

            While RdrProcNum.Read()
                entry = entry + 1
            End While

            Dim last2yr As String = Date.Today.Year.ToString.Substring(Date.Today.Year.ToString.Length - 2, 2)
            Dim currentdate As String = Date.Today.Month
            If currentdate < 10 Then
                currentdate = "0" & currentdate
            End If
            Dim processnum As String = (entry & "-" & currentdate & "-" & last2yr)
            'MsgBox(processnum.ToString)
            TxtProcessNum.Text = processnum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub BtnConfirm_Click_1(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Call Me.startadding()
    End Sub

    Public Sub startadding()
        Try

            Dim ProcessNum As String
            Dim StoreID As String

            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            ProcessNum = Me.TxtProcessNum.Text
            StoreID = Me.TxtStoreID.Text

            InsertStr = "insert into processorder values('" & ProcessNum & "','" & StoreID & "')"
            CmdInsert = New DB2Command(InsertStr, MedConn2)
            CmdInsert.ExecuteNonQuery()

            BtnConfirm.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        hasBeenClicked = True
        Me.BtnUserDrop.Enabled = False
        FrmDSOrderReceipt.Show()
    End Sub

    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            Dim i As Integer
            Dim EntryNum As String
            Dim ProcessNum As String
            Dim ItemID As String
            Dim ItemName As String
            Dim ItemPrice As String
            Dim Quantity As String
            Dim total As String
            Dim temp As String

            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            Dim td As String = String.Format("{0:mmddhmmss}", DateTime.Now)

            If String.IsNullOrEmpty(TxtItemID.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                i += 1
                EntryNum = td + i
                TxtEntNum.Text = EntryNum
                ProcessNum = Me.TxtProcessNum.Text
                ItemID = Me.TxtItemID.Text
                ItemName = Me.TxtItemName.Text
                ItemPrice = Me.TxtWholePrice.Text
                Quantity = Me.NumericUpDown1.Value
                temp = TxtWholePrice.Text
                total = temp * NumericUpDown1.Value

                InsertStr = "insert into store_medsup values('" & EntryNum & "','" & ProcessNum & "','" & ItemID & "','" & ItemName & "','" & ItemPrice & "','" & Quantity & "','" & total & "' )"
                CmdInsert = New DB2Command(InsertStr, MedConn2)
                CmdInsert.ExecuteNonQuery()
                MsgBox("Item added to shopping cart...")
                Call Me.ClearEntry()
                Call Me.Refresh_ShopCart()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnShopCart_Click(sender As Object, e As EventArgs) Handles BtnShopCart.Click
        Call showcart(PanelShopCart)
    End Sub

    Private Sub CScart()
        PanelShopCart.Visible = False
    End Sub

    Private Sub hideSubMenu2()
        If PanelShopCart.Visible = True Then
            PanelShopCart.Visible = False
        End If
    End Sub

    Private Sub showcart(subsub As Panel)
        If subsub.Visible = False Then
            Call hideSubMenu2()
            subsub.Visible = True
        Else
            subsub.Visible = False
        End If
    End Sub

    Private Sub TextSearchM_TextChanged(sender As Object, e As EventArgs) Handles TextSearchM.TextChanged
        Try
            Dim StrSeach As String
            Dim CmdSeach As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim StrSearch2 As String
            Dim row As String()

            StrSearch2 = Me.TextSearchM.Text + "%"
            StrSeach = "select * from medicationsupply where genericname like '" & StrSearch2 & "'"
            CmdSeach = New DB2Command(StrSeach, MedConn2)
            RdrSearch = CmdSeach.ExecuteReader
            Me.DGVMed2.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5), RdrSearch.GetString(6)}
                Me.DGVMed2.Rows.Add(row)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles BtnTracking.Click
        BtnUserDrop.Enabled = False
        FrmDSTracking.Show()
        Call hideSubMenu()
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        BtnUserDrop.Enabled = False
        FrmDSinformation.Show()
        Call hideSubMenu()
    End Sub

    Private Sub BtnRemove_Click_1(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Try

            Dim DeleteStr As String
            Dim CmdDelete As DB2Command

            If String.IsNullOrEmpty(TxtItemID.Text) Then
                MsgBox("Please select an item from the table above first...")
            Else
                DeleteStr = "delete from store_medsup where storemsentrynum = '" & Me.TxtEntNum.Text & "'"

                If MsgBox("Are you sure you want to remove '" & Me.TxtItemName.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, MedConn2)
                    CmdDelete.ExecuteNonQuery()

                    MsgBox("Remove Successful...")
                Else
                    MsgBox("Remove Aborted")
                End If
                Call Refresh_ShopCart()
                Call ClearEntry()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles BtnSubmit.MouseEnter
        Me.BtnUserDrop.Enabled = False
        Call hideSubMenu()
    End Sub

    Private Sub BtnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles BtnSubmit.MouseLeave
        Me.BtnUserDrop.Enabled = True
    End Sub
End Class
