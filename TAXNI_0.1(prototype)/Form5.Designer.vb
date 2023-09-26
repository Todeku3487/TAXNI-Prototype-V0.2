<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblDatePaid = New System.Windows.Forms.Label()
        Me.LblPayer = New System.Windows.Forms.Label()
        Me.LblPayFreq = New System.Windows.Forms.Label()
        Me.LblSal = New System.Windows.Forms.Label()
        Me.TxtPayer = New System.Windows.Forms.TextBox()
        Me.TxtSal = New System.Windows.Forms.TextBox()
        Me.TxtHrWork = New System.Windows.Forms.TextBox()
        Me.LblHrWork = New System.Windows.Forms.Label()
        Me.TxtHrPay = New System.Windows.Forms.TextBox()
        Me.LblHrPay = New System.Windows.Forms.Label()
        Me.ChkSal = New System.Windows.Forms.CheckBox()
        Me.ChkHr = New System.Windows.Forms.CheckBox()
        Me.CombPayFreq = New System.Windows.Forms.ComboBox()
        Me.DTPDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.BtnCalc = New System.Windows.Forms.Button()
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
        Me.PicLogo.TabIndex = 6
        Me.PicLogo.TabStop = False
        '
        'LblDatePaid
        '
        Me.LblDatePaid.AutoSize = True
        Me.LblDatePaid.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDatePaid.Location = New System.Drawing.Point(12, 322)
        Me.LblDatePaid.Name = "LblDatePaid"
        Me.LblDatePaid.Size = New System.Drawing.Size(169, 34)
        Me.LblDatePaid.TabIndex = 27
        Me.LblDatePaid.Text = "Date Paid"
        '
        'LblPayer
        '
        Me.LblPayer.AutoSize = True
        Me.LblPayer.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPayer.Location = New System.Drawing.Point(12, 273)
        Me.LblPayer.Name = "LblPayer"
        Me.LblPayer.Size = New System.Drawing.Size(106, 34)
        Me.LblPayer.TabIndex = 26
        Me.LblPayer.Text = "Payer"
        '
        'LblPayFreq
        '
        Me.LblPayFreq.AutoSize = True
        Me.LblPayFreq.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPayFreq.Location = New System.Drawing.Point(12, 227)
        Me.LblPayFreq.Name = "LblPayFreq"
        Me.LblPayFreq.Size = New System.Drawing.Size(304, 34)
        Me.LblPayFreq.TabIndex = 25
        Me.LblPayFreq.Text = "Payslip Frequency"
        '
        'LblSal
        '
        Me.LblSal.AutoSize = True
        Me.LblSal.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSal.Location = New System.Drawing.Point(12, 181)
        Me.LblSal.Name = "LblSal"
        Me.LblSal.Size = New System.Drawing.Size(115, 34)
        Me.LblSal.TabIndex = 24
        Me.LblSal.Text = "Salary"
        '
        'TxtPayer
        '
        Me.TxtPayer.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtPayer.Location = New System.Drawing.Point(375, 270)
        Me.TxtPayer.Name = "TxtPayer"
        Me.TxtPayer.Size = New System.Drawing.Size(220, 40)
        Me.TxtPayer.TabIndex = 22
        '
        'TxtSal
        '
        Me.TxtSal.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtSal.Location = New System.Drawing.Point(375, 178)
        Me.TxtSal.Name = "TxtSal"
        Me.TxtSal.Size = New System.Drawing.Size(220, 40)
        Me.TxtSal.TabIndex = 20
        '
        'TxtHrWork
        '
        Me.TxtHrWork.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtHrWork.Location = New System.Drawing.Point(375, 132)
        Me.TxtHrWork.Name = "TxtHrWork"
        Me.TxtHrWork.Size = New System.Drawing.Size(220, 40)
        Me.TxtHrWork.TabIndex = 19
        '
        'LblHrWork
        '
        Me.LblHrWork.AutoSize = True
        Me.LblHrWork.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHrWork.Location = New System.Drawing.Point(12, 135)
        Me.LblHrWork.Name = "LblHrWork"
        Me.LblHrWork.Size = New System.Drawing.Size(241, 34)
        Me.LblHrWork.TabIndex = 18
        Me.LblHrWork.Text = "Hours Worked"
        '
        'TxtHrPay
        '
        Me.TxtHrPay.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtHrPay.Location = New System.Drawing.Point(375, 86)
        Me.TxtHrPay.Name = "TxtHrPay"
        Me.TxtHrPay.Size = New System.Drawing.Size(220, 40)
        Me.TxtHrPay.TabIndex = 17
        '
        'LblHrPay
        '
        Me.LblHrPay.AutoSize = True
        Me.LblHrPay.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHrPay.Location = New System.Drawing.Point(12, 89)
        Me.LblHrPay.Name = "LblHrPay"
        Me.LblHrPay.Size = New System.Drawing.Size(187, 34)
        Me.LblHrPay.TabIndex = 16
        Me.LblHrPay.Text = "Hourly Pay"
        '
        'ChkSal
        '
        Me.ChkSal.AutoSize = True
        Me.ChkSal.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChkSal.Location = New System.Drawing.Point(123, 25)
        Me.ChkSal.Name = "ChkSal"
        Me.ChkSal.Size = New System.Drawing.Size(137, 38)
        Me.ChkSal.TabIndex = 28
        Me.ChkSal.Text = "Salary"
        Me.ChkSal.UseVisualStyleBackColor = True
        '
        'ChkHr
        '
        Me.ChkHr.AutoSize = True
        Me.ChkHr.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChkHr.Location = New System.Drawing.Point(266, 25)
        Me.ChkHr.Name = "ChkHr"
        Me.ChkHr.Size = New System.Drawing.Size(209, 38)
        Me.ChkHr.TabIndex = 29
        Me.ChkHr.Text = "Hourly Pay"
        Me.ChkHr.UseVisualStyleBackColor = True
        '
        'CombPayFreq
        '
        Me.CombPayFreq.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CombPayFreq.FormattingEnabled = True
        Me.CombPayFreq.Items.AddRange(New Object() {"Weekly", "Fortnight", "Monthy"})
        Me.CombPayFreq.Location = New System.Drawing.Point(375, 224)
        Me.CombPayFreq.Name = "CombPayFreq"
        Me.CombPayFreq.Size = New System.Drawing.Size(220, 40)
        Me.CombPayFreq.TabIndex = 30
        '
        'DTPDatePaid
        '
        Me.DTPDatePaid.CalendarFont = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DTPDatePaid.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DTPDatePaid.Location = New System.Drawing.Point(266, 316)
        Me.DTPDatePaid.Name = "DTPDatePaid"
        Me.DTPDatePaid.Size = New System.Drawing.Size(329, 40)
        Me.DTPDatePaid.TabIndex = 31
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCalc.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCalc.Location = New System.Drawing.Point(12, 375)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(583, 63)
        Me.BtnCalc.TabIndex = 32
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.Image = CType(resources.GetObject("BtnReturn.Image"), System.Drawing.Image)
        Me.BtnReturn.Location = New System.Drawing.Point(541, 12)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(51, 51)
        Me.BtnReturn.TabIndex = 45
        Me.BtnReturn.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.DTPDatePaid)
        Me.Controls.Add(Me.CombPayFreq)
        Me.Controls.Add(Me.ChkHr)
        Me.Controls.Add(Me.ChkSal)
        Me.Controls.Add(Me.LblDatePaid)
        Me.Controls.Add(Me.LblPayer)
        Me.Controls.Add(Me.LblPayFreq)
        Me.Controls.Add(Me.LblSal)
        Me.Controls.Add(Me.TxtPayer)
        Me.Controls.Add(Me.TxtSal)
        Me.Controls.Add(Me.TxtHrWork)
        Me.Controls.Add(Me.LblHrWork)
        Me.Controls.Add(Me.TxtHrPay)
        Me.Controls.Add(Me.LblHrPay)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "Form5"
        Me.Text = "TaxCalc"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblDatePaid As Label
    Friend WithEvents LblPayer As Label
    Friend WithEvents LblPayFreq As Label
    Friend WithEvents LblSal As Label
    Friend WithEvents TxtPayer As TextBox
    Friend WithEvents TxtSal As TextBox
    Friend WithEvents TxtHrWork As TextBox
    Friend WithEvents LblHrWork As Label
    Friend WithEvents TxtHrPay As TextBox
    Friend WithEvents LblHrPay As Label
    Friend WithEvents ChkSal As CheckBox
    Friend WithEvents ChkHr As CheckBox
    Friend WithEvents CombPayFreq As ComboBox
    Friend WithEvents DTPDatePaid As DateTimePicker
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnReturn As PictureBox
End Class
