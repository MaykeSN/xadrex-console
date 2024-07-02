using System;
using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void PrintTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++) 
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.GetPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.GetPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
