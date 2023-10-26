using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.Liskov
{
    internal interface ISwimFly
    {
        int SwimSpeed { get; set; }

        int FlySpeed { get; set; }

        void Swim();
        void Fly();
    }
}
