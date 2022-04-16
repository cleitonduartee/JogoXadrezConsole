using System;
using tabuleiro;
using jogoXadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());



            //try
            //{
            //    Tabuleiro tab = new(8, 8);
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //    Tela.ImprimirTabuleiro(tab);
            //}catch (TabuleiroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
        }
    }
}
