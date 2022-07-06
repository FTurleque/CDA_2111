namespace TreeView
{
    public partial class FilesExplorer : Form
    {
        public FilesExplorer()
        {
            InitializeComponent();
        }

        private void txtBoxPath_Validated(object sender, EventArgs e)
        {
            var result = Directory.EnumerateFileSystemEntries(@"C:\Users\CRM\Documents\Microsoft Office Professional Plus 2013 VL Edition x86 x64 FR");
            // var r = Directory.EnumerateFiles(@"C:\Users\CRM\Documents\Microsoft Office Professional Plus 2013 VL Edition x86 x64 FR");
        }
    }
}