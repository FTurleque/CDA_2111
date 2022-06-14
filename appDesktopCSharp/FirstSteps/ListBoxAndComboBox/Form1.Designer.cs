namespace ListBoxAndComboBox
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
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.btnAddOneInTarget = new System.Windows.Forms.Button();
            this.btnAddAllInTarget = new System.Windows.Forms.Button();
            this.btnAddOneInSource = new System.Windows.Forms.Button();
            this.btnAddAllInSource = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 51);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(145, 23);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // listBoxTarget
            // 
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.ItemHeight = 15;
            this.listBoxTarget.Location = new System.Drawing.Point(222, 50);
            this.listBoxTarget.Name = "listBoxTarget";
            this.listBoxTarget.Size = new System.Drawing.Size(132, 169);
            this.listBoxTarget.TabIndex = 0;
            this.listBoxTarget.SelectedIndexChanged += new System.EventHandler(this.listBoxTarget_SelectedIndexChanged);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTarget.Location = new System.Drawing.Point(264, 16);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(45, 21);
            this.labelTarget.TabIndex = 1;
            this.labelTarget.Text = "Cible";
            // 
            // btnAddOneInTarget
            // 
            this.btnAddOneInTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOneInTarget.Location = new System.Drawing.Point(163, 50);
            this.btnAddOneInTarget.Name = "btnAddOneInTarget";
            this.btnAddOneInTarget.Size = new System.Drawing.Size(53, 23);
            this.btnAddOneInTarget.TabIndex = 3;
            this.btnAddOneInTarget.Text = ">";
            this.btnAddOneInTarget.UseVisualStyleBackColor = true;
            this.btnAddOneInTarget.Click += new System.EventHandler(this.btnAddOneInTarget_Click);
            // 
            // btnAddAllInTarget
            // 
            this.btnAddAllInTarget.Location = new System.Drawing.Point(163, 79);
            this.btnAddAllInTarget.Name = "btnAddAllInTarget";
            this.btnAddAllInTarget.Size = new System.Drawing.Size(53, 23);
            this.btnAddAllInTarget.TabIndex = 4;
            this.btnAddAllInTarget.Text = ">>";
            this.btnAddAllInTarget.UseVisualStyleBackColor = true;
            this.btnAddAllInTarget.Click += new System.EventHandler(this.btnAddAllInTarget_Click);
            // 
            // btnAddOneInSource
            // 
            this.btnAddOneInSource.Location = new System.Drawing.Point(163, 167);
            this.btnAddOneInSource.Name = "btnAddOneInSource";
            this.btnAddOneInSource.Size = new System.Drawing.Size(53, 23);
            this.btnAddOneInSource.TabIndex = 5;
            this.btnAddOneInSource.Text = "<";
            this.btnAddOneInSource.UseVisualStyleBackColor = true;
            this.btnAddOneInSource.Click += new System.EventHandler(this.btnAddOneInSource_Click);
            // 
            // btnAddAllInSource
            // 
            this.btnAddAllInSource.Location = new System.Drawing.Point(163, 196);
            this.btnAddAllInSource.Name = "btnAddAllInSource";
            this.btnAddAllInSource.Size = new System.Drawing.Size(53, 23);
            this.btnAddAllInSource.TabIndex = 6;
            this.btnAddAllInSource.Text = "<<";
            this.btnAddAllInSource.UseVisualStyleBackColor = true;
            this.btnAddAllInSource.Click += new System.EventHandler(this.btnAddAllInSource_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(292, 225);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(62, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Bas";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(222, 225);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(64, 23);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Haut";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSource.Location = new System.Drawing.Point(54, 17);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(58, 21);
            this.labelSource.TabIndex = 9;
            this.labelSource.Text = "Source";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 274);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnAddAllInSource);
            this.Controls.Add(this.btnAddOneInSource);
            this.Controls.Add(this.btnAddAllInTarget);
            this.Controls.Add(this.btnAddOneInTarget);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.listBoxTarget);
            this.Name = "Form1";
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTarget;
        private Label labelTarget;
        private ComboBox comboBoxSource;
        private Button btnAddOneInTarget;
        private Button btnAddAllInTarget;
        private Button btnAddOneInSource;
        private Button btnAddAllInSource;
        private Button btnDown;
        private Button btnUp;
        private Label labelSource;
    }
}