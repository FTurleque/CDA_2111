namespace FormsMenu
{
    public partial class CheckBoxRadioBtn : Form
    {
        private Color labelTxtEnterBaseColor;

        public CheckBoxRadioBtn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBtnBg.Tag = Color.Red;
            radioBtnBgBlue.Tag = Color.Blue;
            radioBtnBgGreen.Tag = Color.Green;
            checkBoxBgColor.Tag = groupBoxBg;
            checkBoxCharColor.Tag = groupBoxChar;
            checkBoxCase.Tag = groupBoxCasse;
            groupBoxChoice.Enabled = false;
            groupBoxBg.Visible = false;
            groupBoxChar.Visible = false;
            groupBoxCasse.Visible = false;
            labelTxtEnterBaseColor = this.labelTxtEnter.ForeColor;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            groupBoxChoice.Enabled = (userInput.Text.Length > 0) ? true : false;
            labelTxtEnter.Text = userInput.Text;
        }

        private void CheckBoxBgColor_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxChecked = (CheckBox)sender;
            GroupBox groupBox = (GroupBox)checkBoxChecked.Tag;
            groupBox.Visible = checkBoxChecked.Checked ? true : false;

            if(!checkBoxBgColor.Checked)
            {
                radioBtnBgBlue.Checked = false;
                radioBtnBgGreen.Checked = false;
                radioBtnBg.Checked = false;
                labelTxtEnter.BackColor = Color.Empty;
            }

            if (!checkBoxCharColor.Checked)
            {
                radioBtnCharBlack.Checked = false;
                radioBtnChar.Checked = false;
                radioBtnCharWhite.Checked = false;
                labelTxtEnter.ForeColor = this.labelTxtEnterBaseColor;
            }
            if(!checkBoxCase.Checked)
            {
                radioBtnCase.Checked = false;
                radioBtnUpperCase.Checked = false;
                labelTxtEnter.Text = userInput.Text;
            }

        }

        private void RadioBtnBg_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            labelTxtEnter.BackColor = (Color)radioBtn.Tag;
        }

        private void RadioBtnChar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            labelTxtEnter.ForeColor = radioBtn.Name switch
            {
                "radioBtnCharBlack" => Color.Black,
                "radioBtnCharWhite" => Color.White,
                _ => Color.Red,
            };
        }

        private void radioBtnCase_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            labelTxtEnter.Text = (radioButton.Name == "radioBtnUpperCase") ? labelTxtEnter.Text.ToUpper() : labelTxtEnter.Text.ToLower();
        }

    }
}