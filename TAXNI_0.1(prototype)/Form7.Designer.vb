<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblSortRec = New System.Windows.Forms.Label()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.LblAlphabet = New System.Windows.Forms.Label()
        Me.LblSearchRec = New System.Windows.Forms.Label()
        Me.LblByDate = New System.Windows.Forms.Label()
        Me.CombByDate = New System.Windows.Forms.ComboBox()
        Me.CombAlphabet = New System.Windows.Forms.ComboBox()
        Me.LstRecs = New System.Windows.Forms.ListView()
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
        Me.PicLogo.TabIndex = 8
        Me.PicLogo.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtSearch.Location = New System.Drawing.Point(643, 58)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(260, 40)
        Me.TxtSearch.TabIndex = 36
        '
        'LblSortRec
        '
        Me.LblSortRec.AutoSize = True
        Me.LblSortRec.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSortRec.Location = New System.Drawing.Point(247, 12)
        Me.LblSortRec.Name = "LblSortRec"
        Me.LblSortRec.Size = New System.Drawing.Size(218, 34)
        Me.LblSortRec.TabIndex = 35
        Me.LblSortRec.Text = "Sort Records"
        '
        'BtnApply
        '
        Me.BtnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnApply.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnApply.Location = New System.Drawing.Point(108, 165)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(795, 63)
        Me.BtnApply.TabIndex = 37
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = False
        '
        'LblAlphabet
        '
        Me.LblAlphabet.AutoSize = True
        Me.LblAlphabet.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblAlphabet.Location = New System.Drawing.Point(108, 61)
        Me.LblAlphabet.Name = "LblAlphabet"
        Me.LblAlphabet.Size = New System.Drawing.Size(241, 34)
        Me.LblAlphabet.TabIndex = 38
        Me.LblAlphabet.Text = "Alphabetically"
        '
        'LblSearchRec
        '
        Me.LblSearchRec.AutoSize = True
        Me.LblSearchRec.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblSearchRec.Location = New System.Drawing.Point(643, 12)
        Me.LblSearchRec.Name = "LblSearchRec"
        Me.LblSearchRec.Size = New System.Drawing.Size(260, 34)
        Me.LblSearchRec.TabIndex = 39
        Me.LblSearchRec.Text = "Search Records"
        '
        'LblByDate
        '
        Me.LblByDate.AutoSize = True
        Me.LblByDate.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblByDate.Location = New System.Drawing.Point(108, 107)
        Me.LblByDate.Name = "LblByDate"
        Me.LblByDate.Size = New System.Drawing.Size(138, 34)
        Me.LblByDate.TabIndex = 40
        Me.LblByDate.Text = "By Date"
        '
        'CombByDate
        '
        Me.CombByDate.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CombByDate.FormattingEnabled = True
        Me.CombByDate.Location = New System.Drawing.Point(355, 104)
        Me.CombByDate.Name = "CombByDate"
        Me.CombByDate.Size = New System.Drawing.Size(220, 40)
        Me.CombByDate.TabIndex = 41
        '
        'CombAlphabet
        '
        Me.CombAlphabet.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CombAlphabet.FormattingEnabled = True
        Me.CombAlphabet.Location = New System.Drawing.Point(355, 58)
        Me.CombAlphabet.Name = "CombAlphabet"
        Me.CombAlphabet.Size = New System.Drawing.Size(220, 40)
        Me.CombAlphabet.TabIndex = 42
        '
        'LstRecs
        '
        Me.LstRecs.Location = New System.Drawing.Point(108, 234)
        Me.LstRecs.Name = "LstRecs"
        Me.LstRecs.Size = New System.Drawing.Size(795, 374)
        Me.LstRecs.TabIndex = 43
        Me.LstRecs.UseCompatibleStateImageBehavior = False
        '
        'BtnReturn
        '
        Me.BtnReturn.Image = CType(resources.GetObject("BtnReturn.Image"), System.Drawing.Image)
        Me.BtnReturn.Location = New System.Drawing.Point(968, 12)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(51, 51)
        Me.BtnReturn.TabIndex = 46
        Me.BtnReturn.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 620)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.LstRecs)
        Me.Controls.Add(Me.CombAlphabet)
        Me.Controls.Add(Me.CombByDate)
        Me.Controls.Add(Me.LblByDate)
        Me.Controls.Add(Me.LblSearchRec)
        Me.Controls.Add(Me.LblAlphabet)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.LblSortRec)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "Form7"
        Me.Text = "ViewRec"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblSortRec As Label
    Friend WithEvents BtnApply As Button
    Friend WithEvents LblAlphabet As Label
    Friend WithEvents LblSearchRec As Label
    Friend WithEvents LblByDate As Label
    Friend WithEvents CombByDate As ComboBox
    Friend WithEvents CombAlphabet As ComboBox
    Friend WithEvents LstRecs As ListView
    Friend WithEvents BtnReturn As PictureBox
End Class
