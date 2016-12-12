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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_BUSCAR_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.txt_pago_con = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_vuelto = New System.Windows.Forms.TextBox()
        Me.txt_Pagar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_Cobrar = New System.Windows.Forms.Button()
        Me.dgv_facturas_prod = New System.Windows.Forms.DataGridView()
        Me.IdArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.txt_nFactura = New System.Windows.Forms.TextBox()
        Me.EncabezadoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TipoFacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.DetalleFacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(541, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Buscar por codigo"
        '
        'TXT_BUSCAR_CODIGO
        '
        Me.TXT_BUSCAR_CODIGO.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BUSCAR_CODIGO.Location = New System.Drawing.Point(642, 50)
        Me.TXT_BUSCAR_CODIGO.Name = "TXT_BUSCAR_CODIGO"
        Me.TXT_BUSCAR_CODIGO.Size = New System.Drawing.Size(138, 20)
        Me.TXT_BUSCAR_CODIGO.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(538, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Buscar por nombre"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(642, 24)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(138, 20)
        Me.txt_buscar_nombre.TabIndex = 27
        '
        'txt_pago_con
        '
        Me.txt_pago_con.Location = New System.Drawing.Point(781, 329)
        Me.txt_pago_con.Name = "txt_pago_con"
        Me.txt_pago_con.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_con.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(545, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Devolver"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(716, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Pagon con"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Location = New System.Drawing.Point(605, 329)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(100, 20)
        Me.txt_vuelto.TabIndex = 38
        '
        'txt_Pagar
        '
        Me.txt_Pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pagar.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pagar.Location = New System.Drawing.Point(742, 367)
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
        Me.Label13.Location = New System.Drawing.Point(564, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 34)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Neto a pagar $"
        '
        'cmb_Cobrar
        '
        Me.cmb_Cobrar.Location = New System.Drawing.Point(622, 407)
        Me.cmb_Cobrar.Name = "cmb_Cobrar"
        Me.cmb_Cobrar.Size = New System.Drawing.Size(158, 36)
        Me.cmb_Cobrar.TabIndex = 41
        Me.cmb_Cobrar.Text = "Cobrar"
        Me.cmb_Cobrar.UseVisualStyleBackColor = True
        '
        'dgv_facturas_prod
        '
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
        Me.dgv_facturas_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticuloDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.dgv_facturas_prod.DataSource = Me.ArticuloBindingSource
        Me.dgv_facturas_prod.Location = New System.Drawing.Point(538, 81)
        Me.dgv_facturas_prod.Name = "dgv_facturas_prod"
        Me.dgv_facturas_prod.ReadOnly = True
        Me.dgv_facturas_prod.Size = New System.Drawing.Size(355, 242)
        Me.dgv_facturas_prod.TabIndex = 1
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
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(237, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(249, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.ClienteComboBox.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(101, 104)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClienteComboBox.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Nombre cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(67, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tipo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(37, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "N° Factura"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.BackColor = System.Drawing.Color.Transparent
        Me.FechaLabel.ForeColor = System.Drawing.Color.White
        Me.FechaLabel.Location = New System.Drawing.Point(102, 25)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 53
        Me.FechaLabel.Text = "Fecha"
        '
        'txt_nFactura
        '
        Me.txt_nFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncabezadoFacturaBindingSource, "IdFactura", True))
        Me.txt_nFactura.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nFactura.Location = New System.Drawing.Point(101, 52)
        Me.txt_nFactura.Name = "txt_nFactura"
        Me.txt_nFactura.Size = New System.Drawing.Size(100, 20)
        Me.txt_nFactura.TabIndex = 56
        '
        'EncabezadoFacturaBindingSource
        '
        Me.EncabezadoFacturaBindingSource.DataSource = GetType(Entidades.Factura)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Location = New System.Drawing.Point(840, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(58, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Fecha"
        '
        'TipoFacturaComboBox
        '
        Me.TipoFacturaComboBox.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoFacturaComboBox.FormattingEnabled = True
        Me.TipoFacturaComboBox.Location = New System.Drawing.Point(101, 77)
        Me.TipoFacturaComboBox.Name = "TipoFacturaComboBox"
        Me.TipoFacturaComboBox.Size = New System.Drawing.Size(44, 21)
        Me.TipoFacturaComboBox.TabIndex = 61
        '
        'DetalleFacturaDataGridView
        '
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
        Me.DetalleFacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn1, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DetalleFacturaDataGridView.DataSource = Me.DetalleFacturaBindingSource
        Me.DetalleFacturaDataGridView.Location = New System.Drawing.Point(22, 146)
        Me.DetalleFacturaDataGridView.Name = "DetalleFacturaDataGridView"
        Me.DetalleFacturaDataGridView.Size = New System.Drawing.Size(510, 311)
        Me.DetalleFacturaDataGridView.TabIndex = 62
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataSource = GetType(Entidades.FacturaDetalle)
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 502)
        Me.Controls.Add(Me.DetalleFacturaDataGridView)
        Me.Controls.Add(Me.TipoFacturaComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.txt_nFactura)
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
        Me.Controls.Add(Me.txt_pago_con)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_vuelto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_BUSCAR_CODIGO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.dgv_facturas_prod)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA"
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_BUSCAR_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_pago_con As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_vuelto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Pagar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_Cobrar As System.Windows.Forms.Button
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgregarArticulosBindingSource As BindingSource
    Friend WithEvents EncabezadoFacturaBindingSource As BindingSource
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents dgv_facturas_prod As DataGridView
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents IdArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents Label8 As Label
    Friend WithEvents FechaLabel As Label
    Friend WithEvents txt_nFactura As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TipoFacturaComboBox As ComboBox
    Friend WithEvents DetalleFacturaDataGridView As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
