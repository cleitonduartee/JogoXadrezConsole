using tabuleiro;

namespace jogoXadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
        private bool PodeMover(Posicao posicao)
        {
            var peca = Tabuleiro.Peca(posicao);
            return peca.Posicao == null || peca.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //acima
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                    break;

                posicao.Linha -= -1;
            }

            //abaixo
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                    break;

                posicao.Linha -= +1;
            }

            //direito
            posicao.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                    break;

                posicao.Coluna -= +1;
            }

            //esquerda
            posicao.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                    break;

                posicao.Coluna -= 1;
            }


            return matriz;
        }
    }
}
