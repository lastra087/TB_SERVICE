Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Clientes

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function carga_grilla() As DataSet
        Return o_database.ExecuteDataSet("todos_campos")
    End Function

    Public Function buscar_x_nombre(ByVal nombre As String) As DataSet
        Return o_database.ExecuteDataSet("consulta_x_nom", nombre)
    End Function

    Public Function nuevo_cliente(ByVal nombre As String, ByVal apellido As String, ByVal telefono As Long, ByVal correo As String, ByVal cuil As Long) As Double
        Return o_database.ExecuteScalar("nuevo_cliente", nombre, apellido, telefono, correo, cuil)
    End Function

    Public Function modificar_cliente(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal telefono As Long, ByVal correo As String, ByVal cuil As Long) As Double
        Return o_database.executescalar("modifica_cliente", idcliente, nombre, apellido, telefono, correo, cuil)
    End Function

End Class
