'Program: DarkTower
'Me: Player.vb
'Date: 4/6/2019
'Author: Jason Welch
'Purpose: A class that holds player data

Option Strict On
Option Explicit On

Public Class Player
    Private playersCurrentInventory As Inventory
    Private hasGameStartedBoolean As Boolean = False
    Private initialStartPositionShort As Short
    Private currentStartPositonShort As Short
    Private currentPositionShort As Short
    Private defeatedCastlesList As List(Of Short)

    '==========================================================================================
    'Name: Contructor
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Default Constructor 
    Public Sub New()
        defeatedCastlesList = New List(Of Short)
        Inventory = New Inventory(True)
    End Sub

    '==========================================================================================
    'Name: HasGameStarted
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Get and Set hasGameStartedBoolean
    Public Property HasGameStarted() As Boolean
        Get
            Return hasGameStartedBoolean
        End Get
        Set(ByVal value As Boolean)
            hasGameStartedBoolean = value
        End Set
    End Property

    '==========================================================================================
    'Name: initialStartPosition
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Get and Set initialStartPositionShort
    Public Property InitialStartPosition() As Short
        Get
            Return initialStartPositionShort
        End Get
        Set(ByVal value As Short)
            initialStartPositionShort = value
        End Set
    End Property

    '==========================================================================================
    'Name: currentStartPositon
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Get and Set currentStartPositonShort
    Public Property CurrentStartPositon() As Short
        Get
            Return currentStartPositonShort
        End Get
        Set(ByVal value As Short)
            currentStartPositonShort = value
        End Set
    End Property

    '==========================================================================================
    'Name: currentPosition
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Get and Set currentPositionShort
    Public Property CurrentPosition() As Short
        Get
            Return currentPositionShort
        End Get
        Set(ByVal value As Short)
            currentPositionShort = value
        End Set
    End Property

    '==========================================================================================
    'Name: Inventory
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Get and Set currentPositionShort
    Public Property Inventory() As Inventory
        Get
            Return playersCurrentInventory
        End Get
        Set(ByVal value As Inventory)
            playersCurrentInventory = value
        End Set
    End Property

    '==========================================================================================
    'Name: AddDefeatedCastle
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Add Castle to DefeatedCastleList
    Public Sub AddDefeatedCastle(castleShort As Short)
        defeatedCastlesList.Add(castleShort)
    End Sub

    Public Function GetDefeatedCastleList() As List(Of Short)
        Return defeatedCastlesList
    End Function

    '==========================================================================================
    'Name: HasCastleBeenDefeated
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Returns true if castleShort is in List
    Public Function HasCastleBeenDefeated(castleShort As Short) As Boolean
        Return defeatedCastlesList.Contains(castleShort)
    End Function

    '==========================================================================================
    'Name: UpdateInventoryDisplay()
    'Date: 4/6/19
    'Author: Jason Welch
    'Purpose: Update Displayed Inventory on Main Form from Inventory Object
    Public Sub UpdateInventoryDisplay()
        mainForm.warriorCountLabel.Text = playersCurrentInventory.WarriorCount.ToString()
        mainForm.foodCountLabel.Text = playersCurrentInventory.FoodCount.ToString()
        mainForm.goldMaxLabel.Text = "/ " & playersCurrentInventory.GoldMax().ToString()
        mainForm.goldCountLabel.Text = playersCurrentInventory.GoldCount.ToString()
        mainForm.scoutCheckBox.Checked = playersCurrentInventory.HaveScout
        mainForm.healerCheckBox.Checked = playersCurrentInventory.HaveHealer
        mainForm.beastCheckBox.Checked = playersCurrentInventory.HaveBeast
        mainForm.bronzeKeyCheckBox.Checked = playersCurrentInventory.HaveBronzeKey
        mainForm.silverKeyCheckBox.Checked = playersCurrentInventory.HaveSilverKey
        mainForm.goldKeyCheckBox.Checked = playersCurrentInventory.HaveGoldKey
    End Sub

End Class
'================================== No Code Follows ===========================================
