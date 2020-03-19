using System;
using Test_one.lib;

namespace Test_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Ronaldo"), new Jogador2());
            jogo.IniciarJogo();
        }
    }

}
