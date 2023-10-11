using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    public class Person
    {

        private protected string Name { get; set; }

        protected internal string Surname { get; set; }
        //public string Surname { get; set; }
    }
}
