Public Class Deck
    Dim r As New Random(Now.Millisecond)
    Dim mDeck As New List(Of Card)
    Dim Suits() As String = {"S", "D", "C", "H"}
    Dim Faces() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"}

    'constructor that adds one of each card to the deck
    Public Sub New()
        For Each suit As String In Suits
            For Each face As String In Faces.Reverse
                mDeck.Add(New Card(suit, face))
            Next
        Next
    End Sub

    Public Sub Shuffle()
        Dim card As Card
        Dim cardNum As Integer
        For i As Integer = 0 To 52
            cardNum = r.Next(0, 51) Mod mDeck.Count 'TEST THIS FOR RANDOMNESS
            card = mDeck(cardNum)
            mDeck.RemoveAt(cardNum)
            mDeck.Add(card)
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
