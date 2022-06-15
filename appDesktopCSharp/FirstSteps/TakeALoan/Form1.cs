using LibInputValidation;

namespace TakeALoan
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider;
        private NameValidator nameValidate;
        private DoubleValidator doubleValidator;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            nameValidate = new NameValidator();
            doubleValidator = new DoubleValidator();
            radioBtnPercent.Checked = true;
            radioBtnPercent.Tag = 7;
            radioBtn8.Tag = 8;
            radioBtn9.Tag = 9;
            listBoxPeriods.SelectedIndex = 0;
            labelRefundNumber.Text = "1";
        }

        private void HScrollBarMonth_Scroll(object sender, ScrollEventArgs e)
        {
            labelMonth.Text = hScrollBarMonth.Value.ToString();
            labelRefundNumber.Text = (int.Parse(labelMonth.Text) / (int)hScrollBarMonth.Tag).ToString();
        }

        private void RadioBtnPercent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            int step;
            switch (listBoxPeriods.SelectedItem)
            {
                case "Bimestriel":
                    step = 2;
                    break;
                case "Trimestriel":
                    step = 3;
                    break;
                case "Semestriel":
                    step = 6;
                    break;
                case "Annuel":
                    step = 12;
                    break;
                default:
                    step = 1;
                    break;
            }
            hScrollBarMonth.Tag = step;
            hScrollBarMonth.Minimum = (int)hScrollBarMonth.Tag;
            labelMonth.Text = hScrollBarMonth.Minimum.ToString();
            hScrollBarMonth.LargeChange = step * 2;
            hScrollBarMonth.SmallChange = step;
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxLoan, doubleValidator.IsValidDouble(textBoxLoan.Text) ? String.Empty : "Ne doit contenir que des chiffre ',' ou '.'.");
            errorProvider.SetError(textBoxName, nameValidate.isValidName(textBoxName.Text) ? String.Empty : "Erreur de nom");

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}