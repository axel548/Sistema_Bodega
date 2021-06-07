<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carga))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Bf_GradianPnl = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Lbl_Descriptivo = New System.Windows.Forms.Label()
        Me.pctb_logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_Cargando = New System.Windows.Forms.Label()
        Me.Bf_Prbar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBD = New System.Windows.Forms.Timer(Me.components)
        Me.tmrArchivos = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInternet = New System.Windows.Forms.Timer(Me.components)
        Me.Bf_Animation = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Bf_GradianPnl.SuspendLayout()
        CType(Me.pctb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bf_GradianPnl
        '
        Me.Bf_GradianPnl.BackgroundImage = CType(resources.GetObject("Bf_GradianPnl.BackgroundImage"), System.Drawing.Image)
        Me.Bf_GradianPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bf_GradianPnl.Controls.Add(Me.Lbl_Descriptivo)
        Me.Bf_GradianPnl.Controls.Add(Me.pctb_logo)
        Me.Bf_GradianPnl.Controls.Add(Me.Lbl_Cargando)
        Me.Bf_GradianPnl.Controls.Add(Me.Bf_Prbar)
        Me.Bf_Animation.SetDecoration(Me.Bf_GradianPnl, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_GradianPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bf_GradianPnl.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_GradianPnl.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Bf_GradianPnl.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Bf_GradianPnl.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Bf_GradianPnl.Location = New System.Drawing.Point(0, 0)
        Me.Bf_GradianPnl.Name = "Bf_GradianPnl"
        Me.Bf_GradianPnl.Quality = 10
        Me.Bf_GradianPnl.Size = New System.Drawing.Size(338, 207)
        Me.Bf_GradianPnl.TabIndex = 1
        '
        'Lbl_Descriptivo
        '
        Me.Lbl_Descriptivo.AutoSize = True
        Me.Lbl_Descriptivo.BackColor = System.Drawing.Color.Transparent
        Me.Bf_Animation.SetDecoration(Me.Lbl_Descriptivo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Descriptivo.Font = New System.Drawing.Font("Roboto", 9.25!)
        Me.Lbl_Descriptivo.ForeColor = System.Drawing.Color.White
        Me.Lbl_Descriptivo.Location = New System.Drawing.Point(65, 161)
        Me.Lbl_Descriptivo.Name = "Lbl_Descriptivo"
        Me.Lbl_Descriptivo.Size = New System.Drawing.Size(26, 15)
        Me.Lbl_Descriptivo.TabIndex = 9
        Me.Lbl_Descriptivo.Text = "bfg"
        '
        'pctb_logo
        '
        Me.pctb_logo.BackColor = System.Drawing.Color.Transparent
        Me.Bf_Animation.SetDecoration(Me.pctb_logo, BunifuAnimatorNS.DecorationType.None)
        Me.pctb_logo.Image = CType(resources.GetObject("pctb_logo.Image"), System.Drawing.Image)
        Me.pctb_logo.Location = New System.Drawing.Point(106, 12)
        Me.pctb_logo.Name = "pctb_logo"
        Me.pctb_logo.Size = New System.Drawing.Size(134, 122)
        Me.pctb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctb_logo.TabIndex = 8
        Me.pctb_logo.TabStop = False
        '
        'Lbl_Cargando
        '
        Me.Lbl_Cargando.AutoSize = True
        Me.Lbl_Cargando.BackColor = System.Drawing.Color.Transparent
        Me.Bf_Animation.SetDecoration(Me.Lbl_Cargando, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Cargando.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cargando.ForeColor = System.Drawing.Color.White
        Me.Lbl_Cargando.Location = New System.Drawing.Point(113, 137)
        Me.Lbl_Cargando.Name = "Lbl_Cargando"
        Me.Lbl_Cargando.Size = New System.Drawing.Size(122, 23)
        Me.Lbl_Cargando.TabIndex = 2
        Me.Lbl_Cargando.Text = "Preparando..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Bf_Prbar
        '
        Me.Bf_Prbar.BackColor = System.Drawing.Color.Silver
        Me.Bf_Prbar.BorderRadius = 5
        Me.Bf_Animation.SetDecoration(Me.Bf_Prbar, BunifuAnimatorNS.DecorationType.None)
        Me.Bf_Prbar.Location = New System.Drawing.Point(12, 185)
        Me.Bf_Prbar.MaximumValue = 100
        Me.Bf_Prbar.Name = "Bf_Prbar"
        Me.Bf_Prbar.ProgressColor = System.Drawing.Color.Azure
        Me.Bf_Prbar.Size = New System.Drawing.Size(314, 10)
        Me.Bf_Prbar.TabIndex = 1
        Me.Bf_Prbar.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'tmrBD
        '
        Me.tmrBD.Interval = 7000
        '
        'tmrArchivos
        '
        Me.tmrArchivos.Interval = 1000
        '
        'tmrInternet
        '
        Me.tmrInternet.Interval = 1000
        '
        'Bf_Animation
        '
        Me.Bf_Animation.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.Bf_Animation.Cursor = Nothing
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
        Me.Bf_Animation.DefaultAnimation = Animation1
        '
        'Carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 207)
        Me.Controls.Add(Me.Bf_GradianPnl)
        Me.Bf_Animation.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga"
        Me.Bf_GradianPnl.ResumeLayout(False)
        Me.Bf_GradianPnl.PerformLayout()
        CType(Me.pctb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bf_GradianPnl As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Bf_Prbar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Lbl_Cargando As Label
    Friend WithEvents pctb_logo As PictureBox
    Friend WithEvents Lbl_Descriptivo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tmrBD As Timer
    Friend WithEvents tmrArchivos As Timer
    Friend WithEvents tmrInternet As Timer
    Friend WithEvents Bf_Animation As BunifuAnimatorNS.BunifuTransition
End Class
