namespace DefilementComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            numUpDownRed.Value = hScrollBarRed.Value;
            numUpDownGreen.Value = hScrollBarGreen.Value;
            numUpDownBlue.Value = hScrollBarBlue.Value;
        }

        private void numUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRed.Value = (int)numUpDownRed.Value;
            hScrollBarGreen.Value = (int)numUpDownGreen.Value;
            hScrollBarBlue.Value = (int)numUpDownBlue.Value;
        }
    }
}