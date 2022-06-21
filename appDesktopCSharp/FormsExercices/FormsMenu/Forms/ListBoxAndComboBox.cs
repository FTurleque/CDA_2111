using System.ComponentModel;

namespace FormsMenu
{
    public partial class ListBoxAndComboBox : Form
    {
        ListManager manager;

        public ListBoxAndComboBox()
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
                    "Canada", "Chili", "Chine", "Colombie", "Égypte", "Espagne", "France", "Ghana", "Grece", "Guinée", "Guyane",
                    "Japon", "Jordanie", "Laos", "Liban", "Macao", "Mali", "Maroc", "Mongolie", "Népal", "Nigéria", "Panama",
                    "Paraguay", "Pérou", "Philippines", "Pologne", "Portugal", "Roumanie", "Russie", "Salvador", "Suède", "Suisse",
                    "Taïwan", "Tanzanie", "Ukraine", "USA", "Viêtnam", "Zambie"
                },
                Target = new BindingList<string>()
            };
            comboBoxSource.DataSource = manager.Source;
            listBoxTarget.DataSource = manager.Target;
            btnDown.Tag = 2;
            btnUp.Tag = -1;
            comboBoxSource.SelectedIndex = -1;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }
        private void ComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisablingTheButtons();
        }

        private void ListBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisablingTheButtons();
            btnUp.Enabled = listBoxTarget.SelectedIndex > 0;
            btnDown.Enabled = listBoxTarget.SelectedIndex < manager.Target.Count - 1 && 
                listBoxTarget.SelectedIndex != -1;
        }

        private void DisablingTheButtons()
        {
            btnAddOneInTarget.Enabled = comboBoxSource.SelectedIndex >= 0;
            btnAddAllInTarget.Enabled = manager.Source.Count > 0;
            btnAddAllInSource.Enabled = manager.Target.Count > 0;
            btnAddOneInSource.Enabled = listBoxTarget.SelectedIndex >= 0;
        }

        private void BtnAddOneInTarget_Click(object sender, EventArgs e)
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

        private void BtnAddAllInTarget_Click(object sender, EventArgs e)
        {
            manager.MoveAll();
            listBoxTarget.SelectedIndex = -1;
        }

        private void BtnAddOneInSource_Click(object sender, EventArgs e)
        {
            try
            {
                manager.ReverseMoveOne(listBoxTarget.SelectedIndex);
                comboBoxSource.SelectedIndex = -1;
                listBoxTarget.SelectedIndex = -1;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddAllInSource_Click(object sender, EventArgs e)
        {
            manager.ReverseMoveAll();
            comboBoxSource.SelectedIndex = -1;
            listBoxTarget.SelectedIndex = -1;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                listBoxTarget.SelectedIndex =
                    manager.Move(
                        listBoxTarget.SelectedIndex,
                        (int)control.Tag
                );
            }
        }
    }
}