using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        readonly BowlingGame _game = new BowlingGame();
        [TestMethod]
        public void Check_ActualScenario()
        {
            _game.RollStrike();
            _game.Roll(9, 1);
            _game.Roll(5, 5);
            _game.Roll(7, 2);
            _game.RollStrike();
            _game.RollStrike();
            _game.RollStrike();
            _game.Roll(9, 0);
            _game.Roll(8, 2);
            _game.RollFinalFrame(9, 1, 10);
            Assert.AreEqual(187, _game.GetScore());
        }

    }
}
