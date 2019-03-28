Option Strict On
Option Explicit On
'Program: DarkTower
'Me: mainForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Imports System.ComponentModel

Public Class mainForm
    Private currentInventory As Inventory
    Private currentPlayer As PlayerTurn
    Public startPositionShort As Short = 1S

    '==========================================================================================
    'Name: mainForm_Load
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'splashForm.ShowDialog()

    End Sub
    '==========================================================================================
    'Name: NewGameToolStripMenuItem_Click
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        currentInventory = New Inventory
        currentInventory.UpdateInventory()
        currentPlayer = New PlayerTurn(currentInventory)
        startPositionForm.Show()
        Me.Hide()
        currentPlayer.UserPosition = startPositionShort
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

    Private Sub BazarrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BazarrToolStripMenuItem.Click
        bazaarForm.Show()
    End Sub
End Class
'================================== No Code Follows ===========================================
