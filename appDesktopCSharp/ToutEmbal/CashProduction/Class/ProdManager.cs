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
        private static List<Production> productions;
        private static Production? prodByName;

        /// <summary>
        /// Création d'instances de la class Production.
        /// </summary>
        public static void MakeProdInstancies()
        {
            productions = new List<Production>();
            productions.Add(new Production(TypeOfBox.A, 10000));
            productions.Add(new Production(TypeOfBox.B, 25000));
            productions.Add(new Production(TypeOfBox.C, 120000));
        }

        /// <summary>
        /// Parcour de la liste de production.
        /// </summary>
        /// <param name="_type">Type de la production</param>
        /// <returns>Retourne une instance de Production spécifique par son type</returns>
        public static Production GetOneProdInstance(string _type)
        {
            foreach (Production prod in productions)
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
