using FormsMenu;
using FormsMenu.Lib;

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
        }

        private void HScrollBarMonth_Scroll(object sender, ScrollEventArgs e)
        {
            labelMonth.Text = hScrollBarMonth.Value.ToString();
            refund.RefundNumber = (double)(int.Parse(labelMonth.Text) / (int)hScrollBarMonth.Tag);
            labelRefundNumber.Text = refund.RefundNumber.ToString();
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
            var step = listBoxPeriods.SelectedItem switch
            {
                "Bimestriel" => 2,
                "Trimestriel" => 3,
                "Semestriel" => 6,
                "Annuel" => 12,
                _ => 1,
            };
            hScrollBarMonth.Tag = step;
            hScrollBarMonth.Minimum = (int)hScrollBarMonth.Tag;
            labelMonth.Text = hScrollBarMonth.Minimum.ToString();
            hScrollBarMonth.LargeChange = step * 2;
            hScrollBarMonth.SmallChange = step;
            hScrollBarMonth.Value = step;
            refund.Periodicity = (double)step;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxLoan, doubleValidator.IsValidDouble(textBoxLoan.Text) ? String.Empty : "Ne doit contenir que des chiffre ',' ou '.'.");
            errorProvider.SetError(textBoxName, nameValidate.IsValidName(textBoxName.Text) ? String.Empty : "Erreur de nom");
            labelResultLoan.Text = refund.Refund(double.Parse(textBoxLoan.Text)).ToString() + " €";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}