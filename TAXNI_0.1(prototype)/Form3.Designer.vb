<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnLog = New System.Windows.Forms.Button()
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
        Me.PicLogo.TabIndex = 4
        Me.PicLogo.TabStop = False
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPass.Location = New System.Drawing.Point(12, 134)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(169, 34)
        Me.LblPass.TabIndex = 18
        Me.LblPass.Text = "Password"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.Location = New System.Drawing.Point(12, 88)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(176, 34)
        Me.LblUser.TabIndex = 17
        Me.LblUser.Text = "Username"
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtPass.Location = New System.Drawing.Point(223, 131)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(220, 40)
        Me.TxtPass.TabIndex = 16
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtUser.Location = New System.Drawing.Point(223, 85)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(220, 40)
        Me.TxtUser.TabIndex = 15
        '
        'BtnLog
        '
        Me.BtnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLog.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLog.Location = New System.Drawing.Point(12, 189)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(431, 63)
        Me.BtnLog.TabIndex = 19
        Me.BtnLog.Text = "Log In"
        Me.BtnLog.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.Image = CType(resources.GetObject("BtnReturn.Image"), System.Drawing.Image)
        Me.BtnReturn.Location = New System.Drawing.Point(392, 12)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(51, 51)
        Me.BtnReturn.TabIndex = 46
        Me.BtnReturn.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 264)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnLog)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "Form3"
        Me.Text = "LogIn"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblPass As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents BtnLog As Button
    Friend WithEvents BtnReturn As PictureBox
End Class
