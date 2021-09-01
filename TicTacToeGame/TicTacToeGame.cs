using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        // instance variable
        public char[] board;

        // constructor
        public TicTacToeGame()
        {
            board = new char[10];
        }

        // method to create empty board
        public void CreateBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = '-';
            }
        }

        // method to play game
        public void PlayGame()
        {
            Console.Write("\nEnter youy choice: ");
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice.ToLower() == "x")
                {
                    Console.WriteLine("\nComputer choice is \'O\'");
                    break;
                }
                else if (choice.ToLower() == "o")
                {
                    Console.WriteLine("\nComputer choice is \'X\'");
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong choice");
                    break;
                }
            }
        }

        // method to display the board
        public void Display()
        {
            Console.Write($"{new string('-', 13)}\n");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i + j]} | ");
                }
                Console.WriteLine("");
            }
            Console.Write($"{new string('-', 13)}\n");
        }
    }
}
