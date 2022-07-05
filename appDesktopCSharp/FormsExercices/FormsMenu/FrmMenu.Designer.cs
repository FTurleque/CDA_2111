namespace FormsMenu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputControlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxAndRadioButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.borrowingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLastWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitPhases = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem,
            this.toolStripSeparator3,
            this.exitMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.loginToolStripMenuItem.Text = "Connexion";
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loginMenuItem.Text = "&Identification";
            this.loginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitMenuItem.Text = "&Quitter";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adderMenuItem});
            this.phase1ToolStripMenuItem.Enabled = false;
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // adderMenuItem
            // 
            this.adderMenuItem.Name = "adderMenuItem";
            this.adderMenuItem.Size = new System.Drawing.Size(153, 22);
            this.adderMenuItem.Text = "L\'&Additionneur";
            this.adderMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputControlMenuItem});
            this.phase2ToolStripMenuItem.Enabled = false;
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // inputControlMenuItem
            // 
            this.inputControlMenuItem.Name = "inputControlMenuItem";
            this.inputControlMenuItem.Size = new System.Drawing.Size(172, 22);
            this.inputControlMenuItem.Text = "Contrôles de &saisie";
            this.inputControlMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxAndRadioButtonMenuItem,
            this.listBoxMenuItem,
            this.comboBoxMenuItem,
            this.scrollingMenuItem,
            this.toolStripSeparator5,
            this.borrowingMenuItem});
            this.phase3ToolStripMenuItem.Enabled = false;
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // checkBoxAndRadioButtonMenuItem
            // 
            this.checkBoxAndRadioButtonMenuItem.Name = "checkBoxAndRadioButtonMenuItem";
            this.checkBoxAndRadioButtonMenuItem.Size = new System.Drawing.Size(217, 22);
            this.checkBoxAndRadioButtonMenuItem.Text = "CheckBox et &RadioBoutons";
            this.checkBoxAndRadioButtonMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // listBoxMenuItem
            // 
            this.listBoxMenuItem.Name = "listBoxMenuItem";
            this.listBoxMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listBoxMenuItem.Text = "&ListBox";
            this.listBoxMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // comboBoxMenuItem
            // 
            this.comboBoxMenuItem.Name = "comboBoxMenuItem";
            this.comboBoxMenuItem.Size = new System.Drawing.Size(217, 22);
            this.comboBoxMenuItem.Text = "Combo&Box";
            this.comboBoxMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // scrollingMenuItem
            // 
            this.scrollingMenuItem.Name = "scrollingMenuItem";
            this.scrollingMenuItem.Size = new System.Drawing.Size(217, 22);
            this.scrollingMenuItem.Text = "&Défilement";
            this.scrollingMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // borrowingMenuItem
            // 
            this.borrowingMenuItem.Name = "borrowingMenuItem";
            this.borrowingMenuItem.Size = new System.Drawing.Size(217, 22);
            this.borrowingMenuItem.Text = "S&ynthèse";
            this.borrowingMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator4});
            this.windowToolStripMenuItem.Enabled = false;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "&Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "&Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(126, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDate,
            this.lblTime,
            this.lblLastWindow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusDate
            // 
            this.toolStripStatusDate.Name = "toolStripStatusDate";
            this.toolStripStatusDate.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 17);
            this.lblTime.Text = "Time";
            // 
            // lblLastWindow
            // 
            this.lblLastWindow.Name = "lblLastWindow";
            this.lblLastWindow.Size = new System.Drawing.Size(59, 17);
            this.lblLastWindow.Text = "Last Form";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLogin,
            this.toolStripSeparator1,
            this.toolStripSplitPhases,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnLogin
            // 
            this.toolStripBtnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLogin.Image")));
            this.toolStripBtnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLogin.Name = "toolStripBtnLogin";
            this.toolStripBtnLogin.Size = new System.Drawing.Size(67, 22);
            this.toolStripBtnLogin.Text = "S\'identifier";
            this.toolStripBtnLogin.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitPhases
            // 
            this.toolStripSplitPhases.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitPhases.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitPhases.Image")));
            this.toolStripSplitPhases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitPhases.Name = "toolStripSplitPhases";
            this.toolStripSplitPhases.Size = new System.Drawing.Size(59, 22);
            this.toolStripSplitPhases.Text = "Phases";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.Text = "Créer des formulaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnLogin;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitPhases;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem loginMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem adderMenuItem;
        private ToolStripMenuItem inputControlMenuItem;
        private ToolStripMenuItem checkBoxAndRadioButtonMenuItem;
        private ToolStripMenuItem listBoxMenuItem;
        private ToolStripMenuItem comboBoxMenuItem;
        private ToolStripMenuItem scrollingMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem borrowingMenuItem;
        private ToolStripStatusLabel toolStripStatusDate;
        private ToolStripStatusLabel lblLastWindow;
        private ToolStripStatusLabel lblTime;
    }
}