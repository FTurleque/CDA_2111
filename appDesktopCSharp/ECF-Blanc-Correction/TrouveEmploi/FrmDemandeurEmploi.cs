using TrouveEmploi.Lib.Class;
using TrouveEmploi.Lib.Extensions;
using TrouveEmploi.Lib.Validation;

namespace TrouveEmploi
{
    public partial class FrmDemandeurEmploi : Form
    {
        private ErrorProvider _errorProvider;
        private NameValidator _validName;
        private YearValidator _validYear;
        private SentenceValidator _validSentences;
        private Diploma? diploma;
        private JobSeekerViewModel model;
        private JobSeeker jobSeeker;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _errorProvider = new ErrorProvider();
            _validName = new NameValidator();
            _validYear = new YearValidator();
            _validSentences = new SentenceValidator();
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
            try
            {
                _errorProvider.SetError(txtBoxName, _validName.IsValid(txtBoxName.Text) ? String.Empty : "Le Format du nom n'est pas valide.");
                _errorProvider.SetError(txtBoxFirstName, _validName.IsValid(txtBoxFirstName.Text) ? String.Empty : "Le Format du prénom n'est pas valide.");
                _errorProvider.SetError(txtBoxRegistration, _validYear.IsValid(txtBoxRegistration.Text) ? String.Empty : "La date est dans le futur ou c'est des lettre.");
                if (checkBoxDiploma.Checked)
                {
                    _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ? String.Empty : "Le nom du diplôme a des charactère intérdit.");
                    _errorProvider.SetError(txtBoxDiplomaYear, _validYear.IsValid(txtBoxDiplomaYear.Text) ? String.Empty : "La date est dans le futur ou c'est des lettre.");
                    diploma = new Diploma(txtBoxDiplomaName.Text, Int32.Parse(txtBoxDiplomaYear.Text));
                }
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