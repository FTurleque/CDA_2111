using TrouveEmploi.Lib;
using TrouveEmploi.Lib.Validation;

namespace TrouveEmploi
{
    public partial class MainForm : Form
    {
        private Diploma? diploma;
        private JobSeekerViewModel model;
        private JobSeeker jobSeeker;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Levels level in Enum.GetValues(typeof(Levels)))
            {
                comboBoxLevels.Items.Add(EnumExtensions.GetDescription(level));
            }
            comboBoxLevels.SelectedIndex = 0;
            // Valeurs temporaires
            txtBoxName.Text = "Turleque";
            txtBoxFirstName.Text = "Fabrice";
            txtBoxRegistration.Text = "2020";
        }

        private void Validation_Click(object sender, EventArgs e)
        {
            diploma = new Diploma(txtBoxDiplomaName.Text, Int32.Parse(txtBoxDiplomaYear.Text));
            model = new JobSeekerViewModel()
            {
                Name = txtBoxName.Text,
                FirstName = txtBoxFirstName.Text,
                RegistrationYear = Int32.Parse(txtBoxRegistration.Text),
                Level = (Levels)Enum.Parse<Levels>(comboBoxLevels.SelectedItem.ToString()),
                Diploma = diploma
            };
            if (model.IsValid())
            {
                jobSeeker = new JobSeeker(model);
            }
        }

        private void AddDiploma_CheckedChanged(object sender, EventArgs e)
        {
            gBoxDiploma.Enabled = checkBoxDiploma.Checked;
        }
    }
}