namespace GameTop
{
    public class Jogador2 : IJogador
    {
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