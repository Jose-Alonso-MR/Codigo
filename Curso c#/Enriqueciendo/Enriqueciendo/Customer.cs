using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enriqueciendo
{
    public sealed class Customer
    {

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }


        public int? Age { get; set; }


        public Country Country { get; set; }


        public bool? Agreement { get; set; }

    }

}
