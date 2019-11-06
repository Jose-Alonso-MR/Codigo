using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArchivosImagenesParte2
{
    public partial class fMain : Form
    {
        private const string fileName = "test.txt";
        private const string binaryFileName = "test.dat";

        public fMain()
        {
            InitializeComponent();
        }

        
        private void ReadTestFile()
        {
            txtResult.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach(string line in lines)
            {
                //string[] values = line.Split(new char[] { ';' } , StringSplitOptions.RemoveEmptyEntries);
                string[] values = line.Split(';');

                string name = values[0];
                string phone = values[1];
                string postalCode = values[2];

                txtResult.AppendText(string.Format(
                    "Nombre:{0}, Telefono:{1}, Código postal:{2}",
                    name, phone, postalCode)
                );

                txtResult.AppendText(System.Environment.NewLine);

            }

            MessageBox.Show("Lectura completa");

        }





        private void ReadBinary()
        {
            Customer customer = new Customer();
            BinaryReader br = null;

            try
            {
                br = new BinaryReader(new FileStream(binaryFileName, FileMode.Open));

                customer.ID = br.ReadInt32();
                customer.name = br.ReadString();
                customer.phone = br.ReadString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (br != null)
                {
                    br.Dispose();
                }
            }


        }

        private void WriteBinary()
        {
            Customer customer = new Customer();

            customer.ID = 100000000;
            customer.name = "Philippe Andrews";
            customer.phone = "96655544";

            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(binaryFileName, FileMode.Create));

                bw.Write(customer.ID);
                bw.Write(customer.name);

            }
            catch
            {

            }
            finally
            {
                if (bw != null)
                {
                    bw.Dispose();
                }
            }


        }




        private void WriteTestFile()
        {
            txtResult.Clear();


            //FileStream fs = new FileStream(fileName, FileMode.Create);

            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create)))
            {
                sw.AutoFlush = true;

                Random r = new Random();
                for (int i = 1; i <= 100; i++)
                {
                    string line = "valuéñ" + i;

                    string phone = r.Next().ToString();
                    line += ";" + phone;

                    string postalCode = r.Next().ToString();
                    line += ";" + postalCode;

                    sw.WriteLine(line);


                    //sw.Flush();
                }
            }


            MessageBox.Show("Completado");
        }



        private void OpenImage()
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();

            if (dlg == DialogResult.OK)
            {

                Image myImage = Image.FromFile(this.openFileDialog1.FileName);

                this.pictureBox1.Image = myImage;
            }

        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadTestFile();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteTestFile();
        }



        private void btnReadBinary_Click(object sender, EventArgs e)
        {
            ReadBinary();
        }

        private void btnWriteBinary_Click(object sender, EventArgs e)
        {
            WriteBinary();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

    }
}
