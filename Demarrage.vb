Public Class Demarrage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New AccueilFrm
        pb.Visible = True
        pb.Value = pb.Minimum
        Do While pb.Value < pb.Maximum
            pb.Value += 25
            System.Threading.Thread.Sleep(1000)
        Loop
        If pb.Value = pb.Maximum Then
            pb.Visible = False
            f.Visible = True
            Me.Visible = False
        End If
    End Sub

End Class