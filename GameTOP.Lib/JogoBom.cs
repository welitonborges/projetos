using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class JogoBom
    {
        public JogoBom(iJogador jogador)
        {
            _jogador = jogador;
        }

        private readonly iJogador _jogador;

        public void IniciarJogo()
        {
            _jogador.Chuta();
            _jogador.Corre();
            _jogador.Passe();
        }
    }
}