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

        {
            int[,] winningCombinations = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
            { 0, 4, 8 }, { 2, 4, 6 } // Diagonals
        };

            foreach (var combo in winningCombinations)
            {
                if (board[combo[0]] == board[combo[1]] && board[combo[1]] == board[combo[2]])
                    winner = true;
            }

        }

        return winner;
	}
}
