Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class Login

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function inicio_sesion(ByVal username As String, ByVal password As String) As String
        Try
            Dim o_command As DbCommand = o_database.GetStoredProcCommand("inicio_sesion")
            o_database.AddInParameter(o_command, "@usuario", DbType.String, username)
            o_database.AddInParameter(o_command, "@contraseña", DbType.String, password)

            Dim userType As String = Convert.ToString(o_database.ExecuteScalar(o_command))

            If String.IsNullOrEmpty(userType) Then
                Return Nothing
            End If
            Return userType

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
