<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaintDS))
        Me.DGVDrg = New System.Windows.Forms.DataGridView()
        Me.UpdInfBttn = New System.Windows.Forms.Button()
        Me.DelBttn = New System.Windows.Forms.Button()
        Me.TxtDrgStrID = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVDrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDrg
        '
        Me.DGVDrg.AllowUserToAddRows = False
        Me.DGVDrg.AllowUserToDeleteRows = False
        Me.DGVDrg.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDrg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDrg.GridColor = System.Drawing.Color.Black
        Me.DGVDrg.Location = New System.Drawing.Point(91, 139)
        Me.DGVDrg.Name = "DGVDrg"
        Me.DGVDrg.Size = New System.Drawing.Size(669, 203)
        Me.DGVDrg.TabIndex = 4
        '
        'UpdInfBttn
        '
        Me.UpdInfBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.UpdInfBttn.FlatAppearance.BorderSize = 0
        Me.UpdInfBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdInfBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdInfBttn.ForeColor = System.Drawing.Color.White
        Me.UpdInfBttn.Location = New System.Drawing.Point(504, 348)
        Me.UpdInfBttn.Name = "UpdInfBttn"
        Me.UpdInfBttn.Size = New System.Drawing.Size(120, 30)
        Me.UpdInfBttn.TabIndex = 6
        Me.UpdInfBttn.Text = "UPDATE"
        Me.UpdInfBttn.UseVisualStyleBackColor = False
        '
        'DelBttn
        '
        Me.DelBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DelBttn.FlatAppearance.BorderSize = 0
        Me.DelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBttn.ForeColor = System.Drawing.Color.White
        Me.DelBttn.Location = New System.Drawing.Point(640, 348)
        Me.DelBttn.Name = "DelBttn"
        Me.DelBttn.Size = New System.Drawing.Size(120, 30)
        Me.DelBttn.TabIndex = 5
        Me.DelBttn.Text = "DELETE"
        Me.DelBttn.UseVisualStyleBackColor = False
        '
        'TxtDrgStrID
        '
        Me.TxtDrgStrID.Location = New System.Drawing.Point(131, 173)
        Me.TxtDrgStrID.Name = "TxtDrgStrID"
        Me.TxtDrgStrID.Size = New System.Drawing.Size(100, 20)
        Me.TxtDrgStrID.TabIndex = 7
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(12, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 45)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 398)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(818, 33)
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DRUG STORE MAINTENANCE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pharmacy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(26, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FrmMaintDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(818, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVDrg)
        Me.Controls.Add(Me.UpdInfBttn)
        Me.Controls.Add(Me.DelBttn)
        Me.Controls.Add(Me.TxtDrgStrID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMaintDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVDrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVDrg As System.Windows.Forms.DataGridView
    Friend WithEvents UpdInfBttn As System.Windows.Forms.Button
    Friend WithEvents DelBttn As System.Windows.Forms.Button
    Friend WithEvents TxtDrgStrID As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
