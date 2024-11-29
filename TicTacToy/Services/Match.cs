using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToy.Entities;

namespace TicTacToy.Services
{
    internal static class Match
    {

        public static void InterpretPlay(string[,] board, string letter, string symbol)
        {
            switch (letter)
            {
                case "a":
                    board[0, 0] = symbol;
                    break;
                case "b":
                    board[0, 1] = symbol;
                    break;
                case "c":
                    board[0, 2] = symbol;
                    break;
                case "d":
                    board[1, 0] = symbol;
                    break;
                case "e":
                    board[1, 1] = symbol;
                    break;
                case "f":
                    board[1, 2] = symbol;
                    break;
                case "g":
                    board[2, 0] = symbol;
                    break;
                case "h":
                    board[2, 1] = symbol;
                    break;
                case "i":
                    board[2, 2] = symbol;
                    break;
            }

        }

        public static bool CheckVictory(string[,] board, string symbol)
        {

            if (board[0,0] == symbol && board[0,1] == symbol && board[0,2] == symbol)
            {
                //linha horizontal superior
                return true;
            } else if(board[1, 0] == symbol && board[1, 1] == symbol && board[1, 2] == symbol)
            {
                //linha horizontal centro
                return true;
            }else if(board[2, 0] == symbol && board[2, 1] == symbol && board[2, 2] == symbol)
            {
                //linha horizontal inferior
                return true;
            }else if(board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol)
            {
                //linha vertical esquerda
                return true;
            }else if(board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol)
            {
                //linha vertical centro
                return true;
            }else if(board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol)
            {
                //linha vertical direita
                return true;
            }else if(board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            {
                //diagonal principal
                return true;
            }else if(board[2, 0] == symbol && board[1, 1] == symbol && board[0, 2] == symbol)
            {
                //diagonal secundária
                return true;
            }else
            {
                return false;
            }


        }
    }
}
