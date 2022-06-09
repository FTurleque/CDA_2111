namespace CheckBoxAndRadioButtons
{
    public partial class Form1 : Form
    {
        Color labelTxtEnterBaseColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxChoice.Enabled = false;
            groupBoxBg.Visible = false;
            groupBoxChar.Visible = false;
            groupBoxCasse.Visible = false;
            labelTxtEnterBaseColor = this.labelTxtEnter.ForeColor;
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            if (userInput.Text.Length == 0)
            {
                groupBoxChoice.Enabled = false;
            }
            else
            {
                groupBoxChoice.Enabled = true;
            }
            labelTxtEnter.Text = userInput.Text;
        }

        private void CheckBoxBgColor_CheckedChanged(object sender, EventArgs e)
        {
            this.DisplayCheckBox(checkBoxBgColor, groupBoxBg);
            if(!checkBoxBgColor.Checked)
            {
                /*radioBtnBgBlue.Checked = false;
                radioBtnBgGreen.Checked = false;
                radioBtnBg.Checked = false;*/
                labelTxtEnter.BackColor = Color.Empty;
            }
        }

        private void RadioBtnBg_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnBg.Checked)
            {
                labelTxtEnter.BackColor = Color.Red;
            }
            else if(radioBtnBgGreen.Checked)
            {
                labelTxtEnter.BackColor = Color.Green;
            }
            else
            {
                labelTxtEnter.BackColor = Color.Blue;
            }
        }

        private void CheckBoxCharColor_CheckedChanged(object sender, EventArgs e)
        {
            this.DisplayCheckBox(checkBoxCharColor, groupBoxChar);
            if (!checkBoxCharColor.Checked)
            {
                labelTxtEnter.ForeColor = this.labelTxtEnterBaseColor;
                /*radioBtnCharBlack.Checked = false;
                radioBtnChar.Checked = false;
                radioBtnCharWhite.Checked = false;*/
            }
        }
        private void RadioBtnChar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnChar.Checked)
            {
                labelTxtEnter.ForeColor = Color.Red;
            }
            else if (radioBtnCharBlack.Checked)
            {
                labelTxtEnter.ForeColor = Color.Black;
            }
            else
            {
                labelTxtEnter.ForeColor = Color.White;
            }
        }


        private void CheckBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            this.DisplayCheckBox(checkBoxCasse, groupBoxCasse);
            if(checkBoxCasse.Checked)
            {
                radioBtnLowerCase.Checked = false;
                radioBtnUpperCase.Checked = false;
            }
        }

        private void DisplayCheckBox(CheckBox checkbox, GroupBox group)
        {
            if (checkbox.Checked)
            {
                group.Visible = true;
            }
            else
            {
                group.Visible = false;
            }
        }

        private void radioBtnLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.Text = labelTxtEnter.Text.ToLower();
        }

        private void radioBtnUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.Text = labelTxtEnter.Text.ToUpper();
        }

    }
}