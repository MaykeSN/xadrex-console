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

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine();
            Console.WriteLine(pos.ToPosition());

            Console.ReadKey();
        }
    }
}
