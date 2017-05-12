using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleDetermination;

namespace TriangleDeterminationTest
{
    [TestClass]
    public class TriangleDeterminationVMTest
    {
        [TestMethod]
        public void Test_DetermineCommand_GIVEN_ValidIntegers_THEN_ItCallsCalculatorWithIntegers()
        {
            int sideA = 2;
            int sideB = 3;
            int sideC = 6;

            var target = new TriangleDeterminationVM();

            target.SideA = sideA.ToString();
            target.SideB = sideB.ToString();
            target.SideC = sideC.ToString();

            target.DetermineCommand.Execute(null);

            Assert.AreEqual(TriangleStyles.Styles.Scalene.ToString(), target.TriangleStyleResult);
        }
    }
}
