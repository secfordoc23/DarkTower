Option Strict On
Option Explicit On
'Program: DarkTower
'Me: mainForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Imports System.ComponentModel

Public Class mainForm
    Private currentMove As PlayerMovement
    Private loot As CombatLoot

    Private Const MAX_BRIGANDS_RANDOM_ATTACK As Short = 25S
    Private Const MAX_BRIGANDS_CASTLE As Short = 50S
    Private Const MAX_BRIGANDS_DARK_TOWER As Short = 99S

    '==========================================================================================
    'Name: mainForm_Load
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        splashForm.ShowDialog()
        CreateNewPlayer()
        currentPlayer.HasGameStarted = False
    End Sub
    '==========================================================================================
    'Name: NewGameToolStripMenuItem_Click
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        CreateNewPlayer()

        currentMove = New PlayerMovement
        currentMove.ResetMap()

        currentPlayer.UpdateInventoryDisplay()
        currentPlayer.HasGameStarted = True

        startPositionForm.ShowDialog()
    End Sub
    '==========================================================================================
    'Name: mainForm_Closing
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Gives user opportunity to not leave program
    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
    '==========================================================================================
    'Name: ExitToolStripMenuItem_Click
    'Date: 2/10/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    '==========================================================================================
    'Name: BazarrToolStripMenuItem_Click
    'Date: 3/28/2019
    'Author: Jason Welch
    'Purpose: Shows the Bazaar Form
    Private Sub BazarrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BazarrToolStripMenuItem.Click
        bazaarForm.ShowDialog()
    End Sub
    '==========================================================================================
    'Name: SetStartPosition
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets the Users Start Location
    Public Sub SetStartPosition(startPositionShort As Short)
        If currentPlayer.HasGameStarted Then
            currentPlayer.CurrentPosition = startPositionShort
            currentPlayer.CurrentStartPositon = startPositionShort
            currentPlayer.InitialStartPosition = startPositionShort
            currentMove.SetInitialStartPosition(startPositionShort)
        End If

    End Sub
    '==========================================================================================
    'Name: SetPosition
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets the Users Location
    Public Sub SetPosition(selectedPositionShort As Short)
        If currentPlayer.HasGameStarted Then
            If currentMove.ValidateMove(currentPlayer.CurrentStartPositon, currentPlayer.CurrentPosition, selectedPositionShort) Then
                currentMove.MovePlayer(currentPlayer.CurrentPosition, selectedPositionShort)
                If selectedPositionShort = 19 Or selectedPositionShort = 29 Or selectedPositionShort = 39 Or selectedPositionShort = 49 Then
                    If Not currentPlayer.HasCastleBeenDefeated(selectedPositionShort) Then
                        TakeATurn(1)
                        If currentPlayer.Inventory.WarriorCount <> 0 Then
                            loot = New CombatLoot
                            With loot.CastleLoot(currentPlayer.GetDefeatedCastleList())
                                currentPlayer.Inventory.GoldCount += .GoldCount
                                currentPlayer.Inventory.HaveBronzeKey = .HaveBronzeKey
                                currentPlayer.Inventory.HaveSilverKey = .HaveSilverKey
                                currentPlayer.Inventory.HaveGoldKey = .HaveGoldKey
                            End With
                            currentPlayer.AddDefeatedCastle(selectedPositionShort)
                        End If
                    Else
                        MsgBox("You have already defeated this Castle!", vbOKOnly, "Castle Defeated!")
                    End If
                ElseIf selectedPositionShort = 0 Then
                    If currentPlayer.Inventory.HaveBronzeKey And currentPlayer.Inventory.HaveSilverKey And currentPlayer.Inventory.HaveGoldKey Then
                        TakeATurn(2)
                    Else
                        MsgBox("You DO NOT have all of the Keys to unlock the Dark Tower", vbOKOnly, "The Dark Tower")
                    End If
                Else
                    TakeATurn(0)
                End If
                currentPlayer.CurrentPosition = selectedPositionShort
                currentPlayer.Inventory.FoodCount -= 1S
                currentPlayer.UpdateInventoryDisplay()
            End If
        End If
    End Sub
    '==========================================================================================
    'Name: TakeATurn
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Private Sub TakeATurn(moveType As Short)

        If currentPlayer.Inventory.GoldCount = 0 And currentPlayer.Inventory.WarriorCount = 0 Then
            moveType = -1
        ElseIf currentPlayer.Inventory.FoodCount = 0 Then
            StarvationEvent()
        End If

        Select Case moveType
            Case 0 ' Territory
                GenerateRandomEvent()
            Case 1 ' Castle
                My.Computer.Audio.Play(My.Resources.tomb_battle, AudioPlayMode.WaitToComplete)
                combatForm.warriorCountShort = currentPlayer.Inventory.WarriorCount
                combatForm.maxBragandCountShort = MAX_BRIGANDS_CASTLE
                combatForm.ShowDialog()
                currentPlayer.Inventory.WarriorCount = combatForm.warriorCountShort
            Case 2 ' Dark Tower
                My.Computer.Audio.Play(My.Resources.sanctuary, AudioPlayMode.WaitToComplete)
                combatForm.warriorCountShort = currentPlayer.Inventory.WarriorCount
                combatForm.maxBragandCountShort = MAX_BRIGANDS_DARK_TOWER
                combatForm.ShowDialog()
                currentPlayer.Inventory.WarriorCount = combatForm.warriorCountShort
                If currentPlayer.Inventory.WarriorCount > 0 Then
                    MsgBox("Your have defeated the Dark Tower, and recovered the Stolen Scepter.  Thank you for playing.", vbOKOnly, "You Have Defeated the Dark Tower!")
                    currentPlayer.HasGameStarted = False
                End If
            Case Else
                MsgBox("You have lost the game. Please start a new game or load a previous game.", vbOKOnly, "You Have Lost the Game!")
        End Select

    End Sub
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
                combatForm.warriorCountShort = currentPlayer.Inventory.WarriorCount
                combatForm.maxBragandCountShort = MAX_BRIGANDS_RANDOM_ATTACK
                combatForm.ShowDialog()
                currentPlayer.Inventory.WarriorCount = combatForm.warriorCountShort
                If currentPlayer.Inventory.WarriorCount <> 0 Then
                    loot = New CombatLoot
                    currentPlayer.Inventory.GoldCount += loot.RandomAttackLoot()
                End If
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
        My.Computer.Audio.Play(My.Resources.plague, AudioPlayMode.Background)
        Dim gameEvent = New eventForm
        gameEvent.eventPictureBox.BackgroundImage = My.Resources.Plague1
        If currentPlayer.Inventory.HaveHealer Then
            gameEvent.eventRichTextBox.Text = "Plague Strikes!"  & vbCrLf & vbCrLf & "You Healer has stopped the Plague." & vbCrLf & "You gain 2 Warriors"
            currentPlayer.Inventory.WarriorCount += 2S
        Else
            gameEvent.eventRichTextBox.Text = "Plague Strikes!"  & vbCrLf & vbCrLf & "You have been hit by the Plague!" & vbCrLf & "You lose 2 Warriors"
            currentPlayer.Inventory.WarriorCount -= 2S
        End If
        gameEvent.ShowDialog()
    End Sub

    '==========================================================================================
    'Name: LostEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: 
    Private Sub LostEvent()
        My.Computer.Audio.Play(My.Resources.lost, AudioPlayMode.Background)
        Dim gameEvent = New eventForm
        gameEvent.eventPictureBox.BackgroundImage = My.Resources.LostImage
        If currentPlayer.Inventory.HaveScout Then
            gameEvent.eventRichTextBox.Text = "Lost in Uncharted Territories!" & vbCrLf & vbCrLf & " Your Scout has found a faster path to your destination." & vbCrLf & "You gain 2 Food."
            currentPlayer.Inventory.FoodCount += 2S
        Else
            gameEvent.eventRichTextBox.Text = "Lost in Uncharted Territories!" & vbCrLf & vbCrLf & "You got lost along your journey!" & vbCrLf & "You lose 2 Food."
            currentPlayer.Inventory.FoodCount -= 2S
        End If
        gameEvent.ShowDialog()
    End Sub

    '==========================================================================================
    'Name: StarvationEvent
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Substracts 1 warrior from user inventory
    Private Sub StarvationEvent()
        My.Computer.Audio.Play(My.Resources.starving, AudioPlayMode.Background)
        MsgBox("Your Warriors are Starving!", vbOKOnly, "Starvation!")
        currentPlayer.Inventory.WarriorCount -= 1S
    End Sub

    '==========================================================================================
    'Name: MoveToStartPosition
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets the Users Location
    Private Sub MoveToStartPosition(selectedStartPosition As Short)
        My.Computer.Audio.Play(My.Resources.pegasus, AudioPlayMode.Background)
        currentMove.MovePlayer(currentPlayer.CurrentPosition, selectedStartPosition)
        currentPlayer.CurrentPosition = selectedStartPosition
        currentPlayer.CurrentStartPositon = selectedStartPosition
    End Sub
    '==========================================================================================
    'Name: MoveToStartPosition1ToolStripMenuItem_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets Start Position to 1
    Private Sub MoveToStartPosition1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToStartPosition1ToolStripMenuItem.Click
        MoveToStartPosition(10S)
        MoveToStartPosition1ToolStripMenuItem.Enabled = False
        MoveToStartPosition2ToolStripMenuItem1.Enabled = True
        MoveToStartPosition3ToolStripMenuItem2.Enabled = True
        MoveToStartPosition4ToolStripMenuItem3.Enabled = True
    End Sub
    '==========================================================================================
    'Name: MoveToStartPosition2ToolStripMenuItem1_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets Start Position to 2
    Private Sub MoveToStartPosition2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveToStartPosition2ToolStripMenuItem1.Click
        MoveToStartPosition(20S)
        MoveToStartPosition1ToolStripMenuItem.Enabled = True
        MoveToStartPosition2ToolStripMenuItem1.Enabled = False
        MoveToStartPosition3ToolStripMenuItem2.Enabled = True
        MoveToStartPosition4ToolStripMenuItem3.Enabled = True
    End Sub
    '==========================================================================================
    'Name: MoveToStartPosition3ToolStripMenuItem2_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets Start Position to 3
    Private Sub MoveToStartPosition3ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MoveToStartPosition3ToolStripMenuItem2.Click
        MoveToStartPosition(30S)
        MoveToStartPosition1ToolStripMenuItem.Enabled = True
        MoveToStartPosition2ToolStripMenuItem1.Enabled = True
        MoveToStartPosition3ToolStripMenuItem2.Enabled = False
        MoveToStartPosition4ToolStripMenuItem3.Enabled = True
    End Sub
    '==========================================================================================
    'Name: MoveToStartPosition4ToolStripMenuItem3_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Sets Start Position to 4
    Private Sub MoveToStartPosition4ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MoveToStartPosition4ToolStripMenuItem3.Click
        MoveToStartPosition(40S)
        MoveToStartPosition1ToolStripMenuItem.Enabled = True
        MoveToStartPosition2ToolStripMenuItem1.Enabled = True
        MoveToStartPosition3ToolStripMenuItem2.Enabled = True
        MoveToStartPosition4ToolStripMenuItem3.Enabled = False
    End Sub
    '==========================================================================================
    'Name: desertTile6PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile6PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile6PictureBox.Click
        SetPosition(16)
    End Sub
    '==========================================================================================
    'Name: desertTile5PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile5PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile5PictureBox.Click
        SetPosition(15)
    End Sub
    '==========================================================================================
    'Name: desertTile7PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile7PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile7PictureBox.Click
        SetPosition(17)
    End Sub
    '==========================================================================================
    'Name: desertTile4PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile4PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile4PictureBox.Click
        SetPosition(14)
    End Sub
    '==========================================================================================
    'Name: desertTile8PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile8PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile8PictureBox.Click
        SetPosition(18)
    End Sub
    '==========================================================================================
    'Name: desertTile2PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile2PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile2PictureBox.Click
        SetPosition(12)
    End Sub
    '==========================================================================================
    'Name: desertTile3PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile3PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile3PictureBox.Click
        SetPosition(13)
    End Sub
    '==========================================================================================
    'Name: castleTile1PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub castleTile1PictureBox_Click(sender As Object, e As EventArgs) Handles castleTile1PictureBox.Click
        SetPosition(19)
    End Sub
    '==========================================================================================
    'Name: desertTile1PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub desertTile1PictureBox_Click(sender As Object, e As EventArgs) Handles desertTile1PictureBox.Click
        SetPosition(11)
    End Sub
    '==========================================================================================
    'Name: darkTowerTilePictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub darkTowerTilePictureBox_Click(sender As Object, e As EventArgs) Handles darkTowerTilePictureBox.Click
        SetPosition(0)
    End Sub
    '==========================================================================================
    'Name: forestTile1PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile1PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile1PictureBox.Click
        SetPosition(21)
    End Sub
    '==========================================================================================
    'Name: forestTile2PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile2PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile2PictureBox.Click
        SetPosition(22)
    End Sub
    '==========================================================================================
    'Name: castleTile2PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub castleTile2PictureBox_Click(sender As Object, e As EventArgs) Handles castleTile2PictureBox.Click
        SetPosition(29)
    End Sub
    '==========================================================================================
    'Name: forestTile3PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile3PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile3PictureBox.Click
        SetPosition(23)
    End Sub
    '==========================================================================================
    'Name: forestTile4PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile4PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile4PictureBox.Click
        SetPosition(24)
    End Sub
    '==========================================================================================
    'Name: forestTile5PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile5PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile5PictureBox.Click
        SetPosition(25)
    End Sub
    '==========================================================================================
    'Name: forestTile6PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile6PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile6PictureBox.Click
        SetPosition(26)
    End Sub
    '==========================================================================================
    'Name: forestTile7PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile7PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile7PictureBox.Click
        SetPosition(27)
    End Sub
    '==========================================================================================
    'Name: forestTile8PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub forestTile8PictureBox_Click(sender As Object, e As EventArgs) Handles forestTile8PictureBox.Click
        SetPosition(28)
    End Sub
    '==========================================================================================
    'Name: plainTile1PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile1PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile1PictureBox.Click
        SetPosition(31)
    End Sub
    '==========================================================================================
    'Name: castleTile3PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub castleTile3PictureBox_Click(sender As Object, e As EventArgs) Handles castleTile3PictureBox.Click
        SetPosition(39)
    End Sub
    '==========================================================================================
    'Name: plainTile2PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile2PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile2PictureBox.Click
        SetPosition(32)
    End Sub
    '==========================================================================================
    'Name: plainTile3PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile3PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile3PictureBox.Click
        SetPosition(33)
    End Sub
    '==========================================================================================
    'Name: plainTile4PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile4PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile4PictureBox.Click
        SetPosition(34)
    End Sub
    '==========================================================================================
    'Name: plainTile5PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile5PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile5PictureBox.Click
        SetPosition(35)
    End Sub
    '==========================================================================================
    'Name: plainTile6PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile6PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile6PictureBox.Click
        SetPosition(36)
    End Sub
    '==========================================================================================
    'Name: plainTile7PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile7PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile7PictureBox.Click
        SetPosition(37)
    End Sub
    '==========================================================================================
    'Name: plainTile8PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub plainTile8PictureBox_Click(sender As Object, e As EventArgs) Handles plainTile8PictureBox.Click
        SetPosition(38)
    End Sub
    '==========================================================================================
    'Name: icelandTile1PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile1PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile1PictureBox.Click
        SetPosition(41)
    End Sub
    '==========================================================================================
    'Name: castleTile4PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub castleTile4PictureBox_Click(sender As Object, e As EventArgs) Handles castleTile4PictureBox.Click
        SetPosition(49)
    End Sub
    '==========================================================================================
    'Name: icelandTile2PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile2PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile2PictureBox.Click
        SetPosition(42)
    End Sub
    '==========================================================================================
    'Name: icelandTile3PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile3PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile3PictureBox.Click
        SetPosition(43)
    End Sub
    '==========================================================================================
    'Name: icelandTile8PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile8PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile8PictureBox.Click
        SetPosition(48)
    End Sub
    '==========================================================================================
    'Name: icelandTile7PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile7PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile7PictureBox.Click
        SetPosition(47)
    End Sub
    '==========================================================================================
    'Name: icelandTile6PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile6PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile6PictureBox.Click
        SetPosition(46)
    End Sub
    '==========================================================================================
    'Name: icelandTile5PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile5PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile5PictureBox.Click
        SetPosition(45)
    End Sub
    '==========================================================================================
    'Name: icelandTile4PictureBox_Click
    'Date: 3/30/2019
    'Author: Jason Welch
    'Purpose: Move to tile position
    Private Sub icelandTile4PictureBox_Click(sender As Object, e As EventArgs) Handles icelandTile4PictureBox.Click
        SetPosition(44)
    End Sub

End Class
'================================== No Code Follows ===========================================
