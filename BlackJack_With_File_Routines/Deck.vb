Public Class Deck
    Dim r As New Random(Now.Millisecond)
    Dim mDeck As New List(Of Card)
    Dim Suits() As String = {"Spades", "Diamonds", "Clubs", "Hearts"}
    Dim Faces() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}

    'constructor that adds one of each card to the deck
    Public Sub New()
        For Each suit As String In Suits
            For Each face As String In Faces.Reverse
                mDeck.Add(New Card(suit, face))
            Next
        Next
    End Sub

    'Knuth Shuffle!
    Public Sub Shuffle()
        Dim tmpCard As Card
        Dim randCard As Integer
        For i As Integer = mDeck.Count - 1 To 0 Step -1
            randCard = r.Next(i + 1)

            tmpCard = mDeck(i)
            mDeck(i) = mDeck(randCard)
            mDeck(randCard) = tmpCard
        Next
    End Sub

    Public ReadOnly Property TakeCard() As Card
        Get
            Dim removedCard As Card = mDeck(0)
            mDeck.RemoveAt(0)
            Return removedCard
        End Get
    End Property

    Public ReadOnly Property DeckState() As String
        Get
            Dim d As String = ""
            For Each c As Card In mDeck
                d &= c.ToString
            Next
            Return d
        End Get
    End Property
End Class
