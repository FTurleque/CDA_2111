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
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtNom.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtNom_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNom.Text))
            {
                errorProvider.SetError(txtNom, "Entrez un nom.");
            }
            else
            {
                errorProvider.SetError(txtNom, "");
                if (!Regex.IsMatch(txtNom.Text, @"^[\D]+$"))
                {
                    errorProvider.SetError(txtNom, "Un nom ne comporte pas de chiffre.");
                }
                else
                {
                    errorProvider.SetError(txtNom, "");
                }
            }

        }

        private void txtDate_Validated(object sender, EventArgs e)
        {
            try
            {
                var cultureInfo = new CultureInfo("fr-FR");
                DateTime date = DateTime.Parse(txtDate.Text, cultureInfo);
                if(date < DateTime.Now) 
                {
                    MessageBox.Show("La date est déja passé.");
                    txtDate.Clear();
                }
                /*if(Regex.IsMatch(txtDate.Text, @"^[a-z]+([ \-']?[a-z]+[ \-']?[a-z]+[ \-']?)[a-z]+$"))
                {
                    string[] date = txtDate.Text.Split('\u002C');
                }
                else
                {
                    throw new Exception("Le format entré n'est pas au format date.");
                }*/
            }
            catch (FormatException error)
            {
                Console.Error.WriteLine("Erreur : " + error);
            }
        }
    }
}