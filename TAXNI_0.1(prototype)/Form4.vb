Public Class Form4
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        'returns to starting page
        Globals.userID = Nothing
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        'opens the tax calculator
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub BtnViewRecs_Click(sender As Object, e As EventArgs) Handles BtnViewRecs.Click
        'opens the view records window
        Form7.Show()
        Me.Close()
    End Sub
End Class