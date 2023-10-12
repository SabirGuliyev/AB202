using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal class Dog:Mammal
    {
        public string Name { get; set; }

        public string Breed { get; set; }

     

        public void PlayWithHuman()
        {
            Console.WriteLine("Plays");
        }

        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }

        public override void Eat()
        {
            Console.WriteLine("Yem ve meat ile qidalanir");
        }
    }
}
