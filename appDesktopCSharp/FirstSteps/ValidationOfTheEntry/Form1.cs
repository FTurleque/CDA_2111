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

        }

        private void txtNom_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNom.Text, @"^[\D]+$"))
            {
                Console.WriteLine(txtNom.Text);
            }
            else
            {
                string message = "Vous n'avez pas entrée de lettres";
                MessageBox.Show(message);
                txtNom.Clear();
                //Console.WriteLine("Vous n'avez pas entré de lettres");
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