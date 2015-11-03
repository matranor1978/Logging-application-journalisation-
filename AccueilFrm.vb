Imports System.IO
Imports System.Xml.Serialization


Public Class AccueilFrm
    Private liste As New List(Of Type)

    Private Sub CréerTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CréerTypeToolStripMenuItem.Click
        TypeJournalFrm.Show()
        Me.Hide()
    End Sub

    Private Sub CréerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CréerToolStripMenuItem.Click
        CreationJournalFrm.Show()
        Me.Hide()

    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        End
    End Sub

    Private Sub AccueilFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub AccueilFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fichier As New FileStream("listeTypes.txt", FileMode.Open)
        Dim Serialiseur As New XmlSerializer(liste.GetType)
        liste = Serialiseur.Deserialize(fichier)
        fichier.Flush()
        fichier.Close()
    End Sub

    Public Function recupererType(ByVal ext As String)
        For Each t In liste
            If t.Extension = ext Then
                Return t
            End If
        Next
        Return Nothing
    End Function

   
    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        Try
            Dim reponse As DialogResult
            reponse = OpenFileDialog1.ShowDialog()
            Dim fichier As New FileStream(OpenFileDialog1.FileName, FileMode.Open)

            If reponse = Windows.Forms.DialogResult.OK Then
                Form1.lbMotsCle.Items.Clear()
                Form1.cbCategoriesConsignation.Items.Clear()
                Dim t As Type
                Dim str As String
                Dim strArr() As String
                str = OpenFileDialog1.FileName
                strArr = str.Split(".")
                t = recupererType(strArr(1))
                For Each i In t.MotsCle
                    Form1.lbMotsCle.Items.Add(i)
                    Form1.lbMotsCle.Sorted = True

                Next
                For Each i In t.Categories
                    Form1.cbCategoriesConsignation.Items.Add(i)
                Next
                Try
                    Dim entrees As New List(Of Entree)
                    Dim Serialiseur As New XmlSerializer(entrees.GetType)
                    entrees = Serialiseur.Deserialize(fichier)
                    fichier.Flush()
                    fichier.Close()
                    For Each Entree In entrees
                        Form1.rtConsultation.AppendText(Entree.Description & " " & Entree.Dates & vbCrLf & " Catégorie: " & Entree.Categorie & vbCrLf)
                        Dim chaine As String = " Mots-clé: "
                        For Each motcle In Entree.MotsCle
                            chaine = chaine & motcle & "; "
                        Next
                        Form1.rtConsultation.AppendText(chaine & vbCrLf & vbCrLf & vbCrLf)
                    Next
                Catch ex As Exception
                End Try
                Form1.Text = OpenFileDialog1.FileName
                Form1.Show()
                Me.Hide()
            End If
            fichier.Close()
        Catch ex As Exception

        End Try
        
    End Sub
End Class