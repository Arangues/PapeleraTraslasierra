Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class ClienteMappers


    Public Shared Function ObtenerTodos() As List(Of Cliente)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodos"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnCliente(datos.Rows)
    End Function



    Public Shared Sub InsertarCliente(nuevoCliente As Cliente)

        If nuevoCliente Is Nothing Then
            Throw New Exception("Debe especificar un cliente a dar de alta")
        End If

        nuevoCliente.Validador()

        Dim NombreStoreProcedure As String = "InsertarCliente"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@idCliente", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)

        misParametros.Add(New SqlParameter("@Nombre", nuevoCliente.nombre))
        misParametros.Add(New SqlParameter("@Direccion", nuevoCliente.direccion))
        misParametros.Add(New SqlParameter("@Localidad", nuevoCliente.localidad))
        misParametros.Add(New SqlParameter("@Email", nuevoCliente.Email))
        misParametros.Add(New SqlParameter("@Telefono", nuevoCliente.Telefono))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


        Dim ClienteId As Integer = CInt(parametroRetorno.Value)

        nuevoCliente.AsignarClienteId(ClienteId)
    End Sub

    Public Shared Sub InsertarCliente(nuevosClientes As List(Of Cliente))

        For Each c As Cliente In nuevosClientes
            InsertarCliente(c)
        Next
    End Sub


    Public Shared Sub EliminaCliente(nuevoCliente As Cliente)

        If nuevoCliente Is Nothing Then
            Throw New Exception("Debe especificar un cliente a eliminar")
        End If

        nuevoCliente.Validador()

        Dim NombreStoreProcedure As String = "EliminarCliente"

        Dim misParametros As New List(Of SqlParameter)()




        misParametros.Add(New SqlParameter("@idCliente", nuevoCliente.IdCliente))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


    End Sub


    Public Shared Sub ModificarCliente(nuevoCliente As Cliente)

        If nuevoCliente Is Nothing Then
            Throw New Exception("Debe especificar que cliente desea modificar")
        End If
        nuevoCliente.Validador()


        Dim NombreStoreProcedure As String = "ModificarCliente"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idCliente", nuevoCliente.IdCliente))
        misParametros.Add(New SqlParameter("@Nombre", nuevoCliente.nombre))
        misParametros.Add(New SqlParameter("@Direccion", nuevoCliente.direccion))
        misParametros.Add(New SqlParameter("@Localidad", nuevoCliente.localidad))
        misParametros.Add(New SqlParameter("@Email", nuevoCliente.Email))
        misParametros.Add(New SqlParameter("@Telefono", nuevoCliente.Telefono))



        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub



    Private Shared Function ConvertirRowEnCliente(row As DataRow) As Cliente

        Dim miCliente As New Cliente(CInt(row("idCliente")))

        miCliente.IdCliente = CInt(row("idCliente"))
        miCliente.nombre = row("Nombre").ToString()
        miCliente.direccion = row("Direccion").ToString()
        miCliente.localidad = row("Localidad")
        miCliente.Email = row("Email").ToString()
        miCliente.Telefono = row("Telefono").ToString()



        Return miCliente
    End Function

    Private Shared Function ConvertirRowEnCliente(rows As DataRowCollection) As List(Of Cliente)

        Dim misClientes As New List(Of Cliente)()
        For Each registro As DataRow In rows

            Dim unCliente As Cliente = Nothing

            unCliente = ConvertirRowEnCliente(registro)

            misClientes.Add(unCliente)
        Next
        Return misClientes
    End Function




    Public Shared Function ObtenerClientes(Nombre As String) As List(Of Cliente)

        If String.IsNullOrEmpty(Nombre) OrElse Nombre.Length < 4 Then
            Throw New Exception("Debe ingresar al menos 4 caracteres para realizar esta búsqueda.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerClientePorApellidoYNombre"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@Nombre", Nombre.Trim()))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnCliente(datos.Rows)
    End Function


    Public Shared Function ObtenerClientePorId(id As Integer) As Cliente
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerClientePorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idCliente", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnCliente(datos.Rows(0))
    End Function

    Public Shared Function CargarComboClientes(ByVal comboactual As Object)
        Try

            Dim misClientes = Mappers.ClienteMappers.ObtenerTodos()

            With comboactual
                .DataSource = misClientes
                .DisplayMember = "Nombre"
                .ValueMember = "Nombre"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally


        End Try
        Return True
    End Function





End Class



