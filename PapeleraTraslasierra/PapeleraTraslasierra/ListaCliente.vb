Imports Mappers
Imports Entidades
Public Class ListaCliente
    Public usuarioCliente_ As String

    Public Property UsuarioArticulo() As String
        Get
            Return usuarioCliente_
        End Get
        Set(ByVal value As String)
            usuarioCliente_ = value
        End Set
    End Property


    Private Sub ListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuarioCliente_ = "Sergio" Then
            btn_eliminar.Enabled = False
            btn_modificar.Enabled = False
        End If
        ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = New Cliente
        If frmcliente.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea agregar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar registro")
            If pregunta = DialogResult.Yes Then
                ClienteMappers.InsertarCliente(frmcliente.Cliente)
                ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
            End If
            ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = ClienteBindingSource.Current
        If frmcliente.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea Modifcar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
            If pregunta = DialogResult.Yes Then
                ClienteMappers.ModificarCliente(frmcliente.Cliente)
                ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
            End If
            ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim frmcliente As New ABMCliente
        frmcliente.Cliente = ClienteBindingSource.Current
        Dim pregunta As DialogResult = MsgBox("¿ Desea eliminar al cliente" & " " & frmcliente.Cliente.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro")
        If pregunta = DialogResult.Yes Then
            ClienteMappers.EliminaCliente(frmcliente.Cliente)
            ClienteBindingSource.DataSource = ClienteMappers.ObtenerTodos
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
