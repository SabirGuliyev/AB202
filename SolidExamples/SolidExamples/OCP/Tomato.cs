using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.OCP
{
    internal class Tomato : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Pomidor hazirdir");
        }
    }
}
