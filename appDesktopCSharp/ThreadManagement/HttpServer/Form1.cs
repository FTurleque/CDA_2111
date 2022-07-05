namespace HttpServer
{
    public partial class Form1 : Form
    {
        WebServer server;

        public Form1()
        {
            InitializeComponent();
            server = new WebServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Text = "Démarrer";
            btnStart.BackColor = Color.DarkRed;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (server.Running)
            {
                server.Stop();
                btnStart.Text = "Démarrer";
                btnStart.BackColor = Color.DarkRed;
            }
            else
            {
                server.Start();
                btnStart.Text = "Arrêter";
                btnStart.BackColor = Color.DarkGreen;
            }
        }
    }
}