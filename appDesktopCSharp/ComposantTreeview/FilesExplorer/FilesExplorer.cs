using FilesExplorer.Class;

namespace FilesExplorer
{
    public partial class FilesExplorer : Form
    {
        TreeNodeMaker nodes;

        public FilesExplorer()
        {
            InitializeComponent();
        }

        private void FilesExplorer_Load(object sender, EventArgs e)
        {
            nodes = new TreeNodeMaker(treeView);
        }

        private void btnHardDiskPath_Click(object sender, EventArgs e)
        {
            /*var dir = Directory.GetDirectories(path);
            var fs = Directory.GetFileSystemEntries(path);*/
            nodes.MakeNodes(txtBoxPath.Text);
            /*foreach (var item in Directory.EnumerateDirectories(path))
            {
                if(item is System.IO.Directory)
                {
                    string directory = (string)item;
                }
            }*/
            /*TreeMaker.MakeNode(txtBoxPath.Text);*/
        }
    }
}