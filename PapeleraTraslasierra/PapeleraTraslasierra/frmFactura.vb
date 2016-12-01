Imports Mappers
Imports Entidades

Public Class frmFactura

    Dim facturaEnEdicion As Entidades.Factura


    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos

        facturaEnEdicion = New Factura

        EncabezadoFacturaBindingSource.DataSource = facturaEnEdicion
    End Sub

    Private Sub dgv_facturas_prod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_prod.CellClick
        AgregarArticulosBindingSource.DataSource = ArticuloBindingSource.Current
    End Sub

    Private Sub cmb_Agregar_Click(sender As Object, e As EventArgs)
        Dim detalle As New FacturaDetalle
        detalle.Cantidad = txt_cantidad.Text

        facturaEnEdicion.Detalle.Add(detalle)
        DetalleFacturaBindingSource.DataSource = facturaEnEdicion.Detalle

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
End Class