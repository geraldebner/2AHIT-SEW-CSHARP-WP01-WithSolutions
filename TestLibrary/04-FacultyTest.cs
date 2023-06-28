using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLibrary
{

    [TestClass]
    public class FacultyTest
    {
        [TestMethod]
        public void TestFaculty1()
        {
            Assert.AreEqual(WP01.Faculty.CalcFaculty(1),1);
        }
        [TestMethod]
        public void TestFaculty3()
        {
            Assert.AreEqual(WP01.Faculty.CalcFaculty(3),6);
        }
        [TestMethod]
        public void TestFaculty10()
        {
            Assert.AreEqual(WP01.Faculty.CalcFaculty(10),3628800);
        }
        [TestMethod]
        public void TestFaculty30()
        {
            Assert.AreEqual(WP01.Faculty.CalcFaculty(30),1409286144);
        }

        [TestMethod]
        public void TestFaculty100()
        {
            Assert.AreEqual(WP01.Faculty.CalcFaculty(100),0);
        }

    }
}