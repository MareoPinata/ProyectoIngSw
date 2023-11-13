Imports System.Data.SqlClient
Module ConexionBD
    Public Function ObtenerConexion() As SqlConnection
        Dim cadenaConexion As String = "Data Source='DESKTOP-NU4UVLE';Initial Catalog=INGSW;Integrated Security=True"
        Dim conexion As New SqlConnection(cadenaConexion)
        Return conexion
    End Function
End Module
