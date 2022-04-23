using tabuleiro;

namespace jogoXadrez
{
    public class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
                
        public override string ToString()
        {
            return "R";
        }
        private bool PodeMover(Posicao posicao)
        {
            var peca = Tabuleiro.Peca(posicao);
            return peca.Posicao == null || peca.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
           
            Posicao posicao = new Posicao(0,0);

            //acima
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //nordeste
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //direita
            posicao.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //sudeste
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //abaixo
            posicao.definirValores(Posicao.Linha +1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //sudoeste
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //esquerda
            posicao.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            //noroeste
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(Posicao))
                matriz[posicao.Linha, posicao.Coluna] = true;

            return matriz;
        }
    }
}
