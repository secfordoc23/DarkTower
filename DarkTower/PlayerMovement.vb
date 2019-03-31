'Program: DarkTower
'Me: PlayerMovement.vb
'Date: 3/30/2019
'Author: Jason Welch
'Purpose: A class that controls the movement of a player

Option Strict On
Option Explicit On

Public Class PlayerMovement
    Private startPositionShort As Short
    Private selectedPositionShort As Short
    Private currentPositionShort As Short
    Private validMovesList As New List(Of Short)
    '==========================================================================================
    'Name: Contructor
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New(startPositionShort As Short)
        Me.startPositionShort = startPositionShort
    End Sub
    '==========================================================================================
    'Name: ValidateMove
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Validates a players Move
    Public Function ValidateMove(currentPositionShort As Short, selectedPositionShort As Short) As Boolean
        Dim isValidBoolean As Boolean = False
        Me.selectedPositionShort = selectedPositionShort
        Me.currentPositionShort = currentPositionShort
        validMovesList.Clear()

        Select Case currentPositionShort
            Case 10, 20, 30, 40
                validMovesList.Add(startPositionShort + 6S)
                validMovesList.Add(currentPositionShort)
            Case 16, 26, 36, 46
                validMovesList.Add(startPositionShort + 5S)
                validMovesList.Add(startPositionShort + 7S)
                validMovesList.Add(startPositionShort + 9S)
            Case 15, 25, 35, 46
                validMovesList.Add(startPositionShort + 6S)
                validMovesList.Add(startPositionShort + 4S)
                validMovesList.Add(startPositionShort + 2S)
            Case 17, 27, 37, 47
                validMovesList.Add(startPositionShort + 6S)
                validMovesList.Add(startPositionShort + 8S)
                validMovesList.Add(startPositionShort + 3S)
            Case 14, 24, 34, 44
                validMovesList.Add(startPositionShort + 5S)
            Case 18, 28, 38, 48
                validMovesList.Add(startPositionShort + 7S)
            Case 12, 22, 32, 42
                validMovesList.Add(startPositionShort + 5S)
                validMovesList.Add(startPositionShort * 10S)
            Case 13, 23, 33, 43
                validMovesList.Add(startPositionShort + 7S)
                validMovesList.Add(startPositionShort + 9S)
            Case 11, 21, 31, 41
                validMovesList.Add(startPositionShort + 9S)
                validMovesList.Add(0)
            Case 19, 29, 39, 49 ' Castle
                validMovesList.Add(startPositionShort + 1S)
                validMovesList.Add(startPositionShort + 2S)
                validMovesList.Add(startPositionShort + 3S)
                validMovesList.Add(startPositionShort + 6S)
            Case Else
                Return isValidBoolean
        End Select

        isValidBoolean = VerifyMoveInList(validMovesList)
        Return isValidBoolean
    End Function
    '==========================================================================================
    'Name: VerifyMoveInList
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Verifies that move is in List
    Private Function VerifyMoveInList(validMoveList As List(Of Short)) As Boolean
        If validMoveList.Contains(selectedPositionShort) Then
            Return True
        End If
        MsgBox("Invalid Move From Current Position.", vbOKOnly, "Invalid Move!")
        Return False
    End Function
    '==========================================================================================
    'Name: MovePlayer
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: 
    Public Sub MovePlayer()
        Select Case startPositionShort
            Case 10
                setPlayerPositionDesert()
                If Not selectedPositionShort Mod 10 = 0 Then
                    ResetDesertPictureBox()
                End If
            Case 20
                setPlayerPositionForest()
                If Not selectedPositionShort Mod 10 = 0 Then
                    ResetForestPictureBox()
                End If
            Case 30
                setPlayerPositionPlains()
                If Not selectedPositionShort Mod 10 = 0 Then
                    ResetPlainsPictureBox()
                End If
            Case 40
                setPlayerPositionIceland()
                If Not selectedPositionShort Mod 10 = 0 Then
                    ResetIcelandPictureBox()
                End If
        End Select
    End Sub
    '==========================================================================================
    'Name: setPlayerPositionDesert
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Sets Tile to Player Tile 
    Private Sub setPlayerPositionDesert()
        Select Case selectedPositionShort
            Case 10
                mainForm.startTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 16
                mainForm.desertTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 15
                mainForm.desertTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 17
                mainForm.desertTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 14
                mainForm.desertTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 18
                mainForm.desertTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 12
                mainForm.desertTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 13
                mainForm.desertTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 11
                mainForm.desertTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 19
                mainForm.castleTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select
    End Sub
    '==========================================================================================
    'Name: ResetDesertPictureBox
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Resets Tile to Default Background Image
    Private Sub ResetDesertPictureBox()
        Select Case currentPositionShort
            Case 10
                mainForm.startTile1PictureBox.BackgroundImage = My.Resources.YellowTile
            Case 16
                mainForm.desertTile6PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 15
                mainForm.desertTile5PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 17
                mainForm.desertTile7PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 14
                mainForm.desertTile4PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 18
                mainForm.desertTile8PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 12
                mainForm.desertTile2PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 13
                mainForm.desertTile3PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 11
                mainForm.desertTile1PictureBox.BackgroundImage = My.Resources.BrownTile
            Case 19
                mainForm.castleTile1PictureBox.BackgroundImage = My.Resources.GrayTile
        End Select
    End Sub
    '==========================================================================================
    'Name: setPlayerPositionForest
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Sets Tile to Player Tile 
    Private Sub setPlayerPositionForest()
        Select Case selectedPositionShort
            Case 20
                mainForm.startTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 26
                mainForm.forestTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 25
                mainForm.forestTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 27
                mainForm.forestTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 24
                mainForm.forestTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 28
                mainForm.forestTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 22
                mainForm.forestTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 23
                mainForm.forestTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 21
                mainForm.forestTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 29
                mainForm.castleTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select
    End Sub
    '==========================================================================================
    'Name: ResetForestPictureBox
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Resets Tile to Default Background Image
    Private Sub ResetForestPictureBox()
        Select Case currentPositionShort
            Case 20
                mainForm.startTile2PictureBox.BackgroundImage = My.Resources.YellowTile
            Case 26
                mainForm.forestTile6PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 25
                mainForm.forestTile5PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 27
                mainForm.forestTile7PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 24
                mainForm.forestTile4PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 28
                mainForm.forestTile8PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 22
                mainForm.forestTile2PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 23
                mainForm.forestTile3PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 21
                mainForm.forestTile1PictureBox.BackgroundImage = My.Resources.GreenTile
            Case 29
                mainForm.castleTile2PictureBox.BackgroundImage = My.Resources.GrayTile
        End Select
    End Sub
    '==========================================================================================
    'Name: setPlayerPositionPlains
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Sets Tile to Player Tile 
    Private Sub setPlayerPositionPlains()
        Select Case selectedPositionShort
            Case 30
                mainForm.startTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 36
                mainForm.plainTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 35
                mainForm.plainTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 37
                mainForm.plainTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 34
                mainForm.plainTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 38
                mainForm.plainTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 32
                mainForm.plainTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 33
                mainForm.plainTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 31
                mainForm.plainTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 39
                mainForm.castleTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select
    End Sub
    '==========================================================================================
    'Name: ResetPlainsPictureBox
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Resets Tile to Default Background Image
    Private Sub ResetPlainsPictureBox()
        Select Case currentPositionShort
            Case 30
                mainForm.startTile3PictureBox.BackgroundImage = My.Resources.YellowTile
            Case 36
                mainForm.plainTile6PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 35
                mainForm.plainTile5PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 37
                mainForm.plainTile7PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 34
                mainForm.plainTile4PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 38
                mainForm.plainTile8PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 32
                mainForm.plainTile2PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 33
                mainForm.plainTile3PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 31
                mainForm.plainTile1PictureBox.BackgroundImage = My.Resources.LightGreenTile
            Case 39
                mainForm.castleTile3PictureBox.BackgroundImage = My.Resources.GrayTile
        End Select
    End Sub
    '==========================================================================================
    'Name: setPlayerPositionIceland
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Sets Tile to Player Tile 
    Private Sub setPlayerPositionIceland()
        Select Case selectedPositionShort
            Case 10
                mainForm.startTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 16
                mainForm.icelandTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 15
                mainForm.icelandTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 17
                mainForm.icelandTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 14
                mainForm.icelandTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 18
                mainForm.icelandTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 12
                mainForm.icelandTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 13
                mainForm.icelandTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 11
                mainForm.icelandTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 19
                mainForm.castleTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select
    End Sub
    '==========================================================================================
    'Name: ResetIcelandPictureBox
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Resets Tile to Default Background Image
    Private Sub ResetIcelandPictureBox()
        Select Case currentPositionShort
            Case 10
                mainForm.startTile4PictureBox.BackgroundImage = My.Resources.YellowTile
            Case 16
                mainForm.icelandTile6PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 15
                mainForm.icelandTile5PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 17
                mainForm.icelandTile7PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 14
                mainForm.icelandTile4PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 18
                mainForm.icelandTile8PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 12
                mainForm.icelandTile2PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 13
                mainForm.icelandTile3PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 11
                mainForm.icelandTile1PictureBox.BackgroundImage = My.Resources.LightBlueTile
            Case 19
                mainForm.castleTile4PictureBox.BackgroundImage = My.Resources.GrayTile
        End Select
    End Sub
End Class
'================================== No Code Follows ===========================================
