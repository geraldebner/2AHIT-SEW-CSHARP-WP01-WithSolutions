using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{

    [TestClass]
    public class StatisticsTest
    {
        [TestMethod]
        public void TestStatisticsMax()
        {
            Assert.AreEqual(WP01.Statistics.Max(1.0,2.0),2.0);
            Assert.AreEqual(WP01.Statistics.Max(-1.0,-2.0),-1.0);
            Assert.AreEqual(WP01.Statistics.Max(1.0,1.0),1.0);
        }

         [TestMethod]
        public void TestStatisticsMin()
        {
            Assert.AreEqual(WP01.Statistics.Min(1.0,2.0),1.0);
            Assert.AreEqual(WP01.Statistics.Min(-1.0,-2.0),-2.0);
            Assert.AreEqual(WP01.Statistics.Min(1.0,1.0),1.0);
        }


    }
}