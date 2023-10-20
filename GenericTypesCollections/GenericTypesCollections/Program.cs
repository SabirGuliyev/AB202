using GenericTypesCollections.Animals;
using GenericTypesCollections.Foods;
using System.Collections;

namespace GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region GenericType
            //Product<int> product = new Product<int>(100);
            //product.Quality -= 10;


            //Product<char> prodcut2 = new Product<char>('A');
            //prodcut2.Quality = Char.ToLower(prodcut2.Quality);

            //Product<string> prodcut3 = new Product<string>("high");
            //prodcut3.Quality += "++";


            //Console.WriteLine(product.Quality);
            //Console.WriteLine(prodcut2.Quality);
            //Console.WriteLine(prodcut3.Quality);

            //Lion lion = new Lion { AvgLifetime=20,IsAlpha=true,Name="Simba"};
            //Lion lion2 = new Lion { AvgLifetime=20,IsAlpha=false,Name="Alex"};

            //Meat meat = new Meat { TypeName="Beef"};


            //ZooCage<Lion,Meat> zooCage = new ZooCage<Lion,Meat>(meat);

            //zooCage.Add(lion);
            //zooCage.Add(lion2);

            //zooCage.ShowAnimals();
            //zooCage.ShowFood();

            //Console.WriteLine("--------------------------------");

            //Elephant elephant = new Elephant { AvgLifetime=30,TeethWeight=14.5,Name="Hakuna"};
            //Elephant elephant2 = new Elephant { AvgLifetime=30,TeethWeight=17.5,Name="Matata"};

            //Grass grass = new Grass { TypeName = "Yonca" };

            //ZooCage<Elephant,Grass> zooCage2 = new ZooCage<Elephant,Grass>(grass);

            //zooCage2.Add(elephant);
            //zooCage2.Add(elephant2);
            //zooCage2.ShowAnimals();
            //zooCage2.ShowFood(); 
            #endregion



            //ArrayList
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add("Salam");
            //list.Add('D');

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Salam");
            //sortedList.Add(5, "Hello");
            //sortedList.Add('A', "Shalom");




            //SortedList<char, string> sorted = new SortedList<char, string>();

            //sorted.Add('z', "Azer");
            //sorted.Add('b', "Amin");
            //sorted.Add('a', "Aqshin");
            //sorted.Add('f', "Aqshin");
            //Console.WriteLine(sorted.TryAdd(7, "Fidan"));


            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(sorted['b']);

            //LIFO
            //Stack<string> names=new Stack<string>();

            //names.Push("Baki");
            //names.Push("Berde");
            //names.Push("Naxcivan");
            //names.Push("Yevlax");


            //Console.WriteLine(names.Peek()+" peek elediyimiz deyer");
            //names.Pop();
            //names.Pop();
            //names.Pop();



            //string name;
            //Console.WriteLine(names.TryPop(out name)); 

            //Console.WriteLine(name);



            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //FIFO
            //Queue<string> names=new Queue<string>();

            //names.Enqueue("Azer");
            //names.Enqueue("Ayshen");
            //names.Enqueue("Ferid");

            //names.Peek();
            //names.Dequeue();
            //names.Dequeue();
            //names.Dequeue();
            //names.TryDequeue();


            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names.ElementAt(i));
            //}

            //Dictionary<string, string> students = new Dictionary<string, string>();
            //students.Add("c2", "Nurlan Seferli");
            //students.Add("c1", "Nurlan");

            //students.TryAdd("c3", "Said");


            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            //Console.WriteLine(students["c1"]);




            List<int> nums = new List<int> { 1,2,3,1,4};
            List<int> nums2 = new List<int> { 30,40};
          
            nums.Add(20);
            //nums.Remove(1);
            nums.AddRange(nums2);
            //nums.RemoveAt(0);
            //nums.RemoveRange(0, 3);
            //nums.RemoveAll(x => x > 5);

            

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }


        }
    }
}