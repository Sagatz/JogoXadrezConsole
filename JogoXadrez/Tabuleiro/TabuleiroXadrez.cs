﻿using Tabuleiro.Exceptions;

namespace Tabuleiro
{
    class TabuleiroXadrez
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        private Peca[,] Pecas;

        public TabuleiroXadrez()
        {
        }

        public TabuleiroXadrez(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pecas = new Peca[Linha, Coluna];
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha > Linha || pos.Coluna < 0 || pos.Coluna > Coluna)
            {
                return false;
            }
            else
            {
                return true;
            }           
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
