using CashProduction.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashProduction.UserControls
{
    public partial class ProgressBarControl : UserControl
    {
        public ProgressBarControl()
        {
            InitializeComponent();
        }

        private void ProgressBarControl_Load(object sender, EventArgs e)
        {
            if (ProdManager.GetProductions == null)
            {
                ProdManager.MakeProdInstancies();
            }
            List<Production> productions = ProdManager.GetProductions;
            foreach (Production prod in productions)
            {
                prod.OnChange += ProdChange;
            }
        }

        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                lblProdName.Text = "Production " + prod.Name;
                progressBarProd.Minimum = 0;
                progressBarProd.Maximum = prod.TotalProduction;
                progressBarProd.Value = prod.BoxesNumber;
            }
        }
    }
}
