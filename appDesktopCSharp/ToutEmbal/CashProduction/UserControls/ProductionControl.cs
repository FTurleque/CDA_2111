using System.ComponentModel;
using CashProduction.Class;

namespace CashProduction.ProductionControl
{
    public partial class productionControl : UserControl
    {
        Production prod;

        public productionControl()
        {
            InitializeComponent();
        }

        public void ProdLink(Production prod)
        {
            this.prod = prod;
            this.prod.OnChange += ProdChange;
        }

        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {

                txtBoxBoxNumber.Text = prod.BoxCounter.ToString();
                txtBoxDefectRatePerHour.Text = prod.DefectRateLastHour.ToString();
                txtBoxGlobalDefectRate.Text = prod.GlobalDefectRate.ToString();
            }
        }
    }
}
