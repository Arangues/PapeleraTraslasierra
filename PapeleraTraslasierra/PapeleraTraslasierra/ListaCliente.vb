Imports Mappers
Imports Entidades
Imports Datos
Imports System.Data.SqlClient

Public Class ListaCliente
    Public usuarioCliente_ As String
    Dim CLiente As New Cliente
    Private _clientes As List(Of Cliente)
    Public Property UsuarioTipoCliente() As String
        Get
            Return usuarioCliente_
        End Get
        Set(ByVal value As String)
            usuarioCliente_ = value
        End Set
    End Property


    Private Sub ListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuarioCliente_ = "Usuario" Then
            btn_eliminar.Enabled = False
            btn_modificar.Enabled = False
        End If
        _clientes = ClienteMappers.ObtenerTodos
        ClienteBindingSource.DataSource = _clientes
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = New Cliente
        If frmcliente.ShowDialog() = DialogResult.OK Then

            Dim pregunta As DialogResult = MsgBox("¿ Desea agregar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar registro")
            If pregunta = DialogResult.Yes Then

                ClienteMappers.InsertarCliente(frmcliente.Cliente)
                dgv_Cliente.Refresh()
            End If
            _clientes = ClienteMappers.ObtenerTodos
            ClienteBindingSource.DataSource = _clientes
        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = ClienteBindingSource.Current
        If frmcliente.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea Modifcar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
            If pregunta = DialogResult.Yes Then
                ClienteMappers.ModificarCliente(frmcliente.Cliente)

            End If
            _clientes = ClienteMappers.ObtenerTodos
            ClienteBindingSource.DataSource = _clientes
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = ClienteBindingSource.Current
        Dim pregunta As DialogResult = MsgBox("¿ Desea eliminar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro")
        If pregunta = DialogResult.Yes Then
            ClienteMappers.EliminaCliente(frmcliente.Cliente)
            _clientes = ClienteMappers.ObtenerTodos
            ClienteBindingSource.DataSource = _clientes
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nombre.TextChanged

        ClienteBindingSource.DataSource = _clientes.Where(Function(c) c.nombre.ToLower Like txt_buscar_nombre.Text.Trim.ToLower + "*")


    End Sub


End Class
