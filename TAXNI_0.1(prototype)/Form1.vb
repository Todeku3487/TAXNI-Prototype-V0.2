Public Class Form1
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        Form3.Show()
        Me.Close()
        'closes this window and opens the log in window
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Form2.Show()
        Me.Close()
        'closes this window and opens the create account window
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
