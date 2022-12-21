<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateP))
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtPharmaContNum = New System.Windows.Forms.TextBox()
        Me.TxtPharmaEmail = New System.Windows.Forms.TextBox()
        Me.TxtPharmaID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPharmaName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(33, 329)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(330, 27)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "UPDATE AND SAVE CHANGES"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnReset.FlatAppearance.BorderSize = 0
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(33, 362)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(162, 27)
        Me.BtnReset.TabIndex = 44
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(201, 362)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(162, 27)
        Me.BtnClose.TabIndex = 38
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtPharmaContNum
        '
        Me.TxtPharmaContNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaContNum.Location = New System.Drawing.Point(33, 265)
        Me.TxtPharmaContNum.MaxLength = 20
        Me.TxtPharmaContNum.Name = "TxtPharmaContNum"
        Me.TxtPharmaContNum.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaContNum.TabIndex = 52
        '
        'TxtPharmaEmail
        '
        Me.TxtPharmaEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaEmail.Location = New System.Drawing.Point(33, 198)
        Me.TxtPharmaEmail.MaxLength = 50
        Me.TxtPharmaEmail.Name = "TxtPharmaEmail"
        Me.TxtPharmaEmail.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaEmail.TabIndex = 49
        '
        'TxtPharmaID
        '
        Me.TxtPharmaID.Enabled = False
        Me.TxtPharmaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaID.Location = New System.Drawing.Point(33, 59)
        Me.TxtPharmaID.MaxLength = 10
        Me.TxtPharmaID.Name = "TxtPharmaID"
        Me.TxtPharmaID.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaID.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.beautiful_color_gradient_hues_backgrounds_abdcff_0396ff
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(-3, -40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 646)
        Me.Panel2.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Controls.Add(Me.BtnReset)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.TxtPharmaContNum)
        Me.Panel1.Controls.Add(Me.TxtPharmaEmail)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPharmaID)
        Me.Panel1.Controls.Add(Me.TxtPharmaName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(94, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 422)
        Me.Panel1.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Email"
        '
        'TxtPharmaName
        '
        Me.TxtPharmaName.Enabled = False
        Me.TxtPharmaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaName.Location = New System.Drawing.Point(33, 117)
        Me.TxtPharmaName.MaxLength = 50
        Me.TxtPharmaName.Multiline = True
        Me.TxtPharmaName.Name = "TxtPharmaName"
        Me.TxtPharmaName.Size = New System.Drawing.Size(330, 41)
        Me.TxtPharmaName.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Pharma ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Pharmaceutical Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(186, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 29)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "UPDATE RECORD"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmUpdateP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtPharmaContNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtPharmaEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPharmaID As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPharmaName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
