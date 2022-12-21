<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdEmp))
        Me.TxtEmpPass = New System.Windows.Forms.TextBox()
        Me.CnclBttn = New System.Windows.Forms.Button()
        Me.TxtEmpID = New System.Windows.Forms.TextBox()
        Me.UpdBttn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEmpName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEmpJob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmpContNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtEmpPass
        '
        Me.TxtEmpPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpPass.Location = New System.Drawing.Point(23, 277)
        Me.TxtEmpPass.MaxLength = 16
        Me.TxtEmpPass.Name = "TxtEmpPass"
        Me.TxtEmpPass.Size = New System.Drawing.Size(341, 22)
        Me.TxtEmpPass.TabIndex = 7
        '
        'CnclBttn
        '
        Me.CnclBttn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CnclBttn.FlatAppearance.BorderSize = 0
        Me.CnclBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CnclBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnclBttn.Location = New System.Drawing.Point(34, 382)
        Me.CnclBttn.Name = "CnclBttn"
        Me.CnclBttn.Size = New System.Drawing.Size(330, 35)
        Me.CnclBttn.TabIndex = 13
        Me.CnclBttn.Text = "Close"
        Me.CnclBttn.UseVisualStyleBackColor = False
        '
        'TxtEmpID
        '
        Me.TxtEmpID.Enabled = False
        Me.TxtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpID.Location = New System.Drawing.Point(23, 45)
        Me.TxtEmpID.Name = "TxtEmpID"
        Me.TxtEmpID.Size = New System.Drawing.Size(341, 22)
        Me.TxtEmpID.TabIndex = 1
        '
        'UpdBttn
        '
        Me.UpdBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.UpdBttn.FlatAppearance.BorderSize = 0
        Me.UpdBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdBttn.Location = New System.Drawing.Point(34, 341)
        Me.UpdBttn.Name = "UpdBttn"
        Me.UpdBttn.Size = New System.Drawing.Size(330, 35)
        Me.UpdBttn.TabIndex = 12
        Me.UpdBttn.Text = "UPDATE AND SAVE CHANGES"
        Me.UpdBttn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Employee Password"
        '
        'TxtEmpName
        '
        Me.TxtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpName.Location = New System.Drawing.Point(23, 101)
        Me.TxtEmpName.MaxLength = 30
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(341, 22)
        Me.TxtEmpName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Employee Contact Number"
        '
        'TxtEmpJob
        '
        Me.TxtEmpJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpJob.Location = New System.Drawing.Point(23, 158)
        Me.TxtEmpJob.MaxLength = 40
        Me.TxtEmpJob.Name = "TxtEmpJob"
        Me.TxtEmpJob.Size = New System.Drawing.Size(341, 22)
        Me.TxtEmpJob.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee Job Description"
        '
        'TxtEmpContNum
        '
        Me.TxtEmpContNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpContNum.Location = New System.Drawing.Point(23, 217)
        Me.TxtEmpContNum.MaxLength = 16
        Me.TxtEmpContNum.Name = "TxtEmpContNum"
        Me.TxtEmpContNum.Size = New System.Drawing.Size(341, 22)
        Me.TxtEmpContNum.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(180, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 33)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "UPDATE RECORD"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.beautiful_color_gradient_hues_backgrounds_abdcff_0396ff
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 710)
        Me.Panel1.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TxtEmpPass)
        Me.Panel2.Controls.Add(Me.CnclBttn)
        Me.Panel2.Controls.Add(Me.TxtEmpID)
        Me.Panel2.Controls.Add(Me.UpdBttn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtEmpName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtEmpJob)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtEmpContNum)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(94, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 452)
        Me.Panel2.TabIndex = 0
        '
        'FrmUpdEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 639)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtEmpPass As System.Windows.Forms.TextBox
    Friend WithEvents CnclBttn As System.Windows.Forms.Button
    Friend WithEvents TxtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents UpdBttn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpJob As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpContNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
