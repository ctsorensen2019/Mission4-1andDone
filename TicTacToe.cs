namespace Mission4;

public class TicTacToe
{
	public char[] PrintBoard(char[] board, string player1, string player2)
	{
        Console.WriteLine($"\n  {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[6]} | {board[7]} | {board[8]} \n");
		return board;
    }

	public Boolean CheckWinner(char[] board, string player1, string player2, char currentSymbol)
	{
		Boolean winner = false;
        
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                winner = true;
            }
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                winner = true;
            }
        }
        if (board[0] == board[1, 1] && board[1, 1] == board[8])
        {
            winner = true;
        }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            winner = true;
        }

        return winner;
	}
}
