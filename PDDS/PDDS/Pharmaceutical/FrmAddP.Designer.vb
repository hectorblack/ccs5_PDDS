<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddP))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtPharmaContNum = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtPharmaEmail = New System.Windows.Forms.TextBox()
        Me.TxtPharmaName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPharmaID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.beautiful_color_gradient_hues_backgrounds_abdcff_0396ff
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-4, -29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 646)
        Me.Panel2.TabIndex = 65
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.TxtPharmaContNum)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.TxtPharmaEmail)
        Me.Panel1.Controls.Add(Me.TxtPharmaName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtPharmaID)
        Me.Panel1.Location = New System.Drawing.Point(94, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 422)
        Me.Panel1.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Contact Number"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(33, 329)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(330, 27)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtPharmaContNum
        '
        Me.TxtPharmaContNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaContNum.Location = New System.Drawing.Point(33, 260)
        Me.TxtPharmaContNum.MaxLength = 20
        Me.TxtPharmaContNum.Name = "TxtPharmaContNum"
        Me.TxtPharmaContNum.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaContNum.TabIndex = 61
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
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Email"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(33, 362)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(162, 27)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtPharmaEmail
        '
        Me.TxtPharmaEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaEmail.Location = New System.Drawing.Point(33, 198)
        Me.TxtPharmaEmail.MaxLength = 50
        Me.TxtPharmaEmail.Name = "TxtPharmaEmail"
        Me.TxtPharmaEmail.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaEmail.TabIndex = 59
        '
        'TxtPharmaName
        '
        Me.TxtPharmaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaName.Location = New System.Drawing.Point(33, 117)
        Me.TxtPharmaName.MaxLength = 50
        Me.TxtPharmaName.Multiline = True
        Me.TxtPharmaName.Name = "TxtPharmaName"
        Me.TxtPharmaName.Size = New System.Drawing.Size(330, 41)
        Me.TxtPharmaName.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Pharma ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Pharmaceutical Name:"
        '
        'TxtPharmaID
        '
        Me.TxtPharmaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPharmaID.Location = New System.Drawing.Point(33, 59)
        Me.TxtPharmaID.MaxLength = 10
        Me.TxtPharmaID.Name = "TxtPharmaID"
        Me.TxtPharmaID.Size = New System.Drawing.Size(330, 22)
        Me.TxtPharmaID.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(171, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 29)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ADD NEW RECORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmAddP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtPharmaContNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtPharmaEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPharmaName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPharmaID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
