Imports System.IO

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' // Check all users we have and if a match is found, store data & let them order.
        Dim LoginStatus As Boolean = 0
        Dim readUsers() As String = File.ReadAllLines("Users.txt")
        Dim User As String
        For Each User In readUsers
            Dim thisUser As String() = Split(User, ",")
            If thisUser(2) = txtEmail.Text And thisUser(3) = txtPassword.Text Then
                UserDetails.ID = thisUser(0)
                UserDetails.Name = thisUser(1)
                UserDetails.Email = thisUser(2)
                UserDetails.PhoneNo = thisUser(3)
                UserDetails.Address = thisUser(4)
                UserDetails.Postcode = thisUser(5)
                LoginStatus = 1

                ClassicOrder.Show()
                Me.Hide()
                ' // debug
                StaffView.Show()
                Exit For
            End If
        Next

        If LoginStatus = 0 Then
            MsgBox("Couldn't login. Please double check your entered details.")
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' // Check user has entered all required info, and if so register them.
        If txtRegisterName.Text = "" Or txtRegisterAddress.Text = "" Or txtRegisterEmail.Text = "" Or txtRegisterPassword.Text = "" Or txtRegisterPhoneNo.Text = "" Or txtRegisterPostcode.Text = "" Then
            MsgBox("Something is wrong with your entered information :(")
        Else
            Dim newID As Integer = File.ReadAllLines("Users.txt").Length + 1
            Dim newName As String = txtRegisterName.Text
            Dim newEmail As String = txtRegisterEmail.Text
            Dim newPassword As String = txtRegisterPassword.Text
            Dim newPhoneNo As String = txtRegisterPhoneNo.Text
            Dim newAddress As String = txtRegisterAddress.Text
            Dim newPostcode As String = txtRegisterPostcode.Text
            File.AppendAllText("Users.txt", newID & "," & newName & "," & newEmail & "," & newPassword & "," & newPhoneNo & "," & newAddress & "," & newPostcode + Environment.NewLine)
            MsgBox("You've been sucessfully registered at Dominos. Get yourself a pizza to celebrate.")
        End If

        txtRegisterName.Clear()
        txtRegisterEmail.Clear()
        txtRegisterPassword.Clear()
        txtRegisterAddress.Clear()
        txtRegisterPostcode.Clear()
        txtRegisterPhoneNo.Clear()
    End Sub
End Class