Imports IBM.Data.DB2

Public Class FrmDSOrders
    Private DSOconn As Common.DbConnection

    Private Sub DSOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DSOconn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            DSOconn.Open()

            DGVOI.ColumnCount = 7
            DGVOrders.ColumnCount = 4

            With DGVOrders
                .Columns(0).Name = "Purchase ID"
                .Columns(1).Name = "ProcessNum"
                .Columns(2).Name = "Tracking Num"
                .Columns(3).Name = "Total"
                'wala diri ang storeid gi load

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            With DGVOI
                .Columns(0).Name = "storemsid"
                .Columns(0).Visible = False
                .Columns(1).Name = "Process num"
                .Columns(2).Name = "Item ID"
                .Columns(3).Name = "Item Name"
                .Columns(4).Name = "Price"
                .Columns(5).Name = "Quantity"
                .Columns(6).Name = "Total"
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_DGVOrders()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Refresh_DGVOrders() 'change later to private
        Dim RdrProcOrd As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from orderreciept where storeid= '" & FrmDSmainInt.TxtStoreID.Text & "'"
        cmdRetrieve = New DB2Command(SelectStr, DSOconn)
        RdrProcOrd = cmdRetrieve.ExecuteReader
        Me.DGVOrders.Rows.Clear()

        While RdrProcOrd.Read
            row = New String() {RdrProcOrd.GetString(0), RdrProcOrd.GetString(1), RdrProcOrd.GetString(2), RdrProcOrd.GetString(3)}
            DGVOrders.Rows.Add(row)
        End While

        RdrProcOrd.Close()

    End Sub

    Public Sub Refresh_DGVOI() 'change later to private
        Dim RdrProcOrd As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from store_medsup where processnum= '" & Me.TxtProcessNum.Text & "'"
        cmdRetrieve = New DB2Command(SelectStr, DSOconn)
        RdrProcOrd = cmdRetrieve.ExecuteReader
        Me.DGVOI.Rows.Clear()

        While RdrProcOrd.Read
            row = New String() {RdrProcOrd.GetString(0), RdrProcOrd.GetString(1), RdrProcOrd.GetString(2), RdrProcOrd.GetString(3), RdrProcOrd.GetString(4), RdrProcOrd.GetString(5), RdrProcOrd.GetString(6)}
            DGVOI.Rows.Add(row)
        End While

        RdrProcOrd.Close()

    End Sub

    Private Sub DGVOrders_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVOrders.MouseUp
        Me.TxtProcessNum.Text = Me.DGVOrders.CurrentRow.Cells(1).Value
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmDSmainInt.BtnUserDrop.Enabled = True
        Me.Close()
    End Sub

    Private Sub BtnShowDetails_Click(sender As Object, e As EventArgs) Handles BtnShowDetails.Click
        DGVOI.Refresh()
        Call Refresh_DGVOI()
    End Sub
End Class