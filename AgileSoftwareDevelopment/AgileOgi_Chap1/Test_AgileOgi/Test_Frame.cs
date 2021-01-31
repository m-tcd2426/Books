using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileOgi_Chap1.BowlingGame;

namespace Test_AgileOgi
{
    [TestClass]
    public class Test_Frame
    {
        [TestMethod]
        public void TestScoreNoThrows()
        {
            var f = new Frame();
            Assert.AreEqual(0, f.GetScore());
        }
        [TestMethod]
        public void TestAddOneThrow()
        {
            var f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.GetScore());
        }
    }
}