namespace FilesExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesExplorer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnExpansionTree = new System.Windows.Forms.Button();
            this.btnReduceTree = new System.Windows.Forms.Button();
            this.btnHardDiskPath = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(278, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chemin du dossier à examiner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(405, 54);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(233, 23);
            this.txtBoxPath.TabIndex = 11;
            this.txtBoxPath.Text = "C:\\Users\\CRM\\Documents\\algoboxwin64usb\\algoboxwin64usb";
            // 
            // btnExpansionTree
            // 
            this.btnExpansionTree.Location = new System.Drawing.Point(154, 570);
            this.btnExpansionTree.Name = "btnExpansionTree";
            this.btnExpansionTree.Size = new System.Drawing.Size(100, 61);
            this.btnExpansionTree.TabIndex = 10;
            this.btnExpansionTree.Text = "&Expansion de l\'arbre";
            this.btnExpansionTree.UseVisualStyleBackColor = true;
            // 
            // btnReduceTree
            // 
            this.btnReduceTree.Location = new System.Drawing.Point(534, 570);
            this.btnReduceTree.Name = "btnReduceTree";
            this.btnReduceTree.Size = new System.Drawing.Size(99, 61);
            this.btnReduceTree.TabIndex = 9;
            this.btnReduceTree.Text = "&Reduction de l\'arbre";
            this.btnReduceTree.UseVisualStyleBackColor = true;
            // 
            // btnHardDiskPath
            // 
            this.btnHardDiskPath.Location = new System.Drawing.Point(154, 22);
            this.btnHardDiskPath.Name = "btnHardDiskPath";
            this.btnHardDiskPath.Size = new System.Drawing.Size(100, 76);
            this.btnHardDiskPath.TabIndex = 8;
            this.btnHardDiskPath.Text = "&Affichage du disque dur";
            this.btnHardDiskPath.UseVisualStyleBackColor = true;
            this.btnHardDiskPath.Click += new System.EventHandler(this.btnHardDiskPath_Click);
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(56, 120);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(689, 434);
            this.treeView.TabIndex = 7;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pngegg.png");
            this.imageList.Images.SetKeyName(1, "kisspng-computer-icons-document-file-format-apple-icon-ima-social-media-content-v" +
        "ideo-package-gingerbeard-m-5b634cb280a200.3736848915332343545269.png");
            // 
            // FilesExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.btnExpansionTree);
            this.Controls.Add(this.btnReduceTree);
            this.Controls.Add(this.btnHardDiskPath);
            this.Controls.Add(this.treeView);
            this.Name = "FilesExplorer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxPath;
        private Button btnExpansionTree;
        private Button btnReduceTree;
        private Button btnHardDiskPath;
        private TreeView treeView;
        private ImageList imageList;
    }
}