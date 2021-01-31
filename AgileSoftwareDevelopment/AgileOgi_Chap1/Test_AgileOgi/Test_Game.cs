using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileOgi_Chap1.BowlingGame;

namespace Test_AgileOgi
{
    [TestClass]
    public class Test_Game
    {
        //[TestMethod]
        //public void TestOneThrow()
        //{
        //    var g = new Game();
        //    g.Add(5);
        //    Assert.AreEqual(5, g.Score());
        //    Assert.AreEqual(1, g.GetCurrentFrame());
        //}
        [TestMethod]
        public void TestTwoThrowsNoMark()
        {
            var g = new Game();
            g.Add(5);
            g.Add(4);
            Assert.AreEqual(9, g.Score());
            Assert.AreEqual(2, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestFourThrowsNoMark()
        {
            var g = new Game();
            g.Add(5);
            g.Add(4);
            g.Add(7);
            g.Add(2);
            Assert.AreEqual(18, g.Score());
            Assert.AreEqual(9, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
            Assert.AreEqual(3, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestSimpleSpare()
        {
            var g = new Game();
            g.Add(3);
            g.Add(7);
            g.Add(3);
            Assert.AreEqual(13, g.ScoreForFrame(1));
            Assert.AreEqual(2, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestSimpleFrameAfterSpare()
        {
            var g = new Game();
            g.Add(3);
            g.Add(7);
            g.Add(3);
            g.Add(2);
            Assert.AreEqual(13, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
            Assert.AreEqual(18, g.Score());
            Assert.AreEqual(3, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestSimpleStrike()
        {
            var g = new Game();
            g.Add(10);
            g.Add(3);
            g.Add(6);
            Assert.AreEqual(19, g.ScoreForFrame(1));
            Assert.AreEqual(28, g.Score());
            Assert.AreEqual(3, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestPerfectGame()
        {
            var g = new Game();
            for(int i = 0; i < 12; i++)
                g.Add(10);
            Assert.AreEqual(300, g.Score());
            Assert.AreEqual(11, g.GetCurrentFrame());
        }
        [TestMethod]
        public void TestEndOfArray()
        {
            var g = new Game();
            for(int i = 0; i < 9; i++)
            {
                g.Add(0);
                g.Add(0);
            }
            // 10番目のフレームでスペア
            g.Add(2);
            g.Add(8);
            // 配列の最後にストライク
            g.Add(10);
            Assert.AreEqual(20, g.Score());
        }
        [TestMethod]
        public void TestSampleGame()
        {
            var g = new Game();
            g.Add(1);
            g.Add(4);
            g.Add(4);
            g.Add(5);
            g.Add(6);
            g.Add(4);
            g.Add(5);
            g.Add(5);
            g.Add(10);
            g.Add(0);
            g.Add(1);
            g.Add(7);
            g.Add(3);
            g.Add(6);
            g.Add(4);
            g.Add(10);
            g.Add(2);
            g.Add(8);
            g.Add(6);
            Assert.AreEqual(133, g.Score());
        }
        [TestMethod]
        public void TestHeartBreak()
        {
            var g = new Game();
            for (int i = 0; i < 11; i++)
                g.Add(10);
            g.Add(9);
            Assert.AreEqual(299, g.Score());
        }
        [TestMethod]
        public void TestTenthFrameSpare()
        {
            var g = new Game();
            for (int i = 0; i < 9; i++)
                g.Add(10);
            g.Add(9);
            g.Add(1);
            g.Add(1);
            Assert.AreEqual(270, g.Score());
        }
    }
}
