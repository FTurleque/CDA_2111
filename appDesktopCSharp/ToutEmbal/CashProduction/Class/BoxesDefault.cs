using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProduction.Class
{
    internal class BoxesDefault
    {
        private const int minRandomDefault = 100;
        private int maxRandomDefault = 1000;
        public Dictionary<string, string> DefaultList { get; set; }

        public DateTime DefaultTime { get; set; }

        public BoxesDefault(string _productionName, DateTime _defaultTime)
        {
            throw new System.NotImplementedException();
        }

        public int GenerateRandomDefault()
        {
            throw new System.NotImplementedException();
        }
    }
}
