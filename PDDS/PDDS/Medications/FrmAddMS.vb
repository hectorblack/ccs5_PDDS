Imports IBM.Data.DB2


Public Class FrmAddMS
    Private MedConn As Common.DbConnection

    Private Sub AddMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        MedConn.Open()
    End Sub

    Private Sub ClearEntry()

        Me.TxtItemID2.Clear()
        Me.TxtPharmaID2.Clear()
        Me.TxtGenName2.Clear()
        Me.TxtTherCat2.Clear()
        Me.TxtDosage2.Clear()
        Me.TxtRetail2.Clear()
        Me.TxtWholePrice2.Clear()

        Me.TxtItemID2.Focus()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim ItemID As String
            Dim PharmaID As String
            Dim GenName As String
            Dim TherCat As String
            Dim Dosage As String
            Dim Retail As String
            Dim WholePrice As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            ItemID = Me.TxtItemID2.Text
            PharmaID = Me.TxtPharmaID2.Text
            GenName = Me.TxtGenName2.Text
            TherCat = Me.TxtTherCat2.Text
            Dosage = Me.TxtDosage2.Text
            Retail = Me.TxtRetail2.Text
            WholePrice = Me.TxtWholePrice2.Text

            InsertStr = "insert into medicationsupply values('" & ItemID & "','" & PharmaID & "','" & GenName & "','" & TherCat & "','" & Dosage & "','" & Retail & "','" & WholePrice & "' )"
            CmdInsert = New DB2Command(InsertStr, MedConn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")
            Call FrmMedications.Refresh_Datagrid()
            Call Me.ClearEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Call Me.ClearEntry()
    End Sub

End Class