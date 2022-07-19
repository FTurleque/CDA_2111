using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ProdManager.GetProductions == null)
            {
                ProdManager.MakeProdInstancies();
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StartProd_Click(object sender, EventArgs e)
        {
            var prodName = sender as ToolStripMenuItem;
            Production prod = ProdManager.GetOneProdInstance(prodName.Text);
            prod.Start();
        }

        private void ProdChange(object sender, PropertyChangedEventArgs e)
        {
            if(sender is Production prod)
            {
                prodControlA.Name = prod.Name;
            }
        }
    }
}