﻿using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroXadrez tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
