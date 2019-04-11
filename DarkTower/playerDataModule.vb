'Program: DarkTower
'Me: PlayerMovement.vb
'Date: 3/30/2019
'Author: Jason Welch
'Purpose: Get and Set Data across forms
Option Strict On
Option Explicit On

Module playerDataModule
    Private currentInventory As Inventory
    Private currentGoldShort As Short
    '==========================================================================================
    'Name: GetCurrentInventory
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose: Get and Set Inventory
    Public Property GetCurrentInventory() As Inventory
        Get
            Return currentInventory
        End Get
        Set(ByVal value As Inventory)
            currentInventory = value
        End Set
    End Property

    '==========================================================================================
    'Name: GetCurrentGold
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose: Get and Set Current Gold
    Public Property GetCurrentGold() As Short
        Get
            Return currentGoldShort
        End Get
        Set(ByVal value As Short)
            currentGoldShort = value
        End Set
    End Property
End Module
'================================== No Code Follows ===========================================
