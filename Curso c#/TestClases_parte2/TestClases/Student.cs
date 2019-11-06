using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestClases
{
    public sealed class Student : Person
    {

        //constructor
        public Student(string name, string lastName): base(name, lastName, "")
        {
        }


        public void Enrollment()
        {
        }



        public override bool CanTeach
        {
            get
            {
                return false;
            }
        }


        //public override string Greeting()
        //{
        //    return "Hola, soy un estudiante";
        //}



    }


}
