Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Repuestos

    Dim o_database As Database

    Public Sub New()

        o_database = DatabaseFactory.CreateDatabase("conn")

    End Sub

    Public Function cargar_grilla_repuestos() As DataSet

        Return o_database.ExecuteDataSet("cargar_grilla_repuestos")

    End Function

    Public Function combo_proveedor() As DataSet

        Return o_database.ExecuteDataSet("combo_proveedor")

    End Function

    Public Function agregar_repuesto(ByVal repuesto As String, ByVal stock As Integer, ByVal precio As Decimal, ByVal descripcion As String, proveedor As Integer) As Double

        Return o_database.ExecuteScalar("agregar_repuesto", repuesto, stock, precio, descripcion, proveedor)

    End Function

    Public Function modificar_repuesto(ByVal id As Integer, ByVal repuesto As String, ByVal stock As Integer, ByVal precio As Decimal, ByVal descripcion As String, proveedor As Integer) As Double

        Return o_database.ExecuteScalar("modificar_repuesto", id, repuesto, stock, precio, descripcion, proveedor)

    End Function

    Public Function eliminar_repuestos(ByVal id As Integer) As Double

        Return o_database.ExecuteScalar("eliminar_repuestos", id)

    End Function

    Public Function buscar_repuesto(ByVal Nombre As String) As DataSet

        Return o_database.ExecuteDataSet("buscar_repuesto", Nombre)

    End Function

End Class
