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
    }
}