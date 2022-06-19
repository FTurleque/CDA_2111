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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            nameValidator = new NameValidator();
            dateValidator = new DateValidator();
            doubleValidator = new DoubleValidator();
            zipCode = new ZipCode();

        // Application.Restart();
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();
            errorProvider.Clear();
            txtNom.Focus();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(txtNom, nameValidator.isValidName(txtNom.Text) ? String.Empty : "Erreur de nom.");
                errorProvider.SetError(txtDate, dateValidator.IsValidDate(txtDate.Text) ? String.Empty : "Erreur de format de date.");
                errorProvider.SetError(txtMontant, doubleValidator.IsValidDouble(txtMontant.Text) ? String.Empty : "Erreur de format.");
                errorProvider.SetError(txtCP, zipCode.isValidNumber(txtCP.Text) ? String.Empty : "Erreur de code postal.");

            }
            catch (Exception)
            {

                throw;
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
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
            else
            {
                MessageBox.Show("Remplissez les champs", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void TxtNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                string message = "Entrez un nom.";
                this.ReturnErrorMessage(txtNom, message, e);
            }
            else if (!Regex.IsMatch(txtNom.Text, @"^[a-zA-Z]+([-]?[a-zA-Z]+)$"))
            {
                string message = "Entrez des lettres avec un - ou pas.";
                this.ReturnErrorMessage(txtNom, message, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNom, string.Empty);
            }*/
        }

        private void TxtDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                string message = "Entrez une date.";
                this.ReturnErrorMessage(txtDate, message, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDate, string.Empty);
                try
                {
                    DateTime date;
                    CultureInfo userUICultureInfo = CultureInfo.CurrentUICulture;
                        if(userUICultureInfo.Name != new CultureInfo("fr-FR").Name || 
                        DateTime.TryParseExact(txtDate.Text, "yyyy/MM/dd", 
                        new CultureInfo("en-US"),
                        DateTimeStyles.None,
                        out date))
                    {
                        date = DateTime.Parse(txtDate.Text, new CultureInfo("fr-FR"));
                        txtDate.Text = date.ToString("d");
                    }
                    else
                    {
                        date = DateTime.Parse(txtDate.Text);
                    }
                    if (date < DateTime.Now)
                    {
                        string message = "La date est déja passé.";
                        this.ReturnErrorMessage(txtDate, message, e);
                    }
                }
                catch (FormatException)
                {
                    errorProvider.SetError(txtDate, "Entrez un date valide.");
                }
            }
        }

        private void TxtMontant_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            if (string.IsNullOrWhiteSpace(txtMontant.Text))
            {
                string message = "Entrer un montant.";
                this.ReturnErrorMessage(txtMontant, message, e);
            }
            else if(!Regex.IsMatch(txtMontant.Text, @"^[\d]+([.,]?[\d]{2})$"))
            {
                string message = "Entré des chiffres uniquement positif, deux chiffres après la virgule max.";
                this.ReturnErrorMessage(txtMontant, message, e);
            }
            else
            {
                if(currentCulture == new CultureInfo("en-EN"))
                {
                    txtMontant.Text = Regex.Replace(txtMontant.Text, "[,]", replacement: ".");
                } 
                else
                {
                    txtMontant.Text = Regex.Replace(txtMontant.Text, "[.]", replacement: ",");
                }
                e.Cancel = false;
                errorProvider.SetError(txtMontant, string.Empty);
            }
        }

        private void TxtCP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCP.Text))
            {
                string message = "Entrez un code postal.";
                this.ReturnErrorMessage(txtCP, message, e);
            }
            else if(!Regex.IsMatch(txtCP.Text, @"^[\d]{5}"))
            {
                string message = "Un code postal est composé de chiffre";
                this.ReturnErrorMessage(txtCP, message, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCP, string.Empty);
            }
        }

        private void ReturnErrorMessage(TextBox textBox, string message, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            /*textBox.Focus();*/
            errorProvider.SetError(textBox, message);
        }
    }
}