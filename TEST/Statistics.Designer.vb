<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GdStat = New System.Windows.Forms.DataGridView()
        Me.CmbBoxStDep = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbBoxMonth = New System.Windows.Forms.ComboBox()
        Me.MskedTxtBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.Lblyear = New System.Windows.Forms.Label()
        Me.PicBoxNav5 = New System.Windows.Forms.PictureBox()
        Me.PicBoxDashboardS = New System.Windows.Forms.PictureBox()
        Me.GrpBoxS = New System.Windows.Forms.GroupBox()
        Me.BtnExporter = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.LblPerNav = New System.Windows.Forms.Label()
        Me.Nom_Service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Restant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consultation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Décés = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Per_med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Act_operatoire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sortie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transfere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Journée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GdStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxNav5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxDashboardS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GdStat
        '
        Me.GdStat.AllowUserToAddRows = False
        Me.GdStat.AllowUserToDeleteRows = False
        Me.GdStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GdStat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.GdStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GdStat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom_Service, Me.Lits, Me.Entrant, Me.Restant, Me.Consultation, Me.Décés, Me.Per_med, Me.Act_operatoire, Me.Examen, Me.Sortie, Me.Transfere, Me.TOL, Me.Journée, Me.TEM, Me.TMH, Me.CRL, Me.DMS})
        Me.GdStat.Location = New System.Drawing.Point(19, 189)
        Me.GdStat.MultiSelect = False
        Me.GdStat.Name = "GdStat"
        Me.GdStat.ReadOnly = True
        Me.GdStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GdStat.Size = New System.Drawing.Size(639, 165)
        Me.GdStat.TabIndex = 0
        '
        'CmbBoxStDep
        '
        Me.CmbBoxStDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxStDep.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxStDep.FormattingEnabled = True
        Me.CmbBoxStDep.Location = New System.Drawing.Point(332, 27)
        Me.CmbBoxStDep.Name = "CmbBoxStDep"
        Me.CmbBoxStDep.Size = New System.Drawing.Size(326, 33)
        Me.CmbBoxStDep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom De Departement :"
        '
        'CmbBoxMonth
        '
        Me.CmbBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMonth.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.CmbBoxMonth.FormattingEnabled = True
        Me.CmbBoxMonth.Items.AddRange(New Object() {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"})
        Me.CmbBoxMonth.Location = New System.Drawing.Point(537, 95)
        Me.CmbBoxMonth.Name = "CmbBoxMonth"
        Me.CmbBoxMonth.Size = New System.Drawing.Size(121, 33)
        Me.CmbBoxMonth.TabIndex = 3
        '
        'MskedTxtBox1
        '
        Me.MskedTxtBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.MskedTxtBox1.Location = New System.Drawing.Point(153, 95)
        Me.MskedTxtBox1.Mask = "0000"
        Me.MskedTxtBox1.Name = "MskedTxtBox1"
        Me.MskedTxtBox1.Size = New System.Drawing.Size(121, 32)
        Me.MskedTxtBox1.TabIndex = 4
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonth.Location = New System.Drawing.Point(409, 100)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(51, 21)
        Me.LblMonth.TabIndex = 5
        Me.LblMonth.Text = "Mois :"
        '
        'Lblyear
        '
        Me.Lblyear.AutoSize = True
        Me.Lblyear.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblyear.Location = New System.Drawing.Point(34, 100)
        Me.Lblyear.Name = "Lblyear"
        Me.Lblyear.Size = New System.Drawing.Size(61, 21)
        Me.Lblyear.TabIndex = 6
        Me.Lblyear.Text = "Année :"
        '
        'PicBoxNav5
        '
        Me.PicBoxNav5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PicBoxNav5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicBoxNav5.Location = New System.Drawing.Point(0, 0)
        Me.PicBoxNav5.Name = "PicBoxNav5"
        Me.PicBoxNav5.Size = New System.Drawing.Size(925, 43)
        Me.PicBoxNav5.TabIndex = 7
        Me.PicBoxNav5.TabStop = False
        '
        'PicBoxDashboardS
        '
        Me.PicBoxDashboardS.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PicBoxDashboardS.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicBoxDashboardS.Location = New System.Drawing.Point(0, 43)
        Me.PicBoxDashboardS.Name = "PicBoxDashboardS"
        Me.PicBoxDashboardS.Size = New System.Drawing.Size(207, 491)
        Me.PicBoxDashboardS.TabIndex = 8
        Me.PicBoxDashboardS.TabStop = False
        '
        'GrpBoxS
        '
        Me.GrpBoxS.Controls.Add(Me.BtnExporter)
        Me.GrpBoxS.Controls.Add(Me.GdStat)
        Me.GrpBoxS.Controls.Add(Me.CmbBoxStDep)
        Me.GrpBoxS.Controls.Add(Me.Label1)
        Me.GrpBoxS.Controls.Add(Me.Lblyear)
        Me.GrpBoxS.Controls.Add(Me.MskedTxtBox1)
        Me.GrpBoxS.Controls.Add(Me.LblMonth)
        Me.GrpBoxS.Controls.Add(Me.CmbBoxMonth)
        Me.GrpBoxS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpBoxS.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxS.Location = New System.Drawing.Point(227, 64)
        Me.GrpBoxS.Name = "GrpBoxS"
        Me.GrpBoxS.Size = New System.Drawing.Size(677, 408)
        Me.GrpBoxS.TabIndex = 9
        Me.GrpBoxS.TabStop = False
        '
        'BtnExporter
        '
        Me.BtnExporter.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnExporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExporter.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExporter.ForeColor = System.Drawing.Color.White
        Me.BtnExporter.Location = New System.Drawing.Point(553, 367)
        Me.BtnExporter.Name = "BtnExporter"
        Me.BtnExporter.Size = New System.Drawing.Size(105, 32)
        Me.BtnExporter.TabIndex = 7
        Me.BtnExporter.Text = "Exporter As"
        Me.BtnExporter.UseVisualStyleBackColor = False
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 171)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(207, 36)
        Me.BtnDashboard.TabIndex = 10
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.UseVisualStyleBackColor = False
        '
        'LblPerNav
        '
        Me.LblPerNav.AutoSize = True
        Me.LblPerNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LblPerNav.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerNav.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblPerNav.Location = New System.Drawing.Point(19, 10)
        Me.LblPerNav.Name = "LblPerNav"
        Me.LblPerNav.Size = New System.Drawing.Size(259, 24)
        Me.LblPerNav.TabIndex = 11
        Me.LblPerNav.Text = "Hospital Management System"
        '
        'Nom_Service
        '
        Me.Nom_Service.HeaderText = "Nom Service"
        Me.Nom_Service.Name = "Nom_Service"
        Me.Nom_Service.ReadOnly = True
        Me.Nom_Service.Width = 124
        '
        'Lits
        '
        Me.Lits.HeaderText = "Lits"
        Me.Lits.Name = "Lits"
        Me.Lits.ReadOnly = True
        Me.Lits.Width = 59
        '
        'Entrant
        '
        Me.Entrant.HeaderText = "Entrant"
        Me.Entrant.Name = "Entrant"
        Me.Entrant.ReadOnly = True
        Me.Entrant.Width = 85
        '
        'Restant
        '
        Me.Restant.HeaderText = "Restant"
        Me.Restant.Name = "Restant"
        Me.Restant.ReadOnly = True
        Me.Restant.Width = 87
        '
        'Consultation
        '
        Me.Consultation.HeaderText = "Consultation"
        Me.Consultation.Name = "Consultation"
        Me.Consultation.ReadOnly = True
        Me.Consultation.Width = 123
        '
        'Décés
        '
        Me.Décés.HeaderText = "Décés"
        Me.Décés.Name = "Décés"
        Me.Décés.ReadOnly = True
        Me.Décés.Width = 76
        '
        'Per_med
        '
        Me.Per_med.HeaderText = "Personnel Médical"
        Me.Per_med.Name = "Per_med"
        Me.Per_med.ReadOnly = True
        Me.Per_med.Width = 148
        '
        'Act_operatoire
        '
        Me.Act_operatoire.HeaderText = "Actes Operatoire"
        Me.Act_operatoire.Name = "Act_operatoire"
        Me.Act_operatoire.ReadOnly = True
        Me.Act_operatoire.Width = 138
        '
        'Examen
        '
        Me.Examen.HeaderText = "Examen"
        Me.Examen.Name = "Examen"
        Me.Examen.ReadOnly = True
        Me.Examen.Width = 89
        '
        'Sortie
        '
        Me.Sortie.HeaderText = "Sortie"
        Me.Sortie.Name = "Sortie"
        Me.Sortie.ReadOnly = True
        Me.Sortie.Width = 76
        '
        'Transfere
        '
        Me.Transfere.HeaderText = "Transfere"
        Me.Transfere.Name = "Transfere"
        Me.Transfere.ReadOnly = True
        '
        'TOL
        '
        Me.TOL.HeaderText = "TOL%"
        Me.TOL.Name = "TOL"
        Me.TOL.ReadOnly = True
        Me.TOL.Width = 76
        '
        'Journée
        '
        Me.Journée.HeaderText = "Journée D'hospitalisation"
        Me.Journée.Name = "Journée"
        Me.Journée.ReadOnly = True
        Me.Journée.Width = 191
        '
        'TEM
        '
        Me.TEM.HeaderText = "TEM%"
        Me.TEM.Name = "TEM"
        Me.TEM.ReadOnly = True
        Me.TEM.Width = 78
        '
        'TMH
        '
        Me.TMH.HeaderText = "TMH%"
        Me.TMH.Name = "TMH"
        Me.TMH.ReadOnly = True
        Me.TMH.Width = 81
        '
        'CRL
        '
        Me.CRL.HeaderText = "CRL"
        Me.CRL.Name = "CRL"
        Me.CRL.ReadOnly = True
        Me.CRL.Width = 63
        '
        'DMS
        '
        Me.DMS.HeaderText = "DMS"
        Me.DMS.Name = "DMS"
        Me.DMS.ReadOnly = True
        Me.DMS.Width = 69
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 534)
        Me.Controls.Add(Me.LblPerNav)
        Me.Controls.Add(Me.BtnDashboard)
        Me.Controls.Add(Me.GrpBoxS)
        Me.Controls.Add(Me.PicBoxDashboardS)
        Me.Controls.Add(Me.PicBoxNav5)
        Me.Name = "Statistics"
        Me.Text = "Statistique"
        CType(Me.GdStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxNav5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxDashboardS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxS.ResumeLayout(False)
        Me.GrpBoxS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBoxStDep As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbBoxMonth As ComboBox
    Friend WithEvents MskedTxtBox1 As MaskedTextBox
    Friend WithEvents LblMonth As Label
    Friend WithEvents Lblyear As Label
    Public WithEvents GdStat As DataGridView
    Friend WithEvents PicBoxNav5 As PictureBox
    Friend WithEvents PicBoxDashboardS As PictureBox
    Friend WithEvents GrpBoxS As GroupBox
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents LblPerNav As Label
    Friend WithEvents BtnExporter As Button
    Friend WithEvents Nom_Service As DataGridViewTextBoxColumn
    Friend WithEvents Lits As DataGridViewTextBoxColumn
    Friend WithEvents Entrant As DataGridViewTextBoxColumn
    Friend WithEvents Restant As DataGridViewTextBoxColumn
    Friend WithEvents Consultation As DataGridViewTextBoxColumn
    Friend WithEvents Décés As DataGridViewTextBoxColumn
    Friend WithEvents Per_med As DataGridViewTextBoxColumn
    Friend WithEvents Act_operatoire As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Sortie As DataGridViewTextBoxColumn
    Friend WithEvents Transfere As DataGridViewTextBoxColumn
    Friend WithEvents TOL As DataGridViewTextBoxColumn
    Friend WithEvents Journée As DataGridViewTextBoxColumn
    Friend WithEvents TEM As DataGridViewTextBoxColumn
    Friend WithEvents TMH As DataGridViewTextBoxColumn
    Friend WithEvents CRL As DataGridViewTextBoxColumn
    Friend WithEvents DMS As DataGridViewTextBoxColumn
End Class
