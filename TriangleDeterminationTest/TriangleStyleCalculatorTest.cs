using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleDetermination;

namespace TriangleDeterminationTest
{
    [TestClass]
    public class TriangleStyleCalculatorTest
    {
        [TestMethod]
        public void Test_GetTriangleStyle_Given_SameNumbers_THEN_ExpectEquilateralTriangle()
        {
            var target = new TriangleStyleCalculator();

            var result = target.GetTriangleStyle(4, 4, 4);

            Assert.AreEqual(TriangleStyles.Styles.Equilateral, result);
        }

        [TestMethod]
        public void Test_GetTriangleStyle_Given_A_AND_B_IsSameNumbers_THEN_ExpectIsoscelesTriangle()
        {
            var target = new TriangleStyleCalculator();

            var result = target.GetTriangleStyle(4, 4, 2);

            Assert.AreEqual(TriangleStyles.Styles.Isosceles, result);
        }

        [TestMethod]
        public void Test_GetTriangleStyle_Given_B_AND_C_IsSameNumbers_THEN_ExpectIsoscelesTriangle()
        {
            var target = new TriangleStyleCalculator();

            var result = target.GetTriangleStyle(2, 4, 4);

            Assert.AreEqual(TriangleStyles.Styles.Isosceles, result);
        }

        [TestMethod]
        public void Test_GetTriangleStyle_Given_TwoSameNumbers_THEN_ExpectIsoscelesTriangle()
        {
            var target = new TriangleStyleCalculator();

            var result = target.GetTriangleStyle(4, 4, 2);

            Assert.AreEqual(TriangleStyles.Styles.Isosceles, result);
        }

        [TestMethod]
        public void Test_GetTriangleStyle_Given_ThreeUnidenticalNumbers_THEN_ExpectScaleneTriangle()
        {
            var target = new TriangleStyleCalculator();

            var result = target.GetTriangleStyle(5, 88, 3);

            Assert.AreEqual(TriangleStyles.Styles.Scalene, result);
        }
    }
}
