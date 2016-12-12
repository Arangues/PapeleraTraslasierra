Imports Entidades
Imports Mappers
Public Class ListaFactura

    Private _Facturas As List(Of Factura)

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        frmFactura.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mappers.FacturaMappers.CargarComboFiltroFactura(FiltrarFacturaComboBox)
        Mappers.FacturaMappers.CargarComboClientes(ClienteComboBox)

        anularButton.Enabled = Reglas.UsuarioRegla.EsAdmin
        _Facturas = FacturaMappers.ObtenerTodos
        FacturasBindingSource.DataSource = _Facturas

    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub buscarPorNumeroTextBox_LostFocus(sender As Object, e As EventArgs)
        buscarPorNumeroTextBox.Text = ""
    End Sub

    Private Sub buscarPorNumeroTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles buscarPorNumeroTextBox.TextChanged
        FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.FacturaNumero Like buscarPorNumeroTextBox.Text + "*")
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Dim dia As String
        dia = MonthCalendar2.SelectionStart
        FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.Fecha Like dia + "*")
    End Sub

    Private Sub ClienteComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClienteComboBox.SelectedIndexChanged
        ' FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.Cliente Like ClienteComboBox.SelectedItem.ToString + "*")
    End Sub

    Private Sub FiltrarFacturaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FiltrarFacturaComboBox.SelectedIndexChanged
        ' FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.Tipo Like FiltrarFacturaComboBox.SelectedItem.ToString + "*")
    End Sub
End Class