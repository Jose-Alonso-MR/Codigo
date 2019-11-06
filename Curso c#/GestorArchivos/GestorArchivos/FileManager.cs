using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace GestorArchivos
{
    public delegate void PathChangedHandler();
    public delegate void TextFileOpenedHandler(string contents);
    public delegate void ImageFileOpenedHandler(Image image);


    public class FileManager
    {
        private string _CurrentPath;
        private List<FileFolderEntry> _FilesAndFolders;
        private FileSystemWatcher _FileWatcher;


        public event PathChangedHandler PathChanged;
        public event TextFileOpenedHandler TextFileOpened;
        public event ImageFileOpenedHandler ImageFileOpened;


        public FileManager()
        {
            _FilesAndFolders = new List<FileFolderEntry>();

            _FileWatcher = new FileSystemWatcher();
            _FileWatcher.Created += OnFileWatcherCreated;
            _FileWatcher.Changed += OnFileWatcherChanged;
            _FileWatcher.Deleted += OnFileWatcherDeleted;
            _FileWatcher.Renamed += OnFileWatcherRenamed;
        }

        private void OnFileWatcherRenamed(object sender, RenamedEventArgs e)
        {
            Refresh();
        }

        private void OnFileWatcherDeleted(object sender, FileSystemEventArgs e)
        {
            Refresh();
        }

        private void OnFileWatcherChanged(object sender, FileSystemEventArgs e)
        {
            Refresh();
        }

        private void OnFileWatcherCreated(object sender, FileSystemEventArgs e)
        {
            Refresh();
        }



        private void LoadFilesAndFolders()
        {
            _FilesAndFolders.Clear();

            string[] folders = Directory.GetDirectories(_CurrentPath);
            foreach(string folder in folders)
            {
                _FilesAndFolders.Add(new FileFolderEntry() {

                    FullName = folder,
                    Name = Path.GetFileName(folder),
                    IsFolder = true

                });
            }


            string[] files = Directory.GetFiles(_CurrentPath);
            foreach(string file in files)
            {
                FileInfo flInfo = new FileInfo(file);

                _FilesAndFolders.Add(new FileFolderEntry()
                {
                    FullName = file,
                    Name = Path.GetFileName(file),
                    Size = flInfo.Length
                });
            }


        }


        public void OpenFile(string file)
        {
            string extension = Path.GetExtension(file);

            if(extension == ".txt")
            {
                string contents = File.ReadAllText(Path.Combine(_CurrentPath, file));
                if (TextFileOpened != null)
                    TextFileOpened(contents);
            }
            else if(extension == ".jpg")
            {
                Image image = Image.FromFile(Path.Combine(_CurrentPath, file));
                if (ImageFileOpened != null)
                    ImageFileOpened(image);
            }

        }



        public List<FileFolderEntry> FilesAndFolders
        {
            get
            {
                return _FilesAndFolders;
            }
        }



        public void GoToUp()
        {
            DirectoryInfo drInfo = Directory.GetParent(_CurrentPath);
            SetCurrentPath(drInfo.FullName);
        }



        public void GoToFolder(string folder)
        {
            this.SetCurrentPath(Path.Combine(_CurrentPath, folder));
        }


        public string GetCurrentPath()
        {
            return _CurrentPath;
        }


        public void SetCurrentPath(string path)
        {
            _CurrentPath = path;

            _FileWatcher.Path = path;
            _FileWatcher.EnableRaisingEvents = true;

            Refresh();
        }


        public void Refresh()
        {
            LoadFilesAndFolders();

            if (PathChanged != null)
            {
                PathChanged();
            }

        }


    }
}
