using Tabuleiro;
using Xadrez_Console.Tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(TabuleiroP tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
