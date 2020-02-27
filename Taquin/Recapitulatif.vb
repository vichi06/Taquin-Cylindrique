Public Class Recapitulatif
    Private Sub Recapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBoxBestScore.Items.Clear()
        ListBoxNoms.Items.Clear()

        For Each player In listeJoueurs
            ListBoxNoms.Items.Add(player.getName)

            If player.getHS <> Nothing Then
                ListBoxBestScore.Items.Add(player.getHS)
            Else
                ListBoxBestScore.Items.Add("aucun")
            End If

            ComboBoxJoueurs.Items.Add(player.getName)
        Next
    End Sub

    Private Sub ButtonFullStats_Click(sender As Object, e As EventArgs) Handles ButtonFullStats.Click
        If ListBoxNoms.SelectedIndex <> -1 Then
            MsgBox("Stats de " & research(ListBoxNoms.SelectedItem).getName & " : Meilleur Temps de " &
                   research(ListBoxNoms.SelectedItem).getHS & " secondes, avec un temps de jeu de " &
                   research(ListBoxNoms.SelectedItem).getgamingTime & " secondes, sur un nombre de " &
                   research(ListBoxNoms.SelectedItem).getNG & " parties jouées")
        Else
            MsgBox("sélectionnez un joueur")
        End If
    End Sub
    Private Sub ComboBoxJoueurs_Enter(sender As Object, e As EventArgs) Handles ComboBoxJoueurs.KeyPress
        For Each Name As String In ListBoxNoms.Items
            If Name.Equals(ComboBoxJoueurs.Text) Then
                ListBoxNoms.SetSelected(ListBoxNoms.Items.IndexOf(Name), True)
                Exit Sub
            End If
        Next
    End Sub
    Private Sub ListBoxNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNoms.SelectedIndexChanged
        ComboBoxJoueurs.Text = ListBoxNoms.SelectedItem.ToString
    End Sub
    Private Sub ComboBoxJoueurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJoueurs.SelectedIndexChanged
        For Each Name As String In ListBoxNoms.Items
            If Name.Equals(ComboBoxJoueurs.Text) Then
                ListBoxNoms.SetSelected(ListBoxNoms.Items.IndexOf(Name), True)
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
        Accueil.Show()
    End Sub

    Private Sub RadioButtonTriAlpha_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriAlpha.CheckedChanged
        If RadioButtonTriAlpha.Checked Then
            ListBoxNoms.Sorted = True
            ListBoxBestScore.Sorted = False

            ListBoxBestScore.Items.Clear()

            For Each player In ListBoxNoms.Items
                If research(player).getHS = 0 Then
                    ListBoxBestScore.Items.Add("aucun")
                Else
                    ListBoxBestScore.Items.Add(research(player).getHS)
                End If
            Next
        End If
    End Sub

    Private Sub RadioButtonTriTmps_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriTmps.CheckedChanged
        If RadioButtonTriTmps.Checked Then
            ListBoxNoms.Sorted = False
            ListBoxBestScore.Sorted = True

            ListBoxNoms.Items.Clear()

            Dim listeJoueursBis As New List(Of Joueur)

            For Each joueur In listeJoueurs
                listeJoueursBis.Add(joueur)
            Next


            For Each hs In ListBoxBestScore.Items
                For Each j In listeJoueursBis
                    If hs = j.getHS().ToString Then
                        ListBoxNoms.Items.Add(j.getName)
                        listeJoueursBis.Remove(j)
                        Exit For
                    ElseIf hs.Equals("aucun") Then
                        If j.getHS = 0 Then
                            ListBoxNoms.Items.Add(j.getName)
                            listeJoueursBis.Remove(j)
                            Exit For
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        listeJoueurs.Clear()
        Accueil.ComboBoxName.Items.Clear()
        Close()
        Accueil.Show()
        Accueil.ButtonTabScores.PerformClick()
    End Sub
End Class