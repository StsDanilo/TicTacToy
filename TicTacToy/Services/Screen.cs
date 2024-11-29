using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToy.Services
{
    internal static class Screen
    {
        public static void PrintScreen(string[,] board)
        {
            Printchar(" " + board[0, 0]);
            Printchar("|");
            Printchar(board[0, 1]);
            Printchar("|");
            Printchar(board[0, 2]);
            Console.WriteLine();

            Printchar(" -+-+-");
            Console.WriteLine();

            Printchar(" " + board[1, 0]);
            Printchar("|");
            Printchar(board[1, 1]);
            Printchar("|");
            Printchar(board[1, 2]);
            Console.WriteLine();

            Printchar(" -+-+-");
            Console.WriteLine();

            Printchar(" " + board[2, 0]);
            Printchar("|");
            Printchar(board[2, 1]);
            Printchar("|");
            Printchar(board[2, 2]);
            Console.WriteLine();
        }

        private static void Printchar(string text)
        {
            if (text == "X" || text == " X")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text);
                Console.ResetColor();
            }
            else if (text == "O" || text == " O")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(text);
                Console.ResetColor();
            }
            else if (text == "|" || text == " -+-+-")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(text);
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(text);
                Console.ResetColor();
            }

        }
    }
}
