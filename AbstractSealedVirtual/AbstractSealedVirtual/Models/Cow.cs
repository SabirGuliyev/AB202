﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal class Cow:Animal
    {
        public void MakeMilk()
        {
            Console.WriteLine("Milk produced");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mooooooooooooooo");
        }
    }
}
