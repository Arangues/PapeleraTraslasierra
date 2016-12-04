<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaArticulos))
        Me.dgv_CLIENTE = New System.Windows.Forms.DataGridView()
        Me.eliminarArticuloButton = New System.Windows.Forms.Button()
        Me.modificarArticuloButton = New System.Windows.Forms.Button()
        Me.agregarArticuloButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_BUSCAR_CATEGORIA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_CLIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_CLIENTE
        '
        Me.dgv_CLIENTE.AutoGenerateColumns = False
        Me.dgv_CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CLIENTE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticuloDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgv_CLIENTE.DataSource = Me.ArticuloBindingSource
        Me.dgv_CLIENTE.Location = New System.Drawing.Point(32, 73)
        Me.dgv_CLIENTE.Name = "dgv_CLIENTE"
        Me.dgv_CLIENTE.ReadOnly = True
        Me.dgv_CLIENTE.Size = New System.Drawing.Size(747, 286)
        Me.dgv_CLIENTE.TabIndex = 0
        '
        'eliminarArticuloButton
        '
        Me.eliminarArticuloButton.Location = New System.Drawing.Point(209, 13)
        Me.eliminarArticuloButton.Name = "eliminarArticuloButton"
        Me.eliminarArticuloButton.Size = New System.Drawing.Size(75, 23)
        Me.eliminarArticuloButton.TabIndex = 9
        Me.eliminarArticuloButton.Text = "Eliminar"
        Me.eliminarArticuloButton.UseVisualStyleBackColor = True
        '
        'modificarArticuloButton
        '
        Me.modificarArticuloButton.Location = New System.Drawing.Point(128, 13)
        Me.modificarArticuloButton.Name = "modificarArticuloButton"
        Me.modificarArticuloButton.Size = New System.Drawing.Size(75, 23)
        Me.modificarArticuloButton.TabIndex = 8
        Me.modificarArticuloButton.Text = "Modificar"
        Me.modificarArticuloButton.UseVisualStyleBackColor = True
        '
        'agregarArticuloButton
        '
        Me.agregarArticuloButton.Location = New System.Drawing.Point(47, 13)
        Me.agregarArticuloButton.Name = "agregarArticuloButton"
        Me.agregarArticuloButton.Size = New System.Drawing.Size(75, 23)
        Me.agregarArticuloButton.TabIndex = 7
        Me.agregarArticuloButton.Text = "Agregar"
        Me.agregarArticuloButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(434, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Buscar por categoria"
        '
        'TXT_BUSCAR_CATEGORIA
        '
        Me.TXT_BUSCAR_CATEGORIA.Location = New System.Drawing.Point(547, 52)
        Me.TXT_BUSCAR_CATEGORIA.Name = "TXT_BUSCAR_CATEGORIA"
        Me.TXT_BUSCAR_CATEGORIA.Size = New System.Drawing.Size(150, 20)
        Me.TXT_BUSCAR_CATEGORIA.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(174, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Buscar por nombre"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(278, 52)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(150, 20)
        Me.txt_buscar_nombre.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Location = New System.Drawing.Point(728, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(629, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Articulos"
        '
        'IdArticuloDataGridViewTextBoxColumn
        '
        Me.IdArticuloDataGridViewTextBoxColumn.DataPropertyName = "idArticulo"
        Me.IdArticuloDataGridViewTextBoxColumn.HeaderText = "idArticulo"
        Me.IdArticuloDataGridViewTextBoxColumn.Name = "IdArticuloDataGridViewTextBoxColumn"
        Me.IdArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'ListaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_BUSCAR_CATEGORIA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.eliminarArticuloButton)
        Me.Controls.Add(Me.modificarArticuloButton)
        Me.Controls.Add(Me.agregarArticuloButton)
        Me.Controls.Add(Me.dgv_CLIENTE)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTICULOS"
        CType(Me.dgv_CLIENTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_CLIENTE As System.Windows.Forms.DataGridView
    Friend WithEvents eliminarArticuloButton As Button
    Friend WithEvents modificarArticuloButton As Button
    Friend WithEvents agregarArticuloButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_BUSCAR_CATEGORIA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_buscar_nombre As TextBox
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents IdArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
