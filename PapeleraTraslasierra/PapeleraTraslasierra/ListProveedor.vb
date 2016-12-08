Imports Mappers
Imports Entidades
Imports Datos
Imports System.Data.SqlClient

Public Class ListProveedor
    Public usuarioProveedor_ As String
    Private _Proveedores As List(Of Proveedor)
    Public Property UsuarioArticulo() As String
        Get
            Return usuarioProveedor_
        End Get
        Set(ByVal value As String)
            usuarioProveedor_ = value
        End Set
    End Property
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuarioProveedor_ = "Sergio" Then
            btn_modificar.Enabled = False
            btn_modificar.Enabled = False
        End If

        ProveedorBindingSource.DataSource = ProveedoresMappers.ObtenerTodos
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim frmproveedor As New ABMProveedores
        frmproveedor.Proveedores = ProveedorBindingSource.Current
        Dim pregunta As DialogResult = MsgBox("¿ Desea eliminar al proveedor" & " " & frmproveedor.Proveedores.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro")
        If pregunta = DialogResult.Yes Then
            ProveedoresMappers.EliminaProveedor(frmproveedor.Proveedores)
            _Proveedores = ProveedoresMappers.ObtenerTodos
            ProveedorBindingSource.DataSource = _Proveedores
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim frmProveedores As New ABMProveedores
        frmProveedores.Proveedores = ProveedorBindingSource.Current
        If frmProveedores.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea modificar al proveedor" & " " & frmProveedores.Proveedores.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
            If pregunta = DialogResult.Yes Then
                ProveedoresMappers.ModificarProveedor(frmProveedores.Proveedores)

            End If
            _Proveedores = ProveedoresMappers.ObtenerTodos
            ProveedorBindingSource.DataSource = _Proveedores
        End If
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim frmProveedores As New ABMProveedores
        frmProveedores.Proveedores = New Proveedor
        If frmProveedores.ShowDialog() = DialogResult.OK Then
            Dim pregunta As DialogResult = MsgBox("¿ Desea agregar al proveedor" & " " & frmProveedores.Proveedores.nombre & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar registro")
            If pregunta = DialogResult.Yes Then
                ProveedoresMappers.InsertarProveedor(frmProveedores.Proveedores)

            End If
            _Proveedores = ProveedoresMappers.ObtenerTodos
            ProveedorBindingSource.DataSource = _Proveedores
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nombre.TextChanged
        ProveedorBindingSource.DataSource = _Proveedores.Where(Function(c) c.nombre.ToLower Like txt_buscar_nombre.Text.Trim.ToLower + "*")
    End Sub
End Class