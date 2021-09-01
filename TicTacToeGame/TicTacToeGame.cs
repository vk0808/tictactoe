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
    }
}
