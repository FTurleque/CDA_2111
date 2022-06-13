namespace DefilementComponents
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(81, 46);
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarRed.TabIndex = 0;
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(81, 121);
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarBlue.TabIndex = 1;
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(81, 84);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarGreen.TabIndex = 2;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRed.Location = new System.Drawing.Point(21, 49);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(48, 19);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Rouge";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(21, 128);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(30, 15);
            this.labelBlue.TabIndex = 4;
            this.labelBlue.Text = "Bleu";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGreen.Location = new System.Drawing.Point(21, 87);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(34, 19);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Vert";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(391, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(391, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(391, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 23);
            this.textBox3.TabIndex = 8;
            // 
            // numUpDownRed
            // 
            this.numUpDownRed.Location = new System.Drawing.Point(295, 45);
            this.numUpDownRed.Name = "numUpDownRed";
            this.numUpDownRed.Size = new System.Drawing.Size(77, 23);
            this.numUpDownRed.TabIndex = 9;
            // 
            // numUpDownBlue
            // 
            this.numUpDownBlue.Location = new System.Drawing.Point(295, 120);
            this.numUpDownBlue.Name = "numUpDownBlue";
            this.numUpDownBlue.Size = new System.Drawing.Size(77, 23);
            this.numUpDownBlue.TabIndex = 10;
            // 
            // numUpDownGreen
            // 
            this.numUpDownGreen.Location = new System.Drawing.Point(295, 83);
            this.numUpDownGreen.Name = "numUpDownGreen";
            this.numUpDownGreen.Size = new System.Drawing.Size(77, 23);
            this.numUpDownGreen.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 187);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(437, 123);
            this.textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 339);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.numUpDownGreen);
            this.Controls.Add(this.numUpDownBlue);
            this.Controls.Add(this.numUpDownRed);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarRed);
            this.Name = "Form1";
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarBlue;
        private HScrollBar hScrollBarGreen;
        private Label labelRed;
        private Label labelBlue;
        private Label labelGreen;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numUpDownRed;
        private NumericUpDown numUpDownBlue;
        private NumericUpDown numUpDownGreen;
        private TextBox textBox4;
    }
}