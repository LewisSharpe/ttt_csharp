﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MINIMAX
namespace Minimax_TPL
{
    // HUMAN Player_TPL INHERITS QUALITIES OF Player_TPL
    class HumanPlayer_TPL : Player_TPL
    {
        public HumanPlayer_TPL(string _name, counters _counter) : base(_counter)
        {
            name = _name;
        }

   // GET MOVE: ASK FOR USER INPUT
        public override Tuple<int, int> GetMove(GameBoard_TPL<counters> board, GameBoard_TPL<int> scoreBoard)
        {
            int x; // x axis
            int y; // y axis
            Console.WriteLine("It's {0}'s turn.", name); // promp input
            Console.WriteLine();
            do // start do loop
            {
                Console.Write("Enter x coordinate: ");
                while (!(int.TryParse(Console.ReadKey().KeyChar.ToString(), out x) && (x >= 1 && x <= 7)))
                    Console.Write("\nInvalid input. Try again: ");
                Console.Write("\nEnter y coordinate: ");
                while (!(int.TryParse(Console.ReadKey().KeyChar.ToString(), out y) && (y >= 1 && y <= 7)))
                    Console.Write("\nInvalid input. Try again: ");
            } while (!CheckValidMove(board, x, y));
            return new Tuple<int, int>(x, y); // ask for valid coords
        } // end do loop

        // CHECK IF MOVE IS VALID
        public bool CheckValidMove(GameBoard_TPL<counters> board, int x, int y)
        {
            if (board[x, y] == counters.EMPTY) // if move coords match empty cell
                return true;  // place move
            Console.WriteLine("\nThere is already a counter at ({0}, {1}). Try again.", x, y);
            // Debug.Assert();
            return false;
        }
    }
}