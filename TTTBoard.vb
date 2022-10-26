Public Class TTTBoard
    'Public boardSize As Integer = 9
    Private Const BoardSize As Integer = 11
    'create an array to represent spaces on the board
    Private board(BoardSize - 1) As String

    'Board look
    '0 1 2
    '3 4 5
    '6 7 8




    'Defult Constructor - It is called when new board() is used in calling code
    Public Sub New()
        resetboard()
    End Sub

    ''' <summary>
    ''' Resets the board so that all spaces hold their numeric place (no Xs or Os)
    ''' </summary>
    Public Sub resetboard()
        For i As Integer = 0 To BoardSize - 1
            board(i) = i.ToString
        Next
    End Sub

    Public Overrides Function Tostring() As String
        Return board(0) & "|" & board(1) & "|" & board(2) & vbNewLine &
                "-----" & vbNewLine &
               board(3) & "|" & board(4) & "|" & board(5) & vbNewLine &
                "-----" & vbNewLine &
               board(6) & "|" & board(7) & "|" & board(8)
    End Function

    ''' <summary>
    ''' Accepts an Indew on the board, verifies it is open and then if
    ''' "X" or "O" is passed in, makes the move
    ''' </summary>
    ''' <param name="spaceindex">Index on the board</param>
    ''' <param name="XorO">an X or O</param>
    ''' <returns>true if successfully placed, false otherwise</returns>
    Public Function UseSpace(spaceindex As Integer, XorO As String) As Boolean
        XorO = XorO.ToUpper.Trim
        'Valid character?
        If XorO <> "X" AndAlso XorO <> "O" Then
            Return False
        End If
        'within range?
        If spaceindex < 0 OrElse spaceindex >= board.Length Then
            Return False
        End If

        'is the space still available
        If board(spaceindex) <> spaceindex.ToString Then
            Return False
        End If
        board(spaceindex) = XorO
        Return True
    End Function
End Class
