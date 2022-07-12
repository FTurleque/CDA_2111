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

        public BoxesDefault(string _productionName, DateTime _defaultTime)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<string, string> DefaultList
        {
            get => default;
            set
            {
            }
        }

        public DateTime DefaultTime
        {
            get => default;
            set
            {
            }
        }

        public int GenerateRandomDefault()
        {
            throw new System.NotImplementedException();
        }
    }
}
