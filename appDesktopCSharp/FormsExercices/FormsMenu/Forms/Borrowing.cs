using FormsMenu;

namespace FormsMenu
{
    public partial class Borrowing : Form
    {
        private ErrorProvider errorProvider;
        private NameValidator nameValidate;
        private DoubleValidator doubleValidator;
        private RefundCalculation refund;

        public Borrowing()
        {
            InitializeComponent();
            refund = new RefundCalculation();
            errorProvider = new ErrorProvider();
            nameValidate = new NameValidator();
            doubleValidator = new DoubleValidator();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioBtnPercent.Checked = true;
            radioBtnPercent.Tag = 0.07;
            radioBtn8.Tag = 0.08;
            radioBtn9.Tag = 0.09;
            listBoxPeriods.SelectedIndex = 0;
            labelRefundNumber.Text = "1";
            refund.Rate = (double)radioBtnPercent.Tag;
            /*refund.RefundNumber = int.Parse(labelRefundNumber.Text);*/
        }

        private void HScrollBarMonth_Scroll(object sender, ScrollEventArgs e)
        {
            labelMonth.Text = hScrollBarMonth.Value.ToString();
            labelRefundNumber.Text = (int.Parse(labelMonth.Text) / (int)hScrollBarMonth.Tag).ToString();
            refund.RefundNumber = int.Parse(labelMonth.Text);
        }

        private void RadioBtnPercent_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtnChecked = (RadioButton)sender;
            if(refund.Rate != 0)
            {
                refund.Rate = (double)radioBtnChecked.Tag;
            }
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
            hScrollBarMonth.Value = step;
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxLoan, doubleValidator.IsValidDouble(textBoxLoan.Text) ? String.Empty : "Ne doit contenir que des chiffre ',' ou '.'.");
            errorProvider.SetError(textBoxName, nameValidate.IsValidName(textBoxName.Text) ? String.Empty : "Erreur de nom");
            double tmp = (double)((int)hScrollBarMonth.Tag);
            labelResultLoan.Text = refund.Refund(double.Parse(textBoxLoan.Text), tmp).ToString() + " €";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}