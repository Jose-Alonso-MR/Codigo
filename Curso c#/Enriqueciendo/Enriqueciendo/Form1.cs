using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enriqueciendo
{
    public partial class Form1 : Form
    {

        private CustomerManager _Manager;




        public Form1()
        {
            InitializeComponent();


            _Manager = new CustomerManager();
            _Manager.CustomerCreated += _Manager_CustomerCreated;


            TestEvent();

            //TestEnums();
            //TestAge();
            //TestNullables();
        }

        private void _Manager_CustomerCreated(Customer customer)
        {
            MessageBox.Show("Cliente creado");    
        }



        private void TestEvent()
        {
            Customer customer = new Customer();
            _Manager.CreateCustomer(customer);

        }



        private void TestEnums()
        {
            Customer customer = new Customer();

            customer.Country = Country.UnitedKingdom;
        }


        private void TestAge()
        {

            Customer customer = new Customer();
            customer.Age = 12;

            string errorMessage = "";
            if(!UTILS.IsValidCustomer(customer, out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            
            this.txtResult.Text = "El cliente es válido";

        }


        private void TestNullables()
        {

            Customer customer = new Customer();

            if(customer.Agreement.HasValue)
            {
                bool agreement = customer.Agreement.Value;
            }


            this.txtResult.Text = customer.Age.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(sender == button1)
            {

            }

            MessageBox.Show("aa");

        }
    }
}
