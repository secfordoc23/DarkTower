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

    '==========================================================================================
    'Name: WarriorCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set warriorCountShort
    Public Property WarriorCount() As Short = 10S
    '==========================================================================================
    'Name: FoodCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set foodCountShort
    Public Property FoodCount() As Short = 25S
    '==========================================================================================
    'Name: GoldCount()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set goldCountShort
    Public Property GoldCount() As Short = 30S
    '==========================================================================================
    'Name: HaveScout()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveScoutBoolean
    Public Property HaveScout() As Boolean = False
    '==========================================================================================
    'Name: HaveHealer()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveHealerBoolean
    Public Property HaveHealer() As Boolean = False
    '==========================================================================================
    'Name: HaveBeast()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveBeastBoolean
    Public Property HaveBeast() As Boolean = False
    '==========================================================================================
    'Name: HaveBronzeKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveBronzeKeyBoolean
    Public Property HaveBronzeKey() As Boolean = False
    '==========================================================================================
    'Name: HaveSilverKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveSilverKeyBoolean
    Public Property HaveSilverKey() As Boolean = False
    '==========================================================================================
    'Name: HaveGoldKey()
    'Date: 2/18/19
    'Author: Jason Welch
    'Purpose: Get and Set haveGoldKeyBoolean
    Public Property HaveGoldKey() As Boolean = False

End Class
'================================== No Code Follows ===========================================
