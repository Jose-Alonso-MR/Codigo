using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes
{
    public partial class fMain : Form
    {
        private CustomerManager _customerManager;

        public fMain()
        {
            InitializeComponent();
            Init();
        }


        private void fMain_Activated(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }


        private void Init()
        {
            _customerManager = new CustomerManager();

            _customerManager.AddCustomer("Jose", "Alonso", "Benito Juarez");
        }


        private void EditCustomer()
        {
            if (lstCustomers.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCustomers.SelectedIndices[0];
            Customer customer = _customerManager.Customers[selectedIndex];

            fCustomer formCustomer = new fCustomer();
            formCustomer.EditingCustomer = new Customer() {
                Name = customer.Name,
                LastName = customer.LastName,
                Address = customer.Address
            };

            if(formCustomer.ShowDialog() == DialogResult.OK)
            {
                //_customerManager.Customers[selectedIndex] = formCustomer.EditingCustomer;

                _customerManager.SetCustomer(selectedIndex, formCustomer.EditingCustomer);
                btnRefresh.PerformClick();
            }

        }


        private void DeleteCustomer()
        {
            if (lstCustomers.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCustomers.SelectedIndices[0];
            _customerManager.DeleteCustomer(selectedIndex);
            btnRefresh.PerformClick();

        }


        private void DuplicateCustomer()
        {
            if (lstCustomers.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCustomers.SelectedIndices[0];

            _customerManager.DuplicateCustomer(selectedIndex);
            btnRefresh.PerformClick();
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();

            List<Customer> customers = _customerManager.Customers;

            foreach(Customer customer in customers)
            {
                ListViewItem item = lstCustomers.Items.Add(customer.Name);
                item.SubItems.Add(customer.LastName);
                item.SubItems.Add(customer.Address);
                item.SubItems.Add(customer.CreateDate.ToString("dd/MM/yy"));
            }

            if(lstCustomers.Items.Count > 0)
            {
                lstCustomers.Items[0].Selected = true;
            }

            //lblTotalCustomers.Text = "Total clientes " + lstCustomers.Items.Count;
            lblTotalCustomers.Text = "Total clientes " + _customerManager.Customers.Count;

            lstCustomers.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fCustomer formCustomer = new fCustomer();
            formCustomer.EditingCustomer = new Customer();

            if(formCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer newCustomer = formCustomer.EditingCustomer;
                _customerManager.AddCustomer(newCustomer.Name, newCustomer.LastName, newCustomer.Address);

                btnRefresh.PerformClick();
            }


        }



        private void lstCustomers_DoubleClick(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            DuplicateCustomer();
        }
    }
}
