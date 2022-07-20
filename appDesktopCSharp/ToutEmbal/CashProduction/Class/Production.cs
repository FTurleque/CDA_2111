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
        // Evenement qui permet de s'abonner aux changement de la Production.
        public event PropertyChangedEventHandler OnChange;

        // Nom + prod par heure.
        public readonly TypeOfBox boxType;

        // Temp de production d'une boite.
        public readonly int prodTimeOfABox;

        // Total de la production.
        public readonly int totalProduction;

        // Etat de la production.
        public bool ProdStarted { get; private set; }

        // Nombre de boites.
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

        // Création du Thread.
        public Thread Thread { get; set; }

        // Défault de production sur 1h.
        public float DefectRateLastHour { get; private set; }

        // Taux de défault global.
        public float GlobalDefectRate { get; private set; }

        internal BoxesDefault ProductionDefault { get; private set; }


        /// <summary>
        /// Construction d'une Production.
        /// </summary>
        /// <param name="_boxType">Type de la boite produite</param>
        /// <param name="_totalProduction">Total des boite demandé pour términer la Production</param>
        public Production(TypeOfBox _boxType, int _totalProduction)
        {
            this.boxType = _boxType;
            this.totalProduction = _totalProduction;
            this.boxCounter = 0;
            DefectRateLastHour = 0;
            GlobalDefectRate = 0;
            ProdStarted = false;
            Thread = new Thread(this.StartedProd);
            prodTimeOfABox = (int)(3600d / (double)boxType * 1000d);
        }

        /// <summary>
        /// Réinitialisation des valeur,
        /// on passe le boolean à true
        /// Lancement du Thread.
        /// </summary>
        public void Start()
        {
            if (!ProdStarted)
            {
                BoxCounter = 0;
                DefectRateLastHour = 0;
                GlobalDefectRate = 0;
                ProdStarted = true;
                Thread.Start();
            }
        }

        /// <summary>
        /// Lancement de la Production.
        /// </summary>
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

        /// <summary>
        /// Mise en pause la production.
        /// </summary>
        public void StandBy()
        {
            ProdStarted = false;
        }

        /// <summary>
        /// redémarage de la Production.
        /// </summary>
        public void Continue()
        {
            ProdStarted = true;
        }

        /// <summary>
        /// Lancement de la mise a jour des valeurs de la Production qui on changées.
        /// </summary>
        private void Update()
        {
            if (this.OnChange != null)
            {
                OnChange(this, new PropertyChangedEventArgs(nameof(BoxCounter)));
            }
        }
    }
}
