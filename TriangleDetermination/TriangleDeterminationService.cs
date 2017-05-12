using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDetermination
{
    public class TriangleDeterminationService : ITriangleDeterminationService
    {
        private readonly ITriangleStyleCalculator _calculator;
        public TriangleDeterminationService(ITriangleStyleCalculator calculator)
        {
            _calculator = calculator;
        }

        public string DetermineTriangle(string sideA, string sideB, string sideC)
        {
            int parsedSide1, parsedSide2, parsedSide3;

            if (int.TryParse(sideA, out parsedSide1) && int.TryParse(sideB, out parsedSide2) && int.TryParse(sideC, out parsedSide3))
            {
                TriangleStyles.Styles result = _calculator.GetTriangleStyle(parsedSide1, parsedSide2, parsedSide3);
                return result.ToString();
            }

            return string.Empty;
        }
    }
}
