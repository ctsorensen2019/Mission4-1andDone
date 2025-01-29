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

	public string CheckWinner(char[] board, string player1, string player2)
	{
		string winner = "";
		return winner;
	}
}
    public string CheckWinner(int[] board, string player1, string player2)
    {
        string winner = "";
        return winner;
    }

    public bool ValidChoice(string numberChoice, string numbersChosen)
    {
        bool result = true; //Default to a valid guess

        if (numberChoice.Length != 1) //Make sure the user only enters one number
        {
            Console.WriteLine("Sorry, the guess has to be only one number. Try again.");
            result = false;
            //return false; // It's generally good practice to use return instead of setting variables while still testing the code so that you can see it's happening
        }
        else if (!Char.IsNumber(numberChoice[0])) //Make sure the user enters a letter and not something else
        {
            Console.WriteLine("Sorry, the guess needs to be a number. Try again.");

        }
        else if (numbersChosen.Contains(numberChoice)) //Check to see if the letter was already guessed
        {
            Console.WriteLine("Sorry, you already guessed that number");
            result = false;
        }
        return result;

    public void UpdateBoard(string numberChoice, char[] board, currentSymbol)
    {

        for (int i = 0; i < board.Length; i++)
        {
            if (numberChoice.Contains(board[i]))
            {
                board[i] = currentSymbol;
            }
        }
    }
}
}
//WAYS TO WIN
// 0 1 2 
// 3 4 5
// 6 7 8
// 0 3 6 
// 1 4 7 
// 2 5 8
// 0 4 8
// 2 4 6