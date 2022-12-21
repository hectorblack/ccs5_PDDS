<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedications))
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtItemID = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAddMS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchM = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DGVMed = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGVMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(619, 404)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(119, 29)
        Me.BtnUpdate.TabIndex = 17
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'TxtItemID
        '
        Me.TxtItemID.Location = New System.Drawing.Point(391, 409)
        Me.TxtItemID.Name = "TxtItemID"
        Me.TxtItemID.Size = New System.Drawing.Size(201, 20)
        Me.TxtItemID.TabIndex = 16
        Me.TxtItemID.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(869, 404)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(119, 29)
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAddMS
        '
        Me.BtnAddMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAddMS.FlatAppearance.BorderSize = 0
        Me.BtnAddMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMS.ForeColor = System.Drawing.Color.White
        Me.BtnAddMS.Location = New System.Drawing.Point(744, 404)
        Me.BtnAddMS.Name = "BtnAddMS"
        Me.BtnAddMS.Size = New System.Drawing.Size(119, 29)
        Me.BtnAddMS.TabIndex = 14
        Me.BtnAddMS.Text = "ADD ITEMS"
        Me.BtnAddMS.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(761, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Search"
        '
        'TxtSearchM
        '
        Me.TxtSearchM.Location = New System.Drawing.Point(813, 120)
        Me.TxtSearchM.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearchM.Name = "TxtSearchM"
        Me.TxtSearchM.Size = New System.Drawing.Size(175, 20)
        Me.TxtSearchM.TabIndex = 11
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(4, 4)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 24)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DGVMed
        '
        Me.DGVMed.AllowUserToAddRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMed.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMed.BackgroundColor = System.Drawing.Color.White
        Me.DGVMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMed.GridColor = System.Drawing.Color.Black
        Me.DGVMed.Location = New System.Drawing.Point(66, 148)
        Me.DGVMed.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVMed.Name = "DGVMed"
        Me.DGVMed.Size = New System.Drawing.Size(922, 245)
        Me.DGVMed.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "MEDICATIONS AND SUPPLIES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.drugs
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(30, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 32)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 27)
        Me.Panel2.TabIndex = 21
        '
        'FrmMedications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TxtItemID)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddMS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchM)
        Me.Controls.Add(Me.DGVMed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMedications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtItemID As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddMS As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchM As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents DGVMed As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
