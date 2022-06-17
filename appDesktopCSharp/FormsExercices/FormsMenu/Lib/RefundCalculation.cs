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
        
        public double Refund(double borrowedCapital, double step)
        {
            double divisor = Math.Pow(1 + (Rate / 12), -RefundNumber);
            double monthResult = (borrowedCapital * (Rate / 12)) / (1 - divisor);
            return Math.Round(monthResult * step, 2);
        }
    }
}
