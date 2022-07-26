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
            this.components = new System.ComponentModel.Container();
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
            this.statusBoxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.prodControlA = new CashProduction.ProductionControl.productionControl();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.prodControlB = new CashProduction.ProductionControl.productionControl();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.prodControlC = new CashProduction.ProductionControl.productionControl();
            this.progressBarControlA = new CashProduction.UserControls.ProgressBarControl();
            this.progressBarControlC = new CashProduction.UserControls.ProgressBarControl();
            this.progressBarControlB = new CashProduction.UserControls.ProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartA = new System.Windows.Forms.Button();
            this.btnStopA = new System.Windows.Forms.Button();
            this.btnStandByA = new System.Windows.Forms.Button();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxC = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.tabPageB.SuspendLayout();
            this.tabPageC.SuspendLayout();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.groupBoxC.SuspendLayout();
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
            this.startAMenu.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // startBMenu
            // 
            this.startBMenu.Name = "startBMenu";
            this.startBMenu.Size = new System.Drawing.Size(82, 22);
            this.startBMenu.Text = "B";
            this.startBMenu.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // startCMenu
            // 
            this.startCMenu.Name = "startCMenu";
            this.startCMenu.Size = new System.Drawing.Size(82, 22);
            this.startCMenu.Text = "C";
            this.startCMenu.Click += new System.EventHandler(this.StartProd_Click);
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
            this.stopAMenu.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // stopBMenu
            // 
            this.stopBMenu.Name = "stopBMenu";
            this.stopBMenu.Size = new System.Drawing.Size(82, 22);
            this.stopBMenu.Text = "B";
            this.stopBMenu.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // StopCMenu
            // 
            this.StopCMenu.Name = "StopCMenu";
            this.StopCMenu.Size = new System.Drawing.Size(82, 22);
            this.StopCMenu.Text = "C";
            this.StopCMenu.Click += new System.EventHandler(this.StopProd_Click);
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
            this.continueAMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // continueBMenu
            // 
            this.continueBMenu.Name = "continueBMenu";
            this.continueBMenu.Size = new System.Drawing.Size(82, 22);
            this.continueBMenu.Text = "B";
            this.continueBMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // continueCMenu
            // 
            this.continueCMenu.Name = "continueCMenu";
            this.continueCMenu.Size = new System.Drawing.Size(82, 22);
            this.continueCMenu.Text = "C";
            this.continueCMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBoxA,
            this.boxA,
            this.statusBoxB,
            this.boxB,
            this.statusBoxC,
            this.boxC,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBoxA
            // 
            this.statusBoxA.Name = "statusBoxA";
            this.statusBoxA.Size = new System.Drawing.Size(57, 17);
            this.statusBoxA.Text = "Caisse A :";
            // 
            // boxA
            // 
            this.boxA.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBoxB
            // 
            this.statusBoxB.Name = "statusBoxB";
            this.statusBoxB.Size = new System.Drawing.Size(51, 17);
            this.statusBoxB.Text = "Caise B :";
            // 
            // boxB
            // 
            this.boxB.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBoxC
            // 
            this.statusBoxC.Name = "statusBoxC";
            this.statusBoxC.Size = new System.Drawing.Size(62, 17);
            this.statusBoxC.Text = "Caisses C :";
            // 
            // boxC
            // 
            this.boxC.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(0, 17);
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(33, 17);
            this.statusTime.Text = "Time";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageA);
            this.tabControl.Controls.Add(this.tabPageB);
            this.tabControl.Controls.Add(this.tabPageC);
            this.tabControl.Location = new System.Drawing.Point(212, 142);
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
            // progressBarControlA
            // 
            this.progressBarControlA.Location = new System.Drawing.Point(17, 332);
            this.progressBarControlA.Name = "progressBarControlA";
            this.progressBarControlA.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlA.TabIndex = 9;
            // 
            // progressBarControlC
            // 
            this.progressBarControlC.Location = new System.Drawing.Point(17, 411);
            this.progressBarControlC.Name = "progressBarControlC";
            this.progressBarControlC.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlC.TabIndex = 10;
            // 
            // progressBarControlB
            // 
            this.progressBarControlB.Location = new System.Drawing.Point(17, 370);
            this.progressBarControlB.Name = "progressBarControlB";
            this.progressBarControlB.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlB.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartA
            // 
            this.btnStartA.BackgroundImage = global::CashProduction.Properties.Resources.Green;
            this.btnStartA.Location = new System.Drawing.Point(7, 22);
            this.btnStartA.Name = "btnStartA";
            this.btnStartA.Size = new System.Drawing.Size(33, 66);
            this.btnStartA.TabIndex = 12;
            this.btnStartA.UseVisualStyleBackColor = true;
            this.btnStartA.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // btnStopA
            // 
            this.btnStopA.BackgroundImage = global::CashProduction.Properties.Resources.Red;
            this.btnStopA.Enabled = false;
            this.btnStopA.Location = new System.Drawing.Point(85, 22);
            this.btnStopA.Name = "btnStopA";
            this.btnStopA.Size = new System.Drawing.Size(32, 66);
            this.btnStopA.TabIndex = 13;
            this.btnStopA.UseVisualStyleBackColor = true;
            this.btnStopA.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // btnStandByA
            // 
            this.btnStandByA.BackgroundImage = global::CashProduction.Properties.Resources.Orange;
            this.btnStandByA.Enabled = false;
            this.btnStandByA.Location = new System.Drawing.Point(46, 22);
            this.btnStandByA.Name = "btnStandByA";
            this.btnStandByA.Size = new System.Drawing.Size(33, 66);
            this.btnStandByA.TabIndex = 14;
            this.btnStandByA.UseVisualStyleBackColor = true;
            this.btnStandByA.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.btnStandByA);
            this.groupBoxA.Controls.Add(this.btnStartA);
            this.groupBoxA.Controls.Add(this.btnStopA);
            this.groupBoxA.Location = new System.Drawing.Point(33, 27);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(125, 96);
            this.groupBoxA.TabIndex = 24;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Production A";
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.button1);
            this.groupBoxB.Controls.Add(this.button2);
            this.groupBoxB.Controls.Add(this.button3);
            this.groupBoxB.Location = new System.Drawing.Point(256, 27);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(125, 96);
            this.groupBoxB.TabIndex = 25;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Production B";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CashProduction.Properties.Resources.Orange;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(46, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 66);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CashProduction.Properties.Resources.Green;
            this.button2.Location = new System.Drawing.Point(7, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 66);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CashProduction.Properties.Resources.Red;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(85, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 66);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // groupBoxC
            // 
            this.groupBoxC.Controls.Add(this.button4);
            this.groupBoxC.Controls.Add(this.button5);
            this.groupBoxC.Controls.Add(this.button6);
            this.groupBoxC.Location = new System.Drawing.Point(479, 27);
            this.groupBoxC.Name = "groupBoxC";
            this.groupBoxC.Size = new System.Drawing.Size(125, 96);
            this.groupBoxC.TabIndex = 25;
            this.groupBoxC.TabStop = false;
            this.groupBoxC.Text = "Production C";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CashProduction.Properties.Resources.Orange;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(46, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 66);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CashProduction.Properties.Resources.Green;
            this.button5.Location = new System.Drawing.Point(7, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 66);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::CashProduction.Properties.Resources.Red;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(85, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 66);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 502);
            this.Controls.Add(this.groupBoxC);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.progressBarControlB);
            this.Controls.Add(this.progressBarControlC);
            this.Controls.Add(this.progressBarControlA);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Production de boites";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageB.ResumeLayout(false);
            this.tabPageC.ResumeLayout(false);
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxC.ResumeLayout(false);
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
        private StatusStrip statusStrip1;
        private TabControl tabControl;
        private TabPage tabPageA;
        private TabPage tabPageB;
        private TabPage tabPageC;
        private ProductionControl.productionControl prodControlA;
        private ProductionControl.productionControl prodControlB;
        private ProductionControl.productionControl prodControlC;
        private ToolStripStatusLabel statusBoxA;
        private ToolStripStatusLabel statusBoxB;
        private ToolStripStatusLabel statusBoxC;
        private ToolStripStatusLabel statusTime;
        private UserControls.ProgressBarControl progressBarControlA;
        private UserControls.ProgressBarControl progressBarControlC;
        private UserControls.ProgressBarControl progressBarControlB;
        private ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel boxA;
        private ToolStripStatusLabel boxB;
        private ToolStripStatusLabel boxC;
        private Button btnStartA;
        private Button btnStopA;
        private Button btnStandByA;
        private GroupBox groupBoxA;
        private GroupBox groupBoxB;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBoxC;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}