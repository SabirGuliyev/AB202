using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Duck : Bird,ISwimFly
    {
        public int FlySpeed { get; set; }
        public int SwimSpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Duck flied away "+FlySpeed);
        }
        public void Swim()
        {
            Console.WriteLine("Duck swam away " );
        }
        public override void MakeSound()
        {
            Console.WriteLine("Qagq");
        }
    }
        

      
}
