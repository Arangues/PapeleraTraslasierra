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
        ListaCliente.ShowDialog()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        Dim listaFactura As New ListaFactura
        listaFactura.ShowDialog()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim ListaProveedores As New ListaProveedores
        ListaProveedores.ShowDialog()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuarioMenuStrinp_Click(sender As Object, e As EventArgs) Handles UsuarioMenuStrinp.Click
        My.Forms.ListaUsuario.ShowDialog()

    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        Dim pregunta As DialogResult = MsgBox("¿ Desea salir de la sesion de " & " " & usuarioMenu_ & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar registro")
        If pregunta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim ListaArticulos As New ListasArticulo
        ListaArticulos.ShowDialog()
    End Sub

    Private Sub AsdToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Forms.Form1.Show()
    End Sub

    Private Sub salirButton_Click(sender As Object, e As EventArgs) Handles salirButton.Click
        Dim pregunta As DialogResult = MsgBox("¿ Seguro desea salir del programa ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If pregunta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub minimizarButton_Click(sender As Object, e As EventArgs) Handles minimizarButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class