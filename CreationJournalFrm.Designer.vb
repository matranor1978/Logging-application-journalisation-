<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreationJournalFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTypes = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bCreerJournal = New System.Windows.Forms.Button()
        Me.bAnnuler = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tNomJournal = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisissez le type :"
        '
        'cbTypes
        '
        Me.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypes.FormattingEnabled = True
        Me.cbTypes.Location = New System.Drawing.Point(196, 97)
        Me.cbTypes.Name = "cbTypes"
        Me.cbTypes.Size = New System.Drawing.Size(187, 21)
        Me.cbTypes.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(38, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Créez un nouveau type"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bCreerJournal
        '
        Me.bCreerJournal.BackColor = System.Drawing.Color.Gray
        Me.bCreerJournal.Location = New System.Drawing.Point(273, 297)
        Me.bCreerJournal.Name = "bCreerJournal"
        Me.bCreerJournal.Size = New System.Drawing.Size(75, 23)
        Me.bCreerJournal.TabIndex = 3
        Me.bCreerJournal.Text = "Créer journal"
        Me.bCreerJournal.UseVisualStyleBackColor = False
        '
        'bAnnuler
        '
        Me.bAnnuler.BackColor = System.Drawing.Color.Gray
        Me.bAnnuler.Location = New System.Drawing.Point(371, 297)
        Me.bAnnuler.Name = "bAnnuler"
        Me.bAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.bAnnuler.TabIndex = 4
        Me.bAnnuler.Text = "Annuler"
        Me.bAnnuler.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Donnez un nom à votre journal:"
        '
        'tNomJournal
        '
        Me.tNomJournal.Location = New System.Drawing.Point(196, 248)
        Me.tNomJournal.Name = "tNomJournal"
        Me.tNomJournal.Size = New System.Drawing.Size(187, 20)
        Me.tNomJournal.TabIndex = 6
        '
        'SaveFileDialog1
        '
        '
        'CreationJournalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 332)
        Me.Controls.Add(Me.tNomJournal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bAnnuler)
        Me.Controls.Add(Me.bCreerJournal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbTypes)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreationJournalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal - Création"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bCreerJournal As System.Windows.Forms.Button
    Friend WithEvents bAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tNomJournal As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
