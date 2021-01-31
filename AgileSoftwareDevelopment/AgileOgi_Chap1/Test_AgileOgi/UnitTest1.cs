using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileOgi_Chap1;

namespace Test_AgileOgi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1, b = 2;
            int c = a + b;
            Assert.AreEqual(c, 3);
        }
        [TestMethod]
        public void NullArray()
        {
            int[] array = PrimeGenerator.GeneratePrimes(0);
            Assert.AreEqual(array.Length, 0);
        }
        [TestMethod]
        public void MinArray()
        {
            int[] array = PrimeGenerator.GeneratePrimes(2);
            Assert.AreEqual(array.Length, 1);
            Assert.AreEqual(array[0], 2);
        }
        [TestMethod]
        public void ThreeArray()
        {
            int[] array = PrimeGenerator.GeneratePrimes(3);
            Assert.AreEqual(array.Length, 2);
            Assert.AreEqual(array[0], 2);
            Assert.AreEqual(array[1], 3);
        }
        [TestMethod]
        public void CentArray()
        {
            int[] array = PrimeGenerator.GeneratePrimes(100);
            Assert.AreEqual(array.Length, 25);
            Assert.AreEqual(array[24], 97);
        }
    }
}
