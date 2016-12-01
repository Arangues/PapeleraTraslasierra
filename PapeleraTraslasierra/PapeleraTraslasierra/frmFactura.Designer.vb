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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncabezadoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AgregarArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.txt_preciov_art = New System.Windows.Forms.TextBox()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nFactura = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataSource = GetType(Entidades.FacturaDetalle)
        '
        'EncabezadoFacturaBindingSource
        '
        Me.EncabezadoFacturaBindingSource.DataSource = GetType(Entidades.Factura)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(572, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Buscar por codigo"
        '
        'TXT_BUSCAR_CODIGO
        '
        Me.TXT_BUSCAR_CODIGO.Location = New System.Drawing.Point(673, 48)
        Me.TXT_BUSCAR_CODIGO.Name = "TXT_BUSCAR_CODIGO"
        Me.TXT_BUSCAR_CODIGO.Size = New System.Drawing.Size(138, 20)
        Me.TXT_BUSCAR_CODIGO.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(569, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Buscar por nombre"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(673, 22)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(138, 20)
        Me.txt_buscar_nombre.TabIndex = 27
        '
        'txt_pago_con
        '
        Me.txt_pago_con.Location = New System.Drawing.Point(816, 325)
        Me.txt_pago_con.Name = "txt_pago_con"
        Me.txt_pago_con.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_con.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(580, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Devolver"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(751, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Pagon con"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Location = New System.Drawing.Point(640, 325)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(100, 20)
        Me.txt_vuelto.TabIndex = 38
        '
        'txt_Pagar
        '
        Me.txt_Pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pagar.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pagar.Location = New System.Drawing.Point(754, 375)
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
        Me.Label13.Location = New System.Drawing.Point(576, 375)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 34)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Neto a pagar $"
        '
        'cmb_Cobrar
        '
        Me.cmb_Cobrar.Location = New System.Drawing.Point(582, 448)
        Me.cmb_Cobrar.Name = "cmb_Cobrar"
        Me.cmb_Cobrar.Size = New System.Drawing.Size(158, 36)
        Me.cmb_Cobrar.TabIndex = 41
        Me.cmb_Cobrar.Text = "Cobrar"
        Me.cmb_Cobrar.UseVisualStyleBackColor = True
        '
        'AgregarArticulosBindingSource
        '
        Me.AgregarArticulosBindingSource.DataSource = GetType(Entidades.Articulo)
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(47, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(519, 342)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle factura"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn1, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleFacturaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(510, 311)
        Me.DataGridView1.TabIndex = 0
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(746, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 36)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_facturas_prod
        '
        Me.dgv_facturas_prod.AutoGenerateColumns = False
        Me.dgv_facturas_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticuloDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.dgv_facturas_prod.DataSource = Me.ArticuloBindingSource
        Me.dgv_facturas_prod.Location = New System.Drawing.Point(572, 77)
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
        Me.Label6.Location = New System.Drawing.Point(268, 84)
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
        Me.Label5.Location = New System.Drawing.Point(275, 55)
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
        Me.Label4.Location = New System.Drawing.Point(268, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Nombre"
        '
        'cmb_Eliminar
        '
        Me.cmb_Eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Eliminar.Location = New System.Drawing.Point(403, 116)
        Me.cmb_Eliminar.Name = "cmb_Eliminar"
        Me.cmb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Eliminar.TabIndex = 47
        Me.cmb_Eliminar.Text = "Eliminar"
        Me.cmb_Eliminar.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(318, 81)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(160, 23)
        Me.txt_cantidad.TabIndex = 45
        '
        'cmb_Agregar
        '
        Me.cmb_Agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Agregar.Location = New System.Drawing.Point(318, 116)
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
        Me.txt_nombre_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_art.Location = New System.Drawing.Point(318, 23)
        Me.txt_nombre_art.Name = "txt_nombre_art"
        Me.txt_nombre_art.ReadOnly = True
        Me.txt_nombre_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_nombre_art.TabIndex = 43
        '
        'txt_preciov_art
        '
        Me.txt_preciov_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_preciov_art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgregarArticulosBindingSource, "PrecioVenta", True))
        Me.txt_preciov_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preciov_art.Location = New System.Drawing.Point(318, 52)
        Me.txt_preciov_art.Name = "txt_preciov_art"
        Me.txt_preciov_art.ReadOnly = True
        Me.txt_preciov_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_preciov_art.TabIndex = 44
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(127, 103)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCliente.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(45, 106)
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
        Me.Label1.Location = New System.Drawing.Point(93, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tipo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncabezadoFacturaBindingSource, "Tipo", True))
        Me.TextBox1.Location = New System.Drawing.Point(127, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TextBox1.TabIndex = 58
        '
        'txt_fecha
        '
        Me.txt_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncabezadoFacturaBindingSource, "Fecha", True))
        Me.txt_fecha.Location = New System.Drawing.Point(127, 25)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(63, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "N° Factura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(84, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Fecha"
        '
        'txt_nFactura
        '
        Me.txt_nFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncabezadoFacturaBindingSource, "NumeroFactura", True))
        Me.txt_nFactura.Location = New System.Drawing.Point(127, 51)
        Me.txt_nFactura.Name = "txt_nFactura"
        Me.txt_nFactura.Size = New System.Drawing.Size(100, 20)
        Me.txt_nFactura.TabIndex = 56
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Location = New System.Drawing.Point(874, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 531)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nFactura)
        Me.Controls.Add(Me.ComboBoxCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Eliminar)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.cmb_Agregar)
        Me.Controls.Add(Me.txt_nombre_art)
        Me.Controls.Add(Me.txt_preciov_art)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_Cobrar)
        Me.Controls.Add(Me.txt_Pagar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_pago_con)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_vuelto)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_BUSCAR_CODIGO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.dgv_facturas_prod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA"
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncabezadoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents AgregarArticulosBindingSource As BindingSource
    Friend WithEvents EncabezadoFacturaBindingSource As BindingSource
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents dgv_facturas_prod As DataGridView
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents IdArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_Eliminar As Button
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents cmb_Agregar As Button
    Friend WithEvents txt_nombre_art As TextBox
    Friend WithEvents txt_preciov_art As TextBox
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nFactura As TextBox
    Friend WithEvents Button2 As Button
End Class
