<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mouvement
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
        Me.TabCntrl3 = New System.Windows.Forms.TabControl()
        Me.Admision = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxJournee = New System.Windows.Forms.TextBox()
        Me.LblAEM = New System.Windows.Forms.Label()
        Me.LblAFM = New System.Windows.Forms.Label()
        Me.LblAHM = New System.Windows.Forms.Label()
        Me.TxtBoxAEM = New System.Windows.Forms.TextBox()
        Me.TxtBoxAHM = New System.Windows.Forms.TextBox()
        Me.TxtBoxAFM = New System.Windows.Forms.TextBox()
        Me.Transfer = New System.Windows.Forms.TabPage()
        Me.LblTEM = New System.Windows.Forms.Label()
        Me.LblTFM = New System.Windows.Forms.Label()
        Me.LblTHM = New System.Windows.Forms.Label()
        Me.TxtBoxTEM = New System.Windows.Forms.TextBox()
        Me.TxtBoxTFM = New System.Windows.Forms.TextBox()
        Me.TxtBoxTHM = New System.Windows.Forms.TextBox()
        Me.Décis = New System.Windows.Forms.TabPage()
        Me.LblDEM = New System.Windows.Forms.Label()
        Me.LblDFM = New System.Windows.Forms.Label()
        Me.LblDHM = New System.Windows.Forms.Label()
        Me.TxtBoxDFM = New System.Windows.Forms.TextBox()
        Me.TxtBoxDEM = New System.Windows.Forms.TextBox()
        Me.TxtBoxDHM = New System.Windows.Forms.TextBox()
        Me.Sortie = New System.Windows.Forms.TabPage()
        Me.LblSEM = New System.Windows.Forms.Label()
        Me.LblSFM = New System.Windows.Forms.Label()
        Me.LblSHM = New System.Windows.Forms.Label()
        Me.TxtBoxSEM = New System.Windows.Forms.TextBox()
        Me.TxtBoxSFM = New System.Windows.Forms.TextBox()
        Me.TxtBoxSHM = New System.Windows.Forms.TextBox()
        Me.GrpBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBoxMser = New System.Windows.Forms.ComboBox()
        Me.CmbBoxMdep = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.CmbBoxMM = New System.Windows.Forms.ComboBox()
        Me.LblMM = New System.Windows.Forms.Label()
        Me.LblAM = New System.Windows.Forms.Label()
        Me.LblNomMSe = New System.Windows.Forms.Label()
        Me.LblNomM = New System.Windows.Forms.Label()
        Me.BtnVal2 = New System.Windows.Forms.Button()
        Me.PicDash4 = New System.Windows.Forms.PictureBox()
        Me.PicNav4 = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnDashMouv = New System.Windows.Forms.Button()
        Me.TabCntrl3.SuspendLayout()
        Me.Admision.SuspendLayout()
        Me.Transfer.SuspendLayout()
        Me.Décis.SuspendLayout()
        Me.Sortie.SuspendLayout()
        Me.GrpBox2.SuspendLayout()
        CType(Me.PicDash4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNav4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCntrl3
        '
        Me.TabCntrl3.Controls.Add(Me.Admision)
        Me.TabCntrl3.Controls.Add(Me.Transfer)
        Me.TabCntrl3.Controls.Add(Me.Décis)
        Me.TabCntrl3.Controls.Add(Me.Sortie)
        Me.TabCntrl3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCntrl3.ItemSize = New System.Drawing.Size(62, 36)
        Me.TabCntrl3.Location = New System.Drawing.Point(20, 171)
        Me.TabCntrl3.Name = "TabCntrl3"
        Me.TabCntrl3.SelectedIndex = 0
        Me.TabCntrl3.Size = New System.Drawing.Size(621, 242)
        Me.TabCntrl3.TabIndex = 0
        '
        'Admision
        '
        Me.Admision.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Admision.Controls.Add(Me.Label1)
        Me.Admision.Controls.Add(Me.TxtBoxJournee)
        Me.Admision.Controls.Add(Me.LblAEM)
        Me.Admision.Controls.Add(Me.LblAFM)
        Me.Admision.Controls.Add(Me.LblAHM)
        Me.Admision.Controls.Add(Me.TxtBoxAEM)
        Me.Admision.Controls.Add(Me.TxtBoxAHM)
        Me.Admision.Controls.Add(Me.TxtBoxAFM)
        Me.Admision.Location = New System.Drawing.Point(4, 40)
        Me.Admision.Name = "Admision"
        Me.Admision.Padding = New System.Windows.Forms.Padding(3)
        Me.Admision.Size = New System.Drawing.Size(613, 198)
        Me.Admision.TabIndex = 0
        Me.Admision.Text = "Admission"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Journée :"
        '
        'TxtBoxJournee
        '
        Me.TxtBoxJournee.Location = New System.Drawing.Point(203, 145)
        Me.TxtBoxJournee.Name = "TxtBoxJournee"
        Me.TxtBoxJournee.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxJournee.TabIndex = 6
        '
        'LblAEM
        '
        Me.LblAEM.AutoSize = True
        Me.LblAEM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAEM.Location = New System.Drawing.Point(49, 105)
        Me.LblAEM.Name = "LblAEM"
        Me.LblAEM.Size = New System.Drawing.Size(73, 21)
        Me.LblAEM.TabIndex = 5
        Me.LblAEM.Text = "Enfant    :"
        '
        'LblAFM
        '
        Me.LblAFM.AutoSize = True
        Me.LblAFM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAFM.Location = New System.Drawing.Point(49, 64)
        Me.LblAFM.Name = "LblAFM"
        Me.LblAFM.Size = New System.Drawing.Size(73, 21)
        Me.LblAFM.TabIndex = 4
        Me.LblAFM.Text = "Femme  :"
        '
        'LblAHM
        '
        Me.LblAHM.AutoSize = True
        Me.LblAHM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAHM.Location = New System.Drawing.Point(49, 20)
        Me.LblAHM.Name = "LblAHM"
        Me.LblAHM.Size = New System.Drawing.Size(73, 21)
        Me.LblAHM.TabIndex = 3
        Me.LblAHM.Text = "Homme :"
        '
        'TxtBoxAEM
        '
        Me.TxtBoxAEM.Location = New System.Drawing.Point(203, 101)
        Me.TxtBoxAEM.Name = "TxtBoxAEM"
        Me.TxtBoxAEM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxAEM.TabIndex = 2
        '
        'TxtBoxAHM
        '
        Me.TxtBoxAHM.Location = New System.Drawing.Point(203, 14)
        Me.TxtBoxAHM.Name = "TxtBoxAHM"
        Me.TxtBoxAHM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxAHM.TabIndex = 1
        '
        'TxtBoxAFM
        '
        Me.TxtBoxAFM.Location = New System.Drawing.Point(203, 58)
        Me.TxtBoxAFM.Name = "TxtBoxAFM"
        Me.TxtBoxAFM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxAFM.TabIndex = 0
        '
        'Transfer
        '
        Me.Transfer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Transfer.Controls.Add(Me.LblTEM)
        Me.Transfer.Controls.Add(Me.LblTFM)
        Me.Transfer.Controls.Add(Me.LblTHM)
        Me.Transfer.Controls.Add(Me.TxtBoxTEM)
        Me.Transfer.Controls.Add(Me.TxtBoxTFM)
        Me.Transfer.Controls.Add(Me.TxtBoxTHM)
        Me.Transfer.Location = New System.Drawing.Point(4, 40)
        Me.Transfer.Name = "Transfer"
        Me.Transfer.Padding = New System.Windows.Forms.Padding(3)
        Me.Transfer.Size = New System.Drawing.Size(613, 198)
        Me.Transfer.TabIndex = 1
        Me.Transfer.Text = "Transfer"
        '
        'LblTEM
        '
        Me.LblTEM.AutoSize = True
        Me.LblTEM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTEM.Location = New System.Drawing.Point(49, 127)
        Me.LblTEM.Name = "LblTEM"
        Me.LblTEM.Size = New System.Drawing.Size(73, 21)
        Me.LblTEM.TabIndex = 5
        Me.LblTEM.Text = "Enfant    :"
        '
        'LblTFM
        '
        Me.LblTFM.AutoSize = True
        Me.LblTFM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTFM.Location = New System.Drawing.Point(49, 79)
        Me.LblTFM.Name = "LblTFM"
        Me.LblTFM.Size = New System.Drawing.Size(73, 21)
        Me.LblTFM.TabIndex = 4
        Me.LblTFM.Text = "Femme  :"
        '
        'LblTHM
        '
        Me.LblTHM.AutoSize = True
        Me.LblTHM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTHM.Location = New System.Drawing.Point(49, 29)
        Me.LblTHM.Name = "LblTHM"
        Me.LblTHM.Size = New System.Drawing.Size(73, 21)
        Me.LblTHM.TabIndex = 3
        Me.LblTHM.Text = "Homme :"
        '
        'TxtBoxTEM
        '
        Me.TxtBoxTEM.Location = New System.Drawing.Point(203, 121)
        Me.TxtBoxTEM.Name = "TxtBoxTEM"
        Me.TxtBoxTEM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxTEM.TabIndex = 2
        '
        'TxtBoxTFM
        '
        Me.TxtBoxTFM.Location = New System.Drawing.Point(203, 73)
        Me.TxtBoxTFM.Name = "TxtBoxTFM"
        Me.TxtBoxTFM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxTFM.TabIndex = 1
        '
        'TxtBoxTHM
        '
        Me.TxtBoxTHM.Location = New System.Drawing.Point(203, 24)
        Me.TxtBoxTHM.Name = "TxtBoxTHM"
        Me.TxtBoxTHM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxTHM.TabIndex = 0
        '
        'Décis
        '
        Me.Décis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Décis.Controls.Add(Me.LblDEM)
        Me.Décis.Controls.Add(Me.LblDFM)
        Me.Décis.Controls.Add(Me.LblDHM)
        Me.Décis.Controls.Add(Me.TxtBoxDFM)
        Me.Décis.Controls.Add(Me.TxtBoxDEM)
        Me.Décis.Controls.Add(Me.TxtBoxDHM)
        Me.Décis.Location = New System.Drawing.Point(4, 40)
        Me.Décis.Name = "Décis"
        Me.Décis.Size = New System.Drawing.Size(613, 198)
        Me.Décis.TabIndex = 2
        Me.Décis.Text = "Décis"
        '
        'LblDEM
        '
        Me.LblDEM.AutoSize = True
        Me.LblDEM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDEM.Location = New System.Drawing.Point(49, 127)
        Me.LblDEM.Name = "LblDEM"
        Me.LblDEM.Size = New System.Drawing.Size(73, 21)
        Me.LblDEM.TabIndex = 5
        Me.LblDEM.Text = "Enfant    :"
        '
        'LblDFM
        '
        Me.LblDFM.AutoSize = True
        Me.LblDFM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDFM.Location = New System.Drawing.Point(49, 79)
        Me.LblDFM.Name = "LblDFM"
        Me.LblDFM.Size = New System.Drawing.Size(73, 21)
        Me.LblDFM.TabIndex = 4
        Me.LblDFM.Text = "Femme  :"
        '
        'LblDHM
        '
        Me.LblDHM.AutoSize = True
        Me.LblDHM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDHM.Location = New System.Drawing.Point(49, 29)
        Me.LblDHM.Name = "LblDHM"
        Me.LblDHM.Size = New System.Drawing.Size(73, 21)
        Me.LblDHM.TabIndex = 3
        Me.LblDHM.Text = "Homme :"
        '
        'TxtBoxDFM
        '
        Me.TxtBoxDFM.Location = New System.Drawing.Point(203, 73)
        Me.TxtBoxDFM.Name = "TxtBoxDFM"
        Me.TxtBoxDFM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxDFM.TabIndex = 2
        '
        'TxtBoxDEM
        '
        Me.TxtBoxDEM.Location = New System.Drawing.Point(203, 121)
        Me.TxtBoxDEM.Name = "TxtBoxDEM"
        Me.TxtBoxDEM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxDEM.TabIndex = 1
        '
        'TxtBoxDHM
        '
        Me.TxtBoxDHM.Location = New System.Drawing.Point(203, 24)
        Me.TxtBoxDHM.Name = "TxtBoxDHM"
        Me.TxtBoxDHM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxDHM.TabIndex = 0
        '
        'Sortie
        '
        Me.Sortie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Sortie.Controls.Add(Me.LblSEM)
        Me.Sortie.Controls.Add(Me.LblSFM)
        Me.Sortie.Controls.Add(Me.LblSHM)
        Me.Sortie.Controls.Add(Me.TxtBoxSEM)
        Me.Sortie.Controls.Add(Me.TxtBoxSFM)
        Me.Sortie.Controls.Add(Me.TxtBoxSHM)
        Me.Sortie.Location = New System.Drawing.Point(4, 40)
        Me.Sortie.Name = "Sortie"
        Me.Sortie.Size = New System.Drawing.Size(613, 198)
        Me.Sortie.TabIndex = 3
        Me.Sortie.Text = "Sortie"
        '
        'LblSEM
        '
        Me.LblSEM.AutoSize = True
        Me.LblSEM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSEM.Location = New System.Drawing.Point(49, 127)
        Me.LblSEM.Name = "LblSEM"
        Me.LblSEM.Size = New System.Drawing.Size(73, 21)
        Me.LblSEM.TabIndex = 5
        Me.LblSEM.Text = "Enfant    :"
        '
        'LblSFM
        '
        Me.LblSFM.AutoSize = True
        Me.LblSFM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSFM.Location = New System.Drawing.Point(49, 79)
        Me.LblSFM.Name = "LblSFM"
        Me.LblSFM.Size = New System.Drawing.Size(73, 21)
        Me.LblSFM.TabIndex = 4
        Me.LblSFM.Text = "Femme  :"
        '
        'LblSHM
        '
        Me.LblSHM.AutoSize = True
        Me.LblSHM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSHM.Location = New System.Drawing.Point(49, 29)
        Me.LblSHM.Name = "LblSHM"
        Me.LblSHM.Size = New System.Drawing.Size(73, 21)
        Me.LblSHM.TabIndex = 3
        Me.LblSHM.Text = "Homme :"
        '
        'TxtBoxSEM
        '
        Me.TxtBoxSEM.Location = New System.Drawing.Point(203, 121)
        Me.TxtBoxSEM.Name = "TxtBoxSEM"
        Me.TxtBoxSEM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxSEM.TabIndex = 2
        '
        'TxtBoxSFM
        '
        Me.TxtBoxSFM.Location = New System.Drawing.Point(203, 73)
        Me.TxtBoxSFM.Name = "TxtBoxSFM"
        Me.TxtBoxSFM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxSFM.TabIndex = 1
        '
        'TxtBoxSHM
        '
        Me.TxtBoxSHM.Location = New System.Drawing.Point(203, 24)
        Me.TxtBoxSHM.Name = "TxtBoxSHM"
        Me.TxtBoxSHM.Size = New System.Drawing.Size(160, 32)
        Me.TxtBoxSHM.TabIndex = 0
        '
        'GrpBox2
        '
        Me.GrpBox2.Controls.Add(Me.CmbBoxMser)
        Me.GrpBox2.Controls.Add(Me.CmbBoxMdep)
        Me.GrpBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GrpBox2.Controls.Add(Me.CmbBoxMM)
        Me.GrpBox2.Controls.Add(Me.LblMM)
        Me.GrpBox2.Controls.Add(Me.LblAM)
        Me.GrpBox2.Controls.Add(Me.LblNomMSe)
        Me.GrpBox2.Controls.Add(Me.LblNomM)
        Me.GrpBox2.Controls.Add(Me.BtnVal2)
        Me.GrpBox2.Controls.Add(Me.TabCntrl3)
        Me.GrpBox2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBox2.ForeColor = System.Drawing.Color.Black
        Me.GrpBox2.Location = New System.Drawing.Point(231, 58)
        Me.GrpBox2.Name = "GrpBox2"
        Me.GrpBox2.Size = New System.Drawing.Size(671, 464)
        Me.GrpBox2.TabIndex = 1
        Me.GrpBox2.TabStop = False
        Me.GrpBox2.Text = "Gestion Des Mouvements"
        '
        'CmbBoxMser
        '
        Me.CmbBoxMser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMser.FormattingEnabled = True
        Me.CmbBoxMser.Location = New System.Drawing.Point(356, 74)
        Me.CmbBoxMser.Name = "CmbBoxMser"
        Me.CmbBoxMser.Size = New System.Drawing.Size(281, 35)
        Me.CmbBoxMser.TabIndex = 11
        '
        'CmbBoxMdep
        '
        Me.CmbBoxMdep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMdep.FormattingEnabled = True
        Me.CmbBoxMdep.Location = New System.Drawing.Point(356, 28)
        Me.CmbBoxMdep.Name = "CmbBoxMdep"
        Me.CmbBoxMdep.Size = New System.Drawing.Size(281, 35)
        Me.CmbBoxMdep.TabIndex = 10
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(118, 122)
        Me.MaskedTextBox2.Mask = "0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 35)
        Me.MaskedTextBox2.TabIndex = 9
        '
        'CmbBoxMM
        '
        Me.CmbBoxMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMM.FormattingEnabled = True
        Me.CmbBoxMM.Items.AddRange(New Object() {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"})
        Me.CmbBoxMM.Location = New System.Drawing.Point(440, 122)
        Me.CmbBoxMM.Name = "CmbBoxMM"
        Me.CmbBoxMM.Size = New System.Drawing.Size(197, 35)
        Me.CmbBoxMM.TabIndex = 8
        '
        'LblMM
        '
        Me.LblMM.AutoSize = True
        Me.LblMM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMM.Location = New System.Drawing.Point(285, 131)
        Me.LblMM.Name = "LblMM"
        Me.LblMM.Size = New System.Drawing.Size(51, 21)
        Me.LblMM.TabIndex = 5
        Me.LblMM.Text = "Mois :"
        '
        'LblAM
        '
        Me.LblAM.AutoSize = True
        Me.LblAM.BackColor = System.Drawing.SystemColors.Control
        Me.LblAM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAM.Location = New System.Drawing.Point(16, 132)
        Me.LblAM.Name = "LblAM"
        Me.LblAM.Size = New System.Drawing.Size(61, 21)
        Me.LblAM.TabIndex = 4
        Me.LblAM.Text = "Année :"
        '
        'LblNomMSe
        '
        Me.LblNomMSe.AutoSize = True
        Me.LblNomMSe.BackColor = System.Drawing.SystemColors.Control
        Me.LblNomMSe.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomMSe.Location = New System.Drawing.Point(16, 81)
        Me.LblNomMSe.Name = "LblNomMSe"
        Me.LblNomMSe.Size = New System.Drawing.Size(129, 21)
        Me.LblNomMSe.TabIndex = 3
        Me.LblNomMSe.Text = "Nom De Service :"
        '
        'LblNomM
        '
        Me.LblNomM.AutoSize = True
        Me.LblNomM.BackColor = System.Drawing.SystemColors.Control
        Me.LblNomM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomM.Location = New System.Drawing.Point(16, 35)
        Me.LblNomM.Name = "LblNomM"
        Me.LblNomM.Size = New System.Drawing.Size(170, 21)
        Me.LblNomM.TabIndex = 2
        Me.LblNomM.Text = "Nom De Departement :"
        '
        'BtnVal2
        '
        Me.BtnVal2.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnVal2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BtnVal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVal2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnVal2.Location = New System.Drawing.Point(545, 419)
        Me.BtnVal2.Name = "BtnVal2"
        Me.BtnVal2.Size = New System.Drawing.Size(96, 34)
        Me.BtnVal2.TabIndex = 1
        Me.BtnVal2.Text = "Valider"
        Me.BtnVal2.UseVisualStyleBackColor = False
        '
        'PicDash4
        '
        Me.PicDash4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PicDash4.Location = New System.Drawing.Point(1, 42)
        Me.PicDash4.Name = "PicDash4"
        Me.PicDash4.Size = New System.Drawing.Size(207, 491)
        Me.PicDash4.TabIndex = 2
        Me.PicDash4.TabStop = False
        '
        'PicNav4
        '
        Me.PicNav4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PicNav4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicNav4.Location = New System.Drawing.Point(0, 0)
        Me.PicNav4.Name = "PicNav4"
        Me.PicNav4.Size = New System.Drawing.Size(925, 43)
        Me.PicNav4.TabIndex = 3
        Me.PicNav4.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTitle.Location = New System.Drawing.Point(19, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(259, 24)
        Me.LblTitle.TabIndex = 4
        Me.LblTitle.Text = "Hospital Management System"
        '
        'BtnDashMouv
        '
        Me.BtnDashMouv.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashMouv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashMouv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashMouv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashMouv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashMouv.Location = New System.Drawing.Point(1, 171)
        Me.BtnDashMouv.Name = "BtnDashMouv"
        Me.BtnDashMouv.Size = New System.Drawing.Size(206, 36)
        Me.BtnDashMouv.TabIndex = 5
        Me.BtnDashMouv.Text = "Dashboard"
        Me.BtnDashMouv.UseVisualStyleBackColor = False
        '
        'Mouvement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 534)
        Me.Controls.Add(Me.BtnDashMouv)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PicNav4)
        Me.Controls.Add(Me.PicDash4)
        Me.Controls.Add(Me.GrpBox2)
        Me.Name = "Mouvement"
        Me.Text = "Mouvement"
        Me.TabCntrl3.ResumeLayout(False)
        Me.Admision.ResumeLayout(False)
        Me.Admision.PerformLayout()
        Me.Transfer.ResumeLayout(False)
        Me.Transfer.PerformLayout()
        Me.Décis.ResumeLayout(False)
        Me.Décis.PerformLayout()
        Me.Sortie.ResumeLayout(False)
        Me.Sortie.PerformLayout()
        Me.GrpBox2.ResumeLayout(False)
        Me.GrpBox2.PerformLayout()
        CType(Me.PicDash4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNav4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabCntrl3 As TabControl
    Friend WithEvents Admision As TabPage
    Friend WithEvents Transfer As TabPage
    Friend WithEvents Décis As TabPage
    Friend WithEvents Sortie As TabPage
    Friend WithEvents GrpBox2 As GroupBox
    Friend WithEvents BtnVal2 As Button
    Friend WithEvents PicDash4 As PictureBox
    Friend WithEvents PicNav4 As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnDashMouv As Button
    Friend WithEvents LblMM As Label
    Friend WithEvents LblAM As Label
    Friend WithEvents LblNomMSe As Label
    Friend WithEvents LblNomM As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents CmbBoxMM As ComboBox
    Friend WithEvents CmbBoxMdep As ComboBox
    Friend WithEvents CmbBoxMser As ComboBox
    Friend WithEvents TxtBoxDEM As TextBox
    Friend WithEvents TxtBoxDHM As TextBox
    Friend WithEvents TxtBoxSEM As TextBox
    Friend WithEvents TxtBoxSFM As TextBox
    Friend WithEvents TxtBoxSHM As TextBox
    Friend WithEvents TxtBoxAEM As TextBox
    Friend WithEvents TxtBoxAHM As TextBox
    Friend WithEvents TxtBoxAFM As TextBox
    Friend WithEvents TxtBoxTEM As TextBox
    Friend WithEvents TxtBoxTFM As TextBox
    Friend WithEvents TxtBoxTHM As TextBox
    Friend WithEvents TxtBoxDFM As TextBox
    Friend WithEvents LblAEM As Label
    Friend WithEvents LblAFM As Label
    Friend WithEvents LblAHM As Label
    Friend WithEvents LblTEM As Label
    Friend WithEvents LblTFM As Label
    Friend WithEvents LblTHM As Label
    Friend WithEvents LblDEM As Label
    Friend WithEvents LblDFM As Label
    Friend WithEvents LblDHM As Label
    Friend WithEvents LblSEM As Label
    Friend WithEvents LblSFM As Label
    Friend WithEvents LblSHM As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxJournee As TextBox
End Class
