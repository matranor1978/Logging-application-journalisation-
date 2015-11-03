Imports System.IO
Imports System.Xml.Serialization
Imports System
Imports System.Linq
Imports System.Collections.Generic


Public Class Form1

    Private liste As New List(Of Type)


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objStreamReader As New StreamReader("listeTypes.txt")
        Dim x As New XmlSerializer(liste.GetType)
        liste = x.Deserialize(objStreamReader)
        objStreamReader.Close()

    End Sub


    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        rtConsultation.ResetText()
        lbMotsCleConsignation.Items.Clear()
        cbCategorieConsultation.Items.Clear()
        cbCategorieConsultation.Visible = False
        clbMotsCleConsultation.Items.Clear()
        clbMotsCleConsultation.Visible = False
        bOK.Visible = False
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        AccueilFrm.Show()
    End Sub

   
    Private Sub bAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouter.Click
        

        If cbCategoriesConsignation.SelectedIndex <> -1 AndAlso lbMotsCleConsignation.Items.Count <> 0 AndAlso tDescription.Text <> "" Then
            Dim listMotsCles As New List(Of String)
            For Each item In lbMotsCleConsignation.Items
                listMotsCles.Add(item.ToString)
                lbMotsCle.Items.Add(item)
            Next
            If MessageBox.Show("Voulez vous créer cette entrée?", "Entrée - Création", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim entree As New Entree(cbCategoriesConsignation.SelectedItem, listMotsCles, Date.Now, tDescription.Text)
                Dim entrees As New List(Of Entree)
                Dim fich1 As New FileStream(Me.Text, FileMode.Open)
                Dim Serialiseur1 As New XmlSerializer(entrees.GetType)
                Try
                    entrees = Serialiseur1.Deserialize(fich1)
                Catch ex As Exception
                End Try
                fich1.Close()
                entrees.Add(entree)
                Dim fich2 As New FileStream(Me.Text, FileMode.Open)
                Dim Serialiseur2 As New XmlSerializer(entrees.GetType)
                fich2.Flush()
                Serialiseur2.Serialize(fich2, entrees)
                fich2.Close()
                afficher(entree)
                cbCategoriesConsignation.SelectedIndex = -1
                lbMotsCleConsignation.Items.Clear()
                tDescription.Text = ""
            Else
                cbCategoriesConsignation.SelectedIndex = -1
                lbMotsCleConsignation.Items.Clear()
                tDescription.Text = ""
            End If
            
        Else : MsgBox("Tous les champs sont obligatoires!")
        End If
    End Sub

   
    

    Private Sub bAjouterMotCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouterMotCle.Click
        Try
            lbMotsCleConsignation.Items.Add(lbMotsCle.SelectedItem)
            lbMotsCleConsignation.Sorted = True
            lbMotsCle.Items.Remove(lbMotsCle.SelectedItem)

        Catch ex As Exception

        End Try
        
    End Sub

    
    Private Sub bRetirerMotCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRetirerMotCle.Click
        Try
            lbMotsCle.Items.Add(lbMotsCleConsignation.SelectedItem)
            lbMotsCleConsignation.Items.Remove(lbMotsCleConsignation.SelectedItem)
            bAjouterMotCle.Enabled = True
        Catch ex As Exception

        End Try
        
    End Sub

  
    Private Sub cbConsultation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbConsultation.SelectedIndexChanged
        clbMotsCleConsultation.Visible = False
        bOK.Visible = False
        cbCategorieConsultation.Visible = False
        Dim t As Type
        Dim str As String
        Dim strArr() As String
        str = Me.Text
        strArr = str.Split(".")
        t = recupererType(strArr(1))
        If cbConsultation.SelectedItem.ToString = "Mots-clé (événements incluant la totalité des mots-clé choisis)" Then
            clbMotsCleConsultation.Items.Clear()
            For Each i In t.MotsCle
                clbMotsCleConsultation.Items.Add(i)
                clbMotsCleConsultation.Sorted = True
            Next
            cbCategorieConsultation.Visible = False
            clbMotsCleConsultation.Visible = True
            bOK.Visible = True
        ElseIf cbConsultation.SelectedItem.ToString = "Catégorie" Then
            cbCategorieConsultation.Items.Clear()
            For Each i In t.Categories
                cbCategorieConsultation.Items.Add(i)
            Next
            clbMotsCleConsultation.Visible = False
            bOK.Visible = False
            cbCategorieConsultation.Visible = True
        ElseIf cbConsultation.SelectedItem.ToString = "Ordre chronologique décroissant" Then
            rtConsultation.Clear()
            Dim entrees As New List(Of Entree)
            Dim fich5 As New FileStream(Me.Text, FileMode.Open)
            Dim Serialiseur5 As New XmlSerializer(entrees.GetType)
            Try
                entrees = Serialiseur5.Deserialize(fich5)
            Catch ex As Exception
            End Try
            fich5.Close()
            entrees = entrees.OrderByDescending(Function(entree) entree.Dates).ToList
            For Each entree In entrees
                afficher(entree)
            Next
        End If
        
    End Sub

    Public Function recupererType(ByVal ext As String)
        For Each t In liste
            If t.Extension = ext Then
                Return t
            End If
        Next
        Return Nothing
    End Function

    Private Sub cbCategorieConsultation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategorieConsultation.SelectedIndexChanged
        rtConsultation.Clear()
        Dim entrees As New List(Of Entree)
        Dim fich3 As New FileStream(Me.Text, FileMode.Open)
        Dim Serialiseur3 As New XmlSerializer(entrees.GetType)
        Try
            entrees = Serialiseur3.Deserialize(fich3)
        Catch ex As Exception
        End Try
        fich3.Close()
        Dim compteur As Integer = 0
        For Each entree In entrees
            If entree.Categorie = cbCategorieConsultation.SelectedItem.ToString Then
                afficher(entree)
                compteur = compteur + 1
            End If
        Next
        If compteur = 0 Then
            rtConsultation.Text = "Aucune entrée n'existe pour cette catégorie"
        End If
    End Sub

    Private Sub bAfficherTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAfficherTout.Click
        clbMotsCleConsultation.Visible = False
        bOK.Visible = False
        cbCategorieConsultation.Visible = False
        rtConsultation.Clear()
        Dim entrees As New List(Of Entree)
        Dim fich4 As New FileStream(Me.Text, FileMode.Open)
        Dim Serialiseur4 As New XmlSerializer(entrees.GetType)
        Try
            entrees = Serialiseur4.Deserialize(fich4)
        Catch ex As Exception
        End Try
        fich4.Close()
        For Each entree In entrees
            afficher(entree)
        Next
    End Sub

    
    Private Sub bOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click

        If clbMotsCleConsultation.CheckedItems.Count <> 0 Then
            rtConsultation.Clear()
                Dim entrees As New List(Of Entree)
            Dim fich4 As New FileStream(Me.Text, FileMode.Open)
                Dim Serialiseur4 As New XmlSerializer(entrees.GetType)
                Try
                    entrees = Serialiseur4.Deserialize(fich4)
                Catch ex As Exception
                End Try
                fich4.Close()

                Dim liste As New List(Of String)
                For Each item In clbMotsCleConsultation.CheckedItems
                    liste.Add(item)
                Next
                Dim entr As New Entree(liste)
                Dim compteur As Integer = 0
                For Each entree In entrees
                    If entree.CompareTo(entr) Then
                    afficher(entree)
                        compteur = compteur + 1
                    ElseIf clbMotsCleConsultation.CheckedItems.Count < entree.MotsCle.Count Then
                        For Each mot In clbMotsCleConsultation.CheckedItems
                            If entree.MotsCle.Contains(mot) Then
                            afficher(entree)
                                compteur = compteur + 1
                            End If
                        Next
                    End If
                Next
                If compteur = 0 Then
                    rtConsultation.Text = "Aucune entrée n'existe pour ce choix de mots-clé!!"
                End If
        Else : rtConsultation.Text = "Vous devez choisir au moins un mot-clé!!"
        End If

    End Sub
    
    Private Sub tDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDescription.TextChanged
        If tDescription.Text.Length = 280 Then
            MessageBox.Show("Vous avez atteint le maximum de cacartères autorisé pour la description!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub afficher(ByVal entree)
        rtConsultation.AppendText(Entree.Description & " " & Entree.Dates & vbCrLf & " Catégorie: " & Entree.Categorie & vbCrLf)
        Dim chaine As String = " Mots-clé: "
        For Each motcle In Entree.MotsCle
            chaine = chaine & motcle & "; "
        Next
        rtConsultation.AppendText(chaine & vbCrLf & vbCrLf & vbCrLf)
    End Sub
End Class
