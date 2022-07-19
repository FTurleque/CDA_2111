namespace BoxProduction
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StopCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.txtBoxGlobalDefectRateA = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRateHourA = new System.Windows.Forms.TextBox();
            this.txtBoxNbA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxGlobalDefectRateB = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRateHourB = new System.Windows.Forms.TextBox();
            this.txtBoxNbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.txtBoxGlobalDefectRateC = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRateHourC = new System.Windows.Forms.TextBox();
            this.txtBoxNbC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProdA = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.lblProdC = new System.Windows.Forms.Label();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.lblProdB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageB.SuspendLayout();
            this.tabPageC.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.productionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 20);
            this.fileMenu.Text = "&Fichier";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(111, 22);
            this.exitMenu.Text = "&Quitter";
            // 
            // productionMenu
            // 
            this.productionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu,
            this.stopMenu,
            this.continueMenu});
            this.productionMenu.Name = "productionMenu";
            this.productionMenu.Size = new System.Drawing.Size(78, 20);
            this.productionMenu.Text = "&Production";
            // 
            // startMenu
            // 
            this.startMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAMenu,
            this.startBMenu,
            this.startCMenu});
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(127, 22);
            this.startMenu.Text = "&Démarer";
            // 
            // startAMenu
            // 
            this.startAMenu.Name = "startAMenu";
            this.startAMenu.Size = new System.Drawing.Size(82, 22);
            this.startAMenu.Text = "A";
            // 
            // startBMenu
            // 
            this.startBMenu.Name = "startBMenu";
            this.startBMenu.Size = new System.Drawing.Size(82, 22);
            this.startBMenu.Text = "B";
            // 
            // startCMenu
            // 
            this.startCMenu.Name = "startCMenu";
            this.startCMenu.Size = new System.Drawing.Size(82, 22);
            this.startCMenu.Text = "C";
            // 
            // stopMenu
            // 
            this.stopMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopAMenu,
            this.stopBMenu,
            this.StopCMenu});
            this.stopMenu.Name = "stopMenu";
            this.stopMenu.Size = new System.Drawing.Size(127, 22);
            this.stopMenu.Text = "&Arrêter";
            // 
            // stopAMenu
            // 
            this.stopAMenu.Name = "stopAMenu";
            this.stopAMenu.Size = new System.Drawing.Size(82, 22);
            this.stopAMenu.Text = "A";
            // 
            // stopBMenu
            // 
            this.stopBMenu.Name = "stopBMenu";
            this.stopBMenu.Size = new System.Drawing.Size(82, 22);
            this.stopBMenu.Text = "B";
            // 
            // StopCMenu
            // 
            this.StopCMenu.Name = "StopCMenu";
            this.StopCMenu.Size = new System.Drawing.Size(82, 22);
            this.StopCMenu.Text = "C";
            // 
            // continueMenu
            // 
            this.continueMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continueAMenu,
            this.continueBMenu,
            this.continueCMenu});
            this.continueMenu.Name = "continueMenu";
            this.continueMenu.Size = new System.Drawing.Size(127, 22);
            this.continueMenu.Text = "&Continuer";
            // 
            // continueAMenu
            // 
            this.continueAMenu.Name = "continueAMenu";
            this.continueAMenu.Size = new System.Drawing.Size(82, 22);
            this.continueAMenu.Text = "A";
            // 
            // continueBMenu
            // 
            this.continueBMenu.Name = "continueBMenu";
            this.continueBMenu.Size = new System.Drawing.Size(82, 22);
            this.continueBMenu.Text = "B";
            // 
            // continueCMenu
            // 
            this.continueCMenu.Name = "continueCMenu";
            this.continueCMenu.Size = new System.Drawing.Size(82, 22);
            this.continueCMenu.Text = "C";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Caisse A :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel2.Text = "Caise B :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel3.Text = "Caisses C";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel4.Text = "Time";
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.txtBoxGlobalDefectRateA);
            this.tabPageA.Controls.Add(this.txtBoxDefectRateHourA);
            this.tabPageA.Controls.Add(this.txtBoxNbA);
            this.tabPageA.Controls.Add(this.label7);
            this.tabPageA.Controls.Add(this.label8);
            this.tabPageA.Controls.Add(this.label9);
            this.tabPageA.Location = new System.Drawing.Point(4, 24);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageA.Size = new System.Drawing.Size(450, 177);
            this.tabPageA.TabIndex = 1;
            this.tabPageA.Text = "Type A";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageA);
            this.tabControl.Controls.Add(this.tabPageB);
            this.tabControl.Controls.Add(this.tabPageC);
            this.tabControl.Location = new System.Drawing.Point(214, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(458, 205);
            this.tabControl.TabIndex = 9;
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.txtBoxGlobalDefectRateB);
            this.tabPageB.Controls.Add(this.txtBoxDefectRateHourB);
            this.tabPageB.Controls.Add(this.txtBoxNbB);
            this.tabPageB.Controls.Add(this.label1);
            this.tabPageB.Controls.Add(this.label2);
            this.tabPageB.Controls.Add(this.label3);
            this.tabPageB.Location = new System.Drawing.Point(4, 24);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageB.Size = new System.Drawing.Size(450, 177);
            this.tabPageB.TabIndex = 2;
            this.tabPageB.Text = "Type B";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // txtBoxGlobalDefectRateA
            // 
            this.txtBoxGlobalDefectRateA.Location = new System.Drawing.Point(300, 118);
            this.txtBoxGlobalDefectRateA.Name = "txtBoxGlobalDefectRateA";
            this.txtBoxGlobalDefectRateA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateA.TabIndex = 23;
            // 
            // txtBoxDefectRateHourA
            // 
            this.txtBoxDefectRateHourA.Location = new System.Drawing.Point(300, 76);
            this.txtBoxDefectRateHourA.Name = "txtBoxDefectRateHourA";
            this.txtBoxDefectRateHourA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRateHourA.TabIndex = 22;
            // 
            // txtBoxNbA
            // 
            this.txtBoxNbA.Location = new System.Drawing.Point(300, 35);
            this.txtBoxNbA.Name = "txtBoxNbA";
            this.txtBoxNbA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNbA.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Taux défaut depuis démarrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Taux défaut heure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre de caisses depuis le démarrage";
            // 
            // txtBoxGlobalDefectRateB
            // 
            this.txtBoxGlobalDefectRateB.Location = new System.Drawing.Point(300, 118);
            this.txtBoxGlobalDefectRateB.Name = "txtBoxGlobalDefectRateB";
            this.txtBoxGlobalDefectRateB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateB.TabIndex = 23;
            // 
            // txtBoxDefectRateHourB
            // 
            this.txtBoxDefectRateHourB.Location = new System.Drawing.Point(300, 76);
            this.txtBoxDefectRateHourB.Name = "txtBoxDefectRateHourB";
            this.txtBoxDefectRateHourB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRateHourB.TabIndex = 22;
            // 
            // txtBoxNbB
            // 
            this.txtBoxNbB.Location = new System.Drawing.Point(300, 35);
            this.txtBoxNbB.Name = "txtBoxNbB";
            this.txtBoxNbB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNbB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Taux défaut depuis démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Taux défaut heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.txtBoxGlobalDefectRateC);
            this.tabPageC.Controls.Add(this.txtBoxDefectRateHourC);
            this.tabPageC.Controls.Add(this.txtBoxNbC);
            this.tabPageC.Controls.Add(this.label4);
            this.tabPageC.Controls.Add(this.label5);
            this.tabPageC.Controls.Add(this.label6);
            this.tabPageC.Location = new System.Drawing.Point(4, 24);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageC.Size = new System.Drawing.Size(450, 177);
            this.tabPageC.TabIndex = 3;
            this.tabPageC.Text = "Type C";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // txtBoxGlobalDefectRateC
            // 
            this.txtBoxGlobalDefectRateC.Location = new System.Drawing.Point(300, 118);
            this.txtBoxGlobalDefectRateC.Name = "txtBoxGlobalDefectRateC";
            this.txtBoxGlobalDefectRateC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateC.TabIndex = 23;
            // 
            // txtBoxDefectRateHourC
            // 
            this.txtBoxDefectRateHourC.Location = new System.Drawing.Point(300, 76);
            this.txtBoxDefectRateHourC.Name = "txtBoxDefectRateHourC";
            this.txtBoxDefectRateHourC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRateHourC.TabIndex = 22;
            // 
            // txtBoxNbC
            // 
            this.txtBoxNbC.Location = new System.Drawing.Point(300, 35);
            this.txtBoxNbC.Name = "txtBoxNbC";
            this.txtBoxNbC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNbC.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Taux défaut depuis démarrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Taux défaut heure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre de caisses depuis le démarrage";
            // 
            // lblProdA
            // 
            this.lblProdA.AutoSize = true;
            this.lblProdA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdA.Location = new System.Drawing.Point(40, 277);
            this.lblProdA.Name = "lblProdA";
            this.lblProdA.Size = new System.Drawing.Size(122, 25);
            this.lblProdA.TabIndex = 10;
            this.lblProdA.Text = "Production A";
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(218, 279);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(450, 23);
            this.progressBarA.TabIndex = 11;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(218, 359);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(450, 23);
            this.progressBarC.TabIndex = 13;
            // 
            // lblProdC
            // 
            this.lblProdC.AutoSize = true;
            this.lblProdC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdC.Location = new System.Drawing.Point(40, 357);
            this.lblProdC.Name = "lblProdC";
            this.lblProdC.Size = new System.Drawing.Size(122, 25);
            this.lblProdC.TabIndex = 12;
            this.lblProdC.Text = "Production C";
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(218, 318);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(450, 23);
            this.progressBarB.TabIndex = 15;
            // 
            // lblProdB
            // 
            this.lblProdB.AutoSize = true;
            this.lblProdB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdB.Location = new System.Drawing.Point(40, 316);
            this.lblProdB.Name = "lblProdB";
            this.lblProdB.Size = new System.Drawing.Size(121, 25);
            this.lblProdB.TabIndex = 14;
            this.lblProdB.Text = "Production B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 432);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.lblProdB);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.lblProdC);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.lblProdA);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "ToutEmbal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageA.ResumeLayout(false);
            this.tabPageA.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageB.ResumeLayout(false);
            this.tabPageB.PerformLayout();
            this.tabPageC.ResumeLayout(false);
            this.tabPageC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem productionMenu;
        private ToolStripMenuItem startMenu;
        private ToolStripMenuItem startAMenu;
        private ToolStripMenuItem startBMenu;
        private ToolStripMenuItem startCMenu;
        private ToolStripMenuItem stopMenu;
        private ToolStripMenuItem stopAMenu;
        private ToolStripMenuItem stopBMenu;
        private ToolStripMenuItem StopCMenu;
        private ToolStripMenuItem continueMenu;
        private ToolStripMenuItem continueAMenu;
        private ToolStripMenuItem continueBMenu;
        private ToolStripMenuItem continueCMenu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private TabPage tabPageA;
        private TextBox txtBoxGlobalDefectRateA;
        private TextBox txtBoxDefectRateHourA;
        private TextBox txtBoxNbA;
        private Label label7;
        private Label label8;
        private Label label9;
        private TabControl tabControl;
        private TabPage tabPageB;
        private TextBox txtBoxGlobalDefectRateB;
        private TextBox txtBoxDefectRateHourB;
        private TextBox txtBoxNbB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabPage tabPageC;
        private TextBox txtBoxGlobalDefectRateC;
        private TextBox txtBoxDefectRateHourC;
        private TextBox txtBoxNbC;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblProdA;
        private ProgressBar progressBarA;
        private ProgressBar progressBarC;
        private Label lblProdC;
        private ProgressBar progressBarB;
        private Label lblProdB;
    }
}