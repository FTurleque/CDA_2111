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
        private List<JobSeeker> jobSeekers;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            jobSeekers = new List<JobSeeker>();
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
        }

        private void Validation_Click(object sender, EventArgs e)
        {
            try
            {
                /*_errorProvider.SetError(txtBoxName, _validName.IsValid(txtBoxName.Text) ? String.Empty : "Le Format du nom n'est pas valide.");
                _errorProvider.SetError(txtBoxFirstName, _validName.IsValid(txtBoxFirstName.Text) ? String.Empty : "Le Format du prénom n'est pas valide.");*/
                if (checkBoxDiploma.Checked)
                {
                    _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ? String.Empty : "");
                    _errorProvider.SetError(txtBoxDiplomaYear, _validYear.IsValid(txtBoxDiplomaYear.Text) ? String.Empty : "");
                    diploma = new Diploma(txtBoxDiplomaName.Text, Int32.Parse(txtBoxDiplomaYear.Text));
                }
                model = new JobSeekerViewModel()
                {
                    Name = txtBoxName.Text,
                    FirstName = txtBoxFirstName.Text,
                    Level = (Levels)Enum.Parse<Levels>(comboBoxLevels.SelectedItem.ToString()),
                    Diploma = diploma
                };
                if (model.IsValid())
                {
                    jobSeeker = new JobSeeker(model);
                    jobSeekers.Add(jobSeeker);
                    DisplayJobSeeker resp = new DisplayJobSeeker();
                    resp.JobSeekerLink(jobSeeker, this);
                    resp.Show();
                }
            }
            catch (FormatException ex)
            {
                _errorProvider.SetError(txtBoxDiplomaYear, ex.Message);

            }
            catch (InvalidDataException ex)
            {
                _errorProvider.SetError(txtBoxDiplomaName, ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                _errorProvider.SetError(txtBoxDiplomaYear, ex.Message);
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
            txtBoxDiplomaName.Clear();
            txtBoxDiplomaYear.Clear();
            comboBoxLevels.SelectedIndex = 0;
        }
    }
}