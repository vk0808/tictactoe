using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Tic-Tac-Toe Game");

            // Object instantiation
            TicTacToeGame game = new TicTacToeGame();

            // Calling method of TicTacToe class
            game.CreateBoard();

        }
    }
}
