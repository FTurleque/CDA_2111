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
        private Production ProdA { get; set; }
        /*private Production ProdB { get; set; }
        private Production ProdC { get; set; }*/

        public ProgressBarControl()
        {
            InitializeComponent();
        }

        private void ProgressBarControl_Load(object sender, EventArgs e)
        {
            ProdA = Production.GetInstance("A", 10000);
            /*ProdB = Production.GetInstance("B", 25000);
            ProdC = Production.GetInstance("C", 120000);*/
            ProdA.OnChange += ProdChange;
            /*ProdB.OnChange += ProdChange;
            ProdC.OnChange += ProdChange;*/
        }

        private void ProdChange(object sender, PropertyChangedEventArgs e)
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
