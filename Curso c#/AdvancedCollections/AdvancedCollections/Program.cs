using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Customer> hashCustomers = new HashSet<Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            hashCustomers.Add(pepito);

            Customer pepito2 = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            hashCustomers.Add(pepito2);


            Console.WriteLine(pepito != pepito2);


            Console.WriteLine(pepito);



            Console.WriteLine(string.Format("El número de clientes es {0}", hashCustomers.Count));
            Console.ReadLine();

        }


        private static void TestDictionaryRemove()
        {

            Dictionary<int, Customer> customerDict = new Dictionary<int, Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            Customer juanito = new Customer()
            {
                Name = "Juanito",
                ID = 2,
            };


            customerDict.Add(pepito.ID, pepito);
            customerDict.Add(juanito.ID, juanito);

            //remove a given customer using ID/key
            customerDict.Remove(2);
        }


        private static void TestDictionaryEnumerate()
        {

            Dictionary<int, Customer> customerDict = new Dictionary<int, Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            Customer juanito = new Customer()
            {
                Name = "Juanito",
                ID = 2,
            };


            customerDict.Add(pepito.ID, pepito);
            customerDict.Add(juanito.ID, juanito);
            foreach (KeyValuePair<int, Customer> kvp in customerDict)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            foreach (int key in customerDict.Keys)
            {

            }

            foreach (Customer customer in customerDict.Values)
            {
            }

            Customer temp = customerDict[4];

        }



        private static void TestDictionary()
        {
            Dictionary<int, Customer> customerDict = new Dictionary<int, Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            Customer juanito = new Customer()
            {
                Name = "Juanito",
                ID = 2,
            };



            customerDict.Add(pepito.ID, pepito);

            customerDict.Add(juanito.ID, juanito);


            if (!customerDict.ContainsKey(pepito.ID))
            {
                customerDict.Add(juanito.ID, juanito);
            }


            Customer customer2 = customerDict[3];



            Console.ReadLine();

        }



        private static void TestHashSet()
        {

            HashSet<Customer> hashCustomers = new HashSet<Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            Customer juanito = new Customer()
            {
                Name = "Juanito",
                ID = 2,
            };


            hashCustomers.Add(pepito);
            hashCustomers.Add(juanito);
            hashCustomers.Add(juanito);


            foreach (Customer customer in hashCustomers)
            {

            }


        }



        private static void TestStack()
        {

            Stack<Customer> stack = new Stack<Customer>();

            Customer pepito = new Customer()
            {
                Name = "Pepito",
                ID = 1,
            };

            Customer juanito = new Customer()
            {
                Name = "Juanito",
                ID = 2,
            };


            stack.Push(pepito);
            stack.Push(juanito);


            Customer quienSera = stack.Pop();


            Console.Write(quienSera.Name);
        }


        private static void TestQueue()
        {
            Queue<Customer> queue = new Queue<Customer>();


            Customer pepito = new Customer();
            Customer juanito = new Customer();

            queue.Enqueue(pepito);
            queue.Enqueue(juanito);

            Customer pepitoOtraVez = queue.Dequeue();
        }

    }



    public class Customer
    {

        public int ID { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            //if(obj is Customer)
            //{
            //    Customer paramCustomer = obj as Customer;
            //    if (paramCustomer.ID == this.ID)
            //        return true;
            //}
            //return false;
        
            return obj is Customer && (obj as Customer).ID == ID;
        }
        
        public override int GetHashCode()
        {
            return ID;
        }


        public static bool operator ==(Customer customerLeft, Customer customerRight)
        {
            return customerLeft.ID == customerRight.ID;
        }

        public static bool operator !=(Customer customerLeft, Customer customerRight)
        {
            return customerLeft.ID != customerRight.ID;
        }


        public static Customer operator +(Customer customer)
        {
            return new Customer() { };
        }


    }

}
