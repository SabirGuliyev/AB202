using ExceptionHandling.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                value = value.Trim();
                if (value.Length<3)
                {
                    //throw new NameFormatException(value + " is not in correct format");
                }
                _name = value;

            }
        }


        public Student(string name)
        {
            Name = name;
        }
    }
}
