Imports Mappers
Public Class ListaFactura

    Public usuarioFactura_ As String

    Public Property UsuarioFactura() As String
        Get
            Return usuarioFactura_
        End Get
        Set(ByVal value As String)
            usuarioFactura_ = value
        End Set
    End Property
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        frmFactura.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FacturasBindingSource.DataSource = FacturaMappers.ObtenerTodos()
        If usuarioFactura_ = "Sergio" Then
            btn_eliminar.Visible = False
        End If
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub
End Class