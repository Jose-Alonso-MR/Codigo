using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorArchivos
{
    public partial class fMain : Form
    {

        private FileManager _Manager;


        public fMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            Init();
        }


        private void Init()
        {
            _Manager = new FileManager();

            _Manager.PathChanged += OnManagerPathChanged;
            _Manager.ImageFileOpened += OnManagerImageFileOpened;
            _Manager.TextFileOpened += OnManagerTextFileOpened;

            _Manager.SetCurrentPath(Application.StartupPath);
        }


        private void OnManagerTextFileOpened(string contents)
        {
            this.pctImageContents.Visible = false;
            this.txtFileContents.Visible = true;
            this.txtFileContents.Text = contents;
        }


        private void OnManagerImageFileOpened(Image image)
        {
            this.txtFileContents.Visible = false;
            this.pctImageContents.Visible = true;
            this.pctImageContents.Image = image;
        }



        private void OnManagerPathChanged()
        {
            this.lstFiles.Items.Clear();
            this.lblCurrentPath.Text = _Manager.GetCurrentPath();

            this.lstFiles.Items.Add("..");

            foreach (FileFolderEntry fileAndFolder in _Manager.FilesAndFolders)
            {
                ListViewItem it = null;
                if (fileAndFolder.IsFolder)
                {
                    it = this.lstFiles.Items.Add("<DIR>" + fileAndFolder.Name);
                }
                else
                {
                    it = this.lstFiles.Items.Add(fileAndFolder.Name);
                }

                it.SubItems.Add(fileAndFolder.Size.ToString());

            }
            
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItems.Count == 0)
                return;

            string itemSelected = lstFiles.SelectedItems[0].Text;
            
            if(itemSelected == "..")
            {
                _Manager.GoToUp();
            }
            else if(itemSelected.StartsWith("<DIR>"))
            {
                _Manager.GoToFolder(itemSelected.Replace("<DIR>", ""));
            }
            else
            {
                _Manager.OpenFile(itemSelected);
            }

        }
    }

}
