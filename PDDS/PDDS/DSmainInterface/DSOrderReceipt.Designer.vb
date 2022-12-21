<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDSOrderReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDSOrderReceipt))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTrackingNum = New System.Windows.Forms.TextBox()
        Me.BtnConfirmOrder = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtPayOptions = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVorderlist = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtStoreID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProcessNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPurchaseID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGVorderlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tracking Num:"
        '
        'TxtTrackingNum
        '
        Me.TxtTrackingNum.Enabled = False
        Me.TxtTrackingNum.Location = New System.Drawing.Point(171, 123)
        Me.TxtTrackingNum.Name = "TxtTrackingNum"
        Me.TxtTrackingNum.Size = New System.Drawing.Size(145, 20)
        Me.TxtTrackingNum.TabIndex = 28
        '
        'BtnConfirmOrder
        '
        Me.BtnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnConfirmOrder.FlatAppearance.BorderSize = 0
        Me.BtnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmOrder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmOrder.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmOrder.Location = New System.Drawing.Point(430, 365)
        Me.BtnConfirmOrder.Name = "BtnConfirmOrder"
        Me.BtnConfirmOrder.Size = New System.Drawing.Size(220, 38)
        Me.BtnConfirmOrder.TabIndex = 27
        Me.BtnConfirmOrder.Text = "CONFIRM AND PLACE ORDER"
        Me.BtnConfirmOrder.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(12, 30)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(90, 29)
        Me.BtnClose.TabIndex = 26
        Me.BtnClose.Text = "GO BACK"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtPayOptions
        '
        Me.TxtPayOptions.Enabled = False
        Me.TxtPayOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPayOptions.Location = New System.Drawing.Point(188, 316)
        Me.TxtPayOptions.Name = "TxtPayOptions"
        Me.TxtPayOptions.Size = New System.Drawing.Size(128, 20)
        Me.TxtPayOptions.TabIndex = 25
        Me.TxtPayOptions.Text = "Cash on Delivery"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Payment Options"
        '
        'DGVorderlist
        '
        Me.DGVorderlist.AllowUserToAddRows = False
        Me.DGVorderlist.AllowUserToDeleteRows = False
        Me.DGVorderlist.AllowUserToResizeRows = False
        Me.DGVorderlist.BackgroundColor = System.Drawing.Color.White
        Me.DGVorderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVorderlist.GridColor = System.Drawing.Color.Black
        Me.DGVorderlist.Location = New System.Drawing.Point(69, 156)
        Me.DGVorderlist.Name = "DGVorderlist"
        Me.DGVorderlist.Size = New System.Drawing.Size(532, 150)
        Me.DGVorderlist.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "StoreID"
        '
        'TxtStoreID
        '
        Me.TxtStoreID.Enabled = False
        Me.TxtStoreID.Location = New System.Drawing.Point(487, 87)
        Me.TxtStoreID.Name = "TxtStoreID"
        Me.TxtStoreID.Size = New System.Drawing.Size(114, 20)
        Me.TxtStoreID.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Process Num:"
        Me.Label3.Visible = False
        '
        'TxtProcessNum
        '
        Me.TxtProcessNum.Enabled = False
        Me.TxtProcessNum.Location = New System.Drawing.Point(487, 122)
        Me.TxtProcessNum.Name = "TxtProcessNum"
        Me.TxtProcessNum.Size = New System.Drawing.Size(114, 20)
        Me.TxtProcessNum.TabIndex = 19
        Me.TxtProcessNum.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(427, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(487, 312)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(114, 22)
        Me.TxtTotal.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Purchase ID:"
        '
        'TxtPurchaseID
        '
        Me.TxtPurchaseID.Enabled = False
        Me.TxtPurchaseID.Location = New System.Drawing.Point(171, 87)
        Me.TxtPurchaseID.Name = "TxtPurchaseID"
        Me.TxtPurchaseID.Size = New System.Drawing.Size(145, 20)
        Me.TxtPurchaseID.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 24)
        Me.Panel1.TabIndex = 30
        '
        'FrmDSOrderReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTrackingNum)
        Me.Controls.Add(Me.BtnConfirmOrder)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtPayOptions)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVorderlist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtStoreID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtProcessNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPurchaseID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDSOrderReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVorderlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTrackingNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnConfirmOrder As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtPayOptions As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGVorderlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtStoreID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProcessNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
