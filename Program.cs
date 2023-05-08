using System;
using tabuleiro;
using Xadrez_console;
using xadrez;
class Program
{
    static void Main(string[] args)
    {

        PartidaDeXadrez partida = new PartidaDeXadrez();

        while (!partida.terminada)
        {
            try
            {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
                Console.Write("Turno: " + partida.turno);

                Console.WriteLine();
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                Console.WriteLine();
                Console.Write("origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                partida.validarPosicaoDeOrigem(origem);

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.WriteLine();
                Console.Write("destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                partida.validarPosicaoDeDestino(origem, destino);
                partida.realizaJogada(origem, destino);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
         }
    }
}
