Imports System.IO

Public Class StaffView

    Private takings As Decimal

    Private Sub StaffView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        staffWelcomeDetails.Text = "Welcome to the Dominos system management screen, " & UserDetails.Name & "."
        getOrders()
        getUsers()
    End Sub

    Private Sub getOrders()
        ordersDataGridView.Rows.Clear()
        takings = 0

        Dim readText() As String = File.ReadAllLines("Orders.txt")
        Dim fileContent As String
        ordersPlaced.Text = "Orders Placed (" & readText.Count & " in total)"

        For Each fileContent In readText
            Dim order As String() = Split(fileContent, ",")

            Dim orderDrinks As String
            If order(3) <> 0 Then orderDrinks = orderDrinks & "Coke: " & order(3)
            If order(4) <> 0 Then orderDrinks = orderDrinks & " Diet Coke: " & order(4)
            If order(5) <> 0 Then orderDrinks = orderDrinks & " Coke Zero: " & order(5)
            If order(6) <> 0 Then orderDrinks = orderDrinks & " Smartwater: " & order(6)
            If order(7) <> 0 Then orderDrinks = orderDrinks & " Fanta: " & order(7)
            Dim spriteQuantity As String = order(8).Chars(0)
            If spriteQuantity <> 0 Then orderDrinks = orderDrinks & " Sprite: " & spriteQuantity
            If order(3) + order(4) + order(5) + order(6) + order(7) + spriteQuantity = 0 Then orderDrinks = "None."

            Dim orderSides As String
            If order(9) <> 0 Then orderSides = orderSides & " Meltin' Meatballs: " & order(9)
            If order(10) <> 0 Then orderSides = orderSides & " Garlic Pizza Bread: " & order(10)
            If order(11) <> 0 Then orderSides = orderSides & " Potato Wedges: " & order(11)
            Dim chicknmixboxQuantity As String = order(12).Chars(0)
            If chicknmixboxQuantity <> 0 Then orderSides = orderSides & " Chick 'n' Mix Box: " & chicknmixboxQuantity
            If order(9) + order(10) + order(11) + chicknmixboxQuantity = 0 Then orderSides = "None."

            Dim orderDips As String
            If order(13) <> 0 Then orderDips = orderDips & " Random: " & order(13)
            If order(14) <> 0 Then orderDips = orderDips & " Big Garlic: " & order(14)
            If order(15) <> 0 Then orderDips = orderDips & " Big BBQ: " & order(15)
            If order(16) <> 0 Then orderDips = orderDips & " FRANK's: " & order(16)
            If order(17) <> 0 Then orderDips = orderDips & " Chili Infused Oil: " & order(17)
            If order(13) + order(14) + order(15) + order(16) + order(17) = 0 Then orderDips = "None."

            ordersDataGridView.Rows.Add(order(0), order(1), orderDrinks, orderSides, orderDips, order(18))
            orderDrinks = ""
            orderSides = ""
            orderDips = ""
            takings = takings + order(18).Remove(0, 1)
        Next

        totalTakings.Text = "Total Takings: " & "£" & takings
    End Sub

    Private Sub getUsers()
        usersDataGridView.Rows.Clear()

        Dim LoginStatus As Boolean = 0
        Dim readUsers() As String = File.ReadAllLines("Users.txt")
        Dim User As String
        For Each User In readUsers
            Dim thisUser As String() = Split(User, ",")
            usersDataGridView.Rows.Add(thisUser(0), thisUser(1), thisUser(2), thisUser(5), thisUser(6), thisUser(4))
        Next
    End Sub

    Private Sub ordersRefresh_Click(sender As Object, e As EventArgs) Handles ordersRefresh.Click
        getOrders()
    End Sub

    Private Sub usersRefresh_Click(sender As Object, e As EventArgs) Handles usersRefresh.Click
        getUsers()
    End Sub
End Class