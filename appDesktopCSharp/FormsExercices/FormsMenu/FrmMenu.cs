using FormsMenu.Lib;

namespace FormsMenu
{
    public partial class FrmMenu : Form
    {
        private FormBuilder<Adder> frmAdder;
        private FormBuilder<Borrowing> frmBorrowing;
        private FormBuilder<CheckBoxRadioBtn> frmCheckBoxRadioBtn;
        private FormBuilder<InputValidator> frmInputValidator;
        private FormBuilder<ListBoxAndComboBox> frmListBoxAndComboBox;
        private FormBuilder<ListBoxOperation> frmListBoxOperation;
        private FormBuilder<ScrollingElement> frmScrollingElement;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            frmAdder = new();
            frmBorrowing = new();
            frmCheckBoxRadioBtn = new();
            frmInputValidator = new();
            frmListBoxAndComboBox = new();
            frmListBoxOperation = new();
            frmScrollingElement = new();

            phase1ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Enabled = false;
            windowToolStripMenuItem.Enabled = false;
            toolStripStatusDate.Text = DateTime.Now.ToString("d");
        }

        private void OnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            switch (menu.Name)
            {
                case "loginMenuItem":
                case "toolStripBtnLogin":
                    MessageBox.Show("Bonjour, bienvenue dans notre sélection ne formulaires.", "Bienvenue", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    phase1ToolStripMenuItem.Enabled = true;
                    phase2ToolStripMenuItem.Enabled = true;
                    phase3ToolStripMenuItem.Enabled = true;
                    windowToolStripMenuItem.Enabled = true;
                    break;
                case "exitMenuItem":
                    var result = MessageBox.Show("Voulez vous quitter l'application ?", "Quiter",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;
                case "adderMenuItem":
                    frmAdder.CreateInstance(this).Show();
                    break;
                case "inputControlMenuItem":
                    frmInputValidator.CreateInstance(this).Show();
                    break;
                case "checkBoxAndRadioButtonMenuItem":
                    frmCheckBoxRadioBtn.CreateInstance(this).Show();
                    break;
                case "listBoxMenuItem":
                    frmListBoxOperation.CreateInstance(this).Show();
                    break;
                case "comboBoxMenuItem":
                    frmListBoxAndComboBox.CreateInstance(this).Show();
                    break;
                case "scrollingMenuItem":
                    frmScrollingElement.CreateInstance(this).Show();
                    break;
                case "borrowingMenuItem":
                    frmBorrowing.CreateInstance(this).Show();
                    break;
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
    }
}