using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProduction.Class
{
    public class Production
    {
        // Nom
        public string Name { get; set; }

        // Total de la production
        public int TotalProduction { get; set; }

        // Production par heure
        public int ProdPerHour { get; set; }

        // Etat de la production
        public bool ProdStarted { get; set; }

        // Compteur de bonnes caisses
        private int boxesNumber;
        public int BoxesNumber
        {
            get => boxesNumber;
            private set
            {
                if (value > 0 && value <= TotalProduction)
                {
                    boxesNumber = value;
                }
            }
        }

        // Compteur de caisses déféctueuse
        private int defectiveBox;
        public int DefectiveBox 
        {
            get => defectiveBox;
            private set
            {
                if(value > 0 && value < DefectiveBox)
                {
                    defectiveBox = value;
                }
            }
        }

        // Taux de défault global
        public float GlobalDefectRate { get; set; }

        // Liste des box 



        public Production(string _name, int _totalProduction, int _prodPerHour)
        {
            Name = _name;
            TotalProduction = _totalProduction;
            ProdPerHour = _prodPerHour;
            boxesNumber = 0;
            DefectiveBox = 0;
            GlobalDefectRate = 0;
            ProdStarted = false;
        }

        public void Start()
        {
            ProdStarted = true;
            while (BoxesNumber != TotalProduction && ProdStarted)
            {
                Box newBox = new Box(Name);
                if (newBox.IsOk)
                {
                    BoxesNumber++;
                }
                else
                {
                    defectiveBox++;
                }
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
