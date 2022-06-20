namespace FormsMenu
{
    public partial class FrmMenu : Form
    {
        private Adder frmAdder;
        private Borrowing frmBorrowing;
        private CheckBoxRadioBtn frmCheckBoxRadioBtn;
        private InputValidator frmInputValidator;
        private ListBoxAndComboBox frmListBoxAndComboBox;
        private ListBoxOperation frmListBoxOperation;
        private ScrollingElement frmScrollingElement;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            phase1ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Enabled = false;
            toolStripStatusDate.Text = DateTime.Now.ToString("d");
        }

        private void OnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            switch (menu.Name)
            {
                case "loginMenuItem":
                    MessageBox.Show("Bonjour, bienvenue dans notre sélection ne formulaires.", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    phase1ToolStripMenuItem.Enabled = true;
                    phase2ToolStripMenuItem.Enabled = true;
                    phase3ToolStripMenuItem.Enabled = true;
                    break;
                case "exitMenuItem":
                    Environment.Exit(0);
                    break;
                case "adderMenuItem":
                    frmAdder = new Adder();
                    ShowForm(frmAdder);
                    break;
                case "inputControlMenuItem":
                    frmInputValidator = new InputValidator();
                    ShowForm(frmInputValidator);
                    break;
                case "checkBoxAndRadioButtonMenuItem":
                    frmCheckBoxRadioBtn = new CheckBoxRadioBtn();
                    ShowForm(frmCheckBoxRadioBtn);
                    break;
                case "listBoxMenuItem":
                    frmListBoxOperation = new ListBoxOperation();
                    ShowForm(frmListBoxOperation);
                    break;
                case "comboBoxMenuItem":
                    frmListBoxAndComboBox = new ListBoxAndComboBox();
                    ShowForm(frmListBoxAndComboBox);
                    break;
                case "scrollingMenuItem":
                    frmScrollingElement = new ScrollingElement();
                    ShowForm(frmScrollingElement);
                    break;
                case "borrowingMenuItem":
                    frmBorrowing = new Borrowing();
                    ShowForm(frmBorrowing);
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

        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

    }
}