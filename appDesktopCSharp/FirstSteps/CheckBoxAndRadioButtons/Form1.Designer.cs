namespace CheckBoxAndRadioButtons
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserInput = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCharColor = new System.Windows.Forms.CheckBox();
            this.checkBoxBgColor = new System.Windows.Forms.CheckBox();
            this.groupBoxBg = new System.Windows.Forms.GroupBox();
            this.radioBtnBgGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnBgBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnBgRed = new System.Windows.Forms.RadioButton();
            this.groupBoxChar = new System.Windows.Forms.GroupBox();
            this.radioBtnCharWhite = new System.Windows.Forms.RadioButton();
            this.radioBtnCharRed = new System.Windows.Forms.RadioButton();
            this.radioBtnCharBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioBtnUpperCase = new System.Windows.Forms.RadioButton();
            this.radioBtnLowerCase = new System.Windows.Forms.RadioButton();
            this.labelTxt = new System.Windows.Forms.Label();
            this.labelTxtEnter = new System.Windows.Forms.Label();
            this.groupBoxChoice.SuspendLayout();
            this.groupBoxBg.SuspendLayout();
            this.groupBoxChar.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserInput
            // 
            this.labelUserInput.AutoSize = true;
            this.labelUserInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserInput.Location = new System.Drawing.Point(28, 13);
            this.labelUserInput.Name = "labelUserInput";
            this.labelUserInput.Size = new System.Drawing.Size(124, 21);
            this.labelUserInput.TabIndex = 3;
            this.labelUserInput.Text = "Taper votre texte";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInput.Location = new System.Drawing.Point(28, 42);
            this.userInput.MaxLength = 25;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(278, 25);
            this.userInput.TabIndex = 4;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoice.Controls.Add(this.checkBoxCharColor);
            this.groupBoxChoice.Controls.Add(this.checkBoxBgColor);
            this.groupBoxChoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxChoice.Location = new System.Drawing.Point(360, 13);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(218, 118);
            this.groupBoxChoice.TabIndex = 5;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(12, 82);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(63, 23);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // checkBoxCharColor
            // 
            this.checkBoxCharColor.AutoSize = true;
            this.checkBoxCharColor.Location = new System.Drawing.Point(12, 53);
            this.checkBoxCharColor.Name = "checkBoxCharColor";
            this.checkBoxCharColor.Size = new System.Drawing.Size(174, 23);
            this.checkBoxCharColor.TabIndex = 1;
            this.checkBoxCharColor.Text = "Couleur des charactères";
            this.checkBoxCharColor.UseVisualStyleBackColor = true;
            this.checkBoxCharColor.CheckedChanged += new System.EventHandler(this.checkBoxCharColor_CheckedChanged);
            // 
            // checkBoxBgColor
            // 
            this.checkBoxBgColor.AutoSize = true;
            this.checkBoxBgColor.Location = new System.Drawing.Point(12, 24);
            this.checkBoxBgColor.Name = "checkBoxBgColor";
            this.checkBoxBgColor.Size = new System.Drawing.Size(127, 23);
            this.checkBoxBgColor.TabIndex = 0;
            this.checkBoxBgColor.Text = "Couleur de fond";
            this.checkBoxBgColor.UseVisualStyleBackColor = true;
            this.checkBoxBgColor.CheckedChanged += new System.EventHandler(this.checkBoxBgColor_CheckedChanged);
            // 
            // groupBoxBg
            // 
            this.groupBoxBg.Controls.Add(this.radioBtnBgGreen);
            this.groupBoxBg.Controls.Add(this.radioBtnBgBlue);
            this.groupBoxBg.Controls.Add(this.radioBtnBgRed);
            this.groupBoxBg.Location = new System.Drawing.Point(28, 184);
            this.groupBoxBg.Name = "groupBoxBg";
            this.groupBoxBg.Size = new System.Drawing.Size(106, 119);
            this.groupBoxBg.TabIndex = 6;
            this.groupBoxBg.TabStop = false;
            this.groupBoxBg.Text = "Fond";
            // 
            // radioBtnBgGreen
            // 
            this.radioBtnBgGreen.AutoSize = true;
            this.radioBtnBgGreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnBgGreen.Location = new System.Drawing.Point(13, 52);
            this.radioBtnBgGreen.Name = "radioBtnBgGreen";
            this.radioBtnBgGreen.Size = new System.Drawing.Size(52, 23);
            this.radioBtnBgGreen.TabIndex = 2;
            this.radioBtnBgGreen.TabStop = true;
            this.radioBtnBgGreen.Text = "Vert";
            this.radioBtnBgGreen.UseVisualStyleBackColor = true;
            this.radioBtnBgGreen.CheckedChanged += new System.EventHandler(this.radioBtnBgGreen_CheckedChanged);
            // 
            // radioBtnBgBlue
            // 
            this.radioBtnBgBlue.AutoSize = true;
            this.radioBtnBgBlue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnBgBlue.Location = new System.Drawing.Point(13, 81);
            this.radioBtnBgBlue.Name = "radioBtnBgBlue";
            this.radioBtnBgBlue.Size = new System.Drawing.Size(53, 23);
            this.radioBtnBgBlue.TabIndex = 1;
            this.radioBtnBgBlue.TabStop = true;
            this.radioBtnBgBlue.Text = "Bleu";
            this.radioBtnBgBlue.UseVisualStyleBackColor = true;
            this.radioBtnBgBlue.CheckedChanged += new System.EventHandler(this.radioBtnBgBlue_CheckedChanged);
            // 
            // radioBtnBgRed
            // 
            this.radioBtnBgRed.AutoSize = true;
            this.radioBtnBgRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnBgRed.Location = new System.Drawing.Point(13, 24);
            this.radioBtnBgRed.Name = "radioBtnBgRed";
            this.radioBtnBgRed.Size = new System.Drawing.Size(66, 23);
            this.radioBtnBgRed.TabIndex = 0;
            this.radioBtnBgRed.TabStop = true;
            this.radioBtnBgRed.Text = "Rouge";
            this.radioBtnBgRed.UseVisualStyleBackColor = true;
            this.radioBtnBgRed.CheckedChanged += new System.EventHandler(this.radioBtnBgRed_CheckedChanged);
            // 
            // groupBoxChar
            // 
            this.groupBoxChar.Controls.Add(this.radioBtnCharWhite);
            this.groupBoxChar.Controls.Add(this.radioBtnCharRed);
            this.groupBoxChar.Controls.Add(this.radioBtnCharBlack);
            this.groupBoxChar.Location = new System.Drawing.Point(140, 184);
            this.groupBoxChar.Name = "groupBoxChar";
            this.groupBoxChar.Size = new System.Drawing.Size(106, 119);
            this.groupBoxChar.TabIndex = 7;
            this.groupBoxChar.TabStop = false;
            this.groupBoxChar.Text = "Charactères";
            // 
            // radioBtnCharWhite
            // 
            this.radioBtnCharWhite.AutoSize = true;
            this.radioBtnCharWhite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnCharWhite.Location = new System.Drawing.Point(15, 52);
            this.radioBtnCharWhite.Name = "radioBtnCharWhite";
            this.radioBtnCharWhite.Size = new System.Drawing.Size(59, 23);
            this.radioBtnCharWhite.TabIndex = 5;
            this.radioBtnCharWhite.TabStop = true;
            this.radioBtnCharWhite.Text = "Blanc";
            this.radioBtnCharWhite.UseVisualStyleBackColor = true;
            this.radioBtnCharWhite.CheckedChanged += new System.EventHandler(this.radioBtnCharWhite_CheckedChanged);
            // 
            // radioBtnCharRed
            // 
            this.radioBtnCharRed.AutoSize = true;
            this.radioBtnCharRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnCharRed.Location = new System.Drawing.Point(15, 24);
            this.radioBtnCharRed.Name = "radioBtnCharRed";
            this.radioBtnCharRed.Size = new System.Drawing.Size(66, 23);
            this.radioBtnCharRed.TabIndex = 3;
            this.radioBtnCharRed.TabStop = true;
            this.radioBtnCharRed.Text = "Rouge";
            this.radioBtnCharRed.UseVisualStyleBackColor = true;
            this.radioBtnCharRed.CheckedChanged += new System.EventHandler(this.radioBtnCharRed_CheckedChanged);
            // 
            // radioBtnCharBlack
            // 
            this.radioBtnCharBlack.AutoSize = true;
            this.radioBtnCharBlack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnCharBlack.Location = new System.Drawing.Point(15, 81);
            this.radioBtnCharBlack.Name = "radioBtnCharBlack";
            this.radioBtnCharBlack.Size = new System.Drawing.Size(53, 23);
            this.radioBtnCharBlack.TabIndex = 4;
            this.radioBtnCharBlack.TabStop = true;
            this.radioBtnCharBlack.Text = "Noir";
            this.radioBtnCharBlack.UseVisualStyleBackColor = true;
            this.radioBtnCharBlack.CheckedChanged += new System.EventHandler(this.radioBtnCharBlack_CheckedChanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioBtnUpperCase);
            this.groupBoxCasse.Controls.Add(this.radioBtnLowerCase);
            this.groupBoxCasse.Location = new System.Drawing.Point(252, 208);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(121, 95);
            this.groupBoxCasse.TabIndex = 7;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            // 
            // radioBtnUpperCase
            // 
            this.radioBtnUpperCase.AutoSize = true;
            this.radioBtnUpperCase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnUpperCase.Location = new System.Drawing.Point(17, 57);
            this.radioBtnUpperCase.Name = "radioBtnUpperCase";
            this.radioBtnUpperCase.Size = new System.Drawing.Size(94, 23);
            this.radioBtnUpperCase.TabIndex = 8;
            this.radioBtnUpperCase.TabStop = true;
            this.radioBtnUpperCase.Text = "Majuscules";
            this.radioBtnUpperCase.UseVisualStyleBackColor = true;
            this.radioBtnUpperCase.CheckedChanged += new System.EventHandler(this.radioBtnUpperCase_CheckedChanged);
            // 
            // radioBtnLowerCase
            // 
            this.radioBtnLowerCase.AutoSize = true;
            this.radioBtnLowerCase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnLowerCase.Location = new System.Drawing.Point(16, 28);
            this.radioBtnLowerCase.Name = "radioBtnLowerCase";
            this.radioBtnLowerCase.Size = new System.Drawing.Size(95, 23);
            this.radioBtnLowerCase.TabIndex = 6;
            this.radioBtnLowerCase.TabStop = true;
            this.radioBtnLowerCase.Text = "Minuscules";
            this.radioBtnLowerCase.UseVisualStyleBackColor = true;
            this.radioBtnLowerCase.CheckedChanged += new System.EventHandler(this.radioBtnLowerCase_CheckedChanged);
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Location = new System.Drawing.Point(30, 115);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(16, 15);
            this.labelTxt.TabIndex = 8;
            this.labelTxt.Text = "   ";
            // 
            // labelTxtEnter
            // 
            this.labelTxtEnter.AutoSize = true;
            this.labelTxtEnter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTxtEnter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTxtEnter.Location = new System.Drawing.Point(20, 93);
            this.labelTxtEnter.Name = "labelTxtEnter";
            this.labelTxtEnter.Size = new System.Drawing.Size(59, 37);
            this.labelTxtEnter.TabIndex = 0;
            this.labelTxtEnter.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 332);
            this.Controls.Add(this.labelTxtEnter);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.groupBoxChar);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxBg);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.labelUserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            this.groupBoxBg.ResumeLayout(false);
            this.groupBoxBg.PerformLayout();
            this.groupBoxChar.ResumeLayout(false);
            this.groupBoxChar.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelUserInput;
        private TextBox userInput;
        private GroupBox groupBoxChoice;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCharColor;
        private CheckBox checkBoxBgColor;
        private GroupBox groupBoxBg;
        private RadioButton radioBtnBgGreen;
        private RadioButton radioBtnBgBlue;
        private RadioButton radioBtnBgRed;
        private GroupBox groupBoxChar;
        private RadioButton radioBtnCharWhite;
        private RadioButton radioBtnCharRed;
        private RadioButton radioBtnCharBlack;
        private GroupBox groupBoxCasse;
        private RadioButton radioBtnUpperCase;
        private RadioButton radioBtnLowerCase;
        private Label labelTxt;
        private Label labelTxtEnter;
    }
}