using System;
using Tabuleiro;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez Tab = new TabuleiroXadrez(8, 8);

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}
