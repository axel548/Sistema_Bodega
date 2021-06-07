<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perdida_Reparación
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perdida_Reparación))
        Me.Dgv_Pendientes = New System.Windows.Forms.DataGridView()
        Me.NoLFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoprestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CobrolfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoríaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LosefixBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet = New IES.BodegaDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pctb_ayuda = New System.Windows.Forms.PictureBox()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Lbl_herramienta = New System.Windows.Forms.Label()
        Me.txt_herramienta = New System.Windows.Forms.TextBox()
        Me.Btn_generarCodigo = New System.Windows.Forms.Button()
        Me.Lbl_no = New System.Windows.Forms.Label()
        Me.Txt_no = New System.Windows.Forms.TextBox()
        Me.Lbl_cantHerr = New System.Windows.Forms.Label()
        Me.Txt_cantHerr = New System.Windows.Forms.TextBox()
        Me.Txt_preUnit = New System.Windows.Forms.TextBox()
        Me.Lbl_preUnit = New System.Windows.Forms.Label()
        Me.Lbl_estado = New System.Windows.Forms.Label()
        Me.Cb_estado = New System.Windows.Forms.ComboBox()
        Me.Lbl_categoria = New System.Windows.Forms.Label()
        Me.Cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Lbl_codigo = New System.Windows.Forms.Label()
        Me.Txt_codigo = New System.Windows.Forms.TextBox()
        Me.Txt_dpi1 = New System.Windows.Forms.TextBox()
        Me.Txt_dpi2 = New System.Windows.Forms.TextBox()
        Me.Txt_dpi3 = New System.Windows.Forms.TextBox()
        Me.Lbl_guion1 = New System.Windows.Forms.Label()
        Me.Lbl_guion2 = New System.Windows.Forms.Label()
        Me.Lbl_dpi = New System.Windows.Forms.Label()
        Me.Txt_carne = New System.Windows.Forms.TextBox()
        Me.Lbl_carne = New System.Windows.Forms.Label()
        Me.Lbl_tipo = New System.Windows.Forms.Label()
        Me.Cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Lbl_total = New System.Windows.Forms.Label()
        Me.Btn_Modif = New System.Windows.Forms.Button()
        Me.Lose_fixTableAdapter = New IES.BodegaDataSetTableAdapters.lose_fixTableAdapter()
        Me.Lbl_articu = New System.Windows.Forms.Label()
        Me.Txt_articulo = New System.Windows.Forms.TextBox()
        Me.Txt_estudiante = New System.Windows.Forms.TextBox()
        Me.Lbl_Profesor = New System.Windows.Forms.Label()
        Me.Lbl_Estudiante = New System.Windows.Forms.Label()
        CType(Me.Dgv_Pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LosefixBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pctb_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Pendientes
        '
        Me.Dgv_Pendientes.AllowUserToAddRows = False
        Me.Dgv_Pendientes.AllowUserToDeleteRows = False
        Me.Dgv_Pendientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Pendientes.AutoGenerateColumns = False
        Me.Dgv_Pendientes.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Pendientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Pendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Pendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Pendientes.ColumnHeadersHeight = 30
        Me.Dgv_Pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoLFDataGridViewTextBoxColumn, Me.NoprestDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.ArticuloDataGridViewTextBoxColumn, Me.CodigoPersonaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CobrolfDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.CategoríaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.Dgv_Pendientes.DataSource = Me.LosefixBindingSource
        Me.Dgv_Pendientes.EnableHeadersVisualStyles = False
        Me.Dgv_Pendientes.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_Pendientes.Location = New System.Drawing.Point(12, 285)
        Me.Dgv_Pendientes.Name = "Dgv_Pendientes"
        Me.Dgv_Pendientes.ReadOnly = True
        Me.Dgv_Pendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Pendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_Pendientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Pendientes.Size = New System.Drawing.Size(699, 302)
        Me.Dgv_Pendientes.TabIndex = 51
        '
        'NoLFDataGridViewTextBoxColumn
        '
        Me.NoLFDataGridViewTextBoxColumn.DataPropertyName = "no_LF"
        Me.NoLFDataGridViewTextBoxColumn.HeaderText = "No. Herramienta"
        Me.NoLFDataGridViewTextBoxColumn.Name = "NoLFDataGridViewTextBoxColumn"
        Me.NoLFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoprestDataGridViewTextBoxColumn
        '
        Me.NoprestDataGridViewTextBoxColumn.DataPropertyName = "no_prest"
        Me.NoprestDataGridViewTextBoxColumn.HeaderText = "No. Prestamo"
        Me.NoprestDataGridViewTextBoxColumn.Name = "NoprestDataGridViewTextBoxColumn"
        Me.NoprestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoPersonaDataGridViewTextBoxColumn
        '
        Me.CodigoPersonaDataGridViewTextBoxColumn.DataPropertyName = "codigoPersona"
        Me.CodigoPersonaDataGridViewTextBoxColumn.HeaderText = "Carne/DPI"
        Me.CodigoPersonaDataGridViewTextBoxColumn.Name = "CodigoPersonaDataGridViewTextBoxColumn"
        Me.CodigoPersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CobrolfDataGridViewTextBoxColumn
        '
        Me.CobrolfDataGridViewTextBoxColumn.DataPropertyName = "cobro_lf"
        Me.CobrolfDataGridViewTextBoxColumn.HeaderText = "Cobro c/u"
        Me.CobrolfDataGridViewTextBoxColumn.Name = "CobrolfDataGridViewTextBoxColumn"
        Me.CobrolfDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoríaDataGridViewTextBoxColumn
        '
        Me.CategoríaDataGridViewTextBoxColumn.DataPropertyName = "categoría"
        Me.CategoríaDataGridViewTextBoxColumn.HeaderText = "Categoría"
        Me.CategoríaDataGridViewTextBoxColumn.Name = "CategoríaDataGridViewTextBoxColumn"
        Me.CategoríaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LosefixBindingSource
        '
        Me.LosefixBindingSource.DataMember = "lose_fix"
        Me.LosefixBindingSource.DataSource = Me.BodegaDataSet
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 38)
        Me.Panel1.TabIndex = 53
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Pctb_ayuda)
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_Titulo)
        Me.BunifuGradientPanel1.Controls.Add(Me.Pctb_salir)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(723, 38)
        Me.BunifuGradientPanel1.TabIndex = 85
        '
        'Pctb_ayuda
        '
        Me.Pctb_ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_ayuda.BackColor = System.Drawing.Color.Transparent
        Me.Pctb_ayuda.Image = CType(resources.GetObject("Pctb_ayuda.Image"), System.Drawing.Image)
        Me.Pctb_ayuda.Location = New System.Drawing.Point(652, 3)
        Me.Pctb_ayuda.Name = "Pctb_ayuda"
        Me.Pctb_ayuda.Size = New System.Drawing.Size(32, 32)
        Me.Pctb_ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pctb_ayuda.TabIndex = 93
        Me.Pctb_ayuda.TabStop = False
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Titulo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.Black
        Me.lbl_Titulo.Location = New System.Drawing.Point(84, 3)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(541, 32)
        Me.lbl_Titulo.TabIndex = 47
        Me.lbl_Titulo.Text = "Perdida y/o Reparación de Herramienta"
        '
        'Pctb_salir
        '
        Me.Pctb_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_salir.BackColor = System.Drawing.Color.Black
        Me.Pctb_salir.Image = CType(resources.GetObject("Pctb_salir.Image"), System.Drawing.Image)
        Me.Pctb_salir.Location = New System.Drawing.Point(690, 3)
        Me.Pctb_salir.Name = "Pctb_salir"
        Me.Pctb_salir.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_salir.TabIndex = 48
        Me.Pctb_salir.TabStop = False
        '
        'Lbl_herramienta
        '
        Me.Lbl_herramienta.AutoSize = True
        Me.Lbl_herramienta.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_herramienta.Location = New System.Drawing.Point(12, 61)
        Me.Lbl_herramienta.Name = "Lbl_herramienta"
        Me.Lbl_herramienta.Size = New System.Drawing.Size(128, 19)
        Me.Lbl_herramienta.TabIndex = 197
        Me.Lbl_herramienta.Text = "No. Herramienta:"
        '
        'txt_herramienta
        '
        Me.txt_herramienta.Enabled = False
        Me.txt_herramienta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_herramienta.Location = New System.Drawing.Point(146, 61)
        Me.txt_herramienta.Name = "txt_herramienta"
        Me.txt_herramienta.ShortcutsEnabled = False
        Me.txt_herramienta.Size = New System.Drawing.Size(83, 21)
        Me.txt_herramienta.TabIndex = 196
        '
        'Btn_generarCodigo
        '
        Me.Btn_generarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_generarCodigo.Image = CType(resources.GetObject("Btn_generarCodigo.Image"), System.Drawing.Image)
        Me.Btn_generarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_generarCodigo.Location = New System.Drawing.Point(68, 241)
        Me.Btn_generarCodigo.Name = "Btn_generarCodigo"
        Me.Btn_generarCodigo.Size = New System.Drawing.Size(94, 38)
        Me.Btn_generarCodigo.TabIndex = 195
        Me.Btn_generarCodigo.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.Btn_generarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_generarCodigo.UseVisualStyleBackColor = True
        '
        'Lbl_no
        '
        Me.Lbl_no.AutoSize = True
        Me.Lbl_no.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_no.Location = New System.Drawing.Point(31, 93)
        Me.Lbl_no.Name = "Lbl_no"
        Me.Lbl_no.Size = New System.Drawing.Size(109, 19)
        Me.Lbl_no.TabIndex = 199
        Me.Lbl_no.Text = "No. Prestamo:"
        '
        'Txt_no
        '
        Me.Txt_no.Enabled = False
        Me.Txt_no.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_no.Location = New System.Drawing.Point(146, 91)
        Me.Txt_no.Name = "Txt_no"
        Me.Txt_no.ShortcutsEnabled = False
        Me.Txt_no.Size = New System.Drawing.Size(83, 21)
        Me.Txt_no.TabIndex = 198
        '
        'Lbl_cantHerr
        '
        Me.Lbl_cantHerr.AutoSize = True
        Me.Lbl_cantHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cantHerr.Location = New System.Drawing.Point(441, 191)
        Me.Lbl_cantHerr.Name = "Lbl_cantHerr"
        Me.Lbl_cantHerr.Size = New System.Drawing.Size(82, 19)
        Me.Lbl_cantHerr.TabIndex = 200
        Me.Lbl_cantHerr.Text = "Cantidad:"
        '
        'Txt_cantHerr
        '
        Me.Txt_cantHerr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_cantHerr.Enabled = False
        Me.Txt_cantHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cantHerr.Location = New System.Drawing.Point(544, 188)
        Me.Txt_cantHerr.MaxLength = 15
        Me.Txt_cantHerr.Name = "Txt_cantHerr"
        Me.Txt_cantHerr.ShortcutsEnabled = False
        Me.Txt_cantHerr.Size = New System.Drawing.Size(140, 26)
        Me.Txt_cantHerr.TabIndex = 201
        '
        'Txt_preUnit
        '
        Me.Txt_preUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_preUnit.Enabled = False
        Me.Txt_preUnit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_preUnit.Location = New System.Drawing.Point(544, 222)
        Me.Txt_preUnit.Name = "Txt_preUnit"
        Me.Txt_preUnit.ShortcutsEnabled = False
        Me.Txt_preUnit.Size = New System.Drawing.Size(140, 26)
        Me.Txt_preUnit.TabIndex = 203
        '
        'Lbl_preUnit
        '
        Me.Lbl_preUnit.AutoSize = True
        Me.Lbl_preUnit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_preUnit.Location = New System.Drawing.Point(441, 222)
        Me.Lbl_preUnit.Name = "Lbl_preUnit"
        Me.Lbl_preUnit.Size = New System.Drawing.Size(88, 19)
        Me.Lbl_preUnit.TabIndex = 202
        Me.Lbl_preUnit.Text = "Precio c/u:"
        '
        'Lbl_estado
        '
        Me.Lbl_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_estado.AutoSize = True
        Me.Lbl_estado.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_estado.Location = New System.Drawing.Point(8, 170)
        Me.Lbl_estado.Name = "Lbl_estado"
        Me.Lbl_estado.Size = New System.Drawing.Size(64, 19)
        Me.Lbl_estado.TabIndex = 207
        Me.Lbl_estado.Text = "Estado:"
        '
        'Cb_estado
        '
        Me.Cb_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_estado.BackColor = System.Drawing.Color.White
        Me.Cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_estado.Enabled = False
        Me.Cb_estado.FormattingEnabled = True
        Me.Cb_estado.Items.AddRange(New Object() {"Reparación", "Perdida"})
        Me.Cb_estado.Location = New System.Drawing.Point(102, 171)
        Me.Cb_estado.Name = "Cb_estado"
        Me.Cb_estado.Size = New System.Drawing.Size(138, 21)
        Me.Cb_estado.TabIndex = 206
        '
        'Lbl_categoria
        '
        Me.Lbl_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_categoria.AutoSize = True
        Me.Lbl_categoria.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_categoria.Location = New System.Drawing.Point(8, 142)
        Me.Lbl_categoria.Name = "Lbl_categoria"
        Me.Lbl_categoria.Size = New System.Drawing.Size(88, 19)
        Me.Lbl_categoria.TabIndex = 205
        Me.Lbl_categoria.Text = "Categoría:"
        '
        'Cb_categoria
        '
        Me.Cb_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categoria.BackColor = System.Drawing.Color.White
        Me.Cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categoria.Enabled = False
        Me.Cb_categoria.FormattingEnabled = True
        Me.Cb_categoria.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica"})
        Me.Cb_categoria.Location = New System.Drawing.Point(102, 140)
        Me.Cb_categoria.Name = "Cb_categoria"
        Me.Cb_categoria.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categoria.TabIndex = 204
        '
        'Lbl_codigo
        '
        Me.Lbl_codigo.AutoSize = True
        Me.Lbl_codigo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_codigo.Location = New System.Drawing.Point(441, 129)
        Me.Lbl_codigo.Name = "Lbl_codigo"
        Me.Lbl_codigo.Size = New System.Drawing.Size(68, 19)
        Me.Lbl_codigo.TabIndex = 208
        Me.Lbl_codigo.Text = "Código:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Txt_codigo
        '
        Me.Txt_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_codigo.Enabled = False
        Me.Txt_codigo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_codigo.Location = New System.Drawing.Point(544, 122)
        Me.Txt_codigo.MaxLength = 3000
        Me.Txt_codigo.Name = "Txt_codigo"
        Me.Txt_codigo.ShortcutsEnabled = False
        Me.Txt_codigo.Size = New System.Drawing.Size(144, 26)
        Me.Txt_codigo.TabIndex = 209
        '
        'Txt_dpi1
        '
        Me.Txt_dpi1.Enabled = False
        Me.Txt_dpi1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dpi1.Location = New System.Drawing.Point(544, 63)
        Me.Txt_dpi1.MaxLength = 4
        Me.Txt_dpi1.Name = "Txt_dpi1"
        Me.Txt_dpi1.ShortcutsEnabled = False
        Me.Txt_dpi1.Size = New System.Drawing.Size(38, 22)
        Me.Txt_dpi1.TabIndex = 234
        Me.Txt_dpi1.Visible = False
        '
        'Txt_dpi2
        '
        Me.Txt_dpi2.Enabled = False
        Me.Txt_dpi2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dpi2.Location = New System.Drawing.Point(588, 63)
        Me.Txt_dpi2.MaxLength = 5
        Me.Txt_dpi2.Name = "Txt_dpi2"
        Me.Txt_dpi2.ShortcutsEnabled = False
        Me.Txt_dpi2.Size = New System.Drawing.Size(43, 22)
        Me.Txt_dpi2.TabIndex = 235
        Me.Txt_dpi2.Visible = False
        '
        'Txt_dpi3
        '
        Me.Txt_dpi3.Enabled = False
        Me.Txt_dpi3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dpi3.Location = New System.Drawing.Point(637, 63)
        Me.Txt_dpi3.MaxLength = 4
        Me.Txt_dpi3.Name = "Txt_dpi3"
        Me.Txt_dpi3.ShortcutsEnabled = False
        Me.Txt_dpi3.Size = New System.Drawing.Size(38, 22)
        Me.Txt_dpi3.TabIndex = 236
        Me.Txt_dpi3.Visible = False
        '
        'Lbl_guion1
        '
        Me.Lbl_guion1.AutoSize = True
        Me.Lbl_guion1.Enabled = False
        Me.Lbl_guion1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_guion1.Location = New System.Drawing.Point(579, 63)
        Me.Lbl_guion1.Name = "Lbl_guion1"
        Me.Lbl_guion1.Size = New System.Drawing.Size(15, 19)
        Me.Lbl_guion1.TabIndex = 237
        Me.Lbl_guion1.Text = "-"
        Me.Lbl_guion1.Visible = False
        '
        'Lbl_guion2
        '
        Me.Lbl_guion2.AutoSize = True
        Me.Lbl_guion2.Enabled = False
        Me.Lbl_guion2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_guion2.Location = New System.Drawing.Point(628, 63)
        Me.Lbl_guion2.Name = "Lbl_guion2"
        Me.Lbl_guion2.Size = New System.Drawing.Size(15, 19)
        Me.Lbl_guion2.TabIndex = 238
        Me.Lbl_guion2.Text = "-"
        Me.Lbl_guion2.Visible = False
        '
        'Lbl_dpi
        '
        Me.Lbl_dpi.AutoSize = True
        Me.Lbl_dpi.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dpi.Location = New System.Drawing.Point(444, 64)
        Me.Lbl_dpi.Name = "Lbl_dpi"
        Me.Lbl_dpi.Size = New System.Drawing.Size(40, 19)
        Me.Lbl_dpi.TabIndex = 233
        Me.Lbl_dpi.Text = "DPI:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbl_dpi.Visible = False
        '
        'Txt_carne
        '
        Me.Txt_carne.Enabled = False
        Me.Txt_carne.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_carne.Location = New System.Drawing.Point(544, 61)
        Me.Txt_carne.MaxLength = 3000
        Me.Txt_carne.Name = "Txt_carne"
        Me.Txt_carne.ShortcutsEnabled = False
        Me.Txt_carne.Size = New System.Drawing.Size(108, 26)
        Me.Txt_carne.TabIndex = 231
        '
        'Lbl_carne
        '
        Me.Lbl_carne.AutoSize = True
        Me.Lbl_carne.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_carne.Location = New System.Drawing.Point(444, 66)
        Me.Lbl_carne.Name = "Lbl_carne"
        Me.Lbl_carne.Size = New System.Drawing.Size(60, 19)
        Me.Lbl_carne.TabIndex = 230
        Me.Lbl_carne.Text = "Carne:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbl_carne.Visible = False
        '
        'Lbl_tipo
        '
        Me.Lbl_tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_tipo.AutoSize = True
        Me.Lbl_tipo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_tipo.Location = New System.Drawing.Point(8, 197)
        Me.Lbl_tipo.Name = "Lbl_tipo"
        Me.Lbl_tipo.Size = New System.Drawing.Size(46, 19)
        Me.Lbl_tipo.TabIndex = 240
        Me.Lbl_tipo.Text = "Tipo:"
        '
        'Cb_tipo
        '
        Me.Cb_tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_tipo.BackColor = System.Drawing.Color.White
        Me.Cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_tipo.Enabled = False
        Me.Cb_tipo.FormattingEnabled = True
        Me.Cb_tipo.Items.AddRange(New Object() {"Estudiante", "Profesor"})
        Me.Cb_tipo.Location = New System.Drawing.Point(102, 198)
        Me.Cb_tipo.Name = "Cb_tipo"
        Me.Cb_tipo.Size = New System.Drawing.Size(138, 21)
        Me.Cb_tipo.TabIndex = 239
        '
        'Txt_total
        '
        Me.Txt_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_total.Enabled = False
        Me.Txt_total.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_total.Location = New System.Drawing.Point(512, 254)
        Me.Txt_total.Name = "Txt_total"
        Me.Txt_total.ShortcutsEnabled = False
        Me.Txt_total.Size = New System.Drawing.Size(172, 26)
        Me.Txt_total.TabIndex = 241
        '
        'Lbl_total
        '
        Me.Lbl_total.AutoSize = True
        Me.Lbl_total.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_total.Location = New System.Drawing.Point(444, 257)
        Me.Lbl_total.Name = "Lbl_total"
        Me.Lbl_total.Size = New System.Drawing.Size(50, 19)
        Me.Lbl_total.TabIndex = 242
        Me.Lbl_total.Text = "Total:"
        '
        'Btn_Modif
        '
        Me.Btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modif.Image = CType(resources.GetObject("Btn_Modif.Image"), System.Drawing.Image)
        Me.Btn_Modif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modif.Location = New System.Drawing.Point(12, 241)
        Me.Btn_Modif.Name = "Btn_Modif"
        Me.Btn_Modif.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Modif.TabIndex = 243
        Me.Btn_Modif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modif.UseVisualStyleBackColor = True
        '
        'Lose_fixTableAdapter
        '
        Me.Lose_fixTableAdapter.ClearBeforeFill = True
        '
        'Lbl_articu
        '
        Me.Lbl_articu.AutoSize = True
        Me.Lbl_articu.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_articu.Location = New System.Drawing.Point(441, 157)
        Me.Lbl_articu.Name = "Lbl_articu"
        Me.Lbl_articu.Size = New System.Drawing.Size(71, 19)
        Me.Lbl_articu.TabIndex = 244
        Me.Lbl_articu.Text = "Artículo:"
        '
        'Txt_articulo
        '
        Me.Txt_articulo.Enabled = False
        Me.Txt_articulo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_articulo.Location = New System.Drawing.Point(544, 154)
        Me.Txt_articulo.Name = "Txt_articulo"
        Me.Txt_articulo.ShortcutsEnabled = False
        Me.Txt_articulo.Size = New System.Drawing.Size(144, 26)
        Me.Txt_articulo.TabIndex = 245
        '
        'Txt_estudiante
        '
        Me.Txt_estudiante.Enabled = False
        Me.Txt_estudiante.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_estudiante.Location = New System.Drawing.Point(544, 91)
        Me.Txt_estudiante.Name = "Txt_estudiante"
        Me.Txt_estudiante.ShortcutsEnabled = False
        Me.Txt_estudiante.Size = New System.Drawing.Size(108, 26)
        Me.Txt_estudiante.TabIndex = 247
        '
        'Lbl_Profesor
        '
        Me.Lbl_Profesor.AutoSize = True
        Me.Lbl_Profesor.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Profesor.Location = New System.Drawing.Point(444, 94)
        Me.Lbl_Profesor.Name = "Lbl_Profesor"
        Me.Lbl_Profesor.Size = New System.Drawing.Size(76, 19)
        Me.Lbl_Profesor.TabIndex = 248
        Me.Lbl_Profesor.Text = "Profesor:"
        Me.Lbl_Profesor.Visible = False
        '
        'Lbl_Estudiante
        '
        Me.Lbl_Estudiante.AutoSize = True
        Me.Lbl_Estudiante.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Estudiante.Location = New System.Drawing.Point(444, 94)
        Me.Lbl_Estudiante.Name = "Lbl_Estudiante"
        Me.Lbl_Estudiante.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_Estudiante.TabIndex = 246
        Me.Lbl_Estudiante.Text = "Estudiante:"
        Me.Lbl_Estudiante.Visible = False
        '
        'Perdida_Reparación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 599)
        Me.Controls.Add(Me.Txt_estudiante)
        Me.Controls.Add(Me.Lbl_Profesor)
        Me.Controls.Add(Me.Lbl_Estudiante)
        Me.Controls.Add(Me.Lbl_articu)
        Me.Controls.Add(Me.Txt_articulo)
        Me.Controls.Add(Me.Btn_Modif)
        Me.Controls.Add(Me.Txt_total)
        Me.Controls.Add(Me.Lbl_total)
        Me.Controls.Add(Me.Lbl_tipo)
        Me.Controls.Add(Me.Cb_tipo)
        Me.Controls.Add(Me.Txt_dpi1)
        Me.Controls.Add(Me.Txt_dpi2)
        Me.Controls.Add(Me.Txt_dpi3)
        Me.Controls.Add(Me.Lbl_guion1)
        Me.Controls.Add(Me.Lbl_guion2)
        Me.Controls.Add(Me.Lbl_dpi)
        Me.Controls.Add(Me.Txt_carne)
        Me.Controls.Add(Me.Lbl_carne)
        Me.Controls.Add(Me.Lbl_codigo)
        Me.Controls.Add(Me.Txt_codigo)
        Me.Controls.Add(Me.Lbl_estado)
        Me.Controls.Add(Me.Cb_estado)
        Me.Controls.Add(Me.Lbl_categoria)
        Me.Controls.Add(Me.Cb_categoria)
        Me.Controls.Add(Me.Txt_preUnit)
        Me.Controls.Add(Me.Lbl_preUnit)
        Me.Controls.Add(Me.Lbl_cantHerr)
        Me.Controls.Add(Me.Txt_cantHerr)
        Me.Controls.Add(Me.Lbl_no)
        Me.Controls.Add(Me.Txt_no)
        Me.Controls.Add(Me.Lbl_herramienta)
        Me.Controls.Add(Me.txt_herramienta)
        Me.Controls.Add(Me.Btn_generarCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dgv_Pendientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Perdida_Reparación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perdida_Reparación"
        CType(Me.Dgv_Pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LosefixBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pctb_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Pendientes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Pctb_ayuda As PictureBox
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Btn_generarCodigo As Button
    Friend WithEvents Lbl_herramienta As Label
    Friend WithEvents txt_herramienta As TextBox
    Friend WithEvents Lbl_no As Label
    Friend WithEvents Txt_no As TextBox
    Friend WithEvents Lbl_cantHerr As Label
    Friend WithEvents Txt_cantHerr As TextBox
    Friend WithEvents Txt_preUnit As TextBox
    Friend WithEvents Lbl_preUnit As Label
    Friend WithEvents Lbl_estado As Label
    Friend WithEvents Cb_estado As ComboBox
    Friend WithEvents Lbl_categoria As Label
    Friend WithEvents Cb_categoria As ComboBox
    Friend WithEvents Lbl_codigo As Label
    Friend WithEvents Txt_codigo As TextBox
    Friend WithEvents Txt_dpi1 As TextBox
    Friend WithEvents Txt_dpi2 As TextBox
    Friend WithEvents Txt_dpi3 As TextBox
    Friend WithEvents Lbl_guion1 As Label
    Friend WithEvents Lbl_guion2 As Label
    Friend WithEvents Lbl_dpi As Label
    Friend WithEvents Txt_carne As TextBox
    Friend WithEvents Lbl_carne As Label
    Friend WithEvents Lbl_tipo As Label
    Friend WithEvents Cb_tipo As ComboBox
    Friend WithEvents Txt_total As TextBox
    Friend WithEvents Lbl_total As Label
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents LosefixBindingSource As BindingSource
    Friend WithEvents Lose_fixTableAdapter As BodegaDataSetTableAdapters.lose_fixTableAdapter
    Friend WithEvents NoLFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoprestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CobrolfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoríaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_articu As Label
    Public WithEvents Txt_articulo As TextBox
    Public WithEvents Txt_estudiante As TextBox
    Friend WithEvents Lbl_Profesor As Label
    Friend WithEvents Lbl_Estudiante As Label
End Class
