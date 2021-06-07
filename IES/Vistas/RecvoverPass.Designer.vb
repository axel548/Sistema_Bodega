<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecvoverPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecvoverPass))
        Me.Lbl_UsEma = New System.Windows.Forms.Label()
        Me.Lbl_Result = New System.Windows.Forms.Label()
        Me.Txt_recuperar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pctb_minimizar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_recuperar = New System.Windows.Forms.Button()
        Me.Btn_regresar = New System.Windows.Forms.Button()
        Me.Bf_dragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.pctb_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_UsEma
        '
        Me.Lbl_UsEma.AutoSize = True
        Me.Lbl_UsEma.Font = New System.Drawing.Font("Roboto", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UsEma.Location = New System.Drawing.Point(12, 25)
        Me.Lbl_UsEma.Name = "Lbl_UsEma"
        Me.Lbl_UsEma.Size = New System.Drawing.Size(318, 20)
        Me.Lbl_UsEma.TabIndex = 1
        Me.Lbl_UsEma.Text = "Ingrese su Usuario o Correo Electrónico: "
        '
        'Lbl_Result
        '
        Me.Lbl_Result.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Result.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Result.Location = New System.Drawing.Point(13, 185)
        Me.Lbl_Result.Name = "Lbl_Result"
        Me.Lbl_Result.Size = New System.Drawing.Size(272, 65)
        Me.Lbl_Result.TabIndex = 2
        Me.Lbl_Result.Text = "REsult"
        Me.Lbl_Result.Visible = False
        '
        'Txt_recuperar
        '
        Me.Txt_recuperar.Location = New System.Drawing.Point(16, 73)
        Me.Txt_recuperar.Name = "Txt_recuperar"
        Me.Txt_recuperar.ShortcutsEnabled = False
        Me.Txt_recuperar.Size = New System.Drawing.Size(314, 20)
        Me.Txt_recuperar.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 38)
        Me.Panel1.TabIndex = 4
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.pctb_minimizar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label3)
        Me.BunifuGradientPanel1.Controls.Add(Me.pctb_salir)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(338, 38)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'pctb_minimizar
        '
        Me.pctb_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.pctb_minimizar.Image = CType(resources.GetObject("pctb_minimizar.Image"), System.Drawing.Image)
        Me.pctb_minimizar.Location = New System.Drawing.Point(280, 3)
        Me.pctb_minimizar.Name = "pctb_minimizar"
        Me.pctb_minimizar.Size = New System.Drawing.Size(25, 25)
        Me.pctb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_minimizar.TabIndex = 10
        Me.pctb_minimizar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Recuperación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pctb_salir
        '
        Me.pctb_salir.BackColor = System.Drawing.Color.Transparent
        Me.pctb_salir.Image = CType(resources.GetObject("pctb_salir.Image"), System.Drawing.Image)
        Me.pctb_salir.Location = New System.Drawing.Point(310, 3)
        Me.pctb_salir.Name = "pctb_salir"
        Me.pctb_salir.Size = New System.Drawing.Size(25, 25)
        Me.pctb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_salir.TabIndex = 9
        Me.pctb_salir.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Btn_recuperar)
        Me.Panel2.Controls.Add(Me.Btn_regresar)
        Me.Panel2.Controls.Add(Me.Txt_recuperar)
        Me.Panel2.Controls.Add(Me.Lbl_Result)
        Me.Panel2.Controls.Add(Me.Lbl_UsEma)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 259)
        Me.Panel2.TabIndex = 5
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
        Me.Btn_recuperar.Location = New System.Drawing.Point(106, 106)
        Me.Btn_recuperar.Name = "Btn_recuperar"
        Me.Btn_recuperar.Size = New System.Drawing.Size(121, 40)
        Me.Btn_recuperar.TabIndex = 83
        Me.Btn_recuperar.Text = "           Recuperar"
        Me.Btn_recuperar.UseVisualStyleBackColor = False
        '
        'Btn_regresar
        '
        Me.Btn_regresar.BackColor = System.Drawing.Color.White
        Me.Btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_regresar.Image = CType(resources.GetObject("Btn_regresar.Image"), System.Drawing.Image)
        Me.Btn_regresar.Location = New System.Drawing.Point(291, 217)
        Me.Btn_regresar.Name = "Btn_regresar"
        Me.Btn_regresar.Size = New System.Drawing.Size(44, 39)
        Me.Btn_regresar.TabIndex = 4
        Me.Btn_regresar.UseVisualStyleBackColor = False
        '
        'Bf_dragControl
        '
        Me.Bf_dragControl.Fixed = True
        Me.Bf_dragControl.Horizontal = True
        Me.Bf_dragControl.TargetControl = Me.BunifuGradientPanel1
        Me.Bf_dragControl.Vertical = True
        '
        'RecvoverPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 297)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecvoverPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecvoverPass"
        Me.Panel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.pctb_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_UsEma As Label
    Friend WithEvents Lbl_Result As Label
    Friend WithEvents Txt_recuperar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pctb_minimizar As PictureBox
    Friend WithEvents pctb_salir As PictureBox
    Friend WithEvents Btn_regresar As Button
    Friend WithEvents Btn_recuperar As Button
    Friend WithEvents Bf_dragControl As Bunifu.Framework.UI.BunifuDragControl
End Class
