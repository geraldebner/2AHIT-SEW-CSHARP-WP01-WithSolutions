using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{

    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void TestLeapYear2000()
        {
            Assert.IsTrue(WP01.LeapYear.IsLeapYear(2000));
        }

        [TestMethod]
        public void TestLeapYear2004()
        {
            Assert.IsTrue(WP01.LeapYear.IsLeapYear(2004));
        }

        [TestMethod]
        public void TestLeapYear2002()
        {
            Assert.IsFalse(WP01.LeapYear.IsLeapYear(2002));
        }

        [TestMethod]
        public void TestLeapYear2020()
        {
            Assert.IsTrue(WP01.LeapYear.IsLeapYear(2020));
        }

        [TestMethod]
        public void TestLeapYear2100()
        {
            Assert.IsFalse(WP01.LeapYear.IsLeapYear(2100));
        }

        public void TestLeapYear2021()
        {
            Assert.IsFalse(WP01.LeapYear.IsLeapYear(2021));
        }


    }
}