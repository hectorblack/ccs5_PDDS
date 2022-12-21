Imports IBM.Data.DB2
Public Class FrmEAmainInterface
    Private EAconn As Common.DbConnection
    Private Sub FrmEAmainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EAconn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        EAconn.Open()

    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        EAconn.Close()
        Me.Close()
        RegLoginWindow.Show()
    End Sub

    Private Sub BtnMS_Click(sender As Object, e As EventArgs) Handles BtnMS.Click
        FrmMedications.Show()
    End Sub

    Private Sub BtnPharma_Click(sender As Object, e As EventArgs) Handles BtnPharma.Click
        FrmPharmaceutical.Show()
    End Sub

    Private Sub BtnDS_Click(sender As Object, e As EventArgs) Handles BtnDS.Click
        FrmMaintDS.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmEmployee.Show()
    End Sub

    Private Sub BtnOR_Click(sender As Object, e As EventArgs) Handles BtnOR.Click
        FrmTransactMaint.Show()
    End Sub

    Private Sub BtnTracking_Click(sender As Object, e As EventArgs) Handles BtnTracking.Click
        FrmTrackingMaint.Show()
    End Sub
End Class
