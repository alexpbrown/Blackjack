Public Class Card
    Dim Suits() As String = {"S", "D", "C", "H"}
    Dim Faces() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"}

    Private mFace As String
    Private mSuit As String
    Protected cValue As Integer
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

    Public ReadOnly Property CardValue() As Integer
        Get
            Return cValue
        End Get
    End Property

    Public ReadOnly Property SuitValue() As Integer
        Get
            Return sValue
        End Get
    End Property

    'Constructor for the class, initializes values for the card
    Public Sub New(ByVal newSuit As String, ByVal newFaceVal As String)
        mFace = newFaceVal
        mSuit = newSuit
        cValue = Array.IndexOf(Of String)(Faces, mFace)
        sValue = Array.IndexOf(Of String)(Suits, mSuit)
    End Sub


    'Returns the card as a string (e.g. "S6" six of spades)
    Public Overrides Function ToString() As String
        Return mSuit & mFace
    End Function

    'Implement card jpegs as a sub here
End Class
