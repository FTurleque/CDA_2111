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
            /*foreach (Control c in this.Controls)
            {
                if(c is UserControl control)
                {
                    
                }
                Char typeProde = c.Name.ToArray()[^1];
                //MessageBox.Show(typeProde.ToString());
            }*/
            // Liaison du userControl à une prod précise
            prodControlA.ProdLink(ProdManager.GetOneProdInstance("A"));
            prodControlB.ProdLink(ProdManager.GetOneProdInstance("B"));
            prodControlC.ProdLink(ProdManager.GetOneProdInstance("C"));
            progressBarControlA.ProdLink(ProdManager.GetOneProdInstance("A"));
            progressBarControlB.ProdLink(ProdManager.GetOneProdInstance("B"));
            progressBarControlC.ProdLink(ProdManager.GetOneProdInstance("C"));
            timer1.Start();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            foreach (Production prod in ProdManager.Productions)
            {
                if (prod.ProdStarted)
                {
                    prod.ProdEnding = true;
                }
            }
            this.Close();
        }


        private void StartProd_Click(object sender, EventArgs e)
        {
            // Faire désactiver et activer les menus
            /*foreach (ToolStripItem item in productionMenu.DropDownItems)
            {
                
            }*/
            /*foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {
                    foreach (Control cc in c.Controls)
                    {
                        // ...
                    }
                }
                else if (c.GetType() == typeof(MenuStrip))
                {   // ToolStrip et cousin(e)s :D
                    foreach (ToolStripItem ci in ((MenuStrip)c).Items)
                    {
                        
                        // ...
                    }
                }
                else
                {
                    // Controles contenus par le formulaire
                }
            }*/
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToLongTimeString();
            boxA.Text = ProdManager.GetOneProdInstance("A").BoxCounter.ToString();
            boxB.Text = ProdManager.GetOneProdInstance("B").BoxCounter.ToString();
            boxC.Text = ProdManager.GetOneProdInstance("C").BoxCounter.ToString();
        }
    }
}