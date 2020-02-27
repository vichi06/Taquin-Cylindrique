Public Class Joueur
    Dim name As String
    Dim highScore As Integer
    Dim nbGames As Integer
    Dim gamingTime As Integer

    Sub New(n As String)
        name = n
        nbGames = 0
        highScore = Nothing
        gamingTime = 0
    End Sub

    Sub New(n As String, hs As Integer, nbG As Integer, gt As Integer)
        name = n
        highScore = hs
        nbGames = nbG
        gamingTime = gt
    End Sub
    Sub rejoue()
        nbGames += 1
    End Sub
    Sub won(temps As Integer)
        If highScore = Nothing Or temps <= highScore Then
            highScore = temps
        End If
    End Sub
    Sub addGT(time As Integer)
        gamingTime += time
    End Sub
    Sub plays()
        nbGames += 1
    End Sub
    Function getName()
        Return name
    End Function
    Function getNG()
        Return nbGames
    End Function
    Function getHS()
        Return highScore
    End Function
    Function getgamingTime()
        Return gamingTime
    End Function
End Class