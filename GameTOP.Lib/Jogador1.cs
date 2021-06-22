using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Paula")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }

        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }
    }
}
