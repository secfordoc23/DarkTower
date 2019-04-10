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

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Close()
    End Sub

    Private Sub combatForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim combat As New PlayerCombat
        combatLogListBox.Items.Clear()
        warriorCountShort = combat.Attack(warriorCountShort, maxBragandCountShort)
    End Sub
End Class
'================================== No Code Follows ===========================================