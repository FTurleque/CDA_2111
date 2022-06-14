using System.ComponentModel;

namespace ListBoxAndComboBox
{
    public partial class Form1 : Form
    {
        ListManager manager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new ListManager()
            {
                Source = new BindingList<string>()
                {
                    "Allemagne", "Australie", "Autriche", "Bahamas", "Belgique", "Birmanie", "Brésil", "Bulgarie", "Cameroun",
                    /*"Canada", "Chili", "Chine", "Colombie", "Égypte", "Espagne", "France", "Ghana", "Grece", "Guinée", "Guyane",
                    "Japon", "Jordanie", "Laos", "Liban", "Macao", "Mali", "Maroc", "Mongolie", "Népal", "Nigéria", "Panama",
                    "Paraguay", "Pérou", "Philippines", "Pologne", "Portugal", "Roumanie", "Russie", "Salvador", "Suède", "Suisse",
                    "Taïwan", "Tanzanie", "Ukraine", "USA", "Viêtnam", "Zambie"*/
                },
                Target = new BindingList<string>()
            };
            comboBoxSource.DataSource = manager.Source;
            listBoxTarget.DataSource = manager.Target;
            comboBoxSource.SelectedIndex = -1;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddOneInTarget.Enabled = comboBoxSource.SelectedIndex >= 0;
            btnAddAllInTarget.Enabled = manager.Source.Count > 0;
            btnAddAllInSource.Enabled = manager.Target.Count > 0;
            btnAddOneInSource.Enabled = listBoxTarget.SelectedIndex >= 0;
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddOneInTarget.Enabled = comboBoxSource.SelectedIndex >= 0;
            btnAddAllInTarget.Enabled = manager.Source.Count > 0;
            btnAddAllInSource.Enabled = manager.Target.Count > 0;
            btnAddOneInSource.Enabled = listBoxTarget.SelectedIndex >= 0;
            btnUp.Enabled = listBoxTarget.SelectedIndex > 0;
            btnDown.Enabled = listBoxTarget.SelectedIndex > 0;
        }

        private void btnAddOneInTarget_Click(object sender, EventArgs e)
        {
            try
            {
                manager.MoveOne(comboBoxSource.SelectedIndex);
                comboBoxSource.SelectedIndex = -1;
                listBoxTarget.SelectedIndex = -1;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAllInTarget_Click(object sender, EventArgs e)
        {
            manager.MoveAll();
            listBoxTarget.SelectedIndex = -1;
        }

        private void btnAddOneInSource_Click(object sender, EventArgs e)
        {
            try
            {
                manager.ReverseMouveOne(listBoxTarget.SelectedIndex);
                comboBoxSource.SelectedIndex = -1;
                listBoxTarget.SelectedIndex = -1;
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
            comboBoxSource.SelectedIndex = -1;
            listBoxTarget.SelectedIndex = -1;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            manager.Move(listBoxTarget.SelectedIndex, listBoxTarget.SelectedIndex - 1);
            listBoxTarget.SelectedIndex--;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            manager.Move(listBoxTarget.SelectedIndex, listBoxTarget.SelectedIndex + 1);
            listBoxTarget.SelectedIndex++;
        }
    }
}