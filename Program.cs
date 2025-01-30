using Mission4;

internal class Program
{
    public static void Main(string[] args)
    {
        string player1 = "";
        string player2 = "";
        string winner = "";
        string currentplayer = player1;
        char currentSymbol = 'X';

        //Making an array of length 9
        char[] board = new char[9];

        //Welcome Message to Players
        Console.WriteLine("Welcome to the Tic-Tac-Toe!");
        Console.WriteLine("Player 1 will use 'X' and Player 2 will use 'O'.\n");
        
        Console.WriteLine("Type the name of Player 1: ");
        player1 = Console.ReadLine();
        
        Console.WriteLine("Type the name of Player 2: ");
        player2 = Console.ReadLine();

        TicTacToe tb = new TicTacToe();

        //adding numbers as characters to board array
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (i + 1).ToString()[0]; //Filling the board with numbers 1-9 as characters not int
        }

        //While game is running
                  
        while (tb.CheckWinner(board, currentSymbol) == false)
        {
            tb.PrintBoard(board);
            
            // Next players turn. Updates board with their choice.
            Console.WriteLine($"It's {(currentSymbol == 'X' ? player1 : player2)}'s turn: ");
            tb.UpdateBoard(board, currentSymbol);
            
            // Ends the game before another switch can occur
            if (tb.CheckWinner(board, currentSymbol)) 
            {
                break;                               
            }
            
            if (tb.IsBoardFull(board))
            {
                break;
            }
            // Switches player1 to player 2 and vice versa
            currentSymbol = (currentSymbol == 'X') ? 'O' :  'X';
        }
        if (tb.CheckWinner(board, currentSymbol) == true)
        {
            if (currentSymbol == 'X') {
                winner = player1;
            }
            else
            {
                winner = player2;
            }
            
            // Prints the winner and final game board
            Console.WriteLine($"The winner is {winner}");
            tb.PrintBoard(board);
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("It's a draw!");
            tb.PrintBoard(board);
            Environment.Exit(0);
        }

    }
}

