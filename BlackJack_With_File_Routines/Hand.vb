Public Class Hand
    Protected mHand As List(Of Card)
    Private fin As Boolean = False

    Public ReadOnly Property Length() As Integer
        Get
            Return mHand.Count
        End Get
    End Property

    'constructor
    Public Sub New()
        mHand = New List(Of Card)
        fin = False
    End Sub

    Public Sub AddCard(ByVal c As Card)
        mHand.Add(c)
    End Sub

    Public Sub RemoveCard(ByVal i As Integer)
        mHand.RemoveAt(i)
    End Sub

    Public ReadOnly Property Cards(ByVal index As Integer) As Card
        Get
            Return mHand(index)
        End Get
    End Property

    Public Property Finished() As Boolean
        Get
            Return fin
        End Get
        Set(ByVal value As Boolean)
            fin = value
        End Set
    End Property

    Public ReadOnly Property Blackjack() As Boolean
        Get
            If mHand.Count = 2 And Score() = 21 Then
                fin = True
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Sub Clear()
        mHand.Clear()
    End Sub

    'calculates the score of the hand
    Function Score() As Integer
        Dim aggScore As Integer = 0
        Dim numAces As Integer = 0
        Dim cValue As Integer
        For i As Integer = 0 To mHand.Count - 1
            cValue = mHand(i).CardValue
            If cValue = 11 Then
                numAces += 1
            End If
            aggScore += cValue
        Next

        'while the score is over 21, subtract 10 for each ace present in the hand
        For i As Integer = numAces To 1 Step -1
            If aggScore > 21 Then
                aggScore -= 10
            End If
        Next

        Return aggScore
    End Function

End Class
