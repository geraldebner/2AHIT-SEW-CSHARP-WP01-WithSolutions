using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace test_library;

[TestClass]
public class UnitTest_01_Triangle11
{
   [TestMethod]
    public void triangle_hyp_Test1()
    {
        Assert.AreEqual( WP01.ex_01.triangle_hyp(3.0,4.0), 5.0);
    }
    [TestMethod]
    public void triangle_area_Test1()
    {
         //AssemblyLoadEventArgs.Equals( ex_01.triangle_area(3.0,4.0), 6.0);

    }

    [TestMethod]
    public void triangle_circle_Test1()
    {
        // AssemblyLoadEventArgs.Equals( ex_01.triangle_circ(3.0,4.0) == 12.0);

    }
}