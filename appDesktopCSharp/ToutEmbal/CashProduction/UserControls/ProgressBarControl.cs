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

        public void ProdLink(Production prod)
        {
            this.prod = prod;
            lblProdName.Text = "Production " + prod.boxType.ToString();
            progressBarProd.Maximum = this.prod.totalProduction;
            this.prod.OnChange += ProdChange;
        }

        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                progressBarProd.Value = prod.BoxCounter;
            }
        }
    }
}
