using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Création des instances de ma production
            ProdManager.MakeProdInstancies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Liaison du userControl à une prod précise
            prodControlA.ProdLink(ProdManager.GetOneProdInstance("A"));
            prodControlB.ProdLink(ProdManager.GetOneProdInstance("B"));
            prodControlC.ProdLink(ProdManager.GetOneProdInstance("C"));
            progressBarControlA.ProdLink(ProdManager.GetOneProdInstance("A"));
            progressBarControlB.ProdLink(ProdManager.GetOneProdInstance("B"));
            progressBarControlC.ProdLink(ProdManager.GetOneProdInstance("C"));
            statusBoxA.Text += $"  {ProdManager.GetOneProdInstance("A").BoxCounter}";
            statusBoxB.Text += $"  {ProdManager.GetOneProdInstance("B").BoxCounter}";
            statusBoxC.Text += $"  {ProdManager.GetOneProdInstance("C").BoxCounter}";
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

        private void StopProd_Click(object sender, EventArgs e)
        {
            var prodName = sender as ToolStripMenuItem;
            Production prod = ProdManager.GetOneProdInstance(prodName.Text);
        }

        private void ContinueProd_Click(object sender, EventArgs e)
        {
            var prodName = sender as ToolStripMenuItem;
            Production prod = ProdManager.GetOneProdInstance(prodName.Text);
        }
    }
}