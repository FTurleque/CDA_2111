using FormsMenu.Interfaces;
using FormsMenu.Lib;

namespace FormsMenu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            adderMenuItem.Tag = new FormBuilder<Adder>();
            inputControlMenuItem.Tag = new FormBuilder<InputValidator>();
            checkBoxAndRadioButtonMenuItem.Tag = new FormBuilder<CheckBoxRadioBtn>();
            listBoxMenuItem.Tag = new FormBuilder<ListBoxOperation>();
            comboBoxMenuItem.Tag = new FormBuilder<ListBoxAndComboBox>();
            scrollingMenuItem.Tag = new FormBuilder<ScrollingElement>();
            borrowingMenuItem.Tag = new FormBuilder<Borrowing>();
            toolStripStatusDate.Text = DateTime.Now.ToString("d");
        }

        private void OnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            if (menu.Tag is IFormBuilder formBuilder)
            {
                formBuilder.CreateInstance(this).Show();
            }
            switch (menu.Name)
            {
                case "cascadeToolStripMenuItem":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "horizontalToolStripMenuItem":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "verticalToolStripMenuItem":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
                default:
                    break;
            }
        }

        private void LoginMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour, bienvenue dans notre sélection ne formulaires.", "Bienvenue",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            windowToolStripMenuItem.Enabled = true;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez vous quitter l'application ?", "Quiter",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}