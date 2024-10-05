Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Estadisticas
    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    'del chat
    'Dim connection As New SqlConnection(ConnectionString)
    'Public Function ObtenerDatosVentasPorMes() As DataSet
    '    Dim oDs As New DataSet
    '    ' Asumiendo que tienes una conexión configurada en tu clase
    '    Dim db As Database = DatabaseFactory.CreateDatabase("conn")
    '    Dim sqlCommand As String = "SELECT Mes, CantidadVentas FROM VentasPorMes"
    '    Dim dbCommand As Common.DbCommand = db.GetSqlStringCommand(sqlCommand)
    '    oDs = db.ExecuteDataSet(dbCommand)
    '    Return oDs
    'End Function
    'fin del chat


    Public Function Marcas_sala_espera() As DataSet
        Return o_database.ExecuteDataSet("Estadisticas_carga_cahrt")
    End Function

End Class
