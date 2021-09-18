<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pathologie
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.PicBoxSupp = New System.Windows.Forms.PictureBox()
        Me.DtMalade = New System.Windows.Forms.DataGridView()
        Me.LblChoixSer = New System.Windows.Forms.Label()
        Me.CmbPathser = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CmbBoxDepPath = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddPath = New System.Windows.Forms.Button()
        Me.PicBoxPath = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSerPath = New System.Windows.Forms.Label()
        Me.CmbBoxPathSer = New System.Windows.Forms.ComboBox()
        Me.TxtBoxNomPt = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PicBoxSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtMalade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicBoxPath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 36)
        Me.TabControl1.Location = New System.Drawing.Point(20, 24)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(475, 281)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnSupp)
        Me.TabPage1.Controls.Add(Me.PicBoxSupp)
        Me.TabPage1.Controls.Add(Me.DtMalade)
        Me.TabPage1.Controls.Add(Me.LblChoixSer)
        Me.TabPage1.Controls.Add(Me.CmbPathser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(467, 237)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste Des Maladies"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnSupp
        '
        Me.BtnSupp.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSupp.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSupp.Location = New System.Drawing.Point(23, 191)
        Me.BtnSupp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSupp.Name = "BtnSupp"
        Me.BtnSupp.Size = New System.Drawing.Size(108, 31)
        Me.BtnSupp.TabIndex = 4
        Me.BtnSupp.Text = "Supprimer"
        Me.BtnSupp.UseVisualStyleBackColor = False
        '
        'PicBoxSupp
        '
        Me.PicBoxSupp.BackColor = System.Drawing.Color.Gainsboro
        Me.PicBoxSupp.Location = New System.Drawing.Point(0, 181)
        Me.PicBoxSupp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PicBoxSupp.Name = "PicBoxSupp"
        Me.PicBoxSupp.Size = New System.Drawing.Size(458, 52)
        Me.PicBoxSupp.TabIndex = 3
        Me.PicBoxSupp.TabStop = False
        '
        'DtMalade
        '
        Me.DtMalade.AllowUserToAddRows = False
        Me.DtMalade.AllowUserToDeleteRows = False
        Me.DtMalade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtMalade.Location = New System.Drawing.Point(23, 47)
        Me.DtMalade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DtMalade.MultiSelect = False
        Me.DtMalade.Name = "DtMalade"
        Me.DtMalade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtMalade.Size = New System.Drawing.Size(422, 115)
        Me.DtMalade.TabIndex = 2
        '
        'LblChoixSer
        '
        Me.LblChoixSer.AutoSize = True
        Me.LblChoixSer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoixSer.Location = New System.Drawing.Point(60, 13)
        Me.LblChoixSer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblChoixSer.Name = "LblChoixSer"
        Me.LblChoixSer.Size = New System.Drawing.Size(129, 21)
        Me.LblChoixSer.TabIndex = 1
        Me.LblChoixSer.Text = "Nom De Service :"
        '
        'CmbPathser
        '
        Me.CmbPathser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPathser.FormattingEnabled = True
        Me.CmbPathser.Location = New System.Drawing.Point(224, 11)
        Me.CmbPathser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbPathser.Name = "CmbPathser"
        Me.CmbPathser.Size = New System.Drawing.Size(223, 29)
        Me.CmbPathser.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CmbBoxDepPath)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.BtnAddPath)
        Me.TabPage2.Controls.Add(Me.PicBoxPath)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.LblSerPath)
        Me.TabPage2.Controls.Add(Me.CmbBoxPathSer)
        Me.TabPage2.Controls.Add(Me.TxtBoxNomPt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(467, 237)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ajouter Maladie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CmbBoxDepPath
        '
        Me.CmbBoxDepPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxDepPath.FormattingEnabled = True
        Me.CmbBoxDepPath.Location = New System.Drawing.Point(195, 13)
        Me.CmbBoxDepPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbBoxDepPath.Name = "CmbBoxDepPath"
        Me.CmbBoxDepPath.Size = New System.Drawing.Size(200, 29)
        Me.CmbBoxDepPath.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Departement :"
        '
        'BtnAddPath
        '
        Me.BtnAddPath.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAddPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPath.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAddPath.Location = New System.Drawing.Point(32, 187)
        Me.BtnAddPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAddPath.Name = "BtnAddPath"
        Me.BtnAddPath.Size = New System.Drawing.Size(78, 37)
        Me.BtnAddPath.TabIndex = 5
        Me.BtnAddPath.Text = "Ajouter"
        Me.BtnAddPath.UseVisualStyleBackColor = False
        '
        'PicBoxPath
        '
        Me.PicBoxPath.BackColor = System.Drawing.Color.Gainsboro
        Me.PicBoxPath.Location = New System.Drawing.Point(5, 179)
        Me.PicBoxPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PicBoxPath.Name = "PicBoxPath"
        Me.PicBoxPath.Size = New System.Drawing.Size(458, 54)
        Me.PicBoxPath.TabIndex = 4
        Me.PicBoxPath.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom De Maladie :"
        '
        'LblSerPath
        '
        Me.LblSerPath.AutoSize = True
        Me.LblSerPath.Location = New System.Drawing.Point(28, 50)
        Me.LblSerPath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSerPath.Name = "LblSerPath"
        Me.LblSerPath.Size = New System.Drawing.Size(67, 21)
        Me.LblSerPath.TabIndex = 2
        Me.LblSerPath.Text = "Service :"
        '
        'CmbBoxPathSer
        '
        Me.CmbBoxPathSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxPathSer.FormattingEnabled = True
        Me.CmbBoxPathSer.Location = New System.Drawing.Point(195, 47)
        Me.CmbBoxPathSer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbBoxPathSer.Name = "CmbBoxPathSer"
        Me.CmbBoxPathSer.Size = New System.Drawing.Size(200, 29)
        Me.CmbBoxPathSer.TabIndex = 1
        '
        'TxtBoxNomPt
        '
        Me.TxtBoxNomPt.Location = New System.Drawing.Point(195, 86)
        Me.TxtBoxNomPt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBoxNomPt.Name = "TxtBoxNomPt"
        Me.TxtBoxNomPt.Size = New System.Drawing.Size(200, 28)
        Me.TxtBoxNomPt.TabIndex = 0
        '
        'Pathologie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(518, 316)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Pathologie"
        Me.Text = "Pathologie"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PicBoxSupp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtMalade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PicBoxPath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnAddPath As Button
    Friend WithEvents PicBoxPath As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSerPath As Label
    Friend WithEvents CmbBoxPathSer As ComboBox
    Friend WithEvents TxtBoxNomPt As TextBox
    Friend WithEvents CmbBoxDepPath As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblChoixSer As Label
    Friend WithEvents CmbPathser As ComboBox
    Friend WithEvents DtMalade As DataGridView
    Friend WithEvents BtnSupp As Button
    Friend WithEvents PicBoxSupp As PictureBox
End Class
