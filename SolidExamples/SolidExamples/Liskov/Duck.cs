using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.Liskov
{
    internal class Duck : Bird, ISwim,IFly
    {
        public int SwimSpeed { get ; set; }
        public int FlySpeed { get ; set ; }

        public void Fly()
        {
            Console.WriteLine("Flied");
        }

        public void Swim()
        {
            Console.WriteLine("Swam");
        }
    }
}
