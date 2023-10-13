using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Person
    {
        //public static byte RetirementAge;
        public int Count { get; set; }= 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        //static Person()
        //{
        //     if (DateTime.Now.Year >= 2024)
        //    {
        //        RetirementAge = 65;
        //    }
        //    else
        //    {
        //        RetirementAge = 60;
        //    }
           
        //}
        public Person()
        {
            Count++;
            Id = Count;
        }
        public void GetInfo()
        {

            Console.WriteLine($"{Name} {Surname}");
        }
       
    }
}
