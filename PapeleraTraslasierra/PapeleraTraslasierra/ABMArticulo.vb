Imports Entidades
Public Class ABMArticulo

    Public Property Articulo As Articulo
        Get
            Return ArticuloBindingSource.Current
        End Get
        Set(value As Articulo)
            ArticuloBindingSource.DataSource = value
        End Set
    End Property

    Private Sub ABMArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mappers.ArticuloMappers.CategoriaCargarCombo(campo_Categoria)
        Mappers.ArticuloMappers.ProveedorCargarCombo(campo_Proveedor)
        campo_PrecioUnitario.Enabled = Reglas.UsuarioRegla.EsAdmin
        campo_PrecioVenta.Enabled = Reglas.UsuarioRegla.EsAdmin
        Campo_Stock.Enabled = Reglas.UsuarioRegla.EsAdmin
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If VericarTextBox(Me) Then
            Exit Sub
        End If

        ArticuloBindingSource.EndEdit()
        DialogResult = DialogResult.OK
    End Sub



    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
    Public Function VericarTextBox(ByVal formulario As Form)
        For Each Control As Control In formulario.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                If Control.Text = "" Then
                    MsgBox("No se permiten valores vacios en : " + Control.Name)
                    Return True
                    Exit Function
                End If
            End If
        Next

    End Function

End Class