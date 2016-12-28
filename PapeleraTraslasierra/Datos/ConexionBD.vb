Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Threading.Tasks




Public Class ConexionDB

    Private Shared strConexion As String = "Data Source=SGA\SQL2014; DataBase=Papelera; integrated security=sspi"
    Private Shared objConexion As New SqlConnection(strConexion)
    Public Conexion As New SqlConnection(strConexion)


    Public Shared Sub AbrirConexion()
        Try
            ''Antes de abrir la conexion me fijo si ya no esta abierta
            'If Not (objConexion.State = ConnectionState.Closed) Then
            objConexion.Open()

            'End If
        Catch ex As InvalidOperationException
            Throw ex
        Finally
            objConexion.Close()

        End Try
    End Sub

    Public Sub CerrarConexion()
        Try

            objConexion.Open()
        Catch ex1 As InvalidOperationException
            Throw ex1
        Finally
            objConexion.Close()
        End Try
    End Sub

    Public Shared Function ObtenerConexion() As SqlConnection
        AbrirConexion()
        Return objConexion
    End Function

    Public Shared Function ObtenerDatos(nombreStoreProcedure As String, Optional parametros As List(Of SqlParameter) = Nothing) As DataTable
        'Este metodo nos permite obtener cualquier dato proveniente de un procedimiento almacenado de la base
        'Lo creamos para no tener que estar realizando conexiones en todo el codigo

        'Me tienen que pasar un nombre si o si para poder ejecutar
        If String.IsNullOrEmpty(nombreStoreProcedure) Then
            Throw New Exception("Debe espeficicar el nombre del Store Procedure que se ejecutara")
        End If

        If parametros Is Nothing Then
            parametros = New List(Of SqlParameter)()
        End If

        Dim miConexion As SqlConnection = ObtenerConexion()

        Try
            Dim Comando As New SqlCommand(nombreStoreProcedure, miConexion)
            Comando.CommandType = CommandType.StoredProcedure

            miConexion.Open()

            'Ahora agregamos la coleccion de parametros que me enviaron 
            For Each p As SqlParameter In parametros
                'Controlo que el parametro tenga un nombre
                If String.IsNullOrEmpty(p.ParameterName) Then
                    Throw New Exception("Existe un parametro que no se le especifico su nombre")
                End If
                'Controlo que el parametro tenga un valor
                If p.Value Is Nothing Then
                    Throw New Exception("Existe un parametro que no se le asigno un valor")
                End If

                'Parece que el parametro esta bien, lo agregamos al comando
                Comando.Parameters.Add(p)
            Next

            Dim objDataAdapter As New SqlDataAdapter(nombreStoreProcedure, miConexion)
            objDataAdapter.SelectCommand = Comando
            objDataAdapter.SelectCommand.Connection = miConexion

            Dim datos As DataTable = New System.Data.DataTable()

            objDataAdapter.Fill(datos)

            'Devuelvo los datos

            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            'Cierro la conexion, ya no la uso
            miConexion.Close()
        End Try
    End Function



    Public Shared Sub EjecutarProcedimientoAlmacenado(nombreStoreProcedure As String, parametros As List(Of SqlParameter))
        'Este metodo nos permite obtener cualquier dato proveniente de un SP de la base
        'Lo creamos para no tener que estar realizando conexiones en todo el codigo

        'Me tienen que pasar un nombre si o si para poder ejecutar
        If String.IsNullOrEmpty(nombreStoreProcedure) Then
            Throw New Exception("Debe espeficicar el nombre del Store Procedure que se ejecutara")
        End If

        If parametros Is Nothing Then
            parametros = New List(Of SqlParameter)()
        End If

        Dim miConexion As SqlConnection = ObtenerConexion()

        Try
            Dim Comando As New SqlCommand(nombreStoreProcedure, miConexion)
            Comando.CommandType = CommandType.StoredProcedure

            miConexion.Open()

            'Ahora agregamos la coleccion de parametros que me enviaron 
            For Each p As SqlParameter In parametros
                'Controlo que el parametro tenga un nombre
                If String.IsNullOrEmpty(p.ParameterName) Then
                    Throw New Exception("Existe un parametro que no se le especifico su nombre")
                End If
                'Controlo que el parametro tenga un valor si es que no es un parametro de retorno
                If p.Direction <> ParameterDirection.Output AndAlso p.Value Is Nothing Then
                    Throw New Exception("Existe un parametro que no se le asigno un valor")
                End If

                'Parece que el parametro esta bien, lo agregamos al comando
                Comando.Parameters.Add(p)
            Next


            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            'Cierro la conexion, ya no la uso
            miConexion.Close()
        End Try
    End Sub







End Class
