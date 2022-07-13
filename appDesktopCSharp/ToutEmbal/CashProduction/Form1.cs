using CashProduction.Class;

namespace CashProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Production prodA = new Production("A", 10000);
            Production prodB = new Production("B", 25000);
            Production prodC = new Production("C", 120000);
        }
    }
}