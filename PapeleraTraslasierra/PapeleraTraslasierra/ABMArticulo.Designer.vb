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
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TexboxStockMax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TexboxStockMin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TexboxStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TexboxPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TexboxPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TexboxNombre = New System.Windows.Forms.TextBox()
        Me.TexboxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TexboxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(84, 361)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(165, 361)
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
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(28, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Stock Max"
        '
        'TexboxStockMax
        '
        Me.TexboxStockMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "StockMax", True))
        Me.TexboxStockMax.Location = New System.Drawing.Point(93, 231)
        Me.TexboxStockMax.Name = "TexboxStockMax"
        Me.TexboxStockMax.Size = New System.Drawing.Size(86, 20)
        Me.TexboxStockMax.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(31, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Stock Min"
        '
        'TexboxStockMin
        '
        Me.TexboxStockMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "StockMin", True))
        Me.TexboxStockMin.Location = New System.Drawing.Point(93, 205)
        Me.TexboxStockMin.Name = "TexboxStockMin"
        Me.TexboxStockMin.Size = New System.Drawing.Size(86, 20)
        Me.TexboxStockMin.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(50, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Stock"
        '
        'TexboxStock
        '
        Me.TexboxStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.TexboxStock.Location = New System.Drawing.Point(93, 177)
        Me.TexboxStock.Name = "TexboxStock"
        Me.TexboxStock.Size = New System.Drawing.Size(86, 20)
        Me.TexboxStock.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(17, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Precio Venta"
        '
        'TexboxPrecioVenta
        '
        Me.TexboxPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "PrecioVenta", True))
        Me.TexboxPrecioVenta.Location = New System.Drawing.Point(93, 153)
        Me.TexboxPrecioVenta.Name = "TexboxPrecioVenta"
        Me.TexboxPrecioVenta.Size = New System.Drawing.Size(86, 20)
        Me.TexboxPrecioVenta.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(10, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Precio Unitario"
        '
        'TexboxPrecioUnitario
        '
        Me.TexboxPrecioUnitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "PrecioUnitario", True))
        Me.TexboxPrecioUnitario.Location = New System.Drawing.Point(93, 127)
        Me.TexboxPrecioUnitario.Name = "TexboxPrecioUnitario"
        Me.TexboxPrecioUnitario.Size = New System.Drawing.Size(86, 20)
        Me.TexboxPrecioUnitario.TabIndex = 36
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
        'TexboxNombre
        '
        Me.TexboxNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Nombre", True))
        Me.TexboxNombre.Location = New System.Drawing.Point(93, 75)
        Me.TexboxNombre.Name = "TexboxNombre"
        Me.TexboxNombre.Size = New System.Drawing.Size(186, 20)
        Me.TexboxNombre.TabIndex = 33
        '
        'TexboxCategoria
        '
        Me.TexboxCategoria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Categoria", True))
        Me.TexboxCategoria.FormattingEnabled = True
        Me.TexboxCategoria.Location = New System.Drawing.Point(93, 100)
        Me.TexboxCategoria.Name = "TexboxCategoria"
        Me.TexboxCategoria.Size = New System.Drawing.Size(186, 21)
        Me.TexboxCategoria.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(23, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Descripcion"
        '
        'TexboxDescripcion
        '
        Me.TexboxDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.TexboxDescripcion.Location = New System.Drawing.Point(93, 257)
        Me.TexboxDescripcion.Multiline = True
        Me.TexboxDescripcion.Name = "TexboxDescripcion"
        Me.TexboxDescripcion.Size = New System.Drawing.Size(186, 96)
        Me.TexboxDescripcion.TabIndex = 48
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
        'ABMArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(324, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TexboxDescripcion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TexboxId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TexboxStockMax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TexboxStockMin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TexboxStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TexboxPrecioVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TexboxPrecioUnitario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TexboxNombre)
        Me.Controls.Add(Me.TexboxCategoria)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(324, 405)
        Me.MinimumSize = New System.Drawing.Size(324, 405)
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
    Friend WithEvents Label8 As Label
    Friend WithEvents TexboxStockMax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TexboxStockMin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TexboxStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TexboxPrecioVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TexboxPrecioUnitario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TexboxNombre As TextBox
    Friend WithEvents TexboxCategoria As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TexboxDescripcion As TextBox
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents Label1 As Label
End Class
