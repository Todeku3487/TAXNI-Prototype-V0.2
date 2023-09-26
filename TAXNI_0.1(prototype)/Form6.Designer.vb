<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblGross = New System.Windows.Forms.Label()
        Me.LblTaxDed = New System.Windows.Forms.Label()
        Me.LblNIDed = New System.Windows.Forms.Label()
        Me.LblNet = New System.Windows.Forms.Label()
        Me.LblDatePaid = New System.Windows.Forms.Label()
        Me.LblPayer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNIDed = New System.Windows.Forms.TextBox()
        Me.TxtTaxDed = New System.Windows.Forms.TextBox()
        Me.TxtGross = New System.Windows.Forms.TextBox()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.TxtDatePaid = New System.Windows.Forms.TextBox()
        Me.TxtPayer = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
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
        Me.PicLogo.TabIndex = 7
        Me.PicLogo.TabStop = False
        '
        'LblGross
        '
        Me.LblGross.AutoSize = True
        Me.LblGross.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblGross.Location = New System.Drawing.Point(12, 92)
        Me.LblGross.Name = "LblGross"
        Me.LblGross.Size = New System.Drawing.Size(234, 34)
        Me.LblGross.TabIndex = 17
        Me.LblGross.Text = "Gross Income"
        '
        'LblTaxDed
        '
        Me.LblTaxDed.AutoSize = True
        Me.LblTaxDed.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTaxDed.Location = New System.Drawing.Point(12, 138)
        Me.LblTaxDed.Name = "LblTaxDed"
        Me.LblTaxDed.Size = New System.Drawing.Size(242, 34)
        Me.LblTaxDed.TabIndex = 18
        Me.LblTaxDed.Text = "Tax Deduction"
        '
        'LblNIDed
        '
        Me.LblNIDed.AutoSize = True
        Me.LblNIDed.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNIDed.Location = New System.Drawing.Point(12, 184)
        Me.LblNIDed.Name = "LblNIDed"
        Me.LblNIDed.Size = New System.Drawing.Size(224, 34)
        Me.LblNIDed.TabIndex = 19
        Me.LblNIDed.Text = "NI Deduction"
        '
        'LblNet
        '
        Me.LblNet.AutoSize = True
        Me.LblNet.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNet.Location = New System.Drawing.Point(12, 230)
        Me.LblNet.Name = "LblNet"
        Me.LblNet.Size = New System.Drawing.Size(139, 34)
        Me.LblNet.TabIndex = 20
        Me.LblNet.Text = "Net Pay"
        '
        'LblDatePaid
        '
        Me.LblDatePaid.AutoSize = True
        Me.LblDatePaid.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDatePaid.Location = New System.Drawing.Point(12, 276)
        Me.LblDatePaid.Name = "LblDatePaid"
        Me.LblDatePaid.Size = New System.Drawing.Size(169, 34)
        Me.LblDatePaid.TabIndex = 21
        Me.LblDatePaid.Text = "Date Paid"
        '
        'LblPayer
        '
        Me.LblPayer.AutoSize = True
        Me.LblPayer.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPayer.Location = New System.Drawing.Point(12, 322)
        Me.LblPayer.Name = "LblPayer"
        Me.LblPayer.Size = New System.Drawing.Size(106, 34)
        Me.LblPayer.TabIndex = 22
        Me.LblPayer.Text = "Payer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(385, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 34)
        Me.Label6.TabIndex = 23
        '
        'TxtNIDed
        '
        Me.TxtNIDed.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtNIDed.Location = New System.Drawing.Point(277, 181)
        Me.TxtNIDed.Name = "TxtNIDed"
        Me.TxtNIDed.Size = New System.Drawing.Size(220, 40)
        Me.TxtNIDed.TabIndex = 27
        '
        'TxtTaxDed
        '
        Me.TxtTaxDed.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtTaxDed.Location = New System.Drawing.Point(277, 135)
        Me.TxtTaxDed.Name = "TxtTaxDed"
        Me.TxtTaxDed.Size = New System.Drawing.Size(220, 40)
        Me.TxtTaxDed.TabIndex = 26
        '
        'TxtGross
        '
        Me.TxtGross.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtGross.Location = New System.Drawing.Point(277, 89)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.Size = New System.Drawing.Size(220, 40)
        Me.TxtGross.TabIndex = 25
        '
        'TxtNet
        '
        Me.TxtNet.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtNet.Location = New System.Drawing.Point(277, 227)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(220, 40)
        Me.TxtNet.TabIndex = 28
        '
        'TxtDatePaid
        '
        Me.TxtDatePaid.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtDatePaid.Location = New System.Drawing.Point(277, 273)
        Me.TxtDatePaid.Name = "TxtDatePaid"
        Me.TxtDatePaid.Size = New System.Drawing.Size(220, 40)
        Me.TxtDatePaid.TabIndex = 29
        '
        'TxtPayer
        '
        Me.TxtPayer.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtPayer.Location = New System.Drawing.Point(277, 319)
        Me.TxtPayer.Name = "TxtPayer"
        Me.TxtPayer.Size = New System.Drawing.Size(220, 40)
        Me.TxtPayer.TabIndex = 30
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSave.Location = New System.Drawing.Point(263, 379)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(234, 63)
        Me.BtnSave.TabIndex = 33
        Me.BtnSave.Text = "Save Result"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnMenu.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMenu.Location = New System.Drawing.Point(12, 379)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(234, 63)
        Me.BtnMenu.TabIndex = 34
        Me.BtnMenu.Text = "Main Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.Image = CType(resources.GetObject("BtnReturn.Image"), System.Drawing.Image)
        Me.BtnReturn.Location = New System.Drawing.Point(452, 12)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(51, 51)
        Me.BtnReturn.TabIndex = 46
        Me.BtnReturn.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 453)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtPayer)
        Me.Controls.Add(Me.TxtDatePaid)
        Me.Controls.Add(Me.TxtNet)
        Me.Controls.Add(Me.TxtNIDed)
        Me.Controls.Add(Me.TxtTaxDed)
        Me.Controls.Add(Me.TxtGross)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblPayer)
        Me.Controls.Add(Me.LblDatePaid)
        Me.Controls.Add(Me.LblNet)
        Me.Controls.Add(Me.LblNIDed)
        Me.Controls.Add(Me.LblTaxDed)
        Me.Controls.Add(Me.LblGross)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.BtnMenu)
        Me.Name = "Form6"
        Me.Text = "TaxResults"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblGross As Label
    Friend WithEvents LblTaxDed As Label
    Friend WithEvents LblNIDed As Label
    Friend WithEvents LblNet As Label
    Friend WithEvents LblDatePaid As Label
    Friend WithEvents LblPayer As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNIDed As TextBox
    Friend WithEvents TxtTaxDed As TextBox
    Friend WithEvents TxtGross As TextBox
    Friend WithEvents TxtNet As TextBox
    Friend WithEvents TxtDatePaid As TextBox
    Friend WithEvents TxtPayer As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnReturn As PictureBox
End Class
