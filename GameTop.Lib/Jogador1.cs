using GameTop.Interface;

namespace GameTop.Lib
{
   public class Jogador1 : IJogador
    {        
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

    public string Chuta()
    {
        return $"{_Nome} está chutando \n";
    }

    public string Corre()
    {
        return $"{_Nome} está corendo \n";
    }

    public string Passa()
    {
        return $"{_Nome} está passando \n";
    }

    }
}