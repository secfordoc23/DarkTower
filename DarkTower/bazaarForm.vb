'Program: DarkTower
'Me: bazaarForm.vb
'Date: 4/10/2019
'Author: Jason Welch
'Purpose: Allow Player to buy Items

Option Strict On
Option Explicit On

Public Class bazaarForm
    Private purchaseInventory As Inventory
    Private purchaseGoldCountShort As Short
    Private currentGoldCountShort As Short
    Private Const ONE_TIME_BUY_AMOUNT As Short = 20S
    Private Const WARRIOR_AMOUNT_PER As Short = 5S
    Private Const FOOD_AMOUNT_PER As Short = 1S

    '==========================================================================================
    'Name: cancelButton_Click
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose: Close Bazaar Form
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: bazaarForm_Load
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub bazaarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bazaar, AudioPlayMode.Background)
        purchaseInventory = New Inventory(False)
        currentGoldCountShort = currentPlayer.Inventory.GoldCount
        purchaseGoldCountShort = 0

        With currentPlayer.Inventory
            If .HaveScout Then
                scoutCheckBox.Enabled = False
            End If
            purchaseInventory.HaveScout = .HaveScout
            scoutCheckBox.Checked = .HaveScout

            If .HaveHealer Then
                healerCheckBox.Enabled = False
            End If
            purchaseInventory.HaveHealer = .HaveHealer
            healerCheckBox.Checked = .HaveHealer

            If .HaveBeast Then
                beastCheckBox.Enabled = False
            End If
            purchaseInventory.HaveBeast = .HaveBeast
            beastCheckBox.Checked = .HaveBeast

            For warriorCountShort As Short = 0 To .HowManyWarriorsToMax
                warriorComboBox.Items.Add(warriorCountShort)
            Next
            purchaseInventory.WarriorCount = 0
            For foodCountShort As Short = 0 To .HowMuchFoodToMax
                foodComboBox.Items.Add(foodCountShort)
            Next
            purchaseInventory.FoodCount = 0
        End With
        currentGoldLabel.Text = currentPlayer.Inventory.GoldCount.ToString
        foodComboBox.SelectedIndex = 0
        warriorComboBox.SelectedIndex = 0
    End Sub
    '==========================================================================================
    'Name: buyButton_Click
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        currentPlayer.Inventory.GoldCount -= purchaseGoldCountShort
        With purchaseInventory
            currentPlayer.Inventory.WarriorCount += .WarriorCount
            currentPlayer.Inventory.FoodCount += .FoodCount
            currentPlayer.Inventory.HaveBeast = .HaveBeast
            currentPlayer.Inventory.HaveHealer = .HaveHealer
            currentPlayer.Inventory.HaveScout = .HaveScout
        End With
        currentPlayer.UpdateInventoryDisplay()
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: warriorComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub warriorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles warriorComboBox.SelectedIndexChanged
        If (purchaseGoldCountShort + (warriorComboBox.SelectedIndex * WARRIOR_AMOUNT_PER)) > currentGoldCountShort Then
            MsgBox("Your purchase has exceeded your available gold!", vbOKOnly, "Unable to Purchase!")
            warriorComboBox.SelectedIndex = 0
        Else
            purchaseInventory.WarriorCount = CShort(warriorComboBox.SelectedIndex)
        End If
        UpdatePurchaseGold()
    End Sub
    '==========================================================================================
    'Name: foodComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub foodComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foodComboBox.SelectedIndexChanged
        If (purchaseGoldCountShort + (foodComboBox.SelectedIndex * FOOD_AMOUNT_PER)) > currentGoldCountShort Then
            MsgBox("Your purchase has exceeded your available gold!", vbOKOnly, "Unable to Purchase!")
            foodComboBox.SelectedIndex = 0
        Else
            purchaseInventory.FoodCount = CShort(foodComboBox.SelectedIndex)
        End If
        UpdatePurchaseGold()
    End Sub
    '==========================================================================================
    'Name: scoutCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub scoutCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles scoutCheckBox.CheckedChanged
        If scoutCheckBox.Checked = True And purchaseInventory.HaveScout = False Then
            If purchaseGoldCountShort + ONE_TIME_BUY_AMOUNT > currentGoldCountShort Then
                MsgBox("Your purchase has exceeded your available gold!", vbOKOnly, "Unable to Purchase!")
                scoutCheckBox.Checked = False
            Else
                purchaseInventory.HaveScout = True
            End If
            'Else
            '    purchaseInventory.HaveScout = False
        End If
        UpdatePurchaseGold()
    End Sub
    '==========================================================================================
    'Name: healerCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub healerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles healerCheckBox.CheckedChanged
        If healerCheckBox.Checked = True And purchaseInventory.HaveHealer = False Then
            If purchaseGoldCountShort + ONE_TIME_BUY_AMOUNT > currentGoldCountShort Then
                MsgBox("Your purchase has exceeded your available gold!", vbOKOnly, "Unable to Purchase!")
                healerCheckBox.Checked = False
            Else
                purchaseInventory.HaveHealer = True
            End If
            'Else
            '    purchaseInventory.HaveHealer = False
        End If
        UpdatePurchaseGold()
    End Sub
    '==========================================================================================
    'Name: beastCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub beastCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles beastCheckBox.CheckedChanged
        If beastCheckBox.Checked = True And purchaseInventory.HaveBeast = False Then
            If purchaseGoldCountShort + ONE_TIME_BUY_AMOUNT > currentGoldCountShort Then
                MsgBox("Your purchase has exceeded your available gold!", vbOKOnly, "Unable to Purchase!")
                beastCheckBox.Checked = False
            Else
                purchaseInventory.HaveBeast = True
            End If
            'Else
            '    purchaseInventory.HaveBeast = False
        End If
        UpdatePurchaseGold()
    End Sub
    '==========================================================================================
    'Name: UpdatePurchaseGold
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub UpdatePurchaseGold()
        purchaseGoldCountShort = 0

        If beastCheckBox.Enabled And beastCheckBox.Checked Then
            purchaseGoldCountShort += ONE_TIME_BUY_AMOUNT
        End If

        If healerCheckBox.Enabled And healerCheckBox.Checked Then
            purchaseGoldCountShort += ONE_TIME_BUY_AMOUNT
        End If

        If scoutCheckBox.Enabled And scoutCheckBox.Checked Then
            purchaseGoldCountShort += ONE_TIME_BUY_AMOUNT
        End If

        purchaseGoldCountShort += CShort(warriorComboBox.SelectedIndex * WARRIOR_AMOUNT_PER)

        purchaseGoldCountShort += CShort(foodComboBox.SelectedIndex * FOOD_AMOUNT_PER)

        purchaseTotalLabel.Text = purchaseGoldCountShort.ToString
    End Sub
End Class
'================================== No Code Follows ===========================================
