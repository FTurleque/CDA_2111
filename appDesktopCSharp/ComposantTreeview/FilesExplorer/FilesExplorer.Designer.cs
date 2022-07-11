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
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnHardDiskPath = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnPathSelected = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(162, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chemin du dossier à examiner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(290, 54);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(343, 23);
            this.txtBoxPath.TabIndex = 11;
            this.txtBoxPath.Text = "C:\\Users\\fturl\\OneDrive - CENTRE DE READAPTATION\\Documents\\CDA\\cmder";
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(154, 570);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(100, 61);
            this.btnExpand.TabIndex = 10;
            this.btnExpand.Text = "&Expansion de l\'arbre";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(534, 570);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(99, 61);
            this.btnCollapse.TabIndex = 9;
            this.btnCollapse.Text = "&Reduction de l\'arbre";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnHardDiskPath
            // 
            this.btnHardDiskPath.Location = new System.Drawing.Point(56, 21);
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
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.png");
            this.imageList.Images.SetKeyName(1, "file.png");
            this.imageList.Images.SetKeyName(2, "folder-open-empty.png");
            this.imageList.Images.SetKeyName(3, "folder-open.png");
            this.imageList.Images.SetKeyName(4, "fichier-exe.png");
            this.imageList.Images.SetKeyName(5, "fichier-avi.png");
            this.imageList.Images.SetKeyName(6, "fichier-css.png");
            this.imageList.Images.SetKeyName(7, "fichier-doc.png");
            this.imageList.Images.SetKeyName(8, "fichier-docx.png");
            this.imageList.Images.SetKeyName(9, "fichier-gif.png");
            this.imageList.Images.SetKeyName(10, "fichier-html.png");
            this.imageList.Images.SetKeyName(11, "fichier-iso.png");
            this.imageList.Images.SetKeyName(12, "fichier-jpg.png");
            this.imageList.Images.SetKeyName(13, "fichier-js.png");
            this.imageList.Images.SetKeyName(14, "fichier-mkv.png");
            this.imageList.Images.SetKeyName(15, "fichier-mp3.png");
            this.imageList.Images.SetKeyName(16, "fichier-mp4.png");
            this.imageList.Images.SetKeyName(17, "fichier-mpg.png");
            this.imageList.Images.SetKeyName(18, "fichier-pdf.png");
            this.imageList.Images.SetKeyName(19, "fichier-php.png");
            this.imageList.Images.SetKeyName(20, "fichier-png.png");
            this.imageList.Images.SetKeyName(21, "fichier-ppt.png");
            this.imageList.Images.SetKeyName(22, "fichier-rar.png");
            this.imageList.Images.SetKeyName(23, "fichier-svg.png");
            this.imageList.Images.SetKeyName(24, "fichier-txt.png");
            this.imageList.Images.SetKeyName(25, "fichier-zip.png");
            // 
            // btnPathSelected
            // 
            this.btnPathSelected.Location = new System.Drawing.Point(639, 21);
            this.btnPathSelected.Name = "btnPathSelected";
            this.btnPathSelected.Size = new System.Drawing.Size(106, 76);
            this.btnPathSelected.TabIndex = 13;
            this.btnPathSelected.Text = "&Sélection du chemin";
            this.btnPathSelected.UseVisualStyleBackColor = true;
            this.btnPathSelected.Click += new System.EventHandler(this.btnPathSelected_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FilesExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPathSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnCollapse);
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
        private Button btnExpand;
        private Button btnCollapse;
        private Button btnHardDiskPath;
        private TreeView treeView;
        private ImageList imageList;
        private Button btnPathSelected;
        private StatusStrip statusStrip1;
    }
}