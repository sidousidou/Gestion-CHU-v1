<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmModifie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDepartement = New System.Windows.Forms.Label()
        Me.txtNbrlit = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.lblService = New System.Windows.Forms.Label()
        Me.BtnCancel2 = New System.Windows.Forms.Button()
        Me.LblMnomDep = New System.Windows.Forms.Label()
        Me.LblMnomSer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nbre des lits :"
        '
        'lblDepartement
        '
        Me.lblDepartement.AutoSize = True
        Me.lblDepartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartement.Location = New System.Drawing.Point(212, 13)
        Me.lblDepartement.Name = "lblDepartement"
        Me.lblDepartement.Size = New System.Drawing.Size(86, 16)
        Me.lblDepartement.TabIndex = 1
        Me.lblDepartement.Text = "Département"
        '
        'txtNbrlit
        '
        Me.txtNbrlit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbrlit.Location = New System.Drawing.Point(215, 86)
        Me.txtNbrlit.Name = "txtNbrlit"
        Me.txtNbrlit.Size = New System.Drawing.Size(207, 26)
        Me.txtNbrlit.TabIndex = 2
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnOk.Location = New System.Drawing.Point(215, 135)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 36)
        Me.BtnOk.TabIndex = 4
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(212, 49)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(57, 16)
        Me.lblService.TabIndex = 1
        Me.lblService.Text = "Service "
        '
        'BtnCancel2
        '
        Me.BtnCancel2.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnCancel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancel2.Location = New System.Drawing.Point(347, 135)
        Me.BtnCancel2.Name = "BtnCancel2"
        Me.BtnCancel2.Size = New System.Drawing.Size(75, 36)
        Me.BtnCancel2.TabIndex = 5
        Me.BtnCancel2.Text = "Cancel"
        Me.BtnCancel2.UseVisualStyleBackColor = False
        '
        'LblMnomDep
        '
        Me.LblMnomDep.AutoSize = True
        Me.LblMnomDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMnomDep.Location = New System.Drawing.Point(12, 9)
        Me.LblMnomDep.Name = "LblMnomDep"
        Me.LblMnomDep.Size = New System.Drawing.Size(173, 20)
        Me.LblMnomDep.TabIndex = 6
        Me.LblMnomDep.Text = "Nom De Departement :"
        '
        'LblMnomSer
        '
        Me.LblMnomSer.AutoSize = True
        Me.LblMnomSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMnomSer.Location = New System.Drawing.Point(12, 45)
        Me.LblMnomSer.Name = "LblMnomSer"
        Me.LblMnomSer.Size = New System.Drawing.Size(126, 20)
        Me.LblMnomSer.TabIndex = 7
        Me.LblMnomSer.Text = "Nom De Sevice :"
        '
        'FmModifie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 195)
        Me.Controls.Add(Me.LblMnomSer)
        Me.Controls.Add(Me.LblMnomDep)
        Me.Controls.Add(Me.BtnCancel2)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtNbrlit)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblDepartement)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FmModifie"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDepartement As Label
    Friend WithEvents txtNbrlit As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents lblService As Label
    Friend WithEvents BtnCancel2 As Button
    Friend WithEvents LblMnomDep As Label
    Friend WithEvents LblMnomSer As Label
End Class
