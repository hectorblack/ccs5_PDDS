<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPharmaceutical
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPharmaceutical))
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtPharmaID = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAddPharma = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchP = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DGVPharma = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVPharma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(528, 390)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'TxtPharmaID
        '
        Me.TxtPharmaID.Location = New System.Drawing.Point(740, 395)
        Me.TxtPharmaID.Name = "TxtPharmaID"
        Me.TxtPharmaID.Size = New System.Drawing.Size(201, 20)
        Me.TxtPharmaID.TabIndex = 25
        Me.TxtPharmaID.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(634, 390)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 28)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAddPharma
        '
        Me.BtnAddPharma.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnAddPharma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAddPharma.FlatAppearance.BorderSize = 0
        Me.BtnAddPharma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPharma.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPharma.ForeColor = System.Drawing.Color.White
        Me.BtnAddPharma.Location = New System.Drawing.Point(383, 390)
        Me.BtnAddPharma.Name = "BtnAddPharma"
        Me.BtnAddPharma.Size = New System.Drawing.Size(139, 28)
        Me.BtnAddPharma.TabIndex = 23
        Me.BtnAddPharma.Text = "ADD NEW RECORD"
        Me.BtnAddPharma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddPharma.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Search"
        '
        'TxtSearchP
        '
        Me.TxtSearchP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchP.Location = New System.Drawing.Point(516, 110)
        Me.TxtSearchP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearchP.Multiline = True
        Me.TxtSearchP.Name = "TxtSearchP"
        Me.TxtSearchP.Size = New System.Drawing.Size(218, 25)
        Me.TxtSearchP.TabIndex = 21
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(10, 7)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 24)
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DGVPharma
        '
        Me.DGVPharma.AllowUserToAddRows = False
        Me.DGVPharma.AllowUserToDeleteRows = False
        Me.DGVPharma.BackgroundColor = System.Drawing.Color.White
        Me.DGVPharma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPharma.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPharma.GridColor = System.Drawing.Color.Black
        Me.DGVPharma.Location = New System.Drawing.Point(53, 164)
        Me.DGVPharma.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPharma.Name = "DGVPharma"
        Me.DGVPharma.Size = New System.Drawing.Size(681, 207)
        Me.DGVPharma.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 40)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "PHARMACEUTICALS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 448)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 32)
        Me.Panel2.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.factory__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(24, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'FrmPharmaceutical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TxtPharmaID)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddPharma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchP)
        Me.Controls.Add(Me.DGVPharma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPharmaceutical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVPharma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtPharmaID As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddPharma As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchP As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents DGVPharma As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
