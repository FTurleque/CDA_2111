using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMenu
{
    internal class RefundCalculation
    {
        public double Rate { get; set; }
        public double RefundNumber { get; set; }
        public double Periodicity { get; set; }

        public RefundCalculation() { }
        
        public double Refund(double borrowedCapital)
        {
            double annualRate = Rate / (12.0 / Periodicity);
            return Math.Round(borrowedCapital * (annualRate / (1 - Math.Pow(1.0 + annualRate, -RefundNumber))), 2);
        }
    }
}
