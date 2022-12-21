<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrackingMaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrackingMaint))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DGVtoprocess = New System.Windows.Forms.DataGridView()
        Me.DGVotw = New System.Windows.Forms.DataGridView()
        Me.DGVdelivered = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DatePickerETA = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComBoxEmployee = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTrackingNum = New System.Windows.Forms.TextBox()
        CType(Me.DGVtoprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVotw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVdelivered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(12, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DGVtoprocess
        '
        Me.DGVtoprocess.AllowUserToAddRows = False
        Me.DGVtoprocess.AllowUserToDeleteRows = False
        Me.DGVtoprocess.AllowUserToOrderColumns = True
        Me.DGVtoprocess.BackgroundColor = System.Drawing.Color.White
        Me.DGVtoprocess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtoprocess.GridColor = System.Drawing.Color.Black
        Me.DGVtoprocess.Location = New System.Drawing.Point(104, 143)
        Me.DGVtoprocess.Name = "DGVtoprocess"
        Me.DGVtoprocess.Size = New System.Drawing.Size(551, 135)
        Me.DGVtoprocess.TabIndex = 5
        '
        'DGVotw
        '
        Me.DGVotw.AllowUserToAddRows = False
        Me.DGVotw.AllowUserToDeleteRows = False
        Me.DGVotw.AllowUserToOrderColumns = True
        Me.DGVotw.BackgroundColor = System.Drawing.Color.White
        Me.DGVotw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVotw.GridColor = System.Drawing.Color.Black
        Me.DGVotw.Location = New System.Drawing.Point(104, 313)
        Me.DGVotw.Name = "DGVotw"
        Me.DGVotw.Size = New System.Drawing.Size(551, 135)
        Me.DGVotw.TabIndex = 6
        '
        'DGVdelivered
        '
        Me.DGVdelivered.AllowUserToAddRows = False
        Me.DGVdelivered.AllowUserToDeleteRows = False
        Me.DGVdelivered.AllowUserToOrderColumns = True
        Me.DGVdelivered.BackgroundColor = System.Drawing.Color.White
        Me.DGVdelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdelivered.GridColor = System.Drawing.Color.Black
        Me.DGVdelivered.Location = New System.Drawing.Point(104, 483)
        Me.DGVdelivered.Name = "DGVdelivered"
        Me.DGVdelivered.Size = New System.Drawing.Size(551, 135)
        Me.DGVdelivered.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To Process"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "On the way"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Delivered"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 30)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 625)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(947, 27)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TRACKING"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tracking
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(23, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.ComBoxStatus)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DatePickerETA)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ComBoxEmployee)
        Me.Panel3.Controls.Add(Me.BtnUpdate)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtTrackingNum)
        Me.Panel3.Location = New System.Drawing.Point(695, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 361)
        Me.Panel3.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Status"
        '
        'ComBoxStatus
        '
        Me.ComBoxStatus.FormattingEnabled = True
        Me.ComBoxStatus.Location = New System.Drawing.Point(17, 177)
        Me.ComBoxStatus.Name = "ComBoxStatus"
        Me.ComBoxStatus.Size = New System.Drawing.Size(200, 21)
        Me.ComBoxStatus.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ETA"
        '
        'DatePickerETA
        '
        Me.DatePickerETA.Location = New System.Drawing.Point(17, 237)
        Me.DatePickerETA.Name = "DatePickerETA"
        Me.DatePickerETA.Size = New System.Drawing.Size(200, 20)
        Me.DatePickerETA.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Employee"
        '
        'ComBoxEmployee
        '
        Me.ComBoxEmployee.FormattingEnabled = True
        Me.ComBoxEmployee.Location = New System.Drawing.Point(17, 123)
        Me.ComBoxEmployee.Name = "ComBoxEmployee"
        Me.ComBoxEmployee.Size = New System.Drawing.Size(200, 21)
        Me.ComBoxEmployee.TabIndex = 26
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(17, 286)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 23)
        Me.BtnUpdate.TabIndex = 25
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tracking Num"
        '
        'TxtTrackingNum
        '
        Me.TxtTrackingNum.Enabled = False
        Me.TxtTrackingNum.Location = New System.Drawing.Point(17, 70)
        Me.TxtTrackingNum.Name = "TxtTrackingNum"
        Me.TxtTrackingNum.Size = New System.Drawing.Size(200, 20)
        Me.TxtTrackingNum.TabIndex = 23
        '
        'FrmTrackingMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVdelivered)
        Me.Controls.Add(Me.DGVotw)
        Me.Controls.Add(Me.DGVtoprocess)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTrackingMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVtoprocess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVotw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVdelivered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents DGVtoprocess As System.Windows.Forms.DataGridView
    Friend WithEvents DGVotw As System.Windows.Forms.DataGridView
    Friend WithEvents DGVdelivered As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DatePickerETA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComBoxEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTrackingNum As System.Windows.Forms.TextBox
End Class
