namespace DefilementComponents
{
    public partial class Form1 : Form
    {
        MyColor colorResult;

        public Form1()
        {
            InitializeComponent();
            colorResult = new MyColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelColorResult.BackColor = colorResult.NewColor;
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
            colorResult.ChangeColor(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            labelColorResult.BackColor = colorResult.NewColor;
        }
    }
}