'Program: DarkTower
'Me: combatForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: A class that controls the events of a Player taking there turn

Option Strict On
Option Explicit On

Public Class combatForm
    Public maxBragandCountShort As Short = 0
    Public warriorCountShort As Short = 0
    Private rand As Random
    Private brigandCountShort As Short = 0

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Close()
    End Sub

    Private Sub combatForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        brigandCountShort = GetBrigandCount(maxBragandCountShort)
        combatLogListBox.Items.Add("You are being attacked by " & brigandCountShort & " Brigands!")

    End Sub

    Private Sub combatForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        combatLogListBox.Items.Clear()
        rand = New Random()
        okButton.Enabled = False
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
    Private Sub Combat()
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
            combatLogListBox.Items.Add(battleResultsString & " - Warriors: " & warriorCountShort & " Brigands: " & brigandCountShort)
            Threading.Thread.Sleep(2000)
        End While

        If warriorCountShort = 0 Then
            combatLogListBox.Items.Add("Battle Lost!")
        Else
            combatLogListBox.Items.Add("Battle Won!")
        End If
    End Sub

    Private Sub startCombatButton_Click(sender As Object, e As EventArgs) Handles startCombatButton.Click
        Combat()
        okButton.Enabled = True
    End Sub
End Class
'================================== No Code Follows ===========================================