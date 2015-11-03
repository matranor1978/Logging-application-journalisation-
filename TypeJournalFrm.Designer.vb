<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeJournalFrm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bOk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tExtension = New System.Windows.Forms.TextBox()
        Me.tMotsCle = New System.Windows.Forms.TextBox()
        Me.bAjouterMotCle = New System.Windows.Forms.Button()
        Me.lbMotsCle = New System.Windows.Forms.ListBox()
        Me.tCategories = New System.Windows.Forms.TextBox()
        Me.lbCategories = New System.Windows.Forms.ListBox()
        Me.bAjouterCategorie = New System.Windows.Forms.Button()
        Me.bRetirerMotCle = New System.Windows.Forms.Button()
        Me.bRetierCategorie = New System.Windows.Forms.Button()
        Me.bAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bOk
        '
        Me.bOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bOk.Location = New System.Drawing.Point(532, 385)
        Me.bOk.Name = "bOk"
        Me.bOk.Size = New System.Drawing.Size(67, 23)
        Me.bOk.TabIndex = 9
        Me.bOk.Text = "OK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(31, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Extension :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(31, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mots-clé (maximum 5) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(31, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Catégories :"
        '
        'tExtension
        '
        Me.tExtension.Location = New System.Drawing.Point(34, 59)
        Me.tExtension.Name = "tExtension"
        Me.tExtension.Size = New System.Drawing.Size(100, 20)
        Me.tExtension.TabIndex = 14
        '
        'tMotsCle
        '
        Me.tMotsCle.Location = New System.Drawing.Point(34, 125)
        Me.tMotsCle.Name = "tMotsCle"
        Me.tMotsCle.Size = New System.Drawing.Size(170, 20)
        Me.tMotsCle.TabIndex = 15
        '
        'bAjouterMotCle
        '
        Me.bAjouterMotCle.BackColor = System.Drawing.Color.Gray
        Me.bAjouterMotCle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAjouterMotCle.Location = New System.Drawing.Point(231, 125)
        Me.bAjouterMotCle.Name = "bAjouterMotCle"
        Me.bAjouterMotCle.Size = New System.Drawing.Size(32, 23)
        Me.bAjouterMotCle.TabIndex = 17
        Me.bAjouterMotCle.Text = ">"
        Me.bAjouterMotCle.UseVisualStyleBackColor = False
        '
        'lbMotsCle
        '
        Me.lbMotsCle.FormattingEnabled = True
        Me.lbMotsCle.Location = New System.Drawing.Point(278, 125)
        Me.lbMotsCle.Name = "lbMotsCle"
        Me.lbMotsCle.Size = New System.Drawing.Size(248, 95)
        Me.lbMotsCle.TabIndex = 19
        '
        'tCategories
        '
        Me.tCategories.Location = New System.Drawing.Point(34, 263)
        Me.tCategories.Name = "tCategories"
        Me.tCategories.Size = New System.Drawing.Size(170, 20)
        Me.tCategories.TabIndex = 20
        '
        'lbCategories
        '
        Me.lbCategories.FormattingEnabled = True
        Me.lbCategories.Location = New System.Drawing.Point(278, 261)
        Me.lbCategories.Name = "lbCategories"
        Me.lbCategories.Size = New System.Drawing.Size(248, 95)
        Me.lbCategories.TabIndex = 23
        '
        'bAjouterCategorie
        '
        Me.bAjouterCategorie.BackColor = System.Drawing.Color.Gray
        Me.bAjouterCategorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAjouterCategorie.Location = New System.Drawing.Point(231, 261)
        Me.bAjouterCategorie.Name = "bAjouterCategorie"
        Me.bAjouterCategorie.Size = New System.Drawing.Size(32, 23)
        Me.bAjouterCategorie.TabIndex = 21
        Me.bAjouterCategorie.Text = ">"
        Me.bAjouterCategorie.UseVisualStyleBackColor = False
        '
        'bRetirerMotCle
        '
        Me.bRetirerMotCle.BackColor = System.Drawing.Color.DimGray
        Me.bRetirerMotCle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRetirerMotCle.Location = New System.Drawing.Point(546, 197)
        Me.bRetirerMotCle.Name = "bRetirerMotCle"
        Me.bRetirerMotCle.Size = New System.Drawing.Size(93, 23)
        Me.bRetirerMotCle.TabIndex = 24
        Me.bRetirerMotCle.Text = "Retirer mot"
        Me.bRetirerMotCle.UseVisualStyleBackColor = False
        '
        'bRetierCategorie
        '
        Me.bRetierCategorie.BackColor = System.Drawing.Color.Gray
        Me.bRetierCategorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRetierCategorie.Location = New System.Drawing.Point(546, 333)
        Me.bRetierCategorie.Name = "bRetierCategorie"
        Me.bRetierCategorie.Size = New System.Drawing.Size(93, 23)
        Me.bRetierCategorie.TabIndex = 25
        Me.bRetierCategorie.Text = "Retirer catégorie"
        Me.bRetierCategorie.UseVisualStyleBackColor = False
        '
        'bAnnuler
        '
        Me.bAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAnnuler.Location = New System.Drawing.Point(605, 385)
        Me.bAnnuler.Name = "bAnnuler"
        Me.bAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.bAnnuler.TabIndex = 26
        Me.bAnnuler.Text = "Annuler"
        Me.bAnnuler.UseVisualStyleBackColor = False
        '
        'TypeJournalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 420)
        Me.Controls.Add(Me.bAnnuler)
        Me.Controls.Add(Me.bRetierCategorie)
        Me.Controls.Add(Me.bRetirerMotCle)
        Me.Controls.Add(Me.lbCategories)
        Me.Controls.Add(Me.bAjouterCategorie)
        Me.Controls.Add(Me.tCategories)
        Me.Controls.Add(Me.lbMotsCle)
        Me.Controls.Add(Me.bAjouterMotCle)
        Me.Controls.Add(Me.bOk)
        Me.Controls.Add(Me.tMotsCle)
        Me.Controls.Add(Me.tExtension)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TypeJournalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type de Journal  - Création"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bOk As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tExtension As System.Windows.Forms.TextBox
    Friend WithEvents tMotsCle As System.Windows.Forms.TextBox
    Friend WithEvents bAjouterMotCle As System.Windows.Forms.Button
    Friend WithEvents lbMotsCle As System.Windows.Forms.ListBox
    Friend WithEvents tCategories As System.Windows.Forms.TextBox
    Friend WithEvents lbCategories As System.Windows.Forms.ListBox
    Friend WithEvents bAjouterCategorie As System.Windows.Forms.Button
    Friend WithEvents bRetirerMotCle As System.Windows.Forms.Button
    Friend WithEvents bRetierCategorie As System.Windows.Forms.Button
    Friend WithEvents bAnnuler As System.Windows.Forms.Button
End Class
