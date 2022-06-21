namespace FormsMenu
{
    public partial class ListBoxOperation : Form
    {
        ErrorProvider errorProvider;
        public ListBoxOperation()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(!listBoxElements.Items.Contains(textBoxNewElement.Text))
            {
                listBoxElements.Items.Add(textBoxNewElement.Text);
                textBoxCount.Text = listBoxElements.Items.Count.ToString();
                listBoxElements.SelectedIndex = listBoxElements.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Le nouvel element est déjà dans la liste", 
                    "Erreur", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            textBoxNewElement.Clear();
            textBoxNewElement.Focus();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxIndexElement, 
                listBoxElements.Items.Count > int.Parse(textBoxIndexElement.Text) ?
                String.Empty : "Le chiffre séléctionner est hors limite");
            if (listBoxElements.Items.Count > int.Parse(textBoxIndexElement.Text))
            {
                listBoxElements.SelectedIndex = int.Parse(textBoxIndexElement.Text);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBoxElements.Items.Clear();
        }

        private void ListBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = listBoxElements.SelectedIndex.ToString();
            textBoxText.Text = listBoxElements.SelectedItem.ToString();
        }
    }
}