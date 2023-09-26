Public Class Form5
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        'returns to main menu
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        'delcaring variables
        Dim hrpay As Double = TxtHrPay.Text
        Dim hrwork As Double = TxtHrWork.Text
        Dim salary As Double = TxtSal.Text
        Dim freq As String = CombPayFreq.SelectedItem
        Dim payer As String = TxtPayer.Text
        Dim datepaid As String = DTPDatePaid.Text
        Dim salCalc As Boolean = ChkSal.Checked
        Dim hrCalc As Boolean = ChkHr.Checked
        Dim valid As Boolean = False


        If Str(hrpay) = "" Or Str(hrwork) = "" Or Str(salary) = "" Or freq = "" Or payer = "" Or datepaid = "" Then
            MsgBox("all fields need to be filled")
            valid = False
            'presence check

        ElseIf (salCalc = True And hrCalc = True) Or (salCalc = False And hrCalc = False) Then
            MsgBox("chose either salary or hourly calculation")
            valid = False
            'ensures that only one box is checked

        End If

    End Sub
End Class