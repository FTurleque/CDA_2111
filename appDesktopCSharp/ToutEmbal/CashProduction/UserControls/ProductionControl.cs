using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashProduction.Class;

namespace CashProduction.ProductionControl
{
    public partial class productionControl : UserControl
    {
        public productionControl()
        {
            InitializeComponent();
        }

        private void ProductionControl_Load(object sender, EventArgs e)
        {
            if (ProdManager.GetProductions == null)
            {
                ProdManager.MakeProdInstancies();
            }
            List<Production> productions = ProdManager.GetProductions;
            foreach (Production prod in productions)
            {
                txtBoxCashRegistersNb.Text = prod.BoxesNumber.ToString();
                prod.OnChange += ProdChange;
            }
        }

        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                txtBoxCashRegistersNb.Text = prod.BoxesNumber.ToString();
            }
        }
    }
}
