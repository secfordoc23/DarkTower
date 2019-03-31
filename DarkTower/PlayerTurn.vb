'Program: DarkTower
'Me: PlayerTurn.vb
'Date: TBD
'Author: Jason Welch
'Purpose: A class that controls the events of a Player taking there trun

Option Strict On
Option Explicit On

Public Class PlayerTurn
    Private userInventory As Inventory

    '==========================================================================================
    'Name: Contructor
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New(currentInventory As Inventory)
        userInventory = currentInventory
    End Sub
    '==========================================================================================
    'Name: TakeATurn
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Public Function TakeATurn(moveType As Short) As Inventory
        If userInventory.GoldCount = 0 And userInventory.WarriorCount = 0 Then
            moveType = -1
        ElseIf userInventory.FoodCount = 0 Then
            StarvationEvent()
        End If

        Select Case moveType
            Case 0 ' Territory
                GenerateRandomEvent()
                userInventory.FoodCount -= 1S
            Case 1 ' Castle
                CastleEvent()
                userInventory.FoodCount -= 1S
            Case 2 ' Dark Tower
                DarkTowerEvent()
                userInventory.FoodCount -= 1S
            Case Else
                MsgBox("You have lost the game. Please start a new game or load a previous game.", vbOKOnly, "You Have Lost the Game!")
        End Select

        Return userInventory
    End Function
    '==========================================================================================
    'Name: RandomEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Private Sub GenerateRandomEvent()
        Dim rand As New Random
        Dim randomShort As Short

        randomShort = CShort(rand.Next(100) + 1)

        Select Case randomShort
            Case 1 To 20
                PlagueEvent()
            Case 40 To 60
                LostEvent()
            Case 80 To 100
                AttackEvent()
            Case Else
                ' Success
        End Select
    End Sub
    '==========================================================================================
    'Name: CastleEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:  
    Private Sub CastleEvent()
        Dim attackCastle As New PlayerCombat(userInventory)
        userInventory = attackCastle.CastleBattle()
    End Sub
    '==========================================================================================
    'Name: DarkTowerEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:  
    Private Sub DarkTowerEvent()
        Dim attackDarkTower As New PlayerCombat(userInventory)
        userInventory = attackDarkTower.DarkTowerBattle()
    End Sub
    '==========================================================================================
    'Name: PlagueEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub PlagueEvent()
        If userInventory.HaveHealer Then
            MsgBox("You Healer has stopped the Plague.  You gain 2 Warriors", vbOKOnly, "Plague Strikes!")
            userInventory.WarriorCount += 2S
        Else
            MsgBox("You have been hit by the Plague! You lose 2 Warriors", vbOKOnly, "Plague Strikes!")
            userInventory.WarriorCount -= 2S
        End If
    End Sub

    '==========================================================================================
    'Name: LostEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub LostEvent()
        If userInventory.HaveScout Then
            MsgBox("Your Scout has found a faster path to your destination.  You gain 2 Food.", vbOKOnly, "Lost in Uncharted Territories!")
            userInventory.FoodCount += 2S
        Else
            MsgBox("You got lost along your journey! You lose 2 Food.", vbOKOnly, "Lost in Uncharted Territories!")
            userInventory.FoodCount -= 2S
        End If
    End Sub
    '==========================================================================================
    'Name: AttackEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub AttackEvent()
        Dim ambush As New PlayerCombat(userInventory)
        userInventory = ambush.RandomAttack()
    End Sub
    '==========================================================================================
    'Name: StarvationEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Substracts 1 warrior from user inventory
    Private Sub StarvationEvent()
        MsgBox("Your Warriors are Starving!", vbOKOnly, "Starvation!")
        userInventory.WarriorCount -= 1S
    End Sub
End Class
'================================== No Code Follows ===========================================
