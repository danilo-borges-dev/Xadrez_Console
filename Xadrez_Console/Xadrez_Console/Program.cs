using System;
using Tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroP tab = new TabuleiroP(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
