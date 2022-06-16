namespace TakeALoan
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLoan = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLoan = new System.Windows.Forms.Label();
            this.groupBoxInterestRates = new System.Windows.Forms.GroupBox();
            this.radioBtn9 = new System.Windows.Forms.RadioButton();
            this.radioBtn8 = new System.Windows.Forms.RadioButton();
            this.radioBtnPercent = new System.Windows.Forms.RadioButton();
            this.hScrollBarMonth = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.listBoxPeriods = new System.Windows.Forms.ListBox();
            this.labelRepaymentPeriod = new System.Windows.Forms.Label();
            this.labelRefundNumber = new System.Windows.Forms.Label();
            this.labelRefund = new System.Windows.Forms.Label();
            this.labelResultLoan = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxInterestRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxLoan
            // 
            this.textBoxLoan.Location = new System.Drawing.Point(152, 68);
            this.textBoxLoan.MaxLength = 10;
            this.textBoxLoan.Name = "textBoxLoan";
            this.textBoxLoan.Size = new System.Drawing.Size(131, 23);
            this.textBoxLoan.TabIndex = 1;
            this.textBoxLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(23, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nom";
            // 
            // labelLoan
            // 
            this.labelLoan.AutoSize = true;
            this.labelLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoan.Location = new System.Drawing.Point(23, 72);
            this.labelLoan.Name = "labelLoan";
            this.labelLoan.Size = new System.Drawing.Size(115, 19);
            this.labelLoan.TabIndex = 3;
            this.labelLoan.Text = "Capital Emprunté";
            // 
            // groupBoxInterestRates
            // 
            this.groupBoxInterestRates.Controls.Add(this.radioBtn9);
            this.groupBoxInterestRates.Controls.Add(this.radioBtn8);
            this.groupBoxInterestRates.Controls.Add(this.radioBtnPercent);
            this.groupBoxInterestRates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxInterestRates.Location = new System.Drawing.Point(417, 29);
            this.groupBoxInterestRates.Name = "groupBoxInterestRates";
            this.groupBoxInterestRates.Size = new System.Drawing.Size(94, 153);
            this.groupBoxInterestRates.TabIndex = 4;
            this.groupBoxInterestRates.TabStop = false;
            this.groupBoxInterestRates.Text = "Taux d\'intérêt";
            // 
            // radioBtn9
            // 
            this.radioBtn9.AutoSize = true;
            this.radioBtn9.Location = new System.Drawing.Point(20, 104);
            this.radioBtn9.Name = "radioBtn9";
            this.radioBtn9.Size = new System.Drawing.Size(44, 19);
            this.radioBtn9.TabIndex = 2;
            this.radioBtn9.Text = "9 %";
            this.radioBtn9.UseVisualStyleBackColor = true;
            this.radioBtn9.CheckedChanged += new System.EventHandler(this.RadioBtnPercent_CheckedChanged);
            // 
            // radioBtn8
            // 
            this.radioBtn8.AutoSize = true;
            this.radioBtn8.Location = new System.Drawing.Point(20, 68);
            this.radioBtn8.Name = "radioBtn8";
            this.radioBtn8.Size = new System.Drawing.Size(44, 19);
            this.radioBtn8.TabIndex = 1;
            this.radioBtn8.Text = "8 %";
            this.radioBtn8.UseVisualStyleBackColor = true;
            this.radioBtn8.CheckedChanged += new System.EventHandler(this.RadioBtnPercent_CheckedChanged);
            // 
            // radioBtnPercent
            // 
            this.radioBtnPercent.AutoSize = true;
            this.radioBtnPercent.Location = new System.Drawing.Point(20, 33);
            this.radioBtnPercent.Name = "radioBtnPercent";
            this.radioBtnPercent.Size = new System.Drawing.Size(44, 19);
            this.radioBtnPercent.TabIndex = 0;
            this.radioBtnPercent.Text = "7 %";
            this.radioBtnPercent.UseVisualStyleBackColor = true;
            this.radioBtnPercent.CheckedChanged += new System.EventHandler(this.RadioBtnPercent_CheckedChanged);
            // 
            // hScrollBarMonth
            // 
            this.hScrollBarMonth.Location = new System.Drawing.Point(174, 133);
            this.hScrollBarMonth.Maximum = 360;
            this.hScrollBarMonth.Minimum = 1;
            this.hScrollBarMonth.Name = "hScrollBarMonth";
            this.hScrollBarMonth.Size = new System.Drawing.Size(224, 17);
            this.hScrollBarMonth.TabIndex = 5;
            this.hScrollBarMonth.Value = 1;
            this.hScrollBarMonth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarMonth_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Durée en mois du remboursement";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(144, 135);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(0, 15);
            this.labelMonth.TabIndex = 7;
            // 
            // listBoxPeriods
            // 
            this.listBoxPeriods.FormattingEnabled = true;
            this.listBoxPeriods.ItemHeight = 15;
            this.listBoxPeriods.Items.AddRange(new object[] {
            "Mensuel",
            "Bimestriel",
            "Trimestriel",
            "Semestriel",
            "Annuel"});
            this.listBoxPeriods.Location = new System.Drawing.Point(23, 218);
            this.listBoxPeriods.Name = "listBoxPeriods";
            this.listBoxPeriods.Size = new System.Drawing.Size(260, 79);
            this.listBoxPeriods.TabIndex = 8;
            this.listBoxPeriods.SelectedIndexChanged += new System.EventHandler(this.ListBoxPeriods_SelectedIndexChanged);
            // 
            // labelRepaymentPeriod
            // 
            this.labelRepaymentPeriod.AutoSize = true;
            this.labelRepaymentPeriod.Location = new System.Drawing.Point(23, 200);
            this.labelRepaymentPeriod.Name = "labelRepaymentPeriod";
            this.labelRepaymentPeriod.Size = new System.Drawing.Size(167, 15);
            this.labelRepaymentPeriod.TabIndex = 9;
            this.labelRepaymentPeriod.Text = "Périodicité de remboursement";
            // 
            // labelRefundNumber
            // 
            this.labelRefundNumber.AutoSize = true;
            this.labelRefundNumber.ForeColor = System.Drawing.Color.Red;
            this.labelRefundNumber.Location = new System.Drawing.Point(379, 225);
            this.labelRefundNumber.Name = "labelRefundNumber";
            this.labelRefundNumber.Size = new System.Drawing.Size(0, 15);
            this.labelRefundNumber.TabIndex = 10;
            // 
            // labelRefund
            // 
            this.labelRefund.AutoSize = true;
            this.labelRefund.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRefund.Location = new System.Drawing.Point(417, 220);
            this.labelRefund.Name = "labelRefund";
            this.labelRefund.Size = new System.Drawing.Size(143, 21);
            this.labelRefund.TabIndex = 11;
            this.labelRefund.Text = "Remboursements";
            // 
            // labelResultLoan
            // 
            this.labelResultLoan.AutoSize = true;
            this.labelResultLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultLoan.ForeColor = System.Drawing.Color.Red;
            this.labelResultLoan.Location = new System.Drawing.Point(437, 263);
            this.labelResultLoan.Name = "labelResultLoan";
            this.labelResultLoan.Size = new System.Drawing.Size(0, 19);
            this.labelResultLoan.TabIndex = 12;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(540, 29);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 323);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelResultLoan);
            this.Controls.Add(this.labelRefund);
            this.Controls.Add(this.labelRefundNumber);
            this.Controls.Add(this.labelRepaymentPeriod);
            this.Controls.Add(this.listBoxPeriods);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBarMonth);
            this.Controls.Add(this.groupBoxInterestRates);
            this.Controls.Add(this.labelLoan);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxLoan);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Emprunts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInterestRates.ResumeLayout(false);
            this.groupBoxInterestRates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxLoan;
        private Label labelName;
        private Label labelLoan;
        private GroupBox groupBoxInterestRates;
        private RadioButton radioBtn9;
        private RadioButton radioBtn8;
        private RadioButton radioBtnPercent;
        private HScrollBar hScrollBarMonth;
        private Label label3;
        private Label labelMonth;
        private ListBox listBoxPeriods;
        private Label labelRepaymentPeriod;
        private Label labelRefundNumber;
        private Label labelRefund;
        private Label labelResultLoan;
        private Button btnOk;
        private Button btnCancel;
    }
}