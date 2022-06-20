using System.Globalization;
using System.Text.RegularExpressions;

namespace FormsMenu
{
    public partial class InputValidator : Form
    {
        private ErrorProvider errorProvider;
        private NameValidator nameValidator;
        private DateValidator dateValidator;
        private DoubleValidator doubleValidator;
        private ZipCode zipCode;

        public InputValidator()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            nameValidator = new NameValidator();
            dateValidator = new DateValidator();
            doubleValidator = new DoubleValidator();
            zipCode = new ZipCode();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();
            errorProvider.Clear();
            txtNom.Focus();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNom, nameValidator.IsValidName(txtNom.Text) ? String.Empty : "Erreur de nom.");
            errorProvider.SetError(txtDate, dateValidator.IsValidDate(txtDate.Text) ? String.Empty : "Erreur de format de date.");
            errorProvider.SetError(txtMontant, doubleValidator.IsValidDouble(txtMontant.Text) ? String.Empty : "Erreur de format.");
            errorProvider.SetError(txtCP, zipCode.isValidNumber(txtCP.Text) ? String.Empty : "Erreur de code postal.");

            if( nameValidator.IsValidName(txtNom.Text) && 
                dateValidator.IsValidDate(txtDate.Text) &&
                doubleValidator.IsValidDouble(txtMontant.Text) &&
                zipCode.isValidNumber(txtCP.Text))
            {
                MessageBox.Show("Nom : " + txtNom.Text +
                                "\nDate : " + txtDate.Text +
                                "\nMontant : " + txtMontant.Text +
                                "\nCode : " + txtCP.Text, "Validation effectuée", MessageBoxButtons.OK);
                var result = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}