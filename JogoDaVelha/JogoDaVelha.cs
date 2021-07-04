using System;

namespace JogoDaVelha
{
    public class JogoDaVelhaGame : IjogoDaVelha
    {
        private Tabuleiro _tabuleiro { get; set;}
        private char _simboloDoJogador { get; set; }

        public JogoDaVelhaGame(){
            _tabuleiro = new Tabuleiro();
            _simboloDoJogador = 'X';
        }

        public int ContarCamposVazios(){
            return _tabuleiro.CamposVazios;
        }

        public void ExecutarMovimento(int x, int y){
            _tabuleiro.ExecutarJogada(x, y, _simboloDoJogador);

            if (_simboloDoJogador == 'X')
                _simboloDoJogador = 'Y';
            else
                _simboloDoJogador = 'X';
        }
    }
}
