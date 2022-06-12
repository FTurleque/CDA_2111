namespace ListBoxAndComboBox
{
    public partial class Form1 : Form
    {
        private string[] countriesList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countriesList = new string[]
            {
                "Allemagne", "Australie", "Autriche", "Bahamas", "Belgique", "Birmanie", "Brésil", "Bulgarie", "Cameroun", 
                "Canada", "Chili", "Chine", "Colombie", "Égypte", "Espagne", "France", "Ghana", "Grece", "Guinée", "Guyane",
                "Japon", "Jordanie", "Laos", "Liban", "Macao", "Mali", "Maroc", "Mongolie", "Népal", "Nigéria", "Panama", 
                "Paraguay", "Pérou", "Philippines", "Pologne", "Portugal", "Roumanie", "Russie", "Salvador", "Suède", "Suisse", 
                "Taïwan", "Tanzanie", "Ukraine", "USA", "Viêtnam", "Zambie"
            };

            foreach (string country in countriesList)
            {
                comboBoxSource.Items.Add(country);
            }
        }

        private void btnAddOneInTarget_Click(object sender, EventArgs e)
        {
            listBoxTarget.Items.Add((string)comboBoxSource.SelectedItem);
            comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
        }

        private void btnAddAllInTarget_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBoxSource.Items)
            {
                listBoxTarget.Items.Add(item);
            }
            comboBoxSource.Items.Clear();
        }

        private void btnAddOneInSource_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAllInSource_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }
    }
}