using System.Globalization;
using System.Text.RegularExpressions;

namespace ValidationOfTheEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Application.Restart();
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();
            errorProvider.Clear();
            txtNom.Focus();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Nom : " + txtNom.Text +
                                "\nDate : " + txtDate.Text +
                                "\nMontant : " + txtMontant.Text +
                                "\nCode : " + txtCP.Text, "Validation effectuée", MessageBoxButtons.OK);
                MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

        }

        private void txtNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                e.Cancel = true;
                txtNom.Focus();
                errorProvider.SetError(txtNom, "Entrez un nom.");
            }
            else if (!Regex.IsMatch(txtNom.Text, @"^[a-zA-Z]+[-][a-zA-Z]+$"))
            {
                e.Cancel = true;
                txtNom.Focus();
                errorProvider.SetError(txtNom, "Entrez des lettres avec un - ou pas.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNom, string.Empty);
            }
        }

        private void txtDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                e.Cancel = true;
                txtDate.Focus();
                errorProvider.SetError(txtDate, "Entrez une date.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDate, string.Empty);
                try
                {
                    // Permettre tous les format de date et afficher au format fr
                    var cultureInfo = new CultureInfo("fr-FR");
                    DateTime date = DateTime.Parse(txtDate.Text, cultureInfo);
                    if (date < DateTime.Now)
                    {
                        MessageBox.Show("La date est déja passé.");
                        txtDate.Clear();
                    }
                }
                catch (FormatException error)
                {
                    errorProvider.SetError(txtDate, "Entrez un date valide?.");
                }
            }
        }

        private void txtMontant_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Verifier dans le montant la , et . (Fr: , et En: .) selon le systeme changer le . en , vis et versa
            if(string.IsNullOrWhiteSpace(txtMontant.Text))
            {
                e.Cancel = true;
                txtMontant.Focus();
                errorProvider.SetError(txtMontant, "Entrer un montant.");
            }
            else if(!Regex.IsMatch(txtMontant.Text, @"^[\d]+([.,]?[\d]{2})$"))
            {
                e.Cancel = true;
                txtMontant.Focus();
                errorProvider.SetError(txtMontant, "Entré des chiffres, deux chiffres après la virgule max.");
            }
            else if (double.Parse(txtMontant.Text) < 0)
            {
                e.Cancel = false;
                txtMontant.Focus();
                errorProvider.SetError(txtMontant, "Vous ne pouvez pas être en négatif.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMontant, string.Empty);
            }
        }

        private void txtCP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCP.Text))
            {
                e.Cancel = true;
                txtCP.Focus();
                errorProvider.SetError(txtCP, "Entrez un code postal.");
            }
            else if(!Regex.IsMatch(txtCP.Text, @"^[\d]{5}"))
            {
                e.Cancel = true;
                txtCP.Focus();
                errorProvider.SetError(txtCP, "Un code postal est composé de chiffre");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCP, string.Empty);
            }
        }
    }
}