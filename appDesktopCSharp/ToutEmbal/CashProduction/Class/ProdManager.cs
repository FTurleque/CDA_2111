using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProduction.Class
{
    public static class ProdManager
    {
        // Liste des production
        public  static List<Production> Productions { get; private set; }
        private static Production? prodByName;

        /// <summary>
        /// Création d'instances de la class Production.
        /// </summary>
        public static void MakeProdInstancies()
        {
            Productions = new List<Production>();
            Productions.Add(new Production(TypeOfBox.A, 1000)); // 10000
            Productions.Add(new Production(TypeOfBox.B, 2500)); // 25000
            Productions.Add(new Production(TypeOfBox.C, 12000)); // 120000
        }

        /// <summary>
        /// Parcour de la liste de production.
        /// </summary>
        /// <param name="_type">Type de la production</param>
        /// <returns>Retourne une instance de Production spécifique par son type</returns>
        public static Production GetOneProdInstance(string _type)
        {
            foreach (Production prod in Productions)
            {
                if (prod.boxType.ToString() == _type)
                {
                    prodByName = prod;
                }
            }
            return prodByName;
        }
    }
}
