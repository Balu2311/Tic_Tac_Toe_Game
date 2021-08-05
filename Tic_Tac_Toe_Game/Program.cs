using System;

namespace Tic_Tac_Toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacTone Game");
            TicTacToeGame obj = new TicTacToeGame();
            obj.gameBoard();
            obj.abillityToInput();
        }
    }
}
