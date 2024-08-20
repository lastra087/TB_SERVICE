Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Marca_Modelo

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function combo_marca() As DataSet
        Return o_database.ExecuteDataSet("combo_marca")
    End Function

    Public Function nueva_marca(ByVal marca As String) As Double
        Return o_database.ExecuteScalar("nueva_marca", marca)
    End Function

    Public Function cargar_equipo(ByVal Equipo As String, ByVal Marca As Integer) As Double
        Return o_database.ExecuteScalar("cargar_equipo", Equipo, Marca)
    End Function

    Public Function modificar_equipo(ByVal idmodelo As Integer, ByVal modelo As String, ByVal idmarca As Integer) As Double
        Return o_database.ExecuteScalar("modifica_equipo", idmodelo, modelo, idmarca)
    End Function

    Public Function carga_grilla() As DataSet
        Return o_database.ExecuteDataSet("carga_grilla_equipo")
    End Function

    Public Function grilla_x_marca() As DataSet
        Return o_database.ExecuteDataSet("combo_marca")
    End Function

    Public Function eliminar_marca(ByVal marca As String) As Double
        Return o_database.ExecuteScalar("elimina_marca", marca)
    End Function

End Class
