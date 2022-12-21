<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransactMaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransactMaint))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtProcessNum = New System.Windows.Forms.TextBox()
        Me.DGVAllOrders = New System.Windows.Forms.DataGridView()
        Me.DGVselectedorder = New System.Windows.Forms.DataGridView()
        Me.BtnShowDetails = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVAllOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVselectedorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(7, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 13
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtProcessNum
        '
        Me.TxtProcessNum.Enabled = False
        Me.TxtProcessNum.Location = New System.Drawing.Point(629, 142)
        Me.TxtProcessNum.Name = "TxtProcessNum"
        Me.TxtProcessNum.Size = New System.Drawing.Size(129, 20)
        Me.TxtProcessNum.TabIndex = 12
        '
        'DGVAllOrders
        '
        Me.DGVAllOrders.AllowUserToAddRows = False
        Me.DGVAllOrders.AllowUserToDeleteRows = False
        Me.DGVAllOrders.BackgroundColor = System.Drawing.Color.White
        Me.DGVAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAllOrders.GridColor = System.Drawing.Color.Black
        Me.DGVAllOrders.Location = New System.Drawing.Point(50, 115)
        Me.DGVAllOrders.Name = "DGVAllOrders"
        Me.DGVAllOrders.Size = New System.Drawing.Size(558, 150)
        Me.DGVAllOrders.TabIndex = 15
        '
        'DGVselectedorder
        '
        Me.DGVselectedorder.AllowUserToAddRows = False
        Me.DGVselectedorder.AllowUserToDeleteRows = False
        Me.DGVselectedorder.BackgroundColor = System.Drawing.Color.White
        Me.DGVselectedorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVselectedorder.GridColor = System.Drawing.Color.Black
        Me.DGVselectedorder.Location = New System.Drawing.Point(114, 280)
        Me.DGVselectedorder.Name = "DGVselectedorder"
        Me.DGVselectedorder.Size = New System.Drawing.Size(560, 150)
        Me.DGVselectedorder.TabIndex = 16
        '
        'BtnShowDetails
        '
        Me.BtnShowDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnShowDetails.FlatAppearance.BorderSize = 0
        Me.BtnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowDetails.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowDetails.ForeColor = System.Drawing.Color.White
        Me.BtnShowDetails.Location = New System.Drawing.Point(644, 202)
        Me.BtnShowDetails.Name = "BtnShowDetails"
        Me.BtnShowDetails.Size = New System.Drawing.Size(129, 23)
        Me.BtnShowDetails.TabIndex = 17
        Me.BtnShowDetails.Text = "SHOW DETAILS"
        Me.BtnShowDetails.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(629, 168)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 28)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Text = "*Click in the first table first before clicking the show details button"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TRANSACTIONS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.invoice
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 34)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 461)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 33)
        Me.Panel2.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enter__1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(50, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'FrmTransactMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnShowDetails)
        Me.Controls.Add(Me.DGVselectedorder)
        Me.Controls.Add(Me.DGVAllOrders)
        Me.Controls.Add(Me.TxtProcessNum)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTransactMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVAllOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVselectedorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtProcessNum As System.Windows.Forms.TextBox
    Friend WithEvents DGVAllOrders As System.Windows.Forms.DataGridView
    Friend WithEvents DGVselectedorder As System.Windows.Forms.DataGridView
    Friend WithEvents BtnShowDetails As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
