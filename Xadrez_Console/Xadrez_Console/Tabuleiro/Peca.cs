
using Tabuleiro;
using Xadrez_Console.Tabuleiro;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public TabuleiroP tab { get; set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroP tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            qtdMovimentos = 0;
        }
    }
}
