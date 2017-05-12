using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TriangleDetermination;

namespace TriangleDeterminationTest
{
    [TestClass]
    public class TriangleDeterminationServiceTest
    {
        [TestMethod]
        public void Test_DetermineTriangle_GIVEN_ValidInput_THEN_ItCallsCalculatorWithParsedValues()
        {
            int sideA = 3;
            int sideB = 45;
            int sideC = 43;

            Mock<ITriangleStyleCalculator> triangleStyleCalculatorMock = new Mock<ITriangleStyleCalculator>(MockBehavior.Strict);
            triangleStyleCalculatorMock.Setup(x => x.GetTriangleStyle(sideA, sideB, sideC)).Returns(TriangleStyles.Styles.Scalene);

            var target = new TriangleDeterminationService(triangleStyleCalculatorMock.Object);
            var result = target.DetermineTriangle(sideA.ToString(), sideB.ToString(), sideC.ToString());
            Assert.AreEqual(TriangleStyles.Styles.Scalene.ToString(), result);
            triangleStyleCalculatorMock.Verify();
        }
    }
}
