using tabuleiro;

namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
        }
        public void IncrementarMovimento()
        {
            QtdMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}
