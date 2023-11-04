using ADONETExample.Models;
using ADONETExample.Services;
using System.Data;
using System.Data.SqlClient;

namespace ADONETExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ADO intro
            string conn = "server=MSI;database=ADONETAB202;trusted_connection=true;integrated security=true;";
            //SqlConnection connection = new SqlConnection(conn);
            //connection.Open();

            //string cmd = "INSERT INTO Students VALUES('Test','Testov',18)";
            //SqlCommand command = new SqlCommand(cmd, connection);

            //int result = command.ExecuteNonQuery();
            //connection.Close();

            //if (result>0)
            //{
            //    Console.WriteLine("Command successfully completed");
            //}
            //else
            //{
            //    Console.WriteLine("Error occured");
            //}

            //string query = "SELECT * FROM Students";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //connection.Close();


            //foreach(DataRow item in table.Rows)
            //{

            //    Console.WriteLine(item["Id"]+" " + item["Name"]+" " + item["Surname"]+" " + item["Age"]);
            //}


            #endregion

            StudentService service=new StudentService();

           

            Student student = new Student { Name="Azer",Surname="Alasgerli",Age=22};

            //service.Add(student);

            service.Delete(4);

            List<Student> students = service.GetAll();

            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age}");
            }


        }
    }
}