using Test_one.Interface;

namespace Test_one.lib
{
    public class Jogador2 : IJogador
    {
        public string chutar()
        {
            return "Maradona estas pateando.";
        }

        public string correr()
        {
            return "Maradona estas corriendo.";
        }

        public string passar()
        {
            return "Maradona estas passeando.";
        }
    }
}