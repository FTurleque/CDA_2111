using TrouveEmploi.Lib;

namespace TrouveEmploi
{
    public partial class DisplayJobSeeker : Form
    {
        FrmDemandeurEmploi parent;

        public DisplayJobSeeker()
        {
            InitializeComponent();
        }

        public void JobSeekerLink(JobSeeker _jobSeeker, FrmDemandeurEmploi _parent)
        {
            this.parent = _parent;
            txtBoxId.Text = _jobSeeker.Id.ToString();
            txtBoxName.Text = _jobSeeker.Name.ToString();
            txtBoxFirstName.Text = _jobSeeker.FirstName.ToString();
            txtBoxRegistrationYear.Text = _jobSeeker.RegistrationYear.ToString();
            txtBoxLevel.Text = _jobSeeker.Level.ToString();
            txtBoxEmployability.Text = _jobSeeker.Employability.ToString();
            if (_jobSeeker.Diploma != null)
            {
                txtBoxDiplomaName.Text = _jobSeeker.Diploma.LastDiplomaName.ToString();
                txtBoxDiplomaYear.Text = _jobSeeker.Diploma.LastDiplomaYear.ToString();
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            parent.Close();
            this.Close();
        }

        private void AddJobseeker_Click(object sender, EventArgs e)
        {
            parent.ResetTheFields();
            this.Close();
        }
    }
}
