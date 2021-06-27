using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Bruno está Chutando \n";
        }

        public string Corre()
        {
            return "Bruno está Correndo \n";
        }

        public string Passe()
        {
            return "Bruno está Passando \n";
        }
    }
}