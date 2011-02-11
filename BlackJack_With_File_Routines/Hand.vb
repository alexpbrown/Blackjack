Public Class Hand
    Protected mHand As List(Of Card)

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
End Class
