'Program: DarkTower
'Me: PlayerTurn.vb
'Date: TBD
'Author: Jason Welch
'Purpose: A class that controls the events of a Player taking there trun

Option Strict On
Option Explicit On

Public Class PlayerTurn
    Private userInventory As Inventory
    Private userPositionShort As Short

    '==========================================================================================
    'Name: Contructor
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New(ByVal currentInventory As Inventory)
        userInventory = currentInventory
    End Sub
    '==========================================================================================
    'Name: TakeATurn
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Public Sub TakeATurn(ByVal moveType As Short)
        Select Case moveType
            Case 0 ' Territory
                GenerateRandomEvent()
            Case 1 ' Crypt
            Case 2 ' Dark Tower
            Case Else
                MsgBox("Move Type not Recognized!", MsgBoxStyle.Critical, "Move Type Error")
        End Select
    End Sub
    '==========================================================================================
    'Name: RandomEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: Generate a Random Event 
    Private Function GenerateRandomEvent() As String
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
    'Name: CryptEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose:  

    '==========================================================================================
    'Name: DarkTowerEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose:  

    '==========================================================================================
    'Name: PlagueEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: 

    '==========================================================================================
    'Name: LostEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: 

    '==========================================================================================
    'Name: AttackEvent
    'Date: 2/19/19
    'Author: Jason Welch
    'Purpose: 

    '==========================================================================================
    'Name: UserPosition()
    'Date: 3/28/19
    'Author: Jason Welch
    'Purpose: Get and Set userPositionShort
    Public Property UserPosition() As Short
        Get
            Return userPositionShort
        End Get
        Set(ByVal value As Short)
            userPositionShort = value
        End Set
    End Property
End Class
'================================== No Code Follows ===========================================
