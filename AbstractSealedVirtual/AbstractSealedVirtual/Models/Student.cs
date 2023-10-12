using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.Models
{
    internal class Student:Person
    {
        public string Group { get; set; }
        public byte Course { get; set; }


       //public sealed override void GetInfo()
       // {
       //     Console.WriteLine($"{Name} {Surname} {Age} {Group} {Course}");
       // }

        //public void GetInfo()
        //{
        //    Console.WriteLine("sds");
        //}
        public override string ToString()
        {
            return $"{Age}"; 
        }

    }
}
