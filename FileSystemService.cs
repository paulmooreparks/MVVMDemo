using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemViewer {
    public class FileSystemService {
        public FileSystem FileSystem { get; set; }

        public FileSystemService() {
            FileSystem = new FileSystem();
        }

        public void Load() {
            FileSystem.RootFolder.Children.Add(new File { Name = "file1", Size = 100, LastUser = "user1" });
            FileSystem.RootFolder.Children.Add(new File { Name = "file2", Size = 200, LastUser = "user2" });
            FileSystem.RootFolder.Children.Add(new Folder { Name = "folder1", LastUser = "user3" });
            FileSystem.RootFolder.Children.Add(new Folder { Name = "folder2", LastUser = "user4" });
        }

        public void AddFile(string name, int size, string lastUser) {
            var file = new File { Name = name, Size = size, LastUser = lastUser };
            FileSystem.RootFolder.Children.Add(file);
        }

        public void AddFolder(string name, string lastUser) {
            var folder = new Folder { Name = name, LastUser = lastUser };
            FileSystem.RootFolder.Children.Add(folder);
        }
    }
}
