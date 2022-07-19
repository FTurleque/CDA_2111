using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProduction.Class
{
    public class Production
    {
        public event PropertyChangedEventHandler OnChange;

        // Nom
        public string Name { get; set; }

        // Production par heure
        public int ProdPerHour { get; set; }

        // Etat de la production
        public bool ProdStarted { get; set; }

        // Nombre de caisses
        private int boxesNumber;
        public int BoxesNumber 
        {
            get => boxesNumber; 
            private set
            {
                if (value > 0 && value <= TotalProduction)
                {
                    boxesNumber = value;
                    Update();
                }
            }
        }

        // Défault de production sur 1h
        public float DefectRateLastHour { get; set; }

        // Taux de défault global
        public float GlobalDefectRate { get; set; }

        // Production à l'heure
        public QuotaPerHour QuotaPerHour { get; set; }

        internal BoxesDefault ProductionDefault { get; set; }

        // Total de la production
        public int TotalProduction { get; set; }


        public Production(string _name, int _totalProduction, int _prodPerHour)
        {
            Name = _name;
            TotalProduction = _totalProduction;
            ProdPerHour = _prodPerHour;
            boxesNumber = 0;
            DefectRateLastHour = 0;
            GlobalDefectRate = 0;
            ProdStarted = false;
        }

        public void Start()
        {
            ProdStarted = true;
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

        private void Update()
        {
            if (this.OnChange != null)
            {
                OnChange(this, new PropertyChangedEventArgs(nameof(BoxesNumber)));
            }
        }
    }
}
