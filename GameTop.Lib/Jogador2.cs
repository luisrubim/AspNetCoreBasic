using GameTop.Interface;

namespace GameTop.Lib
{
   public class Jogador2 : IJogador
    {        

    public string Chuta()
    {
        return "/nMaradona está chutando xxx \n";
    }

    public string Corre()
    {
        return "Maradona está corendo  xxx\n";
    }

    public string Passa()
    {
        return "Maradona está passando xxxx \n";
    }

    }
}