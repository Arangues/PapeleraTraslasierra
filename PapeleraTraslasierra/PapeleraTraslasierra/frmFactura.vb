Imports Mappers
Imports Entidades
Imports Datos
Imports System.Data.SqlClient

Public Class frmFactura

    Dim facturaEnEdicion As Entidades.Factura
    Private _Articulos As List(Of Articulo)

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaLabel.Text = Date.Today
        ClienteMappers.CargarComboClientes(ClienteComboBox)
        FacturaMappers.TipoFacturaCargarCombo(TipoFacturaComboBox)
        BindingSourceArticulo.DataSource = ArticuloMappers.ObtenerTodos

        facturaEnEdicion = New Factura

        EncabezadoFacturaBindingSource.DataSource = facturaEnEdicion
    End Sub

    Private Sub dgv_facturas_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_prod.CellClick
        AgregarArticulosBindingSource.DataSource = BindingSourceArticulo.Current
    End Sub



    Private Sub cmb_Cobrar_Click(sender As Object, e As EventArgs) Handles cmb_Cobrar.Click
        If txt_Pagar.Text = "0" Or txt_Pagar.Text = 0 Then
            MsgBox("Debe elegir un articulo a cobrar")
            Exit Sub
        End If
        facturaEnEdicion.Tipo = TipoFacturaComboBox.SelectedValue
        facturaEnEdicion.Cliente = ClienteComboBox.SelectedItem
        Reglas.FacturaRegla.GenerarFactura(facturaEnEdicion)
        MsgBox("SE CREO LA FACTURA")
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pregunta As DialogResult = MsgBox("¿Se eliminara la gestion de la factura desea cerrar" & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir Factura")
        If pregunta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub




    Private Sub cmb_Agregar_Click_1(sender As Object, e As EventArgs) Handles cmb_Agregar.Click
        If txt_nombre_art.Text = "" Then
            MsgBox("falta ingresar nombre del articulo")
            Exit Sub
        End If
        If txt_cantidad.Text = "" Then
            MsgBox("falta ingresar cantidad del articulo")
            Exit Sub
        End If
        If txt_preciov_art.Text = "" Then
            MsgBox("falta ingresar precio del articulo")
            Exit Sub
        End If


        Dim detalle As New FacturaDetalle

        Dim precio As Decimal
        Dim cantidad As Integer
        cantidad = txt_cantidad.Text
        precio = txt_preciov_art.Text


        detalle.Articulo = BindingSourceArticulo.Current
        detalle.Cantidad = cantidad
        detalle.Precio = precio


        facturaEnEdicion.Detalle.Add(detalle)
        DetalleFacturaBindingSource.DataSource = facturaEnEdicion.Detalle
        DetalleFacturaBindingSource.ResetBindings(False)
        txt_Pagar.Text = facturaEnEdicion.FacturaTotal
    End Sub



    Private Sub TXT_BUSCAR_CODIGO_TextChanged(sender As Object, e As EventArgs)
        '  BindingSourceArticulo.DataSource = _Articulos.Where(Function(c) c.idArticulo Like TXT_BUSCAR_CODIGO.Text + "*")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        '     BindingSourceArticulo.DataSource = _Articulos.Where(Function(c) c.Nombre.ToLower Like TextBox1.Text.Trim.ToLower + "*")
    End Sub

    Private Sub dgv_facturas_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_prod.CellContentClick

    End Sub
End Class