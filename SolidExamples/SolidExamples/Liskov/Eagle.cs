using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.Liskov
{
    internal class Eagle : Bird, IFly
    {
        public int Age { get; set; }

        public int FlySpeed { get; set ; }
       

        public void Fly()
        {
            Console.WriteLine("Flied away");
        }
       

        public override void Eat()
        {
            if (Age < 5)
            {
                Console.WriteLine("worms");
            }
            else
            {
                Console.WriteLine("Meat");
            }
        }

       
    }
}
