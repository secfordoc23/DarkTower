'Program: DarkTower
'Me: Inventory.vb
'Date: 2/18/19
'Author: Jason Welch
'Purpose: A class to store game inventory data

Option Strict On
Option Explicit On

Public Class Inventory
    Private warriorCountShort As Short
    Private foodCountShort As Short
    Private goldCountShort As Short
    Private haveScoutBoolean As Boolean
    Private haveHealerBoolean As Boolean
    Private haveBeastBoolean As Boolean
    Private haveBronzeKeyBoolean As Boolean
    Private haveSilverKeyBoolean As Boolean
    Private haveGoldKeyBoolean As Boolean

    Private Const MAX_VALUE_SHORT As Short = 99S

    '==========================================================================================
    'Name: New()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Default Constructor
    Public Sub New()
        warriorCountShort = 10S
        foodCountShort = 25S
        goldCountShort = 30S
        haveScoutBoolean = False
        haveHealerBoolean = False
        haveBeastBoolean = False
        haveBronzeKeyBoolean = False
        haveSilverKeyBoolean = False
        haveGoldKeyBoolean = False
    End Sub
    '==========================================================================================
    'Name: WarriorCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set warriorCountShort
    Public Property WarriorCount() As Short
        Get
            Return warriorCountShort
        End Get
        Set(ByVal value As Short)
            warriorCountShort = value
        End Set
    End Property
    '==========================================================================================
    'Name: FoodCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set foodCountShort
    Public Property FoodCount() As Short
        Get
            Return foodCountShort
        End Get
        Set(ByVal value As Short)
            foodCountShort = value
        End Set
    End Property
    '==========================================================================================
    'Name: GoldCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set goldCountShort
    Public Property GoldCount() As Short
        Get
            Return goldCountShort
        End Get
        Set(ByVal value As Short)
            goldCountShort = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveScout()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveScoutBoolean
    Public Property HaveScout() As Boolean
        Get
            Return haveScoutBoolean
        End Get
        Set(ByVal value As Boolean)
            haveScoutBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveHealer()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveHealerBoolean
    Public Property HaveHealer() As Boolean
        Get
            Return haveHealerBoolean
        End Get
        Set(ByVal value As Boolean)
            haveHealerBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveBeast()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveBeastBoolean
    Public Property HaveBeast() As Boolean
        Get
            Return haveBeastBoolean
        End Get
        Set(ByVal value As Boolean)
            haveBeastBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveBronzeKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveBronzeKeyBoolean
    Public Property HaveBronzeKey() As Boolean
        Get
            Return haveBronzeKeyBoolean
        End Get
        Set(ByVal value As Boolean)
            haveBronzeKeyBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveSilverKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveSilverKeyBoolean
    Public Property HaveSilverKey() As Boolean
        Get
            Return haveSilverKeyBoolean
        End Get
        Set(ByVal value As Boolean)
            haveSilverKeyBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: HaveGoldKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveGoldKeyBoolean
    Public Property HaveGoldKey() As Boolean
        Get
            Return haveGoldKeyBoolean
        End Get
        Set(ByVal value As Boolean)
            haveGoldKeyBoolean = value
        End Set
    End Property
    '==========================================================================================
    'Name: AvailableWarriors
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Returns Distance between current Warrior count and Max value
    Public Function HowManyWarriorsToMax() As Short
        Return DistanceToMaxValue(warriorCountShort)
    End Function
    '==========================================================================================
    'Name: AvailableFood
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Returns Distance between current Food count and Max value
    Public Function HowMuchFoodToMax() As Short
        Return DistanceToMaxValue(foodCountShort)
    End Function
    '==========================================================================================
    'Name: AvailableGold
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Returns Distance between current Gold count and Max value
    Public Function HowMuchGoldToMax() As Short
        If HaveBeast Then
            Return DistanceToMaxValue(goldCountShort)
        Else

        End If
        
    End Function
    '==========================================================================================
    'Name: DistanceToMaxValue
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Returns Distance to Max Value
    Private Function DistanceToMaxValue(ByVal currentCount As Short) As Short
        Return MAX_VALUE_SHORT - currentCount
    End Function
    '==========================================================================================
    'Name: UpdateInventory()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Update Inventory on Main Form from Inventory Object
    Public Sub UpdateInventory()
        mainForm.warriorCountLabel.Text = warriorCountShort.ToString()
        mainForm.foodCountLabel.Text = foodCountShort.ToString()
        mainForm.goldCountLabel.Text = goldCountShort.ToString()
        mainForm.scoutCheckBox.Checked = haveScoutBoolean
        mainForm.healerCheckBox.Checked = haveHealerBoolean
        mainForm.beastCheckBox.Checked = haveBeastBoolean
        mainForm.bronzeKeyCheckBox.Checked = haveBronzeKeyBoolean
        mainForm.silverKeyCheckBox.Checked = haveSilverKeyBoolean
        mainForm.goldKeyCheckBox.Checked = haveGoldKeyBoolean
    End Sub
End Class
'================================== No Code Follows ===========================================
