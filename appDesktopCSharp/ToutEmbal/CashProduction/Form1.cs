using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Cr�ation des instances de ma production
            ProdManager.MakeProdInstancies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if(c is UserControl control)
                {
                    
                }
                Char typeProde = c.Name.ToArray()[^1];
                MessageBox.Show(typeProde.ToString());
            }
            // Liaison du userControl � une prod pr�cise
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
            prod.StandBy();
        }

        private void ContinueProd_Click(object sender, EventArgs e)
        {
            var prodName = sender as ToolStripMenuItem;
            Production prod = ProdManager.GetOneProdInstance(prodName.Text);
            prod.Continue();
        }

        // Changement du nombre de boites par Production dans la bar de status
    }
}