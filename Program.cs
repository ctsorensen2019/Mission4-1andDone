using TicTacToe;

internal class Program
{
    public static void Main(string[] args)
    {
        string player1 = "";
        string player2 = "";

        //Making an array of length 9
        char[] board = new char[9];

        //Welcome Message to Players
        Console.WriteLine("Welcome to the Tic-Tac-Toe!");
        Console.WriteLine("Player 1 will use 'X' and Player 2 will use 'O'.\n");
        Console.WriteLine("Type the name of Player 1: ");
        player1 = Console.ReadLine();
        Console.WriteLine("Type the name of Player 2: ");
        player2 = Console.ReadLine();

        //adding numbers as characters to board array
        for (int i = 0;i < board.Length; i++)
        {
            board[i] = (i + 1).ToString()[0]; //Filling the board with numbers 1-9 as characters not int
        }
    }
}
