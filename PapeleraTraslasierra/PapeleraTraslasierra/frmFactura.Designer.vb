<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me.txt_Pagar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_Cobrar = New System.Windows.Forms.Button()
        Me.dgv_facturas_prod = New System.Windows.Forms.DataGridView()
        Me.BindingSourceArticulo = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Eliminar = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.cmb_Agregar = New System.Windows.Forms.Button()
        Me.txt_nombre_art = New System.Windows.Forms.TextBox()
        Me.AgregarArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_preciov_art = New System.Windows.Forms.TextBox()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DetalleFacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoFacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EncabezadoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Pagar
        '
        Me.txt_Pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pagar.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pagar.Location = New System.Drawing.Point(783, 383)
        Me.txt_Pagar.Multiline = True
        Me.txt_Pagar.Name = "txt_Pagar"
        Me.txt_Pagar.Size = New System.Drawing.Size(126, 34)
        Me.txt_Pagar.TabIndex = 40
        Me.txt_Pagar.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.No
        Me.Label13.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(605, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 34)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Neto a pagar $"
        '
        'cmb_Cobrar
        '
        Me.cmb_Cobrar.BackColor = System.Drawing.Color.GreenYellow
        Me.cmb_Cobrar.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Cobrar.Location = New System.Drawing.Point(663, 423)
        Me.cmb_Cobrar.Name = "cmb_Cobrar"
        Me.cmb_Cobrar.Size = New System.Drawing.Size(158, 36)
        Me.cmb_Cobrar.TabIndex = 41
        Me.cmb_Cobrar.Text = "COBRAR"
        Me.cmb_Cobrar.UseVisualStyleBackColor = False
        '
        'dgv_facturas_prod
        '
        Me.dgv_facturas_prod.AllowUserToAddRows = False
        Me.dgv_facturas_prod.AllowUserToDeleteRows = False
        Me.dgv_facturas_prod.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facturas_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_facturas_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idArticulo, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.dgv_facturas_prod.DataSource = Me.BindingSourceArticulo
        Me.dgv_facturas_prod.Location = New System.Drawing.Point(538, 41)
        Me.dgv_facturas_prod.Name = "dgv_facturas_prod"
        Me.dgv_facturas_prod.ReadOnly = True
        Me.dgv_facturas_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas_prod.Size = New System.Drawing.Size(416, 303)
        Me.dgv_facturas_prod.TabIndex = 1
        '
        'BindingSourceArticulo
        '
        Me.BindingSourceArticulo.DataSource = GetType(Entidades.Articulo)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(237, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(249, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(242, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Nombre"
        '
        'cmb_Eliminar
        '
        Me.cmb_Eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Eliminar.Location = New System.Drawing.Point(377, 117)
        Me.cmb_Eliminar.Name = "cmb_Eliminar"
        Me.cmb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Eliminar.TabIndex = 47
        Me.cmb_Eliminar.Text = "Eliminar"
        Me.cmb_Eliminar.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.SkyBlue
        Me.txt_cantidad.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(292, 82)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(160, 23)
        Me.txt_cantidad.TabIndex = 45
        '
        'cmb_Agregar
        '
        Me.cmb_Agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Agregar.Location = New System.Drawing.Point(292, 117)
        Me.cmb_Agregar.Name = "cmb_Agregar"
        Me.cmb_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Agregar.TabIndex = 46
        Me.cmb_Agregar.Text = "Agregar"
        Me.cmb_Agregar.UseVisualStyleBackColor = True
        '
        'txt_nombre_art
        '
        Me.txt_nombre_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_nombre_art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgregarArticulosBindingSource, "Nombre", True))
        Me.txt_nombre_art.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_art.Location = New System.Drawing.Point(292, 24)
        Me.txt_nombre_art.Name = "txt_nombre_art"
        Me.txt_nombre_art.ReadOnly = True
        Me.txt_nombre_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_nombre_art.TabIndex = 43
        '
        'AgregarArticulosBindingSource
        '
        Me.AgregarArticulosBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'txt_preciov_art
        '
        Me.txt_preciov_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_preciov_art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgregarArticulosBindingSource, "PrecioVenta", True))
        Me.txt_preciov_art.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preciov_art.Location = New System.Drawing.Point(292, 53)
        Me.txt_preciov_art.Name = "txt_preciov_art"
        Me.txt_preciov_art.ReadOnly = True
        Me.txt_preciov_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_preciov_art.TabIndex = 44
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClienteComboBox.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(95, 77)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClienteComboBox.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Cliiente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tipo"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.BackColor = System.Drawing.Color.Transparent
        Me.FechaLabel.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel.ForeColor = System.Drawing.Color.White
        Me.FechaLabel.Location = New System.Drawing.Point(92, 22)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(46, 17)
        Me.FechaLabel.TabIndex = 53
        Me.FechaLabel.Text = "Fecha"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Location = New System.Drawing.Point(901, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DetalleFacturaDataGridView
        '
        Me.DetalleFacturaDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DetalleFacturaDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DetalleFacturaDataGridView.AutoGenerateColumns = False
        Me.DetalleFacturaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleFacturaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DetalleFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleFacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.NombreArticulo})
        Me.DetalleFacturaDataGridView.DataSource = Me.DetalleFacturaBindingSource
        Me.DetalleFacturaDataGridView.Location = New System.Drawing.Point(22, 146)
        Me.DetalleFacturaDataGridView.Name = "DetalleFacturaDataGridView"
        Me.DetalleFacturaDataGridView.ReadOnly = True
        Me.DetalleFacturaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DetalleFacturaDataGridView.Size = New System.Drawing.Size(510, 311)
        Me.DetalleFacturaDataGridView.TabIndex = 62
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreArticulo
        '
        Me.NombreArticulo.DataPropertyName = "NombreArticulo"
        Me.NombreArticulo.HeaderText = "Articulo"
        Me.NombreArticulo.Name = "NombreArticulo"
        Me.NombreArticulo.ReadOnly = True
        Me.NombreArticulo.Width = 200
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataSource = GetType(Entidades.FacturaDetalle)
        '
        'TipoFacturaComboBox
        '
        Me.TipoFacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoFacturaComboBox.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoFacturaComboBox.FormattingEnabled = True
        Me.TipoFacturaComboBox.Location = New System.Drawing.Point(95, 50)
        Me.TipoFacturaComboBox.Name = "TipoFacturaComboBox"
        Me.TipoFacturaComboBox.Size = New System.Drawing.Size(44, 21)
        Me.TipoFacturaComboBox.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreArticulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'EncabezadoFacturaBindingSource
        '
        Me.EncabezadoFacturaBindingSource.DataSource = GetType(Entidades.Factura)
        '
        'idArticulo
        '
        Me.idArticulo.DataPropertyName = "idArticulo"
        Me.idArticulo.HeaderText = "Codigo"
        Me.idArticulo.Name = "idArticulo"
        Me.idArticulo.ReadOnly = True
        Me.idArticulo.Width = 70
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio"
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
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(979, 502)
        Me.Controls.Add(Me.DetalleFacturaDataGridView)
        Me.Controls.Add(Me.TipoFacturaComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.ClienteComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Eliminar)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.cmb_Agregar)
        Me.Controls.Add(Me.txt_nombre_art)
        Me.Controls.Add(Me.txt_preciov_art)
        Me.Controls.Add(Me.cmb_Cobrar)
        Me.Controls.Add(Me.txt_Pagar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgv_facturas_prod)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA"
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Pagar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_Cobrar As System.Windows.Forms.Button
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgregarArticulosBindingSource As BindingSource
    Friend WithEvents EncabezadoFacturaBindingSource As BindingSource
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents dgv_facturas_prod As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_Eliminar As Button
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents cmb_Agregar As Button
    Friend WithEvents txt_nombre_art As TextBox
    Friend WithEvents txt_preciov_art As TextBox
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DetalleFacturaDataGridView As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreArticulo As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaComboBox As ComboBox
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSourceArticulo As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idArticulo As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
