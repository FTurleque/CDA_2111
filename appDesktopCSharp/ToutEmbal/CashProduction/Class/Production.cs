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

        // Nom + prod par heure
        public readonly TypeOfBox boxType;

        // Temp de production d'une boite
        public readonly int prodTimeOfABox;

        // Total de la production
        public readonly int totalProduction;

        // Etat de la production
        public bool ProdStarted { get; private set; }

        // Nombre de boites
        private int boxCounter;
        public int BoxCounter 
        {
            get => boxCounter; 
            private set
            {
                if (value > 0 && value <= totalProduction)
                {
                    boxCounter = value;
                    Update();
                }
            }
        }

        // Création du Thread
        private Thread thread;

        // Défault de production sur 1h
        public float DefectRateLastHour { get; private set; }

        // Taux de défault global
        public float GlobalDefectRate { get; private set; }

        internal BoxesDefault ProductionDefault { get; private set; }



        public Production(TypeOfBox _boxType, int _totalProduction)
        {
            this.boxType = _boxType;
            this.totalProduction = _totalProduction;
            this.boxCounter = 0;
            DefectRateLastHour = 0;
            GlobalDefectRate = 0;
            ProdStarted = false;
            thread = new Thread(this.StartedProd);
            prodTimeOfABox = (int)(3600d / (double)boxType * 1000d);
        }

        public void Start()
        {
            if (!ProdStarted)
            {
                BoxCounter = 0;
                DefectRateLastHour = 0;
                GlobalDefectRate = 0;
                ProdStarted = true;
                thread.Start();
            }
        }

        private void StartedProd()
        {
            if (ProdStarted)
            {
                while (BoxCounter != totalProduction)
                {
                    if (ProdStarted)
                    {
                        Thread.Sleep(this.prodTimeOfABox);
                        ++BoxCounter;
                    }
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

        private void Update()
        {
            if (this.OnChange != null)
            {
                OnChange(this, new PropertyChangedEventArgs(nameof(BoxCounter)));
            }
        }
    }
}
