Option Strict On
Option Explicit On
'Program: DarkTower
'Me: startPositionForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: Sets the players start location of a new player

Imports System.ComponentModel

Public Class startPositionForm
    '==========================================================================================
    'Name: icelandButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set start Position to IceLand
    Private Sub icelandButton_Click(sender As Object, e As EventArgs) Handles icelandButton.Click
        mainForm.currentPlayer.InitialStartPosition = 40S
        mainForm.currentPlayer.CurrentStartPositon = 40S
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: forestButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set start Position to Forest
    Private Sub forestButton_Click(sender As Object, e As EventArgs) Handles forestButton.Click
        mainForm.currentPlayer.InitialStartPosition = 20S
        mainForm.currentPlayer.CurrentStartPositon = 20S
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: plainsButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set start Position to Plains
    Private Sub plainsButton_Click(sender As Object, e As EventArgs) Handles plainsButton.Click
        mainForm.currentPlayer.InitialStartPosition = 30S
        mainForm.currentPlayer.CurrentStartPositon = 30S
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: desertButton_Click
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Set start Position to Desert
    Private Sub desertButton_Click(sender As Object, e As EventArgs) Handles desertButton.Click
        mainForm.currentPlayer.InitialStartPosition = 10S
        mainForm.currentPlayer.CurrentStartPositon = 10S
        Me.Close()
    End Sub
    '==========================================================================================
    'Name: desertButton_Click
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Call the SetStartPosition Method on the Main Form
    Private Sub startPositionForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mainForm.SetStartPosition()
    End Sub
End Class
'================================== No Code Follows ===========================================