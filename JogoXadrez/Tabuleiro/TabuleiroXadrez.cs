namespace Tabuleiro
{
    class TabuleiroXadrez
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        private Peca[,] Pecas;

        public TabuleiroXadrez(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pecas = new Peca[Linha, Coluna];
        }
    }
}
