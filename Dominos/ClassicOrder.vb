Imports System.IO

Public Class ClassicOrder

    Private selectedTopping As String = "Original Cheese and Tomato"
    Private selectedSize As String = "Large"
    Private selectedCrust As String = "Classic"
    Private selectedBase As String = "Tomato"

    Private pizzaPrice As Decimal = 14.99
    Private crustPrice As Decimal
    Private drinkPrice As Decimal
    Private sidesPrice As Decimal
    Private dipsPrice As Decimal

    Private pizzaCount As Integer = 0 ' // Stores the quantity of all pizza(s).
    Private orderedPizzaTotal As Decimal = 14.99 ' // Stores the cost of all pizza(s).
    Private orderTotal As Decimal ' // Stores the total cost of the order when placing.
    Private discountApplied As Boolean = False ' // Stores discount state.

    ' ==========================================================================
    ' GLOBAL
    ' ==========================================================================

    ' Set sides = none selected @ start-up.
    Private Sub Dominos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sideMeatballs.SelectedIndex = 0
        sideGarlicBread.SelectedIndex = 0
        sideWedges.SelectedIndex = 0
        sideChickenMixBox.SelectedIndex = 0

        ' Utilize user details.
        welcomeDetails.Text = "Welcome back, " & UserDetails.Name & ". Time for a pizza."

        ' Push default selection to order tracking.
        pizzaCount = 0
        ReDim Preserve CurrentOrder.Pizzas(pizzaCount)
        CurrentOrder.Pizzas(pizzaCount) = "Size: Large " & "/" & " Topping: Cheese and Tomato " & "/" & " Crust: Classic " & "/" & " Base: Tomato" & "|" & pizzaPrice
    End Sub

    ' // To query the price if the order is updated.
    Private Sub getPrice()
        currentPrice.Text = "£" & pizzaPrice + crustPrice
        orderPrice.Text = "£" & orderedPizzaTotal + drinkPrice + sidesPrice + dipsPrice
    End Sub

    Private Sub resetOrder_Click(sender As Object, e As EventArgs) Handles resetOrder.Click
        Dim ActionToTake As Integer = MsgBox("Are you sure you wish to remove your order?", vbYesNo)

        If ActionToTake = DialogResult.Yes Then
            ' // Reset all user selection.
            drinkCocaCola.Value = 0
            drinkCokeZero.Value = 0
            drinkDietCoke.Value = 0
            drinkSmartWater.Value = 0
            drinkFanta.Value = 0
            drinkSprite.Value = 0
            sideMeatballs.SelectedIndex = 0
            sideGarlicBread.SelectedIndex = 0
            sideWedges.SelectedIndex = 0
            sideChickenMixBox.SelectedIndex = 0
            dipRandom.Value = 0
            dipBigGarlic.Value = 0
            dipBigBBQ.Value = 0
            dipFRANKs.Value = 0
            dipChiliInfusedOil.Value = 0

            ' // Revert our order tracking.
            ReDim CurrentOrder.Pizzas(0)
            pizzaCount = -1
            ReDim CurrentOrder.Extras(0)
            orderedPizzaTotal = 0.00
            pizzasInOrder.Text = "0 pizza(s) in order." ' // 0 based indexing.

            ' // Revert to default selection state.
            sizeLarge.Checked = True
            toppingCheeseTomato.Checked = True
            baseTomato.Checked = True
            crustClassic.Checked = True
            pizzaPreview.Image = Dominos.My.Resources.Resources.cheese_and_tomato_20170704_large
            selectedTopping = "Original Cheese and Tomato"
            selectedSize = "Large"
            selectedBase = "Tomato"
            selectedCrust = "Classic"
            pizzaPrice = 14.99
            crustPrice = 0
            drinkPrice = 0
            sidesPrice = 0
            dipsPrice = 0
            getPrice()

            ' // Reset PizzaMaker orders.
            CurrentOrder.PizzaMakerStatus = 0
            ReDim CurrentOrder.PizzaMakerPizzas(0)
            CurrentOrder.PizzaMakerTotal = 0
        End If
    End Sub

    Private Sub pizzaMaker_Click(sender As Object, e As EventArgs) Handles pizzaMaker.Click
        Dim pM As New PizzaMaker
        pM.Show()
    End Sub

    ' ==========================================================================
    ' // Change the pizza graphic based on selected pizza option.
    ' ==========================================================================

    Private Sub toppingCheeseTomato_Set(sender As Object, e As EventArgs) Handles toppingCheeseTomato.GotFocus
        selectedTopping = "Original Cheese and Tomato"
        pizzaPreview.Image = Dominos.My.Resources.Resources.cheese_and_tomato_20170704_large
    End Sub

    Private Sub toppingMightyMeaty_Set(sender As Object, e As EventArgs) Handles toppingMightyMeaty.GotFocus
        selectedTopping = "Mighty Meaty"
        pizzaPreview.Image = Dominos.My.Resources.Resources.mighty_meaty_20170704_large
    End Sub

    Private Sub toppingPepperoniPassion_Set(sender As Object, e As EventArgs) Handles toppingPepperoniPassion.GotFocus
        selectedTopping = "Pepperoni Passion"
        pizzaPreview.Image = Dominos.My.Resources.Resources.pepperonipassion_20170704_large
    End Sub

    Private Sub toppingTexasBBQ_Set(sender As Object, e As EventArgs) Handles toppingTexasBBQ.GotFocus
        selectedTopping = "Texas BBQ"
        pizzaPreview.Image = Dominos.My.Resources.Resources.texasbbq_20170704_large
    End Sub

    Private Sub toppingTandooriHot_Set(sender As Object, e As EventArgs) Handles toppingTandooriHot.GotFocus
        selectedTopping = "Domino's Tandoori Hot"
        pizzaPreview.Image = Dominos.My.Resources.Resources.tandoorihot_20170704_large
    End Sub

    Private Sub toppingFarmhouse_Set(sender As Object, e As EventArgs) Handles toppingFarmhouse.GotFocus
        selectedTopping = "Farmhouse"
        pizzaPreview.Image = Dominos.My.Resources.Resources.farmhouse_20170704_large
    End Sub

    Private Sub toppingDeluxe_Set(sender As Object, e As EventArgs) Handles toppingDeluxe.GotFocus
        selectedTopping = "Deluxe"
        pizzaPreview.Image = Dominos.My.Resources.Resources.deluxe_20170704_large
    End Sub

    Private Sub toppingMeatzza_Set(sender As Object, e As EventArgs) Handles toppingMeatzza.GotFocus
        selectedTopping = "Meatzza"
        pizzaPreview.Image = Dominos.My.Resources.Resources.meatzzapizza_20170704_large
    End Sub

    ' ==========================================================================
    ' // Change prices based on size selected.
    ' ==========================================================================

    Private Sub sizeSmall_Apply(sender As Object, e As EventArgs) Handles sizeSmall.GotFocus
        selectedSize = "Small"
        pizzaPrice = 9.99
        getPrice()
    End Sub

    Private Sub sizeMedium_Apply(sender As Object, e As EventArgs) Handles sizeMedium.GotFocus
        selectedSize = "Medium"
        pizzaPrice = 12.99
        getPrice()
    End Sub

    Private Sub sizeLarge_Apply(sender As Object, e As EventArgs) Handles sizeLarge.GotFocus
        selectedSize = "Large"
        pizzaPrice = 14.99
        getPrice()
    End Sub

    ' ==========================================================================
    ' // Change prices based on crust selected.
    ' ==========================================================================

    Private Sub crustClassic_Apply(sender As Object, e As EventArgs) Handles crustClassic.GotFocus, crustItalian.GotFocus, crustThin.GotFocus
        selectedCrust = "Classic"
        crustPrice = 0
        getPrice()
    End Sub

    Private Sub crustThin_Apply(sender As Object, e As EventArgs) Handles crustThin.GotFocus
        selectedCrust = "Thin"
    End Sub

    Private Sub crustItalian_Apply(sender As Object, e As EventArgs) Handles crustItalian.GotFocus
        selectedCrust = "Italian"
    End Sub

    Private Sub crustStuffedChilliCheese_Apply(sender As Object, e As EventArgs) Handles crustStuffedChilliCheese.GotFocus
        selectedCrust = "Stuffed Chilli Cheese"
        crustPrice = 2.5
        getPrice()
    End Sub

    Private Sub crustStuffedCheese_Apply(sender As Object, e As EventArgs) Handles crustStuffedCheese.GotFocus
        selectedCrust = "Stuffed Cheese"
        crustPrice = 2.99
        getPrice()
    End Sub

    Private Sub crustDoubleDecadence_Apply(sender As Object, e As EventArgs) Handles crustDoubleDecadence.GotFocus
        selectedCrust = "Double Decadence"
        crustPrice = 2.99
        getPrice()
    End Sub

    ' // Double Decadence Logic
    ' // allow selection if size is medium or large.
    Private Sub crustDoubleDecadence_Allow(sender As Object, e As EventArgs) Handles sizeMedium.GotFocus, sizeLarge.GotFocus
        crustDoubleDecadence.Enabled = True
    End Sub

    ' // or revert their selection if they change their size to small.
    Private Sub crustDoubleDecadence_Deny(sender As Object, e As EventArgs) Handles sizeSmall.GotFocus
        If crustDoubleDecadence.Checked = True Then
            selectedCrust = "Classic"
            crustClassic.Checked = True
            crustPrice = 0
            getPrice()
        End If
        crustDoubleDecadence.Enabled = False
    End Sub

    ' ==========================================================================
    ' // Keep track of the base selection.
    ' ==========================================================================

    Private Sub baseTomato_Apply(sender As Object, e As EventArgs) Handles baseTomato.GotFocus
        selectedBase = "Tomato"
    End Sub

    Private Sub baseSundriedTomatoGarlic_Apply(sender As Object, e As EventArgs) Handles baseSundriedTomatoGarlic.GotFocus
        selectedBase = "Sundried Tomato and Garlic"
    End Sub

    Private Sub baseBBQ_Apply(sender As Object, e As EventArgs) Handles baseBBQ.GotFocus
        selectedBase = "BBQ"
    End Sub

    ' ==========================================================================
    ' Change prices based on drink(s) selected.
    ' ==========================================================================

    Private Sub drinksPrice_Change(sender As Object, e As EventArgs) Handles drinkCocaCola.ValueChanged, drinkCokeZero.ValueChanged, drinkDietCoke.ValueChanged, drinkSmartWater.ValueChanged, drinkSprite.ValueChanged, drinkFanta.ValueChanged
        Dim NumberOfDrinks As Integer = drinkCocaCola.Value + drinkDietCoke.Value + drinkCokeZero.Value + drinkSmartWater.Value + drinkSprite.Value + drinkFanta.Value
        drinkPrice = NumberOfDrinks * 1.79
        getPrice()
    End Sub

    ' ==========================================================================
    ' Change prices based on side(s) selected.
    ' ==========================================================================

    Private Sub sidesPrice_Change(sender As Object, e As EventArgs) Handles sideMeatballs.SelectionChangeCommitted, sideGarlicBread.SelectionChangeCommitted, sideWedges.SelectionChangeCommitted, sideChickenMixBox.SelectionChangeCommitted
        sidesPrice = (sideMeatballs.SelectedItem * 4.99) + (sideGarlicBread.SelectedItem * 3.99) + (sideWedges.SelectedItem * 3.99) + (sideChickenMixBox.SelectedItem * 8.49)
        getPrice()
    End Sub

    ' ==========================================================================
    ' Change prices based on dip(s) selected.
    ' ==========================================================================

    Private Sub dipsPrice_Change(sender As Object, e As EventArgs) Handles dipRandom.ValueChanged, dipBigGarlic.ValueChanged, dipBigBBQ.ValueChanged, dipFRANKs.ValueChanged, dipChiliInfusedOil.ValueChanged
        Dim NumberOfDips As Integer = dipBigGarlic.Value + dipBigBBQ.Value + dipFRANKs.Value + dipChiliInfusedOil.Value
        dipsPrice = (dipRandom.Value * 0.49) + NumberOfDips ' // Random Dip is 0.49 and other big dips are 1.00 each.
        getPrice()
    End Sub

    ' ==========================================================================
    ' Add/remove a pizza to/from the order.
    ' ==========================================================================

    Private Sub addPizza_Click(sender As Object, e As EventArgs) Handles addPizza.Click
        If pizzaCount < 19 Then
            ' // Store the fact they've added a pizza to their order.
            pizzaCount = pizzaCount + 1
            ReDim Preserve CurrentOrder.Pizzas(pizzaCount)
            CurrentOrder.Pizzas(pizzaCount) = "Size: " & selectedSize & " / " & "Topping: " & selectedTopping & " / " & "Crust: " & selectedCrust & " / " & "Base: " & selectedBase & "|" & (pizzaPrice + crustPrice)
            pizzasInOrder.Text = (pizzaCount + 1) & " pizza(s) in order." ' // 0 based indexing.

            ' // Update the total price.
            orderedPizzaTotal = orderedPizzaTotal + (pizzaPrice + crustPrice)
            getPrice()
        Else
            MsgBox("Max limit reached. Only 20 pizzas allowed per order.")
        End If
    End Sub

    Private Sub removePizza_Click(sender As Object, e As EventArgs) Handles removePizza.Click
        If pizzaCount <> -1 Then
            ' // Remove pizza price from order.
            Dim lastPizzaPrice() As String = Split(CurrentOrder.Pizzas(pizzaCount), "|")
            orderedPizzaTotal = orderedPizzaTotal - lastPizzaPrice(1)
            getPrice()

            ' // Store the fact they've removed a pizza from their order.
            pizzaCount = pizzaCount - 1
            ReDim Preserve CurrentOrder.Pizzas(pizzaCount)
            pizzasInOrder.Text = (pizzaCount + 1) & " pizza(s) in order." ' // 0 based indexing.

        Else
            MsgBox("No pizzas to remove.")
        End If
    End Sub

    ' ==========================================================================
    ' Place the order.
    ' ==========================================================================

    Private Sub completeOrder_Click(sender As Object, e As EventArgs) Handles completeOrder.Click
        If pizzaCount = -1 And CurrentOrder.PizzaMakerStatus = False Then
            MsgBox("First, grab yourself a pizza :)")
        ElseIf pizzaCount >= 0 And CurrentOrder.pizzamakerstatus = False Then
            MsgBox("ClassicOrder detected.")
            orderTotal = orderPrice.Text.Remove(0, 1)
            ' // Apply 5% discount if applicable.
            If orderTotal > 20 Then
                orderTotal = (orderTotal / 100 * 95)
                discountApplied = True
            End If
            ' // Get their current side selection.
            CurrentOrder.Extras(0) = "Drinks: " & "£" & drinkPrice & "," & drinkCocaCola.Value & "," & drinkDietCoke.Value & "," & drinkCokeZero.Value & "," & drinkSmartWater.Value & "," & drinkSprite.Value & "," & drinkFanta.Value & "|" & "Sides: " & "£" & sidesPrice & "," & sideMeatballs.SelectedItem & "," & sideGarlicBread.SelectedItem & "," & sideWedges.SelectedItem & "," & sideChickenMixBox.SelectedItem & "|" & "Dips: " & "£" & dipsPrice & "," & dipRandom.Value & "," & dipBigGarlic.Value & "," & dipBigBBQ.Value & "," & dipFRANKs.Value & "," & dipChiliInfusedOil.Value & "," & orderTotal.ToString("C")

            ' // Get their current pizza selection.
            Dim OrderPizzas As String = ""
            Dim PizzaPointer As Integer
            For Each Pizza In CurrentOrder.Pizzas
                PizzaPointer = PizzaPointer + 1
                OrderPizzas = OrderPizzas + Pizza
                If PizzaPointer = pizzaCount Then OrderPizzas = OrderPizzas + "/" ' // Add delimiter char if needed.
            Next

            File.AppendAllText("Orders.txt", UserDetails.ID & "," & OrderPizzas & "," & CurrentOrder.Extras(0) + Environment.NewLine)
            If discountApplied = True Then MsgBox("5% coupon applied. Dominos perks, baby.")
            MsgBox("The price is " & orderTotal.ToString("C") & " with 20% VAT of " & ((orderTotal / 100) * 20).ToString("c") & ".")
            MsgBox("Order placed sucessfully.")
            orderTotal = 0
        End If

        If CurrentOrder.PizzaMakerStatus = True Then
            orderTotal = orderPrice.Text.Remove(0, 1) + CurrentOrder.PizzaMakerTotal
            ' // Apply 5% discount if applicable.
            If orderTotal > 20 Then
                orderTotal = (orderTotal / 100 * 95)
                discountApplied = True
            End If

            ' // Get their current side selection.
            CurrentOrder.Extras(0) = "Drinks: " & "£" & drinkPrice & "," & drinkCocaCola.Value & "," & drinkDietCoke.Value & "," & drinkCokeZero.Value & "," & drinkSmartWater.Value & "," & drinkSprite.Value & "," & drinkFanta.Value & "|" & "Sides: " & "£" & sidesPrice & "," & sideMeatballs.SelectedItem & "," & sideGarlicBread.SelectedItem & "," & sideWedges.SelectedItem & "," & sideChickenMixBox.SelectedItem & "|" & "Dips: " & "£" & dipsPrice & "," & dipRandom.Value & "," & dipBigGarlic.Value & "," & dipBigBBQ.Value & "," & dipFRANKs.Value & "," & dipChiliInfusedOil.Value & "," & orderTotal.ToString("C")
            pizzaMakerOrder()
        End If
    End Sub

    Private Sub pizzaMakerOrder()
        ' // check if has ordered pizza on ClassicOrder
        If pizzaCount = -1 Then
            MsgBox("No orders in ClassicOrder, only PizzaMaker detected.")

            Dim PizzaMakerPizzas As String = ""
            Dim PizzaMakerPointer As Integer
            For Each Pizza In CurrentOrder.PizzaMakerPizzas
                PizzaMakerPointer = PizzaMakerPointer + 1
                PizzaMakerPizzas = PizzaMakerPizzas + Pizza
            Next

            File.AppendAllText("Orders.txt", UserDetails.ID & "," & PizzaMakerPizzas & "," & CurrentOrder.Extras(0) + Environment.NewLine)
            If discountApplied = True Then MsgBox("5% coupon applied. Dominos perks, baby.")
            MsgBox("The price is " & CurrentOrder.PizzaMakerTotal.ToString("c") & " with a 20% VAT of " & (orderTotal / 100 * 20).ToString("c") & ".")
            MsgBox("Order placed sucessfully with PizzaMaker.")
            orderTotal = 0
        Else
            MsgBox("ClassicOrder and PizzaMaker detected.")
            ' // Get their current pizza selection.
            Dim OrderPizzas As String = ""
            Dim PizzaPointer As Integer
            For Each Pizza In CurrentOrder.Pizzas
                PizzaPointer = PizzaPointer + 1
                OrderPizzas = OrderPizzas + Pizza
                If PizzaPointer = pizzaCount Then OrderPizzas = OrderPizzas + "/" ' // Add delimiter char if needed.
            Next

            Dim PizzaMakerPizzas As String = ""
            Dim PizzaMakerPointer As Integer
            For Each Pizza In CurrentOrder.PizzaMakerPizzas
                PizzaMakerPointer = PizzaMakerPointer + 1
                PizzaMakerPizzas = PizzaMakerPizzas + Pizza
            Next

            File.AppendAllText("Orders.txt", UserDetails.ID & "," & OrderPizzas & PizzaMakerPizzas & "," & CurrentOrder.Extras(0) + Environment.NewLine)
            If discountApplied = True Then MsgBox("5% coupon applied. Dominos perks, baby.")
            MsgBox("The price is " & orderTotal.ToString("C") & " with a 20% VAT of " & (orderTotal / 100 * 20).ToString("C") & ".")
            MsgBox("Order placed sucessfully with ClassicOrder & PizzaMaker.")
            orderTotal = 0
        End If
    End Sub
End Class
