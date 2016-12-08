Imports Entidades
Public Class ABMProveedores
    Public Property Proveedores As Proveedor
        Get
            Return ProveedorBindingSource.Current
        End Get
        Set(value As Proveedor)
            ProveedorBindingSource.DataSource = value
        End Set
    End Property
    Private Sub ABMProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If VericarTextBox(Me) Then
            Exit Sub
        End If
        ProveedorBindingSource.EndEdit()
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