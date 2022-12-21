<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDSPrintReciept
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDSPrintReciept))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnPageSetup = New System.Windows.Forms.Button()
        Me.BtnPrintPreview = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TxtPrint = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(3, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 515)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 27)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 32)
        Me.Panel2.TabIndex = 2
        '
        'BtnPageSetup
        '
        Me.BtnPageSetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnPageSetup.FlatAppearance.BorderSize = 0
        Me.BtnPageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPageSetup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPageSetup.ForeColor = System.Drawing.Color.Black
        Me.BtnPageSetup.Location = New System.Drawing.Point(303, 466)
        Me.BtnPageSetup.Name = "BtnPageSetup"
        Me.BtnPageSetup.Size = New System.Drawing.Size(118, 28)
        Me.BtnPageSetup.TabIndex = 6
        Me.BtnPageSetup.Text = "PAGE SETUP"
        Me.BtnPageSetup.UseVisualStyleBackColor = False
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnPrintPreview.FlatAppearance.BorderSize = 0
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintPreview.Location = New System.Drawing.Point(163, 466)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(134, 28)
        Me.BtnPrintPreview.TabIndex = 5
        Me.BtnPrintPreview.Text = "PRINT PREVIEW"
        Me.BtnPrintPreview.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Location = New System.Drawing.Point(427, 466)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(118, 28)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TxtPrint
        '
        Me.TxtPrint.BackColor = System.Drawing.Color.White
        Me.TxtPrint.Location = New System.Drawing.Point(177, 56)
        Me.TxtPrint.Multiline = True
        Me.TxtPrint.Name = "TxtPrint"
        Me.TxtPrint.Size = New System.Drawing.Size(351, 379)
        Me.TxtPrint.TabIndex = 7
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Enabled = False
        Me.TxtSubtotal.Location = New System.Drawing.Point(303, 249)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubtotal.TabIndex = 21
        Me.TxtSubtotal.Visible = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Enabled = False
        Me.TxtQuantity.Location = New System.Drawing.Point(303, 214)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.TxtQuantity.TabIndex = 20
        Me.TxtQuantity.Visible = False
        '
        'TxtPrice
        '
        Me.TxtPrice.Enabled = False
        Me.TxtPrice.Location = New System.Drawing.Point(303, 177)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrice.TabIndex = 19
        Me.TxtPrice.Visible = False
        '
        'TxtItem
        '
        Me.TxtItem.Enabled = False
        Me.TxtItem.Location = New System.Drawing.Point(303, 141)
        Me.TxtItem.MaxLength = 20
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(100, 20)
        Me.TxtItem.TabIndex = 18
        Me.TxtItem.Visible = False
        '
        'FrmDSPrintReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtPrint)
        Me.Controls.Add(Me.BtnPageSetup)
        Me.Controls.Add(Me.BtnPrintPreview)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDSPrintReciept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnPageSetup As System.Windows.Forms.Button
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TxtPrint As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtItem As System.Windows.Forms.TextBox
End Class
