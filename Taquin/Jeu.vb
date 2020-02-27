Imports System.IO
Imports System.Windows.Forms

Module Jeu

    Public listeJoueurs As New List(Of Joueur)
    Public timeManager As Double = 360
    Public newPath As String
    Public Const defaultPath = "Joueurs"

    Sub Main()
        Application.Run(Accueil)
    End Sub

    Sub chargerJoueurs(ByVal chemin As String)
        If File.Exists(chemin) Then
            Dim s As String = ""
            Dim SR As StreamReader = File.OpenText(chemin) '

            Do Until SR.Peek = -1
                Dim datas() As String = SR.ReadLine().Split(" ")
                Dim j As New Joueur(datas(0), datas(1), datas(2), datas(3))
                If nouveauJoueur(j.getName()) Then
                    Jeu.listeJoueurs.Add(j)
                End If
            Loop

            SR.Close()
        End If
    End Sub

    Sub enregistrerJoueurs(ByVal chemin As String)
        If File.Exists(chemin) Then

            Dim SW As New StreamWriter(chemin)

            For Each player In Jeu.listeJoueurs
                SW.WriteLine(player.getName & " " & player.getHS & " " & player.getNG & " " & player.getgamingTime)
            Next

            SW.Close()
        Else
            'Création d'un flux d'écriture
            Dim sw As New StreamWriter(chemin)
            'écriture        
            For Each player In Jeu.listeJoueurs
                sw.WriteLine(player.getName & " " & player.getHS & " " & player.getNG & " " & player.getgamingTime)
            Next
        End If
    End Sub



    Sub Ajout(name As String)
        Dim nouveauJoueur As New Joueur(name)
        nouveauJoueur.plays()
        listeJoueurs.Add(nouveauJoueur)
    End Sub

    Function research(name As String) As Joueur
        For Each joueur As Joueur In listeJoueurs
            If joueur.getName.Equals(name) Then
                Return joueur
            End If
        Next

        MsgBox("no player")
        Return Nothing
    End Function

    Function researchHS(hs As Integer) As Joueur
        For Each joueur As Joueur In listeJoueurs
            If joueur.getHS = hs Then
                Return joueur
            End If
        Next

        MsgBox("no player")
        Return Nothing
    End Function

    Function nouveauJoueur(name As String) As Boolean
        For Each player In listeJoueurs
            If player.getName.Equals(name) Then
                Return False
            End If
        Next
        Return True
    End Function
End Module


