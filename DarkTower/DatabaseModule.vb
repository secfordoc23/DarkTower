'Program: DarkTower
'Me: darkTowerModule.vb
'Date: TBD
'Author: Jason Welch
'Purpose: 

Option Strict On
Option Explicit On


Imports System.Data.SqlClient

Module DatabaseModule
    Private databaseConnectionString As String = "server=fs01\\sqlexpress;Trusted_Connection=yes" 'Data Source=FS01\SQLEXPRESS;Initial Catalog=DarkTower;User ID=Jason
    Private databaseNameString As String = "DarkTower"

    '==========================================================================================
    'Name: CheckDatabaseExists
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Public Function CheckDatabaseExists(tempConnection As SqlConnection, datbaseNameString As String) As Boolean
        Dim sqlCreateDBQueryString As String

        tempConnection = New SqlConnection("server=fs01\\sqlexpress;Trusted_Connection=yes")

        Return True
    End Function

    '==========================================================================================
    'Name: CheckDatabaseExists
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Public Function CheckTableExists() As Boolean

        Return True
    End Function


    '==========================================================================================
    'Name: CreateGameTable
    'Date: 
    'Author: Jason Welch
    'Purpose: 
    Public Sub CreateGameTable()


    End Sub

    '==========================================================================================
    'Name: CreateGameTable
    'Date: 
    'Author: Jason Welch
    'Purpose:
    Public Sub CreateDatabase()


    End Sub

    '==========================================================================================
    'Name: AddRecordToTable
    'Date: 
    'Author: Jason Welch
    'Purpose:
    Public Sub AddRecordToTable(ByVal recordName As String)


    End Sub

    '==========================================================================================
    'Name: ReadRecordFromTable
    'Date: 
    'Author: Jason Welch
    'Purpose:
    Public Sub ReadRecordFromTable(ByVal recordName As String)


    End Sub

End Module
