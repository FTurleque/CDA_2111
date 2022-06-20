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
            listBoxElements.Items.Add(textBoxNewElement.Text);
            textBoxCount.Text = listBoxElements.Items.Count.ToString();
            textBoxNewElement.Clear();
            textBoxNewElement.Focus();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if(listBoxElements.Items.Count > int.Parse(textBoxIndexElement.Text))
            {
                listBoxElements.SelectedIndex = int.Parse(textBoxIndexElement.Text);
            }
            else
            {
                errorProvider.SetError(textBoxIndexElement, "Le chiffre séléctionner est hors limite");
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