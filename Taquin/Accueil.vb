Imports System.Windows.Forms
Imports System.IO


Public Class Accueil

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxName.Text = ""

        'charger les joueurs à partir du fichier Joueurs dans /debug/bin

        chargerJoueurs(defaultPath)


        'fill combo box
        For Each player In listeJoueurs
            ComboBoxName.Items.Add(player.getName)
        Next
    End Sub

    Private Sub ComboBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxName.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.KeyChar = Chr(0) 'le caractere est refusé, remplacé par le caractère nul
        End If
    End Sub
    Private Sub ButtonLancer_Click(sender As Object, e As EventArgs) Handles ButtonLancer.Click
        If ComboBoxName.Text.Length = 0 Then
            MsgBox("A name is required")
        Else
            If nouveauJoueur(ComboBoxName.Text) = True Then
                Ajout(ComboBoxName.Text)
                ComboBoxName.Items.Add(ComboBoxName.Text)
            Else
                research(ComboBoxName.Text).plays()
            End If

            Me.Hide()
            PartieEnCours.Show()
        End If
    End Sub
    Private Sub ButtonRecap_Click(sender As Object, e As EventArgs) Handles ButtonTabScores.Click
        Me.Hide()
        Recapitulatif.Show()
    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        If MsgBox("Do you really want to leave the game ?", MsgBoxStyle.YesNo) = vbYes Then
            If newPath <> Nothing Then
                enregistrerJoueurs(newPath)
            Else
                enregistrerJoueurs(defaultPath)
            End If
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        Me.Hide()
        Options.Show()
    End Sub
End Class