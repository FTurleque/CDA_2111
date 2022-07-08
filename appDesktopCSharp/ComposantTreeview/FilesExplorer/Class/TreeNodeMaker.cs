namespace FilesExplorer.Class
{
    internal static class TreeNodeMaker
    {
        public static void MakeNode(DirectoryInfo _dir, TreeNode _parent)
        {
            DirectoryInfo[] subDirs = _dir.GetDirectories();
            if (subDirs.Length > 0 && subDirs != null)
            {
                foreach (DirectoryInfo subDir in subDirs)
                {
                    TreeNode children = new TreeNode(subDir.Name, 0, 1);
                    _parent.Nodes.Add(children);
                    AddFiles(subDir, children);
                    MakeNode(subDir, children);
                }
            }
            AddFiles(_dir, _parent);
        }

        private static void AddFiles(DirectoryInfo _dir, TreeNode _parent)
        {
            FileInfo[] subFiles = _dir.GetFiles();
            if (subFiles.Length > 0 && subFiles != null)
            {
                foreach (FileInfo subFile in subFiles)
                {
                    TreeNode nodeFile = new TreeNode(subFile.Name, 0, 1);
                    _parent.Nodes.Add(nodeFile);
                }
            }
        }
    }
}
