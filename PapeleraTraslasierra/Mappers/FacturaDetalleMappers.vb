﻿Imports System.Data.SqlClient
Imports Datos
Imports Entidades
Public Class FacturaDetalleDetalleMappers
    Public Shared Function ObtenerTodos() As List(Of FacturaDetalle)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodos"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnFacturaDetalle(datos.Rows)
    End Function



    Public Shared Sub InsertarFacturaDetalle(nuevaFacturaDetalle As FacturaDetalle)

        If nuevaFacturaDetalle Is Nothing Then
            Throw New Exception("Debe especificar un FacturaDetalle a dar de alta")
        End If

        ' nuevaFacturaDetalle.Validador()

        Dim NombreStoreProcedure As String = "InsertarFacturaDetalle"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@IdFacturaDetalle", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)


        misParametros.Add(New SqlParameter("@IdFactura", nuevaFacturaDetalle.IdFactura))
        misParametros.Add(New SqlParameter("@IdArticulo", nuevaFacturaDetalle.Articulo.idArticulo))
        misParametros.Add(New SqlParameter("@Precio", nuevaFacturaDetalle.Precio))
        misParametros.Add(New SqlParameter("@Cantidad", nuevaFacturaDetalle.Cantidad))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


        Dim detalleId As Integer = CInt(parametroRetorno.Value)

        nuevaFacturaDetalle.AsignarFacturaDetalleId(detalleId)

        Dim FacturaDetalleId As Integer = CInt(parametroRetorno.Value)


        nuevaFacturaDetalle.AsignarFacturaDetalleId(FacturaDetalleId)
    End Sub

    Public Shared Sub InsertarFacturaDetalle(nuevaFacturaDetalle As FacturaDetalleList)

        For Each c As FacturaDetalle In nuevaFacturaDetalle
            InsertarFacturaDetalle(c)
        Next
    End Sub



    Public Shared Sub ModificarFacturaDetalle(nuevaFacturaDetalle As FacturaDetalle)

        If nuevaFacturaDetalle Is Nothing Then
            Throw New Exception("Debe especificar que FacturaDetalle desea modificar")
        End If
        ' nuevaFacturaDetalle.Validador()

        Dim NombreStoreProcedure As String = "@IdFacturaDetalle"

        Dim misParametros As New List(Of SqlParameter)()


        misParametros.Add(New SqlParameter("@IdFacturaDetalle", nuevaFacturaDetalle.IdFacturaDetalle))
        misParametros.Add(New SqlParameter("@IdFactura", nuevaFacturaDetalle.IdFactura))
        misParametros.Add(New SqlParameter("@IdFactura", nuevaFacturaDetalle.Articulo.idArticulo))
        misParametros.Add(New SqlParameter("@Precio", nuevaFacturaDetalle.Precio))
        misParametros.Add(New SqlParameter("@Cantidad", nuevaFacturaDetalle.Cantidad))




        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub



    Private Shared Function ConvertirRowEnFacturaDetalle(row As DataRow) As FacturaDetalle

        Dim miFacturaDetalle As New FacturaDetalle(CInt(row("IdDetalles")))

        miFacturaDetalle.IdFacturaDetalle = CInt(row("IdDetalles"))
        miFacturaDetalle.IdFactura = CInt(row("IdFactura"))
        miFacturaDetalle.Articulo = ArticuloMappers.ObtenerArticuloPorId(row("idArticulo"))
        miFacturaDetalle.Precio = Convert.ToDecimal(row("Precio"))
        miFacturaDetalle.Cantidad = CInt(row("Cantidad"))

        Return miFacturaDetalle
    End Function

    Private Shared Function ConvertirRowEnFacturaDetalle(rows As DataRowCollection) As FacturaDetalleList

        Dim misFacturaDetalles As New FacturaDetalleList
        For Each registro As DataRow In rows

            Dim unFacturaDetalle As FacturaDetalle = Nothing

            unFacturaDetalle = ConvertirRowEnFacturaDetalle(registro)

            misFacturaDetalles.Add(unFacturaDetalle)
        Next
        Return misFacturaDetalles
    End Function




    Public Shared Function ObtenerFacturaDetalles(Nombre As String) As List(Of FacturaDetalle)

        If String.IsNullOrEmpty(Nombre) OrElse Nombre.Length < 4 Then
            Throw New Exception("Debe ingresar al menos 4 caracteres para realizar esta búsqueda.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaDetallePorApellidoYNombre"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@Nombre", Nombre.Trim()))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFacturaDetalle(datos.Rows)
    End Function



    Public Shared Function ObtenerFacturaDetallePorId(id As Integer) As FacturaDetalle
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaDetallePorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@FacturaDetalleId", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFacturaDetalle(datos.Rows(0))
    End Function

    Public Shared Function obtenerFacturaDetallePorIdFactura(id As Integer) As List(Of FacturaDetalle)
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "obtenerFacturaDetallePorIdFactura"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idFactura", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFacturaDetalle(datos.Rows())
    End Function



End Class
