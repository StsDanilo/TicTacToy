using System.Data;
using TicTacToy.Services;

namespace TicTacToy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = {
            {"a", "b", "c" },
            {"d", "e", "f" },
            {"g", "h", "i" }
            };

            bool ended = false;
            int round = 1;
            string jogadorAtual = "X";

            while (!ended)
            {
                Console.Clear();
                Screen.PrintScreen(board);
                if (Match.CheckVictory(board, jogadorAtual))
                {
                    Console.WriteLine("Vitoria do " +  jogadorAtual);
                    ended = true;
                    break;
                } else if(round == 10)
                {
                    Console.WriteLine("Empate");
                    ended = true;
                    break;
                }

                Console.WriteLine("Escolha uma posição para jogar:");
                Console.Write("Jogador Atual:");
                if (round % 2 == 0)
                {
                    Console.WriteLine("O");
                    jogadorAtual = "O";
                } else
                {
                    Console.WriteLine("X");
                    jogadorAtual = "X";
                }
                string posicao = Console.ReadLine().ToLower();
                Match.InterpretPlay(board, posicao, jogadorAtual);
                round++;
            }
        }
    }
}
