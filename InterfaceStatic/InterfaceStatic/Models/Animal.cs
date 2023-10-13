using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal abstract class Animal
    {
        public byte AvgLifetime { get; set; }
        public string Gender { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("Yem ile qidalanir");
        }

        public abstract void MakeSound();
    }
}
