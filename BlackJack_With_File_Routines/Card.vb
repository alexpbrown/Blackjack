Public Class Card
    Dim Suits() As String = {"Spades", "Diamonds", "Clubs", "Hearts"}
    Dim Faces() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}

    Private mFace As String
    Private mSuit As String
    Protected fValue As Integer
    Protected sValue As Integer

    Public ReadOnly Property Suit() As String
        Get
            Return mSuit
        End Get
    End Property

    Public ReadOnly Property Face() As String
        Get
            Return mFace
        End Get
    End Property

    Public ReadOnly Property FaceValue() As Integer
        Get
            Return fValue
        End Get
    End Property

    Public ReadOnly Property SuitValue() As Integer
        Get
            Return sValue
        End Get
    End Property

    Public ReadOnly Property CardValue() As Integer
        Get
            If fValue = 12 Then
                Return 11
            ElseIf fValue > 7 Then
                Return 10
            Else
                Return fValue + 2
            End If
        End Get
    End Property

    'Constructor for the class, initializes values for the card
    Public Sub New(ByVal newSuit As String, ByVal newFaceVal As String)
        mFace = newFaceVal
        mSuit = newSuit
        fValue = Array.IndexOf(Of String)(Faces, mFace)
        sValue = Array.IndexOf(Of String)(Suits, mSuit)
    End Sub


    'Returns the card as a string (e.g. "6 of Spades" six of spades)
    Public Overrides Function ToString() As String
        Return mFace & " of " & mSuit
    End Function

    'Implement card jpegs as a sub here
End Class
