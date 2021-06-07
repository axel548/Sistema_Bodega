<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.Pctb_Agenda = New System.Windows.Forms.PictureBox()
        Me.Pctb_settings = New System.Windows.Forms.PictureBox()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Panel_fill = New System.Windows.Forms.Panel()
        Me.Pctb_restaurar = New System.Windows.Forms.PictureBox()
        Me.Pctb_maximizar = New System.Windows.Forms.PictureBox()
        Me.Pctb_minimizar = New System.Windows.Forms.PictureBox()
        Me.Pctb_menu = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_usr = New System.Windows.Forms.Label()
        Me.Lbl_tipUsr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pctb_user = New System.Windows.Forms.PictureBox()
        Me.Lbl_email = New System.Windows.Forms.Label()
        Me.Pnl_Inv = New System.Windows.Forms.Panel()
        Me.Pnl_Pres = New System.Windows.Forms.Panel()
        Me.Pnl_Usu = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Pnl_Pendi = New System.Windows.Forms.Panel()
        Me.Btn_Pendientes = New System.Windows.Forms.Button()
        Me.Btn_Prestamos = New System.Windows.Forms.Button()
        Me.Btn_Usr = New System.Windows.Forms.Button()
        Me.Btn_Inventario = New System.Windows.Forms.Button()
        Me.Btn_CierrSesi = New System.Windows.Forms.Button()
        Me.Bf_animation = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Bf_slider = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pnl_solven = New System.Windows.Forms.Panel()
        Me.Btn_Solvencias = New System.Windows.Forms.Button()
        Me.Pnl_conte_slide = New System.Windows.Forms.Panel()
        Me.Panel_contenedor = New System.Windows.Forms.Panel()
        Me.Bf_animation2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Bf_dragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel_menu.SuspendLayout()
        CType(Me.Pctb_Agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Pctb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bf_slider.SuspendLayout()
        Me.Pnl_conte_slide.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.Black
        Me.Panel_menu.Controls.Add(Me.Pctb_Agenda)
        Me.Panel_menu.Controls.Add(Me.Pctb_settings)
        Me.Panel_menu.Controls.Add(Me.Pctb_salir)
        Me.Panel_menu.Controls.Add(Me.Panel_fill)
        Me.Panel_menu.Controls.Add(Me.Pctb_restaurar)
        Me.Panel_menu.Controls.Add(Me.Pctb_maximizar)
        Me.Panel_menu.Controls.Add(Me.Pctb_minimizar)
        Me.Panel_menu.Controls.Add(Me.Pctb_menu)
        Me.Bf_animation2.SetDecoration(Me.Panel_menu, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Panel_menu, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(900, 51)
        Me.Panel_menu.TabIndex = 0
        '
        'Pctb_Agenda
        '
        Me.Bf_animation.SetDecoration(Me.Pctb_Agenda, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_Agenda, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_Agenda.Image = CType(resources.GetObject("Pctb_Agenda.Image"), System.Drawing.Image)
        Me.Pctb_Agenda.Location = New System.Drawing.Point(115, 12)
        Me.Pctb_Agenda.Name = "Pctb_Agenda"
        Me.Pctb_Agenda.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_Agenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_Agenda.TabIndex = 8
        Me.Pctb_Agenda.TabStop = False
        '
        'Pctb_settings
        '
        Me.Bf_animation.SetDecoration(Me.Pctb_settings, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_settings, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_settings.Image = CType(resources.GetObject("Pctb_settings.Image"), System.Drawing.Image)
        Me.Pctb_settings.Location = New System.Drawing.Point(79, 12)
        Me.Pctb_settings.Name = "Pctb_settings"
        Me.Pctb_settings.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_settings.TabIndex = 7
        Me.Pctb_settings.TabStop = False
        '
        'Pctb_salir
        '
        Me.Pctb_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_animation.SetDecoration(Me.Pctb_salir, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_salir, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_salir.Image = CType(resources.GetObject("Pctb_salir.Image"), System.Drawing.Image)
        Me.Pctb_salir.Location = New System.Drawing.Point(867, 12)
        Me.Pctb_salir.Name = "Pctb_salir"
        Me.Pctb_salir.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_salir.TabIndex = 6
        Me.Pctb_salir.TabStop = False
        '
        'Panel_fill
        '
        Me.Panel_fill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_fill.BackColor = System.Drawing.Color.White
        Me.Bf_animation2.SetDecoration(Me.Panel_fill, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Panel_fill, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_fill.Location = New System.Drawing.Point(6, 51)
        Me.Panel_fill.Name = "Panel_fill"
        Me.Panel_fill.Size = New System.Drawing.Size(900, 599)
        Me.Panel_fill.TabIndex = 1
        '
        'Pctb_restaurar
        '
        Me.Pctb_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_animation.SetDecoration(Me.Pctb_restaurar, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_restaurar, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_restaurar.Image = CType(resources.GetObject("Pctb_restaurar.Image"), System.Drawing.Image)
        Me.Pctb_restaurar.Location = New System.Drawing.Point(831, 12)
        Me.Pctb_restaurar.Name = "Pctb_restaurar"
        Me.Pctb_restaurar.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_restaurar.TabIndex = 5
        Me.Pctb_restaurar.TabStop = False
        Me.Pctb_restaurar.Visible = False
        '
        'Pctb_maximizar
        '
        Me.Pctb_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_animation.SetDecoration(Me.Pctb_maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_maximizar.Image = CType(resources.GetObject("Pctb_maximizar.Image"), System.Drawing.Image)
        Me.Pctb_maximizar.Location = New System.Drawing.Point(831, 12)
        Me.Pctb_maximizar.Name = "Pctb_maximizar"
        Me.Pctb_maximizar.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_maximizar.TabIndex = 4
        Me.Pctb_maximizar.TabStop = False
        '
        'Pctb_minimizar
        '
        Me.Pctb_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bf_animation.SetDecoration(Me.Pctb_minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_minimizar.Image = CType(resources.GetObject("Pctb_minimizar.Image"), System.Drawing.Image)
        Me.Pctb_minimizar.Location = New System.Drawing.Point(795, 12)
        Me.Pctb_minimizar.Name = "Pctb_minimizar"
        Me.Pctb_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_minimizar.TabIndex = 3
        Me.Pctb_minimizar.TabStop = False
        '
        'Pctb_menu
        '
        Me.Bf_animation.SetDecoration(Me.Pctb_menu, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_menu, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_menu.Image = CType(resources.GetObject("Pctb_menu.Image"), System.Drawing.Image)
        Me.Pctb_menu.Location = New System.Drawing.Point(12, 12)
        Me.Pctb_menu.Name = "Pctb_menu"
        Me.Pctb_menu.Size = New System.Drawing.Size(30, 30)
        Me.Pctb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctb_menu.TabIndex = 0
        Me.Pctb_menu.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Lbl_usr)
        Me.Panel6.Controls.Add(Me.Lbl_tipUsr)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Pctb_user)
        Me.Panel6.Controls.Add(Me.Lbl_email)
        Me.Bf_animation2.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(3, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(177, 116)
        Me.Panel6.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tipo de usuario:"
        '
        'Lbl_usr
        '
        Me.Lbl_usr.AutoSize = True
        Me.Lbl_usr.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Lbl_usr, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Lbl_usr, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_usr.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_usr.ForeColor = System.Drawing.Color.White
        Me.Lbl_usr.Location = New System.Drawing.Point(58, 52)
        Me.Lbl_usr.Name = "Lbl_usr"
        Me.Lbl_usr.Size = New System.Drawing.Size(43, 14)
        Me.Lbl_usr.TabIndex = 1
        Me.Lbl_usr.Text = "Label1"
        '
        'Lbl_tipUsr
        '
        Me.Lbl_tipUsr.AutoSize = True
        Me.Lbl_tipUsr.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Lbl_tipUsr, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Lbl_tipUsr, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_tipUsr.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_tipUsr.ForeColor = System.Drawing.Color.White
        Me.Lbl_tipUsr.Location = New System.Drawing.Point(92, 92)
        Me.Lbl_tipUsr.Name = "Lbl_tipUsr"
        Me.Lbl_tipUsr.Size = New System.Drawing.Size(43, 14)
        Me.Lbl_tipUsr.TabIndex = 3
        Me.Lbl_tipUsr.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario:"
        '
        'Pctb_user
        '
        Me.Bf_animation.SetDecoration(Me.Pctb_user, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Pctb_user, BunifuAnimatorNS.DecorationType.None)
        Me.Pctb_user.Image = CType(resources.GetObject("Pctb_user.Image"), System.Drawing.Image)
        Me.Pctb_user.Location = New System.Drawing.Point(58, 3)
        Me.Pctb_user.Name = "Pctb_user"
        Me.Pctb_user.Size = New System.Drawing.Size(48, 49)
        Me.Pctb_user.TabIndex = 0
        Me.Pctb_user.TabStop = False
        '
        'Lbl_email
        '
        Me.Lbl_email.AutoSize = True
        Me.Lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Lbl_email, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Lbl_email, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_email.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_email.ForeColor = System.Drawing.Color.White
        Me.Lbl_email.Location = New System.Drawing.Point(41, 72)
        Me.Lbl_email.Name = "Lbl_email"
        Me.Lbl_email.Size = New System.Drawing.Size(43, 14)
        Me.Lbl_email.TabIndex = 2
        Me.Lbl_email.Text = "Label2"
        '
        'Pnl_Inv
        '
        Me.Pnl_Inv.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Pnl_Inv, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_Inv, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_Inv.Location = New System.Drawing.Point(0, 156)
        Me.Pnl_Inv.Name = "Pnl_Inv"
        Me.Pnl_Inv.Size = New System.Drawing.Size(8, 50)
        Me.Pnl_Inv.TabIndex = 3
        '
        'Pnl_Pres
        '
        Me.Pnl_Pres.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Pnl_Pres, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_Pres, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_Pres.Location = New System.Drawing.Point(0, 274)
        Me.Pnl_Pres.Name = "Pnl_Pres"
        Me.Pnl_Pres.Size = New System.Drawing.Size(8, 50)
        Me.Pnl_Pres.TabIndex = 6
        '
        'Pnl_Usu
        '
        Me.Pnl_Usu.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Pnl_Usu, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_Usu, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_Usu.Location = New System.Drawing.Point(0, 215)
        Me.Pnl_Usu.Name = "Pnl_Usu"
        Me.Pnl_Usu.Size = New System.Drawing.Size(8, 50)
        Me.Pnl_Usu.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(0, 518)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(8, 50)
        Me.Panel5.TabIndex = 6
        '
        'Pnl_Pendi
        '
        Me.Pnl_Pendi.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Pnl_Pendi, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_Pendi, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_Pendi.Location = New System.Drawing.Point(0, 333)
        Me.Pnl_Pendi.Name = "Pnl_Pendi"
        Me.Pnl_Pendi.Size = New System.Drawing.Size(8, 50)
        Me.Pnl_Pendi.TabIndex = 5
        '
        'Btn_Pendientes
        '
        Me.Btn_Pendientes.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_Pendientes, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_Pendientes, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Pendientes.FlatAppearance.BorderSize = 0
        Me.Btn_Pendientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Pendientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Pendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pendientes.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pendientes.ForeColor = System.Drawing.Color.White
        Me.Btn_Pendientes.Image = CType(resources.GetObject("Btn_Pendientes.Image"), System.Drawing.Image)
        Me.Btn_Pendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pendientes.Location = New System.Drawing.Point(3, 333)
        Me.Btn_Pendientes.Name = "Btn_Pendientes"
        Me.Btn_Pendientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Pendientes.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Pendientes.TabIndex = 11
        Me.Btn_Pendientes.Text = "               Pendientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Pendientes.UseVisualStyleBackColor = False
        '
        'Btn_Prestamos
        '
        Me.Btn_Prestamos.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_Prestamos, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_Prestamos, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Prestamos.FlatAppearance.BorderSize = 0
        Me.Btn_Prestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Prestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Prestamos.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Prestamos.ForeColor = System.Drawing.Color.White
        Me.Btn_Prestamos.Image = CType(resources.GetObject("Btn_Prestamos.Image"), System.Drawing.Image)
        Me.Btn_Prestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Prestamos.Location = New System.Drawing.Point(3, 274)
        Me.Btn_Prestamos.Name = "Btn_Prestamos"
        Me.Btn_Prestamos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Prestamos.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Prestamos.TabIndex = 10
        Me.Btn_Prestamos.Text = "               Préstamos"
        Me.Btn_Prestamos.UseVisualStyleBackColor = False
        '
        'Btn_Usr
        '
        Me.Btn_Usr.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_Usr, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_Usr, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Usr.FlatAppearance.BorderSize = 0
        Me.Btn_Usr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Usr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Usr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Usr.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Usr.ForeColor = System.Drawing.Color.White
        Me.Btn_Usr.Image = CType(resources.GetObject("Btn_Usr.Image"), System.Drawing.Image)
        Me.Btn_Usr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Usr.Location = New System.Drawing.Point(3, 215)
        Me.Btn_Usr.Name = "Btn_Usr"
        Me.Btn_Usr.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Usr.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Usr.TabIndex = 9
        Me.Btn_Usr.Text = "          Usuarios"
        Me.Btn_Usr.UseVisualStyleBackColor = False
        '
        'Btn_Inventario
        '
        Me.Btn_Inventario.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_Inventario, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_Inventario, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Inventario.FlatAppearance.BorderSize = 0
        Me.Btn_Inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Inventario.Font = New System.Drawing.Font("Roboto Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inventario.ForeColor = System.Drawing.Color.White
        Me.Btn_Inventario.Image = CType(resources.GetObject("Btn_Inventario.Image"), System.Drawing.Image)
        Me.Btn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventario.Location = New System.Drawing.Point(3, 156)
        Me.Btn_Inventario.Name = "Btn_Inventario"
        Me.Btn_Inventario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Inventario.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Inventario.TabIndex = 8
        Me.Btn_Inventario.Text = "               Inventario "
        Me.Btn_Inventario.UseVisualStyleBackColor = False
        '
        'Btn_CierrSesi
        '
        Me.Btn_CierrSesi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CierrSesi.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_CierrSesi, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_CierrSesi, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_CierrSesi.FlatAppearance.BorderSize = 0
        Me.Btn_CierrSesi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_CierrSesi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_CierrSesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CierrSesi.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CierrSesi.ForeColor = System.Drawing.Color.White
        Me.Btn_CierrSesi.Image = CType(resources.GetObject("Btn_CierrSesi.Image"), System.Drawing.Image)
        Me.Btn_CierrSesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_CierrSesi.Location = New System.Drawing.Point(3, 518)
        Me.Btn_CierrSesi.Name = "Btn_CierrSesi"
        Me.Btn_CierrSesi.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_CierrSesi.Size = New System.Drawing.Size(177, 50)
        Me.Btn_CierrSesi.TabIndex = 12
        Me.Btn_CierrSesi.Text = "                 Cerrar                   Sesión"
        Me.Btn_CierrSesi.UseVisualStyleBackColor = False
        '
        'Bf_animation
        '
        Me.Bf_animation.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.Bf_animation.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.Bf_animation.DefaultAnimation = Animation1
        '
        'Bf_slider
        '
        Me.Bf_slider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bf_slider.BackgroundImage = CType(resources.GetObject("Bf_slider.BackgroundImage"), System.Drawing.Image)
        Me.Bf_slider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bf_slider.Controls.Add(Me.Pnl_solven)
        Me.Bf_slider.Controls.Add(Me.Panel6)
        Me.Bf_slider.Controls.Add(Me.Pnl_Inv)
        Me.Bf_slider.Controls.Add(Me.Pnl_Pres)
        Me.Bf_slider.Controls.Add(Me.Btn_Inventario)
        Me.Bf_slider.Controls.Add(Me.Pnl_Usu)
        Me.Bf_slider.Controls.Add(Me.Btn_Usr)
        Me.Bf_slider.Controls.Add(Me.Panel5)
        Me.Bf_slider.Controls.Add(Me.Btn_Prestamos)
        Me.Bf_slider.Controls.Add(Me.Pnl_Pendi)
        Me.Bf_slider.Controls.Add(Me.Btn_Pendientes)
        Me.Bf_slider.Controls.Add(Me.Btn_CierrSesi)
        Me.Bf_slider.Controls.Add(Me.Btn_Solvencias)
        Me.Bf_animation2.SetDecoration(Me.Bf_slider, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Bf_slider, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_slider.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_slider.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_slider.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_slider.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Bf_slider.Location = New System.Drawing.Point(0, 0)
        Me.Bf_slider.Name = "Bf_slider"
        Me.Bf_slider.Quality = 10
        Me.Bf_slider.Size = New System.Drawing.Size(180, 599)
        Me.Bf_slider.TabIndex = 2
        '
        'Pnl_solven
        '
        Me.Pnl_solven.BackColor = System.Drawing.Color.MidnightBlue
        Me.Bf_animation2.SetDecoration(Me.Pnl_solven, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_solven, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_solven.Location = New System.Drawing.Point(0, 392)
        Me.Pnl_solven.Name = "Pnl_solven"
        Me.Pnl_solven.Size = New System.Drawing.Size(8, 50)
        Me.Pnl_solven.TabIndex = 13
        '
        'Btn_Solvencias
        '
        Me.Btn_Solvencias.BackColor = System.Drawing.Color.Transparent
        Me.Bf_animation.SetDecoration(Me.Btn_Solvencias, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me.Btn_Solvencias, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Solvencias.FlatAppearance.BorderSize = 0
        Me.Btn_Solvencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Solvencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Solvencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Solvencias.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Solvencias.ForeColor = System.Drawing.Color.White
        Me.Btn_Solvencias.Image = CType(resources.GetObject("Btn_Solvencias.Image"), System.Drawing.Image)
        Me.Btn_Solvencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Solvencias.Location = New System.Drawing.Point(3, 392)
        Me.Btn_Solvencias.Name = "Btn_Solvencias"
        Me.Btn_Solvencias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Solvencias.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Solvencias.TabIndex = 14
        Me.Btn_Solvencias.Text = "               Solvencia"
        Me.Btn_Solvencias.UseVisualStyleBackColor = False
        '
        'Pnl_conte_slide
        '
        Me.Pnl_conte_slide.BackColor = System.Drawing.Color.White
        Me.Pnl_conte_slide.Controls.Add(Me.Bf_slider)
        Me.Bf_animation2.SetDecoration(Me.Pnl_conte_slide, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Pnl_conte_slide, BunifuAnimatorNS.DecorationType.None)
        Me.Pnl_conte_slide.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_conte_slide.Location = New System.Drawing.Point(0, 51)
        Me.Pnl_conte_slide.Name = "Pnl_conte_slide"
        Me.Pnl_conte_slide.Size = New System.Drawing.Size(180, 599)
        Me.Pnl_conte_slide.TabIndex = 2
        '
        'Panel_contenedor
        '
        Me.Panel_contenedor.BackColor = System.Drawing.Color.White
        Me.Bf_animation2.SetDecoration(Me.Panel_contenedor, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation.SetDecoration(Me.Panel_contenedor, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_contenedor.Location = New System.Drawing.Point(180, 51)
        Me.Panel_contenedor.Name = "Panel_contenedor"
        Me.Panel_contenedor.Size = New System.Drawing.Size(720, 599)
        Me.Panel_contenedor.TabIndex = 3
        '
        'Bf_animation2
        '
        Me.Bf_animation2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.Bf_animation2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.Bf_animation2.DefaultAnimation = Animation2
        '
        'Bf_dragControl
        '
        Me.Bf_dragControl.Fixed = True
        Me.Bf_dragControl.Horizontal = True
        Me.Bf_dragControl.TargetControl = Me.Panel_menu
        Me.Bf_dragControl.Vertical = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.Panel_contenedor)
        Me.Controls.Add(Me.Pnl_conte_slide)
        Me.Controls.Add(Me.Panel_menu)
        Me.Bf_animation.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_animation2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "principal"
        Me.Panel_menu.ResumeLayout(False)
        CType(Me.Pctb_Agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Pctb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bf_slider.ResumeLayout(False)
        Me.Pnl_conte_slide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_menu As Panel
    Friend WithEvents Panel_fill As Panel
    Friend WithEvents Pctb_maximizar As PictureBox
    Friend WithEvents Pctb_minimizar As PictureBox
    Friend WithEvents Pctb_menu As PictureBox
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Pctb_restaurar As PictureBox
    Friend WithEvents Bf_animation As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Bf_animation2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Lbl_email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_usr As Label
    Friend WithEvents Lbl_tipUsr As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pctb_user As PictureBox
    Friend WithEvents Pnl_Inv As Panel
    Friend WithEvents Pnl_Pres As Panel
    Friend WithEvents Pnl_Usu As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Pnl_Pendi As Panel
    Friend WithEvents Btn_Pendientes As Button
    Friend WithEvents Btn_Prestamos As Button
    Friend WithEvents Btn_Usr As Button
    Friend WithEvents Btn_Inventario As Button
    Friend WithEvents Btn_CierrSesi As Button
    Friend WithEvents Bf_slider As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Pnl_conte_slide As Panel
    Friend WithEvents Panel_contenedor As Panel
    Friend WithEvents Bf_dragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Pctb_settings As PictureBox
    Friend WithEvents Pctb_Agenda As PictureBox
    Friend WithEvents Pnl_solven As Panel
    Friend WithEvents Btn_Solvencias As Button
End Class
