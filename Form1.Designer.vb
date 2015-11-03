<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tDescription = New System.Windows.Forms.TextBox()
        Me.bAjouter = New System.Windows.Forms.Button()
        Me.rtConsultation = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbConsultation = New System.Windows.Forms.ComboBox()
        Me.bOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.clbMotsCleConsultation = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCategoriesConsignation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbMotsCle = New System.Windows.Forms.ListBox()
        Me.lbMotsCleConsignation = New System.Windows.Forms.ListBox()
        Me.bAjouterMotCle = New System.Windows.Forms.Button()
        Me.bRetirerMotCle = New System.Windows.Forms.Button()
        Me.cbCategorieConsultation = New System.Windows.Forms.ComboBox()
        Me.bAfficherTout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tDescription
        '
        Me.tDescription.Location = New System.Drawing.Point(12, 152)
        Me.tDescription.MaxLength = 280
        Me.tDescription.Multiline = True
        Me.tDescription.Name = "tDescription"
        Me.tDescription.Size = New System.Drawing.Size(582, 53)
        Me.tDescription.TabIndex = 0
        '
        'bAjouter
        '
        Me.bAjouter.BackColor = System.Drawing.Color.DimGray
        Me.bAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAjouter.Location = New System.Drawing.Point(614, 182)
        Me.bAjouter.Name = "bAjouter"
        Me.bAjouter.Size = New System.Drawing.Size(52, 23)
        Me.bAjouter.TabIndex = 1
        Me.bAjouter.Text = "Ajouter"
        Me.bAjouter.UseVisualStyleBackColor = False
        '
        'rtConsultation
        '
        Me.rtConsultation.Location = New System.Drawing.Point(12, 370)
        Me.rtConsultation.Name = "rtConsultation"
        Me.rtConsultation.ReadOnly = True
        Me.rtConsultation.Size = New System.Drawing.Size(654, 276)
        Me.rtConsultation.TabIndex = 3
        Me.rtConsultation.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Consultation par: "
        '
        'cbConsultation
        '
        Me.cbConsultation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsultation.FormattingEnabled = True
        Me.cbConsultation.Items.AddRange(New Object() {"Ordre chronologique décroissant", "Mots-clé (événements incluant la totalité des mots-clé choisis)", "Catégorie"})
        Me.cbConsultation.Location = New System.Drawing.Point(118, 223)
        Me.cbConsultation.Name = "cbConsultation"
        Me.cbConsultation.Size = New System.Drawing.Size(331, 21)
        Me.cbConsultation.TabIndex = 5
        '
        'bOK
        '
        Me.bOK.BackColor = System.Drawing.Color.Gray
        Me.bOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bOK.Location = New System.Drawing.Point(614, 341)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(32, 23)
        Me.bOK.TabIndex = 6
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = False
        Me.bOK.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Consignation: "
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Gray
        Me.bQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bQuitter.Location = New System.Drawing.Point(614, 652)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(52, 23)
        Me.bQuitter.TabIndex = 8
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'clbMotsCleConsultation
        '
        Me.clbMotsCleConsultation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clbMotsCleConsultation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbMotsCleConsultation.CheckOnClick = True
        Me.clbMotsCleConsultation.ForeColor = System.Drawing.SystemColors.Window
        Me.clbMotsCleConsultation.FormattingEnabled = True
        Me.clbMotsCleConsultation.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.clbMotsCleConsultation.Location = New System.Drawing.Point(455, 223)
        Me.clbMotsCleConsultation.Name = "clbMotsCleConsultation"
        Me.clbMotsCleConsultation.Size = New System.Drawing.Size(198, 120)
        Me.clbMotsCleConsultation.TabIndex = 11
        Me.clbMotsCleConsultation.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(286, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mots-clé : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(30, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Catégorie: "
        '
        'cbCategoriesConsignation
        '
        Me.cbCategoriesConsignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoriesConsignation.FormattingEnabled = True
        Me.cbCategoriesConsignation.Location = New System.Drawing.Point(33, 51)
        Me.cbCategoriesConsignation.Name = "cbCategoriesConsignation"
        Me.cbCategoriesConsignation.Size = New System.Drawing.Size(231, 21)
        Me.cbCategoriesConsignation.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(30, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Description: "
        '
        'lbMotsCle
        '
        Me.lbMotsCle.FormattingEnabled = True
        Me.lbMotsCle.Location = New System.Drawing.Point(289, 51)
        Me.lbMotsCle.Name = "lbMotsCle"
        Me.lbMotsCle.Size = New System.Drawing.Size(172, 95)
        Me.lbMotsCle.TabIndex = 20
        '
        'lbMotsCleConsignation
        '
        Me.lbMotsCleConsignation.FormattingEnabled = True
        Me.lbMotsCleConsignation.Location = New System.Drawing.Point(505, 51)
        Me.lbMotsCleConsignation.Name = "lbMotsCleConsignation"
        Me.lbMotsCleConsignation.Size = New System.Drawing.Size(161, 95)
        Me.lbMotsCleConsignation.TabIndex = 21
        '
        'bAjouterMotCle
        '
        Me.bAjouterMotCle.BackColor = System.Drawing.Color.Gray
        Me.bAjouterMotCle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAjouterMotCle.Location = New System.Drawing.Point(467, 70)
        Me.bAjouterMotCle.Name = "bAjouterMotCle"
        Me.bAjouterMotCle.Size = New System.Drawing.Size(32, 23)
        Me.bAjouterMotCle.TabIndex = 22
        Me.bAjouterMotCle.Text = ">"
        Me.bAjouterMotCle.UseVisualStyleBackColor = False
        '
        'bRetirerMotCle
        '
        Me.bRetirerMotCle.BackColor = System.Drawing.Color.Gray
        Me.bRetirerMotCle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRetirerMotCle.Location = New System.Drawing.Point(467, 99)
        Me.bRetirerMotCle.Name = "bRetirerMotCle"
        Me.bRetirerMotCle.Size = New System.Drawing.Size(32, 23)
        Me.bRetirerMotCle.TabIndex = 23
        Me.bRetirerMotCle.Text = "<"
        Me.bRetirerMotCle.UseVisualStyleBackColor = False
        '
        'cbCategorieConsultation
        '
        Me.cbCategorieConsultation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategorieConsultation.FormattingEnabled = True
        Me.cbCategorieConsultation.Location = New System.Drawing.Point(493, 223)
        Me.cbCategorieConsultation.Name = "cbCategorieConsultation"
        Me.cbCategorieConsultation.Size = New System.Drawing.Size(173, 21)
        Me.cbCategorieConsultation.TabIndex = 24
        Me.cbCategorieConsultation.Visible = False
        '
        'bAfficherTout
        '
        Me.bAfficherTout.BackColor = System.Drawing.Color.Gray
        Me.bAfficherTout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAfficherTout.Location = New System.Drawing.Point(12, 652)
        Me.bAfficherTout.Name = "bAfficherTout"
        Me.bAfficherTout.Size = New System.Drawing.Size(84, 23)
        Me.bAfficherTout.TabIndex = 25
        Me.bAfficherTout.Text = "Afficher tout"
        Me.bAfficherTout.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(678, 685)
        Me.Controls.Add(Me.bAfficherTout)
        Me.Controls.Add(Me.cbCategorieConsultation)
        Me.Controls.Add(Me.bRetirerMotCle)
        Me.Controls.Add(Me.bAjouterMotCle)
        Me.Controls.Add(Me.lbMotsCleConsignation)
        Me.Controls.Add(Me.lbMotsCle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCategoriesConsignation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clbMotsCleConsultation)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.cbConsultation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtConsultation)
        Me.Controls.Add(Me.bAjouter)
        Me.Controls.Add(Me.tDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tDescription As System.Windows.Forms.TextBox
    Friend WithEvents bAjouter As System.Windows.Forms.Button
    Friend WithEvents rtConsultation As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbConsultation As System.Windows.Forms.ComboBox
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents clbMotsCleConsultation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCategoriesConsignation As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbMotsCle As System.Windows.Forms.ListBox
    Friend WithEvents lbMotsCleConsignation As System.Windows.Forms.ListBox
    Friend WithEvents bAjouterMotCle As System.Windows.Forms.Button
    Friend WithEvents bRetirerMotCle As System.Windows.Forms.Button
    Friend WithEvents cbCategorieConsultation As System.Windows.Forms.ComboBox
    Friend WithEvents bAfficherTout As System.Windows.Forms.Button

End Class
