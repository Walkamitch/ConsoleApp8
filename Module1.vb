Module Module1
    'Walker Owens
    '10/26/2022
    'using a class for Tic Tac Toe
    Sub Main()
        Console.WriteLine("Tic Tac Toe by Walker Owens!")
        Dim myboard As New TTTBoard
        myboard.resetboard()
        Dim gameover As Boolean = False
        Do
            Dim valid As Boolean = False
            Dim input As String
            Dim usermove As Integer
            'single turn
            Do
                Printboard(myboard)
                Console.Write("Enter the space you want to play -> ")
                input = Console.ReadLine
                If (Integer.TryParse(input, usermove)) Then
                    valid = myboard.UseSpace(usermove, "X")
                    If Not valid Then
                        Console.WriteLine("Invalid move")
                    End If
                Else
                    Console.WriteLine("Please enter an integer")
                End If
            Loop While Not valid
        Loop While Not gameover '(while gameover = false)

    End Sub

    Sub Printboard(theboard As TTTBoard)
        Console.WriteLine(theboard.ToString())
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(0), theboard.board(1), theboard.board(2))
        'Console.WriteLine("-----")
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(3), theboard.board(4), theboard.board(5))
        'Console.WriteLine("-----")
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(6), theboard.board(7), theboard.board(8))
    End Sub
End Module
