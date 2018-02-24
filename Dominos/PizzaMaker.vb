Imports System.Drawing

Public Class PizzaMaker

    Private pizza As Bitmap = Dominos.My.Resources.PizzaChef_Tray_Circle
    Private selectedCrust As Bitmap = Dominos.My.Resources.Crust_H_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
    Private selectedSauce As Bitmap = Nothing
    Private selectedCheese As Bitmap = Nothing

    Private Sub updatePizza()
        Dim startPizza = Dominos.My.Resources.PizzaChef_Tray_Circle
        Dim graphicPizza = System.Drawing.Graphics.FromImage(startPizza)
        graphicPizza.DrawImage(selectedCrust, 0, 0)
        If selectedSauce IsNot Nothing Then graphicPizza.DrawImage(selectedSauce, 0, 0)
        If selectedCheese IsNot Nothing Then graphicPizza.DrawImage(selectedCheese, 0, 0)
        pizzaTray.BackgroundImage = startPizza
    End Sub

    Function createToppingsLayer(ByVal FirstTopping As System.Drawing.Bitmap, ByVal SecondTopping As System.Drawing.Bitmap, Optional ByVal ThirdTopping As System.Drawing.Bitmap = Nothing) As System.Drawing.Bitmap
        Dim g = System.Drawing.Graphics.FromImage(FirstTopping)
        g.DrawImage(SecondTopping, 0, 0)
        If ThirdTopping IsNot Nothing Then g.DrawImage(ThirdTopping, 0, 0)
        Return FirstTopping
    End Function

    ' ==========================================================================
    ' // Change the pizza graphic based on selected crust option.
    ' ==========================================================================

    Private Sub crustClassic_Set(sender As Object, e As EventArgs) Handles crustClassic.GotFocus
        selectedCrust = Dominos.My.Resources.Crust_H_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    Private Sub crustCheese_Set(sender As Object, e As EventArgs) Handles crustCheese.GotFocus
        selectedCrust = Dominos.My.Resources.Crust_C_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    Private Sub crustItalian_Set(sender As Object, e As EventArgs) Handles crustItalian.GotFocus
        selectedCrust = Dominos.My.Resources.Crust_T_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    Private Sub crustFreshPan_Set(sender As Object, e As EventArgs) Handles crustFreshPan.GotFocus
        selectedCrust = Dominos.My.Resources.Crust_P_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    ' ==========================================================================
    ' // Change the pizza graphic based on selected sauce option.
    ' ==========================================================================

    Private Sub baseNone_Set(sender As Object, e As EventArgs) Handles sauceNone.GotFocus
        selectedSauce = Nothing
        updatePizza()
    End Sub

    Private Sub baseTomato_Set(sender As Object, e As EventArgs) Handles sauceTomato.GotFocus
        selectedSauce = Dominos.My.Resources.NL_Sauce_X_all_CircleLayer1Image_1275
        updatePizza()
    End Sub

    Private Sub baseBBQ_Set(sender As Object, e As EventArgs) Handles sauceBBQ.GotFocus
        selectedSauce = Dominos.My.Resources.Sauce_Xb_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    Private Sub baseHBBQ_Set(sender As Object, e As EventArgs) Handles sauceHBBQ.GotFocus
        selectedSauce = Dominos.My.Resources.Sauce_HBBSCComponentImagePizzaChef_Stack_Circle_1ENDefault19000101_011052
        updatePizza()
    End Sub

    Private Sub baseCremeFraiche_Set(sender As Object, e As EventArgs) Handles sauceCremeFraiche.GotFocus
        selectedSauce = Dominos.My.Resources.Sauce_Xz_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
        updatePizza()
    End Sub

    ' ==========================================================================
    ' // Change pizza graphic and validate the topping(s).
    ' ==========================================================================

    Private Sub toppingCheese1_CheckedChanged(sender As Object, e As EventArgs) Handles toppingCheese1.CheckedChanged
        toppingCheese2.Checked = False

        If toppingCheese1.Checked = True Then
            selectedCheese = Dominos.My.Resources.NL_Topping_K_all_CircleLayer3Image_1275
            updatePizza()
            toppingCheese2.Enabled = True
        Else
            selectedCheese = Nothing
            updatePizza()
            toppingCheese2.Enabled = False
        End If
    End Sub

    Private Sub toppingCheese2_CheckedChanged(sender As Object, e As EventArgs) Handles toppingCheese2.CheckedChanged
        If toppingCheese2.Checked = True Then
            toppingCheese3.Enabled = True
        Else
            toppingCheese3.Enabled = False
        End If
    End Sub

    Private Sub toppingCheese3_CheckedChanged(sender As Object, e As EventArgs) Handles toppingCheese3.CheckedChanged
        If toppingCheese3.Checked = True Then
            toppingCheese1.Enabled = False
            toppingCheese2.Enabled = False
        Else
            toppingCheese1.Enabled = True
            toppingCheese2.Enabled = True
            toppingCheese3.Enabled = False
        End If
    End Sub

    Private Sub toppingAnchovy1_CheckedChanged(sender As Object, e As EventArgs) Handles toppingAnchovy1.CheckedChanged
        toppingAnchovy2.Checked = False

        If toppingAnchovy1.Checked = True Then
            anchovyLayer.BackgroundImage = Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            toppingAnchovy2.Enabled = True
        Else
            anchovyLayer.BackgroundImage = Nothing
            toppingAnchovy2.Enabled = False
        End If
    End Sub

    Private Sub toppingAnchovy2_CheckedChanged(sender As Object, e As EventArgs) Handles toppingAnchovy2.CheckedChanged
        If toppingAnchovy2.Checked = True Then
            anchovyLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            toppingAnchovy3.Enabled = True
        Else
            anchovyLayer.BackgroundImage = Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            toppingAnchovy3.Enabled = False
        End If
    End Sub

    Private Sub toppingAnchovy3_CheckedChanged(sender As Object, e As EventArgs) Handles toppingAnchovy3.CheckedChanged
        If toppingAnchovy3.Checked = True Then
            anchovyLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            toppingAnchovy1.Enabled = False
            toppingAnchovy2.Enabled = False
        Else
            anchovyLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_F_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            toppingAnchovy1.Enabled = True
            toppingAnchovy2.Enabled = True
            toppingAnchovy3.Enabled = False
        End If
    End Sub

    Private Sub toppingBacon1_CheckedChanged(sender As Object, e As EventArgs) Handles toppingBacon1.CheckedChanged
        toppingBacon2.Checked = False

        If toppingBacon1.Checked = True Then
            baconLayer.BackgroundImage = Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121
            toppingBacon2.Enabled = True
        Else
            baconLayer.BackgroundImage = Nothing
            toppingBacon2.Enabled = False
        End If
    End Sub

    Private Sub toppingBacon2_CheckedChanged(sender As Object, e As EventArgs) Handles toppingBacon2.CheckedChanged
        If toppingBacon2.Checked = True Then
            baconLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer2Image_1121)
            toppingBacon3.Enabled = True
        Else
            baconLayer.BackgroundImage = Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121
            toppingBacon3.Enabled = False
        End If
    End Sub

    Private Sub toppingBacon3_CheckedChanged(sender As Object, e As EventArgs) Handles toppingBacon3.CheckedChanged
        If toppingBacon3.Checked = True Then
            baconLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer2Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer3Image_1121)
            toppingBacon1.Enabled = False
            toppingBacon2.Enabled = False
        Else
            baconLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.NL_Topping_B_all_CircleLayer1Image_1121, Dominos.My.Resources.NL_Topping_B_all_CircleLayer2Image_1121)
            toppingBacon1.Enabled = True
            toppingBacon2.Enabled = True
            toppingBacon3.Enabled = False
        End If
    End Sub

    Private Sub toppingChicken1_CheckedChanged(sender As Object, e As EventArgs) Handles toppingChicken1.CheckedChanged
        toppingChicken2.Checked = False

        If toppingChicken1.Checked = True Then
            chickenLayer.BackgroundImage = Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            toppingChicken2.Enabled = True
        Else
            chickenLayer.BackgroundImage = Nothing
            toppingChicken2.Enabled = False
        End If
    End Sub

    Private Sub toppingChicken2_CheckedChanged(sender As Object, e As EventArgs) Handles toppingChicken2.CheckedChanged
        If toppingChicken2.Checked = True Then
            chickenLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            toppingChicken3.Enabled = True
        Else
            chickenLayer.BackgroundImage = Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default
            toppingBacon3.Enabled = False
        End If
    End Sub

    Private Sub toppingChicken3_CheckedChanged(sender As Object, e As EventArgs) Handles toppingChicken3.CheckedChanged
        If toppingChicken3.Checked = True Then
            chickenLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_2_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_3_en_Default)
            toppingChicken1.Enabled = False
            toppingChicken2.Enabled = False
        Else
            chickenLayer.BackgroundImage = createToppingsLayer(Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_1_en_Default, Dominos.My.Resources.Topping_V_ComponentImage_PizzaChef_Stack_Circle_2_en_Default)
            toppingChicken1.Enabled = True
            toppingChicken2.Enabled = True
            toppingChicken3.Enabled = False
        End If
    End Sub
End Class