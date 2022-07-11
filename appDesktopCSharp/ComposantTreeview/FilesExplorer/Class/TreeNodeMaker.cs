using System.Security.Permissions;

namespace FilesExplorer.Class
{
    internal static class TreeNodeMaker
    {
        private static EnumerationOptions directoryOptions = new EnumerationOptions {
            IgnoreInaccessible = true
        };

        public static void MakeNode(DirectoryInfo _dir, TreeNode _parent)
        {
            // var files = Directory.GetDirectories(_dir.FullName, "*", directoryOptions);
            // DirectoryInfo[] subDirs = _dir.GetDirectories(_dir.FullName, directoryOptions);
            DirectoryInfo[] subDirs = _dir.GetDirectories();
            if (subDirs.Length > 0 && subDirs != null)
            {
                foreach (DirectoryInfo subDir in subDirs)
                {
                    TreeNode children = new TreeNode(subDir.Name, 0, 1);
                    children.ImageIndex = 0;
                    children.SelectedImageIndex = 2;
                    children.Name = subDir.Name;
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
                    nodeFile.ImageIndex = DisplayFileIcon(subFile);
                    nodeFile.SelectedImageIndex = DisplayFileIcon(subFile);
                    nodeFile.Name = subFile.Name;
                    _parent.Nodes.Add(nodeFile);
                }
            }
        }

        private static int DisplayFileIcon(FileInfo subFile)
        {
            switch (subFile.Extension)
            {
                case ".exe":
                    return 4;
                case ".avi":
                    return 5;
                case ".css":
                    return 6;
                case ".doc":
                    return 7;
                case ".docx":
                    return 8;
                case ".gif":
                    return 9;
                case ".html":
                    return 10;
                case ".iso":
                    return 11;
                case ".jpg":
                    return 12;
                case ".js":
                    return 13;
                case ".mkv":
                    return 14;
                case ".mp3":
                    return 15;
                case ".mp4":
                    return 16;
                case ".mpg":
                    return 17;
                case ".pdf":
                    return 18;
                case ".php":
                    return 19;
                case ".png":
                    return 20;
                case ".ppt":
                    return 21;
                case ".rar":
                    return 22;
                case ".svg":
                    return 23;
                case ".txt":
                    return 24;
                case ".zip":
                    return 25;
                default:
                    return 1;
            }
        }
    }
}
