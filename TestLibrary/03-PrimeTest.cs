using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{

    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void TestPrime2()
        {
            Assert.IsTrue(WP01.Prime.IsPrime(2));
        }
        [TestMethod]
        public void TestPrime3()
        {
            Assert.IsTrue(WP01.Prime.IsPrime(3));
        }
        [TestMethod]
        public void TestPrime4()
        {
            Assert.IsFalse(WP01.Prime.IsPrime(4));
        }
        [TestMethod]
        public void TestPrime5()
        {
            Assert.IsFalse(WP01.Prime.IsPrime(5));
        }

    }
}