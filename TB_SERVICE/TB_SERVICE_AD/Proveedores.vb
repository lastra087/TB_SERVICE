Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Proveedores

    Dim o_database As Database

    Public Sub New()

        o_database = DatabaseFactory.CreateDatabase("conn")

    End Sub

    Public Function carga_grilla_proveedor() As DataSet

        Return o_database.ExecuteDataSet("carga_grilla_proveedor")

    End Function

    Public Function cargar_proveedor(ByVal Razon_Social As String, ByVal Cuit As String, ByVal Telefono As String, ByVal Direccion As String) As Double

        Return o_database.ExecuteScalar("cargar_proveedor", Razon_Social, Cuit, Telefono, Direccion)

    End Function

    Public Function modificar_proveedor(ByVal ID_Proveedor As Integer, ByVal Razon_Social As String, ByVal Cuit As String, ByVal Telefono As String, ByVal Direccion As String) As Double

        Return o_database.ExecuteScalar("modificar_proveedor", ID_Proveedor, Razon_Social, Cuit, Telefono, Direccion)

    End Function

    Public Function Eliminar_Proveedor(ByVal ID_Proveedor As Integer) As Double
        Return o_database.ExecuteScalar("Eliminar_Proveedor", ID_Proveedor)
    End Function



    Public Function Consultar_Razon_Social(ByVal Razon_Social As String) As DataSet

        Return o_database.ExecuteDataSet("Consultar_Razon_Social", Razon_Social)

    End Function

End Class
