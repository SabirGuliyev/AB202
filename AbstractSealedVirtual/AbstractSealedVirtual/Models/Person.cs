using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal abstract class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public byte Age { get; set; }


        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
}
