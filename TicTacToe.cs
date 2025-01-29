namespace Mission4-1andDone;

public class TicTacToe
{
	public char[] PrintBoard(char[] board, string player1, string player2)
	{
        Console.WriteLine($"\n  {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[6]} | {board[7]} | {board[8]} \n");
    }

	public string CheckWinnter(int[] board, string player1, string player2)
	{
		string winner = "";
		return winner;
	}
}
