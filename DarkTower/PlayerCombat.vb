'Program: DarkTower
'Me: PlayerCombat.vb
'Date: 4/6/2019
'Author: Jason Welch
'Purpose: A class that controls the combat of a player

Option Strict On
Option Explicit On

Public Class PlayerCombat

    Private rand As New Random()
    '==========================================================================================
    'Name: Contructor
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New()

    End Sub
    '==========================================================================================
    'Name: RandomAttack
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Function RandomAttack(warriorCountShort as Short) as Tuple(Of Short,Short)
        Dim brigandCountShort As Short = CShort(rand.Next(1, 25))
        Dim goldCountShort As Short

        MsgBox("You are being attacked by " & brigandCountShort & " Brigands!", vbOKOnly, "Combat with Brigands!")
        warriorCountShort = Combat(brigandCountShort, warriorCountShort)
        If mainForm.currentPlayer.Inventory.WarriorCount <> 0 Then
            goldCountShort = CShort(rand.Next(1, 25))
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Combat!")
        End If
        Return Tuple.Create(warriorCountShort, goldCountShort)
    End Function
    '==========================================================================================
    'Name: CastleBattle
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Function CastleBattle(warriorCountShort As Short, defeatedCastleList As List(Of Short)) As Inventory
        Dim brigandCountShort As Short = CShort(rand.Next(1, 50))
        Dim combatInventory As new Inventory
        combatInventory.WarriorCount = Combat(brigandCountShort, warriorCountShort)
        If warriorCountShort <> 0 Then
            combatInventory.GoldCount = CShort(rand.Next(1, 50))
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
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Combat!")
        End If

        Return combatInventory
    End Function
    '==========================================================================================
    'Name: DarkTowerBattle
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Function DarkTowerBattle(warriorCountShort As Short) as Short
        Dim brigandCountShort As Short = CShort(rand.Next(1, 99))

        warriorCountShort = Combat(brigandCountShort, warriorCountShort)
        If warriorCountShort <> 0 Then
            MsgBox("You have extinguished evil in all the Land. Thank you for playing Dark Tower.", vbOKOnly, "You Have Defeated the Dark Tower!")
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Combat!")
        End If
        Return warriorCountShort
    End Function
    '==========================================================================================
    'Name: WonFight
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Private Function WonFight() As Boolean
        If rand.Next(0, 2) > 0 Then
            Return True
        End If
        Return False
    End Function
    '==========================================================================================
    'Name: Combat
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Private Function Combat(brigandCountShort As Short,warriorCountShort As Short) As Short
        Dim battleResultsString As String
        While brigandCountShort > 0 And mainForm.currentPlayer.Inventory.WarriorCount <> 0S

            If WonFight() Then
                brigandCountShort = CShort(brigandCountShort / 2)
                battleResultsString = "Won"
            Else
                mainForm.currentPlayer.Inventory.WarriorCount -= 1S
                battleResultsString = "Lost"
            End If
            MsgBox("Warriors: " & mainForm.currentPlayer.Inventory.WarriorCount & " Brigands: " & brigandCountShort, vbOKOnly, "Combat " & battleResultsString)
        End While

        If warriorCountShort = 0
            Return 0
        End If
    
        Return warriorCountShort
    End Function
End Class
'================================== No Code Follows ===========================================
