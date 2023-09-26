<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblSur = New System.Windows.Forms.Label()
        Me.TxtSur = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtConfPass = New System.Windows.Forms.TextBox()
        Me.LblEamil = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblConfPass = New System.Windows.Forms.Label()
        Me.BtnCreateAcc = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.PictureBox()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(12, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(91, 61)
        Me.PicLogo.TabIndex = 3
        Me.PicLogo.TabStop = False
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblName.Location = New System.Drawing.Point(12, 79)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(107, 34)
        Me.LblName.TabIndex = 4
        Me.LblName.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtName.Location = New System.Drawing.Point(324, 76)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(220, 40)
        Me.TxtName.TabIndex = 5
        '
        'LblSur
        '
        Me.LblSur.AutoSize = True
        Me.LblSur.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSur.Location = New System.Drawing.Point(12, 125)
        Me.LblSur.Name = "LblSur"
        Me.LblSur.Size = New System.Drawing.Size(157, 34)
        Me.LblSur.TabIndex = 6
        Me.LblSur.Text = "Surname"
        '
        'TxtSur
        '
        Me.TxtSur.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtSur.Location = New System.Drawing.Point(324, 122)
        Me.TxtSur.Name = "TxtSur"
        Me.TxtSur.Size = New System.Drawing.Size(220, 40)
        Me.TxtSur.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtEmail.Location = New System.Drawing.Point(324, 168)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(220, 40)
        Me.TxtEmail.TabIndex = 8
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtUser.Location = New System.Drawing.Point(324, 214)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(220, 40)
        Me.TxtUser.TabIndex = 9
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtPass.Location = New System.Drawing.Point(324, 260)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(220, 40)
        Me.TxtPass.TabIndex = 10
        '
        'TxtConfPass
        '
        Me.TxtConfPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtConfPass.Location = New System.Drawing.Point(324, 306)
        Me.TxtConfPass.Name = "TxtConfPass"
        Me.TxtConfPass.Size = New System.Drawing.Size(220, 40)
        Me.TxtConfPass.TabIndex = 11
        '
        'LblEamil
        '
        Me.LblEamil.AutoSize = True
        Me.LblEamil.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEamil.Location = New System.Drawing.Point(12, 171)
        Me.LblEamil.Name = "LblEamil"
        Me.LblEamil.Size = New System.Drawing.Size(103, 34)
        Me.LblEamil.TabIndex = 12
        Me.LblEamil.Text = "Email"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.Location = New System.Drawing.Point(12, 217)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(176, 34)
        Me.LblUser.TabIndex = 13
        Me.LblUser.Text = "Username"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPass.Location = New System.Drawing.Point(12, 263)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(169, 34)
        Me.LblPass.TabIndex = 14
        Me.LblPass.Text = "Password"
        '
        'LblConfPass
        '
        Me.LblConfPass.AutoSize = True
        Me.LblConfPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblConfPass.Location = New System.Drawing.Point(12, 309)
        Me.LblConfPass.Name = "LblConfPass"
        Me.LblConfPass.Size = New System.Drawing.Size(304, 34)
        Me.LblConfPass.TabIndex = 15
        Me.LblConfPass.Text = "Confirm Password"
        '
        'BtnCreateAcc
        '
        Me.BtnCreateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCreateAcc.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreateAcc.Location = New System.Drawing.Point(12, 372)
        Me.BtnCreateAcc.Name = "BtnCreateAcc"
        Me.BtnCreateAcc.Size = New System.Drawing.Size(532, 66)
        Me.BtnCreateAcc.TabIndex = 16
        Me.BtnCreateAcc.Text = "Create Account"
        Me.BtnCreateAcc.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.Image = CType(resources.GetObject("BtnReturn.Image"), System.Drawing.Image)
        Me.BtnReturn.Location = New System.Drawing.Point(493, 12)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(51, 51)
        Me.BtnReturn.TabIndex = 46
        Me.BtnReturn.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 450)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnCreateAcc)
        Me.Controls.Add(Me.LblConfPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.LblEamil)
        Me.Controls.Add(Me.TxtConfPass)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtSur)
        Me.Controls.Add(Me.LblSur)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "Form2"
        Me.Text = "CreateAcc"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblSur As Label
    Friend WithEvents TxtSur As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtConfPass As TextBox
    Friend WithEvents LblEamil As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents LblConfPass As Label
    Friend WithEvents BtnCreateAcc As Button
    Friend WithEvents BtnReturn As PictureBox
End Class
