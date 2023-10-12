using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal abstract class Animal
    {
        public byte AvgLifeTime { get; set; }

        public string Gender { get; set; }

      

        public virtual void Eat()
        {
            Console.WriteLine("yem ile qidalanir");
        }

        public abstract void MakeSound();

    }
}
