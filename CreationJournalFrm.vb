Imports System.IO
Imports System.Xml.Serialization

Public Class CreationJournalFrm
    Private liste As New List(Of Type)
    Public drapeau As Boolean = False


    Private Sub CreationJournalFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fichier As New FileStream("listeTypes.txt", FileMode.Open)
        Dim Serialiseur As New XmlSerializer(liste.GetType)
        liste = Serialiseur.Deserialize(fichier)
        fichier.Flush()
        fichier.Close()
        cbTypes.Items.Clear()
        For Each type In liste
            cbTypes.Items.Add(type.Extension)
        Next

    End Sub


    Private Sub bCreerJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCreerJournal.Click
        
        If cbTypes.SelectedIndex <> -1 AndAlso tNomJournal.Text <> "" Then
            Try
                My.Computer.FileSystem.WriteAllText("listeJournaux.txt", tNomJournal.Text & "." & cbTypes.SelectedItem.ToString & vbCrLf, True)
                SaveFileDialog1.FileName = tNomJournal.Text
                SaveFileDialog1.DefaultExt = cbTypes.SelectedItem.ToString
                Dim reponse As DialogResult
                reponse = SaveFileDialog1.ShowDialog()
                If reponse = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, String.Empty, False)
                End If
                If MessageBox.Show("Journal créée avec succès. Voulez vous créer un autre?", "Journal - Création", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    cbTypes.SelectedIndex = -1
                    tNomJournal.Text = ""
                Else
                    AccueilFrm.Show()
                    Me.Dispose()
                End If
            Catch ex As Exception

            End Try
            
        Else
            MsgBox("Vous devez choisir un type et donner un nom à votre journal!")
        End If
    End Sub

    Private Sub bAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnnuler.Click
        AccueilFrm.Show()
        Me.Close()
    End Sub

    Private Sub CreationJournalFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        AccueilFrm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tjFrm As New TypeJournalFrm
        tjFrm.Show()
        drapeau = True
    End Sub

End Class