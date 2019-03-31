'Program: DarkTower
'Me: PlayerCombat.vb
'Date: 4/6/2019
'Author: Jason Welch
'Purpose: A class that controls the combat of a player

Option Strict On
Option Explicit On

Public Class PlayerCombat
    Private userInventory As Inventory
    '==========================================================================================
    'Name: Contructor
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New(userInventory As Inventory)
        Me.userInventory = userInventory
    End Sub

    Public Function RandomAttack() As Inventory
        Dim brigandCountShort As Short = CShort(Rnd() * 50)
        MsgBox("You are being attacked by " & brigandCountShort & " Brigands!", vbOKOnly, "Battle with Brigands!")
        Battle(brigandCountShort)
        If userInventory.WarriorCount <> 0 Then
            userInventory.GoldCount += CShort(Rnd() * 50)
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If

        Return userInventory
    End Function

    Public Function CastleBattle() As Inventory
        Dim brigandCountShort As Short = CShort(Rnd() * 100)

        Battle(brigandCountShort)
        If userInventory.WarriorCount <> 0 Then
            userInventory.GoldCount += CShort(Rnd() * 100)
            If Not userInventory.HaveBronzeKey Then
                userInventory.HaveBronzeKey = True
            ElseIf Not userInventory.HaveSilverKey And userInventory.HaveBronzeKey Then
                userInventory.HaveSilverKey = True
            ElseIf Not userInventory.HaveGoldKey And userInventory.HaveSilverKey And userInventory.HaveBronzeKey Then
                userInventory.HaveGoldKey = True
            Else
                ' User has all of the keys so do nothing
            End If
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If

        Return userInventory
    End Function

    Public Function DarkTowerBattle() As Inventory
        Dim brigandCountShort As Short = CShort(Rnd() * 200)

        Battle(brigandCountShort)
        If userInventory.WarriorCount <> 0 Then
            MsgBox("You have extinguished evil in all the Land. Thank you for playing Dark Tower.", vbOKOnly, "You Have Defeated the Dark Tower!")
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If

        Return userInventory
    End Function

    Private Function WonFight() As Boolean
        If (Rnd() * 2) = 1 Then
            Return True
        End If
        Return False
    End Function

    Private Sub Battle(brigandCountShort As Short)
        While brigandCountShort > 0 And userInventory.WarriorCount <> 0S

            If WonFight() Then
                brigandCountShort = CShort(brigandCountShort / 2)
            Else
                userInventory.WarriorCount -= 1S
            End If
        End While

    End Sub
End Class
'================================== No Code Follows ===========================================
