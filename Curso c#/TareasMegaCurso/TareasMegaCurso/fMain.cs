using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareasMegaCurso
{
    public partial class fMain : Form
    {
        private bool _IsNewTask;
        private bool _HasChanges;


        public fMain()
        {
            InitializeComponent();
            Reset();
        }


        private void Reset()
        {
            this.lstTasks.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.txtTask.Enabled = false;
            this.btnAdd.Enabled = true;

            this.txtTask.Text = "";

            //enable/deshabilitar el listbox basado en elementos de numeros
            this.lstTasks.Enabled = this.lstTasks.Items.Count > 0;
            this.lstTasks.SelectedIndex = -1;

            _HasChanges = false;
        }



        private void AddNewTask()
        {
            if(_HasChanges)
            {
                if (MessageBox.Show("¿Guardar cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(!this.SaveChanges())
                    {
                        return;
                    }
                }

            }
            btnCancel.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnAdd.Enabled = false;

            this.txtTask.Enabled = true;
            this.txtTask.Text = "";
            this.txtTask.Focus();

            _IsNewTask = true;
        }


        private void DeleteTask()
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (lstTasks.SelectedIndex >= 0 && lstTasks.SelectedIndex < lstTasks.Items.Count)
                {
                    this.lstTasks.Items.RemoveAt(this.lstTasks.SelectedIndex);
                    this.Reset();
                }
            }
        }

        private bool SaveChanges()
        {
            if(txtTask.Text.Length == 0)
            {
                MessageBox.Show("Debe escribir un nombre para la tarea", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_IsNewTask)
            {
                this.lstTasks.Items.Add(this.txtTask.Text);
                this.Reset();
            }
            else
            {
                this.lstTasks.Items[this.lstTasks.SelectedIndex] = this.txtTask.Text;
                MessageBox.Show("Guardado correctamente");
            }

            return true;
        }

        private void Cancel()
        {
            if (_HasChanges)
            {
                if (MessageBox.Show("¿Guardar cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!this.SaveChanges())
                    {
                        return;
                    }
                }

            }

            this.Reset();
        }


        private void LoadSelectedTask()
        {
            if (lstTasks.SelectedIndex >= 0 && lstTasks.SelectedIndex < lstTasks.Items.Count)
            {
                this.txtTask.Text = lstTasks.Items[lstTasks.SelectedIndex].ToString();

                this.btnSave.Enabled = true;
                this.txtTask.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnCancel.Enabled = true;

                _IsNewTask = false;
            }
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddNewTask();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteTask();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadSelectedTask();
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            _HasChanges = true;
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Guardar cambios?", "Guardar", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                if (!this.SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if(result == DialogResult.No)
            {

            }
            else if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }
}
