using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingBoxingImplicit.Models
{
    internal class Dog:Animal
    {
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Hav hav");
        }
    }
}
