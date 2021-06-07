<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pctb_minimizar = New System.Windows.Forms.PictureBox()
        Me.pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Lbl_inicio = New System.Windows.Forms.Label()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chkb_mostrarContra = New System.Windows.Forms.CheckBox()
        Me.Btn_ingresar = New System.Windows.Forms.Button()
        Me.pctb_logo = New System.Windows.Forms.PictureBox()
        Me.lnklbl_olvContra = New System.Windows.Forms.LinkLabel()
        Me.txt_contr = New System.Windows.Forms.TextBox()
        Me.txt_usr = New System.Windows.Forms.TextBox()
        Me.lbl_contr = New System.Windows.Forms.Label()
        Me.lbl_usr = New System.Windows.Forms.Label()
        CType(Me.pctb_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pctb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctb_minimizar
        '
        Me.pctb_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.pctb_minimizar.Image = CType(resources.GetObject("pctb_minimizar.Image"), System.Drawing.Image)
        Me.pctb_minimizar.Location = New System.Drawing.Point(279, 3)
        Me.pctb_minimizar.Name = "pctb_minimizar"
        Me.pctb_minimizar.Size = New System.Drawing.Size(25, 25)
        Me.pctb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_minimizar.TabIndex = 8
        Me.pctb_minimizar.TabStop = False
        '
        'pctb_salir
        '
        Me.pctb_salir.BackColor = System.Drawing.Color.Transparent
        Me.pctb_salir.Image = CType(resources.GetObject("pctb_salir.Image"), System.Drawing.Image)
        Me.pctb_salir.Location = New System.Drawing.Point(310, 3)
        Me.pctb_salir.Name = "pctb_salir"
        Me.pctb_salir.Size = New System.Drawing.Size(25, 25)
        Me.pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_salir.TabIndex = 6
        Me.pctb_salir.TabStop = False
        '
        'Lbl_inicio
        '
        Me.Lbl_inicio.AutoSize = True
        Me.Lbl_inicio.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_inicio.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_inicio.ForeColor = System.Drawing.Color.White
        Me.Lbl_inicio.Location = New System.Drawing.Point(53, 9)
        Me.Lbl_inicio.Name = "Lbl_inicio"
        Me.Lbl_inicio.Size = New System.Drawing.Size(218, 32)
        Me.Lbl_inicio.TabIndex = 0
        Me.Lbl_inicio.Text = "Inicio de Sesión"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.Black
        Me.Pnl_menu.BackgroundImage = CType(resources.GetObject("Pnl_menu.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnl_menu.Controls.Add(Me.Lbl_inicio)
        Me.Pnl_menu.Controls.Add(Me.pctb_minimizar)
        Me.Pnl_menu.Controls.Add(Me.pctb_salir)
        Me.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(338, 52)
        Me.Pnl_menu.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Pnl_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 52)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Chkb_mostrarContra)
        Me.Panel2.Controls.Add(Me.Btn_ingresar)
        Me.Panel2.Controls.Add(Me.pctb_logo)
        Me.Panel2.Controls.Add(Me.lnklbl_olvContra)
        Me.Panel2.Controls.Add(Me.txt_contr)
        Me.Panel2.Controls.Add(Me.txt_usr)
        Me.Panel2.Controls.Add(Me.lbl_contr)
        Me.Panel2.Controls.Add(Me.lbl_usr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 408)
        Me.Panel2.TabIndex = 3
        '
        'Chkb_mostrarContra
        '
        Me.Chkb_mostrarContra.AutoSize = True
        Me.Chkb_mostrarContra.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkb_mostrarContra.Location = New System.Drawing.Point(102, 342)
        Me.Chkb_mostrarContra.Name = "Chkb_mostrarContra"
        Me.Chkb_mostrarContra.Size = New System.Drawing.Size(134, 18)
        Me.Chkb_mostrarContra.TabIndex = 3
        Me.Chkb_mostrarContra.Text = "Mostrar Contraseña"
        Me.Chkb_mostrarContra.UseVisualStyleBackColor = True
        '
        'Btn_ingresar
        '
        Me.Btn_ingresar.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ingresar.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ingresar.ForeColor = System.Drawing.Color.White
        Me.Btn_ingresar.Image = CType(resources.GetObject("Btn_ingresar.Image"), System.Drawing.Image)
        Me.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ingresar.Location = New System.Drawing.Point(107, 285)
        Me.Btn_ingresar.Name = "Btn_ingresar"
        Me.Btn_ingresar.Size = New System.Drawing.Size(121, 40)
        Me.Btn_ingresar.TabIndex = 2
        Me.Btn_ingresar.Text = "           Ingresar"
        Me.Btn_ingresar.UseVisualStyleBackColor = False
        '
        'pctb_logo
        '
        Me.pctb_logo.Image = CType(resources.GetObject("pctb_logo.Image"), System.Drawing.Image)
        Me.pctb_logo.Location = New System.Drawing.Point(85, 6)
        Me.pctb_logo.Name = "pctb_logo"
        Me.pctb_logo.Size = New System.Drawing.Size(154, 138)
        Me.pctb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_logo.TabIndex = 81
        Me.pctb_logo.TabStop = False
        '
        'lnklbl_olvContra
        '
        Me.lnklbl_olvContra.AutoSize = True
        Me.lnklbl_olvContra.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl_olvContra.Location = New System.Drawing.Point(87, 373)
        Me.lnklbl_olvContra.Name = "lnklbl_olvContra"
        Me.lnklbl_olvContra.Size = New System.Drawing.Size(165, 14)
        Me.lnklbl_olvContra.TabIndex = 4
        Me.lnklbl_olvContra.TabStop = True
        Me.lnklbl_olvContra.Text = "¿Ha olvidado su contraseña?"
        '
        'txt_contr
        '
        Me.txt_contr.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contr.Location = New System.Drawing.Point(59, 248)
        Me.txt_contr.MaxLength = 30
        Me.txt_contr.Name = "txt_contr"
        Me.txt_contr.ShortcutsEnabled = False
        Me.txt_contr.Size = New System.Drawing.Size(231, 21)
        Me.txt_contr.TabIndex = 1
        Me.txt_contr.UseSystemPasswordChar = True
        '
        'txt_usr
        '
        Me.txt_usr.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usr.Location = New System.Drawing.Point(59, 185)
        Me.txt_usr.MaxLength = 30
        Me.txt_usr.Name = "txt_usr"
        Me.txt_usr.ShortcutsEnabled = False
        Me.txt_usr.Size = New System.Drawing.Size(231, 21)
        Me.txt_usr.TabIndex = 0
        '
        'lbl_contr
        '
        Me.lbl_contr.AutoSize = True
        Me.lbl_contr.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contr.Location = New System.Drawing.Point(49, 222)
        Me.lbl_contr.Name = "lbl_contr"
        Me.lbl_contr.Size = New System.Drawing.Size(110, 23)
        Me.lbl_contr.TabIndex = 77
        Me.lbl_contr.Text = "Contraseña:"
        '
        'lbl_usr
        '
        Me.lbl_usr.AutoSize = True
        Me.lbl_usr.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr.Location = New System.Drawing.Point(49, 159)
        Me.lbl_usr.Name = "lbl_usr"
        Me.lbl_usr.Size = New System.Drawing.Size(79, 23)
        Me.lbl_usr.TabIndex = 76
        Me.lbl_usr.Text = "Usuario:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 460)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pctb_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pctb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_inicio As Label
    Friend WithEvents pctb_salir As PictureBox
    Friend WithEvents pctb_minimizar As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Chkb_mostrarContra As CheckBox
    Friend WithEvents Btn_ingresar As Button
    Friend WithEvents pctb_logo As PictureBox
    Friend WithEvents lnklbl_olvContra As LinkLabel
    Friend WithEvents lbl_contr As Label
    Friend WithEvents lbl_usr As Label
    Friend WithEvents txt_contr As TextBox
    Friend WithEvents txt_usr As TextBox
End Class
