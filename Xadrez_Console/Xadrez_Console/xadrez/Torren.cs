using Tabuleiro;
using Xadrez_Console.Tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(TabuleiroP tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
