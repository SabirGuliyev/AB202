using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace NamespaceExample.Models.Base.Example
namespace NamespaceExample.Models
{
    class Person
    {
        public const string WifiPass="Sabir123";
        //public string A { get; set; }

        public readonly string _surname;
        public string _group;
        //Get only Auto property
        public string Name { get; }
        public string Group {get { return _group; } }
        public byte Age { get; init; }


        public Person(string name, string surname, byte age,string group)
        {
            Name = name;
            _group = group;


            
            _surname = surname;
            Age = age;
        }


    }
}
