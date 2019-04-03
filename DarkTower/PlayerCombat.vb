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
    Public Sub RandomAttack()
        Dim brigandCountShort As Short = CShort(rand.Next(1, 25))
        MsgBox("You are being attacked by " & brigandCountShort & " Brigands!", vbOKOnly, "Fight with Brigands!")
        Fight(brigandCountShort)
        If mainForm.currentPlayer.Inventory.WarriorCount <> 0 Then
            mainForm.currentPlayer.Inventory.GoldCount += CShort(rand.Next(1, 25))
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If

    End Sub
    '==========================================================================================
    'Name: CastleBattle
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Sub CastleBattle()
        Dim brigandCountShort As Short = CShort(rand.Next(1, 50))

        Fight(brigandCountShort)
        If mainForm.currentPlayer.Inventory.WarriorCount <> 0 Then
            mainForm.currentPlayer.Inventory.GoldCount += CShort(rand.Next(1, 50))
            If Not mainForm.currentPlayer.Inventory.HaveBronzeKey Then
                mainForm.currentPlayer.Inventory.HaveBronzeKey = True
            ElseIf Not mainForm.currentPlayer.Inventory.HaveSilverKey And mainForm.currentPlayer.Inventory.HaveBronzeKey Then
                mainForm.currentPlayer.Inventory.HaveSilverKey = True
            ElseIf Not mainForm.currentPlayer.Inventory.HaveGoldKey And mainForm.currentPlayer.Inventory.HaveSilverKey And mainForm.currentPlayer.Inventory.HaveBronzeKey Then
                mainForm.currentPlayer.Inventory.HaveGoldKey = True
            Else
                ' User has all of the keys so do nothing
            End If
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If
    End Sub
    '==========================================================================================
    'Name: DarkTowerBattle
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Sub DarkTowerBattle()
        Dim brigandCountShort As Short = CShort(rand.Next(1, 99))

        Fight(brigandCountShort)
        If mainForm.currentPlayer.Inventory.WarriorCount <> 0 Then
            MsgBox("You have extinguished evil in all the Land. Thank you for playing Dark Tower.", vbOKOnly, "You Have Defeated the Dark Tower!")
        Else
            MsgBox("Your warriors fought valiently, but the enemy was to strong!", vbOKOnly, "You Lost the Fight!")
        End If

    End Sub
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
    'Name: Fight
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Private Sub Fight(brigandCountShort As Short)
        Dim battleResultsString As String
        While brigandCountShort > 0 And mainForm.currentPlayer.Inventory.WarriorCount <> 0S

            If WonFight() Then
                brigandCountShort = CShort(brigandCountShort / 2)
                battleResultsString = "Won"
            Else
                mainForm.currentPlayer.Inventory.WarriorCount -= 1S
                battleResultsString = "Lost"
            End If
            MsgBox("Warriors: " & mainForm.currentPlayer.Inventory.WarriorCount & " Brigands: " & brigandCountShort, vbOKOnly, "Fight " & battleResultsString)
        End While

    End Sub
End Class
'================================== No Code Follows ===========================================
