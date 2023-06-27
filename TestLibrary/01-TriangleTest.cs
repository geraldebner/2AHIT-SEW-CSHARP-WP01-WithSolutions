using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary;

[TestClass]
public class TriangleTest
{
   [TestMethod]
    public void TestTriangleHyp()
    {
        Assert.AreEqual( WP01.Triangle.CalcTriangleHyp(3.0,4.0), 5.0);
    }

    [TestMethod]
    public void TestTriangleArea()
    {
         Assert.AreEqual( WP01.Triangle.CalcTriangleArea(3.0,4.0), 6.0);
    }

    [TestMethod]
    public void TestTriangleCirc()
    {
        Assert.AreEqual( WP01.Triangle.CalcTriangleCirc(3.0,4.0), 12.0);
    }
    
}