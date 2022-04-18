using jogoXadrez;
using System;
using tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int linha=0;linha<tabuleiro.Linhas; linha++)
            {
                Console.Write(8 - linha + " ");
                for(int coluna =0; coluna < tabuleiro.Colunas; coluna++)
                {
                    if (tabuleiro.Peca(linha, coluna) == null)
                        Console.Write("- ");
                    else
                        ImprimirPeca(tabuleiro.Peca(linha, coluna));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca (Peca peca)
        {
            if(Cor.Branco.Equals(peca.Cor))
                Console.Write(peca + " ");
            else
            {
                ConsoleColor corAtual = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = corAtual;
            }
        }
        public static PosicaoXadrez LerPosicaoxadrez()
        {
            String valorInformado = Console.ReadLine();
            char coluna = valorInformado[0];
            int linha = int.Parse(valorInformado[1]+"");
            return new PosicaoXadrez(coluna, linha);

        }

    }
}
