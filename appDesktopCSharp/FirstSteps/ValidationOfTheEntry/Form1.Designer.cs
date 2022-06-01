namespace ValidationOfTheEntry
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
            this.components = new System.ComponentModel.Container();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.amout = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dateSize = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(271, 157);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(131, 51);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 23);
            this.txtNom.TabIndex = 2;
            this.txtNom.Validated += new System.EventHandler(this.txtNom_Validated);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(131, 138);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(79, 23);
            this.txtCP.TabIndex = 3;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(131, 109);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(121, 23);
            this.txtMontant.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(131, 80);
            this.txtDate.MaxLength = 10;
            this.txtDate.Name = "txtDate";
            this.txtDate.PlaceholderText = "JJ/MM/AAAA";
            this.txtDate.Size = new System.Drawing.Size(121, 23);
            this.txtDate.TabIndex = 5;
            this.txtDate.Validated += new System.EventHandler(this.txtDate_Validated);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(41, 88);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(31, 15);
            this.date.TabIndex = 13;
            this.date.Text = "Date";
            // 
            // amout
            // 
            this.amout.AutoSize = true;
            this.amout.Location = new System.Drawing.Point(41, 117);
            this.amout.Name = "amout";
            this.amout.Size = new System.Drawing.Size(53, 15);
            this.amout.TabIndex = 12;
            this.amout.Text = "Montant";
            // 
            // postalCode
            // 
            this.postalCode.AutoSize = true;
            this.postalCode.Location = new System.Drawing.Point(41, 146);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(70, 15);
            this.postalCode.TabIndex = 11;
            this.postalCode.Text = "Code Postal";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 15);
            this.name.TabIndex = 10;
            this.name.Text = "Nom";
            // 
            // dateSize
            // 
            this.dateSize.AutoSize = true;
            this.dateSize.Location = new System.Drawing.Point(271, 83);
            this.dateSize.Name = "dateSize";
            this.dateSize.Size = new System.Drawing.Size(87, 15);
            this.dateSize.TabIndex = 14;
            this.dateSize.Text = "(JJ/MM/AAAA)";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 248);
            this.Controls.Add(this.dateSize);
            this.Controls.Add(this.date);
            this.Controls.Add(this.amout);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnValidate;
        private Button btnDelete;
        private TextBox txtNom;
        private TextBox txtCP;
        private TextBox txtMontant;
        private TextBox txtDate;
        private Label date;
        private Label amout;
        private Label postalCode;
        private Label name;
        private Label dateSize;
        private ErrorProvider errorProvider;
    }
}