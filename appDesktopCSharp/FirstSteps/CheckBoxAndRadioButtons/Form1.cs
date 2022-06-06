using System.Drawing;

namespace CheckBoxAndRadioButtons
{
    public partial class Form1 : Form
    {
        Color labelTxtEnterBaseColor;

        public Form1()
        {
            InitializeComponent();
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

        private void checkBoxBgColor_CheckedChanged(object sender, EventArgs e)
        {
            this.displayCheckBox(checkBoxBgColor, groupBoxBg);
            if(!checkBoxBgColor.Checked)
            {
                labelTxtEnter.BackColor = Color.Empty;
            }
        }

        private void radioBtnBgBlue_CheckedChanged(object sender, EventArgs e)
        {
           labelTxtEnter.BackColor = Color.Blue;
        }

        private void radioBtnBgGreen_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.BackColor = Color.Green;
        }

        private void radioBtnBgRed_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.BackColor = Color.Red;
        }

        private void checkBoxCharColor_CheckedChanged(object sender, EventArgs e)
        {
            this.displayCheckBox(checkBoxCharColor, groupBoxChar);
            if (!checkBoxCharColor.Checked)
            {
                labelTxtEnter.ForeColor = this.labelTxtEnterBaseColor;
            }
        }

        private void radioBtnCharRed_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.ForeColor = Color.Red;
        }

        private void radioBtnCharWhite_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.ForeColor = Color.White;
        }

        private void radioBtnCharBlack_CheckedChanged(object sender, EventArgs e)
        {
            labelTxtEnter.ForeColor = Color.Black;
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            this.displayCheckBox(checkBoxCasse, groupBoxCasse);
        }

        private void displayCheckBox(CheckBox checkbox, GroupBox group)
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