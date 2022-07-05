namespace ThreadManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(this.AddText);
            thread.Start();
        }

        private void AddText()
        {
            Thread.Sleep(5000);
            this.Invoke(new MethodInvoker(() =>
            {
                txtResult.Text += "Yeah ";
            }));
            Thread.Sleep(5000);
        }
    }
}