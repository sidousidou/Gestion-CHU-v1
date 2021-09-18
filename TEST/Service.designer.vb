<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Service
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicDashBoard3 = New System.Windows.Forms.PictureBox()
        Me.BtnDashboard3 = New System.Windows.Forms.Button()
        Me.TabCtrlSerM = New System.Windows.Forms.TabControl()
        Me.TabSerList = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDep1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.TabSerAdd = New System.Windows.Forms.TabPage()
        Me.cbDepartement = New System.Windows.Forms.ComboBox()
        Me.LblNdep = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtNomService = New System.Windows.Forms.TextBox()
        Me.TxtNbrLits = New System.Windows.Forms.TextBox()
        Me.LblNomService = New System.Windows.Forms.Label()
        Me.LblNbrLits = New System.Windows.Forms.Label()
        Me.PicBoxTitle2 = New System.Windows.Forms.PictureBox()
        Me.PicBoxInfo2 = New System.Windows.Forms.PictureBox()
        Me.LabTitleSer = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDashBoard3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCtrlSerM.SuspendLayout()
        Me.TabSerList.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSerAdd.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hospital Management System"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(925, 43)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PicDashBoard3
        '
        Me.PicDashBoard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PicDashBoard3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicDashBoard3.Location = New System.Drawing.Point(0, 43)
        Me.PicDashBoard3.Name = "PicDashBoard3"
        Me.PicDashBoard3.Size = New System.Drawing.Size(207, 491)
        Me.PicDashBoard3.TabIndex = 13
        Me.PicDashBoard3.TabStop = False
        '
        'BtnDashboard3
        '
        Me.BtnDashboard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboard3.Location = New System.Drawing.Point(0, 171)
        Me.BtnDashboard3.Name = "BtnDashboard3"
        Me.BtnDashboard3.Size = New System.Drawing.Size(207, 36)
        Me.BtnDashboard3.TabIndex = 14
        Me.BtnDashboard3.Text = "Dashboard"
        Me.BtnDashboard3.UseVisualStyleBackColor = False
        '
        'TabCtrlSerM
        '
        Me.TabCtrlSerM.Controls.Add(Me.TabSerList)
        Me.TabCtrlSerM.Controls.Add(Me.TabSerAdd)
        Me.TabCtrlSerM.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.TabCtrlSerM.ItemSize = New System.Drawing.Size(62, 36)
        Me.TabCtrlSerM.Location = New System.Drawing.Point(249, 140)
        Me.TabCtrlSerM.Name = "TabCtrlSerM"
        Me.TabCtrlSerM.SelectedIndex = 0
        Me.TabCtrlSerM.Size = New System.Drawing.Size(639, 358)
        Me.TabCtrlSerM.TabIndex = 17
        '
        'TabSerList
        '
        Me.TabSerList.BackColor = System.Drawing.Color.Transparent
        Me.TabSerList.Controls.Add(Me.Label3)
        Me.TabSerList.Controls.Add(Me.cbDep1)
        Me.TabSerList.Controls.Add(Me.DataGridView2)
        Me.TabSerList.Controls.Add(Me.BtnUpdate)
        Me.TabSerList.Controls.Add(Me.BtnDel)
        Me.TabSerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSerList.ForeColor = System.Drawing.Color.Black
        Me.TabSerList.Location = New System.Drawing.Point(4, 40)
        Me.TabSerList.Name = "TabSerList"
        Me.TabSerList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSerList.Size = New System.Drawing.Size(631, 314)
        Me.TabSerList.TabIndex = 0
        Me.TabSerList.Text = "Liste Des Services"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Choisis Nom Departement :"
        '
        'cbDep1
        '
        Me.cbDep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDep1.ForeColor = System.Drawing.Color.Black
        Me.cbDep1.FormattingEnabled = True
        Me.cbDep1.Location = New System.Drawing.Point(369, 23)
        Me.cbDep1.Name = "cbDep1"
        Me.cbDep1.Size = New System.Drawing.Size(170, 28)
        Me.cbDep1.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(20, 64)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(519, 170)
        Me.DataGridView2.TabIndex = 11
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnUpdate.Location = New System.Drawing.Point(160, 255)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 38)
        Me.BtnUpdate.TabIndex = 10
        Me.BtnUpdate.Text = "Modifer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDel.Location = New System.Drawing.Point(20, 255)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(130, 38)
        Me.BtnDel.TabIndex = 9
        Me.BtnDel.Text = "Supprimer"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'TabSerAdd
        '
        Me.TabSerAdd.Controls.Add(Me.cbDepartement)
        Me.TabSerAdd.Controls.Add(Me.LblNdep)
        Me.TabSerAdd.Controls.Add(Me.BtnAdd)
        Me.TabSerAdd.Controls.Add(Me.PictureBox1)
        Me.TabSerAdd.Controls.Add(Me.TxtNomService)
        Me.TabSerAdd.Controls.Add(Me.TxtNbrLits)
        Me.TabSerAdd.Controls.Add(Me.LblNomService)
        Me.TabSerAdd.Controls.Add(Me.LblNbrLits)
        Me.TabSerAdd.ForeColor = System.Drawing.Color.Black
        Me.TabSerAdd.Location = New System.Drawing.Point(4, 40)
        Me.TabSerAdd.Name = "TabSerAdd"
        Me.TabSerAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSerAdd.Size = New System.Drawing.Size(631, 314)
        Me.TabSerAdd.TabIndex = 1
        Me.TabSerAdd.Text = "Ajouter Service"
        Me.TabSerAdd.UseVisualStyleBackColor = True
        '
        'cbDepartement
        '
        Me.cbDepartement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbDepartement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartement.FormattingEnabled = True
        Me.cbDepartement.Location = New System.Drawing.Point(212, 120)
        Me.cbDepartement.Name = "cbDepartement"
        Me.cbDepartement.Size = New System.Drawing.Size(280, 33)
        Me.cbDepartement.TabIndex = 12
        '
        'LblNdep
        '
        Me.LblNdep.AutoSize = True
        Me.LblNdep.Location = New System.Drawing.Point(23, 120)
        Me.LblNdep.Name = "LblNdep"
        Me.LblNdep.Size = New System.Drawing.Size(129, 25)
        Me.LblNdep.TabIndex = 11
        Me.LblNdep.Text = "departement :"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAdd.Location = New System.Drawing.Point(50, 243)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 38)
        Me.BtnAdd.TabIndex = 10
        Me.BtnAdd.Text = "Ajouter"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 89)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TxtNomService
        '
        Me.TxtNomService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomService.Location = New System.Drawing.Point(212, 31)
        Me.TxtNomService.Name = "TxtNomService"
        Me.TxtNomService.Size = New System.Drawing.Size(280, 26)
        Me.TxtNomService.TabIndex = 7
        '
        'TxtNbrLits
        '
        Me.TxtNbrLits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNbrLits.Location = New System.Drawing.Point(212, 74)
        Me.TxtNbrLits.Name = "TxtNbrLits"
        Me.TxtNbrLits.Size = New System.Drawing.Size(280, 26)
        Me.TxtNbrLits.TabIndex = 8
        '
        'LblNomService
        '
        Me.LblNomService.AutoSize = True
        Me.LblNomService.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblNomService.ForeColor = System.Drawing.Color.Black
        Me.LblNomService.Location = New System.Drawing.Point(23, 33)
        Me.LblNomService.Name = "LblNomService"
        Me.LblNomService.Size = New System.Drawing.Size(155, 25)
        Me.LblNomService.TabIndex = 5
        Me.LblNomService.Text = "Nom De Service :"
        '
        'LblNbrLits
        '
        Me.LblNbrLits.AutoSize = True
        Me.LblNbrLits.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.LblNbrLits.ForeColor = System.Drawing.Color.Black
        Me.LblNbrLits.Location = New System.Drawing.Point(23, 74)
        Me.LblNbrLits.Name = "LblNbrLits"
        Me.LblNbrLits.Size = New System.Drawing.Size(122, 25)
        Me.LblNbrLits.TabIndex = 6
        Me.LblNbrLits.Text = "Nbr Des Lits :"
        '
        'PicBoxTitle2
        '
        Me.PicBoxTitle2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicBoxTitle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicBoxTitle2.Location = New System.Drawing.Point(207, 43)
        Me.PicBoxTitle2.Name = "PicBoxTitle2"
        Me.PicBoxTitle2.Size = New System.Drawing.Size(718, 50)
        Me.PicBoxTitle2.TabIndex = 18
        Me.PicBoxTitle2.TabStop = False
        '
        'PicBoxInfo2
        '
        Me.PicBoxInfo2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicBoxInfo2.BackgroundImage = CType(resources.GetObject("PicBoxInfo2.BackgroundImage"), System.Drawing.Image)
        Me.PicBoxInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicBoxInfo2.Location = New System.Drawing.Point(228, 52)
        Me.PicBoxInfo2.Name = "PicBoxInfo2"
        Me.PicBoxInfo2.Size = New System.Drawing.Size(32, 33)
        Me.PicBoxInfo2.TabIndex = 19
        Me.PicBoxInfo2.TabStop = False
        '
        'LabTitleSer
        '
        Me.LabTitleSer.AutoSize = True
        Me.LabTitleSer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabTitleSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabTitleSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTitleSer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabTitleSer.Location = New System.Drawing.Point(280, 58)
        Me.LabTitleSer.Name = "LabTitleSer"
        Me.LabTitleSer.Size = New System.Drawing.Size(189, 24)
        Me.LabTitleSer.TabIndex = 20
        Me.LabTitleSer.Text = "Gestion Des Services"
        '
        'BackgroundWorker1
        '
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 534)
        Me.Controls.Add(Me.LabTitleSer)
        Me.Controls.Add(Me.PicBoxInfo2)
        Me.Controls.Add(Me.PicBoxTitle2)
        Me.Controls.Add(Me.TabCtrlSerM)
        Me.Controls.Add(Me.BtnDashboard3)
        Me.Controls.Add(Me.PicDashBoard3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Service"
        Me.Text = "Service"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDashBoard3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCtrlSerM.ResumeLayout(False)
        Me.TabSerList.ResumeLayout(False)
        Me.TabSerList.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSerAdd.ResumeLayout(False)
        Me.TabSerAdd.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxTitle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PicDashBoard3 As PictureBox
    Friend WithEvents BtnDashboard3 As Button
    Friend WithEvents TabCtrlSerM As TabControl
    Friend WithEvents TabSerList As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents TabSerAdd As TabPage
    Friend WithEvents cbDepartement As ComboBox
    Friend WithEvents LblNdep As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtNomService As TextBox
    Friend WithEvents TxtNbrLits As TextBox
    Friend WithEvents LblNomService As Label
    Friend WithEvents LblNbrLits As Label
    Friend WithEvents PicBoxTitle2 As PictureBox
    Friend WithEvents PicBoxInfo2 As PictureBox
    Friend WithEvents LabTitleSer As Label
    Friend WithEvents cbDep1 As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
