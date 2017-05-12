using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDetermination
{
    public interface ITriangleStyleCalculator
    {
        TriangleStyles.Styles GetTriangleStyle(int sideALenght, int sideBLenght, int sideCLenght);
    }
}
