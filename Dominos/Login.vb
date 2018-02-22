Imports System.IO

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' // Get a list of all accepted user/pass combos.
        FileOpen(1, "Users.txt", OpenMode.Input)
        Dim CurrentID As String
        Dim CurrentName As String
        Dim CurrentPassword As String
        Dim CurrentEmail As String
        Dim CurrentPhoneNo As String
        Dim CurrentAddress As String
        Dim CurrentPostcode As String
        Dim LoginStatus As Boolean = 0

        Do While Not EOF(1)
            Input(1, CurrentID)
            Input(1, CurrentName)
            Input(1, CurrentPassword)
            Input(1, CurrentEmail)
            Input(1, CurrentPhoneNo)
            Input(1, CurrentAddress)
            Input(1, CurrentPostcode)
            ' // take txtEmail and txtPassword and check for match! :D
            If txtEmail.Text = CurrentEmail And txtPassword.Text = CurrentPassword Then
                UserDetails.ID = CurrentID
                UserDetails.Name = CurrentName
                UserDetails.Email = CurrentEmail
                UserDetails.PhoneNo = CurrentPhoneNo
                UserDetails.Address = CurrentAddress
                UserDetails.Postcode = CurrentPostcode

                LoginStatus = 1
                ClassicOrder.Show()
                Me.Hide()
                FileClose()

                ' // debug
                StaffView.Show()

                Exit Do
            End If
        Loop

        If LoginStatus = 0 Then
            MsgBox("Couldn't login. Please double check your entered details.")
        End If
        FileClose()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtRegisterName.Text = "" Or txtRegisterAddress.Text = "" Or txtRegisterEmail.Text = "" Or txtRegisterPassword.Text = "" Or txtRegisterPhone.Text = "" Or txtRegisterPostcode.Text = "" Then
            MsgBox("Something is wrong with your entered information :(")
        Else
            Dim newID As Integer = File.ReadAllLines("Users.txt").Length + 1
            FileOpen(1, "Users.txt", OpenMode.Append)
            Dim newName As String = txtRegisterName.Text
            Dim newEmail As String = txtRegisterEmail.Text
            Dim newPassword As String = txtRegisterPassword.Text
            Dim newPhoneNo As String = txtRegisterPhone.Text
            Dim newAddress As String = txtRegisterAddress.Text
            Dim newPostcode As String = txtRegisterPostcode.Text
            WriteLine(1, newID, newName, newPassword, newEmail, newPhoneNo, newAddress, newPostcode)
            FileClose()
            MsgBox("You've been sucessfully registered at Dominos. Get yourself a pizza to celebrate.")
        End If

    End Sub
End Class