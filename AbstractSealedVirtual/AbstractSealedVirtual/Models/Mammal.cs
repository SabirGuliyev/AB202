using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal abstract class Mammal:Animal
    { 
        public void Born()
        {
            Console.WriteLine("Welcome");
        }
    }
}
