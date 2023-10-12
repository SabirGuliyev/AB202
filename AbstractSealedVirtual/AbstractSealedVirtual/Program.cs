using AbstractSealedVirtual.HomeworkModels;
//using AbstractSealedVirtual.Models;

namespace AbstractSealedVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract
            //Dog dog = new Dog
            //{
            //    AvgLifeTime = 12,
            //    Gender = "male",
            //    Name = "Rex",
            //    Breed = "German Shepard"
            //};

            //Cow cow = new Cow
            //{
            //    AvgLifeTime = 6,
            //    Gender = "female",

            //};

            //Animal[] ferma = { dog, cow };

            //foreach (Animal animal in ferma)
            //{
            //    Console.WriteLine(animal.AvgLifeTime);
            //    Console.WriteLine(animal.Gender);
            //    animal.Eat();
            //    animal.MakeSound();

            //    Console.WriteLine("---------------------------------");
            //}

            //Animal animal = new Dog();
            //Animal animal1 = new Cow();




            //dog.MakeSound();
            //cow.MakeSound();

            //dog.Eat();
            //cow.Eat();




            //ctrl+k+u

            //Animal animal = new Animal
            //{
            //    AvgLifeTime = 3,
            //    Gender = "male"
            //};


            #endregion

            #region Virtual example
            //Student student = new Student
            //{
            //    Name="Fidan",
            //    Surname="Behbutzade",
            //    Age=20,
            //    Course=3,
            //    Group="AB202"
            //};

            //Master master = new Master
            //{
            //    Name = "Fidan",
            //    Surname = "Behbutzade",
            //    Age = 20,
            //    //Course = 3,
            //    //Group = "AB202",
            //    Diplom="Red"
            //};

            //student.GetInfo();
            //master.GetInfo();
            //
            //string text=student.ToString();

            //Console.WriteLine(student);
            //Console.WriteLine(master);

            #endregion

            //Task 1
            //Employee employee = new Employee
            //{
            //    Name="Azer",
            //    Salary=3400m,
            //    IsSuccessfull=false,
            //};

            //Assistant assistant = new Assistant();

            //employee=assistant.GetFeedback(employee);

            //Console.WriteLine(employee.Salary);


          Student student=  CreateStudent();
          Student student1=  CreateStudent();
          Student student2=  CreateStudent();
          Student student3=  CreateStudent();
          Student student4=  CreateStudent();
          Student student5=  CreateStudent();









        }


        public static Student CreateStudent()
        {

            bool result = false;
            string name = "";
            Console.WriteLine("Adinizi daxil edin:");
            do
            {

                name = Console.ReadLine().Trim();
                result = CheckLetter(name);
                if (!result || name.Length < 3 || name.Length > 25)
                {
                    Console.Clear();
                    Console.WriteLine("Yanlish deyer daxil etdiniz bir daha sinayin:");
                }

            } while (!result || name.Length < 3 || name.Length > 25);


            Console.WriteLine("Please enter your age:");

            byte age = CheckNumber(200);

            Console.WriteLine("Please enter your grade:");

            byte grade = CheckNumber(100);

            Student student = new Student
            {
                Name = name,
                Age = age,
                Grade = grade,

            };

            Console.WriteLine(student.Name + " " + student.Age + " " + student.Grade);


            return student;
        }
        public static byte CheckNumber(byte limit)
        {
            bool ageResult = false;
            byte age;
            do
            {
                string str = Console.ReadLine();
                ageResult = byte.TryParse(str, out age);
                if (!ageResult || age > limit)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input. Try again:");
                }


            } while (!ageResult || age > limit);

            return age;
        } 
        public static bool CheckLetter(string name)
        {
            
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                   
                    return false;
                }
            }
            return true;

        }
    }
}