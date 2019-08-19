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

        public Peca(Cor cor, TabuleiroXadrez tab)
        {
            Posicao = null;
            Cor = cor;
            MovCount = 0;
            Tab = tab;
        }

    }
}
