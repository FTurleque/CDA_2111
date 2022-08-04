using System.Runtime.InteropServices;
using TrouveEmploi.Lib.Class;
using TrouveEmploi.Lib.Extensions;
using TrouveEmploi.Lib.JobSeekerExceptions;
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
                model = new JobSeekerViewModel()
                {
                    Name = txtBoxName.Text,
                    FirstName = txtBoxFirstName.Text,
                    Level = (Levels)Enum.Parse<Levels>(comboBoxLevels.SelectedItem.ToString()),
                    Diploma = (checkBoxDiploma.Checked) ? new Diploma(txtBoxDiplomaName.Text, txtBoxDiplomaYear.Text) : null,
                };
                if (model.IsValid())
                {
                    SetErrorProvider();
                    jobSeeker = new JobSeeker(model);
                    jobSeekers.Add(jobSeeker);
                    DisplayJobSeeker resp = new DisplayJobSeeker();
                    resp.JobSeekerLink(jobSeeker, this);
                    resp.Show();
                }
            }
            catch (InvalidDataException ex)
            {
                SetErrorProvider(ex);
            }
            catch (InvalidNameException ex) 
            {
                SetErrorProvider(ex);
            }
            catch (InvalidStringException ex)
            {
                SetErrorProvider(ex);
            }
            catch (InvalidDateException ex)
            {
                SetErrorProvider(ex);
            }
        }

        private void SetErrorProvider([Optional] Exception e)
        {
            if (checkBoxDiploma.Checked)
            {
                _errorProvider.SetError(txtBoxDiplomaYear, _validYear.IsValid(txtBoxDiplomaYear.Text) ? 
                    String.Empty : e.Message + "l'ann�e du dipl�me.");
                _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ? 
                    String.Empty : e.Message + "le nom du dipl�me.");
                int dateNb;
                /*if (!String.IsNullOrEmpty(txtBoxDiplomaName.Text) && !String.IsNullOrEmpty(txtBoxDiplomaYear.Text))
                {
                    if (int.TryParse(txtBoxDiplomaYear.Text, out dateNb))
                    {
                        _errorProvider.SetError(txtBoxDiplomaYear,_validYear.IsNotInFuture(int.Parse(txtBoxDiplomaYear.Text)) ? 
                            String.Empty : $"{dateNb} est dans le futur.");
                        _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ? String.Empty : "Le nom du " + e.Message);
                    }
                    else
                    {
                        _errorProvider.SetError(txtBoxDiplomaYear, _validYear.IsValid(txtBoxDiplomaYear.Text) && 
                            _validYear.IsNotInFuture(int.Parse(txtBoxDiplomaYear.Text)) ? String.Empty : "L'ann�e du " + e.Message);
                        _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ? String.Empty : "Le nom du " + e.Message);
                    }
                    
                }
                else
                {
                    _errorProvider.SetError(txtBoxDiplomaYear, _validYear.IsValid(txtBoxDiplomaYear.Text) &&
                    _validYear.IsNotInFuture(int.Parse(txtBoxDiplomaYear.Text)) ||
                    String.IsNullOrEmpty(txtBoxDiplomaName.Text) ? String.Empty : e.Message + "l'ann�e du dipl�me.");
                    _errorProvider.SetError(txtBoxDiplomaName, _validSentences.IsValid(txtBoxDiplomaName.Text) ||
                        String.IsNullOrEmpty(txtBoxDiplomaYear.Text) ? String.Empty : e.Message + "le nom du dipl�me.");
                }*/
                
            }
            _errorProvider.SetError(txtBoxName, _validName.IsValid(txtBoxName.Text) ? String.Empty : e.Message);
            _errorProvider.SetError(txtBoxFirstName, _validName.IsValid(txtBoxFirstName.Text) ? String.Empty : e.Message);
        }

        private void AddDiploma_CheckedChanged(object sender, EventArgs e)
        {
            gBoxDiploma.Enabled = checkBoxDiploma.Checked;
        }

        public void ResetTheFields()
        {
            txtBoxName.Clear();
            txtBoxFirstName.Clear();
            txtBoxDiplomaName.Clear();
            txtBoxDiplomaYear.Clear();
            comboBoxLevels.SelectedIndex = 0;
        }
    }
}