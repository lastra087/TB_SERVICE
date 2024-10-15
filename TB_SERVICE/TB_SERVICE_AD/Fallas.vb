Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class Fallas

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function Carga_grilla() As DataSet
        Return o_database.ExecuteDataSet("Fallas_carga_grilla")
    End Function

    Public Function Carga_grilla_X_fallo() As DataSet
        Return o_database.ExecuteDataSet("Fallas_categoria_fallas")
    End Function

    Public Function Carga_combofallas() As DataSet
        Return o_database.ExecuteDataSet("Fallas_combo_categorias")
    End Function

    Public Function Guardar_cat(ByVal categoria As String) As Double
        Return o_database.ExecuteScalar("Fallas_gaurda_categoria", categoria)
    End Function

    Public Function Modificar_categoria(ByVal id_cat As Integer, ByVal categoria As String) As Double
        Return o_database.ExecuteScalar("Fallas_modifica_categoria", id_cat, categoria)
    End Function

    Public Function Eliminar_categoria(ByVal id_cat As Integer) As Double
        Return o_database.ExecuteScalar("Fallas_elimina_cat", id_cat)
    End Function

    Public Function Guardar_fallo(ByVal fallo As String, ByVal id_cat As Integer) As Double
        Return o_database.ExecuteScalar("Fallas_guargas_falla", fallo, id_cat)
    End Function

    Public Function Modificar_fallo(ByVal id_fallo As Integer, ByVal fallo As String, ByVal id_cat As Integer) As Double
        Return o_database.ExecuteScalar("Fallas_modifica_falla", id_fallo, fallo, id_cat)
    End Function

    Public Function Eliminar_fallo(ByVal id_fallo As Integer) As Double
        Return o_database.ExecuteScalar("Fallas_eiminar_fallo", id_fallo)
    End Function

End Class
