using GameTop.Interface;

namespace GameTop
{
    public class jogoFoda
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public jogoFoda(IJogador jogador1,IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            //System.Console.Write($"{ _jogador._Nome } deu 1 passo");
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write(_jogador1.Passa());

            System.Console.Write("\n proximo jogador");

            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Chuta());
            System.Console.Write(_jogador2.Passa());
        }

    }
}