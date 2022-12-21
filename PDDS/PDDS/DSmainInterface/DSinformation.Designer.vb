<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDSinformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDSinformation))
        Me.TxtPassError = New System.Windows.Forms.TextBox()
        Me.LConfirm = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPassbefore = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtContNum = New System.Windows.Forms.TextBox()
        Me.TxtStoreLoc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtStoreName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtOwnerName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtStoreID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPassError
        '
        Me.TxtPassError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassError.ForeColor = System.Drawing.Color.Red
        Me.TxtPassError.Location = New System.Drawing.Point(33, 364)
        Me.TxtPassError.Name = "TxtPassError"
        Me.TxtPassError.Size = New System.Drawing.Size(120, 13)
        Me.TxtPassError.TabIndex = 37
        Me.TxtPassError.Text = "*Passwords dont match"
        Me.TxtPassError.Visible = False
        '
        'LConfirm
        '
        Me.LConfirm.AutoSize = True
        Me.LConfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LConfirm.Location = New System.Drawing.Point(30, 317)
        Me.LConfirm.Name = "LConfirm"
        Me.LConfirm.Size = New System.Drawing.Size(155, 16)
        Me.LConfirm.TabIndex = 36
        Me.LConfirm.Text = "Confirm New Password"
        Me.LConfirm.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(33, 429)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(330, 27)
        Me.BtnClose.TabIndex = 35
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(33, 396)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(330, 27)
        Me.BtnSave.TabIndex = 33
        Me.BtnSave.Text = "UPDATE AND SAVE CHANGES"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Txtpass
        '
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpass.Location = New System.Drawing.Point(33, 336)
        Me.Txtpass.MaxLength = 16
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpass.Size = New System.Drawing.Size(330, 22)
        Me.Txtpass.TabIndex = 34
        Me.Txtpass.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Password"
        '
        'TxtPassbefore
        '
        Me.TxtPassbefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassbefore.Location = New System.Drawing.Point(33, 278)
        Me.TxtPassbefore.MaxLength = 16
        Me.TxtPassbefore.Name = "TxtPassbefore"
        Me.TxtPassbefore.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassbefore.Size = New System.Drawing.Size(330, 22)
        Me.TxtPassbefore.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "ContactNum:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Store Location"
        '
        'TxtContNum
        '
        Me.TxtContNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContNum.Location = New System.Drawing.Point(33, 221)
        Me.TxtContNum.MaxLength = 16
        Me.TxtContNum.Name = "TxtContNum"
        Me.TxtContNum.Size = New System.Drawing.Size(330, 22)
        Me.TxtContNum.TabIndex = 14
        '
        'TxtStoreLoc
        '
        Me.TxtStoreLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStoreLoc.Location = New System.Drawing.Point(33, 166)
        Me.TxtStoreLoc.MaxLength = 40
        Me.TxtStoreLoc.Name = "TxtStoreLoc"
        Me.TxtStoreLoc.Size = New System.Drawing.Size(330, 22)
        Me.TxtStoreLoc.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Store Name"
        '
        'TxtStoreName
        '
        Me.TxtStoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStoreName.Location = New System.Drawing.Point(33, 113)
        Me.TxtStoreName.MaxLength = 20
        Me.TxtStoreName.Multiline = True
        Me.TxtStoreName.Name = "TxtStoreName"
        Me.TxtStoreName.Size = New System.Drawing.Size(330, 22)
        Me.TxtStoreName.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Owner Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(254, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 22)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "STORE ID"
        '
        'TxtOwnerName
        '
        Me.TxtOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOwnerName.Location = New System.Drawing.Point(33, 56)
        Me.TxtOwnerName.MaxLength = 20
        Me.TxtOwnerName.Multiline = True
        Me.TxtOwnerName.Name = "TxtOwnerName"
        Me.TxtOwnerName.Size = New System.Drawing.Size(330, 22)
        Me.TxtOwnerName.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TxtPassError)
        Me.Panel1.Controls.Add(Me.LConfirm)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtPassbefore)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtContNum)
        Me.Panel1.Controls.Add(Me.TxtStoreLoc)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtStoreName)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtOwnerName)
        Me.Panel1.Location = New System.Drawing.Point(105, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 469)
        Me.Panel1.TabIndex = 39
        '
        'TxtStoreID
        '
        Me.TxtStoreID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtStoreID.Enabled = False
        Me.TxtStoreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStoreID.ForeColor = System.Drawing.Color.Black
        Me.TxtStoreID.Location = New System.Drawing.Point(218, 67)
        Me.TxtStoreID.MaxLength = 10
        Me.TxtStoreID.Name = "TxtStoreID"
        Me.TxtStoreID.Size = New System.Drawing.Size(173, 31)
        Me.TxtStoreID.TabIndex = 2
        Me.TxtStoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmDSinformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.beautiful_color_gradient_hues_backgrounds_abdcff_0396ff
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(602, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtStoreID)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDSinformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPassError As System.Windows.Forms.TextBox
    Friend WithEvents LConfirm As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtPassbefore As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtContNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtStoreLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtStoreName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtStoreID As System.Windows.Forms.TextBox
End Class
