namespace TreeView
{
    partial class FilesExplorer
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnHardDiskPath = new System.Windows.Forms.Button();
            this.btnReduceTree = new System.Windows.Forms.Button();
            this.btnExpansionTree = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(65, 110);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(689, 434);
            this.treeView.TabIndex = 0;
            // 
            // btnHardDiskPath
            // 
            this.btnHardDiskPath.Location = new System.Drawing.Point(163, 12);
            this.btnHardDiskPath.Name = "btnHardDiskPath";
            this.btnHardDiskPath.Size = new System.Drawing.Size(100, 76);
            this.btnHardDiskPath.TabIndex = 1;
            this.btnHardDiskPath.Text = "&Affichage du disque dur";
            this.btnHardDiskPath.UseVisualStyleBackColor = true;
            // 
            // btnReduceTree
            // 
            this.btnReduceTree.Location = new System.Drawing.Point(543, 560);
            this.btnReduceTree.Name = "btnReduceTree";
            this.btnReduceTree.Size = new System.Drawing.Size(99, 61);
            this.btnReduceTree.TabIndex = 2;
            this.btnReduceTree.Text = "&Reduction de l\'arbre";
            this.btnReduceTree.UseVisualStyleBackColor = true;
            // 
            // btnExpansionTree
            // 
            this.btnExpansionTree.Location = new System.Drawing.Point(163, 560);
            this.btnExpansionTree.Name = "btnExpansionTree";
            this.btnExpansionTree.Size = new System.Drawing.Size(100, 61);
            this.btnExpansionTree.TabIndex = 3;
            this.btnExpansionTree.Text = "&Expansion de l\'arbre";
            this.btnExpansionTree.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(414, 44);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(233, 23);
            this.txtBoxPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(287, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chemin du dossier à examiner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExpansionTree);
            this.Controls.Add(this.btnReduceTree);
            this.Controls.Add(this.btnHardDiskPath);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Vous avez sélectionné :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private Button btnHardDiskPath;
        private Button btnReduceTree;
        private Button btnExpansionTree;
        private StatusStrip statusStrip1;
        private TextBox txtBoxPath;
        private Label label1;
    }
}