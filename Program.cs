﻿using System;
using tabuleiro;
using Xadrez_console;
using xadrez;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            
            while (!partida.terminada) {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
            }
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
