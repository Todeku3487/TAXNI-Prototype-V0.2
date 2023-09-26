<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnLog = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLog
        '
        Me.BtnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLog.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLog.Location = New System.Drawing.Point(10, 59)
        Me.BtnLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(333, 47)
        Me.BtnLog.TabIndex = 0
        Me.BtnLog.Text = "Log In"
        Me.BtnLog.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCreate.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.Location = New System.Drawing.Point(10, 111)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(333, 50)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "Create Account"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(10, 9)
        Me.PicLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(80, 46)
        Me.PicLogo.TabIndex = 2
        Me.PicLogo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 170)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnLog)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "LogMenu"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLog As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents PicLogo As PictureBox
End Class
