'Program: DarkTower
'Me: bazaarForm.vb
'Date: 4/10/2019
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On

Public Class bazaarForm
    Public currentInventory As Inventory
    Private purchaseInventory As Inventory
    Private purchaseGoldCountShort As Short
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
        purchaseInventory = currentInventory
        purchaseGoldCountShort = 0

        With purchaseInventory
            currentGoldLabel.Text = .GoldCount.ToString
            If .HaveScout Then
                scoutCheckBox.Enabled = False
            End If
            scoutCheckBox.Checked = .HaveScout
            If .HaveHealer Then
                healerCheckBox.Enabled = false
            End If
            healerCheckBox.Checked = .HaveHealer
            If .HaveBeast Then
                beastCheckBox.Enabled = false
            End If
            beastCheckBox.Checked = .HaveBeast
            For warriorCountShort As Short = 0 To .HowManyWarriorsToMax
                warriorComboBox.Items.Add(warriorCountShort)
            Next
            For foodCountShort As Short = 0 To .HowMuchFoodToMax
                foodComboBox.Items.Add(foodCountShort)
            Next

        End With
        foodComboBox.SelectedIndex = 0
        warriorComboBox.SelectedIndex = 0
        

    End Sub
    '==========================================================================================
    'Name: buyButton_Click
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        With purchaseInventory
            currentInventory.GoldCount -= purchaseGoldCountShort
            currentInventory.WarriorCount += .WarriorCount
            currentInventory.FoodCount += .FoodCount
            currentInventory.HaveBeast = .HaveBeast
            currentInventory.HaveHealer = .HaveHealer
            currentInventory.HaveScout = .HaveScout 
        End With
    End Sub
    '==========================================================================================
    'Name: warriorComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub warriorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles warriorComboBox.SelectedIndexChanged
        purchaseInventory.WarriorCount = CShort(warriorComboBox.SelectedIndex)
        UpdatePurchaseGold
    End Sub
    '==========================================================================================
    'Name: foodComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub foodComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foodComboBox.SelectedIndexChanged
        purchaseInventory.FoodCount = CShort(foodComboBox.SelectedIndex)
        UpdatePurchaseGold
    End Sub
    '==========================================================================================
    'Name: scoutCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub scoutCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles scoutCheckBox.CheckedChanged
        purchaseInventory.HaveScout = scoutCheckBox.Checked
        UpdatePurchaseGold
    End Sub
    '==========================================================================================
    'Name: healerCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub healerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles healerCheckBox.CheckedChanged
        purchaseInventory.HaveHealer = healerCheckBox.Checked
        UpdatePurchaseGold
    End Sub
    '==========================================================================================
    'Name: beastCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub beastCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles beastCheckBox.CheckedChanged
        purchaseInventory.HaveBeast = beastCheckBox.Checked
        UpdatePurchaseGold
    End Sub

    '==========================================================================================
    'Name: UpdatePurchaseGold
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub UpdatePurchaseGold()
        Dim purchaseGoldCountShort As Short = 0


    End Sub
End Class
'================================== No Code Follows ===========================================
