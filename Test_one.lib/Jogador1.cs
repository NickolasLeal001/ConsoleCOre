using Test_one.Interface;

namespace Test_one.lib
{
    public class Jogador1 : IJogador
{
    public readonly string _Nome;

    public Jogador1(string Nome)
    {
        _Nome = Nome;
    }

    //Chuta
    public string chutar()
    {
        return $"{_Nome} está chutando.";
    }
    //Corre
    public string correr()
    {
        return $"{_Nome} está corrrendo.";
    }
    //Passa
    public string passar()
    {
        return $"{_Nome} está passando.\n";
    }
}
}