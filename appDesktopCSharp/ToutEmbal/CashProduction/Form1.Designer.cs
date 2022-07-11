namespace CashProduction
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
            this.progressBarProductionA = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarProductionC = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarProductionB = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.txtBoxGlobalDefectRateA = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRatePerHourA = new System.Windows.Forms.TextBox();
            this.txtBoxCashRegistersNbA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.txtBoxGlobalDefectRateB = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRatePerHourB = new System.Windows.Forms.TextBox();
            this.txtBoxCashRegistersNbB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.txtBoxGlobalDefectRateC = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRatePerHourC = new System.Windows.Forms.TextBox();
            this.txtBoxCashRegistersNbC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageA.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "&Quitter";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
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
            // progressBarProductionA
            // 
            this.progressBarProductionA.Location = new System.Drawing.Point(239, 268);
            this.progressBarProductionA.Name = "progressBarProductionA";
            this.progressBarProductionA.Size = new System.Drawing.Size(369, 23);
            this.progressBarProductionA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Production A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Production C";
            // 
            // progressBarProductionC
            // 
            this.progressBarProductionC.Location = new System.Drawing.Point(239, 326);
            this.progressBarProductionC.Name = "progressBarProductionC";
            this.progressBarProductionC.Size = new System.Drawing.Size(369, 23);
            this.progressBarProductionC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production B";
            // 
            // progressBarProductionB
            // 
            this.progressBarProductionB.Location = new System.Drawing.Point(239, 297);
            this.progressBarProductionB.Name = "progressBarProductionB";
            this.progressBarProductionB.Size = new System.Drawing.Size(369, 23);
            this.progressBarProductionB.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageA);
            this.tabControl.Controls.Add(this.tabPageB);
            this.tabControl.Controls.Add(this.tabPageC);
            this.tabControl.Location = new System.Drawing.Point(239, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(369, 168);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.txtBoxGlobalDefectRateA);
            this.tabPageA.Controls.Add(this.txtBoxDefectRatePerHourA);
            this.tabPageA.Controls.Add(this.txtBoxCashRegistersNbA);
            this.tabPageA.Controls.Add(this.label6);
            this.tabPageA.Controls.Add(this.label5);
            this.tabPageA.Controls.Add(this.label4);
            this.tabPageA.Location = new System.Drawing.Point(4, 24);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageA.Size = new System.Drawing.Size(361, 140);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "Type A";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // txtBoxGlobalDefectRateA
            // 
            this.txtBoxGlobalDefectRateA.Location = new System.Drawing.Point(255, 100);
            this.txtBoxGlobalDefectRateA.Name = "txtBoxGlobalDefectRateA";
            this.txtBoxGlobalDefectRateA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateA.TabIndex = 5;
            // 
            // txtBoxDefectRatePerHourA
            // 
            this.txtBoxDefectRatePerHourA.Location = new System.Drawing.Point(255, 58);
            this.txtBoxDefectRatePerHourA.Name = "txtBoxDefectRatePerHourA";
            this.txtBoxDefectRatePerHourA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRatePerHourA.TabIndex = 4;
            // 
            // txtBoxCashRegistersNbA
            // 
            this.txtBoxCashRegistersNbA.Location = new System.Drawing.Point(255, 17);
            this.txtBoxCashRegistersNbA.Name = "txtBoxCashRegistersNbA";
            this.txtBoxCashRegistersNbA.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCashRegistersNbA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Taux défaut depuis démarrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Taux défaut heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.txtBoxGlobalDefectRateB);
            this.tabPageB.Controls.Add(this.txtBoxDefectRatePerHourB);
            this.tabPageB.Controls.Add(this.txtBoxCashRegistersNbB);
            this.tabPageB.Controls.Add(this.label7);
            this.tabPageB.Controls.Add(this.label8);
            this.tabPageB.Controls.Add(this.label9);
            this.tabPageB.Location = new System.Drawing.Point(4, 24);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageB.Size = new System.Drawing.Size(361, 140);
            this.tabPageB.TabIndex = 1;
            this.tabPageB.Text = "Type B";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // txtBoxGlobalDefectRateB
            // 
            this.txtBoxGlobalDefectRateB.Location = new System.Drawing.Point(255, 100);
            this.txtBoxGlobalDefectRateB.Name = "txtBoxGlobalDefectRateB";
            this.txtBoxGlobalDefectRateB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateB.TabIndex = 11;
            // 
            // txtBoxDefectRatePerHourB
            // 
            this.txtBoxDefectRatePerHourB.Location = new System.Drawing.Point(255, 58);
            this.txtBoxDefectRatePerHourB.Name = "txtBoxDefectRatePerHourB";
            this.txtBoxDefectRatePerHourB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRatePerHourB.TabIndex = 10;
            // 
            // txtBoxCashRegistersNbB
            // 
            this.txtBoxCashRegistersNbB.Location = new System.Drawing.Point(255, 17);
            this.txtBoxCashRegistersNbB.Name = "txtBoxCashRegistersNbB";
            this.txtBoxCashRegistersNbB.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCashRegistersNbB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Taux défaut depuis démarrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Taux défaut heure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.txtBoxGlobalDefectRateC);
            this.tabPageC.Controls.Add(this.txtBoxDefectRatePerHourC);
            this.tabPageC.Controls.Add(this.txtBoxCashRegistersNbC);
            this.tabPageC.Controls.Add(this.label10);
            this.tabPageC.Controls.Add(this.label11);
            this.tabPageC.Controls.Add(this.label12);
            this.tabPageC.Location = new System.Drawing.Point(4, 24);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageC.Size = new System.Drawing.Size(361, 140);
            this.tabPageC.TabIndex = 2;
            this.tabPageC.Text = "Type C";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // txtBoxGlobalDefectRateC
            // 
            this.txtBoxGlobalDefectRateC.Location = new System.Drawing.Point(255, 100);
            this.txtBoxGlobalDefectRateC.Name = "txtBoxGlobalDefectRateC";
            this.txtBoxGlobalDefectRateC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRateC.TabIndex = 11;
            // 
            // txtBoxDefectRatePerHourC
            // 
            this.txtBoxDefectRatePerHourC.Location = new System.Drawing.Point(255, 58);
            this.txtBoxDefectRatePerHourC.Name = "txtBoxDefectRatePerHourC";
            this.txtBoxDefectRatePerHourC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRatePerHourC.TabIndex = 10;
            // 
            // txtBoxCashRegistersNbC
            // 
            this.txtBoxCashRegistersNbC.Location = new System.Drawing.Point(255, 17);
            this.txtBoxCashRegistersNbC.Name = "txtBoxCashRegistersNbC";
            this.txtBoxCashRegistersNbC.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCashRegistersNbC.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Taux défaut depuis démarrage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Taux défaut heure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nombre de caisses depuis le démarrage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarProductionB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarProductionC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarProductionA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageA.PerformLayout();
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
        private ToolStripMenuItem productionMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem startMenu;
        private ToolStripMenuItem stopMenu;
        private ToolStripMenuItem continueMenu;
        private ToolStripMenuItem startAMenu;
        private ToolStripMenuItem startBMenu;
        private ToolStripMenuItem startCMenu;
        private ToolStripMenuItem stopAMenu;
        private ToolStripMenuItem stopBMenu;
        private ToolStripMenuItem StopCMenu;
        private ToolStripMenuItem continueAMenu;
        private ToolStripMenuItem continueBMenu;
        private ToolStripMenuItem continueCMenu;
        private ProgressBar progressBarProductionA;
        private Label label1;
        private Label label2;
        private ProgressBar progressBarProductionC;
        private Label label3;
        private ProgressBar progressBarProductionB;
        private StatusStrip statusStrip1;
        private TabControl tabControl;
        private TabPage tabPageA;
        private TabPage tabPageB;
        private TabPage tabPageC;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox txtBoxGlobalDefectRateA;
        private TextBox txtBoxDefectRatePerHourA;
        private TextBox txtBoxCashRegistersNbA;
        private TextBox txtBoxGlobalDefectRateB;
        private TextBox txtBoxDefectRatePerHourB;
        private TextBox txtBoxCashRegistersNbB;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxGlobalDefectRateC;
        private TextBox txtBoxDefectRatePerHourC;
        private TextBox txtBoxCashRegistersNbC;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}