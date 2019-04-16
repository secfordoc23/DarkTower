'Program: DarkTower
'Me: PlayerMovement.vb
'Date: 3/30/2019
'Author: Jason Welch
'Purpose: A class that controls the movement of a player

Option Strict On
Option Explicit On

Public Class PlayerMovement
    '==========================================================================================
    'Name: Contructor
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New()

    End Sub
    '==========================================================================================
    'Name: ValidateMove
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Validates a players Move
    Public Function ValidateMove(startPositionShort As Short, currentPositionShort As Short, selectedPositionShort As Short) As Boolean
        Dim isValidBoolean As Boolean = False
        Dim validMovesList As New List(Of Short)

        Select Case currentPositionShort
            Case 10, 20, 30, 40
                validMovesList.Add(startPositionShort + 6S)
                validMovesList.Add(currentPositionShort)
            Case 16, 26, 36, 46
                validMovesList.Add(startPositionShort + 5S)
                validMovesList.Add(startPositionShort + 7S)
                validMovesList.Add(startPositionShort + 9S)
            Case 15, 25, 35, 45
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
                validMovesList.Add(startPositionShort + 9S)
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

        isValidBoolean = VerifyMoveInList(validMovesList, selectedPositionShort)
        Return isValidBoolean
    End Function
    '==========================================================================================
    'Name: VerifyMoveInList
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Verifies that move is in List
    Private Function VerifyMoveInList(validMoveList As List(Of Short), selectedPositionShort As Short) As Boolean
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
    Public Sub MovePlayer(currentPositionShort As Short, selectedPositionShort As Short)
        Select Case selectedPositionShort
            Case 10 ' Start Postion 1
                mainForm.startTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 11
                mainForm.desertTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 12
                mainForm.desertTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 13
                mainForm.desertTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 14
                mainForm.desertTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 15
                mainForm.desertTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 16
                mainForm.desertTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 17
                mainForm.desertTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 18
                mainForm.desertTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 19 ' Castle 1
                mainForm.castleTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 20 ' Start Position 2
                mainForm.startTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 21
                mainForm.forestTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 22
                mainForm.forestTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 23
                mainForm.forestTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 24
                mainForm.forestTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 25
                mainForm.forestTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 26
                mainForm.forestTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 27
                mainForm.forestTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 28
                mainForm.forestTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 29 ' Castle 2
                mainForm.castleTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 30 ' Start Position 3
                mainForm.startTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 31
                mainForm.plainTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 32
                mainForm.plainTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 33
                mainForm.plainTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 34
                mainForm.plainTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 35
                mainForm.plainTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 36
                mainForm.plainTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 37
                mainForm.plainTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 38
                mainForm.plainTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 39 ' Castle 3
                mainForm.castleTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 40 ' Start Position 4
                mainForm.startTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 41
                mainForm.icelandTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 42
                mainForm.icelandTile2PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 43
                mainForm.icelandTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 44
                mainForm.icelandTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 45
                mainForm.icelandTile5PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 46
                mainForm.icelandTile6PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 47
                mainForm.icelandTile7PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 48
                mainForm.icelandTile8PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 49 ' Castle 4
                mainForm.castleTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select

        ' Reset Current Position
        ResetTile(currentPositionShort)
    End Sub
    '==========================================================================================
    'Name: ResetTile
    'Date: 3/30/19
    'Author: Jason Welch
    'Purpose: Reset a given tile
    Private Sub ResetTile(currentStartPositionShort As Short)
        Select Case currentStartPositionShort
            Case 10 ' Start Postion 1
                mainForm.startTile1PictureBox.BackgroundImage = My.Resources.StartLocation
            Case 11
                mainForm.desertTile1PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 12
                mainForm.desertTile2PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 13
                mainForm.desertTile3PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 14
                mainForm.desertTile4PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 15
                mainForm.desertTile5PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 16
                mainForm.desertTile6PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 17
                mainForm.desertTile7PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 18
                mainForm.desertTile8PictureBox.BackgroundImage = My.Resources.Desert2Texture
            Case 19 ' Castle 1
                mainForm.castleTile1PictureBox.BackgroundImage = My.Resources.castle
            Case 20 ' Start Position 2
                mainForm.startTile2PictureBox.BackgroundImage = My.Resources.StartLocation
            Case 21
                mainForm.forestTile1PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 22
                mainForm.forestTile2PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 23
                mainForm.forestTile3PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 24
                mainForm.forestTile4PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 25
                mainForm.forestTile5PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 26
                mainForm.forestTile6PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 27
                mainForm.forestTile7PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 28
                mainForm.forestTile8PictureBox.BackgroundImage = My.Resources.Forest1Texture
            Case 29 ' Castle 2
                mainForm.castleTile2PictureBox.BackgroundImage = My.Resources.castle
            Case 30 ' Start Position 3
                mainForm.startTile3PictureBox.BackgroundImage = My.Resources.StartLocation
            Case 31
                mainForm.plainTile1PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 32
                mainForm.plainTile2PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 33
                mainForm.plainTile3PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 34
                mainForm.plainTile4PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 35
                mainForm.plainTile5PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 36
                mainForm.plainTile6PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 37
                mainForm.plainTile7PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 38
                mainForm.plainTile8PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
            Case 39 ' Castle 3
                mainForm.castleTile3PictureBox.BackgroundImage = My.Resources.castle
            Case 40 ' Start Position 4
                mainForm.startTile4PictureBox.BackgroundImage = My.Resources.StartLocation
            Case 41
                mainForm.icelandTile1PictureBox.BackgroundImage = My.Resources.snow1
            Case 42
                mainForm.icelandTile2PictureBox.BackgroundImage = My.Resources.snow1
            Case 43
                mainForm.icelandTile3PictureBox.BackgroundImage = My.Resources.snow1
            Case 44
                mainForm.icelandTile4PictureBox.BackgroundImage = My.Resources.snow1
            Case 45
                mainForm.icelandTile5PictureBox.BackgroundImage = My.Resources.snow1
            Case 46
                mainForm.icelandTile6PictureBox.BackgroundImage = My.Resources.snow1
            Case 47
                mainForm.icelandTile7PictureBox.BackgroundImage = My.Resources.snow1
            Case 48
                mainForm.icelandTile8PictureBox.BackgroundImage = My.Resources.snow1
            Case 49 ' Castle 4
                mainForm.castleTile4PictureBox.BackgroundImage = My.Resources.castle
        End Select
    End Sub
    '==========================================================================================
    'Name: ResetMap
    'Date: 4/4/19
    'Author: Jason Welch
    'Purpose: Reset the all the tiles on the Map
    Public Sub ResetMap()
        ' Location 1
        mainForm.startTile1PictureBox.BackgroundImage = My.Resources.StartLocation
        mainForm.desertTile1PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile2PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile3PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile4PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile5PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile6PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile7PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.desertTile8PictureBox.BackgroundImage = My.Resources.Desert2Texture
        mainForm.castleTile1PictureBox.BackgroundImage = My.Resources.castle
        ' Location 2
        mainForm.startTile2PictureBox.BackgroundImage = My.Resources.StartLocation
        mainForm.forestTile1PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile2PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile3PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile4PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile5PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile6PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile7PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.forestTile8PictureBox.BackgroundImage = My.Resources.Forest1Texture
        mainForm.castleTile2PictureBox.BackgroundImage = My.Resources.castle
        ' Location 3
        mainForm.startTile3PictureBox.BackgroundImage = My.Resources.StartLocation
        mainForm.plainTile1PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile2PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile3PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile4PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile5PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile6PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile7PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.plainTile8PictureBox.BackgroundImage = My.Resources.grass_corner_inner_southwest_f2
        mainForm.castleTile3PictureBox.BackgroundImage = My.Resources.castle
        ' Location 4
        mainForm.startTile4PictureBox.BackgroundImage = My.Resources.StartLocation
        mainForm.icelandTile1PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile2PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile3PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile4PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile5PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile6PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile7PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.icelandTile8PictureBox.BackgroundImage = My.Resources.snow1
        mainForm.castleTile4PictureBox.BackgroundImage = My.Resources.castle
    End Sub
    '==========================================================================================
    'Name: SetInitialStartPosition
    'Date: 4/1/19
    'Author: Jason Welch
    'Purpose: Sets Players Start position tile
    Public Sub SetInitialStartPosition(startPositionShort As Short)
        Select Case startPositionShort
            Case 10
                mainForm.startTile1PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 20
                mainForm.startTile2PictureBox.BackgroundImage = My.Resources.PlayerTile

            Case 30
                mainForm.startTile3PictureBox.BackgroundImage = My.Resources.PlayerTile
            Case 40
                mainForm.startTile4PictureBox.BackgroundImage = My.Resources.PlayerTile
        End Select

    End Sub
End Class
'================================== No Code Follows ===========================================
