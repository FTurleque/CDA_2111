namespace BasicOperationsOnListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxElements.Items.Add(textBoxNewElement.Text);
            textBoxCount.Text = listBoxElements.Items.Count.ToString();
            textBoxNewElement.Clear();
            textBoxNewElement.Focus();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            listBoxElements.SelectedIndex = int.Parse(textBoxIndexElement.Text);
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