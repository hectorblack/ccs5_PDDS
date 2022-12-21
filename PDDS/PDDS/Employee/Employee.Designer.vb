<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.TxtEmpID2 = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DGVEmp = New System.Windows.Forms.DataGridView()
        Me.UpdtEmp = New System.Windows.Forms.Button()
        Me.DelEmp = New System.Windows.Forms.Button()
        Me.AddEmp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtEmpID2
        '
        Me.TxtEmpID2.Enabled = False
        Me.TxtEmpID2.Location = New System.Drawing.Point(715, 322)
        Me.TxtEmpID2.Name = "TxtEmpID2"
        Me.TxtEmpID2.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmpID2.TabIndex = 13
        Me.TxtEmpID2.Visible = False
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
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DGVEmp
        '
        Me.DGVEmp.AllowUserToAddRows = False
        Me.DGVEmp.AllowUserToDeleteRows = False
        Me.DGVEmp.BackgroundColor = System.Drawing.Color.White
        Me.DGVEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmp.GridColor = System.Drawing.Color.Black
        Me.DGVEmp.Location = New System.Drawing.Point(50, 122)
        Me.DGVEmp.Name = "DGVEmp"
        Me.DGVEmp.Size = New System.Drawing.Size(659, 189)
        Me.DGVEmp.TabIndex = 11
        '
        'UpdtEmp
        '
        Me.UpdtEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.UpdtEmp.FlatAppearance.BorderSize = 0
        Me.UpdtEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdtEmp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdtEmp.ForeColor = System.Drawing.Color.White
        Me.UpdtEmp.Location = New System.Drawing.Point(443, 322)
        Me.UpdtEmp.Name = "UpdtEmp"
        Me.UpdtEmp.Size = New System.Drawing.Size(130, 30)
        Me.UpdtEmp.TabIndex = 10
        Me.UpdtEmp.Text = "UPDATE"
        Me.UpdtEmp.UseVisualStyleBackColor = False
        '
        'DelEmp
        '
        Me.DelEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DelEmp.FlatAppearance.BorderSize = 0
        Me.DelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelEmp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelEmp.ForeColor = System.Drawing.Color.White
        Me.DelEmp.Location = New System.Drawing.Point(579, 322)
        Me.DelEmp.Name = "DelEmp"
        Me.DelEmp.Size = New System.Drawing.Size(130, 30)
        Me.DelEmp.TabIndex = 9
        Me.DelEmp.Text = "DELETE"
        Me.DelEmp.UseVisualStyleBackColor = False
        '
        'AddEmp
        '
        Me.AddEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.AddEmp.FlatAppearance.BorderSize = 0
        Me.AddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmp.ForeColor = System.Drawing.Color.White
        Me.AddEmp.Location = New System.Drawing.Point(307, 322)
        Me.AddEmp.Name = "AddEmp"
        Me.AddEmp.Size = New System.Drawing.Size(130, 30)
        Me.AddEmp.TabIndex = 8
        Me.AddEmp.Text = "ADD RECORD"
        Me.AddEmp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 31)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PERSONNEL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.businessman__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 24)
        Me.Panel2.TabIndex = 17
        '
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtEmpID2)
        Me.Controls.Add(Me.DGVEmp)
        Me.Controls.Add(Me.UpdtEmp)
        Me.Controls.Add(Me.DelEmp)
        Me.Controls.Add(Me.AddEmp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEmpID2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents DGVEmp As System.Windows.Forms.DataGridView
    Friend WithEvents UpdtEmp As System.Windows.Forms.Button
    Friend WithEvents DelEmp As System.Windows.Forms.Button
    Friend WithEvents AddEmp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
