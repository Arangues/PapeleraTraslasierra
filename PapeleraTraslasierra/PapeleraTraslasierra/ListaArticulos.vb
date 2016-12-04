Imports Mappers
Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class ListaArticulos
    Public usuarioArticulo_ As String

    Public Property UsuarioArticulo() As String
        Get
            Return usuarioArticulo_
        End Get
        Set(ByVal value As String)
            usuarioArticulo_ = value
        End Set
    End Property


    Private Sub agregarArticuloButton_Click(sender As Object, e As EventArgs) Handles agregarArticuloButton.Click
        Dim frmArticulo As New ABMArticulo
        frmArticulo.Articulo = New Articulo

        If frmArticulo.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea insertar el Articulo" & " " & frmArticulo.Articulo.Nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Insertar registro")
            If pregunta = DialogResult.Yes Then
                ArticuloMappers.InsertarArticulo(frmArticulo.Articulo)
                ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos
            End If
            ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos
        End If
    End Sub



    Private Sub ListaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuarioArticulo_ = "Sergio" Then
            eliminarArticuloButton.Visible = False
        End If
        ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos
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
        ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos



    End Sub

    Private Sub eliminarArticuloButton_Click(sender As Object, e As EventArgs) Handles eliminarArticuloButton.Click
        Dim frmArticulo As New ABMArticulo
        frmArticulo.Articulo = ArticuloBindingSource.Current
        Dim pregunta As DialogResult = MsgBox("¿ Desea eliminar al Articulo" & " " & frmArticulo.Articulo.Nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro")
        If pregunta = DialogResult.Yes Then
            ArticuloMappers.EliminaArticulo(frmArticulo.Articulo)
            ArticuloBindingSource.DataSource = ArticuloMappers.ObtenerTodos
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nombre.TextChanged
        Dim conexion As New ConexionDB
        Dim buscar As New SqlDataAdapter("select * from Articulo where Nombre like '%" + txt_buscar_nombre.Text + "%'", conexion.Conexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "Articulo")
        dgv_CLIENTE.DataSource = ds.Tables(0)

    End Sub

    Private Sub TXT_BUSCAR_CATEGORIA_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR_CATEGORIA.TextChanged
        Dim conexion As New ConexionDB
        Dim buscar As New SqlDataAdapter("select * from Articulo where Categoria like '%" + TXT_BUSCAR_CATEGORIA.Text + "%'", conexion.Conexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "Articulo")
        dgv_CLIENTE.DataSource = ds.Tables(0)
    End Sub
End Class