using System.ComponentModel;

namespace ListBoxAndComboBox
{
    public partial class Form1 : Form
    {
        // private string[] countriesList;
        ListManager manager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*countriesList = new string[]
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
            }*/

            manager = new ListManager()
            {
                Source = new BindingList<string>()
                {
                    "Allemagne", "Australie", "Autriche", "Bahamas", "Belgique", "Birmanie", "Brésil", "Bulgarie", "Cameroun",
                    "Canada", "Chili", "Chine", "Colombie", "Égypte", "Espagne", "France", "Ghana", "Grece", "Guinée", "Guyane",
                    "Japon", "Jordanie", "Laos", "Liban", "Macao", "Mali", "Maroc", "Mongolie", "Népal", "Nigéria", "Panama",
                    "Paraguay", "Pérou", "Philippines", "Pologne", "Portugal", "Roumanie", "Russie", "Salvador", "Suède", "Suisse",
                    "Taïwan", "Tanzanie", "Ukraine", "USA", "Viêtnam", "Zambie"
                },
                Target = new BindingList<string>()
            };
            comboBoxSource.DataSource = manager.Source;
            listBoxTarget.DataSource = manager.Target;
        }

        private void btnAddOneInTarget_Click(object sender, EventArgs e)
        {
            /*if (comboBoxSource.SelectedIndex > -1)
            {
                listBoxTarget.Items.Add((string)comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
            }*/
            try
            {
                manager.MoveOne(comboBoxSource.SelectedIndex);
                // TODO : refresh items
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAllInTarget_Click(object sender, EventArgs e)
        {
            /*if(listBoxTarget.SelectedIndex > -1)
            {
                foreach (var item in comboBoxSource.Items)
                {
                    listBoxTarget.Items.Add(item);
                }
                comboBoxSource.Items.Clear();
            }*/
            manager.MoveAll();
        }

        private void btnAddOneInSource_Click(object sender, EventArgs e)
        {
            try
            {
                manager.ReverseMouveOne(listBoxTarget.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAllInSource_Click(object sender, EventArgs e)
        {
            manager.ReverseList();
            manager.MoveAll();
            manager.ReverseList();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            manager.Reverse();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            manager.Reverse();
        }
    }
}