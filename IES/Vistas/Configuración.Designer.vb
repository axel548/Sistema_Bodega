<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configuración
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuración))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Btn_Correo = New System.Windows.Forms.Button()
        Me.Tab_Config = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbl_contr = New System.Windows.Forms.Label()
        Me.lbl_usr = New System.Windows.Forms.Label()
        Me.Txt_Contra = New System.Windows.Forms.TextBox()
        Me.Btn_recuperar = New System.Windows.Forms.Button()
        Me.Lbl_UPDATEcorreo = New System.Windows.Forms.Label()
        Me.Txt_correo = New System.Windows.Forms.TextBox()
        Me.Lbl_ct = New System.Windows.Forms.Label()
        Me.Lbl_ce = New System.Windows.Forms.Label()
        Me.Lbl_co = New System.Windows.Forms.Label()
        Me.Lbl_Cor = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.Btn_Correos = New System.Windows.Forms.Button()
        Me.Btn_Inventario = New System.Windows.Forms.Button()
        Me.Btn_Usr = New System.Windows.Forms.Button()
        Me.Btn_Prestamos = New System.Windows.Forms.Button()
        Me.Btn_Ayuda = New System.Windows.Forms.Button()
        Me.HistorialPrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaDataSet = New IES.BodegaDataSet()
        Me.Historial_PrestamosTableAdapter = New IES.BodegaDataSetTableAdapters.Historial_PrestamosTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Config.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.HistorialPrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 38)
        Me.Panel1.TabIndex = 84
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'lbl_Titulo
        '
        Me.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Titulo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Titulo.Location = New System.Drawing.Point(241, 3)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(200, 32)
        Me.lbl_Titulo.TabIndex = 47
        Me.lbl_Titulo.Text = "Configuración"
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
        'Btn_Correo
        '
        Me.Btn_Correo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Correo.FlatAppearance.BorderSize = 0
        Me.Btn_Correo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Correo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Correo.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Correo.ForeColor = System.Drawing.Color.Black
        Me.Btn_Correo.Image = CType(resources.GetObject("Btn_Correo.Image"), System.Drawing.Image)
        Me.Btn_Correo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Correo.Location = New System.Drawing.Point(6, 6)
        Me.Btn_Correo.Name = "Btn_Correo"
        Me.Btn_Correo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Correo.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Correo.TabIndex = 86
        Me.Btn_Correo.Text = "             Correo "
        Me.Btn_Correo.UseVisualStyleBackColor = False
        '
        'Tab_Config
        '
        Me.Tab_Config.Controls.Add(Me.TabPage1)
        Me.Tab_Config.Controls.Add(Me.TabPage3)
        Me.Tab_Config.Controls.Add(Me.TabPage5)
        Me.Tab_Config.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Config.Location = New System.Drawing.Point(0, 38)
        Me.Tab_Config.Name = "Tab_Config"
        Me.Tab_Config.SelectedIndex = 0
        Me.Tab_Config.Size = New System.Drawing.Size(723, 561)
        Me.Tab_Config.TabIndex = 88
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(519, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Este programa está orientado para el inventario de las areas respectivas," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y la m" &
    "anipulación de datos, como los prestamos, etc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Creado por: Axel López"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Programa de Inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Versión 7.5"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbl_contr)
        Me.TabPage3.Controls.Add(Me.lbl_usr)
        Me.TabPage3.Controls.Add(Me.Txt_Contra)
        Me.TabPage3.Controls.Add(Me.Btn_recuperar)
        Me.TabPage3.Controls.Add(Me.Lbl_UPDATEcorreo)
        Me.TabPage3.Controls.Add(Me.Txt_correo)
        Me.TabPage3.Controls.Add(Me.Lbl_ct)
        Me.TabPage3.Controls.Add(Me.Lbl_ce)
        Me.TabPage3.Controls.Add(Me.Lbl_co)
        Me.TabPage3.Controls.Add(Me.Lbl_Cor)
        Me.TabPage3.Controls.Add(Me.Btn_Correo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(715, 535)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Correo Eléctronico"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbl_contr
        '
        Me.lbl_contr.AutoSize = True
        Me.lbl_contr.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contr.Location = New System.Drawing.Point(215, 272)
        Me.lbl_contr.Name = "lbl_contr"
        Me.lbl_contr.Size = New System.Drawing.Size(94, 19)
        Me.lbl_contr.TabIndex = 108
        Me.lbl_contr.Text = "Contraseña:"
        '
        'lbl_usr
        '
        Me.lbl_usr.AutoSize = True
        Me.lbl_usr.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr.Location = New System.Drawing.Point(215, 223)
        Me.lbl_usr.Name = "lbl_usr"
        Me.lbl_usr.Size = New System.Drawing.Size(141, 19)
        Me.lbl_usr.TabIndex = 107
        Me.lbl_usr.Text = "Correo Electrónico:"
        '
        'Txt_Contra
        '
        Me.Txt_Contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contra.Location = New System.Drawing.Point(219, 294)
        Me.Txt_Contra.Name = "Txt_Contra"
        Me.Txt_Contra.ShortcutsEnabled = False
        Me.Txt_Contra.Size = New System.Drawing.Size(237, 21)
        Me.Txt_Contra.TabIndex = 106
        Me.Txt_Contra.UseSystemPasswordChar = True
        '
        'Btn_recuperar
        '
        Me.Btn_recuperar.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_recuperar.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recuperar.ForeColor = System.Drawing.Color.White
        Me.Btn_recuperar.Image = CType(resources.GetObject("Btn_recuperar.Image"), System.Drawing.Image)
        Me.Btn_recuperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_recuperar.Location = New System.Drawing.Point(586, 6)
        Me.Btn_recuperar.Name = "Btn_recuperar"
        Me.Btn_recuperar.Size = New System.Drawing.Size(121, 40)
        Me.Btn_recuperar.TabIndex = 104
        Me.Btn_recuperar.Text = "           Actualizar"
        Me.Btn_recuperar.UseVisualStyleBackColor = False
        '
        'Lbl_UPDATEcorreo
        '
        Me.Lbl_UPDATEcorreo.AutoSize = True
        Me.Lbl_UPDATEcorreo.Font = New System.Drawing.Font("Roboto", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UPDATEcorreo.Location = New System.Drawing.Point(218, 189)
        Me.Lbl_UPDATEcorreo.Name = "Lbl_UPDATEcorreo"
        Me.Lbl_UPDATEcorreo.Size = New System.Drawing.Size(195, 20)
        Me.Lbl_UPDATEcorreo.TabIndex = 102
        Me.Lbl_UPDATEcorreo.Text = "Ingrese el Nuevo Correo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Txt_correo
        '
        Me.Txt_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_correo.Location = New System.Drawing.Point(219, 249)
        Me.Txt_correo.Name = "Txt_correo"
        Me.Txt_correo.ShortcutsEnabled = False
        Me.Txt_correo.Size = New System.Drawing.Size(237, 21)
        Me.Txt_correo.TabIndex = 103
        '
        'Lbl_ct
        '
        Me.Lbl_ct.AutoSize = True
        Me.Lbl_ct.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ct.Location = New System.Drawing.Point(108, 99)
        Me.Lbl_ct.Name = "Lbl_ct"
        Me.Lbl_ct.Size = New System.Drawing.Size(57, 19)
        Me.Lbl_ct.TabIndex = 101
        Me.Lbl_ct.Text = "Label5"
        '
        'Lbl_ce
        '
        Me.Lbl_ce.AutoSize = True
        Me.Lbl_ce.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ce.Location = New System.Drawing.Point(159, 79)
        Me.Lbl_ce.Name = "Lbl_ce"
        Me.Lbl_ce.Size = New System.Drawing.Size(57, 19)
        Me.Lbl_ce.TabIndex = 100
        Me.Lbl_ce.Text = "Label4"
        '
        'Lbl_co
        '
        Me.Lbl_co.AutoSize = True
        Me.Lbl_co.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_co.Location = New System.Drawing.Point(8, 99)
        Me.Lbl_co.Name = "Lbl_co"
        Me.Lbl_co.Size = New System.Drawing.Size(94, 19)
        Me.Lbl_co.TabIndex = 99
        Me.Lbl_co.Text = "Contraseña:"
        '
        'Lbl_Cor
        '
        Me.Lbl_Cor.AutoSize = True
        Me.Lbl_Cor.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cor.Location = New System.Drawing.Point(8, 79)
        Me.Lbl_Cor.Name = "Lbl_Cor"
        Me.Lbl_Cor.Size = New System.Drawing.Size(145, 19)
        Me.Lbl_Cor.TabIndex = 98
        Me.Lbl_Cor.Text = "Correo Electrónico: "
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel_Contenedor)
        Me.TabPage5.Controls.Add(Me.Btn_Correos)
        Me.TabPage5.Controls.Add(Me.Btn_Inventario)
        Me.TabPage5.Controls.Add(Me.Btn_Usr)
        Me.TabPage5.Controls.Add(Me.Btn_Prestamos)
        Me.TabPage5.Controls.Add(Me.Btn_Ayuda)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(715, 535)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Ayuda"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Contenedor.Location = New System.Drawing.Point(3, 227)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(709, 305)
        Me.Panel_Contenedor.TabIndex = 92
        '
        'Btn_Correos
        '
        Me.Btn_Correos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Correos.FlatAppearance.BorderSize = 0
        Me.Btn_Correos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Correos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Correos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Correos.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Correos.ForeColor = System.Drawing.Color.Black
        Me.Btn_Correos.Image = CType(resources.GetObject("Btn_Correos.Image"), System.Drawing.Image)
        Me.Btn_Correos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Correos.Location = New System.Drawing.Point(542, 171)
        Me.Btn_Correos.Name = "Btn_Correos"
        Me.Btn_Correos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Correos.Size = New System.Drawing.Size(171, 50)
        Me.Btn_Correos.TabIndex = 91
        Me.Btn_Correos.Text = "             Correo"
        Me.Btn_Correos.UseVisualStyleBackColor = False
        '
        'Btn_Inventario
        '
        Me.Btn_Inventario.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Inventario.FlatAppearance.BorderSize = 0
        Me.Btn_Inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Inventario.Font = New System.Drawing.Font("Roboto Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inventario.ForeColor = System.Drawing.Color.Black
        Me.Btn_Inventario.Image = CType(resources.GetObject("Btn_Inventario.Image"), System.Drawing.Image)
        Me.Btn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventario.Location = New System.Drawing.Point(11, 171)
        Me.Btn_Inventario.Name = "Btn_Inventario"
        Me.Btn_Inventario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Inventario.Size = New System.Drawing.Size(171, 50)
        Me.Btn_Inventario.TabIndex = 88
        Me.Btn_Inventario.Text = "               Inventario "
        Me.Btn_Inventario.UseVisualStyleBackColor = False
        '
        'Btn_Usr
        '
        Me.Btn_Usr.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Usr.FlatAppearance.BorderSize = 0
        Me.Btn_Usr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Usr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Usr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Usr.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Usr.ForeColor = System.Drawing.Color.Black
        Me.Btn_Usr.Image = CType(resources.GetObject("Btn_Usr.Image"), System.Drawing.Image)
        Me.Btn_Usr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Usr.Location = New System.Drawing.Point(188, 171)
        Me.Btn_Usr.Name = "Btn_Usr"
        Me.Btn_Usr.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Usr.Size = New System.Drawing.Size(171, 50)
        Me.Btn_Usr.TabIndex = 89
        Me.Btn_Usr.Text = "          Usuarios"
        Me.Btn_Usr.UseVisualStyleBackColor = False
        '
        'Btn_Prestamos
        '
        Me.Btn_Prestamos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Prestamos.FlatAppearance.BorderSize = 0
        Me.Btn_Prestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Prestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Prestamos.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Prestamos.ForeColor = System.Drawing.Color.Black
        Me.Btn_Prestamos.Image = CType(resources.GetObject("Btn_Prestamos.Image"), System.Drawing.Image)
        Me.Btn_Prestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Prestamos.Location = New System.Drawing.Point(365, 171)
        Me.Btn_Prestamos.Name = "Btn_Prestamos"
        Me.Btn_Prestamos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Prestamos.Size = New System.Drawing.Size(171, 50)
        Me.Btn_Prestamos.TabIndex = 90
        Me.Btn_Prestamos.Text = "               Préstamos"
        Me.Btn_Prestamos.UseVisualStyleBackColor = False
        '
        'Btn_Ayuda
        '
        Me.Btn_Ayuda.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Ayuda.FlatAppearance.BorderSize = 0
        Me.Btn_Ayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ayuda.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ayuda.ForeColor = System.Drawing.Color.Black
        Me.Btn_Ayuda.Image = CType(resources.GetObject("Btn_Ayuda.Image"), System.Drawing.Image)
        Me.Btn_Ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ayuda.Location = New System.Drawing.Point(8, 6)
        Me.Btn_Ayuda.Name = "Btn_Ayuda"
        Me.Btn_Ayuda.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Ayuda.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Ayuda.TabIndex = 87
        Me.Btn_Ayuda.Text = "             Ayuda"
        Me.Btn_Ayuda.UseVisualStyleBackColor = False
        '
        'HistorialPrestamosBindingSource
        '
        Me.HistorialPrestamosBindingSource.DataMember = "Historial_Prestamos"
        Me.HistorialPrestamosBindingSource.DataSource = Me.BodegaDataSet
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "BodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Historial_PrestamosTableAdapter
        '
        Me.Historial_PrestamosTableAdapter.ClearBeforeFill = True
        '
        'Configuración
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 599)
        Me.Controls.Add(Me.Tab_Config)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuración"
        Me.Text = "Configuración"
        Me.Panel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Config.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.HistorialPrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Btn_Correo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tab_Config As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents BodegaDataSet As BodegaDataSet
    Friend WithEvents HistorialPrestamosBindingSource As BindingSource
    Friend WithEvents Historial_PrestamosTableAdapter As BodegaDataSetTableAdapters.Historial_PrestamosTableAdapter
    Friend WithEvents Btn_Ayuda As Button
    Friend WithEvents Lbl_ct As Label
    Friend WithEvents Lbl_ce As Label
    Friend WithEvents Lbl_co As Label
    Friend WithEvents Lbl_Cor As Label
    Friend WithEvents lbl_contr As Label
    Friend WithEvents lbl_usr As Label
    Friend WithEvents Txt_Contra As TextBox
    Friend WithEvents Btn_recuperar As Button
    Friend WithEvents Lbl_UPDATEcorreo As Label
    Friend WithEvents Txt_correo As TextBox
    Friend WithEvents Btn_Correos As Button
    Friend WithEvents Btn_Inventario As Button
    Friend WithEvents Btn_Usr As Button
    Friend WithEvents Btn_Prestamos As Button
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
