Imports Entidades
Imports Datos
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FacturaMappers

    Public Shared Function ObtenerTodos() As List(Of Factura)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "FacturaObtnerTodos"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnFactura(datos.Rows)
    End Function



    Public Shared Sub InsertarFactura(nuevaFactura As Factura)

        If nuevaFactura Is Nothing Then
                Throw New Exception("Debe especificar un Factura a dar de alta")
            End If

            Dim NombreStoreProcedure As String = "InsertarFactura"

            Dim misParametros As New List(Of SqlParameter)()

            Dim parametroRetorno As New SqlParameter("@idFactura", SqlDbType.Int)
            parametroRetorno.Direction = ParameterDirection.Output

            misParametros.Add(parametroRetorno)

            misParametros.Add(New SqlParameter("@FacturaNumero", nuevaFactura.FacturaNumero))
            misParametros.Add(New SqlParameter("@Tipo", nuevaFactura.Tipo))
            misParametros.Add(New SqlParameter("@Fecha", nuevaFactura.Fecha))
            misParametros.Add(New SqlParameter("@idCliente", nuevaFactura.Cliente.IdCliente))
            misParametros.Add(New SqlParameter("@idUsuario", nuevaFactura.Usuario.IdUsuario))

            ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


            Dim FacturaId As Integer = CInt(parametroRetorno.Value)

            nuevaFactura.AsignarFacturaId(FacturaId)

           

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
        misParametros.Add(New SqlParameter("@FacturaTotal", nuevaFactura.FacturaTotal))



        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub


    Public Shared Sub EliminarFactura(factura As Factura)
        If factura Is Nothing Then
            Throw New Exception("Debe especificar que Factura desea eliminar")
        End If
        ' nuevaFactura.Validador()

        Dim NombreStoreProcedure As String = "EliminarFacturaDetalle"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idFactura", factura.IdFactura))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

        NombreStoreProcedure = "EliminarFactura"
        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)
    End Sub


    Private Shared Function ConvertirRowEnFactura(row As DataRow) As Factura

        Dim miFactura As New Factura(CInt(row("IdFactura")))
            miFactura.IdFactura = CInt(row("idFactura"))
            miFactura.FacturaNumero = CInt(row("FacturaNumero"))
            miFactura.Tipo = row("Tipo").ToString()
        miFactura.Fecha = Convert.ToDateTime(row("Fecha"))
        miFactura.Detalle = FacturaDetalleDetalleMappers.obtenerFacturaDetallePorIdFactura(row("idFactura"))
        miFactura.Cliente = ClienteMappers.ObtenerClientePorId(row("idCLiente"))
        miFactura.Usuario = UsuarioMappers.ObtenerUsuarioPorId(row("idUsuario"))

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

    Public Shared Function ObtenerUltimmoNumeroFactura() As Integer


        Dim NombreStoreProcedure As String = "ObtenerNumeroFactura"
        Dim misParametros As New List(Of SqlParameter)()

        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return (datos.Rows(0)("FacturaNumero"))
    End Function

    Public Shared Function ObtenerFacturaPorId(id As Integer) As Factura
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerFacturaPorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idFactura", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFactura(datos.Rows(0))
    End Function

    Public Shared Function obtenerFacturaDetallePorIdFactura(id As Integer) As Factura
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "obtenerFacturaDetallePorIdFactura"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idFactura", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnFactura(datos.Rows(0))
    End Function


    Public Shared Function TipoFacturaCargarCombo(ByVal comboactual As Object)
        Try

            Dim conexion As New ConexionDB
            Dim objComando As New SqlCommand("FacturaTipoCargarCombo", conexion.Conexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "tipo"
                .ValueMember = "tipo"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally


        End Try
        Return True



    End Function

    Public Shared Function CargarComboFiltroFactura(ByVal comboactual As Object)
        Try

            Dim conexion As New ConexionDB
            Dim objComando As New SqlCommand("FacturaFiltro", conexion.Conexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "NombrFiltro"
                .ValueMember = "idFacturaFiltros"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally


        End Try
        Return True
    End Function

    Public Shared Function CargarComboFiltroUsuario(ByVal comboactual As Object)

        Try

            Dim misClientes = Mappers.UsuarioMappers.ObtenerTodos()

            With comboactual
                .DataSource = misClientes
                .DisplayMember = "Usuario"
                .ValueMember = "Usuario"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally


        End Try
        Return True


    End Function


    Public Function ActualizarDetalleActual(ByVal tabla As DataGridView, ByRef subtotal As Decimal, ByVal txtSubtotal As TextBox)
        Try
            Dim fila As Integer = 0
            subtotal = 0
            For Each row As DataGridViewRow In tabla.Rows
                subtotal = subtotal + tabla.Rows(fila).Cells("precio").Value
                fila += 1
            Next
            txtSubtotal.Text = subtotal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function





End Class
