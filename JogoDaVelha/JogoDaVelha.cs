using System;

namespace JogoDaVelha
{
    public class JogoDaVelhaGame : IjogoDaVelha
    {
        private Tabuleiro _tabuleiro { get; set;}

        public JogoDaVelhaGame(){
            _tabuleiro = new Tabuleiro();
        }

        public int ContarCamposVazios(){
            return _tabuleiro.CamposVazios;
        }

        public void ExecutarMovimento(int x, int y){

        }
    }
}
