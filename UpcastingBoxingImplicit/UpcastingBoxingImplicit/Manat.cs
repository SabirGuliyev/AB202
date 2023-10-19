using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingBoxingImplicit
{
    internal class Manat
    {
        public decimal Azn { get; set; }
        public decimal Inflation { get; set; }
        public Manat(decimal azn)
        {
            Azn = azn;
        }



        public static bool operator ==(Manat manat, Manat manat2) 
        {
            return manat.Azn == manat2.Azn;
        }







        public static bool operator !=(Manat manat, Manat manat2)
        {
            return manat.Azn != manat2.Azn;
        }


        public static bool operator >(Manat manat, Manat manat2)
        {
            return manat.Azn > manat2.Azn;
        }
        public static bool operator <(Manat manat, Manat manat2)
        {
            return manat.Azn < manat2.Azn;
        }
        public static bool operator >(Manat manat, decimal manat2)
        {
            return manat.Azn > manat2;
        }
        public static bool operator <(Manat manat, decimal manat2)
        {
            return manat.Azn < manat2;
        }

        public static Manat operator +(Manat manat, Manat manat2)
        {
            manat.Azn+=manat2.Azn;

            return manat;
        }










        //public static explicit operator Manat(Dollar dollar)
        //{
        //    return new Manat(dollar.Usd * 1.7m);
        //}
        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Usd * 1.7m);
        }



        public static implicit operator Manat(decimal value)
        {
            return new Manat(value);
        }




    }
}
