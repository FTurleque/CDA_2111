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
        private Production? ProdA { get; set; }
        /*private Production? ProdB { get; set; }
        private Production? ProdC { get; set; }*/

        public productionControl()
        {
            InitializeComponent();
        }

        private void ProductionControl_Load(object sender, EventArgs e)
        {
            ProdA = Production.GetInstance("A", 10000);
            /*ProdB = Production.GetInstance("B", 25000);
            ProdC = Production.GetInstance("C", 120000);*/
            txtBoxCashRegistersNb.Text = ProdA.BoxesNumber.ToString();
            ProdA.OnChange += ProdChange;
            /*ProdB.OnChange += ProdChange;
            ProdC.OnChange += ProdChange;*/
        }

        private void ProductionUpdate_TextChanged(object sender, EventArgs e)
        {
            // txtBoxCashRegistersNb.Text = ProdA.BoxesNumber.ToString();
            /*txtBoxDefectRatePerHour
            txtBoxGlobalDefectRate*/
        }

        private void ProdChange(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                txtBoxCashRegistersNb.Text = prod.BoxesNumber.ToString();
            }
        }
    }
}
