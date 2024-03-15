using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemViewer {
    public class FileSystemViewModel : Notifier {
        protected FileSystemService _fileSystemService;
        public ObservableCollection<Entry> Entries => _fileSystemService.FileSystem.RootFolder.Children;

        public FileSystemViewModel() {
            _fileSystemService = new FileSystemService();
            _fileSystemService.Load();
        }

        private void Folder_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e) {
        }

        public void Load() {
            _fileSystemService.Load();
        }

        public void AddFile(string name, int size, string lastUser) {
            _fileSystemService.AddFile(name, size, lastUser);
        }

        public void AddFolder(string name, string lastUser) {
            _fileSystemService.AddFolder(name, lastUser);
        }


    }
}
