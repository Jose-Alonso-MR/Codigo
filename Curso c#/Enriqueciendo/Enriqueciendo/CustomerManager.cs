using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enriqueciendo
{

    public delegate void CustomerCreatedDelegate(Customer customer);

    public class CustomerManager
    {


        public event CustomerCreatedDelegate CustomerCreated;



        public void CreateCustomer(Customer customer)
        {

            //write to disk or database

            if(CustomerCreated != null)
            {
                CustomerCreated(customer);
            }

        }


    }


}
