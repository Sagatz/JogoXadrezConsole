﻿using System;
using Tabuleiro;

namespace JogoXadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroXadrez tab)
        {
            for (int i = 0; i < tab.Linha; i++)
            {
                for (int j = 0; j < tab.Coluna; j++)
                {
                   if (tab.peca(i, j) == null)
                   {
                        Console.Write("- ");
                   }
                   else
                   {
                        Console.Write(tab.peca(i, j) + " ");
                   }
                }

                Console.WriteLine();
            }
        }
    }
}
