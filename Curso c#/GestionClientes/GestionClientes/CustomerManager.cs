using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes
{
    public class CustomerManager
    {

        private List<Customer> _Customers;


        public CustomerManager()
        {
            _Customers = new List<Customer>();
        }


        public List<Customer> Customers
        {
            get
            {
                return _Customers;
            }
        }


        public void AddCustomer(string name, string lastName, string address)
        {
            Customer newCustomer = new Customer()
            {
                Name = name, 
                LastName = lastName,
                Address = address

            };

            _Customers.Add(newCustomer);

        }

        public void SetCustomer(int selectedIndex, Customer editingCustomer)
        {
            _Customers[selectedIndex] = new Customer()
            {
                Name = editingCustomer.Name,
                LastName = editingCustomer.LastName,
                Address = editingCustomer.Address
            };
        }

        public void DeleteCustomer(int selectedIndex)
        {
            _Customers.RemoveAt(selectedIndex);
        }


        public void DuplicateCustomer(int selectedIndex)
        {
            Customer customer = _Customers[selectedIndex];

            AddCustomer("Copia de " + customer.Name, customer.LastName, customer.Address);

        }
    }
}
