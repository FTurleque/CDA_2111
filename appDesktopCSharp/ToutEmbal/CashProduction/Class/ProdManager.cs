using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProduction.Class
{
    public static class ProdManager
    {
        private static List<Production> productions;
        private static Production? prodByName;

        public static List<Production>? GetProductions => productions;

        public static void MakeProdInstancies()
        {
            productions = new List<Production>();
            productions.Add(new Production(TypeOfBox.A, 10000));
            productions.Add(new Production(TypeOfBox.B, 25000));
            productions.Add(new Production(TypeOfBox.C, 120000));
        }

        public static Production GetOneProdInstance(string _name)
        {
            foreach (Production prod in productions)
            {
                if (prod.boxType.ToString() == _name)
                {
                    prodByName = prod;
                }
            }
            return prodByName;
        }
    }
}
