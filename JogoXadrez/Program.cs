using System;
using Tabuleiro;
using Xadrez;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez Tab = new TabuleiroXadrez(8, 8);

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta) , new Posicao(0, 0));
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 3));
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}
