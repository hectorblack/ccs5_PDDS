<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateDS))
        Me.CnclBttn = New System.Windows.Forms.Button()
        Me.UpdBttn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrgStrPass = New System.Windows.Forms.TextBox()
        Me.DrgStrCont = New System.Windows.Forms.TextBox()
        Me.DrgStrOwn = New System.Windows.Forms.TextBox()
        Me.DrgStrLoc = New System.Windows.Forms.TextBox()
        Me.DrgStrName = New System.Windows.Forms.TextBox()
        Me.DrgStrID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CnclBttn
        '
        Me.CnclBttn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CnclBttn.FlatAppearance.BorderSize = 0
        Me.CnclBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CnclBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnclBttn.ForeColor = System.Drawing.Color.Black
        Me.CnclBttn.Location = New System.Drawing.Point(32, 424)
        Me.CnclBttn.Name = "CnclBttn"
        Me.CnclBttn.Size = New System.Drawing.Size(330, 27)
        Me.CnclBttn.TabIndex = 27
        Me.CnclBttn.Text = "CANCEL"
        Me.CnclBttn.UseVisualStyleBackColor = False
        '
        'UpdBttn
        '
        Me.UpdBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.UpdBttn.FlatAppearance.BorderSize = 0
        Me.UpdBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdBttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdBttn.ForeColor = System.Drawing.Color.White
        Me.UpdBttn.Location = New System.Drawing.Point(32, 391)
        Me.UpdBttn.Name = "UpdBttn"
        Me.UpdBttn.Size = New System.Drawing.Size(330, 27)
        Me.UpdBttn.TabIndex = 26
        Me.UpdBttn.Text = "UPDATE"
        Me.UpdBttn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Drug Store Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Drug Store Contact Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Drug Store Owner"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Drug Store Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Drug Store Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Drug Store ID"
        '
        'DrgStrPass
        '
        Me.DrgStrPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrPass.Location = New System.Drawing.Point(32, 334)
        Me.DrgStrPass.Name = "DrgStrPass"
        Me.DrgStrPass.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrPass.TabIndex = 19
        '
        'DrgStrCont
        '
        Me.DrgStrCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrCont.Location = New System.Drawing.Point(32, 274)
        Me.DrgStrCont.Name = "DrgStrCont"
        Me.DrgStrCont.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrCont.TabIndex = 18
        '
        'DrgStrOwn
        '
        Me.DrgStrOwn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrOwn.Location = New System.Drawing.Point(32, 107)
        Me.DrgStrOwn.Name = "DrgStrOwn"
        Me.DrgStrOwn.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrOwn.TabIndex = 17
        '
        'DrgStrLoc
        '
        Me.DrgStrLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrLoc.Location = New System.Drawing.Point(32, 216)
        Me.DrgStrLoc.Name = "DrgStrLoc"
        Me.DrgStrLoc.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrLoc.TabIndex = 16
        '
        'DrgStrName
        '
        Me.DrgStrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrName.Location = New System.Drawing.Point(32, 160)
        Me.DrgStrName.Name = "DrgStrName"
        Me.DrgStrName.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrName.TabIndex = 15
        '
        'DrgStrID
        '
        Me.DrgStrID.BackColor = System.Drawing.Color.White
        Me.DrgStrID.Enabled = False
        Me.DrgStrID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrgStrID.Location = New System.Drawing.Point(32, 48)
        Me.DrgStrID.Name = "DrgStrID"
        Me.DrgStrID.ReadOnly = True
        Me.DrgStrID.Size = New System.Drawing.Size(330, 22)
        Me.DrgStrID.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UpdBttn)
        Me.Panel1.Controls.Add(Me.CnclBttn)
        Me.Panel1.Controls.Add(Me.DrgStrOwn)
        Me.Panel1.Controls.Add(Me.DrgStrID)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DrgStrName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DrgStrLoc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DrgStrCont)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DrgStrPass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(109, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 487)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.beautiful_color_gradient_hues_backgrounds_abdcff_0396ff
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-8, -22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(632, 715)
        Me.Panel2.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(227, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "UPDATE CLIENT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmUpdateDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(616, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CnclBttn As System.Windows.Forms.Button
    Friend WithEvents UpdBttn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrgStrPass As System.Windows.Forms.TextBox
    Friend WithEvents DrgStrCont As System.Windows.Forms.TextBox
    Friend WithEvents DrgStrOwn As System.Windows.Forms.TextBox
    Friend WithEvents DrgStrLoc As System.Windows.Forms.TextBox
    Friend WithEvents DrgStrName As System.Windows.Forms.TextBox
    Friend WithEvents DrgStrID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
