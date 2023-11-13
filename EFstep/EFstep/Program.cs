using EFstep.DAL;
using EFstep.Models;

namespace EFstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext context= new AppDbContext();

            //Student student= new Student
            //{
            //    Name="Amin",
            //    Surname="Pashayev",
            //    Age=19
            //};

            //context.Students.Add(student);
            //context.SaveChanges();

            //Student existed= context.Students.FirstOrDefault(s => s.Id == 3);
            //Student existed= context.Students.Find(2);
            //existed.Name = "Azer123";



            //context.Students.Update(existed);
            //context.SaveChanges();

            //if (existed is not null)
            //{
            //    context.Students.Remove(existed);
            //    context.SaveChanges();
            //}

            //if (existed != null)
            //{
            //    Console.WriteLine(existed.Name + " " + existed.Age);
            //}






           //List<Student> students= context.Students.ToList();

             List<Student> students= context.Students.Where(s=>s.Age<30).ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

        }
    }
}