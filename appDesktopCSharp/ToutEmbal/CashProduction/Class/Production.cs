using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProduction.Class
{
    public class Production
    {
        public string Name { get; set; }

        public int BoxesNumber { get; set; }

        public float DefectRateLastHour { get; set; }

        public float GlobalDefectRate { get; set; }

        public QuotaPerHour QuotaPerHour { get; set; }

        internal BoxesDefault ProductionDefault { get; set; }

        public int TotalProduction { get; set; }

        public Production(string _name, int _totalProduction)
        {
            Name = _name;
            TotalProduction = _totalProduction;
        }

        public void Start()
        {
            while (BoxesNumber != TotalProduction)
            {
                BoxesNumber++;
            }
        }

        public void StandBy()
        {
            throw new System.NotImplementedException();
        }

        public void Continue()
        {
            throw new System.NotImplementedException();
        }
    }
}
