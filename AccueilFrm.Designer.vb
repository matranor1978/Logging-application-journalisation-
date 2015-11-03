<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccueilFrm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.JournalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(389, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerTypeToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MenuToolStripMenuItem.Text = "Type de journal"
        '
        'CréerTypeToolStripMenuItem
        '
        Me.CréerTypeToolStripMenuItem.Name = "CréerTypeToolStripMenuItem"
        Me.CréerTypeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CréerTypeToolStripMenuItem.Text = "Créer type"
        '
        'JournalToolStripMenuItem
        '
        Me.JournalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.CréerToolStripMenuItem})
        Me.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem"
        Me.JournalToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.JournalToolStripMenuItem.Text = "Journal"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir "
        '
        'CréerToolStripMenuItem
        '
        Me.CréerToolStripMenuItem.Name = "CréerToolStripMenuItem"
        Me.CréerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CréerToolStripMenuItem.Text = "Créer"
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Gray
        Me.bQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bQuitter.Location = New System.Drawing.Point(302, 262)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(75, 23)
        Me.bQuitter.TabIndex = 1
        Me.bQuitter.Text = "Quiiter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AccueilFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 297)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AccueilFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CréerTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CréerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
