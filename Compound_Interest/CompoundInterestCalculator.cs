using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest
{
    class CompoundInterestCalculator : ICompoundInterestCalculator
    {
        public double CalcInterest(double amt, double rate, int tenor)
        {
            try
            {
                int daysInTheYear = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;
                double interestAmt = (rate / 100) * (amt / daysInTheYear) * tenor;
                return interestAmt;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
