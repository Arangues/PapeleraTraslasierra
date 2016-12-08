Imports Reglas
Public Class frm_menu
    Public _tipo As String
    Public usuarioMenu_ As String

    Public Property UsuarioMenu() As String
        Get
            Return usuarioMenu_
        End Get
        Set(ByVal value As String)
            usuarioMenu_ = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Private Sub MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsuarioLabel.Text = usuarioMenu_
        MsgBox("Bienvenido " + usuarioMenu_)

        UsuarioMenuStrinp.Enabled = UsuarioRegla.EsAdmin

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim ListaCliente As New ListaCliente
        ListaCliente.UsuarioTipoCliente = _tipo
        ListaCliente.ShowDialog()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        Dim listaFactura As New ListaFactura
        listaFactura.ShowDialog()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        ListProveedor.ShowDialog()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuarioMenuStrinp_Click(sender As Object, e As EventArgs) Handles UsuarioMenuStrinp.Click
        My.Forms.MDIMenu.Show()
    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        Dim pregunta As DialogResult = MsgBox("¿ Desea salir de la sesion de " & " " & usuarioMenu_ & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar registro")
        If pregunta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        Dim ListaArticulos As New ListaArticulos
        ListaArticulos.ShowDialog()
    End Sub
End Class