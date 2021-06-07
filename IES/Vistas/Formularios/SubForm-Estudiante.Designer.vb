<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubForm_Estudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubForm_Estudiante))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pctb_Error4 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error3 = New System.Windows.Forms.PictureBox()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.Txt_carne = New System.Windows.Forms.TextBox()
        Me.Lbl_carne = New System.Windows.Forms.Label()
        Me.Cb_Especiali = New System.Windows.Forms.ComboBox()
        Me.lbl_especialdiad = New System.Windows.Forms.Label()
        Me.Pctb_Error7 = New System.Windows.Forms.PictureBox()
        Me.Cb_secc = New System.Windows.Forms.ComboBox()
        Me.Lbl_seccion = New System.Windows.Forms.Label()
        Me.Cb_grado = New System.Windows.Forms.ComboBox()
        Me.Lbl_grado = New System.Windows.Forms.Label()
        Me.Bf_GradianPNL = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Dgv_SubEst = New System.Windows.Forms.DataGridView()
        Me.CarneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudianteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet = New IES.BodegaDataSet()
        Me.Lbl_Aviso = New System.Windows.Forms.Label()
        Me.Txt_apellido = New System.Windows.Forms.TextBox()
        Me.Lbl_apellido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Rbtn_apellido = New System.Windows.Forms.RadioButton()
        Me.Rbtn_nombre = New System.Windows.Forms.RadioButton()
        Me.Rbtn_carne = New System.Windows.Forms.RadioButton()
        Me.Lbl_Modobusqueda = New System.Windows.Forms.Label()
        Me.Pctb_Error6 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error8 = New System.Windows.Forms.PictureBox()
        Me.EstudianteTableAdapter = New IES.BodegaDataSetTableAdapters.estudianteTableAdapter()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bf_GradianPNL.SuspendLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_SubEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pctb_Error4
        '
        Me.Pctb_Error4.Image = CType(resources.GetObject("Pctb_Error4.Image"), System.Drawing.Image)
        Me.Pctb_Error4.Location = New System.Drawing.Point(406, 36)
        Me.Pctb_Error4.Name = "Pctb_Error4"
        Me.Pctb_Error4.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error4.TabIndex = 134
        Me.Pctb_Error4.TabStop = False
        Me.Pctb_Error4.Visible = False
        '
        'Pctb_Error3
        '
        Me.Pctb_Error3.Image = CType(resources.GetObject("Pctb_Error3.Image"), System.Drawing.Image)
        Me.Pctb_Error3.Location = New System.Drawing.Point(184, 39)
        Me.Pctb_Error3.Name = "Pctb_Error3"
        Me.Pctb_Error3.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error3.TabIndex = 133
        Me.Pctb_Error3.TabStop = False
        Me.Pctb_Error3.Visible = False
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_nombre.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nombre.Location = New System.Drawing.Point(292, 36)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.ShortcutsEnabled = False
        Me.Txt_nombre.Size = New System.Drawing.Size(108, 22)
        Me.Txt_nombre.TabIndex = 1
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(212, 37)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_nombre.TabIndex = 131
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'Txt_carne
        '
        Me.Txt_carne.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_carne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_carne.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_carne.Location = New System.Drawing.Point(70, 37)
        Me.Txt_carne.MaxLength = 3000
        Me.Txt_carne.Name = "Txt_carne"
        Me.Txt_carne.ShortcutsEnabled = False
        Me.Txt_carne.Size = New System.Drawing.Size(108, 22)
        Me.Txt_carne.TabIndex = 0
        '
        'Lbl_carne
        '
        Me.Lbl_carne.AutoSize = True
        Me.Lbl_carne.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_carne.Location = New System.Drawing.Point(4, 39)
        Me.Lbl_carne.Name = "Lbl_carne"
        Me.Lbl_carne.Size = New System.Drawing.Size(60, 19)
        Me.Lbl_carne.TabIndex = 129
        Me.Lbl_carne.Text = "Carne:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cb_Especiali
        '
        Me.Cb_Especiali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Especiali.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Especiali.FormattingEnabled = True
        Me.Cb_Especiali.Items.AddRange(New Object() {"Computación ", "Dibujo Técnico", "Electrónica", "Electricidad", "Mecánica", "Ciencias y Letras", "Básicos"})
        Me.Cb_Especiali.Location = New System.Drawing.Point(16, 86)
        Me.Cb_Especiali.Name = "Cb_Especiali"
        Me.Cb_Especiali.Size = New System.Drawing.Size(130, 22)
        Me.Cb_Especiali.TabIndex = 3
        '
        'lbl_especialdiad
        '
        Me.lbl_especialdiad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_especialdiad.AutoSize = True
        Me.lbl_especialdiad.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especialdiad.Location = New System.Drawing.Point(12, 64)
        Me.lbl_especialdiad.Name = "lbl_especialdiad"
        Me.lbl_especialdiad.Size = New System.Drawing.Size(108, 19)
        Me.lbl_especialdiad.TabIndex = 135
        Me.lbl_especialdiad.Text = "Especialidad:"
        '
        'Pctb_Error7
        '
        Me.Pctb_Error7.Image = CType(resources.GetObject("Pctb_Error7.Image"), System.Drawing.Image)
        Me.Pctb_Error7.Location = New System.Drawing.Point(364, 93)
        Me.Pctb_Error7.Name = "Pctb_Error7"
        Me.Pctb_Error7.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error7.TabIndex = 146
        Me.Pctb_Error7.TabStop = False
        Me.Pctb_Error7.Visible = False
        '
        'Cb_secc
        '
        Me.Cb_secc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_secc.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_secc.FormattingEnabled = True
        Me.Cb_secc.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"})
        Me.Cb_secc.Location = New System.Drawing.Point(292, 92)
        Me.Cb_secc.Name = "Cb_secc"
        Me.Cb_secc.Size = New System.Drawing.Size(66, 22)
        Me.Cb_secc.TabIndex = 5
        '
        'Lbl_seccion
        '
        Me.Lbl_seccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_seccion.AutoSize = True
        Me.Lbl_seccion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_seccion.Location = New System.Drawing.Point(216, 95)
        Me.Lbl_seccion.Name = "Lbl_seccion"
        Me.Lbl_seccion.Size = New System.Drawing.Size(70, 19)
        Me.Lbl_seccion.TabIndex = 144
        Me.Lbl_seccion.Text = "Sección:"
        '
        'Cb_grado
        '
        Me.Cb_grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_grado.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_grado.FormattingEnabled = True
        Me.Cb_grado.Items.AddRange(New Object() {"6TO.", "5TO.", "4TO."})
        Me.Cb_grado.Location = New System.Drawing.Point(80, 111)
        Me.Cb_grado.Name = "Cb_grado"
        Me.Cb_grado.Size = New System.Drawing.Size(66, 22)
        Me.Cb_grado.TabIndex = 4
        '
        'Lbl_grado
        '
        Me.Lbl_grado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_grado.AutoSize = True
        Me.Lbl_grado.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_grado.Location = New System.Drawing.Point(12, 111)
        Me.Lbl_grado.Name = "Lbl_grado"
        Me.Lbl_grado.Size = New System.Drawing.Size(62, 19)
        Me.Lbl_grado.TabIndex = 142
        Me.Lbl_grado.Text = "Grado:"
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
        Me.Bf_GradianPNL.TabIndex = 148
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
        'Dgv_SubEst
        '
        Me.Dgv_SubEst.AllowDrop = True
        Me.Dgv_SubEst.AllowUserToAddRows = False
        Me.Dgv_SubEst.AllowUserToDeleteRows = False
        Me.Dgv_SubEst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_SubEst.AutoGenerateColumns = False
        Me.Dgv_SubEst.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_SubEst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_SubEst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubEst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_SubEst.ColumnHeadersHeight = 30
        Me.Dgv_SubEst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarneDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn, Me.GradoDataGridViewTextBoxColumn, Me.SeccionDataGridViewTextBoxColumn})
        Me.Dgv_SubEst.DataSource = Me.EstudianteBindingSource
        Me.Dgv_SubEst.EnableHeadersVisualStyles = False
        Me.Dgv_SubEst.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_SubEst.Location = New System.Drawing.Point(12, 198)
        Me.Dgv_SubEst.Name = "Dgv_SubEst"
        Me.Dgv_SubEst.ReadOnly = True
        Me.Dgv_SubEst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubEst.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_SubEst.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_SubEst.RowTemplate.Height = 30
        Me.Dgv_SubEst.Size = New System.Drawing.Size(416, 160)
        Me.Dgv_SubEst.TabIndex = 149
        '
        'CarneDataGridViewTextBoxColumn
        '
        Me.CarneDataGridViewTextBoxColumn.DataPropertyName = "carne"
        Me.CarneDataGridViewTextBoxColumn.HeaderText = "Carné"
        Me.CarneDataGridViewTextBoxColumn.Name = "CarneDataGridViewTextBoxColumn"
        Me.CarneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        Me.EspecialidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradoDataGridViewTextBoxColumn
        '
        Me.GradoDataGridViewTextBoxColumn.DataPropertyName = "grado"
        Me.GradoDataGridViewTextBoxColumn.HeaderText = "Grado"
        Me.GradoDataGridViewTextBoxColumn.Name = "GradoDataGridViewTextBoxColumn"
        Me.GradoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeccionDataGridViewTextBoxColumn
        '
        Me.SeccionDataGridViewTextBoxColumn.DataPropertyName = "seccion"
        Me.SeccionDataGridViewTextBoxColumn.HeaderText = "Sección"
        Me.SeccionDataGridViewTextBoxColumn.Name = "SeccionDataGridViewTextBoxColumn"
        Me.SeccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstudianteBindingSource
        '
        Me.EstudianteBindingSource.DataMember = "estudiante"
        Me.EstudianteBindingSource.DataSource = Me.BodegaDataSet
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Aviso
        '
        Me.Lbl_Aviso.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Aviso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Aviso.Location = New System.Drawing.Point(8, 163)
        Me.Lbl_Aviso.Name = "Lbl_Aviso"
        Me.Lbl_Aviso.Size = New System.Drawing.Size(195, 32)
        Me.Lbl_Aviso.TabIndex = 154
        Me.Lbl_Aviso.Text = "Presione DobleClick en una celda para seleccionar el registro"
        Me.Lbl_Aviso.Visible = False
        '
        'Txt_apellido
        '
        Me.Txt_apellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_apellido.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_apellido.Location = New System.Drawing.Point(292, 64)
        Me.Txt_apellido.Name = "Txt_apellido"
        Me.Txt_apellido.ShortcutsEnabled = False
        Me.Txt_apellido.Size = New System.Drawing.Size(108, 22)
        Me.Txt_apellido.TabIndex = 2
        '
        'Lbl_apellido
        '
        Me.Lbl_apellido.AutoSize = True
        Me.Lbl_apellido.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_apellido.Location = New System.Drawing.Point(212, 64)
        Me.Lbl_apellido.Name = "Lbl_apellido"
        Me.Lbl_apellido.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_apellido.TabIndex = 156
        Me.Lbl_apellido.Text = "Apellido:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(321, 154)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Cancelar.TabIndex = 213
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        Me.Btn_Cancelar.Visible = False
        '
        'Btn_Add
        '
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(377, 154)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Add.TabIndex = 212
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Image = CType(resources.GetObject("Btn_Search.Image"), System.Drawing.Image)
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(321, 154)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Search.TabIndex = 211
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mostrar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mostrar.Image = CType(resources.GetObject("Btn_Mostrar.Image"), System.Drawing.Image)
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mostrar.Location = New System.Drawing.Point(265, 154)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 38)
        Me.Btn_Mostrar.TabIndex = 210
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Rbtn_apellido
        '
        Me.Rbtn_apellido.Location = New System.Drawing.Point(406, 62)
        Me.Rbtn_apellido.Name = "Rbtn_apellido"
        Me.Rbtn_apellido.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_apellido.TabIndex = 217
        Me.Rbtn_apellido.TabStop = True
        Me.Rbtn_apellido.UseVisualStyleBackColor = True
        Me.Rbtn_apellido.Visible = False
        '
        'Rbtn_nombre
        '
        Me.Rbtn_nombre.Location = New System.Drawing.Point(406, 36)
        Me.Rbtn_nombre.Name = "Rbtn_nombre"
        Me.Rbtn_nombre.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_nombre.TabIndex = 218
        Me.Rbtn_nombre.TabStop = True
        Me.Rbtn_nombre.UseVisualStyleBackColor = True
        Me.Rbtn_nombre.Visible = False
        '
        'Rbtn_carne
        '
        Me.Rbtn_carne.Location = New System.Drawing.Point(184, 39)
        Me.Rbtn_carne.Name = "Rbtn_carne"
        Me.Rbtn_carne.Size = New System.Drawing.Size(22, 21)
        Me.Rbtn_carne.TabIndex = 222
        Me.Rbtn_carne.TabStop = True
        Me.Rbtn_carne.UseVisualStyleBackColor = True
        Me.Rbtn_carne.Visible = False
        '
        'Lbl_Modobusqueda
        '
        Me.Lbl_Modobusqueda.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Modobusqueda.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Modobusqueda.Location = New System.Drawing.Point(290, 133)
        Me.Lbl_Modobusqueda.Name = "Lbl_Modobusqueda"
        Me.Lbl_Modobusqueda.Size = New System.Drawing.Size(95, 18)
        Me.Lbl_Modobusqueda.TabIndex = 223
        Me.Lbl_Modobusqueda.Text = "Modo búsqueda"
        Me.Lbl_Modobusqueda.Visible = False
        '
        'Pctb_Error6
        '
        Me.Pctb_Error6.Image = CType(resources.GetObject("Pctb_Error6.Image"), System.Drawing.Image)
        Me.Pctb_Error6.Location = New System.Drawing.Point(152, 86)
        Me.Pctb_Error6.Name = "Pctb_Error6"
        Me.Pctb_Error6.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error6.TabIndex = 141
        Me.Pctb_Error6.TabStop = False
        Me.Pctb_Error6.Visible = False
        '
        'Pctb_Error8
        '
        Me.Pctb_Error8.Image = CType(resources.GetObject("Pctb_Error8.Image"), System.Drawing.Image)
        Me.Pctb_Error8.Location = New System.Drawing.Point(152, 112)
        Me.Pctb_Error8.Name = "Pctb_Error8"
        Me.Pctb_Error8.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error8.TabIndex = 147
        Me.Pctb_Error8.TabStop = False
        Me.Pctb_Error8.Visible = False
        '
        'EstudianteTableAdapter
        '
        Me.EstudianteTableAdapter.ClearBeforeFill = True
        '
        'SubForm_Estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 370)
        Me.Controls.Add(Me.Lbl_Modobusqueda)
        Me.Controls.Add(Me.Rbtn_carne)
        Me.Controls.Add(Me.Rbtn_nombre)
        Me.Controls.Add(Me.Rbtn_apellido)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Btn_Mostrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_apellido)
        Me.Controls.Add(Me.Txt_apellido)
        Me.Controls.Add(Me.Lbl_Aviso)
        Me.Controls.Add(Me.Dgv_SubEst)
        Me.Controls.Add(Me.Bf_GradianPNL)
        Me.Controls.Add(Me.Pctb_Error8)
        Me.Controls.Add(Me.Pctb_Error7)
        Me.Controls.Add(Me.Cb_secc)
        Me.Controls.Add(Me.Lbl_seccion)
        Me.Controls.Add(Me.Cb_grado)
        Me.Controls.Add(Me.Lbl_grado)
        Me.Controls.Add(Me.Pctb_Error6)
        Me.Controls.Add(Me.Cb_Especiali)
        Me.Controls.Add(Me.lbl_especialdiad)
        Me.Controls.Add(Me.Pctb_Error4)
        Me.Controls.Add(Me.Pctb_Error3)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Lbl_nombre)
        Me.Controls.Add(Me.Txt_carne)
        Me.Controls.Add(Me.Lbl_carne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubForm_Estudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubForm_Estudiante"
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bf_GradianPNL.ResumeLayout(False)
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_SubEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pctb_Error4 As PictureBox
    Friend WithEvents Pctb_Error3 As PictureBox
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents Txt_carne As TextBox
    Friend WithEvents Lbl_carne As Label
    Friend WithEvents Cb_Especiali As ComboBox
    Friend WithEvents lbl_especialdiad As Label
    Friend WithEvents Pctb_Error7 As PictureBox
    Friend WithEvents Cb_secc As ComboBox
    Friend WithEvents Lbl_seccion As Label
    Friend WithEvents Cb_grado As ComboBox
    Friend WithEvents Lbl_grado As Label
    Friend WithEvents Bf_GradianPNL As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Dgv_SubEst As DataGridView
    Friend WithEvents Lbl_Aviso As Label
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Txt_apellido As TextBox
    Friend WithEvents Lbl_apellido As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConteoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents Rbtn_apellido As RadioButton
    Friend WithEvents Rbtn_nombre As RadioButton
    Friend WithEvents Rbtn_carne As RadioButton
    Friend WithEvents Lbl_Modobusqueda As Label
    Friend WithEvents Pctb_Error6 As PictureBox
    Friend WithEvents Pctb_Error8 As PictureBox
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents EstudianteBindingSource As BindingSource
    Friend WithEvents EstudianteTableAdapter As BodegaDataSetTableAdapters.estudianteTableAdapter
    Friend WithEvents CarneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
