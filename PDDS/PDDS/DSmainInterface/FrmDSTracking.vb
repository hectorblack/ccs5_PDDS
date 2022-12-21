Imports IBM.Data.DB2
Public Class FrmDSTracking
    Private TrackingConn As Common.DbConnection
    Private Sub FrmDSTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            TrackingConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
            TrackingConn.Open()

            DGVDStracking.ColumnCount = 4

            With DGVDStracking
                .Columns(0).Name = "Tracking Num"
                .Columns(1).Name = "Employee ID"
                .Columns(2).Name = "ETA"
                .Columns(3).Name = "Status"
                'wala gi include ang storeid

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_Datagrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Refresh_Datagrid() 'change later to private
        Dim RdrMed As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from tracking where storeid= '" & FrmDSmainInt.TxtStoreID.Text & "'"
        cmdRetrieve = New DB2Command(SelectStr, TrackingConn)
        RdrMed = cmdRetrieve.ExecuteReader
        Me.DGVDStracking.Rows.Clear()

        While RdrMed.Read
            row = New String() {RdrMed.GetString(0), RdrMed.GetString(1), RdrMed.GetString(2), RdrMed.GetString(3)}
            DGVDStracking.Rows.Add(row)
        End While

        RdrMed.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmDSmainInt.BtnUserDrop.Enabled = True
        Me.Close()
    End Sub
End Class