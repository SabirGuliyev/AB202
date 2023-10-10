using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersRecordTupleEncapsulation.Models
{
    internal record PersonRecord
    {
        public string Name { get; init; }
        public string Surname { get; init; }

        public PersonRecord(string name, string surname)
        {
            //Name = name;
            //Surname = surname;

            (Name, Surname) = (name, surname);
        }
    }

    //internal record PersonRecord(string Name,string Surname);
}
