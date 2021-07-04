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
        public void ContarCamposVazios_CamposVaziosDevemSerIguaisA9EmUmNovoJogo()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            Assert.AreEqual(9, jogoDaVelha.ContarCamposVazios());
        }

        [Test]
        public void ContarCamposVazios_CamposVaziosDevemDiminuirAoExecutarUmMovimento()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            var camposVaziosIniciais = 9;

            Assert.AreEqual(camposVaziosIniciais, jogoDaVelha.ContarCamposVazios());
        
            jogoDaVelha.ExecutarMovimento(0, 1);

            Assert.AreEqual(camposVaziosIniciais - 1, jogoDaVelha.ContarCamposVazios());
        
        }

        [Test]
        public void ExecutarMovimento_ColunaForaDoRangeDoTabuleiroDevemGerarErro()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            
            Assert.Throws<InvalidMoveException>(() => { jogoDaVelha.ExecutarMovimento(10, 1);});

        }

        [Test]
        public void ExecutarMovimento_LinhaForaDoRangeDoTabuleiroDevemGerarErro()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            
            Assert.Throws<InvalidMoveException>(() => { jogoDaVelha.ExecutarMovimento(1, 10);});

        }

         [Test]
        public void ExecutarMovimento_RealizarJogadaEmCasaOcupadaDeveGerarErro()
        {
            var jogoDaVelha = new JogoDaVelhaGame();
            
            jogoDaVelha.ExecutarMovimento(0, 1);
            Assert.Throws<InvalidMoveException>(() => { jogoDaVelha.ExecutarMovimento(0, 1);});

            
        }
    }
}