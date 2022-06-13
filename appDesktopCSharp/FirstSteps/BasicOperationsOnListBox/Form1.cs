namespace BasicOperationsOnListBox
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            listBoxElements.Items.Add(textBoxNewElement.Text);
            textBoxCount.Text = listBoxElements.Items.Count.ToString();
            textBoxNewElement.Clear();
            textBoxNewElement.Focus();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxElements.Items.Clear();
        }

        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = listBoxElements.SelectedIndex.ToString();
            textBoxText.Text = listBoxElements.SelectedItem.ToString();
        }
    }
}