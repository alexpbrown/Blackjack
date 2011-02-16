Public Class Hand
    Protected mHand As List(Of Card)

    Public ReadOnly Property Length() As Integer
        Get
            Return mHand.Count
        End Get
    End Property

    'constructor
    Public Sub New()
        mHand = New List(Of Card)
    End Sub

    Public Sub AddCard(ByVal c As Card)
        mHand.Add(c)
    End Sub

    Public Function Cards(ByRef index As Integer) As Card
        Return mHand(index)
    End Function

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

        If aggScore > 21 Then
            MessageBox.Show("Bust!")
        End If

        Return aggScore
    End Function

End Class
