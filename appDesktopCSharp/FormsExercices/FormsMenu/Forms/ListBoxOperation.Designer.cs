namespace ListBoxOperation
{
    partial class ListBoxOperation
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
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.labelListBox = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNewElement = new System.Windows.Forms.TextBox();
            this.labelNewElement = new System.Windows.Forms.Label();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelPropreties = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSeletedIndex = new System.Windows.Forms.Label();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 15;
            this.listBoxElements.Location = new System.Drawing.Point(34, 144);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxElements.Size = new System.Drawing.Size(120, 109);
            this.listBoxElements.TabIndex = 0;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelListBox.Location = new System.Drawing.Point(34, 122);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(57, 19);
            this.labelListBox.TabIndex = 1;
            this.labelListBox.Text = "LstListe";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Ajout Liste";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNewElement
            // 
            this.textBoxNewElement.Location = new System.Drawing.Point(34, 35);
            this.textBoxNewElement.Name = "textBoxNewElement";
            this.textBoxNewElement.Size = new System.Drawing.Size(120, 23);
            this.textBoxNewElement.TabIndex = 3;
            // 
            // labelNewElement
            // 
            this.labelNewElement.AutoSize = true;
            this.labelNewElement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewElement.Location = new System.Drawing.Point(34, 13);
            this.labelNewElement.Name = "labelNewElement";
            this.labelNewElement.Size = new System.Drawing.Size(114, 19);
            this.labelNewElement.TabIndex = 4;
            this.labelNewElement.Text = "Nouvel Elément";
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(210, 35);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(48, 23);
            this.textBoxIndexElement.TabIndex = 5;
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIndexElement.Location = new System.Drawing.Point(210, 13);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(103, 19);
            this.labelIndexElement.TabIndex = 6;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(273, 35);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(116, 23);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "&Sélectioner";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(273, 64);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "&Vider la liste";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelPropreties
            // 
            this.labelPropreties.AutoSize = true;
            this.labelPropreties.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPropreties.Location = new System.Drawing.Point(210, 122);
            this.labelPropreties.Name = "labelPropreties";
            this.labelPropreties.Size = new System.Drawing.Size(79, 19);
            this.labelPropreties.TabIndex = 9;
            this.labelPropreties.Text = "Propriétés";
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCount.Enabled = false;
            this.textBoxCount.Location = new System.Drawing.Point(302, 144);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(36, 23);
            this.textBoxCount.TabIndex = 10;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(210, 147);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(72, 15);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Items.Count";
            // 
            // labelSeletedIndex
            // 
            this.labelSeletedIndex.AutoSize = true;
            this.labelSeletedIndex.Location = new System.Drawing.Point(210, 176);
            this.labelSeletedIndex.Name = "labelSeletedIndex";
            this.labelSeletedIndex.Size = new System.Drawing.Size(80, 15);
            this.labelSeletedIndex.TabIndex = 12;
            this.labelSeletedIndex.Text = "SelectedIndex";
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxSelectedIndex.Enabled = false;
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(302, 173);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(36, 23);
            this.textBoxSelectedIndex.TabIndex = 13;
            // 
            // textBoxText
            // 
            this.textBoxText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxText.Enabled = false;
            this.textBoxText.Location = new System.Drawing.Point(302, 202);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(100, 23);
            this.textBoxText.TabIndex = 14;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(210, 205);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 15);
            this.labelText.TabIndex = 15;
            this.labelText.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 289);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.labelSeletedIndex);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelPropreties);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.labelNewElement);
            this.Controls.Add(this.textBoxNewElement);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.listBoxElements);
            this.Name = "Form1";
            this.Text = "Les listes et leur propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxElements;
        private Label labelListBox;
        private Button buttonAdd;
        private TextBox textBoxNewElement;
        private Label labelNewElement;
        private TextBox textBoxIndexElement;
        private Label labelIndexElement;
        private Button buttonSelect;
        private Button buttonClear;
        private Label labelPropreties;
        private TextBox textBoxCount;
        private Label labelCount;
        private Label labelSeletedIndex;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxText;
        private Label labelText;
    }
}