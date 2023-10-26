using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.DIP
{
    internal class Scissor : ICut
    {
        public void Cut()
        {
            Console.WriteLine("Item was cut by Scissor");
        }
    }
}
