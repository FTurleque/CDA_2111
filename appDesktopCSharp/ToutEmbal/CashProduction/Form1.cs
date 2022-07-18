using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        private Production prodA;
        private Production prodB;
        private Production prodC;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prodA = Production.GetInstance("A", 10000);
            prodB = Production.GetInstance("B", 25000);
            prodC = Production.GetInstance("C", 120000);

            prodA.OnChange += ProdChange;
            /*prodB.OnChange += ProdChange;
            prodC.OnChange += ProdChange;*/
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StartProd_Click(object sender, EventArgs e)
        {
            var prodName = sender as ToolStripMenuItem;
            switch (prodName.Text)
            {
                case "A":
                    prodA.Start();
                    break;
                case "B":
                    prodB.Start();
                    break;
                case "C":
                    prodC.Start();
                    break;
                default:
                    break;
            }
        }

        private void ProdChange(object sender, PropertyChangedEventArgs e)
        {
            if(sender is Production prod)
            {
                prodControlA.Name = prod.Name;
                /*progressBarProductionA.Minimum = 1;
                progressBarProductionA.Maximum = prod.TotalProduction;
                progressBarProductionA.Value = prod.BoxesNumber;*/ 
                
            }
        }
    }
}