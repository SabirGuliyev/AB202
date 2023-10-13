using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal abstract class Bird:Animal
    {
        public bool HasEgg { get; set; }

        //public virtual void Fly()
        //{
        //    Console.WriteLine("Bird flied away");
        //}
    }
}
