using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    internal class Tabuleiro : ITabuleiro
    {
        private const int Colunas = 3;
        private const int Linhas = 3;

        private int camposVazios;
        public int CamposVazios
        {
            get { return camposVazios; }
            private set { camposVazios = value; }
        }
        
        private char[,] _tabuleiro {get;set;}

        public Tabuleiro(){
            camposVazios = Colunas * Linhas;
            _tabuleiro = new char[Colunas, Linhas];

            //inicializando o tabuleiro
            for (int col = 0; col < Colunas; col++){
                for (int lin = 0; lin < Linhas; lin++){
                    _tabuleiro[col, lin] = 0;
                }
            }
        }

        public void ExecutarJogada(int x, int y, char simbolo){
            _tabuleiro[x, y] = simbolo;
        }
    }
}
