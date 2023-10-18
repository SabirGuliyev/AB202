using ExceptionHandling.Models;
using ExceptionHandling.Utilities.Exceptions;
using System.Reflection;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exception

            //int num;
            //int num2;


            //try
            //{
            //    string name = "Sabir";
            //    num = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(num / num2);

            //    Console.WriteLine(name[56]);

            //}
            //catch (FormatException e)
            //{
            //    num = 0;
            //    num2 = 0;
            //    Console.WriteLine(num/num2);
            //    Console.WriteLine("1ci catch ishe dushdu");
            //    Console.WriteLine(e.Message);
            //}
            //catch(DivideByZeroException e)
            //{
            //    num2 = 1;
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("2ci catch ishe dushdu");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);

            //}

            //Console.WriteLine("Bu setr oxundu");





            //string[] names = { "Shems", "Azer", "Ali", "Farid", "Nurlan" };


            //try
            //{
            //    Search("  nubar   ", names);



            //    Console.WriteLine("Var");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally bloku oher zaman ishleyecek");
            //}


            //Console.WriteLine("Bura ishe dushecek");



            //Console.WriteLine("Programdaki kodlar devam");

            //string word = "Salam";
            //try
            //{
            //    Student student = new Student("s");

            //    Console.WriteLine(student.Name);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("Devam edir");



            #endregion



            Assembly assembly=Assembly.GetExecutingAssembly();

            Type[] types=assembly.GetTypes();
            //PropertyInfo
            //MethodInfo
            //FieldInfo
            //ConstructorInfo



            //foreach (Type type in types)
            //{
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine(type.Name);


            //    foreach (MemberInfo member in type.GetMembers())
            //    {
            //        Console.WriteLine(member);
            //    }
            //}

            Console.WriteLine("sfdsfdsffsdfsdf");
            Teacher teacher=new Teacher { _name="Sabir",Age=25};

            Type type = teacher.GetType();

            Type type2 = typeof(Teacher);

            Type type3 = assembly.GetType("ExceptionHandling.Models.Teacher");


            Console.WriteLine(type3.Name);


            FieldInfo field = type.GetField("_salary", BindingFlags.NonPublic | BindingFlags.Instance);


            field.SetValue(teacher, 40000m);

            //Console.WriteLine(field.GetValue(teacher));

        }





        public static bool Search(string search, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (search.Trim().ToLower() == arr[i].Trim().ToLower())
                {
                    return true;
                }
            }
            return false;
            //throw new NotFoundException($"{search} movcud deyil");
           
        }
    }
}