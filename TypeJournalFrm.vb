Imports System.IO
Imports System.Xml.Serialization

Public Class TypeJournalFrm
    Private liste As New List(Of Type)

    Private Sub bOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOk.Click
        If tExtension.Text <> Nothing AndAlso lbMotsCle.Items.Count <> 0 AndAlso lbCategories.Items.Count <> 0 Then
            Dim listMotsCles As New List(Of String)
            Dim listCategories As New List(Of String)
            For Each item In lbMotsCle.Items
                listMotsCles.Add(item.ToString)
            Next
            For Each item In lbCategories.Items
                listCategories.Add(item.ToString)
            Next
            Dim type As New Type()
            With type
                .Extension = tExtension.Text
                .MotsCle = listMotsCles
                .Categories = listCategories
            End With

            Dim fichier As New FileStream("listeTypes.txt", FileMode.Open)
            Dim Serialiseur As New XmlSerializer(liste.GetType)
            Try
                liste = Serialiseur.Deserialize(fichier)
            Catch ex As Exception
            End Try
            fichier.Close()
            liste.Add(type)
            Dim fichier1 As New FileStream("listeTypes.txt", FileMode.Open)
            Dim Serialiseur1 As New XmlSerializer(liste.GetType)
            fichier1.Flush()
            Serialiseur1.Serialize(fichier1, liste)
            fichier1.Close()
            CreationJournalFrm.cbTypes.Items.Clear()
            For Each type In liste
                CreationJournalFrm.cbTypes.Items.Add(type.Extension)
            Next
            If MessageBox.Show("Type créée avec succès. Voulez vous créer un autre?", "Type - Création", _
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
                tExtension.Text = ""
                lbMotsCle.Items.Clear()
                lbCategories.Items.Clear()
            Else
                If CreationJournalFrm.drapeau Then
                    Me.Dispose()
                Else
                    AccueilFrm.Show()
                    Me.Dispose()
                End If       
            End If
        Else : MsgBox("Tous les champs sont obligatoires!")
        End If
    End Sub

    Private Sub bAjouterMotCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouterMotCle.Click
        If tMotsCle.Text <> Nothing Then
            lbMotsCle.Items.Add(tMotsCle.Text)
            tMotsCle.Text = ""
        Else : MsgBox("Veuillez saisir un mot clé!")
        End If
        If lbMotsCle.Items.Count = 5 Then
            bAjouterMotCle.Enabled = False
        End If

    End Sub

    Private Sub bAjouterCategorie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouterCategorie.Click
        If tCategories.Text <> Nothing Then
            lbCategories.Items.Add(tCategories.Text)
            tCategories.Text = ""
        Else : MsgBox("Veuillez saisir une catégorie!")
        End If
    End Sub

    Private Sub bRetirerMotCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRetirerMotCle.Click
        If lbMotsCle.SelectedIndex <> -1 Then
            lbMotsCle.Items.Remove(lbMotsCle.SelectedItem)
            bAjouterMotCle.Enabled = True
        End If

    End Sub

    Private Sub bRetierCategorie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRetierCategorie.Click
        lbCategories.Items.Remove(lbCategories.SelectedItem)
    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnnuler.Click
        If CreationJournalFrm.drapeau Then
            Me.Dispose()
        Else
            AccueilFrm.Show()
            Me.Dispose()
        End If
    End Sub


    Private Sub TypeJournalFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        AccueilFrm.Show()
    End Sub

End Class