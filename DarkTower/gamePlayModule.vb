'Program: DarkTower
'Me: gamePlayModule.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On

Module gamePlayModule
    Public currentInventory As Inventory

    '==========================================================================================
    'Name: RandomEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event on Each Turn
    Public Function RandomEvent() As String
        Dim rand As New Random
        Dim randomShort As Short

        randomShort = CShort(rand.Next(100) + 1)

        Select Case randomShort
            Case 1 To 20
                Return "Plague"
            Case 40 To 60
                Return "Lost"
            Case 80 To 100
                Return "Attacked"
            Case Else
                Return "Success"
        End Select
    End Function

    '==========================================================================================
    'Name: TakeATurn
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event
    Public Sub TakeATurn()

    End Sub
End Module
'================================== No Code Follows ===========================================
