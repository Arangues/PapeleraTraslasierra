<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMArticulo))
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TexboxId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Campo_Stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.campo_PrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Campo_Nombre = New System.Windows.Forms.TextBox()
        Me.campo_Categoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Campo_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.campo_Proveedor = New System.Windows.Forms.ComboBox()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(93, 285)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(174, 285)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(69, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 15)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Id"
        '
        'TexboxId
        '
        Me.TexboxId.BackColor = System.Drawing.SystemColors.Control
        Me.TexboxId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TexboxId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "idArticulo", True))
        Me.TexboxId.Location = New System.Drawing.Point(93, 49)
        Me.TexboxId.Name = "TexboxId"
        Me.TexboxId.ReadOnly = True
        Me.TexboxId.Size = New System.Drawing.Size(86, 20)
        Me.TexboxId.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(50, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Stock"
        '
        'Campo_Stock
        '
        Me.Campo_Stock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.Campo_Stock.Enabled = False
        Me.Campo_Stock.Location = New System.Drawing.Point(93, 151)
        Me.Campo_Stock.Name = "Campo_Stock"
        Me.Campo_Stock.Size = New System.Drawing.Size(86, 20)
        Me.Campo_Stock.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(17, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Precio Venta"
        '
        'campo_PrecioVenta
        '
        Me.campo_PrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "PrecioVenta", True))
        Me.campo_PrecioVenta.Enabled = False
        Me.campo_PrecioVenta.Location = New System.Drawing.Point(93, 127)
        Me.campo_PrecioVenta.Name = "campo_PrecioVenta"
        Me.campo_PrecioVenta.Size = New System.Drawing.Size(86, 20)
        Me.campo_PrecioVenta.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(33, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(41, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre"
        '
        'Campo_Nombre
        '
        Me.Campo_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Nombre", True))
        Me.Campo_Nombre.Location = New System.Drawing.Point(93, 75)
        Me.Campo_Nombre.Name = "Campo_Nombre"
        Me.Campo_Nombre.Size = New System.Drawing.Size(186, 20)
        Me.Campo_Nombre.TabIndex = 33
        '
        'campo_Categoria
        '
        Me.campo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo_Categoria.Location = New System.Drawing.Point(93, 100)
        Me.campo_Categoria.Name = "campo_Categoria"
        Me.campo_Categoria.Size = New System.Drawing.Size(186, 21)
        Me.campo_Categoria.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(22, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Descripcion"
        '
        'Campo_Descripcion
        '
        Me.Campo_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.Campo_Descripcion.Location = New System.Drawing.Point(93, 216)
        Me.Campo_Descripcion.Multiline = True
        Me.Campo_Descripcion.Name = "Campo_Descripcion"
        Me.Campo_Descripcion.Size = New System.Drawing.Size(186, 63)
        Me.Campo_Descripcion.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(113, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Articulo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(29, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Proveedor"
        '
        'campo_Proveedor
        '
        Me.campo_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo_Proveedor.Location = New System.Drawing.Point(93, 177)
        Me.campo_Proveedor.Name = "campo_Proveedor"
        Me.campo_Proveedor.Size = New System.Drawing.Size(186, 21)
        Me.campo_Proveedor.TabIndex = 53
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'ABMArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(324, 331)
        Me.Controls.Add(Me.campo_Proveedor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Campo_Descripcion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TexboxId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Campo_Stock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.campo_PrecioVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Campo_Nombre)
        Me.Controls.Add(Me.campo_Categoria)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ABMArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ARTICULO"
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TexboxId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Campo_Stock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents campo_PrecioVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Campo_Nombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Campo_Descripcion As TextBox
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Private WithEvents campo_Categoria As ComboBox
    Private WithEvents campo_Proveedor As ComboBox
End Class
