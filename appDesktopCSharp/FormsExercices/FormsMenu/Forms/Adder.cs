namespace FormsMenu
{
    public partial class Adder : Form
    {
        private List<int> values;
        public string Title 
        { 
            get { return Title; } 
            set { Title = value; }
        }

        public Adder()
        {
            InitializeComponent();
            values = new List<int>();
        }

        private void Adder_Load(object sender, EventArgs e)
        {
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                values.Add(int.Parse(btn.Text));
                textBox1.Text += values.Count > 1 ? "+" + btn.Text : btn.Text;
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
            textBox1.Text += " = " + result.ToString();
        }

    }
}