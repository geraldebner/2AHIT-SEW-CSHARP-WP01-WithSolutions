using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace test_library;

[TestClass]
public class UnitTest_01_Triangle11
{
   [TestMethod]
    public void leap_year_Test_2000()
    {
        Assert.IsTrue( WP01.leapYear.CheckIfLeapYear(2000));
    }

    [TestMethod]
    public void leap_year_Test_2004()
    {
        Assert.IsTrue( WP01.leapYear.CheckIfLeapYear(2004));
    }

    [TestMethod]
    public void leap_year_Test_2002()
    {
        Assert.IsFalse( WP01.leapYear.CheckIfLeapYear(2002));
    }

    [TestMethod]
    public void leap_year_Test_2020()
    {
        Assert.IsTrue( WP01.leapYear.CheckIfLeapYear(2020));
    }

    [TestMethod]
    public void leap_year_Test_2100()
    {
        Assert.IsFalse( WP01.leapYear.CheckIfLeapYear(2100));
    }

     public void leap_year_Test_2021()
    {
        Assert.IsFalse( WP01.leapYear.CheckIfLeapYear(2021));
    }
    

}