namespace FormsMenu
{
    partial class ScrollingElement
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
            this.numUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.labelColorResult = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarRed.Location = new System.Drawing.Point(81, 46);
            this.hScrollBarRed.Maximum = 264;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarRed_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarBlue.Location = new System.Drawing.Point(81, 121);
            this.hScrollBarBlue.Maximum = 264;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarBlue.TabIndex = 1;
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarGreen.Location = new System.Drawing.Point(81, 84);
            this.hScrollBarGreen.Maximum = 264;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(189, 22);
            this.hScrollBarGreen.TabIndex = 2;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRed.Location = new System.Drawing.Point(21, 49);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(48, 19);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Rouge";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.labelGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGreen.Location = new System.Drawing.Point(21, 87);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(34, 19);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Vert";
            // 
            // numUpDownRed
            // 
            this.numUpDownRed.Location = new System.Drawing.Point(295, 45);
            this.numUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownRed.Name = "numUpDownRed";
            this.numUpDownRed.Size = new System.Drawing.Size(77, 23);
            this.numUpDownRed.TabIndex = 9;
            // 
            // numUpDownBlue
            // 
            this.numUpDownBlue.Location = new System.Drawing.Point(295, 120);
            this.numUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownBlue.Name = "numUpDownBlue";
            this.numUpDownBlue.Size = new System.Drawing.Size(77, 23);
            this.numUpDownBlue.TabIndex = 10;
            // 
            // numUpDownGreen
            // 
            this.numUpDownGreen.Location = new System.Drawing.Point(295, 83);
            this.numUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownGreen.Name = "numUpDownGreen";
            this.numUpDownGreen.Size = new System.Drawing.Size(77, 23);
            this.numUpDownGreen.TabIndex = 11;
            // 
            // labelColorResult
            // 
            this.labelColorResult.AutoSize = true;
            this.labelColorResult.BackColor = System.Drawing.Color.Black;
            this.labelColorResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelColorResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelColorResult.Location = new System.Drawing.Point(12, 185);
            this.labelColorResult.MinimumSize = new System.Drawing.Size(460, 140);
            this.labelColorResult.Name = "labelColorResult";
            this.labelColorResult.Size = new System.Drawing.Size(460, 140);
            this.labelColorResult.TabIndex = 12;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Transparent;
            this.lblRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRed.Location = new System.Drawing.Point(391, 45);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(63, 23);
            this.lblRed.TabIndex = 13;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Transparent;
            this.lblGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGreen.Location = new System.Drawing.Point(391, 83);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(63, 23);
            this.lblGreen.TabIndex = 14;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Transparent;
            this.lblBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBlue.Location = new System.Drawing.Point(391, 120);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(63, 23);
            this.lblBlue.TabIndex = 15;
            // 
            // ScrollingElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 339);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.labelColorResult);
            this.Controls.Add(this.numUpDownGreen);
            this.Controls.Add(this.numUpDownBlue);
            this.Controls.Add(this.numUpDownRed);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ScrollingElement";
            this.Text = "Defilement";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private NumericUpDown numUpDownRed;
        private NumericUpDown numUpDownBlue;
        private NumericUpDown numUpDownGreen;
        private Label labelColorResult;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
    }
}