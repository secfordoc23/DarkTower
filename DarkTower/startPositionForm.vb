'Program: DarkTower
'Me: startPositionForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: Sets the players start location of a new player

Option Strict On
Option Explicit On


Public Class startPositionForm
    '==========================================================================================
    'Name: icelandButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set startPositionShort
    Private Sub icelandButton_Click(sender As Object, e As EventArgs) Handles icelandButton.Click
        mainForm.startPositionShort = 4S
        mainForm.Show()
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: forestButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set startPositionShort
    Private Sub forestButton_Click(sender As Object, e As EventArgs) Handles forestButton.Click
        mainForm.startPositionShort = 2S
        mainForm.Show()
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: plainsButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set startPositionShort
    Private Sub plainsButton_Click(sender As Object, e As EventArgs) Handles plainsButton.Click
        mainForm.startPositionShort = 3S
        mainForm.Show()
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: desertButton_Click(
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set startPositionShort
    Private Sub desertButton_Click(sender As Object, e As EventArgs) Handles desertButton.Click
        mainForm.startPositionShort = 1S
        mainForm.Show()
        Me.Close()
    End Sub
    ' Need to Make a Closing Method to Clean up code
End Class
'================================== No Code Follows ===========================================