using TrouveEmploi.Lib;
using TrouveEmploi.Lib.Validation;

namespace TrouveEmploi
{
    public partial class FrmDemandeurEmploi : Form
    {
        private Diploma? diploma;
        private JobSeekerViewModel model;
        private JobSeeker jobSeeker;

        public FrmDemandeurEmploi()
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
            if (checkBoxDiploma.Checked)
            {
                diploma = new Diploma(txtBoxDiplomaName.Text, Int32.Parse(txtBoxDiplomaYear.Text));
            }
            try
            {
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
                    DisplayJobSeeker resp = new DisplayJobSeeker();
                    resp.JobSeekerLink(jobSeeker, this);
                    resp.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddDiploma_CheckedChanged(object sender, EventArgs e)
        {
            gBoxDiploma.Enabled = checkBoxDiploma.Checked;
        }

        public void ResetTheFields()
        {
            /*foreach (Control c in this.Controls)
            {
                if (c is TextBox box)
                {
                    box.Clear();
                }
            }*/
            txtBoxName.Clear();
            txtBoxFirstName.Clear();
            txtBoxRegistration.Clear();
            txtBoxDiplomaName.Clear();
            txtBoxDiplomaYear.Clear();
            comboBoxLevels.SelectedIndex = 0;
        }
    }
}