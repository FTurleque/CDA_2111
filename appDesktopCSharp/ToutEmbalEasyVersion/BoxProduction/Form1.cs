namespace BoxProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarA.Minimum = 0;
            progressBarB.Minimum = 0;
            progressBarC.Minimum = 0;
        }
    }
}