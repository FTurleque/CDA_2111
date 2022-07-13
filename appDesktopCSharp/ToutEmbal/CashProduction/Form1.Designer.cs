﻿namespace CashProduction
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.prodControlA = new CashProduction.ProductionControl.ProductionControl();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.prodControlB = new CashProduction.ProductionControl.ProductionControl();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.prodControlC = new CashProduction.ProductionControl.ProductionControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.exitMenu.Size = new System.Drawing.Size(111, 22);
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
            this.progressBarProductionA.Location = new System.Drawing.Point(212, 268);
            this.progressBarProductionA.Name = "progressBarProductionA";
            this.progressBarProductionA.Size = new System.Drawing.Size(396, 23);
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
            this.progressBarProductionC.Location = new System.Drawing.Point(212, 326);
            this.progressBarProductionC.Name = "progressBarProductionC";
            this.progressBarProductionC.Size = new System.Drawing.Size(396, 23);
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
            this.progressBarProductionB.Location = new System.Drawing.Point(212, 297);
            this.progressBarProductionB.Name = "progressBarProductionB";
            this.progressBarProductionB.Size = new System.Drawing.Size(396, 23);
            this.progressBarProductionB.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 7;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageA);
            this.tabControl.Controls.Add(this.tabPageB);
            this.tabControl.Controls.Add(this.tabPageC);
            this.tabControl.Location = new System.Drawing.Point(212, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(396, 184);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.prodControlA);
            this.tabPageA.Location = new System.Drawing.Point(4, 24);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageA.Size = new System.Drawing.Size(388, 156);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "Type A";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // prodControlA
            // 
            this.prodControlA.Location = new System.Drawing.Point(5, 6);
            this.prodControlA.Name = "prodControlA";
            this.prodControlA.Size = new System.Drawing.Size(380, 143);
            this.prodControlA.TabIndex = 0;
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.prodControlB);
            this.tabPageB.Location = new System.Drawing.Point(4, 24);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageB.Size = new System.Drawing.Size(388, 156);
            this.tabPageB.TabIndex = 1;
            this.tabPageB.Text = "Type B";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // prodControlB
            // 
            this.prodControlB.Location = new System.Drawing.Point(5, 6);
            this.prodControlB.Name = "prodControlB";
            this.prodControlB.Size = new System.Drawing.Size(380, 143);
            this.prodControlB.TabIndex = 0;
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.prodControlC);
            this.tabPageC.Location = new System.Drawing.Point(4, 24);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageC.Size = new System.Drawing.Size(388, 156);
            this.tabPageC.TabIndex = 2;
            this.tabPageC.Text = "Type C";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // prodControlC
            // 
            this.prodControlC.Location = new System.Drawing.Point(5, 6);
            this.prodControlC.Name = "prodControlC";
            this.prodControlC.Size = new System.Drawing.Size(380, 143);
            this.prodControlC.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageB.ResumeLayout(false);
            this.tabPageC.ResumeLayout(false);
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
        private ProductionControl.ProductionControl prodControlA;
        private ProductionControl.ProductionControl prodControlB;
        private ProductionControl.ProductionControl prodControlC;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
    }
}