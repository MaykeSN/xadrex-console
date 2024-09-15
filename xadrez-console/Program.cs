using System;
using System.Collections.Generic;
using System.Linq;
using xadrez;
using System.Net.Http.Headers;
using System.Text;
using tabuleiro;
using System.Threading.Tasks;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.InsertPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
            tab.InsertPeca(new Rei(tab, Cor.Branca), new Posicao(0,0));
            Tela.PrintTabuleiro(tab);
            Console.ReadKey();
        }
    }
}
