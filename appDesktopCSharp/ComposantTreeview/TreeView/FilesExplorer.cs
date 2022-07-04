namespace TreeView
{
    public partial class FilesExplorer : Form
    {
        public FilesExplorer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxPath.Text = @"C:\Users\CRM\Documents";
        }
    }
}