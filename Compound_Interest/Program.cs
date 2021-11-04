using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            Console.ReadLine();

            Console.WriteLine("Hi, Welcome to the Bank " + "! \nPlease select account type. \nInput a number to choose:");
            Console.WriteLine("1. Savings \n2. Current");
            int answerIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Input your Investment Amount (N)");
            double investmentAmt = double.Parse(Console.ReadLine());
            //Console.WriteLine("Input your Investment Rate");
            double rate = 17.0; //decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Input your investment tenure (days)");
            //int tenor = int.Parse(Console.ReadLine());

            int[] tenors = new int[] { 183,273,365,730,1825 };
            foreach (int tenor in tenors)
            {
                double compoundInterest = new Program().CalcInterest(investmentAmt, rate, tenor);
                string shortTenor = string.Empty;
                switch (tenor)
                {
                    case 183:
                        shortTenor = "6 Months";
                        break;
                    case 273:
                        shortTenor = "9 Months";
                        break;
                    case 365:
                        shortTenor = "12 Months";
                        break;
                    case 730:
                        shortTenor = "24 Months";
                        break;
                    case 1825:
                        shortTenor = "60 Months";
                        break;
                }
                Console.WriteLine("Your compound Interest after " + shortTenor + " is N" + compoundInterest.ToString("0.00"));
            }
            
            Console.Read();
        }

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
