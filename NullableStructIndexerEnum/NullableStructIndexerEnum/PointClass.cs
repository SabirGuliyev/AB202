using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexerEnum
{
    internal class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass()
        {

        }
    }

    internal struct PointStruct:ITest
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Test { get ; set; }

        public PointStruct(int x)
        {
            X = x;
            Y = 0;
            Test = 0;
        }
    }

    internal interface ITest
    {
        int Test { get; set; }
    }
}
