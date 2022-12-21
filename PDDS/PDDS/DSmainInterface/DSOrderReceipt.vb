Imports IBM.Data.DB2

Public Class FrmDSOrderReceipt
    Private ORConn As Common.DbConnection
    Private Sub Order_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ORConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        ORConn.Open()
        FrmDSmainInt.BtnUserDrop.Enabled = False
        Me.TxtStoreID.Text = FrmDSmainInt.TxtStoreID.Text
        Me.TxtProcessNum.Text = FrmDSmainInt.TxtProcessNum.Text
        Call Me.generatepurchaseid()
        Call Me.generatetrackingnum()

        DGVorderlist.ColumnCount = 7

        With DGVorderlist
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

            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        Call Refresh_ShopCart()

    End Sub

    Public Sub Refresh_ShopCart() 'change later to private
        Dim RdrMed2 As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()
        Dim vpn As String
        Dim overalltotal As Decimal

        vpn = Me.TxtProcessNum.Text
        SelectStr = "select * from store_medsup where processnum = '" & vpn & "'"
        cmdRetrieve = New DB2Command(SelectStr, ORConn)
        RdrMed2 = cmdRetrieve.ExecuteReader
        Me.DGVorderlist.Rows.Clear()

        While RdrMed2.Read
            row = New String() {RdrMed2.GetString(0), RdrMed2.GetString(1), RdrMed2.GetString(2), RdrMed2.GetString(3), RdrMed2.GetString(4), RdrMed2.GetString(5), RdrMed2.GetString(6)}
            DGVorderlist.Rows.Add(row)
            overalltotal += RdrMed2.GetString(6)
        End While
        Me.TxtTotal.Text = overalltotal
        RdrMed2.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim DelTracking As String
        Dim CmdDelete As DB2Command

        DelTracking = "delete from tracking where trackingnum= '" & Me.TxtTrackingNum.Text & "'"
        CmdDelete = New DB2Command(DelTracking, ORConn)
        CmdDelete.ExecuteNonQuery()
        FrmDSmainInt.BtnUserDrop.Enabled = True
        Me.Close()
    End Sub

    Private Sub generatepurchaseid()
        Try
            Dim entry As Integer = 1000
            Dim db2storeid As String = "select * from  orderreciept"
            Dim CmdLogin As DB2Command = New DB2Command(db2storeid, ORConn)
            Dim RdrLogin As DB2DataReader = CmdLogin.ExecuteReader

            While RdrLogin.Read()
                entry = entry + 1
            End While
            Dim last2yr As String = Date.Today.Year.ToString.Substring(Date.Today.Year.ToString.Length - 2, 2)
            Dim month As String = Date.Today.Month
            If month < 10 Then
                month = "0" & month
            End If
            Dim datenum As String = Date.Today.Day
            If datenum < 10 Then
                datenum = "0" & datenum
            End If
            Dim purchaseid As String = (month & datenum & last2yr & entry)
            'MsgBox(purchaseid.ToString)
            TxtPurchaseID.Text = purchaseid
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub generatetrackingnum()
        Try
            Dim entry As Integer = 1000000
            Dim db2storeid As String = "select * from  tracking"
            Dim CmdLogin As DB2Command = New DB2Command(db2storeid, ORConn)
            Dim RdrLogin As DB2DataReader = CmdLogin.ExecuteReader

            While RdrLogin.Read()
                entry = entry + 1
            End While

            Dim last2yr As String = Date.Today.Year.ToString.Substring(Date.Today.Year.ToString.Length - 2, 2)
            Dim tracking As String = (last2yr & "-" & entry)
            'MsgBox(tracking.ToString)
            TxtTrackingNum.Text = tracking
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnConfirmOrder_Click(sender As Object, e As EventArgs) Handles BtnConfirmOrder.Click
        Try

            Dim TrackingNum As String
            Dim EmpID As String
            Dim ETA As String
            Dim Status As String
            Dim StoreID As String

            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            TrackingNum = Me.TxtTrackingNum.Text
            EmpID = "-"
            ETA = "Processing"
            Status = "Processing"
            StoreID = TxtStoreID.Text

            InsertStr = "insert into tracking values('" & TrackingNum & "','" & EmpID & "','" & ETA & "','" & Status & "', '" & StoreID & "')"
            CmdInsert = New DB2Command(InsertStr, ORConn)
            CmdInsert.ExecuteNonQuery()

            Dim PurchaseID As String
            Dim ProcessNum As String
            Dim Total As String

            PurchaseID = Me.TxtPurchaseID.Text
            ProcessNum = Me.TxtProcessNum.Text
            TrackingNum = Me.TxtTrackingNum.Text
            Total = Me.TxtTotal.Text

            InsertStr = "insert into orderreciept values('" & PurchaseID & "','" & ProcessNum & "','" & TrackingNum & "','" & Total & "','" & StoreID & "')"
            CmdInsert = New DB2Command(InsertStr, ORConn)
            CmdInsert.ExecuteNonQuery()
            MsgBox("Thank you for ordering")
            MsgBox("Use your tracking number to track the details of your order in the tracking section of the program")
            If MsgBox("Do you want to print your receipt? ", MsgBoxStyle.YesNo, ) = vbYes Then
                FrmDSPrintReciept.Show()
            End If

            FrmDSmainInt.BtnUserDrop.Enabled = True
            'FrmDSmainInt.DGVShopCart.Rows.Clear()
            Call FrmDSmainInt.generateprocessnum()
            Call FrmDSmainInt.Refresh_ShopCart()
            Call FrmDSmainInt.startadding()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class