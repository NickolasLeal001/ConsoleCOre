using System;
using Test_one.Interface;

namespace Test_one
{
    public class JogoFODA
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;
        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo ()
        {
            Console.WriteLine(_jogador1.chutar());
            Console.WriteLine(_jogador1.correr());
            Console.WriteLine(_jogador1.passar());

            Console.WriteLine(_jogador2.chutar());
            Console.WriteLine(_jogador2.correr());
            Console.WriteLine(_jogador2.passar());
        }

    }

}