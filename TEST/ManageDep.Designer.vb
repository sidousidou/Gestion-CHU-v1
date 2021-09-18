<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDep))
        Me.PicBoxNavBar = New System.Windows.Forms.PictureBox()
        Me.PicBoxDashboard = New System.Windows.Forms.PictureBox()
        Me.BtnDashboard2 = New System.Windows.Forms.Button()
        Me.TabCtrlAddDep = New System.Windows.Forms.TabControl()
        Me.TabPaDepList = New System.Windows.Forms.TabPage()
        Me.BtnModf = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPaAddDep = New System.Windows.Forms.TabPage()
        Me.BtnaAddDep = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblDepAdd = New System.Windows.Forms.Label()
        Me.TxtBoxDepName = New System.Windows.Forms.TextBox()
        Me.PicBoxTitle = New System.Windows.Forms.PictureBox()
        Me.LblTitleDep = New System.Windows.Forms.Label()
        Me.PicBoxInfo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSerDep = New System.Windows.Forms.Button()
        CType(Me.PicBoxNavBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCtrlAddDep.SuspendLayout()
        Me.TabPaDepList.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPaAddDep.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBoxNavBar
        '
        Me.PicBoxNavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PicBoxNavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicBoxNavBar.Location = New System.Drawing.Point(0, 0)
        Me.PicBoxNavBar.Name = "PicBoxNavBar"
        Me.PicBoxNavBar.Size = New System.Drawing.Size(925, 43)
        Me.PicBoxNavBar.TabIndex = 2
        Me.PicBoxNavBar.TabStop = False
        '
        'PicBoxDashboard
        '
        Me.PicBoxDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PicBoxDashboard.Location = New System.Drawing.Point(0, 43)
        Me.PicBoxDashboard.Name = "PicBoxDashboard"
        Me.PicBoxDashboard.Size = New System.Drawing.Size(207, 493)
        Me.PicBoxDashboard.TabIndex = 3
        Me.PicBoxDashboard.TabStop = False
        '
        'BtnDashboard2
        '
        Me.BtnDashboard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDashboard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboard2.Location = New System.Drawing.Point(0, 171)
        Me.BtnDashboard2.Name = "BtnDashboard2"
        Me.BtnDashboard2.Size = New System.Drawing.Size(207, 36)
        Me.BtnDashboard2.TabIndex = 15
        Me.BtnDashboard2.Text = "Dashboard"
        Me.BtnDashboard2.UseVisualStyleBackColor = False
        '
        'TabCtrlAddDep
        '
        Me.TabCtrlAddDep.Controls.Add(Me.TabPaDepList)
        Me.TabCtrlAddDep.Controls.Add(Me.TabPaAddDep)
        Me.TabCtrlAddDep.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!)
        Me.TabCtrlAddDep.ItemSize = New System.Drawing.Size(62, 36)
        Me.TabCtrlAddDep.Location = New System.Drawing.Point(278, 171)
        Me.TabCtrlAddDep.Name = "TabCtrlAddDep"
        Me.TabCtrlAddDep.SelectedIndex = 0
        Me.TabCtrlAddDep.Size = New System.Drawing.Size(619, 323)
        Me.TabCtrlAddDep.TabIndex = 16
        '
        'TabPaDepList
        '
        Me.TabPaDepList.Controls.Add(Me.BtnModf)
        Me.TabPaDepList.Controls.Add(Me.BtnDel)
        Me.TabPaDepList.Controls.Add(Me.DataGridView3)
        Me.TabPaDepList.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPaDepList.ForeColor = System.Drawing.Color.Black
        Me.TabPaDepList.Location = New System.Drawing.Point(4, 40)
        Me.TabPaDepList.Name = "TabPaDepList"
        Me.TabPaDepList.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPaDepList.Size = New System.Drawing.Size(611, 279)
        Me.TabPaDepList.TabIndex = 0
        Me.TabPaDepList.Text = "Liste de Depatement"
        Me.TabPaDepList.UseVisualStyleBackColor = True
        '
        'BtnModf
        '
        Me.BtnModf.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnModf.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnModf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModf.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnModf.Location = New System.Drawing.Point(166, 229)
        Me.BtnModf.Name = "BtnModf"
        Me.BtnModf.Size = New System.Drawing.Size(130, 38)
        Me.BtnModf.TabIndex = 2
        Me.BtnModf.Text = "Modifer"
        Me.BtnModf.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDel.Location = New System.Drawing.Point(20, 229)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(130, 38)
        Me.BtnDel.TabIndex = 1
        Me.BtnDel.Text = "Supprimer"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(20, 45)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(543, 170)
        Me.DataGridView3.TabIndex = 0
        '
        'TabPaAddDep
        '
        Me.TabPaAddDep.Controls.Add(Me.BtnaAddDep)
        Me.TabPaAddDep.Controls.Add(Me.PictureBox1)
        Me.TabPaAddDep.Controls.Add(Me.LblDepAdd)
        Me.TabPaAddDep.Controls.Add(Me.TxtBoxDepName)
        Me.TabPaAddDep.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPaAddDep.ForeColor = System.Drawing.Color.Black
        Me.TabPaAddDep.Location = New System.Drawing.Point(4, 40)
        Me.TabPaAddDep.Name = "TabPaAddDep"
        Me.TabPaAddDep.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPaAddDep.Size = New System.Drawing.Size(611, 279)
        Me.TabPaAddDep.TabIndex = 1
        Me.TabPaAddDep.Text = "Ajouter Departement"
        Me.TabPaAddDep.UseVisualStyleBackColor = True
        '
        'BtnaAddDep
        '
        Me.BtnaAddDep.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnaAddDep.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnaAddDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnaAddDep.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnaAddDep.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnaAddDep.Location = New System.Drawing.Point(71, 213)
        Me.BtnaAddDep.Name = "BtnaAddDep"
        Me.BtnaAddDep.Size = New System.Drawing.Size(109, 34)
        Me.BtnaAddDep.TabIndex = 4
        Me.BtnaAddDep.Text = "Ajouter"
        Me.BtnaAddDep.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(605, 89)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LblDepAdd
        '
        Me.LblDepAdd.AutoSize = True
        Me.LblDepAdd.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepAdd.Location = New System.Drawing.Point(31, 86)
        Me.LblDepAdd.Name = "LblDepAdd"
        Me.LblDepAdd.Size = New System.Drawing.Size(136, 25)
        Me.LblDepAdd.TabIndex = 1
        Me.LblDepAdd.Text = "Departement : "
        '
        'TxtBoxDepName
        '
        Me.TxtBoxDepName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxDepName.Location = New System.Drawing.Point(282, 83)
        Me.TxtBoxDepName.Name = "TxtBoxDepName"
        Me.TxtBoxDepName.Size = New System.Drawing.Size(213, 32)
        Me.TxtBoxDepName.TabIndex = 0
        '
        'PicBoxTitle
        '
        Me.PicBoxTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicBoxTitle.Location = New System.Drawing.Point(207, 43)
        Me.PicBoxTitle.Name = "PicBoxTitle"
        Me.PicBoxTitle.Size = New System.Drawing.Size(718, 50)
        Me.PicBoxTitle.TabIndex = 17
        Me.PicBoxTitle.TabStop = False
        '
        'LblTitleDep
        '
        Me.LblTitleDep.AutoSize = True
        Me.LblTitleDep.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTitleDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTitleDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleDep.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblTitleDep.Location = New System.Drawing.Point(280, 58)
        Me.LblTitleDep.Name = "LblTitleDep"
        Me.LblTitleDep.Size = New System.Drawing.Size(225, 24)
        Me.LblTitleDep.TabIndex = 18
        Me.LblTitleDep.Text = "Gestion Des Département"
        '
        'PicBoxInfo
        '
        Me.PicBoxInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicBoxInfo.BackgroundImage = CType(resources.GetObject("PicBoxInfo.BackgroundImage"), System.Drawing.Image)
        Me.PicBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicBoxInfo.Location = New System.Drawing.Point(228, 52)
        Me.PicBoxInfo.Name = "PicBoxInfo"
        Me.PicBoxInfo.Size = New System.Drawing.Size(32, 33)
        Me.PicBoxInfo.TabIndex = 19
        Me.PicBoxInfo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hospital Management System"
        '
        'BtnSerDep
        '
        Me.BtnSerDep.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnSerDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSerDep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnSerDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSerDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSerDep.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSerDep.Location = New System.Drawing.Point(0, 207)
        Me.BtnSerDep.Name = "BtnSerDep"
        Me.BtnSerDep.Size = New System.Drawing.Size(207, 36)
        Me.BtnSerDep.TabIndex = 21
        Me.BtnSerDep.Text = "Service"
        Me.BtnSerDep.UseVisualStyleBackColor = False
        '
        'ManageDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 534)
        Me.Controls.Add(Me.BtnSerDep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxInfo)
        Me.Controls.Add(Me.LblTitleDep)
        Me.Controls.Add(Me.PicBoxTitle)
        Me.Controls.Add(Me.TabCtrlAddDep)
        Me.Controls.Add(Me.BtnDashboard2)
        Me.Controls.Add(Me.PicBoxDashboard)
        Me.Controls.Add(Me.PicBoxNavBar)
        Me.Name = "ManageDep"
        Me.Text = "Manage Departement"
        CType(Me.PicBoxNavBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCtrlAddDep.ResumeLayout(False)
        Me.TabPaDepList.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPaAddDep.ResumeLayout(False)
        Me.TabPaAddDep.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBoxNavBar As PictureBox
    Friend WithEvents PicBoxDashboard As PictureBox
    Friend WithEvents BtnDashboard2 As Button
    Friend WithEvents TabCtrlAddDep As TabControl
    Friend WithEvents TabPaDepList As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TabPaAddDep As TabPage
    Friend WithEvents TxtBoxDepName As TextBox
    Friend WithEvents BtnDel As Button
    Friend WithEvents LblDepAdd As Label
    Friend WithEvents BtnModf As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnaAddDep As Button
    Friend WithEvents PicBoxTitle As PictureBox
    Friend WithEvents LblTitleDep As Label
    Friend WithEvents PicBoxInfo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSerDep As Button
End Class
