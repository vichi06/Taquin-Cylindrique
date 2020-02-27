Imports System.IO

Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case timeManager
            Case 360
                TrackBarDifficulté.Value = 1
            Case 240
                TrackBarDifficulté.Value = 2
            Case 120
                TrackBarDifficulté.Value = 3
            Case 80
                TrackBarDifficulté.Value = 4
            Case 60
                TrackBarDifficulté.Value = 5
        End Select
    End Sub
    Private Sub TrackBarDifficulté_Scroll(sender As Object, e As EventArgs) Handles TrackBarDifficulté.Scroll
        If TrackBarDifficulté.Value = 1 Then
            timeManager = 360
        End If
        If TrackBarDifficulté.Value = 2 Then
            timeManager = 240
        End If
        If TrackBarDifficulté.Value = 3 Then
            timeManager = 120
        End If
        If TrackBarDifficulté.Value = 4 Then
            timeManager = 80
        End If
        If TrackBarDifficulté.Value = 5 Then
            timeManager = 60
        End If
    End Sub

    Private Sub CheckBoxTime_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTime.CheckedChanged
        If CheckBoxTime.Checked Then
            timeManager = -1
        Else
            If TrackBarDifficulté.Value = 1 Then
                timeManager = 360
            End If
            If TrackBarDifficulté.Value = 2 Then
                timeManager = 240
            End If
            If TrackBarDifficulté.Value = 3 Then
                timeManager = 120
            End If
            If TrackBarDifficulté.Value = 4 Then
                timeManager = 80
            End If
            If TrackBarDifficulté.Value = 5 Then
                timeManager = 60
            End If
        End If
    End Sub

    Private Sub CheckBoxPlayPause_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPlayPause.CheckedChanged
        If CheckBoxPlayPause.Checked Then
            PartieEnCours.ButtonPausePlay.Enabled = True
        Else
            PartieEnCours.ButtonPausePlay.Enabled = False
        End If
    End Sub
    Private Sub ButtonCharger_Click(sender As Object, e As EventArgs) Handles ButtonCharger.Click
        If File.Exists(TextBox1.Text) Then
            listeJoueurs.Clear()
            chargerJoueurs(TextBox1.Text)
            newPath = TextBox1.Text
        End If
    End Sub

    Private Sub ButtonSauvegarder_Click(sender As Object, e As EventArgs) Handles ButtonSauvegarder.Click
        If File.Exists(TextBox1.Text) Then
            enregistrerJoueurs(TextBox1.Text)
            newPath = TextBox1.Text
        End If

    End Sub

    Private Sub ButtonExitOptions_Click(sender As Object, e As EventArgs) Handles ButtonExitOptions.Click
        Hide()
        Accueil.Show()
    End Sub
End Class