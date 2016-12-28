Imports Entidades
Imports Mappers
Public Class ListaFactura

    Private _Facturas As List(Of Factura)

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim frmFactura As New frmFactura
        frmFactura.ShowDialog()
        _Facturas = FacturaMappers.ObtenerTodos
        BindingSourceFactura.DataSource = _Facturas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'anularButton.Enabled = Reglas.UsuarioRegla.EsAdmin
        _Facturas = FacturaMappers.ObtenerTodos
        BindingSourceFactura.DataSource = _Facturas



    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub buscarPorNumeroTextBox_LostFocus(sender As Object, e As EventArgs)
        buscarPorNumeroTextBox.Text = ""
    End Sub

    Private Sub buscarPorNumeroTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles buscarPorNumeroTextBox.TextChanged
        BindingSourceFactura.DataSource = _Facturas.Where(Function(c) c.FacturaNumero Like buscarPorNumeroTextBox.Text + "*")
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Dim dia As String
        dia = MonthCalendar2.SelectionStart
        BindingSourceFactura.DataSource = _Facturas.Where(Function(c) c.Fecha Like dia + "*")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles clienteBuscarTextBox.TextChanged
        BindingSourceFactura.DataSource = _Facturas.Where(Function(c) c.Cliente.nombre Like clienteBuscarTextBox.Text + "*")
    End Sub

    Private Sub usuarioBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles usuarioBuscarTextBox.TextChanged
        BindingSourceFactura.DataSource = _Facturas.Where(Function(c) c.Usuario.Usuario Like clienteBuscarTextBox.Text + "*")
    End Sub

    Private Sub tipoBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles tipoBuscarTextBox.TextChanged
        BindingSourceFactura.DataSource = _Facturas.Where(Function(c) c.Tipo Like tipoBuscarTextBox.Text.Trim.ToUpper + "*")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick



    End Sub
End Class