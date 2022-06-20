namespace FormsMenu
{
    public partial class ScrollingElement : Form
    {
        Scrolling red;
        Scrolling green;
        Scrolling blue;

        public ScrollingElement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}