using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDetermination
{
    public  class TriangleStyleCalculator : ITriangleStyleCalculator
    {
        public TriangleStyles.Styles GetTriangleStyle(int sideALenght, int sideBLenght, int sideCLenght)
        {
            if (sideALenght == sideBLenght && sideALenght == sideCLenght)
            {
                return TriangleStyles.Styles.Equilateral;
            }
            else if (sideALenght == sideBLenght || sideALenght == sideCLenght)
            {
                return TriangleStyles.Styles.Isosceles;
            }
            else 
            { 
                return TriangleStyles.Styles.Scalene;
            }
        }
    }
}
 