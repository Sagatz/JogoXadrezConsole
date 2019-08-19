namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int MovCount { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor, int movCount, TabuleiroXadrez tab)
        {
            Posicao = posicao;
            Cor = cor;
            MovCount = movCount;
            Tab = tab;
        }

    }
}
