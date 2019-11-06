using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClases
{
    public abstract class Person
    {

        private static int Counter;

        public int ID { get; protected set; }


        public string Name
        {
            get; protected set;
        }

        public string LastName
        {
            get; protected set;
        }


        public string Address
        {
            get; protected set;
        }



        public virtual string Greeting()
        {
            return "Soy una persona";
        }


        public abstract bool CanTeach
        {
            get;
        }



        //constructor
        public Person(string name, string lastName): this(name, lastName, "")
        {
            
        }


        //constructor
        public Person(string name, string lastName, string address)
        {
            if (string.IsNullOrEmpty(name))
            {

            }

            if (string.IsNullOrEmpty(lastName))
            {

            }

            Counter++;

            this.ID = Counter;

            this.Name = name;
            this.LastName = lastName;
            this.Address = address;
        }



        protected void Disable()
        {

        }



    }
}
