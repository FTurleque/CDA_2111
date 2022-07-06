using System.IO;
using FilesExplorer.Class;

namespace FilesExplorer
{
    public partial class FilesExplorer : Form
    {
        /*private TreeMaker treeMaker;*/

        public FilesExplorer()
        {
            InitializeComponent();
        }

        private void FilesExplorer_Load(object sender, EventArgs e)
        {
            /*treeMaker = new TreeMaker(treeView);*/
        }

        private void btnHardDiskPath_Click(object sender, EventArgs e)
        {
            string path = txtBoxPath.Text;
            var dir = Directory.GetDirectories(path);
            var fs = Directory.GetFileSystemEntries(path);
            TreeMaker.MakeNode(path);
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