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
        anularButton.Enabled = Reglas.UsuarioRegla.EsAdmin
        _Facturas = FacturaMappers.ObtenerTodos
        FacturasBindingSource.DataSource = _Facturas

    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TodosRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TodosRadioButton.CheckedChanged
        FacturasBindingSource.DataSource = FacturaMappers.ObtenerTodos()
    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.FacturaNumero Like MonthCalendar2.SelectionRange.Start + "*")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim Todos As String = New Date.Today()
        FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.Fecha Like Todos + "*")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles buscarPorNumeroTextBox.TextChanged
        FacturasBindingSource.DataSource = _Facturas.Where(Function(c) c.FacturaNumero Like buscarPorNumeroTextBox.Text + "*")
    End Sub
End Class