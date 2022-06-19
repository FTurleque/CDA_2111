namespace FormsMenu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private Adder frmAdder;
        private Borrowing frmBorrowing;
        private CheckBoxRadioBtn frmCheckBoxRadioBtn;
        private InputValidator frmInputValidator;
        private ListBoxAndComboBox frmListBoxAndComboBox;
        private ListBoxOperation frmListBoxOperation;
        private ScrollingElement frmScrollingElement;

        private void OnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            switch (menu.Name)
            {
                case "loginMenuItem":
                    MessageBox.Show("Bonjour, bienvenue dans notre sélection ne formulaires.", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "exitMenuItem":
                    Environment.Exit(0);
                    break;
                case "adderMenuItem":
                    frmAdder = new Adder();
                    frmAdder.MdiParent = this;
                    frmAdder.Show();
                    break;
                case "inputControlMenuItem":
                    frmInputValidator = new InputValidator();
                    frmInputValidator.MdiParent = this;
                    frmInputValidator.Show();
                    break;
                case "checkBoxAndRadioButtonMenuItem":
                    frmCheckBoxRadioBtn = new CheckBoxRadioBtn();
                    frmCheckBoxRadioBtn.MdiParent = this;
                    frmCheckBoxRadioBtn.Show();
                    break;
                case "listBoxMenuItem":
                    frmListBoxOperation = new ListBoxOperation();
                    frmListBoxOperation.MdiParent = this;
                    frmListBoxOperation.Show();
                    break;
                case "comboBoxMenuItem":
                    frmListBoxAndComboBox = new ListBoxAndComboBox();
                    frmListBoxAndComboBox.MdiParent = this;
                    frmListBoxAndComboBox.Show();
                    break;
                case "scrollingMenuItem":
                    frmScrollingElement = new ScrollingElement();
                    frmScrollingElement.MdiParent = this;
                    frmScrollingElement.Show();
                    break;
                case "borrowingMenuItem":
                    frmBorrowing = new Borrowing();
                    frmBorrowing.MdiParent = this;
                    frmBorrowing.Show();
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