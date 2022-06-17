namespace DefilementComponents
{
    public partial class ScrollingElement : Form
    {
        //MyColor colorResult;
        Scrolling red;
        Scrolling green;
        Scrolling blue;

        public ScrollingElement()
        {
            InitializeComponent();
            //colorResult = new MyColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // labelColorResult.BackColor = colorResult.NewColor;
            red = new Scrolling(hScrollBarRed, numUpDownRed, lblRed, Color.Red);
            green = new Scrolling(hScrollBarGreen, numUpDownGreen, lblGreen, Color.Green);
            blue = new Scrolling(hScrollBarBlue, numUpDownBlue, lblBlue, Color.Blue);

            hScrollBarGreen.Scroll += HScrollBarRed_Scroll;
            numUpDownGreen.ValueChanged += HScrollBarRed_Scroll;

            hScrollBarBlue.Scroll += HScrollBarRed_Scroll;
            numUpDownBlue.ValueChanged += HScrollBarRed_Scroll;
        }

        private void HScrollBarRed_Scroll(object sender, EventArgs e)
        {
            if (sender is ScrollBar scrollBar)
            {
                Scrolling scrollElement = (Scrolling)scrollBar.Tag;
                scrollElement.ChangeValue(scrollBar.Value);
            }
            else if (sender is NumericUpDown upDown)
            {
                Scrolling scrollElement = (Scrolling)upDown.Tag;
                scrollElement.ChangeValue(upDown.Value);
            }
            labelColorResult.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
        }

        /*private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
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
        }*/
    }
}