using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Eagle:Bird,IFly
    {
        public byte ClawPower { get; set; }
        public int FlySpeed { get; set ; }

        public void Fly()
        {
            Console.WriteLine("Eagle flied away " +FlySpeed*5);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
}
