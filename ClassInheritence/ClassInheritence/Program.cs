using ClassInheritence.Models;
namespace ClassInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("{0} {1} {2}",Name,Surname,Age);
            //Console.WriteLine($"{Name2} {Surname2}");



            #region Anonymous object
            //object person = new
            //{
            //    Name = "Azer",
            //    Surname = "Qasimzade",
            //    Age = 19
            //};

            //object person2 = new
            //{
            //    Fullname = "Fidan",
            //    Age = 20
            //};

            //Console.WriteLine(person.GetType().GetProperty("Name").GetValue(person)); 
            #endregion

            #region Class Constructor This

            //Person person=new Person();
            //person.Name = "Azer";
            //person.Surname = "Qasimzade";
            //person.Age = 19;

            //Person person2 = new Person
            //{
            //    Name = "Fidan",
            //    Surname = "Behbudova",
            //    Age = 20
            //};


            //person.GetInfo();


            //person2.GetInfo();


            //Person person3=new Person("Sabir","Quliyev",25);
            //Person person4 = new Person("Azer", "Qasimzade");

            //Person person5 = new Person("Fidan");
            //Person person6 = new Person("Amin","Pashayev");
            //Person person7 = new Person("Nicat","Mecidov",19);





            //person5.GetInfo();  
            //person6.GetInfo();
            //person7.GetInfo(); 
            #endregion


            Student student = new Student("Seid");

            //student.GetInfo();

            //Teacher teacher = new Teacher
            //{
            //    Name = "Sabir",
            //    Surname = "Quliyev",
            //    Age = 25,
            //    Experience = 12,
              
            //    Salary = 23456
            //};

            //teacher.GetInfo();

        }

    }

    class Person
    {
        //Fields

        public string Name;

        public string Surname;

        public byte Age;


        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Person ctor ishe dushdu");
        }


        #region Overload and This
        //public Person()
        //{
        //    Console.WriteLine("Person created");
        //}
        //public Person(string name):this()
        //{

        //    Name =name;
        //}

        //public Person(string name, string surname):this(name)
        //{
        //    Surname = surname;
        //}
        //public Person(string name, string surname, byte age):this(name,surname)
        //{
        //    Age = age;
        //} 
        #endregion

        //Methods

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

    }
    
}