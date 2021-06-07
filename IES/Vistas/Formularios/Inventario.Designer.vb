<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pctb_Ayuda = New System.Windows.Forms.PictureBox()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Tmr_Txt = New System.Windows.Forms.Timer(Me.components)
        Me.Bf_AnimationTLP = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.TC_Inventario = New System.Windows.Forms.TabControl()
        Me.TP_Ingresos = New System.Windows.Forms.TabPage()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Txt_exists = New System.Windows.Forms.TextBox()
        Me.Lbl_Aviso = New System.Windows.Forms.Label()
        Me.Btn_InsertImage = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Pctb_Error8 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Subcategoria = New System.Windows.Forms.Label()
        Me.Cb_Subcate = New System.Windows.Forms.ComboBox()
        Me.Lbl_codigo = New System.Windows.Forms.Label()
        Me.Txt_codigo = New System.Windows.Forms.TextBox()
        Me.Pctb_Error2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_obser = New System.Windows.Forms.Label()
        Me.Pctb_Error7 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error1 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error6 = New System.Windows.Forms.PictureBox()
        Me.Pctb_Error3 = New System.Windows.Forms.PictureBox()
        Me.lbl_image = New System.Windows.Forms.Label()
        Me.Txt_obser = New System.Windows.Forms.TextBox()
        Me.Pctb_Error4 = New System.Windows.Forms.PictureBox()
        Me.Lbl_estado = New System.Windows.Forms.Label()
        Me.Lbl_nomHerr = New System.Windows.Forms.Label()
        Me.Cb_estado = New System.Windows.Forms.ComboBox()
        Me.Txt_preUnit = New System.Windows.Forms.TextBox()
        Me.Lbl_categoria = New System.Windows.Forms.Label()
        Me.Cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Pctb_Error5 = New System.Windows.Forms.PictureBox()
        Me.Pctb_imagen = New System.Windows.Forms.PictureBox()
        Me.Txt_nomHerr = New System.Windows.Forms.TextBox()
        Me.Lbl_preUnit = New System.Windows.Forms.Label()
        Me.Lbl_cantHerr = New System.Windows.Forms.Label()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Lbl_total = New System.Windows.Forms.Label()
        Me.Txt_cantHerr = New System.Windows.Forms.TextBox()
        Me.TP_SearchActives = New System.Windows.Forms.TabPage()
        Me.Rbtn_categoriaActives = New System.Windows.Forms.RadioButton()
        Me.Rbtn_nombreActives = New System.Windows.Forms.RadioButton()
        Me.GB_NombreActives = New System.Windows.Forms.GroupBox()
        Me.Txt_SearchActives = New System.Windows.Forms.TextBox()
        Me.Pctb_lupaActives = New System.Windows.Forms.PictureBox()
        Me.GB_CategoriaActives = New System.Windows.Forms.GroupBox()
        Me.Cb_SubcateActives = New System.Windows.Forms.ComboBox()
        Me.Cb_categActives = New System.Windows.Forms.ComboBox()
        Me.Btn_MostrarActives = New System.Windows.Forms.Button()
        Me.Dgv_invActives = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewInerAcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet1 = New IES.BodegaDataSet()
        Me.TP_SearchReservs = New System.Windows.Forms.TabPage()
        Me.Rbtn_categoriaReservs = New System.Windows.Forms.RadioButton()
        Me.Rbtn_nombreReservs = New System.Windows.Forms.RadioButton()
        Me.GB_NombreReservs = New System.Windows.Forms.GroupBox()
        Me.Txt_SearchReservs = New System.Windows.Forms.TextBox()
        Me.Pctb_lupaReservs = New System.Windows.Forms.PictureBox()
        Me.GB_CategoriaReservs = New System.Windows.Forms.GroupBox()
        Me.Cb_SubcateReservs = New System.Windows.Forms.ComboBox()
        Me.Cb_categReservs = New System.Windows.Forms.ComboBox()
        Me.Btn_MostrarReservs = New System.Windows.Forms.Button()
        Me.Dgv_invReservs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubestDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewInerReBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TP_SearchEstateWrong = New System.Windows.Forms.TabPage()
        Me.Btn_Delet = New System.Windows.Forms.Button()
        Me.Lbl_Regreso = New System.Windows.Forms.Label()
        Me.Btn_generarCodigo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_CodEstateWrong = New System.Windows.Forms.TextBox()
        Me.Rbtn_categoriaEstateWrong = New System.Windows.Forms.RadioButton()
        Me.Rbtn_nombreEstateWrong = New System.Windows.Forms.RadioButton()
        Me.GB_NombreEstateWrong = New System.Windows.Forms.GroupBox()
        Me.Txt_SearchEstateWrong = New System.Windows.Forms.TextBox()
        Me.Pctb_lupaEstateWrong = New System.Windows.Forms.PictureBox()
        Me.GB_CategoriaEstateWrong = New System.Windows.Forms.GroupBox()
        Me.Cb_SubcateEstateWrong = New System.Windows.Forms.ComboBox()
        Me.Cb_categEstateWrong = New System.Windows.Forms.ComboBox()
        Me.Btn_MostrarEstateWrong = New System.Windows.Forms.Button()
        Me.Dgv_invEstateWrong = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubestDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcatDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewInerMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_InerAcTableAdapter = New IES.BodegaDataSetTableAdapters.View_InerAcTableAdapter()
        Me.View_InerReTableAdapter = New IES.BodegaDataSetTableAdapters.View_InerReTableAdapter()
        Me.View_InerMETableAdapter = New IES.BodegaDataSetTableAdapters.View_InerMETableAdapter()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pctb_Ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC_Inventario.SuspendLayout()
        Me.TP_Ingresos.SuspendLayout()
        CType(Me.Pctb_Error8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_Error5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_SearchActives.SuspendLayout()
        Me.GB_NombreActives.SuspendLayout()
        CType(Me.Pctb_lupaActives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_CategoriaActives.SuspendLayout()
        CType(Me.Dgv_invActives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewInerAcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_SearchReservs.SuspendLayout()
        Me.GB_NombreReservs.SuspendLayout()
        CType(Me.Pctb_lupaReservs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_CategoriaReservs.SuspendLayout()
        CType(Me.Dgv_invReservs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewInerReBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_SearchEstateWrong.SuspendLayout()
        Me.GB_NombreEstateWrong.SuspendLayout()
        CType(Me.Pctb_lupaEstateWrong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_CategoriaEstateWrong.SuspendLayout()
        CType(Me.Dgv_invEstateWrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewInerMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Bf_AnimationTLP.SetDecoration(Me.lbl_Titulo, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_Titulo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.Black
        Me.lbl_Titulo.Location = New System.Drawing.Point(275, 2)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(145, 32)
        Me.lbl_Titulo.TabIndex = 31
        Me.lbl_Titulo.Text = "Inventario"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Bf_AnimationTLP.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 38)
        Me.Panel1.TabIndex = 75
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Pctb_Ayuda)
        Me.BunifuGradientPanel1.Controls.Add(Me.Pctb_salir)
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_Titulo)
        Me.Bf_AnimationTLP.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(723, 38)
        Me.BunifuGradientPanel1.TabIndex = 76
        '
        'Panel2
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(103, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 58)
        Me.Panel2.TabIndex = 97
        '
        'Pctb_Ayuda
        '
        Me.Pctb_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_Ayuda.BackColor = System.Drawing.Color.Transparent
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Ayuda, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Ayuda.Image = CType(resources.GetObject("Pctb_Ayuda.Image"), System.Drawing.Image)
        Me.Pctb_Ayuda.Location = New System.Drawing.Point(652, 3)
        Me.Pctb_Ayuda.Name = "Pctb_Ayuda"
        Me.Pctb_Ayuda.Size = New System.Drawing.Size(32, 32)
        Me.Pctb_Ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pctb_Ayuda.TabIndex = 92
        Me.Pctb_Ayuda.TabStop = False
        '
        'Pctb_salir
        '
        Me.Pctb_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pctb_salir.BackColor = System.Drawing.Color.Black
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_salir, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_salir.Image = CType(resources.GetObject("Pctb_salir.Image"), System.Drawing.Image)
        Me.Pctb_salir.Location = New System.Drawing.Point(690, 3)
        Me.Pctb_salir.Name = "Pctb_salir"
        Me.Pctb_salir.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_salir.TabIndex = 46
        Me.Pctb_salir.TabStop = False
        '
        'Bf_AnimationTLP
        '
        Me.Bf_AnimationTLP.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.Bf_AnimationTLP.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.Bf_AnimationTLP.DefaultAnimation = Animation4
        '
        'TC_Inventario
        '
        Me.TC_Inventario.Controls.Add(Me.TP_Ingresos)
        Me.TC_Inventario.Controls.Add(Me.TP_SearchActives)
        Me.TC_Inventario.Controls.Add(Me.TP_SearchReservs)
        Me.TC_Inventario.Controls.Add(Me.TP_SearchEstateWrong)
        Me.Bf_AnimationTLP.SetDecoration(Me.TC_Inventario, BunifuAnimatorNS.DecorationType.None)
        Me.TC_Inventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC_Inventario.Location = New System.Drawing.Point(0, 38)
        Me.TC_Inventario.Name = "TC_Inventario"
        Me.TC_Inventario.SelectedIndex = 0
        Me.TC_Inventario.Size = New System.Drawing.Size(723, 561)
        Me.TC_Inventario.TabIndex = 99
        '
        'TP_Ingresos
        '
        Me.TP_Ingresos.Controls.Add(Me.Btn_Actualizar)
        Me.TP_Ingresos.Controls.Add(Me.Txt_exists)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_Aviso)
        Me.TP_Ingresos.Controls.Add(Me.Btn_InsertImage)
        Me.TP_Ingresos.Controls.Add(Me.Btn_Limpiar)
        Me.TP_Ingresos.Controls.Add(Me.Btn_Cancelar)
        Me.TP_Ingresos.Controls.Add(Me.Btn_Add)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error8)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_Subcategoria)
        Me.TP_Ingresos.Controls.Add(Me.Cb_Subcate)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_codigo)
        Me.TP_Ingresos.Controls.Add(Me.Txt_codigo)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error2)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_obser)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error7)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error1)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error6)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error3)
        Me.TP_Ingresos.Controls.Add(Me.lbl_image)
        Me.TP_Ingresos.Controls.Add(Me.Txt_obser)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error4)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_estado)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_nomHerr)
        Me.TP_Ingresos.Controls.Add(Me.Cb_estado)
        Me.TP_Ingresos.Controls.Add(Me.Txt_preUnit)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_categoria)
        Me.TP_Ingresos.Controls.Add(Me.Cb_categoria)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_Error5)
        Me.TP_Ingresos.Controls.Add(Me.Pctb_imagen)
        Me.TP_Ingresos.Controls.Add(Me.Txt_nomHerr)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_preUnit)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_cantHerr)
        Me.TP_Ingresos.Controls.Add(Me.Txt_total)
        Me.TP_Ingresos.Controls.Add(Me.Lbl_total)
        Me.TP_Ingresos.Controls.Add(Me.Txt_cantHerr)
        Me.Bf_AnimationTLP.SetDecoration(Me.TP_Ingresos, BunifuAnimatorNS.DecorationType.None)
        Me.TP_Ingresos.Location = New System.Drawing.Point(4, 22)
        Me.TP_Ingresos.Name = "TP_Ingresos"
        Me.TP_Ingresos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Ingresos.Size = New System.Drawing.Size(715, 535)
        Me.TP_Ingresos.TabIndex = 0
        Me.TP_Ingresos.Text = "Ingresos"
        Me.TP_Ingresos.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_Actualizar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.Image = CType(resources.GetObject("Btn_Actualizar.Image"), System.Drawing.Image)
        Me.Btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Actualizar.Location = New System.Drawing.Point(12, 482)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Actualizar.TabIndex = 233
        Me.Btn_Actualizar.Text = "     Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        Me.Btn_Actualizar.Visible = False
        '
        'Txt_exists
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_exists, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_exists.Enabled = False
        Me.Txt_exists.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_exists.Location = New System.Drawing.Point(538, 123)
        Me.Txt_exists.Name = "Txt_exists"
        Me.Txt_exists.ShortcutsEnabled = False
        Me.Txt_exists.Size = New System.Drawing.Size(137, 21)
        Me.Txt_exists.TabIndex = 231
        '
        'Lbl_Aviso
        '
        Me.Lbl_Aviso.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_Aviso, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Aviso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Aviso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Aviso.Location = New System.Drawing.Point(9, 466)
        Me.Lbl_Aviso.Name = "Lbl_Aviso"
        Me.Lbl_Aviso.Size = New System.Drawing.Size(282, 13)
        Me.Lbl_Aviso.TabIndex = 119
        Me.Lbl_Aviso.Text = "*El código del producto se consigue a partir del Estado."
        '
        'Btn_InsertImage
        '
        Me.Btn_InsertImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_InsertImage, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_InsertImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_InsertImage.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_InsertImage.Image = CType(resources.GetObject("Btn_InsertImage.Image"), System.Drawing.Image)
        Me.Btn_InsertImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_InsertImage.Location = New System.Drawing.Point(525, 378)
        Me.Btn_InsertImage.Name = "Btn_InsertImage"
        Me.Btn_InsertImage.Size = New System.Drawing.Size(150, 45)
        Me.Btn_InsertImage.TabIndex = 10
        Me.Btn_InsertImage.Text = "Ingresar Imagen"
        Me.Btn_InsertImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_InsertImage.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_Limpiar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = CType(resources.GetObject("Btn_Limpiar.Image"), System.Drawing.Image)
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(583, 482)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Limpiar.TabIndex = 116
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_Cancelar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(138, 482)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Cancelar.TabIndex = 113
        Me.Btn_Cancelar.Text = "    Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        Me.Btn_Cancelar.Visible = False
        '
        'Btn_Add
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_Add, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(12, 482)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(120, 45)
        Me.Btn_Add.TabIndex = 112
        Me.Btn_Add.Text = "Guardar"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Pctb_Error8
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error8, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error8.Image = CType(resources.GetObject("Pctb_Error8.Image"), System.Drawing.Image)
        Me.Pctb_Error8.Location = New System.Drawing.Point(679, 62)
        Me.Pctb_Error8.Name = "Pctb_Error8"
        Me.Pctb_Error8.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error8.TabIndex = 97
        Me.Pctb_Error8.TabStop = False
        Me.Pctb_Error8.Visible = False
        '
        'Lbl_Subcategoria
        '
        Me.Lbl_Subcategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Subcategoria.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_Subcategoria, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Subcategoria.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Subcategoria.Location = New System.Drawing.Point(444, 61)
        Me.Lbl_Subcategoria.Name = "Lbl_Subcategoria"
        Me.Lbl_Subcategoria.Size = New System.Drawing.Size(118, 19)
        Me.Lbl_Subcategoria.TabIndex = 96
        Me.Lbl_Subcategoria.Text = "Sub-categoría:"
        '
        'Cb_Subcate
        '
        Me.Cb_Subcate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Subcate.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_Subcate, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Subcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Subcate.Enabled = False
        Me.Cb_Subcate.FormattingEnabled = True
        Me.Cb_Subcate.Location = New System.Drawing.Point(566, 59)
        Me.Cb_Subcate.Name = "Cb_Subcate"
        Me.Cb_Subcate.Size = New System.Drawing.Size(107, 21)
        Me.Cb_Subcate.TabIndex = 7
        '
        'Lbl_codigo
        '
        Me.Lbl_codigo.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_codigo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_codigo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_codigo.Location = New System.Drawing.Point(8, 34)
        Me.Lbl_codigo.Name = "Lbl_codigo"
        Me.Lbl_codigo.Size = New System.Drawing.Size(68, 19)
        Me.Lbl_codigo.TabIndex = 25
        Me.Lbl_codigo.Text = "Código:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Txt_codigo
        '
        Me.Txt_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_codigo, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_codigo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_codigo.Location = New System.Drawing.Point(96, 27)
        Me.Txt_codigo.MaxLength = 3000
        Me.Txt_codigo.Name = "Txt_codigo"
        Me.Txt_codigo.ShortcutsEnabled = False
        Me.Txt_codigo.Size = New System.Drawing.Size(108, 26)
        Me.Txt_codigo.TabIndex = 0
        '
        'Pctb_Error2
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error2, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error2.Image = CType(resources.GetObject("Pctb_Error2.Image"), System.Drawing.Image)
        Me.Pctb_Error2.Location = New System.Drawing.Point(413, 65)
        Me.Pctb_Error2.Name = "Pctb_Error2"
        Me.Pctb_Error2.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error2.TabIndex = 84
        Me.Pctb_Error2.TabStop = False
        Me.Pctb_Error2.Visible = False
        '
        'Lbl_obser
        '
        Me.Lbl_obser.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_obser, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_obser.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_obser.Location = New System.Drawing.Point(8, 190)
        Me.Lbl_obser.Name = "Lbl_obser"
        Me.Lbl_obser.Size = New System.Drawing.Size(124, 19)
        Me.Lbl_obser.TabIndex = 49
        Me.Lbl_obser.Text = "Observaciones:"
        '
        'Pctb_Error7
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error7, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error7.Image = CType(resources.GetObject("Pctb_Error7.Image"), System.Drawing.Image)
        Me.Pctb_Error7.Location = New System.Drawing.Point(679, 96)
        Me.Pctb_Error7.Name = "Pctb_Error7"
        Me.Pctb_Error7.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error7.TabIndex = 89
        Me.Pctb_Error7.TabStop = False
        Me.Pctb_Error7.Visible = False
        '
        'Pctb_Error1
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error1, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error1.Image = CType(resources.GetObject("Pctb_Error1.Image"), System.Drawing.Image)
        Me.Pctb_Error1.Location = New System.Drawing.Point(210, 27)
        Me.Pctb_Error1.Name = "Pctb_Error1"
        Me.Pctb_Error1.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error1.TabIndex = 94
        Me.Pctb_Error1.TabStop = False
        Me.Pctb_Error1.Visible = False
        '
        'Pctb_Error6
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error6, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error6.Image = CType(resources.GetObject("Pctb_Error6.Image"), System.Drawing.Image)
        Me.Pctb_Error6.Location = New System.Drawing.Point(679, 27)
        Me.Pctb_Error6.Name = "Pctb_Error6"
        Me.Pctb_Error6.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error6.TabIndex = 88
        Me.Pctb_Error6.TabStop = False
        Me.Pctb_Error6.Visible = False
        '
        'Pctb_Error3
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error3, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error3.Image = CType(resources.GetObject("Pctb_Error3.Image"), System.Drawing.Image)
        Me.Pctb_Error3.Location = New System.Drawing.Point(413, 97)
        Me.Pctb_Error3.Name = "Pctb_Error3"
        Me.Pctb_Error3.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error3.TabIndex = 85
        Me.Pctb_Error3.TabStop = False
        Me.Pctb_Error3.Visible = False
        '
        'lbl_image
        '
        Me.lbl_image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.lbl_image, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_image.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_image.Location = New System.Drawing.Point(455, 160)
        Me.lbl_image.Name = "lbl_image"
        Me.lbl_image.Size = New System.Drawing.Size(250, 16)
        Me.lbl_image.TabIndex = 51
        '
        'Txt_obser
        '
        Me.Txt_obser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_obser, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_obser.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_obser.Location = New System.Drawing.Point(138, 190)
        Me.Txt_obser.Multiline = True
        Me.Txt_obser.Name = "Txt_obser"
        Me.Txt_obser.Size = New System.Drawing.Size(269, 100)
        Me.Txt_obser.TabIndex = 5
        '
        'Pctb_Error4
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error4, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error4.Image = CType(resources.GetObject("Pctb_Error4.Image"), System.Drawing.Image)
        Me.Pctb_Error4.Location = New System.Drawing.Point(413, 129)
        Me.Pctb_Error4.Name = "Pctb_Error4"
        Me.Pctb_Error4.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error4.TabIndex = 86
        Me.Pctb_Error4.TabStop = False
        Me.Pctb_Error4.Visible = False
        '
        'Lbl_estado
        '
        Me.Lbl_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_estado.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_estado, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_estado.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_estado.Location = New System.Drawing.Point(444, 95)
        Me.Lbl_estado.Name = "Lbl_estado"
        Me.Lbl_estado.Size = New System.Drawing.Size(64, 19)
        Me.Lbl_estado.TabIndex = 41
        Me.Lbl_estado.Text = "Estado:"
        '
        'Lbl_nomHerr
        '
        Me.Lbl_nomHerr.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_nomHerr, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_nomHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomHerr.Location = New System.Drawing.Point(8, 65)
        Me.Lbl_nomHerr.Name = "Lbl_nomHerr"
        Me.Lbl_nomHerr.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_nomHerr.TabIndex = 28
        Me.Lbl_nomHerr.Text = "Nombre:"
        '
        'Cb_estado
        '
        Me.Cb_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_estado.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_estado, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_estado.FormattingEnabled = True
        Me.Cb_estado.Items.AddRange(New Object() {"Activo", "Reserva", "Mal Estado", "[Ninguno]"})
        Me.Cb_estado.Location = New System.Drawing.Point(538, 96)
        Me.Cb_estado.Name = "Cb_estado"
        Me.Cb_estado.Size = New System.Drawing.Size(138, 21)
        Me.Cb_estado.TabIndex = 8
        '
        'Txt_preUnit
        '
        Me.Txt_preUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_preUnit, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_preUnit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_preUnit.Location = New System.Drawing.Point(96, 126)
        Me.Txt_preUnit.Name = "Txt_preUnit"
        Me.Txt_preUnit.ShortcutsEnabled = False
        Me.Txt_preUnit.Size = New System.Drawing.Size(311, 26)
        Me.Txt_preUnit.TabIndex = 3
        '
        'Lbl_categoria
        '
        Me.Lbl_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_categoria.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_categoria, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_categoria.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_categoria.Location = New System.Drawing.Point(444, 29)
        Me.Lbl_categoria.Name = "Lbl_categoria"
        Me.Lbl_categoria.Size = New System.Drawing.Size(88, 19)
        Me.Lbl_categoria.TabIndex = 39
        Me.Lbl_categoria.Text = "Categoría:"
        '
        'Cb_categoria
        '
        Me.Cb_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categoria.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_categoria, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categoria.Enabled = False
        Me.Cb_categoria.FormattingEnabled = True
        Me.Cb_categoria.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica", "Varios", "[Ninguno]"})
        Me.Cb_categoria.Location = New System.Drawing.Point(538, 27)
        Me.Cb_categoria.Name = "Cb_categoria"
        Me.Cb_categoria.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categoria.TabIndex = 6
        '
        'Pctb_Error5
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_Error5, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Error5.Image = CType(resources.GetObject("Pctb_Error5.Image"), System.Drawing.Image)
        Me.Pctb_Error5.Location = New System.Drawing.Point(413, 161)
        Me.Pctb_Error5.Name = "Pctb_Error5"
        Me.Pctb_Error5.Size = New System.Drawing.Size(22, 21)
        Me.Pctb_Error5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Error5.TabIndex = 87
        Me.Pctb_Error5.TabStop = False
        Me.Pctb_Error5.Visible = False
        '
        'Pctb_imagen
        '
        Me.Pctb_imagen.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Pctb_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_imagen, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_imagen.Image = Global.IES.My.Resources.Resources.original
        Me.Pctb_imagen.Location = New System.Drawing.Point(496, 179)
        Me.Pctb_imagen.Name = "Pctb_imagen"
        Me.Pctb_imagen.Size = New System.Drawing.Size(192, 193)
        Me.Pctb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_imagen.TabIndex = 27
        Me.Pctb_imagen.TabStop = False
        '
        'Txt_nomHerr
        '
        Me.Txt_nomHerr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_nomHerr, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_nomHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nomHerr.Location = New System.Drawing.Point(96, 62)
        Me.Txt_nomHerr.Name = "Txt_nomHerr"
        Me.Txt_nomHerr.ShortcutsEnabled = False
        Me.Txt_nomHerr.Size = New System.Drawing.Size(311, 26)
        Me.Txt_nomHerr.TabIndex = 1
        '
        'Lbl_preUnit
        '
        Me.Lbl_preUnit.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_preUnit, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_preUnit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_preUnit.Location = New System.Drawing.Point(8, 129)
        Me.Lbl_preUnit.Name = "Lbl_preUnit"
        Me.Lbl_preUnit.Size = New System.Drawing.Size(88, 19)
        Me.Lbl_preUnit.TabIndex = 36
        Me.Lbl_preUnit.Text = "Precio c/u:"
        '
        'Lbl_cantHerr
        '
        Me.Lbl_cantHerr.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_cantHerr, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_cantHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cantHerr.Location = New System.Drawing.Point(8, 97)
        Me.Lbl_cantHerr.Name = "Lbl_cantHerr"
        Me.Lbl_cantHerr.Size = New System.Drawing.Size(82, 19)
        Me.Lbl_cantHerr.TabIndex = 32
        Me.Lbl_cantHerr.Text = "Cantidad:"
        '
        'Txt_total
        '
        Me.Txt_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_total, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_total.Enabled = False
        Me.Txt_total.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_total.Location = New System.Drawing.Point(96, 158)
        Me.Txt_total.Name = "Txt_total"
        Me.Txt_total.ShortcutsEnabled = False
        Me.Txt_total.Size = New System.Drawing.Size(311, 26)
        Me.Txt_total.TabIndex = 4
        '
        'Lbl_total
        '
        Me.Lbl_total.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_total, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_total.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_total.Location = New System.Drawing.Point(8, 161)
        Me.Lbl_total.Name = "Lbl_total"
        Me.Lbl_total.Size = New System.Drawing.Size(50, 19)
        Me.Lbl_total.TabIndex = 34
        Me.Lbl_total.Text = "Total:"
        '
        'Txt_cantHerr
        '
        Me.Txt_cantHerr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_cantHerr, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_cantHerr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cantHerr.Location = New System.Drawing.Point(96, 94)
        Me.Txt_cantHerr.MaxLength = 15
        Me.Txt_cantHerr.Name = "Txt_cantHerr"
        Me.Txt_cantHerr.ShortcutsEnabled = False
        Me.Txt_cantHerr.Size = New System.Drawing.Size(311, 26)
        Me.Txt_cantHerr.TabIndex = 2
        '
        'TP_SearchActives
        '
        Me.TP_SearchActives.Controls.Add(Me.Rbtn_categoriaActives)
        Me.TP_SearchActives.Controls.Add(Me.Rbtn_nombreActives)
        Me.TP_SearchActives.Controls.Add(Me.GB_NombreActives)
        Me.TP_SearchActives.Controls.Add(Me.GB_CategoriaActives)
        Me.TP_SearchActives.Controls.Add(Me.Btn_MostrarActives)
        Me.TP_SearchActives.Controls.Add(Me.Dgv_invActives)
        Me.Bf_AnimationTLP.SetDecoration(Me.TP_SearchActives, BunifuAnimatorNS.DecorationType.None)
        Me.TP_SearchActives.Location = New System.Drawing.Point(4, 22)
        Me.TP_SearchActives.Name = "TP_SearchActives"
        Me.TP_SearchActives.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_SearchActives.Size = New System.Drawing.Size(715, 535)
        Me.TP_SearchActives.TabIndex = 1
        Me.TP_SearchActives.Text = "Búsquedas-Activos"
        Me.TP_SearchActives.UseVisualStyleBackColor = True
        '
        'Rbtn_categoriaActives
        '
        Me.Rbtn_categoriaActives.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_categoriaActives, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_categoriaActives.Location = New System.Drawing.Point(277, 96)
        Me.Rbtn_categoriaActives.Name = "Rbtn_categoriaActives"
        Me.Rbtn_categoriaActives.Size = New System.Drawing.Size(77, 17)
        Me.Rbtn_categoriaActives.TabIndex = 162
        Me.Rbtn_categoriaActives.TabStop = True
        Me.Rbtn_categoriaActives.Text = "Categorías"
        Me.Rbtn_categoriaActives.UseVisualStyleBackColor = True
        '
        'Rbtn_nombreActives
        '
        Me.Rbtn_nombreActives.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_nombreActives, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_nombreActives.Location = New System.Drawing.Point(277, 30)
        Me.Rbtn_nombreActives.Name = "Rbtn_nombreActives"
        Me.Rbtn_nombreActives.Size = New System.Drawing.Size(62, 17)
        Me.Rbtn_nombreActives.TabIndex = 161
        Me.Rbtn_nombreActives.TabStop = True
        Me.Rbtn_nombreActives.Text = "Nombre"
        Me.Rbtn_nombreActives.UseVisualStyleBackColor = True
        '
        'GB_NombreActives
        '
        Me.GB_NombreActives.Controls.Add(Me.Txt_SearchActives)
        Me.GB_NombreActives.Controls.Add(Me.Pctb_lupaActives)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_NombreActives, BunifuAnimatorNS.DecorationType.None)
        Me.GB_NombreActives.Enabled = False
        Me.GB_NombreActives.Location = New System.Drawing.Point(358, 6)
        Me.GB_NombreActives.Name = "GB_NombreActives"
        Me.GB_NombreActives.Size = New System.Drawing.Size(349, 65)
        Me.GB_NombreActives.TabIndex = 160
        Me.GB_NombreActives.TabStop = False
        Me.GB_NombreActives.Text = "Búsqueda por nombre"
        '
        'Txt_SearchActives
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_SearchActives, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_SearchActives.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SearchActives.Location = New System.Drawing.Point(50, 24)
        Me.Txt_SearchActives.MaxLength = 75
        Me.Txt_SearchActives.Name = "Txt_SearchActives"
        Me.Txt_SearchActives.ShortcutsEnabled = False
        Me.Txt_SearchActives.Size = New System.Drawing.Size(293, 22)
        Me.Txt_SearchActives.TabIndex = 165
        '
        'Pctb_lupaActives
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_lupaActives, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_lupaActives.Image = CType(resources.GetObject("Pctb_lupaActives.Image"), System.Drawing.Image)
        Me.Pctb_lupaActives.Location = New System.Drawing.Point(25, 21)
        Me.Pctb_lupaActives.Name = "Pctb_lupaActives"
        Me.Pctb_lupaActives.Size = New System.Drawing.Size(25, 25)
        Me.Pctb_lupaActives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_lupaActives.TabIndex = 166
        Me.Pctb_lupaActives.TabStop = False
        '
        'GB_CategoriaActives
        '
        Me.GB_CategoriaActives.Controls.Add(Me.Cb_SubcateActives)
        Me.GB_CategoriaActives.Controls.Add(Me.Cb_categActives)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_CategoriaActives, BunifuAnimatorNS.DecorationType.None)
        Me.GB_CategoriaActives.Enabled = False
        Me.GB_CategoriaActives.Location = New System.Drawing.Point(358, 77)
        Me.GB_CategoriaActives.Name = "GB_CategoriaActives"
        Me.GB_CategoriaActives.Size = New System.Drawing.Size(349, 70)
        Me.GB_CategoriaActives.TabIndex = 159
        Me.GB_CategoriaActives.TabStop = False
        Me.GB_CategoriaActives.Text = "Búsqueda por categorías"
        '
        'Cb_SubcateActives
        '
        Me.Cb_SubcateActives.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_SubcateActives.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_SubcateActives, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_SubcateActives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_SubcateActives.FormattingEnabled = True
        Me.Cb_SubcateActives.Location = New System.Drawing.Point(171, 19)
        Me.Cb_SubcateActives.Name = "Cb_SubcateActives"
        Me.Cb_SubcateActives.Size = New System.Drawing.Size(107, 21)
        Me.Cb_SubcateActives.TabIndex = 4
        '
        'Cb_categActives
        '
        Me.Cb_categActives.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categActives.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_categActives, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_categActives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categActives.FormattingEnabled = True
        Me.Cb_categActives.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica"})
        Me.Cb_categActives.Location = New System.Drawing.Point(25, 19)
        Me.Cb_categActives.Name = "Cb_categActives"
        Me.Cb_categActives.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categActives.TabIndex = 3
        '
        'Btn_MostrarActives
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_MostrarActives, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_MostrarActives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MostrarActives.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MostrarActives.Image = CType(resources.GetObject("Btn_MostrarActives.Image"), System.Drawing.Image)
        Me.Btn_MostrarActives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_MostrarActives.Location = New System.Drawing.Point(8, 110)
        Me.Btn_MostrarActives.Name = "Btn_MostrarActives"
        Me.Btn_MostrarActives.Size = New System.Drawing.Size(97, 37)
        Me.Btn_MostrarActives.TabIndex = 111
        Me.Btn_MostrarActives.Text = "Mostrar"
        Me.Btn_MostrarActives.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_MostrarActives.UseVisualStyleBackColor = True
        '
        'Dgv_invActives
        '
        Me.Dgv_invActives.AllowUserToAddRows = False
        Me.Dgv_invActives.AllowUserToDeleteRows = False
        Me.Dgv_invActives.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_invActives.AutoGenerateColumns = False
        Me.Dgv_invActives.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_invActives.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_invActives.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invActives.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.Dgv_invActives.ColumnHeadersHeight = 30
        Me.Dgv_invActives.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.SubestDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.SubcatDataGridViewTextBoxColumn})
        Me.Dgv_invActives.DataSource = Me.ViewInerAcBindingSource
        Me.Bf_AnimationTLP.SetDecoration(Me.Dgv_invActives, BunifuAnimatorNS.DecorationType.None)
        Me.Dgv_invActives.EnableHeadersVisualStyles = False
        Me.Dgv_invActives.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_invActives.Location = New System.Drawing.Point(8, 153)
        Me.Dgv_invActives.Name = "Dgv_invActives"
        Me.Dgv_invActives.ReadOnly = True
        Me.Dgv_invActives.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invActives.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_invActives.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.Dgv_invActives.Size = New System.Drawing.Size(699, 367)
        Me.Dgv_invActives.TabIndex = 78
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "Foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cant"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "prec_unit"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio c/u"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'SubestDataGridViewTextBoxColumn
        '
        Me.SubestDataGridViewTextBoxColumn.DataPropertyName = "sub_est"
        Me.SubestDataGridViewTextBoxColumn.HeaderText = "Sub-Estado"
        Me.SubestDataGridViewTextBoxColumn.Name = "SubestDataGridViewTextBoxColumn"
        Me.SubestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "obser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "categoría"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'SubcatDataGridViewTextBoxColumn
        '
        Me.SubcatDataGridViewTextBoxColumn.DataPropertyName = "sub_cat"
        Me.SubcatDataGridViewTextBoxColumn.HeaderText = "Sub-Categoria"
        Me.SubcatDataGridViewTextBoxColumn.Name = "SubcatDataGridViewTextBoxColumn"
        Me.SubcatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewInerAcBindingSource
        '
        Me.ViewInerAcBindingSource.DataMember = "View_InerAc"
        Me.ViewInerAcBindingSource.DataSource = Me.BodegaDataSet1
        '
        'BodegaDataSet1
        '
        Me.BodegaDataSet1.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TP_SearchReservs
        '
        Me.TP_SearchReservs.Controls.Add(Me.Rbtn_categoriaReservs)
        Me.TP_SearchReservs.Controls.Add(Me.Rbtn_nombreReservs)
        Me.TP_SearchReservs.Controls.Add(Me.GB_NombreReservs)
        Me.TP_SearchReservs.Controls.Add(Me.GB_CategoriaReservs)
        Me.TP_SearchReservs.Controls.Add(Me.Btn_MostrarReservs)
        Me.TP_SearchReservs.Controls.Add(Me.Dgv_invReservs)
        Me.Bf_AnimationTLP.SetDecoration(Me.TP_SearchReservs, BunifuAnimatorNS.DecorationType.None)
        Me.TP_SearchReservs.Location = New System.Drawing.Point(4, 22)
        Me.TP_SearchReservs.Name = "TP_SearchReservs"
        Me.TP_SearchReservs.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_SearchReservs.Size = New System.Drawing.Size(715, 535)
        Me.TP_SearchReservs.TabIndex = 2
        Me.TP_SearchReservs.Text = "Búsquedas-Reservas "
        Me.TP_SearchReservs.UseVisualStyleBackColor = True
        '
        'Rbtn_categoriaReservs
        '
        Me.Rbtn_categoriaReservs.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_categoriaReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_categoriaReservs.Location = New System.Drawing.Point(277, 96)
        Me.Rbtn_categoriaReservs.Name = "Rbtn_categoriaReservs"
        Me.Rbtn_categoriaReservs.Size = New System.Drawing.Size(77, 17)
        Me.Rbtn_categoriaReservs.TabIndex = 162
        Me.Rbtn_categoriaReservs.TabStop = True
        Me.Rbtn_categoriaReservs.Text = "Categorías"
        Me.Rbtn_categoriaReservs.UseVisualStyleBackColor = True
        '
        'Rbtn_nombreReservs
        '
        Me.Rbtn_nombreReservs.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_nombreReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_nombreReservs.Location = New System.Drawing.Point(277, 30)
        Me.Rbtn_nombreReservs.Name = "Rbtn_nombreReservs"
        Me.Rbtn_nombreReservs.Size = New System.Drawing.Size(62, 17)
        Me.Rbtn_nombreReservs.TabIndex = 161
        Me.Rbtn_nombreReservs.TabStop = True
        Me.Rbtn_nombreReservs.Text = "Nombre"
        Me.Rbtn_nombreReservs.UseVisualStyleBackColor = True
        '
        'GB_NombreReservs
        '
        Me.GB_NombreReservs.Controls.Add(Me.Txt_SearchReservs)
        Me.GB_NombreReservs.Controls.Add(Me.Pctb_lupaReservs)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_NombreReservs, BunifuAnimatorNS.DecorationType.None)
        Me.GB_NombreReservs.Enabled = False
        Me.GB_NombreReservs.Location = New System.Drawing.Point(358, 6)
        Me.GB_NombreReservs.Name = "GB_NombreReservs"
        Me.GB_NombreReservs.Size = New System.Drawing.Size(349, 65)
        Me.GB_NombreReservs.TabIndex = 160
        Me.GB_NombreReservs.TabStop = False
        Me.GB_NombreReservs.Text = "Búsqueda por nombre"
        '
        'Txt_SearchReservs
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_SearchReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_SearchReservs.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SearchReservs.Location = New System.Drawing.Point(50, 24)
        Me.Txt_SearchReservs.MaxLength = 75
        Me.Txt_SearchReservs.Name = "Txt_SearchReservs"
        Me.Txt_SearchReservs.ShortcutsEnabled = False
        Me.Txt_SearchReservs.Size = New System.Drawing.Size(293, 22)
        Me.Txt_SearchReservs.TabIndex = 163
        '
        'Pctb_lupaReservs
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_lupaReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_lupaReservs.Image = CType(resources.GetObject("Pctb_lupaReservs.Image"), System.Drawing.Image)
        Me.Pctb_lupaReservs.Location = New System.Drawing.Point(25, 21)
        Me.Pctb_lupaReservs.Name = "Pctb_lupaReservs"
        Me.Pctb_lupaReservs.Size = New System.Drawing.Size(25, 25)
        Me.Pctb_lupaReservs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_lupaReservs.TabIndex = 164
        Me.Pctb_lupaReservs.TabStop = False
        '
        'GB_CategoriaReservs
        '
        Me.GB_CategoriaReservs.Controls.Add(Me.Cb_SubcateReservs)
        Me.GB_CategoriaReservs.Controls.Add(Me.Cb_categReservs)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_CategoriaReservs, BunifuAnimatorNS.DecorationType.None)
        Me.GB_CategoriaReservs.Enabled = False
        Me.GB_CategoriaReservs.Location = New System.Drawing.Point(358, 77)
        Me.GB_CategoriaReservs.Name = "GB_CategoriaReservs"
        Me.GB_CategoriaReservs.Size = New System.Drawing.Size(349, 70)
        Me.GB_CategoriaReservs.TabIndex = 159
        Me.GB_CategoriaReservs.TabStop = False
        Me.GB_CategoriaReservs.Text = "Búsqueda por categorías"
        '
        'Cb_SubcateReservs
        '
        Me.Cb_SubcateReservs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_SubcateReservs.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_SubcateReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_SubcateReservs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_SubcateReservs.FormattingEnabled = True
        Me.Cb_SubcateReservs.Location = New System.Drawing.Point(171, 19)
        Me.Cb_SubcateReservs.Name = "Cb_SubcateReservs"
        Me.Cb_SubcateReservs.Size = New System.Drawing.Size(107, 21)
        Me.Cb_SubcateReservs.TabIndex = 4
        '
        'Cb_categReservs
        '
        Me.Cb_categReservs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categReservs.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_categReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_categReservs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categReservs.FormattingEnabled = True
        Me.Cb_categReservs.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica"})
        Me.Cb_categReservs.Location = New System.Drawing.Point(25, 19)
        Me.Cb_categReservs.Name = "Cb_categReservs"
        Me.Cb_categReservs.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categReservs.TabIndex = 3
        '
        'Btn_MostrarReservs
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_MostrarReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_MostrarReservs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MostrarReservs.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MostrarReservs.Image = CType(resources.GetObject("Btn_MostrarReservs.Image"), System.Drawing.Image)
        Me.Btn_MostrarReservs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_MostrarReservs.Location = New System.Drawing.Point(8, 110)
        Me.Btn_MostrarReservs.Name = "Btn_MostrarReservs"
        Me.Btn_MostrarReservs.Size = New System.Drawing.Size(97, 37)
        Me.Btn_MostrarReservs.TabIndex = 124
        Me.Btn_MostrarReservs.Text = "Mostrar"
        Me.Btn_MostrarReservs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_MostrarReservs.UseVisualStyleBackColor = True
        '
        'Dgv_invReservs
        '
        Me.Dgv_invReservs.AllowUserToAddRows = False
        Me.Dgv_invReservs.AllowUserToDeleteRows = False
        Me.Dgv_invReservs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_invReservs.AutoGenerateColumns = False
        Me.Dgv_invReservs.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_invReservs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_invReservs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invReservs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.Dgv_invReservs.ColumnHeadersHeight = 30
        Me.Dgv_invReservs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn11, Me.SubestDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.SubcatDataGridViewTextBoxColumn1})
        Me.Dgv_invReservs.DataSource = Me.ViewInerReBindingSource
        Me.Bf_AnimationTLP.SetDecoration(Me.Dgv_invReservs, BunifuAnimatorNS.DecorationType.None)
        Me.Dgv_invReservs.EnableHeadersVisualStyles = False
        Me.Dgv_invReservs.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_invReservs.Location = New System.Drawing.Point(8, 153)
        Me.Dgv_invReservs.Name = "Dgv_invReservs"
        Me.Dgv_invReservs.ReadOnly = True
        Me.Dgv_invReservs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invReservs.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_invReservs.RowsDefaultCellStyle = DataGridViewCellStyle33
        Me.Dgv_invReservs.Size = New System.Drawing.Size(699, 367)
        Me.Dgv_invReservs.TabIndex = 113
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn2.HeaderText = "Foto"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cant"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "prec_unit"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Precio c/u"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'SubestDataGridViewTextBoxColumn1
        '
        Me.SubestDataGridViewTextBoxColumn1.DataPropertyName = "sub_est"
        Me.SubestDataGridViewTextBoxColumn1.HeaderText = "Sub-Estado"
        Me.SubestDataGridViewTextBoxColumn1.Name = "SubestDataGridViewTextBoxColumn1"
        Me.SubestDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "obser"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "categoría"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'SubcatDataGridViewTextBoxColumn1
        '
        Me.SubcatDataGridViewTextBoxColumn1.DataPropertyName = "sub_cat"
        Me.SubcatDataGridViewTextBoxColumn1.HeaderText = "Sub-Categoría"
        Me.SubcatDataGridViewTextBoxColumn1.Name = "SubcatDataGridViewTextBoxColumn1"
        Me.SubcatDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ViewInerReBindingSource
        '
        Me.ViewInerReBindingSource.DataMember = "View_InerRe"
        Me.ViewInerReBindingSource.DataSource = Me.BodegaDataSet1
        '
        'TP_SearchEstateWrong
        '
        Me.TP_SearchEstateWrong.Controls.Add(Me.Btn_Delet)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Lbl_Regreso)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Btn_generarCodigo)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Label1)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Txt_CodEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Rbtn_categoriaEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Rbtn_nombreEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.GB_NombreEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.GB_CategoriaEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Btn_MostrarEstateWrong)
        Me.TP_SearchEstateWrong.Controls.Add(Me.Dgv_invEstateWrong)
        Me.Bf_AnimationTLP.SetDecoration(Me.TP_SearchEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.TP_SearchEstateWrong.Location = New System.Drawing.Point(4, 22)
        Me.TP_SearchEstateWrong.Name = "TP_SearchEstateWrong"
        Me.TP_SearchEstateWrong.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_SearchEstateWrong.Size = New System.Drawing.Size(715, 535)
        Me.TP_SearchEstateWrong.TabIndex = 3
        Me.TP_SearchEstateWrong.Text = "Búsquedas-Mal Estado"
        Me.TP_SearchEstateWrong.UseVisualStyleBackColor = True
        '
        'Btn_Delet
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_Delet, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delet.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delet.Image = CType(resources.GetObject("Btn_Delet.Image"), System.Drawing.Image)
        Me.Btn_Delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delet.Location = New System.Drawing.Point(8, 67)
        Me.Btn_Delet.Name = "Btn_Delet"
        Me.Btn_Delet.Size = New System.Drawing.Size(197, 37)
        Me.Btn_Delet.TabIndex = 126
        Me.Btn_Delet.Text = "        Volver Activo o Reserva"
        Me.Btn_Delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delet.UseVisualStyleBackColor = True
        '
        'Lbl_Regreso
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Lbl_Regreso, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Regreso.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Regreso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Regreso.Location = New System.Drawing.Point(8, 40)
        Me.Lbl_Regreso.Name = "Lbl_Regreso"
        Me.Lbl_Regreso.Size = New System.Drawing.Size(197, 33)
        Me.Lbl_Regreso.TabIndex = 197
        Me.Lbl_Regreso.Text = "Regrese a la Pestaña ""Ingresos"" de la ventana de Inventario."
        Me.Lbl_Regreso.Visible = False
        '
        'Btn_generarCodigo
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_generarCodigo, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_generarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_generarCodigo.Image = CType(resources.GetObject("Btn_generarCodigo.Image"), System.Drawing.Image)
        Me.Btn_generarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_generarCodigo.Location = New System.Drawing.Point(111, 110)
        Me.Btn_generarCodigo.Name = "Btn_generarCodigo"
        Me.Btn_generarCodigo.Size = New System.Drawing.Size(94, 37)
        Me.Btn_generarCodigo.TabIndex = 196
        Me.Btn_generarCodigo.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.Btn_generarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_generarCodigo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Código:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Txt_CodEstateWrong
        '
        Me.Txt_CodEstateWrong.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_CodEstateWrong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_CodEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_CodEstateWrong.Enabled = False
        Me.Txt_CodEstateWrong.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CodEstateWrong.Location = New System.Drawing.Point(88, 11)
        Me.Txt_CodEstateWrong.MaxLength = 3000
        Me.Txt_CodEstateWrong.Name = "Txt_CodEstateWrong"
        Me.Txt_CodEstateWrong.ShortcutsEnabled = False
        Me.Txt_CodEstateWrong.Size = New System.Drawing.Size(108, 26)
        Me.Txt_CodEstateWrong.TabIndex = 159
        '
        'Rbtn_categoriaEstateWrong
        '
        Me.Rbtn_categoriaEstateWrong.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_categoriaEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_categoriaEstateWrong.Location = New System.Drawing.Point(277, 98)
        Me.Rbtn_categoriaEstateWrong.Name = "Rbtn_categoriaEstateWrong"
        Me.Rbtn_categoriaEstateWrong.Size = New System.Drawing.Size(77, 17)
        Me.Rbtn_categoriaEstateWrong.TabIndex = 158
        Me.Rbtn_categoriaEstateWrong.TabStop = True
        Me.Rbtn_categoriaEstateWrong.Text = "Categorías"
        Me.Rbtn_categoriaEstateWrong.UseVisualStyleBackColor = True
        '
        'Rbtn_nombreEstateWrong
        '
        Me.Rbtn_nombreEstateWrong.AutoSize = True
        Me.Bf_AnimationTLP.SetDecoration(Me.Rbtn_nombreEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Rbtn_nombreEstateWrong.Location = New System.Drawing.Point(277, 32)
        Me.Rbtn_nombreEstateWrong.Name = "Rbtn_nombreEstateWrong"
        Me.Rbtn_nombreEstateWrong.Size = New System.Drawing.Size(62, 17)
        Me.Rbtn_nombreEstateWrong.TabIndex = 157
        Me.Rbtn_nombreEstateWrong.TabStop = True
        Me.Rbtn_nombreEstateWrong.Text = "Nombre"
        Me.Rbtn_nombreEstateWrong.UseVisualStyleBackColor = True
        '
        'GB_NombreEstateWrong
        '
        Me.GB_NombreEstateWrong.Controls.Add(Me.Txt_SearchEstateWrong)
        Me.GB_NombreEstateWrong.Controls.Add(Me.Pctb_lupaEstateWrong)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_NombreEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.GB_NombreEstateWrong.Enabled = False
        Me.GB_NombreEstateWrong.Location = New System.Drawing.Point(358, 8)
        Me.GB_NombreEstateWrong.Name = "GB_NombreEstateWrong"
        Me.GB_NombreEstateWrong.Size = New System.Drawing.Size(349, 65)
        Me.GB_NombreEstateWrong.TabIndex = 128
        Me.GB_NombreEstateWrong.TabStop = False
        Me.GB_NombreEstateWrong.Text = "Búsqueda por nombre"
        '
        'Txt_SearchEstateWrong
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Txt_SearchEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Txt_SearchEstateWrong.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SearchEstateWrong.Location = New System.Drawing.Point(50, 24)
        Me.Txt_SearchEstateWrong.MaxLength = 75
        Me.Txt_SearchEstateWrong.Name = "Txt_SearchEstateWrong"
        Me.Txt_SearchEstateWrong.ShortcutsEnabled = False
        Me.Txt_SearchEstateWrong.Size = New System.Drawing.Size(293, 22)
        Me.Txt_SearchEstateWrong.TabIndex = 165
        '
        'Pctb_lupaEstateWrong
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Pctb_lupaEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_lupaEstateWrong.Image = CType(resources.GetObject("Pctb_lupaEstateWrong.Image"), System.Drawing.Image)
        Me.Pctb_lupaEstateWrong.Location = New System.Drawing.Point(25, 21)
        Me.Pctb_lupaEstateWrong.Name = "Pctb_lupaEstateWrong"
        Me.Pctb_lupaEstateWrong.Size = New System.Drawing.Size(25, 25)
        Me.Pctb_lupaEstateWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_lupaEstateWrong.TabIndex = 166
        Me.Pctb_lupaEstateWrong.TabStop = False
        '
        'GB_CategoriaEstateWrong
        '
        Me.GB_CategoriaEstateWrong.Controls.Add(Me.Cb_SubcateEstateWrong)
        Me.GB_CategoriaEstateWrong.Controls.Add(Me.Cb_categEstateWrong)
        Me.Bf_AnimationTLP.SetDecoration(Me.GB_CategoriaEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.GB_CategoriaEstateWrong.Enabled = False
        Me.GB_CategoriaEstateWrong.Location = New System.Drawing.Point(358, 79)
        Me.GB_CategoriaEstateWrong.Name = "GB_CategoriaEstateWrong"
        Me.GB_CategoriaEstateWrong.Size = New System.Drawing.Size(349, 70)
        Me.GB_CategoriaEstateWrong.TabIndex = 127
        Me.GB_CategoriaEstateWrong.TabStop = False
        Me.GB_CategoriaEstateWrong.Text = "Búsqueda por categorías"
        '
        'Cb_SubcateEstateWrong
        '
        Me.Cb_SubcateEstateWrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_SubcateEstateWrong.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_SubcateEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_SubcateEstateWrong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_SubcateEstateWrong.FormattingEnabled = True
        Me.Cb_SubcateEstateWrong.Location = New System.Drawing.Point(171, 19)
        Me.Cb_SubcateEstateWrong.Name = "Cb_SubcateEstateWrong"
        Me.Cb_SubcateEstateWrong.Size = New System.Drawing.Size(107, 21)
        Me.Cb_SubcateEstateWrong.TabIndex = 4
        '
        'Cb_categEstateWrong
        '
        Me.Cb_categEstateWrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categEstateWrong.BackColor = System.Drawing.Color.White
        Me.Bf_AnimationTLP.SetDecoration(Me.Cb_categEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_categEstateWrong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categEstateWrong.FormattingEnabled = True
        Me.Cb_categEstateWrong.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica"})
        Me.Cb_categEstateWrong.Location = New System.Drawing.Point(25, 19)
        Me.Cb_categEstateWrong.Name = "Cb_categEstateWrong"
        Me.Cb_categEstateWrong.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categEstateWrong.TabIndex = 3
        '
        'Btn_MostrarEstateWrong
        '
        Me.Bf_AnimationTLP.SetDecoration(Me.Btn_MostrarEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_MostrarEstateWrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MostrarEstateWrong.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MostrarEstateWrong.Image = CType(resources.GetObject("Btn_MostrarEstateWrong.Image"), System.Drawing.Image)
        Me.Btn_MostrarEstateWrong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_MostrarEstateWrong.Location = New System.Drawing.Point(8, 110)
        Me.Btn_MostrarEstateWrong.Name = "Btn_MostrarEstateWrong"
        Me.Btn_MostrarEstateWrong.Size = New System.Drawing.Size(97, 37)
        Me.Btn_MostrarEstateWrong.TabIndex = 124
        Me.Btn_MostrarEstateWrong.Text = "Mostrar"
        Me.Btn_MostrarEstateWrong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_MostrarEstateWrong.UseVisualStyleBackColor = True
        '
        'Dgv_invEstateWrong
        '
        Me.Dgv_invEstateWrong.AllowUserToAddRows = False
        Me.Dgv_invEstateWrong.AllowUserToDeleteRows = False
        Me.Dgv_invEstateWrong.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_invEstateWrong.AutoGenerateColumns = False
        Me.Dgv_invEstateWrong.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_invEstateWrong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_invEstateWrong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invEstateWrong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.Dgv_invEstateWrong.ColumnHeadersHeight = 30
        Me.Dgv_invEstateWrong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewImageColumn3, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn19, Me.SubestDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.SubcatDataGridViewTextBoxColumn2})
        Me.Dgv_invEstateWrong.DataSource = Me.ViewInerMEBindingSource
        Me.Bf_AnimationTLP.SetDecoration(Me.Dgv_invEstateWrong, BunifuAnimatorNS.DecorationType.None)
        Me.Dgv_invEstateWrong.EnableHeadersVisualStyles = False
        Me.Dgv_invEstateWrong.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_invEstateWrong.Location = New System.Drawing.Point(8, 155)
        Me.Dgv_invEstateWrong.Name = "Dgv_invEstateWrong"
        Me.Dgv_invEstateWrong.ReadOnly = True
        Me.Dgv_invEstateWrong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_invEstateWrong.RowHeadersDefaultCellStyle = DataGridViewCellStyle35
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_invEstateWrong.RowsDefaultCellStyle = DataGridViewCellStyle36
        Me.Dgv_invEstateWrong.Size = New System.Drawing.Size(699, 365)
        Me.Dgv_invEstateWrong.TabIndex = 113
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn3.HeaderText = "Foto"
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "cant"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "prec_unit"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Precio c/u"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'SubestDataGridViewTextBoxColumn2
        '
        Me.SubestDataGridViewTextBoxColumn2.DataPropertyName = "sub_est"
        Me.SubestDataGridViewTextBoxColumn2.HeaderText = "Sub-Estado"
        Me.SubestDataGridViewTextBoxColumn2.Name = "SubestDataGridViewTextBoxColumn2"
        Me.SubestDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "obser"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "categoría"
        Me.DataGridViewTextBoxColumn21.HeaderText = "categoría"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'SubcatDataGridViewTextBoxColumn2
        '
        Me.SubcatDataGridViewTextBoxColumn2.DataPropertyName = "sub_cat"
        Me.SubcatDataGridViewTextBoxColumn2.HeaderText = "Sub-Categoría"
        Me.SubcatDataGridViewTextBoxColumn2.Name = "SubcatDataGridViewTextBoxColumn2"
        Me.SubcatDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ViewInerMEBindingSource
        '
        Me.ViewInerMEBindingSource.DataMember = "View_InerME"
        Me.ViewInerMEBindingSource.DataSource = Me.BodegaDataSet1
        '
        'View_InerAcTableAdapter
        '
        Me.View_InerAcTableAdapter.ClearBeforeFill = True
        '
        'View_InerReTableAdapter
        '
        Me.View_InerReTableAdapter.ClearBeforeFill = True
        '
        'View_InerMETableAdapter
        '
        Me.View_InerMETableAdapter.ClearBeforeFill = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 599)
        Me.Controls.Add(Me.TC_Inventario)
        Me.Controls.Add(Me.Panel1)
        Me.Bf_AnimationTLP.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pctb_Ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC_Inventario.ResumeLayout(False)
        Me.TP_Ingresos.ResumeLayout(False)
        Me.TP_Ingresos.PerformLayout()
        CType(Me.Pctb_Error8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_Error5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_SearchActives.ResumeLayout(False)
        Me.TP_SearchActives.PerformLayout()
        Me.GB_NombreActives.ResumeLayout(False)
        Me.GB_NombreActives.PerformLayout()
        CType(Me.Pctb_lupaActives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_CategoriaActives.ResumeLayout(False)
        CType(Me.Dgv_invActives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewInerAcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_SearchReservs.ResumeLayout(False)
        Me.TP_SearchReservs.PerformLayout()
        Me.GB_NombreReservs.ResumeLayout(False)
        Me.GB_NombreReservs.PerformLayout()
        CType(Me.Pctb_lupaReservs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_CategoriaReservs.ResumeLayout(False)
        CType(Me.Dgv_invReservs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewInerReBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_SearchEstateWrong.ResumeLayout(False)
        Me.TP_SearchEstateWrong.PerformLayout()
        Me.GB_NombreEstateWrong.ResumeLayout(False)
        Me.GB_NombreEstateWrong.PerformLayout()
        CType(Me.Pctb_lupaEstateWrong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_CategoriaEstateWrong.ResumeLayout(False)
        CType(Me.Dgv_invEstateWrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewInerMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel

    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents CantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoríaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdinveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pctb_Ayuda As PictureBox
    Friend WithEvents Tmr_Txt As Timer
    Friend WithEvents Bf_AnimationTLP As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TC_Inventario As TabControl
    Friend WithEvents TP_Ingresos As TabPage
    Friend WithEvents Lbl_codigo As Label
    Friend WithEvents Txt_codigo As TextBox
    Friend WithEvents Pctb_Error2 As PictureBox
    Friend WithEvents Lbl_obser As Label
    Friend WithEvents Pctb_Error7 As PictureBox
    Friend WithEvents Pctb_Error1 As PictureBox
    Friend WithEvents Pctb_Error6 As PictureBox
    Friend WithEvents Pctb_Error3 As PictureBox
    Friend WithEvents lbl_image As Label
    Friend WithEvents Txt_obser As TextBox
    Friend WithEvents Pctb_Error4 As PictureBox
    Friend WithEvents Lbl_estado As Label
    Friend WithEvents Lbl_nomHerr As Label
    Friend WithEvents Cb_estado As ComboBox
    Friend WithEvents Txt_preUnit As TextBox
    Friend WithEvents Lbl_categoria As Label
    Friend WithEvents Cb_categoria As ComboBox
    Friend WithEvents Pctb_Error5 As PictureBox
    Friend WithEvents Pctb_imagen As PictureBox
    Friend WithEvents Txt_nomHerr As TextBox
    Friend WithEvents Lbl_preUnit As Label
    Friend WithEvents Lbl_cantHerr As Label
    Friend WithEvents Txt_total As TextBox
    Friend WithEvents Lbl_total As Label
    Friend WithEvents Txt_cantHerr As TextBox
    Friend WithEvents TP_SearchActives As TabPage
    Friend WithEvents Dgv_invActives As DataGridView
    Friend WithEvents Pctb_Error8 As PictureBox
    Friend WithEvents Lbl_Subcategoria As Label
    Friend WithEvents Cb_Subcate As ComboBox
    Friend WithEvents Btn_InsertImage As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_MostrarActives As Button
    Friend WithEvents Lbl_Aviso As Label
    Friend WithEvents TP_SearchReservs As TabPage
    Friend WithEvents Btn_MostrarReservs As Button
    Friend WithEvents Dgv_invReservs As DataGridView
    Friend WithEvents TP_SearchEstateWrong As TabPage
    Friend WithEvents Btn_MostrarEstateWrong As Button
    Friend WithEvents Dgv_invEstateWrong As DataGridView
    Friend WithEvents Btn_Delet As Button
    Friend WithEvents Txt_exists As TextBox
    Friend WithEvents GB_NombreEstateWrong As GroupBox
    Friend WithEvents GB_CategoriaEstateWrong As GroupBox
    Friend WithEvents Rbtn_categoriaEstateWrong As RadioButton
    Friend WithEvents Rbtn_nombreEstateWrong As RadioButton
    Friend WithEvents Rbtn_categoriaActives As RadioButton
    Friend WithEvents Rbtn_nombreActives As RadioButton
    Friend WithEvents GB_NombreActives As GroupBox
    Friend WithEvents GB_CategoriaActives As GroupBox
    Friend WithEvents Rbtn_categoriaReservs As RadioButton
    Friend WithEvents Rbtn_nombreReservs As RadioButton
    Friend WithEvents GB_NombreReservs As GroupBox
    Friend WithEvents GB_CategoriaReservs As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_CodEstateWrong As TextBox
    Friend WithEvents Txt_SearchActives As TextBox
    Friend WithEvents Pctb_lupaActives As PictureBox
    Friend WithEvents Txt_SearchReservs As TextBox
    Friend WithEvents Pctb_lupaReservs As PictureBox
    Friend WithEvents Txt_SearchEstateWrong As TextBox
    Friend WithEvents Pctb_lupaEstateWrong As PictureBox
    Friend WithEvents Cb_SubcateActives As ComboBox
    Friend WithEvents Cb_categActives As ComboBox
    Friend WithEvents Cb_SubcateReservs As ComboBox
    Friend WithEvents Cb_categReservs As ComboBox
    Friend WithEvents Cb_SubcateEstateWrong As ComboBox
    Friend WithEvents Cb_categEstateWrong As ComboBox
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_generarCodigo As Button
    Friend WithEvents BodegaDataSet1 As BodegaDataSet
    Friend WithEvents ViewInerAcBindingSource As BindingSource
    Friend WithEvents View_InerAcTableAdapter As BodegaDataSetTableAdapters.View_InerAcTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SubestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SubcatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewInerReBindingSource As BindingSource
    Friend WithEvents View_InerReTableAdapter As BodegaDataSetTableAdapters.View_InerReTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents SubestDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents SubcatDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ViewInerMEBindingSource As BindingSource
    Friend WithEvents View_InerMETableAdapter As BodegaDataSetTableAdapters.View_InerMETableAdapter
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents SubestDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents SubcatDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_Regreso As Label
End Class
