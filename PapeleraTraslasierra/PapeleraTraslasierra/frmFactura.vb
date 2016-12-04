Imports Mappers
Imports Entidades
Imports Datos
Imports System.Data.SqlClient

Public Class frmFactura

    Dim facturaEnEdicion As Entidades.Factura


    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaLabel.Text = Date.Today
        FacturaMappers.CargarComboClientes(ClienteComboBox)
        FacturaMappers.TipoFacturaCargarCombo(TipoFacturaComboBox)
        ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos

        facturaEnEdicion = New Factura

        EncabezadoFacturaBindingSource.DataSource = facturaEnEdicion
    End Sub

    Private Sub dgv_facturas_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_prod.CellClick
        AgregarArticulosBindingSource.DataSource = ArticuloBindingSource.Current
    End Sub



    Private Sub cmb_Cobrar_Click(sender As Object, e As EventArgs) Handles cmb_Cobrar.Click
        Reglas.FacturaRegla.GenerarFactura(facturaEnEdicion)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pregunta As DialogResult = MsgBox("¿Se eliminara la gestion de la factura desea cerrar" & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir Factura")
        If pregunta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub




    Private Sub cmb_Agregar_Click_1(sender As Object, e As EventArgs) Handles cmb_Agregar.Click
        Dim detalle As New FacturaDetalle
        Dim subtotal As Decimal
        Dim total As Double = 0
        Dim precio As Decimal
        Dim cantidad As Integer
        cantidad = txt_cantidad.Text
        precio = txt_preciov_art.Text
        subtotal = precio * cantidad

        detalle.Nombre = txt_nombre_art.Text
        detalle.Cantidad = cantidad
        detalle.Precio = precio
        detalle.Total = subtotal

        facturaEnEdicion.Detalle.Add(detalle)
        DetalleFacturaBindingSource.DataSource = facturaEnEdicion.Detalle
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DetalleFacturaDataGridView.Rows
            total += Convert.ToDouble(fila.Cells(3).Value)
        Next

        txt_Pagar.Text = total
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nombre.TextChanged
        Dim conexion As New ConexionDB
        Dim buscar As New SqlDataAdapter("select * from Articulo where Nombre like '%" + txt_buscar_nombre.Text + "%'", conexion.Conexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "Articulo")
        dgv_facturas_prod.DataSource = ds.Tables(0)
    End Sub

    Private Sub TXT_BUSCAR_CODIGO_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR_CODIGO.TextChanged
        Dim conexion As New ConexionDB
        Dim buscar As New SqlDataAdapter("select * from Articulo where idArticulo like '%" + TXT_BUSCAR_CODIGO.Text + "%'", conexion.Conexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "Articulo")
        dgv_facturas_prod.DataSource = ds.Tables(0)
    End Sub

End Class