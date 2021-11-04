using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest
{
    interface ICompoundInterestCalculator
    {
        double CalcInterest(double amt, double rate, int tenor);
    }
}
