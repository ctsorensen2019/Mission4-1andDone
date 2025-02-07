﻿namespace Mission4;

public class TicTacToe
{

    public void PrintBoard(char[] board)

    {
        Console.WriteLine($"\n  {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine(" ---+---+---");
        Console.WriteLine($"  {board[6]} | {board[7]} | {board[8]} \n");
    }

	public Boolean CheckWinner(char[] board, char currentSymbol)
	{
		Boolean winner = false;

        {
            int[,] winningCombinations = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
            { 0, 4, 8 }, { 2, 4, 6 } // Diagonals
        };
            // Updated logic to allow you to pull array combinations from winningCombinations
            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];
                
                // Compares symbol placement to winning locations
                if (board[a] == currentSymbol &&
                    board[b] == currentSymbol &&
                    board[c] == currentSymbol)
                {
                    winner = true;
                }
            }

        }

        return winner;
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
    
    public bool IsBoardFull(char[] board)
    {
        foreach (char spot in board)
        {
            if (char.IsDigit(spot))
            {
                return false;
            }
        }
        return true;
    }

    public void UpdateBoard(char[] board, char currentSymbol)
    {
        int index;
        bool validChoice = false;

        while (!validChoice) // Keep asking until a valid choice is made
        {
            Console.Write("Enter a number: ");
            string numberChoice = Console.ReadLine(); // Get user input

            // Ensure valid number input
            if (!int.TryParse(numberChoice, out index))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            index -= 1; // Convert 1-based input to 0-based index

            // Check if index is within board range
            if (index < 0 || index >= board.Length)
            {
                Console.WriteLine("Invalid move. Number is out of bounds.");
                continue;
            }

            // Check if the position is already occupied
            if (!char.IsNumber(board[index]))
            {
                Console.WriteLine("That spot is already taken! Choose a different number.");
                continue;
            }

            // If everything is valid, update the board
            board[index] = currentSymbol;
            validChoice = true; // Exit the loop
        }
    }




}
