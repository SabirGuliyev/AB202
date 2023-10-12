using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal class Master:Person
    {

        public string Diplom { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine("Salam");
        }

    }
}
