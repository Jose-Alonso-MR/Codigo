using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestClases
{
    public partial class Student
    {
        private static int Counter;



        public int ID
        {
            get;private set;
        }


        public string Name
        {
            get; private set;
        }

        public string LastName
        {
            get; private set;
        }


        public string Address
        {
            get; private set;
        }


        //constructor
        public Student(string name, string lastName, string address)
        {
            if(string.IsNullOrEmpty(name))
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



        public void Matricular()
        {
        }


    }


}
