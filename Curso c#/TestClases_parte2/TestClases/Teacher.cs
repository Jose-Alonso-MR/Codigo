using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClases
{
    public sealed class Teacher : Person
    {

        //constructor
        public Teacher(string name, string lastName): base(name, lastName, "")
        {
        }


        /// <summary>
        /// List of subjects
        /// </summary>
        public List<string> Subjects { get; private set; }



        public override string Greeting()
        {
            return "Hola, soy un profesor";
        }


        public override bool CanTeach
        {
            get
            {
                return true;
            }
        }

    }

    
}
