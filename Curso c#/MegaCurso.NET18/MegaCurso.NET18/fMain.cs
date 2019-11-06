using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MegaCurso.NET18
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }


        private void TestWriteToLog()
        {

            string badNumber = "123mkzk";

            try
            {
                Log.WriteInfo("Antes de convertir el numero");
                int myNumber = int.Parse(badNumber);
                Log.WriteInfo("Después de convertir el numero");
            }
            catch (Exception ex)
            {
                Log.WriteError(ex.ToString());
            }

        }

        private void btnTestDebug_Click(object sender, EventArgs e)
        {
            //TestParent();
            TestLoop();
        }


        private void TestParent()
        {
            TestChild();
        }

        private void TestChild()
        {

            string myText = "hola";
            int myNumber = 100;

            string pp = this.Text;

        }


        private void TestLoop()
        {
            string myText = "hola";

            for (int i = 1; i <= 100; i++)
            {
                System.Diagnostics.Debug.WriteLineIf(i == 50, string.Format("El valor de myText = {0}", myText));
                myText += i;
            }
            
        }

        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            string folderParam = System.Configuration.ConfigurationManager.AppSettings["Folder"];
            bool writeToFile = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["WriteToFile"]);

            MessageBox.Show(string.Format("Folder parameter is {0}", folderParam));

        }
    }
}
