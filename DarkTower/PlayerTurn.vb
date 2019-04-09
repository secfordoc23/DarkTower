'Program: DarkTower
'Me: PlayerTurn.vb
'Date: TBD
'Author: Jason Welch
'Purpose: A class that controls the events of a Player taking there turn

Option Strict On
Option Explicit On

Public Class PlayerTurn
    Private combat As PlayerCombat
    Private player As Player
    Private Const MAX_BRIGANDS_RANDOM_ATTACK As Short = 25S
    Private Const MAX_BRIGANDS_CASTLE As Short = 50S
    Private Const MAX_BRIGANDS_DARK_TOWER As Short = 99S

    '==========================================================================================
    'Name: Contructor
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New(currentPlayer As Player)
        combat = New PlayerCombat()
        player = currentPlayer
    End Sub
    '==========================================================================================
    'Name: TakeATurn
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Public Function TakeATurn(moveType As Short) As Short
        Dim warriorCountShort As Short = 0S
        If mainForm.currentPlayer.Inventory.GoldCount = 0 And mainForm.currentPlayer.Inventory.WarriorCount = 0 Then
            moveType = -1
        ElseIf mainForm.currentPlayer.Inventory.FoodCount = 0 Then
            StarvationEvent()
        End If

        Select Case moveType
            Case 0 ' Territory
                GenerateRandomEvent()
            Case 1 ' Castle
                combatForm.warriorCountShort = player.Inventory.WarriorCount
                combatForm.maxBragandCountShort = MAX_BRIGANDS_RANDOM_ATTACK
                combatForm.Show()
                warriorCountShort = combatForm.warriorCountShort
            Case 2 ' Dark Tower
                combat.Attack(player.Inventory.WarriorCount, 99)
            Case Else
                MsgBox("You have lost the game. Please start a new game or load a previous game.", vbOKOnly, "You Have Lost the Game!")
        End Select

        Return warriorCountShort
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
                AttackEvent(player.Inventory.WarriorCount)
            Case Else
                ' Success
        End Select
    End Sub

    '==========================================================================================
    'Name: PlagueEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub PlagueEvent()
        If mainForm.currentPlayer.Inventory.HaveHealer Then
            MsgBox("You Healer has stopped the Plague.  You gain 2 Warriors", vbOKOnly, "Plague Strikes!")
            mainForm.currentPlayer.Inventory.WarriorCount += 2S
        Else
            MsgBox("You have been hit by the Plague! You lose 2 Warriors", vbOKOnly, "Plague Strikes!")
            mainForm.currentPlayer.Inventory.WarriorCount -= 2S
        End If
    End Sub

    '==========================================================================================
    'Name: LostEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub LostEvent()
        If mainForm.currentPlayer.Inventory.HaveScout Then
            MsgBox("Your Scout has found a faster path to your destination.  You gain 2 Food.", vbOKOnly, "Lost in Uncharted Territories!")
            mainForm.currentPlayer.Inventory.FoodCount += 2S
        Else
            MsgBox("You got lost along your journey! You lose 2 Food.", vbOKOnly, "Lost in Uncharted Territories!")
            mainForm.currentPlayer.Inventory.FoodCount -= 2S
        End If
    End Sub

    '==========================================================================================
    'Name: StarvationEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Substracts 1 warrior from user inventory
    Private Sub StarvationEvent()
        MsgBox("Your Warriors are Starving!", vbOKOnly, "Starvation!")
        mainForm.currentPlayer.Inventory.WarriorCount -= 1S
    End Sub
End Class
'================================== No Code Follows ===========================================
