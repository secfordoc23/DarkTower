'Program: DarkTower
'Me: bazaarForm.vb
'Date: 4/10/2019
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On

Public Class bazaarForm
    Public currentInventory As Inventory
    Public purchaseInventory As Inventory

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
        purchaseInventory = New Inventory
        currentGoldLabel.Text = currentInventory.GoldCount.ToString
        purchaseTotalLabel.Text = "0"

    End Sub
    '==========================================================================================
    'Name: buyButton_Click
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click

    End Sub
    '==========================================================================================
    'Name: warriorComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub warriorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles warriorComboBox.SelectedIndexChanged

    End Sub
    '==========================================================================================
    'Name: foodComboBox_SelectedIndexChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub foodComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foodComboBox.SelectedIndexChanged

    End Sub
    '==========================================================================================
    'Name: scoutCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub scoutCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles scoutCheckBox.CheckedChanged

    End Sub
    '==========================================================================================
    'Name: healerCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub healerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles healerCheckBox.CheckedChanged

    End Sub
    '==========================================================================================
    'Name: beastCheckBox_CheckedChanged
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose:
    Private Sub beastCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles beastCheckBox.CheckedChanged

    End Sub

End Class
'================================== No Code Follows ===========================================
