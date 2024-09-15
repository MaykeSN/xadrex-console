using System;
using System.Collections.Generic;
using System.Linq;
using xadrez;
using System.Net.Http.Headers;
using System.Text;
using tabuleiro;
using System.Threading.Tasks;
using Xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Torre torre = new Torre(tabuleiro, Cor.Preta);
            Torre torreBranca = new Torre(tabuleiro, Cor.Branca);
            tabuleiro.InsertPeca(torre, new Posicao(0,0));
            tabuleiro.InsertPeca(torreBranca, new Posicao(0,1));
            
            Tela.PrintTabuleiro(tabuleiro);

            Console.ReadKey();
        }
    }
}
