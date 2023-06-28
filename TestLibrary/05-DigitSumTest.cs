using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{

    [TestClass]
    public class DigitSumTest
    {
        [TestMethod]
        public void TestDigitSum1000()
        {
            Assert.AreEqual(WP01.DigitSum.CalcDigitSum(1000),1);
        }
        [TestMethod]
        public void TestDigitSum333()
        {
            Assert.AreEqual(WP01.DigitSum.CalcDigitSum(333),9);
        }
        [TestMethod]
        public void TestDigitSum123()
        {
            Assert.AreEqual(WP01.DigitSum.CalcDigitSum(123),6);
        }
        [TestMethod]
        public void TestDigitSum1001()
        {
            Assert.AreEqual(WP01.DigitSum.CalcDigitSum(1001),2);
        }    
    }
}