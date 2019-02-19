'Program: DarkTower
'Me: turnModule.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On

Module gamePlayModule
    Public currentInventory As Inventory

    '==========================================================================================
    'Name: UpdateInventory()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Update Inventory on Main Form from Inventory Object
    Public Sub UpdateInventory()
        With currentInventory
            mainForm.warriorCountLabel.Text = .WarriorCount.ToString
            mainForm.foodCountLabel.Text = .FoodCount.ToString
            mainForm.goldCountLabel.Text = .GoldCount.ToString
            mainForm.scoutCheckBox.Checked = .HaveScout
            mainForm.healerCheckBox.Checked = .HaveHealer
            mainForm.beastCheckBox.Checked = .HaveBeast
            mainForm.bronzeKeyCheckBox.Checked = .HaveBronzeKey
            mainForm.silverKeyCheckBox.Checked = .HaveSilverKey
            mainForm.goldKeyCheckBox.Checked = .HaveGoldKey
        End With
    End Sub
End Module
'================================== No Code Follows ===========================================
