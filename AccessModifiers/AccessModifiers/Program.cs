using AccessModifiers.Models;
using Education;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person();

            person.Name = "Sabir";
            //person.Surname = "Quliyev";

            person.Surname = "sdasd";

        }
    }
}