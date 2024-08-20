Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Categorias

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub


End Class
