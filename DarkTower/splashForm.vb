'Program: DarkTower
'Me: splashForm.vb
'Date: 4/10/2019
'Author: Jason Welch
'Purpose: Display a Splash screen for my program


Option Explicit On
Option Strict On

Public Class splashForm

    '==========================================================================================
    'Name: splashTimer_Tick
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Timer for Splash Screen
    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        Me.Close()
        splashTimer.Enabled = False
    End Sub

End Class
'================================== No Code Follows ===========================================