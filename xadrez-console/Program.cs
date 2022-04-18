using System;
using tabuleiro;
using jogoXadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
               PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem : ");
                    Posicao origem = Tela.LerPosicaoxadrez().toPosicao();
                    Console.Write("Destino : ");
                    Posicao destino = Tela.LerPosicaoxadrez().toPosicao();

                    partida.ExecultaMovimento(origem, destino);

                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
