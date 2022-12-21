<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDSOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDSOrders))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtProcessNum = New System.Windows.Forms.TextBox()
        Me.DGVOI = New System.Windows.Forms.DataGridView()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        Me.BtnShowDetails = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGVOI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TRANSACTIONS"
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
        Me.BtnClose.Size = New System.Drawing.Size(98, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "GO BACK"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtProcessNum
        '
        Me.TxtProcessNum.Enabled = False
        Me.TxtProcessNum.Location = New System.Drawing.Point(584, 116)
        Me.TxtProcessNum.Name = "TxtProcessNum"
        Me.TxtProcessNum.Size = New System.Drawing.Size(129, 20)
        Me.TxtProcessNum.TabIndex = 7
        '
        'DGVOI
        '
        Me.DGVOI.AllowUserToAddRows = False
        Me.DGVOI.AllowUserToDeleteRows = False
        Me.DGVOI.BackgroundColor = System.Drawing.Color.White
        Me.DGVOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOI.GridColor = System.Drawing.Color.Black
        Me.DGVOI.Location = New System.Drawing.Point(166, 282)
        Me.DGVOI.Name = "DGVOI"
        Me.DGVOI.Size = New System.Drawing.Size(485, 150)
        Me.DGVOI.TabIndex = 6
        '
        'DGVOrders
        '
        Me.DGVOrders.AllowUserToAddRows = False
        Me.DGVOrders.AllowUserToDeleteRows = False
        Me.DGVOrders.BackgroundColor = System.Drawing.Color.White
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.GridColor = System.Drawing.Color.Black
        Me.DGVOrders.Location = New System.Drawing.Point(91, 116)
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.Size = New System.Drawing.Size(487, 150)
        Me.DGVOrders.TabIndex = 5
        '
        'BtnShowDetails
        '
        Me.BtnShowDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnShowDetails.FlatAppearance.BorderSize = 0
        Me.BtnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowDetails.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowDetails.ForeColor = System.Drawing.Color.White
        Me.BtnShowDetails.Location = New System.Drawing.Point(584, 142)
        Me.BtnShowDetails.Name = "BtnShowDetails"
        Me.BtnShowDetails.Size = New System.Drawing.Size(129, 23)
        Me.BtnShowDetails.TabIndex = 10
        Me.BtnShowDetails.Text = "SHOW DETAILS"
        Me.BtnShowDetails.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 31)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enter__1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(91, 282)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.invoice
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(11, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(584, 171)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 41)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "*Click an item in the first table before clicking the show details button"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 31)
        Me.Panel2.TabIndex = 15
        '
        'FrmDSOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnShowDetails)
        Me.Controls.Add(Me.TxtProcessNum)
        Me.Controls.Add(Me.DGVOI)
        Me.Controls.Add(Me.DGVOrders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDSOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVOI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtProcessNum As System.Windows.Forms.TextBox
    Friend WithEvents DGVOI As System.Windows.Forms.DataGridView
    Friend WithEvents DGVOrders As System.Windows.Forms.DataGridView
    Friend WithEvents BtnShowDetails As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
