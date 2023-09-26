Imports System.Data
Imports System.Data.OleDb
Imports Microsoft

Public Class Form3
    'declaring access connection variables
    Dim con As New OleDbConnection
    Dim myqry As String = Nothing
    Dim mycmd As New OleDbCommand

    Sub ConnToDb()
        'locates and opens the database
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\erinr\OneDrive\Desktop\School\Comp Sci\TAXNI_0.1(prototype)\TAXNI_0.1(prototype)\bin\Debug\DatTAXNIx.accdb"
            con.Open()
        Catch ex As Exception
            'if the database won't open
            MsgBox("Unable to establish connection to database")
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the databse when you open the software
        Call ConnToDb()
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        'assigns inputs to variables
        Dim user As String = TxtUser.Text
        Dim pass As String = TxtPass.Text

        If user = "" Or pass = "" Then
            MsgBox("All fields must be filled")
            'presence check for input fields
        Else
            'verifies username and password
            myqry = "SELECT * FROM TblUser WHERE Username = '" & user & "' AND Password = '" & pass & "'"
            mycmd = New OleDbCommand
            mycmd.CommandText = myqry
            mycmd.Connection = con
            If mycmd.ExecuteScalar() Then
                MsgBox("Welcome")
                Globals.userID = user
                Form4.Show()
                Me.Close()

            Else
                'error message if user not found in the database
                MsgBox("Details incorrect")
            End If
        End If
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        'goes back to the log in menu
        Form1.Show()
        Me.Close()
    End Sub
End Class