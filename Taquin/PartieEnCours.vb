Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms


Public Class PartieEnCours

    Dim limiteTemps As Double = timeManager
    Dim minuteur As Double = timeManager
    Dim player As Joueur
    Dim nbClick As Integer = 0
    Enum mouvement
        NORD
        SUD
        EST
        OUEST
    End Enum

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNomJoueur.Text = Accueil.ComboBoxName.Text
        LabelNbClick.Text = nbClick & " clicks"
        player = research(LabelNomJoueur.Text)

        TimerGame.Start()
        TimerGame.Interval = 1000

        If timeManager = -1 Then
            LabelTempsRestant.Text = "illimité"
        Else
            LabelTempsRestant.Text = minuteur & " secondes"
        End If

        Dim valeursButtons = New ArrayList
        For i = 1 To 16
            valeursButtons.Add(i)
        Next

        Dim randomizer As New Random

        'boucle sur boutons pour leur affecter un nombre au hasard pris dans la liste
        For Each button As Windows.Forms.Control In PanelButtons.Controls
            Dim randomIndex As Integer = randomizer.Next(0, valeursButtons.Count)
            button.Text = valeursButtons.Item(randomIndex).ToString

            If valeursButtons.Item(randomIndex).ToString = 16 Then
                button.Visible = False
            End If

            valeursButtons.RemoveAt(randomIndex)
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick
        If Button1.Text.Equals("1") And Button2.Text.Equals("2") And Button3.Text.Equals("3") _
            And Button4.Text.Equals("4") And Button5.Text.Equals("5") _
            And Button6.Text.Equals("6") And Button7.Text.Equals("7") And Button8.Text.Equals("8") _
            And Button9.Text.Equals("9") And Button10.Text.Equals("10") And Button11.Text.Equals("11") _
            And Button12.Text.Equals("12") And Button13.Text.Equals("13") And Button14.Text.Equals("14") _
            And Button15.Text.Equals("15") Then

            player.addGT(limiteTemps - minuteur)
            player.won(limiteTemps - minuteur)
            TimerGame.Stop()
            MsgBox("vous avez gagné en " & (limiteTemps - minuteur) & " secondes")
            Close()
            Accueil.Show()
        End If

        If minuteur > 0 Then
            LabelTempsRestant.Text = minuteur & " secondes"
            minuteur -= 1
        ElseIf minuteur = 0 Then
            TimerGame.Stop()
            MsgBox("La chrono est fini")
            Close()
        End If
    End Sub
    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click
        If MsgBox("Voulez-vous vraiment abandonner ?", MsgBoxStyle.YesNo) = vbYes Then
            player.addGT(limiteTemps - minuteur)
            Close()
            Accueil.Show()
        End If
    End Sub
    Sub echanger(butClicked As Button, butInvisible As Button)
        Dim temp As String = butInvisible.Text
        butInvisible.Text = butClicked.Text
        butClicked.Text = temp
        butInvisible.Visible = True
        butClicked.Visible = False
    End Sub

    Private Sub ButtonRésoudre_Click(sender As Object, e As EventArgs) Handles ButtonRésoudre.Click

        TimerGame.Stop()
        ecrit_fichier()
        appelle_echo()
        Solution.Show()
    End Sub

    Sub ecrit_fichier()
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("TexteSaisi.txt", False, utf8WithoutBom)

        'delivery for Sprint5
        file.WriteLine("4 4")
        For i = 1 To 16
            Dim name As String = "Button" & i
            For Each button As Button In PanelButtons.Controls
                If button.Name = name Then
                    If button.Text <> "16" Then
                        file.Write(button.Text & " ")
                    Else
                        file.Write("# ")
                    End If

                    'saute une ligne
                    If i Mod 4 = 0 Then
                        file.WriteLine()
                    End If
                    Exit For
                End If
            Next
        Next

        file.Close()
    End Sub
    Function lit_fichier() As String
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("TexteRepondu.txt")
        Return fileReader
    End Function
    Sub appelle_echo()
        Dim commande As String =
            "Taquin.exe < TexteSaisi.txt > TexteRepondu.txt"

        Dim p As New Process
        Dim psi As New ProcessStartInfo(
            "cmd.exe",
            "/c " & commande
        )
        p.StartInfo = psi
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        LabelWaiting.Text = ChrW(8987)
        p.Start()
        If (p.WaitForExit(10000) = False) Then
            MsgBox("le taquin n'a aucune solution, désolé")
            Close()
            Accueil.Show()
            p.Close()
        End If
        LabelWaiting.Text = ""
    End Sub

    Private Function RemoveExtraSpace(inVal As String) As String
        With CreateObject("VBScript.RegExp")
            .Pattern = "\s+"
            .Global = True
            RemoveExtraSpace = .Replace(inVal, " ")
        End With
    End Function

    Sub resoudre()
        Dim lines As List(Of String) = File.ReadAllLines("TexteRepondu.txt").ToList

        'remove two first lines useless
        lines.RemoveAt(0)
        lines.RemoveAt(0)

        Dim s As String = ""
        'remove all to keep only movements 
        For Each line As String In lines
            For Each character In line
                If IsNumeric(character) = False And character <> "#" Then
                    s += character
                End If
            Next
        Next

        s = RemoveExtraSpace(s)

        Dim words As String() = s.Split(New Char() {" "})

        For Each word As String In words

            PanelButtons.Refresh()
            Threading.Thread.Sleep(500) ' 500 milliseconds = 0.5 seconds

            Dim numButtonInvisible As Integer

            numButtonInvisible = getBoutonVide.Name.Substring(6)

            Select Case word
                Case mouvement.EST.ToString()
                    If numButtonInvisible + 1 = 5 Or numButtonInvisible + 1 = 9 Or numButtonInvisible + 1 = 13 Or numButtonInvisible + 1 = 17 Then
                        getBouton("Button" & numButtonInvisible - 3).PerformClick()
                    Else
                        getBouton("Button" & numButtonInvisible + 1).PerformClick()
                    End If

                Case mouvement.NORD.ToString()
                    getBouton("Button" & numButtonInvisible - 4).PerformClick()

                Case mouvement.SUD.ToString()
                    getBouton("Button" & numButtonInvisible + 4).PerformClick()

                Case mouvement.OUEST.ToString()
                    If numButtonInvisible - 1 = 4 Or numButtonInvisible - 1 = 8 Or numButtonInvisible - 1 = 12 Then
                        getBouton("Button" & numButtonInvisible + 3).PerformClick()
                    Else
                        getBouton("Button" & numButtonInvisible - 1).PerformClick()
                    End If
            End Select
        Next

        MsgBox("le taquin a été résolu")
        Close()
        Accueil.Show()
    End Sub

    Function getBoutonVide() As Button
        Dim leBouton As Button
        For Each button As Button In PanelButtons.Controls
            If button.Text = "16" Then
                leBouton = button
                Exit For
            End If
        Next
        Return leBouton
    End Function

    Function getBouton(ByVal name As String)
        Dim leBouton As Button
        For Each button As Button In PanelButtons.Controls
            If button.Name = name Then
                leBouton = button
                Exit For
            End If
        Next
        Return leBouton
    End Function

    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click
        nbClick += 1
        LabelNbClick.Text = nbClick & " clicks"
    End Sub



    'tous les événements d'échanges de boutons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button2.Visible = False Then
            echanger(Button1, Button2)
        End If
        If Button5.Visible = False Then
            echanger(Button1, Button5)
        End If
        If Button4.Visible = False Then
            echanger(Button1, Button4)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button1.Visible = False Then
            echanger(Button2, Button1)
        End If

        If Button6.Visible = False Then
            echanger(Button2, Button6)
        End If

        If Button3.Visible = False Then
            echanger(Button2, Button3)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button2.Visible = False Then
            echanger(Button3, Button2)
        End If
        If Button4.Visible = False Then
            echanger(Button3, Button4)
        End If
        If Button7.Visible = False Then
            echanger(Button3, Button7)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button3.Visible = False Then
            echanger(Button4, Button3)
        End If
        If Button8.Visible = False Then
            echanger(Button4, Button8)
        End If
        If Button1.Visible = False Then
            echanger(Button4, Button1)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button1.Visible = False Then
            echanger(Button5, Button1)
        End If
        If Button6.Visible = False Then
            echanger(Button5, Button6)
        End If
        If Button9.Visible = False Then
            echanger(Button5, Button9)
        End If
        If Button8.Visible = False Then
            echanger(Button5, Button8)
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button7.Visible = False Then
            echanger(Button6, Button7)
        End If
        If Button5.Visible = False Then
            echanger(Button6, Button5)
        End If
        If Button2.Visible = False Then
            echanger(Button6, Button2)
        End If
        If Button10.Visible = False Then
            echanger(Button6, Button10)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button3.Visible = False Then
            echanger(Button7, Button3)
        End If
        If Button11.Visible = False Then
            echanger(Button7, Button11)
        End If
        If Button8.Visible = False Then
            echanger(Button7, Button8)
        End If
        If Button6.Visible = False Then
            echanger(Button7, Button6)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button7.Visible = False Then
            echanger(Button8, Button7)
        End If
        If Button4.Visible = False Then
            echanger(Button8, Button4)
        End If
        If Button12.Visible = False Then
            echanger(Button8, Button12)
        End If
        If Button5.Visible = False Then
            echanger(Button8, Button5)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button10.Visible = False Then
            echanger(Button9, Button10)
        End If
        If Button5.Visible = False Then
            echanger(Button9, Button5)
        End If
        If Button13.Visible = False Then
            echanger(Button9, Button13)
        End If
        If Button12.Visible = False Then
            echanger(Button9, Button12)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button9.Visible = False Then
            echanger(Button10, Button9)
        End If
        If Button11.Visible = False Then
            echanger(Button10, Button11)
        End If
        If Button6.Visible = False Then
            echanger(Button10, Button6)
        End If
        If Button14.Visible = False Then
            echanger(Button10, Button14)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button12.Visible = False Then
            echanger(Button11, Button12)
        End If
        If Button10.Visible = False Then
            echanger(Button11, Button10)
        End If
        If Button15.Visible = False Then
            echanger(Button11, Button15)
        End If
        If Button7.Visible = False Then
            echanger(Button11, Button7)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Button8.Visible = False Then
            echanger(Button12, Button8)
        End If
        If Button16.Visible = False Then
            echanger(Button12, Button16)
        End If
        If Button11.Visible = False Then
            echanger(Button12, Button11)
        End If
        If Button9.Visible = False Then
            echanger(Button12, Button9)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Button9.Visible = False Then
            echanger(Button13, Button9)
        End If
        If Button14.Visible = False Then
            echanger(Button13, Button14)
        End If
        If Button16.Visible = False Then
            echanger(Button13, Button16)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Button10.Visible = False Then
            echanger(Button14, Button10)
        End If
        If Button13.Visible = False Then
            echanger(Button14, Button13)
        End If
        If Button15.Visible = False Then
            echanger(Button14, Button15)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Button14.Visible = False Then
            echanger(Button15, Button14)
        End If
        If Button16.Visible = False Then
            echanger(Button15, Button16)
        End If
        If Button11.Visible = False Then
            echanger(Button15, Button11)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button12.Visible = False Then
            echanger(Button16, Button12)
        End If
        If Button15.Visible = False Then
            echanger(Button16, Button15)
        End If
        If Button13.Visible = False Then
            echanger(Button16, Button13)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles ButtonPausePlay.Click
        If TimerGame.Enabled = True Then
            TimerGame.Stop()
            PanelButtons.Enabled = False
            PanelButtons.BackColor = Drawing.Color.LavenderBlush
            PanelButtons.BorderStyle = BorderStyle.FixedSingle
        Else
            TimerGame.Start()
            PanelButtons.Enabled = True
            PanelButtons.BackColor = SystemColors.Control
            PanelButtons.BorderStyle = BorderStyle.None
        End If
    End Sub
End Class