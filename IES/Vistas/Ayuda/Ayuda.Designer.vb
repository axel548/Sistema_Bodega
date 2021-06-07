<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ayuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ayuda))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.Btn_Correo = New System.Windows.Forms.Button()
        Me.Btn_Inventario = New System.Windows.Forms.Button()
        Me.Btn_Usr = New System.Windows.Forms.Button()
        Me.Btn_Prestamos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 38)
        Me.Panel1.TabIndex = 20
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
        Me.BunifuGradientPanel1.TabIndex = 83
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Titulo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Titulo.Location = New System.Drawing.Point(303, 3)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(103, 32)
        Me.lbl_Titulo.TabIndex = 47
        Me.lbl_Titulo.Text = "Ayuda"
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
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Contenedor.Location = New System.Drawing.Point(0, 95)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(723, 305)
        Me.Panel_Contenedor.TabIndex = 21
        '
        'Btn_Correo
        '
        Me.Btn_Correo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Correo.FlatAppearance.BorderSize = 0
        Me.Btn_Correo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Correo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Correo.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Correo.ForeColor = System.Drawing.Color.Black
        Me.Btn_Correo.Image = CType(resources.GetObject("Btn_Correo.Image"), System.Drawing.Image)
        Me.Btn_Correo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Correo.Location = New System.Drawing.Point(549, 44)
        Me.Btn_Correo.Name = "Btn_Correo"
        Me.Btn_Correo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Correo.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Correo.TabIndex = 24
        Me.Btn_Correo.Text = "             Correo"
        Me.Btn_Correo.UseVisualStyleBackColor = False
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
        Me.Btn_Inventario.Location = New System.Drawing.Point(0, 44)
        Me.Btn_Inventario.Name = "Btn_Inventario"
        Me.Btn_Inventario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Inventario.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Inventario.TabIndex = 20
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
        Me.Btn_Usr.Location = New System.Drawing.Point(183, 44)
        Me.Btn_Usr.Name = "Btn_Usr"
        Me.Btn_Usr.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Usr.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Usr.TabIndex = 21
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
        Me.Btn_Prestamos.Location = New System.Drawing.Point(366, 44)
        Me.Btn_Prestamos.Name = "Btn_Prestamos"
        Me.Btn_Prestamos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Prestamos.Size = New System.Drawing.Size(177, 50)
        Me.Btn_Prestamos.TabIndex = 22
        Me.Btn_Prestamos.Text = "               Préstamos"
        Me.Btn_Prestamos.UseVisualStyleBackColor = False
        '
        'Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 400)
        Me.Controls.Add(Me.Btn_Correo)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.Btn_Inventario)
        Me.Controls.Add(Me.Btn_Usr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Prestamos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ayuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        Me.Panel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents Pctb_salir As PictureBox
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents Btn_Correo As Button
    Friend WithEvents Btn_Inventario As Button
    Friend WithEvents Btn_Usr As Button
    Friend WithEvents Btn_Prestamos As Button
End Class
