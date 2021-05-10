namespace GameTop
{
    public  class JogoFODA
    {
        private readonly IJogador _jogador;

        public JogoFODA(IJogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            _jogador.Corre();
            _jogador.Chuta();
            _jogador.Passe();
        }
    }
}