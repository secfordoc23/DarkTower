'Program: DarkTower
'Me: PlayerCombat.vb
'Date: 4/6/2019
'Author: Jason Welch
'Purpose: A class that controls the combat of a player

Option Strict On
Option Explicit On

Public Class PlayerCombat

    Private rand As Random
    '==========================================================================================
    'Name: Contructor
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New()
        rand = New Random()
    End Sub
    '==========================================================================================
    'Name: RandomAttack
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Public Function Attack(warriorCountShort As Short, maxBrigandCount As Short) As Short
        Dim brigandCountShort As Short = GetBrigandCount(maxBrigandCount)

        combatForm.combatLogListBox.Items.Add("You are being attacked by " & brigandCountShort & " Brigands!")

        Return Combat(brigandCountShort, warriorCountShort)
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
    'Name: GetBrigandCount
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Private Function GetBrigandCount(maxBrigandsShort As Short) As Short
        Return CShort(rand.Next(1, maxBrigandsShort))
    End Function
    '==========================================================================================
    'Name: Combat
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose:
    Private Function Combat(brigandCountShort As Short, warriorCountShort As Short) As Short
        Dim battleResultsString As String
        While brigandCountShort > 0 And warriorCountShort > 0S

            If WonFight() Then
                brigandCountShort = CShort(brigandCountShort / 2)
                battleResultsString = "Won"
                My.Computer.Audio.Play(My.Resources.enemy_hit, AudioPlayMode.WaitToComplete)
            Else
                warriorCountShort -= 1S
                battleResultsString = "Lost"
                My.Computer.Audio.Play(My.Resources.player_hit, AudioPlayMode.WaitToComplete)
            End If
            combatForm.combatLogListBox.Items.Add(battleResultsString & " - Warriors: " & warriorCountShort & " Brigands: " & brigandCountShort)
        End While

        If warriorCountShort = 0 Then
            combatForm.combatLogListBox.Items.Add("Battle Lost!")
        Else
            combatForm.combatLogListBox.Items.Add("Battle Won!")
        End If

        Return warriorCountShort
    End Function
End Class
'================================== No Code Follows ===========================================
