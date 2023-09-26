<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnViewRecs = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(12, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(91, 61)
        Me.PicLogo.TabIndex = 5
        Me.PicLogo.TabStop = False
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCalc.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCalc.Location = New System.Drawing.Point(12, 91)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(431, 63)
        Me.BtnCalc.TabIndex = 20
        Me.BtnCalc.Text = "Tax Calculator"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnViewRecs
        '
        Me.BtnViewRecs.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnViewRecs.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnViewRecs.Location = New System.Drawing.Point(12, 160)
        Me.BtnViewRecs.Name = "BtnViewRecs"
        Me.BtnViewRecs.Size = New System.Drawing.Size(431, 63)
        Me.BtnViewRecs.TabIndex = 21
        Me.BtnViewRecs.Text = "View Records"
        Me.BtnViewRecs.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLogOut.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogOut.Location = New System.Drawing.Point(296, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(147, 63)
        Me.BtnLogOut.TabIndex = 22
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 234)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnViewRecs)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "Form4"
        Me.Text = "MainMenu"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnViewRecs As Button
    Friend WithEvents BtnLogOut As Button
End Class
