using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction.UserControls
{
    public partial class ProgressBarControl : UserControl
    {
        private Production prod;

        public ProgressBarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liaison du UserControl à sa Production.
        /// </summary>
        /// <param name="prod">Production à lier</param>
        public void ProdLink(Production prod)
        {
            this.prod = prod;
            lblProdName.Text = "Production " + prod.boxType.ToString();
            progressBarProd.Maximum = this.prod.totalProduction;
            this.prod.OnChange += ProdChange;
        }

        /// <summary>
        /// Mise à jour des ProgressBar en temps réel.
        /// </summary>
        /// <param name="sender">Production concerné par le changement</param>
        /// <param name="e">Evenement de changement de propriété</param>
        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    progressBarProd.Value = prod.BoxCounter;
                }));
            }
        }
    }
}
