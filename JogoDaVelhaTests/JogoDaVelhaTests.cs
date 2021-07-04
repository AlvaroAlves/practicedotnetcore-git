using NUnit.Framework;

namespace JogoDaVelha.Tests
{
    public class CoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CamposVaziosDevemSerIguaisA9EmUmNovoJogo()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            Assert.AreEqual(9, jogoDaVelha.ContarCamposVazios());
        }

        [Test]
        public void CamposVaziosDevemDiminuirAoExecutarUmMovimento()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            var camposVaziosIniciais = 9;

            Assert.AreEqual(camposVaziosIniciais, jogoDaVelha.ContarCamposVazios());
        
            jogoDaVelha.ExecutarMovimento(0, 1);

            Assert.AreEqual(camposVaziosIniciais - 1, jogoDaVelha.ContarCamposVazios());
        
        }

        [Test]
        public void ColunaForaDoRangeDoTabuleiroDevemGerarErro()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            
            Assert.Throws<InvalidMoveException>(() => { jogoDaVelha.ExecutarMovimento(10, 1);});

        }

        [Test]
        public void LinhaForaDoRangeDoTabuleiroDevemGerarErro()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            
            Assert.Throws<InvalidMoveException>(() => { jogoDaVelha.ExecutarMovimento(10, 1);});

        }
    }
}