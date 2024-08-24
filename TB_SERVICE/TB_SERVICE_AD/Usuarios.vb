Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Usuarios

    Dim o_database As Database

    Public Sub New()

        o_database = DatabaseFactory.CreateDatabase("conn")

    End Sub

    Public Function cargar_grilla_usuarios() As DataSet

        Return o_database.ExecuteDataSet("cargar_grilla_usuarios")

    End Function

    Public Function agregar_usuario(ByVal usuario As String, ByVal contraseña As String, ByVal cargo As String) As Double

        Return o_database.ExecuteScalar("agregar_usuario", usuario, contraseña, cargo)

    End Function

    Public Function modificar_usuario(ByVal id As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal cargo As String) As Double

        Return o_database.ExecuteScalar("modificar_usuario", id, usuario, contraseña, cargo)

    End Function

    Public Function eliminar_usuario(ByVal id As Integer) As Double

        Return o_database.ExecuteScalar("eliminar_usuario", id)

    End Function

    Public Function buscar_usuario(ByVal Usuario As String) As DataSet

        Return o_database.ExecuteDataSet("buscar_usuario", Usuario)

    End Function
End Class
