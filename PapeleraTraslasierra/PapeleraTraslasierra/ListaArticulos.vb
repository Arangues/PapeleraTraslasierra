Imports Mappers
Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Imports Reglas

Public Class ListaArticulos

    Private _Articulos As List(Of Articulo)
    Private ABMArticulos As New ABMArticulo


    Private Sub ListaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        eliminarArticuloButton.Enabled = UsuarioRegla.EsAdmin
        _Articulos = ArticuloMappers.ObtenerTodos
        ArticuloBindingSource.DataSource = _Articulos
    End Sub

    Private Sub agregarArticuloButton_Click(sender As Object, e As EventArgs) Handles agregarArticuloButton.Click
        Dim frmArticulo As New ABMArticulo
        frmArticulo.Articulo = New Articulo
        If frmArticulo.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea insertar el Articulo" & " " & frmArticulo.Articulo.Nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Insertar registro")
            If pregunta = DialogResult.Yes Then
                ArticuloMappers.InsertarArticulo(frmArticulo.Articulo)

            End If
            _Articulos = ArticuloMappers.ObtenerTodos
            ArticuloBindingSource.DataSource = _Articulos
        End If
    End Sub

    Private Sub modificarArticuloButton_Click(sender As Object, e As EventArgs) Handles modificarArticuloButton.Click
        Dim frmArticulo As New ABMArticulo
        frmArticulo.Articulo = ArticuloBindingSource.Current

        If frmArticulo.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea Modificar al Articulo" & " " & frmArticulo.Articulo.Nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
            If pregunta = DialogResult.Yes Then
                ArticuloMappers.ModificarArticulo(frmArticulo.Articulo)
            End If
        End If
        _Articulos = ArticuloMappers.ObtenerTodos
        ArticuloBindingSource.DataSource = _Articulos


    End Sub

    Private Sub eliminarArticuloButton_Click(sender As Object, e As EventArgs) Handles eliminarArticuloButton.Click
        Dim frmArticulo As New ABMArticulo
        frmArticulo.Articulo = ArticuloBindingSource.Current
        Dim pregunta As DialogResult = MsgBox("¿ Desea eliminar al Articulo" & " " & frmArticulo.Articulo.Nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro")
        If pregunta = DialogResult.Yes Then
            ArticuloMappers.EliminaArticulo(frmArticulo.Articulo)
            _Articulos = ArticuloMappers.ObtenerTodos
            ArticuloBindingSource.DataSource = _Articulos


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nombre.TextChanged
        ArticuloBindingSource.DataSource = _Articulos.Where(Function(c) c.Nombre.ToLower Like txt_buscar_nombre.Text.Trim.ToLower + "*")



    End Sub

    Private Sub TXT_BUSCAR_CATEGORIA_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR_CATEGORIA.TextChanged
        ArticuloBindingSource.DataSource = _Articulos.Where(Function(c) c.Categoria.ToLower Like TXT_BUSCAR_CATEGORIA.Text.Trim.ToLower + "*")
    End Sub
End Class