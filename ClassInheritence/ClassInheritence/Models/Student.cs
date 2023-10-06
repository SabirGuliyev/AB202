using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritence.Models
{
    internal class Student:Person
    {

        public string Profession;

        public byte Course;

       
        public Student(string name,byte course,string surname) : base(name)
        {


            Surname = surname;
            Console.WriteLine("Studentin ctoru ishe dushdu");
            Course = course;
        }
    }
}
