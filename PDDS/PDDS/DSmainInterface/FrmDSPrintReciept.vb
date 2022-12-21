Imports IBM.Data.DB2
Public Class FrmDSPrintReciept
    Private PrintConn As Common.DbConnection
    Private Sub FrmDSPrintReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintConn = New DB2Connection("server=localhost;database=pdds;" + "uid=db2admin;password=db2admin")
        PrintConn.Open()

        Dim RdrMed2 As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim vpn As String

        vpn = FrmDSOrderReceipt.TxtProcessNum.Text
        SelectStr = "select * from store_medsup where processnum = '" & vpn & "'"
        cmdRetrieve = New DB2Command(SelectStr, PrintConn)
        RdrMed2 = cmdRetrieve.ExecuteReader


        Dim VPurchaseID As String = FrmDSOrderReceipt.TxtPurchaseID.Text
        Dim VStoreID As String = FrmDSOrderReceipt.TxtStoreID.Text
        Dim VTrackingNum As String = FrmDSOrderReceipt.TxtTrackingNum.Text
        Dim VTotal As String = FrmDSOrderReceipt.TxtTotal.Text
        Dim VPayOption As String = FrmDSOrderReceipt.TxtPayOptions.Text


        TxtPrint.Text = ""
        TxtPrint.AppendText(vbTab + vbTab & "       VENUS" + vbNewLine)
        TxtPrint.AppendText(vbTab & "     Pharmaceutical Drug Distributor" + vbNewLine)
        TxtPrint.AppendText(vbTab & "      Hibbard Ave., Dumaguete City" + vbNewLine)
        TxtPrint.AppendText(vbTab & "           Negros Oriental, 6200" + vbNewLine)
        TxtPrint.AppendText("" + vbNewLine)
        TxtPrint.AppendText(vbTab + vbTab & " Official Reciept" + vbNewLine)
        TxtPrint.AppendText("" + vbNewLine)
        TxtPrint.AppendText(" Client ID : " & VStoreID + vbNewLine)
        TxtPrint.AppendText(" Purchase Number : " & VPurchaseID + vbNewLine)
        TxtPrint.AppendText(" Tracking Number : " & VTrackingNum + vbNewLine)
        TxtPrint.AppendText(" Payment Option : " & VPayOption + vbNewLine)
        TxtPrint.AppendText("" + vbNewLine)
        TxtPrint.AppendText("----------------------------------------------------------------------------------------" + vbNewLine)
        TxtPrint.AppendText(" Qty   " + vbTab & " Item ID" + vbTab + vbTab + "Price" + vbTab + "   " + "SubTotal" + vbNewLine)
        TxtPrint.AppendText("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" + vbNewLine)
        While RdrMed2.Read

            TxtItem.Text = RdrMed2.GetString(2)
            TxtPrice.Text = RdrMed2.GetString(4)
            TxtQuantity.Text = RdrMed2.GetString(5)
            TxtSubtotal.Text = RdrMed2.GetString(6)

            Dim Vitem As String = TxtItem.Text
            Dim Vprice As String = TxtPrice.Text
            Dim Vquantity As String = TxtQuantity.Text
            Dim Vsubtotal As String = TxtSubtotal.Text

            TxtPrint.AppendText(" " & Vquantity + vbTab & Vitem + vbTab & Vprice + vbTab + "   " & Vsubtotal + vbNewLine)
        End While

        TxtPrint.AppendText("----------------------------------------------------------------------------------------" + vbNewLine)
        TxtPrint.AppendText("Total: " + vbTab + vbTab + vbTab + vbTab + "   " & VTotal + vbNewLine)
        TxtPrint.AppendText("" + vbNewLine)
        TxtPrint.AppendText("----------------------------------------------------------------------------------------" + vbNewLine)
        TxtPrint.AppendText(vbTab + vbTab & "     THANK YOU" + vbNewLine)
        TxtPrint.AppendText("----------------------------------------------------------------------------------------" + vbNewLine)


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim mickey As String

        mickey = TxtPrint.Text

        Dim font As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(mickey, font, Brushes.Black, 200, 200)
    End Sub

    Private Sub BtnPageSetup_Click(sender As Object, e As EventArgs) Handles BtnPageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub BtnPrintPreview_Click(sender As Object, e As EventArgs) Handles BtnPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PrintConn.Close()
        Me.Close()
    End Sub
End Class