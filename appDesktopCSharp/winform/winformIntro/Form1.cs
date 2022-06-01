namespace winformIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point initialPosition = button1.Location;

            int btnWidthEnd = this.Size.Width - (button1.Size.Width + (initialPosition.X * 2));
            int btnHeightEnd = this.Size.Height - (button1.Size.Height + (initialPosition.Y * 2));

            do
            {
                if(button1.Location.X < btnWidthEnd && button1.Location.Y < btnHeightEnd && button1.Location.Y == initialPosition.Y)
                {
                    button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
                }
                else if (button1.Location.Y < btnHeightEnd && button1.Location.X == btnWidthEnd)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 1);
                }
                else if (button1.Location.X > initialPosition.X)
                {
                    button1.Location = new Point(button1.Location.X - 1, button1.Location.Y);
                }
                else if (button1.Location.Y > initialPosition.Y)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 1);
                } 
            } while (initialPosition != button1.Location);
           
        }
    }
}