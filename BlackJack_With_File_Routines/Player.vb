Public Class Player

    Private gamesWon As Integer     ' number of times the player has won
    Private gamesPlayed As Integer  ' number of games played
    Private totalWinnings As Decimal    'total player winnings

    Public Property Won() As Integer
        Get
            Return gamesWon
        End Get
        Set(ByVal value As Integer)
            gamesWon = value
        End Set
    End Property

    Public Property Played() As Integer
        Get
            Return gamesPlayed
        End Get
        Set(ByVal value As Integer)
            gamesPlayed = value
        End Set
    End Property

    Public Property Winnings() As Decimal
        Get
            Return totalWinnings
        End Get
        Set(ByVal value As Decimal)
            totalWinnings = value
        End Set
    End Property

    Public Sub New()
        gamesPlayed = 0
        gamesWon = 0
        totalWinnings = 0
    End Sub

End Class
