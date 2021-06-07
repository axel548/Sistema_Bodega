<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubForm_Profesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubForm_Profesor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bf_GradianPNL = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_apellido = New System.Windows.Forms.Label()
        Me.Txt_apellido = New System.Windows.Forms.TextBox()
        Me.Lbl_Aviso = New System.Windows.Forms.Label()
        Me.Dgv_SubPro = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialdiadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfesorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet = New IES.BodegaDataSet()
        Me.Pctb_Error4 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error3 = New System.Windows.Forms.PictureBox()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.TxtDPI1 = New System.Windows.Forms.TextBox()
        Me.Lbl_carne = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDPI2 = New System.Windows.Forms.TextBox()
        Me.TxtDPI3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Lbl_Modobusqueda = New System.Windows.Forms.Label()
        Me.Rbtn_nombre = New System.Windows.Forms.RadioButton()
        Me.Rbtn_dpi = New System.Windows.Forms.RadioButton()
        Me.Rbtn_apellido = New System.Windows.Forms.RadioButton()
        Me.Cb_Especiali = New System.Windows.Forms.ComboBox()
        Me.lbl_especialdiad = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProfesorTableAdapter = New IES.BodegaDataSetTableAdapters.profesorTableAdapter()
        Me.Bf_GradianPNL.SuspendLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_SubPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bf_GradianPNL
        '
        Me.Bf_GradianPNL.BackgroundImage = CType(resources.GetObject("Bf_GradianPNL.BackgroundImage"), System.Drawing.Image)
        Me.Bf_GradianPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bf_GradianPNL.Controls.Add(Me.Pctb_salir)
        Me.Bf_GradianPNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bf_GradianPNL.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_GradianPNL.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Bf_GradianPNL.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_GradianPNL.GradientTopRight = System.Drawing.Color.White
        Me.Bf_GradianPNL.Location = New System.Drawing.Point(0, 0)
        Me.Bf_GradianPNL.Name = "Bf_GradianPNL"
        Me.Bf_GradianPNL.Quality = 10
        Me.Bf_GradianPNL.Size = New System.Drawing.Size(440, 28)
        Me.Bf_GradianPNL.TabIndex = 149
        '
        'Pctb_salir
        '
        Me.Pctb_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_salir.BackColor = System.Drawing.Color.Black
        Me.Pctb_salir.Image = CType(resources.GetObject("Pctb_salir.Image"), System.Drawing.Image)
        Me.Pctb_salir.Location = New System.Drawing.Point(410, -2)
        Me.Pctb_salir.Name = "Pctb_salir"
        Me.Pctb_salir.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_salir.TabIndex = 49
        Me.Pctb_salir.TabStop = False
        '
        'Pctb_Error2
        '
        Me.Pctb_Error2.Image = CType(resources.GetObject("Pctb_Error2.Image"), System.Drawing.Image)
        Me.Pctb_Error2.Location = New System.Drawing.Point(204, 90)
        Me.Pctb_Error2.Name = "Pctb_Error2"
        Me.Pctb_Error2.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error2.TabIndex = 181
        Me.Pctb_Error2.TabStop = False
        Me.Pctb_Error2.Visible = False
        '
        'Lbl_apellido
        '
        Me.Lbl_apellido.AutoSize = True
        Me.Lbl_apellido.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_apellido.Location = New System.Drawing.Point(10, 90)
        Me.Lbl_apellido.Name = "Lbl_apellido"
        Me.Lbl_apellido.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_apellido.TabIndex = 180
        Me.Lbl_apellido.Text = "Apellido:"
        '
        'Txt_apellido
        '
        Me.Txt_apellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_apellido.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_apellido.Location = New System.Drawing.Point(90, 90)
        Me.Txt_apellido.Name = "Txt_apellido"
        Me.Txt_apellido.ShortcutsEnabled = False
        Me.Txt_apellido.Size = New System.Drawing.Size(108, 22)
        Me.Txt_apellido.TabIndex = 4
        '
        'Lbl_Aviso
        '
        Me.Lbl_Aviso.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Aviso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Aviso.Location = New System.Drawing.Point(13, 174)
        Me.Lbl_Aviso.Name = "Lbl_Aviso"
        Me.Lbl_Aviso.Size = New System.Drawing.Size(195, 32)
        Me.Lbl_Aviso.TabIndex = 178
        Me.Lbl_Aviso.Text = "Presione DobleClick en una celda para seleccionar el registro"
        Me.Lbl_Aviso.Visible = False
        '
        'Dgv_SubPro
        '
        Me.Dgv_SubPro.AllowDrop = True
        Me.Dgv_SubPro.AllowUserToAddRows = False
        Me.Dgv_SubPro.AllowUserToDeleteRows = False
        Me.Dgv_SubPro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_SubPro.AutoGenerateColumns = False
        Me.Dgv_SubPro.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_SubPro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_SubPro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubPro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_SubPro.ColumnHeadersHeight = 30
        Me.Dgv_SubPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.EspecialdiadDataGridViewTextBoxColumn})
        Me.Dgv_SubPro.DataSource = Me.ProfesorBindingSource
        Me.Dgv_SubPro.EnableHeadersVisualStyles = False
        Me.Dgv_SubPro.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_SubPro.Location = New System.Drawing.Point(13, 209)
        Me.Dgv_SubPro.Name = "Dgv_SubPro"
        Me.Dgv_SubPro.ReadOnly = True
        Me.Dgv_SubPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubPro.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_SubPro.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_SubPro.RowTemplate.Height = 30
        Me.Dgv_SubPro.Size = New System.Drawing.Size(416, 152)
        Me.Dgv_SubPro.TabIndex = 173
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dpi"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DPI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'EspecialdiadDataGridViewTextBoxColumn
        '
        Me.EspecialdiadDataGridViewTextBoxColumn.DataPropertyName = "especialdiad"
        Me.EspecialdiadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialdiadDataGridViewTextBoxColumn.Name = "EspecialdiadDataGridViewTextBoxColumn"
        Me.EspecialdiadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProfesorBindingSource
        '
        Me.ProfesorBindingSource.DataMember = "profesor"
        Me.ProfesorBindingSource.DataSource = Me.BodegaDataSet
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pctb_Error4
        '
        Me.Pctb_Error4.Image = CType(resources.GetObject("Pctb_Error4.Image"), System.Drawing.Image)
        Me.Pctb_Error4.Location = New System.Drawing.Point(204, 62)
        Me.Pctb_Error4.Name = "Pctb_Error4"
        Me.Pctb_Error4.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error4.TabIndex = 163
        Me.Pctb_Error4.TabStop = False
        Me.Pctb_Error4.Visible = False
        '
        'Pctb_Error3
        '
        Me.Pctb_Error3.Image = CType(resources.GetObject("Pctb_Error3.Image"), System.Drawing.Image)
        Me.Pctb_Error3.Location = New System.Drawing.Point(204, 31)
        Me.Pctb_Error3.Name = "Pctb_Error3"
        Me.Pctb_Error3.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error3.TabIndex = 162
        Me.Pctb_Error3.TabStop = False
        Me.Pctb_Error3.Visible = False
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_nombre.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nombre.Location = New System.Drawing.Point(90, 62)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.ShortcutsEnabled = False
        Me.Txt_nombre.Size = New System.Drawing.Size(108, 22)
        Me.Txt_nombre.TabIndex = 3
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(10, 63)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_nombre.TabIndex = 160
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'TxtDPI1
        '
        Me.TxtDPI1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDPI1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDPI1.Location = New System.Drawing.Point(158, 32)
        Me.TxtDPI1.MaxLength = 4
        Me.TxtDPI1.Name = "TxtDPI1"
        Me.TxtDPI1.ShortcutsEnabled = False
        Me.TxtDPI1.Size = New System.Drawing.Size(43, 22)
        Me.TxtDPI1.TabIndex = 2
        '
        'Lbl_carne
        '
        Me.Lbl_carne.AutoSize = True
        Me.Lbl_carne.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_carne.Location = New System.Drawing.Point(12, 31)
        Me.Lbl_carne.Name = "Lbl_carne"
        Me.Lbl_carne.Size = New System.Drawing.Size(40, 19)
        Me.Lbl_carne.TabIndex = 158
        Me.Lbl_carne.Text = "DPI:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 19)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "-"
        '
        'TxtDPI2
        '
        Me.TxtDPI2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDPI2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDPI2.Location = New System.Drawing.Point(109, 32)
        Me.TxtDPI2.MaxLength = 5
        Me.TxtDPI2.Name = "TxtDPI2"
        Me.TxtDPI2.ShortcutsEnabled = False
        Me.TxtDPI2.Size = New System.Drawing.Size(43, 22)
        Me.TxtDPI2.TabIndex = 1
        '
        'TxtDPI3
        '
        Me.TxtDPI3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDPI3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDPI3.Location = New System.Drawing.Point(59, 32)
        Me.TxtDPI3.MaxLength = 4
        Me.TxtDPI3.Name = "TxtDPI3"
        Me.TxtDPI3.ShortcutsEnabled = False
        Me.TxtDPI3.Size = New System.Drawing.Size(43, 22)
        Me.TxtDPI3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 19)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "-"
        '
        'Btn_Search
        '
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Image = CType(resources.GetObject("Btn_Search.Image"), System.Drawing.Image)
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(378, 121)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Search.TabIndex = 187
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mostrar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mostrar.Image = CType(resources.GetObject("Btn_Mostrar.Image"), System.Drawing.Image)
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mostrar.Location = New System.Drawing.Point(378, 77)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Mostrar.TabIndex = 186
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(378, 165)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Add.TabIndex = 208
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(378, 121)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Cancelar.TabIndex = 209
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        Me.Btn_Cancelar.Visible = False
        '
        'Lbl_Modobusqueda
        '
        Me.Lbl_Modobusqueda.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Modobusqueda.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Modobusqueda.Location = New System.Drawing.Point(333, 36)
        Me.Lbl_Modobusqueda.Name = "Lbl_Modobusqueda"
        Me.Lbl_Modobusqueda.Size = New System.Drawing.Size(95, 18)
        Me.Lbl_Modobusqueda.TabIndex = 210
        Me.Lbl_Modobusqueda.Text = "Modo búsqueda"
        Me.Lbl_Modobusqueda.Visible = False
        '
        'Rbtn_nombre
        '
        Me.Rbtn_nombre.Location = New System.Drawing.Point(204, 62)
        Me.Rbtn_nombre.Name = "Rbtn_nombre"
        Me.Rbtn_nombre.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_nombre.TabIndex = 214
        Me.Rbtn_nombre.TabStop = True
        Me.Rbtn_nombre.UseVisualStyleBackColor = True
        Me.Rbtn_nombre.Visible = False
        '
        'Rbtn_dpi
        '
        Me.Rbtn_dpi.Location = New System.Drawing.Point(204, 31)
        Me.Rbtn_dpi.Name = "Rbtn_dpi"
        Me.Rbtn_dpi.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_dpi.TabIndex = 215
        Me.Rbtn_dpi.TabStop = True
        Me.Rbtn_dpi.UseVisualStyleBackColor = True
        Me.Rbtn_dpi.Visible = False
        '
        'Rbtn_apellido
        '
        Me.Rbtn_apellido.Location = New System.Drawing.Point(204, 90)
        Me.Rbtn_apellido.Name = "Rbtn_apellido"
        Me.Rbtn_apellido.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_apellido.TabIndex = 216
        Me.Rbtn_apellido.TabStop = True
        Me.Rbtn_apellido.UseVisualStyleBackColor = True
        Me.Rbtn_apellido.Visible = False
        '
        'Cb_Especiali
        '
        Me.Cb_Especiali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Especiali.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Especiali.FormattingEnabled = True
        Me.Cb_Especiali.Items.AddRange(New Object() {"Computación ", "Dibujo Técnico", "Electrónica", "Electricidad", "Mecánica", "Ciencias y Letras", "Básicos"})
        Me.Cb_Especiali.Location = New System.Drawing.Point(12, 142)
        Me.Cb_Especiali.Name = "Cb_Especiali"
        Me.Cb_Especiali.Size = New System.Drawing.Size(130, 22)
        Me.Cb_Especiali.TabIndex = 218
        '
        'lbl_especialdiad
        '
        Me.lbl_especialdiad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_especialdiad.AutoSize = True
        Me.lbl_especialdiad.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especialdiad.Location = New System.Drawing.Point(12, 120)
        Me.lbl_especialdiad.Name = "lbl_especialdiad"
        Me.lbl_especialdiad.Size = New System.Drawing.Size(108, 19)
        Me.lbl_especialdiad.TabIndex = 217
        Me.lbl_especialdiad.Text = "Especialidad:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(148, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 219
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'ProfesorTableAdapter
        '
        Me.ProfesorTableAdapter.ClearBeforeFill = True
        '
        'SubForm_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 370)
        Me.Controls.Add(Me.Cb_Especiali)
        Me.Controls.Add(Me.lbl_especialdiad)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Rbtn_apellido)
        Me.Controls.Add(Me.Rbtn_dpi)
        Me.Controls.Add(Me.Rbtn_nombre)
        Me.Controls.Add(Me.Lbl_Modobusqueda)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Btn_Mostrar)
        Me.Controls.Add(Me.TxtDPI3)
        Me.Controls.Add(Me.TxtDPI2)
        Me.Controls.Add(Me.Pctb_Error2)
        Me.Controls.Add(Me.Lbl_apellido)
        Me.Controls.Add(Me.Txt_apellido)
        Me.Controls.Add(Me.Lbl_Aviso)
        Me.Controls.Add(Me.Dgv_SubPro)
        Me.Controls.Add(Me.Pctb_Error4)
        Me.Controls.Add(Me.Pctb_Error3)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Lbl_nombre)
        Me.Controls.Add(Me.TxtDPI1)
        Me.Controls.Add(Me.Lbl_carne)
        Me.Controls.Add(Me.Bf_GradianPNL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubForm_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubForm_Profesor"
        Me.Bf_GradianPNL.ResumeLayout(False)
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_SubPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bf_GradianPNL As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Pctb_Error2 As PictureBox
    Friend WithEvents Lbl_apellido As Label
    Friend WithEvents Txt_apellido As TextBox
    Friend WithEvents Lbl_Aviso As Label
    Friend WithEvents Dgv_SubPro As DataGridView
    Friend WithEvents Pctb_Error4 As PictureBox
    Friend WithEvents Pctb_Error3 As PictureBox
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents TxtDPI1 As TextBox
    Friend WithEvents Lbl_carne As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDPI2 As TextBox
    Friend WithEvents TxtDPI3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DpiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Lbl_Modobusqueda As Label
    Friend WithEvents Rbtn_nombre As RadioButton
    Friend WithEvents Rbtn_dpi As RadioButton
    Friend WithEvents Rbtn_apellido As RadioButton
    Friend WithEvents Cb_Especiali As ComboBox
    Friend WithEvents lbl_especialdiad As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents ProfesorBindingSource As BindingSource
    Friend WithEvents ProfesorTableAdapter As BodegaDataSetTableAdapters.profesorTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents EspecialdiadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
