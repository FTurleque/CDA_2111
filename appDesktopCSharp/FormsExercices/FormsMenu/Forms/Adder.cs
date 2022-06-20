namespace FormsMenu
{
    public partial class Adder : Form
    {
        private List<int> values;

        public Adder()
        {
            InitializeComponent();
            values = new List<int>();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                values.Add(int.Parse(btn.Text));
                textBox1.Text += btn.Text + '+';
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void Drain_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            values = new List<int>();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int result = values.Sum();
            textBox1.Text += " = " + result.ToString() + '+';
        }
    }
}