Imports System.Data.OleDb
Module DBConnect
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BSIT2ADirectory.mdb")
End Module
