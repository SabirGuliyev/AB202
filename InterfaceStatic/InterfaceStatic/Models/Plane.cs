using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Plane : IFly
    {
        public int FlySpeed { get ; set; }

        public void Fly()
        {
            Console.WriteLine("Plane flied "+FlySpeed/2);
        }
    }
}
