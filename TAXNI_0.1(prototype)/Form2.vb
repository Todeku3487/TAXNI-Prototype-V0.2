Imports System.Data
Imports System.Data.OleDb
Imports Microsoft

Public Class Form2
    'declaring all variables to be used in this from
    Dim firstName As String
    Dim sur As String
    Dim email As String
    Dim user As String
    Dim pass As String
    Dim confPass As String

    'declaring access connection variables
    Dim con As New OleDbConnection
    Dim myqry As String = Nothing
    Dim mycmd As New OleDbCommand



    Private Sub BtnCreateAcc_Click(sender As Object, e As EventArgs) Handles BtnCreateAcc.Click
        'assigning all the variables to input boxes
        firstName = TxtName.Text
        sur = TxtSur.Text
        email = TxtEmail.Text
        user = TxtUser.Text
        pass = TxtPass.Text
        confPass = TxtConfPass.Text

        'declaring marker boolean for validation
        Dim Valid As Boolean = False

        If firstName = "" Or sur = "" Or email = "" Or user = "" Or pass = "" Or confPass = "" Then
            MsgBox("All fields must be filled")
            Valid = False
            'complete a presence check on all inputs

        ElseIf pass.Length < 8 Then
            Valid = False
            MsgBox("Invalid entry")
            'check that the password is a desired length

        ElseIf confPass <> pass Then
            Valid = False
            MsgBox("Invalid entry")
            'verifies that the user is aware of what their password is

        Else
            Valid = True
            'most validation checks have been completed

            If email.Contains("@") Then
                Valid = True
                'checks the format of the email is valid

            Else
                Valid = False
                MsgBox("Invalid entry")
                'returns error message if email incorrectly formatted
            End If
            ' the email validation was being a problem child

        End If

        If Valid = True Then
            'sets up qry
            myqry = "INSERT INTO TblUser (Username, [Password], Email) "
            myqry = myqry + "VALUES('" & user & "', '" & pass & "', '" & email & "')"

            'creates command to execute qry
            mycmd = New OleDbCommand
            mycmd.CommandText = myqry
            mycmd.Connection = con
            mycmd.ExecuteNonQuery()
            MsgBox("Account successfully created")

            Form3.Show()
            Me.Close()
            'opens the log in window for the user to enter their log in details

        End If

    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Form1.Show()
        Me.Hide()
        'so the user can return to the log in menu if they accidentally click on the incorrect button
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connects to databse when the window loads
        Call ConnToDb()
    End Sub

    Sub ConnToDb()
        'locates and opens the database
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\erinr\OneDrive\Desktop\School\Comp Sci\TAXNI_0.1(prototype)\TAXNI_0.1(prototype)\bin\Debug\DatTAXNIx.accdb"
            con.Open()
        Catch ex As Exception
            MsgBox("Unable to establish connection to database")
        End Try
    End Sub
End Class