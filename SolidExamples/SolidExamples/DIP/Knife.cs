using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.DIP
{
    internal class Knife : ICut
    {

        public Knife()
        {
            throw new Exception("Iti deyil");
        }
        public void Cut()
        {
            Console.WriteLine("Item was cut");
        }
    }
}
