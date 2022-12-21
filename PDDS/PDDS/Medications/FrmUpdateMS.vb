Imports IBM.Data.DB2

Public Class FrmUpdateMS
    Private MedConn As Common.DbConnection
    Private Sub FrmUpdateMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        MedConn.Open()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCloseU.Click
        Call FrmMedications.Refresh_Datagrid()
        Me.Close()
    End Sub

    Private Sub BtnReset1_Click(sender As Object, e As EventArgs) Handles BtnReset1.Click
        Me.TxtItemID1.Text = FrmMedications.DGVMed.CurrentRow.Cells(0).Value
        Me.TxtPharmaID1.Text = FrmMedications.DGVMed.CurrentRow.Cells(1).Value
        Me.TxtGenName1.Text = FrmMedications.DGVMed.CurrentRow.Cells(2).Value
        Me.TxtTherCat1.Text = FrmMedications.DGVMed.CurrentRow.Cells(3).Value
        Me.TxtDosage1.Text = FrmMedications.DGVMed.CurrentRow.Cells(4).Value
        Me.TxtRetail1.Text = FrmMedications.DGVMed.CurrentRow.Cells(5).Value
        Me.TxtWholePrice1.Text = FrmMedications.DGVMed.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnUpdate1.Click
        Try

            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Dim VItemID As String
            Dim VPharmaID As String
            Dim VGenName As String
            Dim VTherCat As String
            Dim VDosage As String
            Dim VRetail As String
            Dim VWholePrice As String

            VItemID = Me.TxtItemID1.Text()
            VPharmaID = Me.TxtPharmaID1.Text
            VGenName = Me.TxtGenName1.Text
            VTherCat = Me.TxtTherCat1.Text
            VDosage = Me.TxtDosage1.Text
            VRetail = Me.TxtRetail1.Text
            VWholePrice = Me.TxtWholePrice1.Text

            StrUpdate = "update medicationsupply set retailprice = '" & VRetail & "', wholesaleprice = '" & VWholePrice & "' where itemID='" & VItemID & "'"
            CmdUpdate = New DB2Command(StrUpdate, MedConn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class