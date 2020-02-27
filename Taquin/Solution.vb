
Imports System.Drawing

Public Class Solution
    Private Sub Solution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxSolution.Text = PartieEnCours.lit_fichier()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Close()
        PartieEnCours.resoudre()
    End Sub
End Class