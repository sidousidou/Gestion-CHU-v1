<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonnelMed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicBoxNavPer = New System.Windows.Forms.PictureBox()
        Me.LblTitleNav = New System.Windows.Forms.Label()
        Me.PicBoxDash4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnValP = New System.Windows.Forms.Button()
        Me.MskdTxtPerYear = New System.Windows.Forms.MaskedTextBox()
        Me.LblYearP = New System.Windows.Forms.Label()
        Me.LblMonthP = New System.Windows.Forms.Label()
        Me.CmbBoxMonthP = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblNbrPara = New System.Windows.Forms.Label()
        Me.LblNbrMed = New System.Windows.Forms.Label()
        Me.LblNbrCh = New System.Windows.Forms.Label()
        Me.TxtBoxMED = New System.Windows.Forms.TextBox()
        Me.TxtBoxPara = New System.Windows.Forms.TextBox()
        Me.TxtBoxNbrChiru = New System.Windows.Forms.TextBox()
        Me.CmbBoxDepPer = New System.Windows.Forms.ComboBox()
        Me.CmbBoxPerSer = New System.Windows.Forms.ComboBox()
        Me.LblDepPer = New System.Windows.Forms.Label()
        Me.LblSerPer = New System.Windows.Forms.Label()
        Me.BtnDashP = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxNavPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxDash4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(137, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PicBoxNavPer
        '
        Me.PicBoxNavPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PicBoxNavPer.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicBoxNavPer.Location = New System.Drawing.Point(0, 0)
        Me.PicBoxNavPer.Name = "PicBoxNavPer"
        Me.PicBoxNavPer.Size = New System.Drawing.Size(925, 43)
        Me.PicBoxNavPer.TabIndex = 1
        Me.PicBoxNavPer.TabStop = False
        '
        'LblTitleNav
        '
        Me.LblTitleNav.AutoSize = True
        Me.LblTitleNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LblTitleNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTitleNav.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleNav.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTitleNav.Location = New System.Drawing.Point(19, 10)
        Me.LblTitleNav.Name = "LblTitleNav"
        Me.LblTitleNav.Size = New System.Drawing.Size(259, 24)
        Me.LblTitleNav.TabIndex = 2
        Me.LblTitleNav.Text = "Hospital System Management"
        '
        'PicBoxDash4
        '
        Me.PicBoxDash4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PicBoxDash4.Location = New System.Drawing.Point(0, 43)
        Me.PicBoxDash4.Name = "PicBoxDash4"
        Me.PicBoxDash4.Size = New System.Drawing.Size(207, 491)
        Me.PicBoxDash4.TabIndex = 3
        Me.PicBoxDash4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.BtnValP)
        Me.GroupBox1.Controls.Add(Me.MskdTxtPerYear)
        Me.GroupBox1.Controls.Add(Me.LblYearP)
        Me.GroupBox1.Controls.Add(Me.LblMonthP)
        Me.GroupBox1.Controls.Add(Me.CmbBoxMonthP)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.CmbBoxDepPer)
        Me.GroupBox1.Controls.Add(Me.CmbBoxPerSer)
        Me.GroupBox1.Controls.Add(Me.LblDepPer)
        Me.GroupBox1.Controls.Add(Me.LblSerPer)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(244, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 451)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnel Médicals"
        '
        'BtnValP
        '
        Me.BtnValP.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnValP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnValP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnValP.Location = New System.Drawing.Point(531, 407)
        Me.BtnValP.Name = "BtnValP"
        Me.BtnValP.Size = New System.Drawing.Size(88, 34)
        Me.BtnValP.TabIndex = 8
        Me.BtnValP.Text = "Valider"
        Me.BtnValP.UseVisualStyleBackColor = False
        '
        'MskdTxtPerYear
        '
        Me.MskdTxtPerYear.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!)
        Me.MskdTxtPerYear.Location = New System.Drawing.Point(186, 147)
        Me.MskdTxtPerYear.Mask = "0000"
        Me.MskdTxtPerYear.Name = "MskdTxtPerYear"
        Me.MskdTxtPerYear.Size = New System.Drawing.Size(100, 35)
        Me.MskdTxtPerYear.TabIndex = 4
        '
        'LblYearP
        '
        Me.LblYearP.AutoSize = True
        Me.LblYearP.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblYearP.ForeColor = System.Drawing.Color.Black
        Me.LblYearP.Location = New System.Drawing.Point(52, 149)
        Me.LblYearP.Name = "LblYearP"
        Me.LblYearP.Size = New System.Drawing.Size(75, 25)
        Me.LblYearP.TabIndex = 6
        Me.LblYearP.Text = "Annee :"
        '
        'LblMonthP
        '
        Me.LblMonthP.AutoSize = True
        Me.LblMonthP.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblMonthP.ForeColor = System.Drawing.Color.Black
        Me.LblMonthP.Location = New System.Drawing.Point(347, 149)
        Me.LblMonthP.Name = "LblMonthP"
        Me.LblMonthP.Size = New System.Drawing.Size(62, 25)
        Me.LblMonthP.TabIndex = 7
        Me.LblMonthP.Text = "Mois :"
        '
        'CmbBoxMonthP
        '
        Me.CmbBoxMonthP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMonthP.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!)
        Me.CmbBoxMonthP.FormattingEnabled = True
        Me.CmbBoxMonthP.Items.AddRange(New Object() {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"})
        Me.CmbBoxMonthP.Location = New System.Drawing.Point(498, 147)
        Me.CmbBoxMonthP.Name = "CmbBoxMonthP"
        Me.CmbBoxMonthP.Size = New System.Drawing.Size(121, 35)
        Me.CmbBoxMonthP.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.TabControl1.Location = New System.Drawing.Point(26, 194)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 211)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblNbrPara)
        Me.TabPage1.Controls.Add(Me.LblNbrMed)
        Me.TabPage1.Controls.Add(Me.LblNbrCh)
        Me.TabPage1.Controls.Add(Me.TxtBoxMED)
        Me.TabPage1.Controls.Add(Me.TxtBoxPara)
        Me.TabPage1.Controls.Add(Me.TxtBoxNbrChiru)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 173)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste De Personnel Med"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblNbrPara
        '
        Me.LblNbrPara.AutoSize = True
        Me.LblNbrPara.Location = New System.Drawing.Point(23, 114)
        Me.LblNbrPara.Name = "LblNbrPara"
        Me.LblNbrPara.Size = New System.Drawing.Size(133, 25)
        Me.LblNbrPara.TabIndex = 5
        Me.LblNbrPara.Text = "Paramédicals :"
        '
        'LblNbrMed
        '
        Me.LblNbrMed.AutoSize = True
        Me.LblNbrMed.Location = New System.Drawing.Point(23, 26)
        Me.LblNbrMed.Name = "LblNbrMed"
        Me.LblNbrMed.Size = New System.Drawing.Size(119, 25)
        Me.LblNbrMed.TabIndex = 4
        Me.LblNbrMed.Text = "Chirurgiens :"
        '
        'LblNbrCh
        '
        Me.LblNbrCh.AutoSize = True
        Me.LblNbrCh.Location = New System.Drawing.Point(22, 72)
        Me.LblNbrCh.Name = "LblNbrCh"
        Me.LblNbrCh.Size = New System.Drawing.Size(102, 25)
        Me.LblNbrCh.TabIndex = 3
        Me.LblNbrCh.Text = "Médecins :"
        '
        'TxtBoxMED
        '
        Me.TxtBoxMED.Location = New System.Drawing.Point(295, 65)
        Me.TxtBoxMED.Name = "TxtBoxMED"
        Me.TxtBoxMED.Size = New System.Drawing.Size(276, 32)
        Me.TxtBoxMED.TabIndex = 2
        '
        'TxtBoxPara
        '
        Me.TxtBoxPara.Location = New System.Drawing.Point(295, 109)
        Me.TxtBoxPara.Name = "TxtBoxPara"
        Me.TxtBoxPara.Size = New System.Drawing.Size(276, 32)
        Me.TxtBoxPara.TabIndex = 1
        '
        'TxtBoxNbrChiru
        '
        Me.TxtBoxNbrChiru.Location = New System.Drawing.Point(295, 23)
        Me.TxtBoxNbrChiru.Name = "TxtBoxNbrChiru"
        Me.TxtBoxNbrChiru.Size = New System.Drawing.Size(276, 32)
        Me.TxtBoxNbrChiru.TabIndex = 0
        '
        'CmbBoxDepPer
        '
        Me.CmbBoxDepPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxDepPer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!)
        Me.CmbBoxDepPer.FormattingEnabled = True
        Me.CmbBoxDepPer.Location = New System.Drawing.Point(301, 27)
        Me.CmbBoxDepPer.Name = "CmbBoxDepPer"
        Me.CmbBoxDepPer.Size = New System.Drawing.Size(318, 35)
        Me.CmbBoxDepPer.TabIndex = 2
        '
        'CmbBoxPerSer
        '
        Me.CmbBoxPerSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxPerSer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!)
        Me.CmbBoxPerSer.FormattingEnabled = True
        Me.CmbBoxPerSer.Location = New System.Drawing.Point(301, 79)
        Me.CmbBoxPerSer.Name = "CmbBoxPerSer"
        Me.CmbBoxPerSer.Size = New System.Drawing.Size(318, 35)
        Me.CmbBoxPerSer.TabIndex = 0
        '
        'LblDepPer
        '
        Me.LblDepPer.AutoSize = True
        Me.LblDepPer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblDepPer.ForeColor = System.Drawing.Color.Black
        Me.LblDepPer.Location = New System.Drawing.Point(53, 32)
        Me.LblDepPer.Name = "LblDepPer"
        Me.LblDepPer.Size = New System.Drawing.Size(131, 25)
        Me.LblDepPer.TabIndex = 3
        Me.LblDepPer.Text = "Departement :"
        '
        'LblSerPer
        '
        Me.LblSerPer.AutoSize = True
        Me.LblSerPer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblSerPer.ForeColor = System.Drawing.Color.Black
        Me.LblSerPer.Location = New System.Drawing.Point(52, 84)
        Me.LblSerPer.Name = "LblSerPer"
        Me.LblSerPer.Size = New System.Drawing.Size(81, 25)
        Me.LblSerPer.TabIndex = 1
        Me.LblSerPer.Text = "Service :"
        '
        'BtnDashP
        '
        Me.BtnDashP.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDashP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashP.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashP.Location = New System.Drawing.Point(0, 171)
        Me.BtnDashP.Name = "BtnDashP"
        Me.BtnDashP.Size = New System.Drawing.Size(207, 36)
        Me.BtnDashP.TabIndex = 5
        Me.BtnDashP.Text = "Dashboard"
        Me.BtnDashP.UseVisualStyleBackColor = False
        '
        'PersonnelMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 534)
        Me.Controls.Add(Me.BtnDashP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PicBoxDash4)
        Me.Controls.Add(Me.LblTitleNav)
        Me.Controls.Add(Me.PicBoxNavPer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PersonnelMed"
        Me.Text = "Personnel Medical"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxNavPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxDash4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicBoxNavPer As PictureBox
    Friend WithEvents LblTitleNav As Label
    Friend WithEvents PicBoxDash4 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblSerPer As Label
    Friend WithEvents CmbBoxPerSer As ComboBox
    Friend WithEvents CmbBoxDepPer As ComboBox
    Friend WithEvents LblDepPer As Label
    Friend WithEvents MskdTxtPerYear As MaskedTextBox
    Friend WithEvents LblMonthP As Label
    Friend WithEvents LblYearP As Label
    Friend WithEvents CmbBoxMonthP As ComboBox
    Friend WithEvents LblNbrPara As Label
    Friend WithEvents LblNbrMed As Label
    Friend WithEvents LblNbrCh As Label
    Friend WithEvents TxtBoxMED As TextBox
    Friend WithEvents TxtBoxPara As TextBox
    Friend WithEvents TxtBoxNbrChiru As TextBox
    Friend WithEvents BtnValP As Button
    Friend WithEvents BtnDashP As Button
End Class
