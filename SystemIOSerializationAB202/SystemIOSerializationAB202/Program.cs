using Newtonsoft.Json;
using SystemIOSerializationAB202.Models;

namespace SystemIOSerializationAB202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory, File
            //Directory.Exists(@"C:\Users\sabir\Desktop\Test");

            //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Test");

            //if (Directory.Exists(@"C:\Users\sabir\Desktop\Test"))
            //{
            //    Directory.Delete(@"C:\Users\sabir\Desktop\Test");
            //}

            //string[] directories = Directory.GetDirectories(@"C:\Users\sabir\Desktop\Test");

            //foreach (var item in directories)
            //{
            //    Console.WriteLine(item);
            //}

            //if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    File.Create(@"C:\Users\sabir\Desktop\Test\text.txt").Close();

            //}


            //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");

            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\sabir\Desktop\Test2");

            //directory.Create();
            //directory.Exists;
            //directory.Delete();


            //FileInfo file = new FileInfo(@"C:\Users\sabir\Desktop\Test3\text.txt");
            //file.Create();


            #endregion

            #region Stream
            //StreamReader sr = new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt");


            //try
            //{
            //    string result = sr.ReadToEnd();

            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    sr.Close();
            //}




            //StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt", true);

            //sw.WriteLine("Azer3 Qasimzade");
            //sw.WriteLine("Aqshin3 Aliyev");
            //sw.WriteLine("Ali3 Kerimov");

            //sw.Close();

            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());



            //using(StreamWriter sw=new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt", true))
            //{
            //    sw.WriteLine("Usingde yazdiq");
            //}


            //string result;
            //using(StreamReader sr=new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    result = sr.ReadToEnd();
            //}


            //Console.WriteLine(result); 
            #endregion


            Category category = new Category { Name="Mobile"};

            //Product product=new Product { Id=1,Category=category,Name="Iphone 15"};
            //Product product2=new Product { Id=2,Category=category,Name="Samsung S22"};
            //Product product3=new Product { Id=3,Category=category,Name="Xiaomi POCO 5x"};

            //List<Product> products=new List<Product> { product, product2, product3 };


            //string result = JsonConvert.SerializeObject(products);

            ////Console.WriteLine(result);

            //using(StreamWriter sw=new StreamWriter(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerializationAB202\SystemIOSerializationAB202\Files\jsonObjects.json"))
            //{
            //    sw.Write(result);
            //}


            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerializationAB202\SystemIOSerializationAB202\Files\jsonObjects.json"))
            {
                result = sr.ReadToEnd();
            }

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);


            products.Add(new Product { Id = 5, Category = category, Name = "Sony Erikson" });




            string json =JsonConvert.SerializeObject(products);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerializationAB202\SystemIOSerializationAB202\Files\jsonObjects.json"))
            {
                sw.Write(json);
            }




            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine(Directory.GetCurrentDirectory());

            //products[0].N

        }
    }
}