Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Taller

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function carga_combo_repuestos() As DataSet
        Return o_database.ExecuteDataSet("Taller_combo_repuesos")
    End Function


    Public Function carga_combo_categorias() As DataSet
        Return o_database.ExecuteDataSet("Taller_combo_categorias")
    End Function
End Class
