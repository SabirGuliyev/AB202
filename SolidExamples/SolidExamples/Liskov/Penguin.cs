using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.Liskov
{
    internal class Penguin : Bird, ISwim
    {
        public int SwimSpeed { get ; set ; }
       

       

        public void Swim()
        {
            Console.WriteLine("Swam");
        }
    }
}
