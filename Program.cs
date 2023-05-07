using System;
using tabuleiro;
using Xadrez_console;
using xadrez;
class Program
{
    static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('c', 7);
        Console.WriteLine(pos);

        Console.WriteLine(pos.toPosicao());

        Console.WriteLine(pos.toPosicao);
    }
}
