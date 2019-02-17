'Program: DarkTower
'Me: mainForm.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On

Public Class mainForm
    Private Box(11, 11) As PictureBox
    '==========================================================================================
    'Name: BuildMap
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub BuildMap()
        For rowShort As Short = 0S To 11S
            For columnShort As Short = 0S To 11S
                DrawBox(rowShort, columnShort)
            Next columnShort
        Next rowShort
    End Sub
    '==========================================================================================
    'Name: DrawBox
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub DrawBox(rowShort As Short, columnShort As Short)
        Box(rowShort, columnShort) = New PictureBox
        Box(rowShort, columnShort).Size = CType(New Point(50, 50), Size)
        Box(rowShort, columnShort).BorderStyle = BorderStyle.FixedSingle

    End Sub
    '==========================================================================================
    'Name: mainForm_Load
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuildMap()
    End Sub
End Class
