using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeALoan
{
    internal class RefundCalculation
    {
        public double Rate { get; set; }
        public double RefundNumber { get; set; }

        public RefundCalculation() { }
        
        public double Refund(double borrowedCapital, double refundType)
        {
            double monthResult = 0;
            /*double tmp = 1 + (0.04 / 12);
            double divisor = Math.Pow(tmp, -240);
            monthResult = Math.Round((100000 * (0.04 /12)) / (1 - divisor), 2);*/
            double tmp = 1 + (Rate / 12);
            double divisor = Math.Pow(tmp, -RefundNumber);
            monthResult = Math.Round((borrowedCapital * (Rate / 12)) / (1 - divisor), 2);
            return monthResult * refundType;
        }
    }
}
