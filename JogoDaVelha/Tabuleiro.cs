using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    internal class Tabuleiro : ITabuleiro
    {
        private int camposVazios;
        public int CamposVazios
        {
            get { return camposVazios; }
            private set { camposVazios = value; }
        }
        
        public Tabuleiro(){
            camposVazios = 9;
        }
    }
}
