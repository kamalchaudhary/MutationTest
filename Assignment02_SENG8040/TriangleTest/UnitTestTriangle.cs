using Assignment02_SENG8040;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class UnitTestTriangle
    {
        TriangleSolver Test = new TriangleSolver();
        string Result;

        [Test]
        // Unit test to check isosceles Triangle with two sides are equal
        public void Unit_Test_Of_Isosceles_Triangle()
        {
            Result = Test.Analyze(5, 15, 15);
            Assert.AreEqual(Result, "This is an isosceles triangle.");
        }
        // Unit test to check Equilateral Triangle with all side are equal
        [Test]
        public void Unit_Test_Of_Equilateral_Triangle()
        {
            Result = Test.Analyze(5, 5, 5);
            Assert.AreEqual(Result, "This is an equilateral triangle.");
        }
        // Unit test to check scalen triangle with all side are different value
        [Test]
        public void Unit_Test_Of_Scalene_Triangle()
        {
            Result = Test.Analyze(7, 12, 15);
            Assert.AreEqual(Result, "This is a scalene triangle.");
        }

        // Unit test to check with one side negative Triangle valuea and not valid triangle
        [Test]
        public void Unite_Test_Of_OneSide_negative()
        {
            
            Result = Test.Analyze(-5, 5, 5);
            Assert.AreEqual(Result, "Triangle is not valid.");
        }
        // Unit test to check with two side negative triangle valuea and not valid triangle
        [Test]
        public void Unit_Test_Of_TwoSide_negative_Triangle()
        {
           
            Result = Test.Analyze(-3, -2, 15);
            Assert.AreEqual(Result, "Triangle is not valid.");
        }
        // Unit test to check with all side zero triangle values and not valid triangle
        [Test]
        public void Unit_Test_Of_All_Side_Zero_Triangle()
        {
           Result = Test.Analyze(0, 0, 0);
            Assert.AreEqual(Result, "Triangle is not valid.");
        }
        // Unit test to check with one side zero triangle values and not valid triangle
        [Test]
        public void Unit_Test_Of_OneSide_Zero_Triangle()
        {
            Result = Test.Analyze(0, 10, 15);
            Assert.AreEqual(Result, "Triangle is not valid.");
        }
        // Unit test to check with values that are not forming a triangle 
        [Test]
        public void Unit_Test_Of_Notvalid_Triangle()
        {
            Result = Test.Analyze(2, 3, 5);
            Assert.AreEqual(Result, "Triangle is not valid.");
        }

        }
}
