'Program: DarkTower
'Me: PlayerMovement.vb
'Date: 3/30/2019
'Author: Jason Welch
'Purpose: Get and Set Data across forms
Option Strict On
Option Explicit On

Module playerDataModule
    Public currentPlayer As Player

    '==========================================================================================
    'Name: CreateNewPlayer
    'Date: 4/10/19
    'Author: Jason Welch
    'Purpose: Instantiate a New Player
    Public Sub CreateNewPlayer() 
        currentPlayer = New Player
    End Sub
End Module
'================================== No Code Follows ===========================================
