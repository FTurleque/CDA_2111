using CashProduction.Class;
using System.ComponentModel;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        Production prod;

        public Form1()
        {
            InitializeComponent();
            // Création des instances de ma production
            ProdManager.MakeProdInstancies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxA.Tag = ProdManager.GetOneProdInstance("A");
            groupBoxB.Tag = ProdManager.GetOneProdInstance("B");
            groupBoxC.Tag = ProdManager.GetOneProdInstance("C");
            // Liaison du userControl à une prod précise
            prodControlA.ProdLink((Production)groupBoxA.Tag);
            prodControlB.ProdLink((Production)groupBoxB.Tag);
            prodControlC.ProdLink((Production)groupBoxC.Tag);
            progressBarControlA.ProdLink((Production)groupBoxA.Tag);
            progressBarControlB.ProdLink((Production)groupBoxB.Tag);
            progressBarControlC.ProdLink((Production)groupBoxC.Tag);
            timer1.Start();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
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

        private void ChangeBtnStates(Production prod)
        {
            switch (prod.boxType.ToString())
            {
                case "A":
                    if (!prod.ProdStarted)
                    {
                        startAMenu.Enabled = false;
                        stopAMenu.Enabled = true;
                        continueAMenu.Enabled = false;
                        btnStartA.Enabled = false;
                        btnStandByA.Enabled = false;
                        btnStopA.Enabled = true;
                        trafficLightA.BackgroundImage = Properties.Resources.Green;
                    }
                    else
                    {
                        startAMenu.Enabled = true;
                        stopAMenu.Enabled = false;
                        continueAMenu.Enabled = true;
                        btnStartA.Enabled = true;
                        btnStandByA.Enabled = true;
                        btnStopA.Enabled = false;
                        trafficLightA.BackgroundImage = Properties.Resources.Orange;
                    }
                    break;
                case "B":
                    if(!prod.ProdStarted)
                    {
                        startBMenu.Enabled = false;
                        stopBMenu.Enabled = true;
                        continueBMenu.Enabled = false;
                        btnStartB.Enabled = false;
                        btnStandByB.Enabled = false;
                        btnStopB.Enabled = true;
                        trafficLightB.BackgroundImage = Properties.Resources.Green;
                    }
                    else
                    {
                        startBMenu.Enabled = true;
                        stopBMenu.Enabled = false;
                        continueBMenu.Enabled = true;
                        btnStartB.Enabled = true;
                        btnStandByB.Enabled = true;
                        btnStopB.Enabled = false;
                        trafficLightB.BackgroundImage = Properties.Resources.Orange;
                    }
                    break;
                case "C":
                    if (!prod.ProdStarted)
                    {
                        startCMenu.Enabled = false;
                        stopCMenu.Enabled = true;
                        continueCMenu.Enabled = false;
                        btnStartC.Enabled = false;
                        btnStandByC.Enabled = false;
                        btnStopC.Enabled = true;
                        trafficLightC.BackgroundImage = Properties.Resources.Green;
                    }
                    else
                    {
                        startCMenu.Enabled = true;
                        stopCMenu.Enabled = false;
                        continueCMenu.Enabled = true;
                        btnStartC.Enabled = true;
                        btnStandByC.Enabled = true;
                        btnStopC.Enabled = false;
                        trafficLightC.BackgroundImage = Properties.Resources.Orange;
                    }
                    break;
                default:
                    break;
            }
        }

        private Production GetProduction(object sender)
        {
            if (sender is Button btn)
            {
                if (btn.Parent is GroupBox)
                {
                    prod = (Production)btn.Parent.Tag;
                    string c = prod.boxType.ToString();
                }
            }
            else if (sender is ToolStripMenuItem prodName)
            {
                prod = ProdManager.GetOneProdInstance(prodName.Text);
            }
            ChangeBtnStates(prod);
            return prod;
        }

        private void StartProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.Start();
        }

        private void StopProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.StandBy();
        }

        private void ContinueProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.Continue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToLongTimeString();
            boxA.Text = ((Production)groupBoxA.Tag).BoxCounter.ToString();
            boxB.Text = ((Production)groupBoxB.Tag).BoxCounter.ToString();
            boxC.Text = ((Production)groupBoxC.Tag).BoxCounter.ToString();
        }

        private void EndedProduction_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if(btn.Parent is GroupBox group)
                {
                    Production prod = (Production)group.Tag;
                    prod.StandBy();

                    foreach (Control c in group.Controls)
                    {
                        if(c.BackgroundImage != null)
                        {
                            c.BackgroundImage = Properties.Resources.Red;
                        }
                        if(c.Text.Equals("Démarer"))
                        {
                            c.Enabled = true;
                        }
                        else
                        {
                            c.Enabled = false;
                        }
                    }
                    foreach (ToolStripItem menu in productionMenu.DropDownItems)
                    {
                        foreach (ToolStripItem item in startMenu.DropDownItems)
                        {

                        }
                        if (menu.Text == prod.boxType.ToString())
                        {
                            menu.Enabled = true;
                        }
                        else
                        { 
                            menu.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}