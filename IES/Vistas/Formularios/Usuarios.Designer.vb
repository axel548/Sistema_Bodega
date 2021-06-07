<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usr = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_contr = New System.Windows.Forms.TextBox()
        Me.lbl_tipUsr = New System.Windows.Forms.Label()
        Me.cb_tipUsr = New System.Windows.Forms.ComboBox()
        Me.tm_data = New System.Windows.Forms.Timer(Me.components)
        Me.Dgv_usr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet2 = New IES.BodegaDataSet()
        Me.Chkb_mostrarContra = New System.Windows.Forms.CheckBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pctb_ayuda = New System.Windows.Forms.PictureBox()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Pctb_Error7 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error6 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error5 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error4 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error3 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Delet = New System.Windows.Forms.Button()
        Me.Btn_Modif = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UsuariosTableAdapter2 = New IES.BodegaDataSetTableAdapters.usuariosTableAdapter()
        CType(Me.Dgv_usr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pctb_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_no
        '
        Me.txt_no.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Location = New System.Drawing.Point(109, 29)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.ShortcutsEnabled = False
        Me.txt_no.Size = New System.Drawing.Size(70, 21)
        Me.txt_no.TabIndex = 51
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(8, 32)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(95, 19)
        Me.lbl_no.TabIndex = 54
        Me.lbl_no.Text = "No. Usuario:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(9, 92)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(70, 19)
        Me.lbl_apellido.TabIndex = 56
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_apellido
        '
        Me.txt_apellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_apellido.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(111, 93)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ShortcutsEnabled = False
        Me.txt_apellido.Size = New System.Drawing.Size(269, 21)
        Me.txt_apellido.TabIndex = 55
        '
        'lbl_email
        '
        Me.lbl_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(9, 124)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(141, 19)
        Me.lbl_email.TabIndex = 58
        Me.lbl_email.Text = "Correo Electrónico:"
        '
        'txt_email
        '
        Me.txt_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_email.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(164, 124)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ShortcutsEnabled = False
        Me.txt_email.Size = New System.Drawing.Size(216, 21)
        Me.txt_email.TabIndex = 57
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(8, 61)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(69, 19)
        Me.lbl_nom.TabIndex = 60
        Me.lbl_nom.Text = "Nombre:"
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(109, 61)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.ShortcutsEnabled = False
        Me.txt_nom.Size = New System.Drawing.Size(269, 21)
        Me.txt_nom.TabIndex = 59
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(422, 32)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(67, 19)
        Me.lbl_usuario.TabIndex = 62
        Me.lbl_usuario.Text = "Usuario:"
        '
        'txt_usr
        '
        Me.txt_usr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_usr.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usr.Location = New System.Drawing.Point(495, 30)
        Me.txt_usr.Name = "txt_usr"
        Me.txt_usr.ShortcutsEnabled = False
        Me.txt_usr.Size = New System.Drawing.Size(195, 21)
        Me.txt_usr.TabIndex = 61
        '
        'lbl_pass
        '
        Me.lbl_pass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(419, 60)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(94, 19)
        Me.lbl_pass.TabIndex = 64
        Me.lbl_pass.Text = "Contraseña:"
        '
        'txt_contr
        '
        Me.txt_contr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_contr.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contr.Location = New System.Drawing.Point(524, 62)
        Me.txt_contr.Name = "txt_contr"
        Me.txt_contr.ShortcutsEnabled = False
        Me.txt_contr.Size = New System.Drawing.Size(166, 21)
        Me.txt_contr.TabIndex = 63
        Me.txt_contr.UseSystemPasswordChar = True
        '
        'lbl_tipUsr
        '
        Me.lbl_tipUsr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_tipUsr.AutoSize = True
        Me.lbl_tipUsr.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipUsr.Location = New System.Drawing.Point(419, 93)
        Me.lbl_tipUsr.Name = "lbl_tipUsr"
        Me.lbl_tipUsr.Size = New System.Drawing.Size(124, 19)
        Me.lbl_tipUsr.TabIndex = 66
        Me.lbl_tipUsr.Text = "Tipo de Usuario:"
        '
        'cb_tipUsr
        '
        Me.cb_tipUsr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tipUsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipUsr.FormattingEnabled = True
        Me.cb_tipUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cb_tipUsr.Items.AddRange(New Object() {"Administrador", "Estándar"})
        Me.cb_tipUsr.Location = New System.Drawing.Point(554, 94)
        Me.cb_tipUsr.Name = "cb_tipUsr"
        Me.cb_tipUsr.Size = New System.Drawing.Size(136, 21)
        Me.cb_tipUsr.TabIndex = 67
        '
        'Dgv_usr
        '
        Me.Dgv_usr.AllowUserToAddRows = False
        Me.Dgv_usr.AllowUserToDeleteRows = False
        Me.Dgv_usr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_usr.AutoGenerateColumns = False
        Me.Dgv_usr.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_usr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_usr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_usr.ColumnHeadersHeight = 30
        Me.Dgv_usr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.Dgv_usr.DataSource = Me.BindingSource2
        Me.Dgv_usr.EnableHeadersVisualStyles = False
        Me.Dgv_usr.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_usr.Location = New System.Drawing.Point(12, 10)
        Me.Dgv_usr.Name = "Dgv_usr"
        Me.Dgv_usr.ReadOnly = True
        Me.Dgv_usr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_usr.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_usr.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_usr.Size = New System.Drawing.Size(699, 223)
        Me.Dgv_usr.TabIndex = 49
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id_usr"
        Me.DataGridViewTextBoxColumn15.HeaderText = "No. Usuario"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 110
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 110
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn18.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 136
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "usr"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "passw"
        Me.DataGridViewTextBoxColumn20.HeaderText = "passw"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "tip_usr"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Tipo de Usuario"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "usuarios"
        Me.BindingSource2.DataSource = Me.BodegaDataSet2
        '
        'BodegaDataSet2
        '
        Me.BodegaDataSet2.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chkb_mostrarContra
        '
        Me.Chkb_mostrarContra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chkb_mostrarContra.AutoSize = True
        Me.Chkb_mostrarContra.Location = New System.Drawing.Point(572, 135)
        Me.Chkb_mostrarContra.Name = "Chkb_mostrarContra"
        Me.Chkb_mostrarContra.Size = New System.Drawing.Size(118, 17)
        Me.Chkb_mostrarContra.TabIndex = 74
        Me.Chkb_mostrarContra.Text = "Mostrar Contraseña"
        Me.Chkb_mostrarContra.UseVisualStyleBackColor = True
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
        Me.BunifuGradientPanel1.TabIndex = 82
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
        Me.lbl_Titulo.Location = New System.Drawing.Point(294, 3)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(146, 32)
        Me.lbl_Titulo.TabIndex = 47
        Me.lbl_Titulo.Text = "USUARIOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 38)
        Me.Panel1.TabIndex = 83
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dgv_usr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 245)
        Me.Panel2.TabIndex = 84
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Pctb_Error7)
        Me.Panel3.Controls.Add(Me.Pctb_Error6)
        Me.Panel3.Controls.Add(Me.Pctb_Error5)
        Me.Panel3.Controls.Add(Me.Pctb_Error4)
        Me.Panel3.Controls.Add(Me.Pctb_Error3)
        Me.Panel3.Controls.Add(Me.Pctb_Error2)
        Me.Panel3.Controls.Add(Me.lbl_no)
        Me.Panel3.Controls.Add(Me.txt_no)
        Me.Panel3.Controls.Add(Me.txt_apellido)
        Me.Panel3.Controls.Add(Me.lbl_apellido)
        Me.Panel3.Controls.Add(Me.txt_email)
        Me.Panel3.Controls.Add(Me.lbl_email)
        Me.Panel3.Controls.Add(Me.txt_nom)
        Me.Panel3.Controls.Add(Me.lbl_nom)
        Me.Panel3.Controls.Add(Me.txt_usr)
        Me.Panel3.Controls.Add(Me.lbl_usuario)
        Me.Panel3.Controls.Add(Me.Chkb_mostrarContra)
        Me.Panel3.Controls.Add(Me.txt_contr)
        Me.Panel3.Controls.Add(Me.lbl_pass)
        Me.Panel3.Controls.Add(Me.lbl_tipUsr)
        Me.Panel3.Controls.Add(Me.cb_tipUsr)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 175)
        Me.Panel3.TabIndex = 85
        '
        'Pctb_Error7
        '
        Me.Pctb_Error7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_Error7.Image = CType(resources.GetObject("Pctb_Error7.Image"), System.Drawing.Image)
        Me.Pctb_Error7.Location = New System.Drawing.Point(696, 93)
        Me.Pctb_Error7.Name = "Pctb_Error7"
        Me.Pctb_Error7.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error7.TabIndex = 88
        Me.Pctb_Error7.TabStop = False
        Me.Pctb_Error7.Visible = False
        '
        'Pctb_Error6
        '
        Me.Pctb_Error6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_Error6.Image = CType(resources.GetObject("Pctb_Error6.Image"), System.Drawing.Image)
        Me.Pctb_Error6.Location = New System.Drawing.Point(696, 62)
        Me.Pctb_Error6.Name = "Pctb_Error6"
        Me.Pctb_Error6.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error6.TabIndex = 87
        Me.Pctb_Error6.TabStop = False
        Me.Pctb_Error6.Visible = False
        '
        'Pctb_Error5
        '
        Me.Pctb_Error5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_Error5.Image = CType(resources.GetObject("Pctb_Error5.Image"), System.Drawing.Image)
        Me.Pctb_Error5.Location = New System.Drawing.Point(696, 30)
        Me.Pctb_Error5.Name = "Pctb_Error5"
        Me.Pctb_Error5.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error5.TabIndex = 86
        Me.Pctb_Error5.TabStop = False
        Me.Pctb_Error5.Visible = False
        '
        'Pctb_Error4
        '
        Me.Pctb_Error4.Image = CType(resources.GetObject("Pctb_Error4.Image"), System.Drawing.Image)
        Me.Pctb_Error4.Location = New System.Drawing.Point(384, 124)
        Me.Pctb_Error4.Name = "Pctb_Error4"
        Me.Pctb_Error4.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error4.TabIndex = 85
        Me.Pctb_Error4.TabStop = False
        Me.Pctb_Error4.Visible = False
        '
        'Pctb_Error3
        '
        Me.Pctb_Error3.Image = CType(resources.GetObject("Pctb_Error3.Image"), System.Drawing.Image)
        Me.Pctb_Error3.Location = New System.Drawing.Point(384, 93)
        Me.Pctb_Error3.Name = "Pctb_Error3"
        Me.Pctb_Error3.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error3.TabIndex = 84
        Me.Pctb_Error3.TabStop = False
        Me.Pctb_Error3.Visible = False
        '
        'Pctb_Error2
        '
        Me.Pctb_Error2.Image = CType(resources.GetObject("Pctb_Error2.Image"), System.Drawing.Image)
        Me.Pctb_Error2.Location = New System.Drawing.Point(384, 61)
        Me.Pctb_Error2.Name = "Pctb_Error2"
        Me.Pctb_Error2.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error2.TabIndex = 83
        Me.Pctb_Error2.TabStop = False
        Me.Pctb_Error2.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Mostrar)
        Me.Panel4.Controls.Add(Me.Btn_Search)
        Me.Panel4.Controls.Add(Me.Btn_Limpiar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 213)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(283, 141)
        Me.Panel4.TabIndex = 86
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mostrar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mostrar.Image = CType(resources.GetObject("Btn_Mostrar.Image"), System.Drawing.Image)
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mostrar.Location = New System.Drawing.Point(13, 20)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Mostrar.TabIndex = 122
        Me.Btn_Mostrar.Text = "    Mostrar"
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Image = CType(resources.GetObject("Btn_Search.Image"), System.Drawing.Image)
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(13, 71)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Search.TabIndex = 123
        Me.Btn_Search.Text = "Buscar"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = CType(resources.GetObject("Btn_Limpiar.Image"), System.Drawing.Image)
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(139, 71)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Limpiar.TabIndex = 121
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Btn_Delet)
        Me.Panel5.Controls.Add(Me.Btn_Modif)
        Me.Panel5.Controls.Add(Me.Btn_Add)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(440, 213)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 141)
        Me.Panel5.TabIndex = 87
        '
        'Btn_Delet
        '
        Me.Btn_Delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delet.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delet.Image = CType(resources.GetObject("Btn_Delet.Image"), System.Drawing.Image)
        Me.Btn_Delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delet.Location = New System.Drawing.Point(25, 71)
        Me.Btn_Delet.Name = "Btn_Delet"
        Me.Btn_Delet.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Delet.TabIndex = 118
        Me.Btn_Delet.Text = "    Eliminar"
        Me.Btn_Delet.UseVisualStyleBackColor = True
        '
        'Btn_Modif
        '
        Me.Btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modif.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modif.Image = CType(resources.GetObject("Btn_Modif.Image"), System.Drawing.Image)
        Me.Btn_Modif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modif.Location = New System.Drawing.Point(151, 71)
        Me.Btn_Modif.Name = "Btn_Modif"
        Me.Btn_Modif.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Modif.TabIndex = 119
        Me.Btn_Modif.Text = "Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Modif.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(151, 20)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Add.TabIndex = 120
        Me.Btn_Add.Text = "     Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(283, 213)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(157, 141)
        Me.Panel6.TabIndex = 88
        '
        'UsuariosTableAdapter2
        '
        Me.UsuariosTableAdapter2.ClearBeforeFill = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 599)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.Dgv_usr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pctb_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UsuariosBindingSource As BindingSource

    Friend WithEvents txt_no As TextBox
    Friend WithEvents lbl_no As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_nom As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usr As TextBox
    Friend WithEvents lbl_pass As Label
    Friend WithEvents txt_contr As TextBox
    Friend WithEvents lbl_tipUsr As Label
    Friend WithEvents cb_tipUsr As ComboBox
    Friend WithEvents tm_data As Timer
    Friend WithEvents TipusrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdusrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Dgv_usr As DataGridView
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents UsuariosTableAdapter As BodegaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents Chkb_mostrarContra As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BodegaDataSet1 As BodegaDataSet
    Friend WithEvents UsuariosTableAdapter1 As BodegaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Pctb_Error7 As PictureBox
    Friend WithEvents Pctb_Error6 As PictureBox
    Friend WithEvents Pctb_Error5 As PictureBox
    Friend WithEvents Pctb_Error4 As PictureBox
    Friend WithEvents Pctb_Error3 As PictureBox
    Friend WithEvents Pctb_Error2 As PictureBox
    Friend WithEvents Pctb_ayuda As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents Btn_Delet As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents BodegaDataSet2 As BodegaDataSet
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents UsuariosTableAdapter2 As BodegaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
End Class
