using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemViewer
{
    public class FileSystem : Notifier {
        public Folder RootFolder { get; set; }

        public FileSystem() {
            RootFolder = new Folder { Name = "root" };
        }
    }

    public abstract class Entry : Notifier {
        private string _name = string.Empty;
        public string Name { 
            get { return _name; }
            set { _name = value; OnPropertyChanged(); } 
        }

        private DateTime _updated = DateTime.Now;
        public DateTime Updated { 
            get { return _updated; } 
            set { _updated = value; OnPropertyChanged(); } 
        }

        private string _lastUser = string.Empty;
        public string LastUser { 
            get { return _lastUser; }
            set { _lastUser = value; OnPropertyChanged(); } 
        }

        public override string ToString() {
            return Name;
        }
    }
    public class File : Entry {
        int _size = 0;
        public int Size {
            get { return _size; }
            set { _size = value; OnPropertyChanged(); }
        }

        public override string ToString() {
            return Name;
        }
    }

    public class Folder : Entry {
        public ObservableCollection<Entry> Children { get; } = new ObservableCollection<Entry>();
        public int Count {
            get {
                return Children.Count();
            }
        }

        public Entry Add(Entry entry) {
            //fire an event
            Children.Add(entry);
            return entry;
        }
        
        public override string ToString() {
            return Name;
        }
    }
}
