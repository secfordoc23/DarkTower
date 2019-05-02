'Program: DarkTower
'Me: CombatLoot.vb
'Date: 4/7/19
'Author: Jason Welch
'Purpose: A class that controls the loot from combat

Option Strict On
Option Explicit On

Public Class CombatLoot
    Private rand As Random
    Private const MAX_RANDOM_ATTACK_GOLD As Short = 25S
    Private const MAX_CASTLE_GOLD As Short = 50S
    '==========================================================================================
    'Name: Contructor
    'Date: 4/7/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New()
        rand = New Random()
    End Sub
    '==========================================================================================
    'Name: CastleLoot
    'Date: 4/7/19
    'Author: Jason Welch
    'Purpose: 
    Public Function CastleLoot(defeatedCastleList As List(Of Short)) As Inventory
        Dim combatInventory As New Inventory(False)
        Dim randomNumber As Short
        combatInventory.WarriorCount = currentPlayer.Inventory.WarriorCount

        combatInventory.GoldCount = GenerateGold(MAX_CASTLE_GOLD)

        If defeatedCastleList.Count = 0 Then
            combatInventory.HaveBronzeKey = True
            combatInventory.HaveSilverKey = False
            combatInventory.HaveGoldKey = False
        ElseIf defeatedCastleList.Count = 1 Then
            combatInventory.HaveBronzeKey = True
            combatInventory.HaveSilverKey = True
            combatInventory.HaveGoldKey = False
        ElseIf defeatedCastleList.Count = 2 Then
            combatInventory.HaveBronzeKey = True
            combatInventory.HaveSilverKey = True
            combatInventory.HaveGoldKey = True
        Else
            ' User has all of the keys so do nothing
        End If

        If Not currentPlayer.Inventory.HaveDragonSword Then
            randomNumber = CShort(rand.Next(1, 10))
            If randomNumber Mod 2 = 0 Then
                combatInventory.HaveDragonSword = True
            End If
        Else
            combatInventory.HaveDragonSword = True
        End If

        Return combatInventory
    End Function
    '==========================================================================================
    'Name: RandomAttackLoot
    'Date: 4/7/19
    'Author: Jason Welch
    'Purpose: 
    Public Function RandomAttackLoot() As Short
        Return GenerateGold(MAX_RANDOM_ATTACK_GOLD)
    End Function
    '==========================================================================================
    'Name: GenerateGold
    'Date: 4/7/19
    'Author: Jason Welch
    'Purpose: 
    Private Function GenerateGold(maxGold As Short) As Short
        Return CShort(rand.Next(10, maxGold))
    End Function
End Class
'================================== No Code Follows ===========================================
