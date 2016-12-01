Imports Entidades
Imports Datos
Imports System.Data.SqlClient

Public Class FacturaMappers

    Public Shared Function ObtenerTodos() As List(Of Factura)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodos"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnFactura(datos.Rows)
    End Function



    Public Shared Sub InsertarFactura(nuevaFactura As Factura)

        If nuevaFactura Is Nothing Then
            Throw New Exception("Debe especificar un Factura a dar de alta")
        End If

        ' nuevaFactura.Validador()

        Dim NombreStoreProcedure As String = "InsertarFactura"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@idFactura", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)

        misParametros.Add(New SqlParameter("@idFactura", nuevaFactura.IdFactura))
        misParametros.Add(New SqlParameter("@Tipo", nuevaFactura.Tipo))
        misParametros.Add(New SqlParameter("@Fecha", nuevaFactura.Fecha))



        Dim FacturaId As Integer = CInt(parametroRetorno.Value)
        ''armo la relacion 
        For Each d As FacturaDetalle In nuevaFactura.Detalle
            d.IdFactura = FacturaId
        Next
        FacturaDetalleDetalleMappers.InsertarFacturaDetalle(nuevaFactura.Detalle)
        nuevaFactura.AsignarFacturaId(FacturaId)
    End Sub

    Public Shared Sub InsertarFactura(nuevaFactura As List(Of Factura))

        For Each c As Factura In nuevaFactura
            InsertarFactura(c)
        Next
    End Sub



    Public Shared Sub ModificarFactura(nuevaFactura As Factura)

        If nuevaFactura Is Nothing Then
            Throw New Exception("Debe especificar que Factura desea modificar")
        End If
        ' nuevaFactura.Validador()

        Dim NombreStoreProcedure As String = "ModificarFactura"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idFactura", nuevaFactura.IdFactura))
        misParametros.Add(New SqlParameter("@Tipo", nuevaFactura.Tipo))
        misParametros.Add(New SqlParameter("@Fecha", nuevaFactura.Fecha))



        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub



    Private Shared Function ConvertirRowEnFactura(row As DataRow) As Factura

        Dim miFactura As New Factura(CInt(row("IdFactura")))
        miFactura.IdFactura = CInt(row("idFactura"))
        miFactura.Tipo = row("Tipo").ToString()
        'miFactura.Tipo = DateTime("Tipo").ToString()


        Return miFactura
    End Function

    Private Shared Function ConvertirRowEnFactura(rows As DataRowCollection) As List(Of Factura)

        Dim misFacturas As New List(Of Factura)()
        For Each registro As DataRow In rows

            Dim unFactura As Factura = Nothing

            unFactura = ConvertirRowEnFactura(registro)

            misFacturas.Add(unFactura)
        Next
        Return misFacturas
    End Function




    Public Shared Function ObtenerFacturas(Nombre As String) As List(Of Factura)

        If String.IsNullOrEmpty(Nombre) OrElse Nombre.Length < 4 Then
            Throw New Exception("Debe ingresar al menos 4 caracteres para realizar esta búsqueda.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaPorApellidoYNombre"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@Nombre", Nombre.Trim()))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFactura(datos.Rows)
    End Function

    Public Shared Function ObtenerFacturaPorNumeroDocumento(dni As String) As Factura
        If dni.Length > 8 Or dni.Length < 7 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaPorNumeroDocumento"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@numeroDocumento", dni))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFactura(datos.Rows(0))
    End Function

    Public Shared Function ObtenerFacturaPorId(id As Integer) As Factura
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaPorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@FacturaId", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFactura(datos.Rows(0))
    End Function

End Class
