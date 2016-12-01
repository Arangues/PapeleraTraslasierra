Public Class frm_menu
    Public tipo As String = "Sergio"
    Public usuarioMenu_ As String

    Public Property UsuarioMenu() As String
        Get
            Return usuarioMenu_
        End Get
        Set(ByVal value As String)
            usuarioMenu_ = value
        End Set
    End Property
    Private Sub MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UsuarioLabel.Text = usuarioMenu_
        MsgBox("Vienvenido " + usuarioMenu_)
        If usuarioMenu_.Trim = tipo.Trim Then
            My.Forms.frm_menu.UsuarioMenuStrinp.Enabled = False

        End If
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        ListaCliente.ShowDialog()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        My.Forms.ListaArticulos.UsuarioArticulo = usuarioMenu_
        ListaArticulos.ShowDialog()

    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        ListaFactura.ShowDialog()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        ListProveedor.ShowDialog()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuarioMenuStrinp_Click(sender As Object, e As EventArgs) Handles UsuarioMenuStrinp.Click
        My.Forms.MDIMenu.Show()
    End Sub
End Class