<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubForm_Inventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubForm_Inventario))
        Me.Dgv_SubInv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bf_GradianPNL = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pctb_salir = New System.Windows.Forms.PictureBox()
        Me.Lbl_Aviso = New System.Windows.Forms.Label()
        Me.Cb_Eleccion = New System.Windows.Forms.ComboBox()
        Me.Cb_Subcate = New System.Windows.Forms.ComboBox()
        Me.Cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Lbl_info1 = New System.Windows.Forms.Label()
        Me.Lbl_info2 = New System.Windows.Forms.Label()
        Me.Lbl_info3 = New System.Windows.Forms.Label()
        CType(Me.Dgv_SubInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Bf_GradianPNL.SuspendLayout()
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_SubInv
        '
        Me.Dgv_SubInv.AllowDrop = True
        Me.Dgv_SubInv.AllowUserToAddRows = False
        Me.Dgv_SubInv.AllowUserToDeleteRows = False
        Me.Dgv_SubInv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dgv_SubInv.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_SubInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_SubInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_SubInv.ColumnHeadersHeight = 30
        Me.Dgv_SubInv.EnableHeadersVisualStyles = False
        Me.Dgv_SubInv.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Dgv_SubInv.Location = New System.Drawing.Point(15, 116)
        Me.Dgv_SubInv.Name = "Dgv_SubInv"
        Me.Dgv_SubInv.ReadOnly = True
        Me.Dgv_SubInv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_SubInv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_SubInv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_SubInv.RowTemplate.Height = 30
        Me.Dgv_SubInv.Size = New System.Drawing.Size(413, 242)
        Me.Dgv_SubInv.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Bf_GradianPNL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 28)
        Me.Panel1.TabIndex = 51
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
        Me.Bf_GradianPNL.TabIndex = 83
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
        Me.Pctb_salir.TabIndex = 53
        Me.Pctb_salir.TabStop = False
        '
        'Lbl_Aviso
        '
        Me.Lbl_Aviso.AutoSize = True
        Me.Lbl_Aviso.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Aviso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Aviso.Location = New System.Drawing.Point(9, 96)
        Me.Lbl_Aviso.Name = "Lbl_Aviso"
        Me.Lbl_Aviso.Size = New System.Drawing.Size(334, 14)
        Me.Lbl_Aviso.TabIndex = 52
        Me.Lbl_Aviso.Text = "Presione DobleClick en una celda para seleccionar el registro"
        Me.Lbl_Aviso.Visible = False
        '
        'Cb_Eleccion
        '
        Me.Cb_Eleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Eleccion.FormattingEnabled = True
        Me.Cb_Eleccion.Items.AddRange(New Object() {"Activo", "Reserva", "Mal Estado"})
        Me.Cb_Eleccion.Location = New System.Drawing.Point(26, 65)
        Me.Cb_Eleccion.Name = "Cb_Eleccion"
        Me.Cb_Eleccion.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Eleccion.TabIndex = 0
        '
        'Cb_Subcate
        '
        Me.Cb_Subcate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Subcate.BackColor = System.Drawing.Color.White
        Me.Cb_Subcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Subcate.FormattingEnabled = True
        Me.Cb_Subcate.Location = New System.Drawing.Point(302, 65)
        Me.Cb_Subcate.Name = "Cb_Subcate"
        Me.Cb_Subcate.Size = New System.Drawing.Size(107, 21)
        Me.Cb_Subcate.TabIndex = 2
        '
        'Cb_categoria
        '
        Me.Cb_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_categoria.BackColor = System.Drawing.Color.White
        Me.Cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_categoria.FormattingEnabled = True
        Me.Cb_categoria.Items.AddRange(New Object() {"Computación", "Eléctronica", "Electricidad", "Dibujo Técnico", "Mecánica"})
        Me.Cb_categoria.Location = New System.Drawing.Point(156, 65)
        Me.Cb_categoria.Name = "Cb_categoria"
        Me.Cb_categoria.Size = New System.Drawing.Size(138, 21)
        Me.Cb_categoria.TabIndex = 1
        '
        'Lbl_info1
        '
        Me.Lbl_info1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_info1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_info1.Location = New System.Drawing.Point(26, 34)
        Me.Lbl_info1.Name = "Lbl_info1"
        Me.Lbl_info1.Size = New System.Drawing.Size(121, 28)
        Me.Lbl_info1.TabIndex = 91
        Me.Lbl_info1.Text = "Seleccione el tipo de Inventario."
        Me.Lbl_info1.Visible = False
        '
        'Lbl_info2
        '
        Me.Lbl_info2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_info2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_info2.Location = New System.Drawing.Point(156, 34)
        Me.Lbl_info2.Name = "Lbl_info2"
        Me.Lbl_info2.Size = New System.Drawing.Size(87, 28)
        Me.Lbl_info2.TabIndex = 98
        Me.Lbl_info2.Text = "Seleccione la categoría."
        Me.Lbl_info2.Visible = False
        '
        'Lbl_info3
        '
        Me.Lbl_info3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_info3.ForeColor = System.Drawing.Color.Black
        Me.Lbl_info3.Location = New System.Drawing.Point(299, 34)
        Me.Lbl_info3.Name = "Lbl_info3"
        Me.Lbl_info3.Size = New System.Drawing.Size(96, 28)
        Me.Lbl_info3.TabIndex = 99
        Me.Lbl_info3.Text = "Seleccione la Sub-categoría." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbl_info3.Visible = False
        '
        'SubForm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 370)
        Me.Controls.Add(Me.Lbl_info3)
        Me.Controls.Add(Me.Lbl_info2)
        Me.Controls.Add(Me.Cb_Subcate)
        Me.Controls.Add(Me.Lbl_info1)
        Me.Controls.Add(Me.Cb_categoria)
        Me.Controls.Add(Me.Cb_Eleccion)
        Me.Controls.Add(Me.Lbl_Aviso)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dgv_SubInv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubForm_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubForm_Inventario"
        CType(Me.Dgv_SubInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Bf_GradianPNL.ResumeLayout(False)
        CType(Me.Pctb_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_SubInv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bf_GradianPNL As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BodegaDataSet As BodegaDataSet

    Friend WithEvents IdinveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents IdpiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_Aviso As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Pctb_salir As PictureBox

    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoríaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cb_Eleccion As ComboBox
    Friend WithEvents Cb_Subcate As ComboBox
    Friend WithEvents Cb_categoria As ComboBox
    Friend WithEvents Lbl_info1 As Label
    Friend WithEvents Lbl_info2 As Label
    Friend WithEvents Lbl_info3 As Label
End Class
