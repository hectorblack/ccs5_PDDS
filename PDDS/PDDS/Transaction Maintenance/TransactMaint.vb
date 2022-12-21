Imports IBM.Data.DB2

Public Class FrmTransactMaint
    Private DSOconn As Common.DbConnection

    Private Sub TransactMaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DSOconn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            DSOconn.Open()

            DGVAllOrders.ColumnCount = 5
            DGVselectedorder.ColumnCount = 7

            With DGVAllOrders
                .Columns(0).Name = "Purchase ID"
                .Columns(1).Name = "Process Num"
                .Columns(2).Name = "Tracking Num"
                .Columns(3).Name = "Total"
                .Columns(4).Name = "Store ID"
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            End With

            With DGVselectedorder
                .Columns(0).Name = "Entry num"

                .Columns(1).Name = "Process Num"
                .Columns(1).Visible = False

                .Columns(2).Name = "Item ID"
                .Columns(3).Name = "Item Name"

                .Columns(4).Name = "Price"
                .Columns(4).Visible = False

                .Columns(5).Name = "Quantity"
                .Columns(6).Name = "Total"
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_Datagrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Refresh_Datagrid() 'change later to private
        Dim RdrPharma As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from orderreciept"
        cmdRetrieve = New DB2Command(SelectStr, DSOconn)
        RdrPharma = cmdRetrieve.ExecuteReader
        Me.DGVAllOrders.Rows.Clear()

        While RdrPharma.Read
            row = New String() {RdrPharma.GetString(0), RdrPharma.GetString(1), RdrPharma.GetString(2), RdrPharma.GetString(3), RdrPharma.GetString(4)}
            DGVAllOrders.Rows.Add(row)
        End While

        RdrPharma.Close()

    End Sub

    Public Sub Refresh_Datagrid2() 'change later to private
        Dim RdrPharma As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from store_medsup where processnum = '" & Me.TxtProcessNum.Text & "'"
        cmdRetrieve = New DB2Command(SelectStr, DSOconn)
        RdrPharma = cmdRetrieve.ExecuteReader
        Me.DGVselectedorder.Rows.Clear()

        While RdrPharma.Read
            row = New String() {RdrPharma.GetString(0), RdrPharma.GetString(1), RdrPharma.GetString(2), RdrPharma.GetString(3), RdrPharma.GetString(4), RdrPharma.GetString(5), RdrPharma.GetString(6)}
            DGVselectedorder.Rows.Add(row)
        End While

        RdrPharma.Close()

    End Sub

    Private Sub DGVALLOrders_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVAllOrders.MouseUp
        Me.TxtProcessNum.Text = Me.DGVAllOrders.CurrentRow.Cells(1).Value
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        DSOconn.Close()
        Me.Close()
    End Sub

    Private Sub BtnShowDetails_Click(sender As Object, e As EventArgs) Handles BtnShowDetails.Click
        DGVselectedorder.Refresh()
        Call Refresh_Datagrid2()
    End Sub


End Class