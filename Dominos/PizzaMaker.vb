Public Class PizzaMaker

    Private selectedCrust As Bitmap = Dominos.My.Resources.Crust_H_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
    Private selectedSauce As Bitmap = Nothing
    Private selectedCheese As Bitmap = Nothing
    Private currentCrust As String = "Classic"
    Private currentSauce As String

    Private totalPrice As Decimal
    Private basePrice As Decimal = 8.5
    Private crustPrice As Decimal
    Private toppingsPrice As Decimal

    Private pizzaCount As Integer
    Private anchovyQuantity As Integer
    Private baconQuantity As Integer
    Private cheeseQuantity As Integer
    Private chickenQuantity As Integer
    Private groundBeefQuantity As Integer
    Private hamQuantity As Integer
    Private pepperoniQuantity As Integer
    Private pineappleQuantity As Integer
    Private salamiQuantity As Integer
    Private swissCheeseQuantity As Integer

    Private Sub PizzaMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set toppings = none selected @ start-up.
        toppingAnchovy.SelectedItem = "0"
        toppingBacon.SelectedItem = "0"
        toppingCheese.SelectedItem = "0"
        toppingChicken.SelectedItem = "0"
        toppingGroundBeef.SelectedItem = "0"
        toppingHam.SelectedItem = "0"
        toppingPepperoni.SelectedItem = "0"
        toppingPineapple.SelectedItem = "0"
        toppingSalami.SelectedItem = "0"
        toppingSwissCheese.SelectedItem = "0"

        ' Set size = medium.
        sizeSelection.SelectedItem = """11.5"
    End Sub

    ' // To query the price if the order is updated.
    Private Sub getPrice()
        toppingsPrice = (toppingAnchovy.SelectedIndex) + (toppingBacon.SelectedIndex) + (toppingCheese.SelectedIndex) + (toppingChicken.SelectedIndex) + (toppingGroundBeef.SelectedIndex) + (toppingHam.SelectedIndex) + (toppingPepperoni.SelectedIndex) + (toppingPineapple.SelectedIndex) + (toppingSalami.SelectedIndex) + (toppingSwissCheese.SelectedIndex)
        ' // first 3 toppings are free
        If toppingsPrice = 1 Then toppingsPrice = toppingsPrice - 1
        If toppingsPrice = 2 Then toppingsPrice = toppingsPrice - 2
        If toppingsPrice = 3 Then toppingsPrice = toppingsPrice - 3
        If toppingsPrice >= 4 Then toppingsPrice = toppingsPrice - 3
        totalPrice = (basePrice + crustPrice + toppingsPrice)
        currentPrice.Text = totalPrice.ToString("c")

        ' // If applicable, disable toppings addition.
        If (toppingsPrice + 3) >= 11 Then
            chooseToppings.Enabled = False
            maxToppingsNotice.Visible = True
        End If
    End Sub

    ' // Combine the pizza tray, sauce and cheese to create an image.
    Private Sub updatePizza()
        Dim startPizza = Dominos.My.Resources.PizzaChef_Tray_Circle
        Dim graphicPizza = System.Drawing.Graphics.FromImage(startPizza)
        graphicPizza.DrawImage(selectedCrust, 0, 0)
        If selectedSauce IsNot Nothing Then graphicPizza.DrawImage(selectedSauce, 0, 0)
        If selectedCheese IsNot Nothing Then graphicPizza.DrawImage(selectedCheese, 0, 0)
        pizzaTray.BackgroundImage = startPizza
    End Sub

    ' // Combine 2 or 3 topping images to create a layer image.
    Function createToppingsLayer(ByVal FirstTopping As System.Drawing.Bitmap, ByVal SecondTopping As System.Drawing.Bitmap, Optional ByVal ThirdTopping As System.Drawing.Bitmap = Nothing) As System.Drawing.Bitmap
        Dim g = System.Drawing.Graphics.FromImage(FirstTopping)
        g.DrawImage(SecondTopping, 0, 0)
        If ThirdTopping IsNot Nothing Then g.DrawImage(ThirdTopping, 0, 0)
        Return FirstTopping
    End Function

    ' ==========================================================================
    ' // Reset user selection/add pizza to order.
    ' ==========================================================================

    Private Sub startOver_Click(sender As Object, e As EventArgs) Handles startOver.Click
        Dim ActionToTake As Integer = MsgBox("Are you sure you wish to remove your custom pizza?", vbYesNo)

        If ActionToTake = DialogResult.Yes Then
            ' Set toppings = none selected.
            toppingAnchovy.SelectedItem = "0"
            toppingBacon.SelectedItem = "0"
            toppingCheese.SelectedItem = "0"
            toppingChicken.SelectedItem = "0"
            toppingGroundBeef.SelectedItem = "0"
            toppingHam.SelectedItem = "0"
            toppingPepperoni.SelectedItem = "0"
            toppingPineapple.SelectedItem = "0"
            toppingSalami.SelectedItem = "0"
            toppingSwissCheese.SelectedItem = "0"

            ' Set pizza options.
            currentCrust = "Classic"
            currentSauce = ""
            selectedCrust = Dominos.My.Resources.Crust_H_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            crustClassic.Checked = True
            selectedSauce = Nothing
            sauceNone.Checked = True
            sizeSelection.SelectedItem = """11.5"

            ' Set prices.
            basePrice = 10
            crustPrice = 0
            toppingsPrice = 0

            ' Re-enable toppings section.
            chooseToppings.Enabled = True
            maxToppingsNotice.Visible = False

            updatePizza()
            getPrice()
        End If
    End Sub

    Private Sub addPizza_Click(sender As Object, e As EventArgs) Handles addPizza.Click
        If currentSauce = "" Or toppingsPrice = 0 Then
            MsgBox("Something is wrong with your order :( Check you've added a sauce & at least 4 toppings!")
        Else
            Dim size As String = ""
            If sizeSelection.SelectedItem = """9.5" Then
                size = "Small"
            ElseIf sizeSelection.SelectedItem = """11.5" Then
                size = "Medium"
            ElseIf sizeSelection.SelectedItem = """13.5" Then
                size = "Large"
            End If

            Dim toppings = "Anchovy: " & toppingAnchovy.SelectedIndex & " Bacon: " & toppingBacon.SelectedIndex & " Cheese: " & toppingCheese.SelectedIndex & " Chicken: " & toppingChicken.SelectedIndex & " Ground Beef: " & toppingGroundBeef.SelectedIndex & " Ham: " & toppingHam.SelectedIndex & " Pepperoni: " & toppingPepperoni.SelectedIndex & " Pineapple: " & toppingPineapple.SelectedIndex & " Salami: " & toppingSalami.SelectedIndex & " Swiss Cheese: " & toppingSwissCheese.SelectedIndex & " "
            pizzaCount = pizzaCount + 1
            ReDim Preserve CurrentOrder.PizzaMakerPizzas(pizzaCount)
            CurrentOrder.PizzaMakerPizzas(pizzaCount) = "Size: " & size & " / Topping: CUSTOM - " & toppings & " / Crust: " & currentCrust & " / Base: " & currentSauce
            CurrentOrder.PizzaMakerTotal = totalPrice
            CurrentOrder.PizzaMakerStatus = 1
            MsgBox(CurrentOrder.PizzaMakerPizzas(pizzaCount))
        End If
    End Sub

    ' ==========================================================================
    ' // Change price based on size selection.
    ' ==========================================================================

    Private Sub sizeSelection_Change(sender As Object, e As EventArgs) Handles sizeSelection.SelectedIndexChanged
        If sizeSelection.SelectedItem = """9.5" Then
            basePrice = 8.5
        ElseIf sizeSelection.SelectedItem = """11.5" Then
            basePrice = 10
        ElseIf sizeSelection.SelectedItem = """13.5" Then
            basePrice = 13.5
        End If
        getPrice()
    End Sub

    ' ==========================================================================
    ' // Change the pizza graphic based on selected crust option.
    ' ==========================================================================

    Private Sub crustClassic_Set(sender As Object, e As EventArgs) Handles crustClassic.GotFocus
        currentCrust = "Classic"
        crustPrice = 0
        selectedCrust = Dominos.My.Resources.Crust_H_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
        getPrice()
    End Sub

    Private Sub crustCheese_Set(sender As Object, e As EventArgs) Handles crustCheese.GotFocus
        currentCrust = "Cheese"
        crustPrice = 1.95
        selectedCrust = Dominos.My.Resources.Crust_C_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
        getPrice()
    End Sub

    Private Sub crustItalian_Set(sender As Object, e As EventArgs) Handles crustItalian.GotFocus
        currentCrust = "Italian"
        crustPrice = 0
        selectedCrust = Dominos.My.Resources.Crust_T_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
        getPrice()
    End Sub

    Private Sub crustFreshPan_Set(sender As Object, e As EventArgs) Handles crustFreshPan.GotFocus
        currentCrust = "Fresh Pan"
        crustPrice = 1
        selectedCrust = Dominos.My.Resources.Crust_P_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
        getPrice()
    End Sub

    ' ==========================================================================
    ' // Change the pizza graphic based on selected sauce option.
    ' ==========================================================================

    Private Sub baseNone_Set(sender As Object, e As EventArgs) Handles sauceNone.GotFocus
        currentSauce = ""
        selectedSauce = Nothing
        updatePizza()
    End Sub

    Private Sub baseTomato_Set(sender As Object, e As EventArgs) Handles sauceTomato.GotFocus
        currentSauce = "Tomato"
        selectedSauce = Dominos.My.Resources.NL_Sauce_X_all_CircleLayer1Image_1275
        updatePizza()
    End Sub

    Private Sub baseBBQ_Set(sender As Object, e As EventArgs) Handles sauceBBQ.GotFocus
        currentSauce = "BBQ"
        selectedSauce = Dominos.My.Resources.Sauce_Xb_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    Private Sub baseHBBQ_Set(sender As Object, e As EventArgs) Handles sauceHBBQ.GotFocus
        currentSauce = "HBBQ"
        selectedSauce = Dominos.My.Resources.Sauce_HBBSCComponentImagePizzaChef_Stack_Circle_1ENDefault19000101_011052
        updatePizza()
    End Sub

    Private Sub baseCremeFraiche_Set(sender As Object, e As EventArgs) Handles sauceCremeFraiche.GotFocus
        currentSauce = "Crème Fraîche"
        selectedSauce = Dominos.My.Resources.Sauce_Xz_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    ' ==========================================================================
    ' // Change pizza graphic based on selected topping(s).
    ' ==========================================================================

    Private Sub toppingAnchovy_Apply(sender As Object, e As EventArgs) Handles toppingAnchovy.SelectedIndexChanged
        If toppingAnchovy.SelectedItem = "0" Then
            anchovyLayer.BackgroundImage = Nothing
            anchovyQuantity = 0
        ElseIf toppingAnchovy.SelectedItem = "1" Then
            anchovyLayer.BackgroundImage = Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            anchovyQuantity = 1
        ElseIf toppingAnchovy.SelectedItem = "2" Then
            anchovyLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            anchovyQuantity = 2
        ElseIf toppingAnchovy.SelectedItem = "3" Then
            anchovyLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            anchovyQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingBacon_Apply(sender As Object, e As EventArgs) Handles toppingBacon.SelectedIndexChanged
        If toppingBacon.SelectedItem = "0" Then
            baconLayer.BackgroundImage = Nothing
            baconQuantity = 0
        ElseIf toppingBacon.SelectedItem = "1" Then
            baconLayer.BackgroundImage = Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121
            baconQuantity = 1
        ElseIf toppingBacon.SelectedItem = "2" Then
            baconLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer2Image_1121)
            baconQuantity = 2
        ElseIf toppingBacon.SelectedItem = "3" Then
            baconLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer2Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer3Image_1121)
            baconQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingCheese_Apply(sender As Object, e As EventArgs) Handles toppingCheese.SelectedIndexChanged
        If toppingCheese.SelectedItem = "0" Then
            selectedCheese = Nothing
            updatePizza()
            cheeseQuantity = 0
        ElseIf toppingCheese.SelectedItem = "1" Then
            selectedCheese = Dominos.My.Resources.NL_Topping_K_all_CircleLayer3Image_1275
            updatePizza()
            cheeseQuantity = 1
        ElseIf toppingCheese.SelectedItem = "2" Then
            selectedCheese = Dominos.My.Resources.NL_Topping_K_all_CircleLayer3Image_1275
            updatePizza()
            cheeseQuantity = 2
        ElseIf toppingCheese.SelectedItem = "3" Then
            selectedCheese = Dominos.My.Resources.NL_Topping_K_all_CircleLayer3Image_1275
            updatePizza()
            cheeseQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingChicken_Apply(sender As Object, e As EventArgs) Handles toppingChicken.SelectedIndexChanged
        If toppingChicken.SelectedItem = "0" Then
            chickenLayer.BackgroundImage = Nothing
            chickenQuantity = 0
        ElseIf toppingChicken.SelectedItem = "1" Then
            chickenLayer.BackgroundImage = Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            chickenQuantity = 1
        ElseIf toppingChicken.SelectedItem = "2" Then
            chickenLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            chickenQuantity = 2
        ElseIf toppingChicken.SelectedItem = "3" Then
            chickenLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            chickenQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingGroundBeef_Apply(sender As Object, e As EventArgs) Handles toppingGroundBeef.SelectedIndexChanged
        If toppingGroundBeef.SelectedItem = "0" Then
            groundBeefLayer.BackgroundImage = Nothing
            groundBeefQuantity = 0
        ElseIf toppingGroundBeef.SelectedItem = "1" Then
            groundBeefLayer.BackgroundImage = Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            groundBeefQuantity = 1
        ElseIf toppingGroundBeef.SelectedItem = "2" Then
            groundBeefLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            groundBeefQuantity = 2
        ElseIf toppingGroundBeef.SelectedItem = "3" Then
            groundBeefLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_G_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            groundBeefQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingHam_Apply(sender As Object, e As EventArgs) Handles toppingHam.SelectedIndexChanged
        If toppingHam.SelectedItem = "0" Then
            hamLayer.BackgroundImage = Nothing
            hamQuantity = 0
        ElseIf toppingHam.SelectedItem = "1" Then
            hamLayer.BackgroundImage = Dominos.My.Resources.NL_Topping_H_all_CircleLayer1Image_1275
            hamQuantity = 1
        ElseIf toppingHam.SelectedItem = "2" Then
            hamLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_H_all_CircleLayer1Image_1275, Dominos.My.Resources.NL_Topping_H_all_CircleLayer2Image_1275)
            hamQuantity = 2
        ElseIf toppingHam.SelectedItem = "3" Then
            hamLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_H_all_CircleLayer1Image_1275, Dominos.My.Resources.NL_Topping_H_all_CircleLayer2Image_1275, Dominos.My.Resources.NL_Topping_H_all_CircleLayer3Image_1275)
            hamQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingPepperoni_Apply(sender As Object, e As EventArgs) Handles toppingPepperoni.SelectedIndexChanged
        If toppingPepperoni.SelectedItem = "0" Then
            pepperoniLayer.BackgroundImage = Nothing
            pepperoniQuantity = 0
        ElseIf toppingPepperoni.SelectedItem = "1" Then
            pepperoniLayer.BackgroundImage = Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            pepperoniQuantity = 1
        ElseIf toppingPepperoni.SelectedItem = "2" Then
            pepperoniLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            pepperoniQuantity = 2
        ElseIf toppingPepperoni.SelectedItem = "3" Then
            pepperoniLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_S_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            pepperoniQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingPineapple_Apply(sender As Object, e As EventArgs) Handles toppingPineapple.SelectedIndexChanged
        If toppingPineapple.SelectedItem = "0" Then
            pineappleLayer.BackgroundImage = Nothing
            pineappleQuantity = 0
        ElseIf toppingPineapple.SelectedItem = "1" Then
            pineappleLayer.BackgroundImage = Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            pineappleQuantity = 1
        ElseIf toppingPineapple.SelectedItem = "2" Then
            pineappleLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            pineappleQuantity = 2
        ElseIf toppingPineapple.SelectedItem = "3" Then
            pineappleLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_A_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            pineappleQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingSalami_Apply(sender As Object, e As EventArgs) Handles toppingSalami.SelectedIndexChanged
        If toppingSalami.SelectedItem = "0" Then
            salamiLayer.BackgroundImage = Nothing
            salamiQuantity = 0
        ElseIf toppingSalami.SelectedItem = "1" Then
            salamiLayer.BackgroundImage = Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer1Image_1275
            salamiQuantity = 1
        ElseIf toppingSalami.SelectedItem = "2" Then
            salamiLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer1Image_1275, Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer2Image_1275)
            salamiQuantity = 2
        ElseIf toppingSalami.SelectedItem = "3" Then
            salamiLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer1Image_1275, Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer2Image_1275, Dominos.My.Resources.NL_Topping_Ss_all_CircleLayer3Image_1275)
            salamiQuantity = 3
        End If
        getPrice()
    End Sub

    Private Sub toppingSwissCheese_Apply(sender As Object, e As EventArgs) Handles toppingSwissCheese.SelectedIndexChanged
        If toppingSwissCheese.SelectedItem = "0" Then
            swissCheeseLayer.BackgroundImage = Nothing
            swissCheeseQuantity = 0
        ElseIf toppingSwissCheese.SelectedItem = "1" Then
            swissCheeseLayer.BackgroundImage = Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            swissCheeseQuantity = 1
        ElseIf toppingSwissCheese.SelectedItem = "2" Then
            swissCheeseLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            swissCheeseQuantity = 2
        ElseIf toppingSwissCheese.SelectedItem = "3" Then
            swissCheeseLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_Et_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            swissCheeseQuantity = 3
        End If
        getPrice()
    End Sub
End Class