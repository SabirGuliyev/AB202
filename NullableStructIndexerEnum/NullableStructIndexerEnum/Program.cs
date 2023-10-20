using NullableStructIndexerEnum.Models;

namespace NullableStructIndexerEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable
            //string name;


            //name = "Salam";

            //nullable valu types

            //int? num=67;


            //if (num.HasValue)
            //{
            //    int num2 = num.Value;
            //    Console.WriteLine(num2);
            //}
            //else
            //{
            //    Console.WriteLine("Nulldir");
            //}
            //Console.WriteLine(num.Value);
            //int num2 = num;



            //int[] ints = { 1, 2, 3 };



            //if (!String.IsNullOrEmpty(name))
            //{

            //    Console.WriteLine(name.Length);
            //}
            //else
            //{
            //    Console.WriteLine("Deyer qoqku");
            //}



            //bool? status = null;


            //if (status is null)
            //{
            //    Console.WriteLine("Tesdiqlenmeyib");
            //}
            //else if (status is false)
            //{
            //    Console.WriteLine("Tesdiqlenib catdirilmayib");
            //}
            //else
            //{
            //    Console.WriteLine("Catdirilib");
            //} 
            #endregion

            #region Struct
            //PointClass pointClass;

            //pointClass = new PointClass { X = 5, Y = 3 };
            //pointClass.X = 10;
            //Console.WriteLine(pointClass.X);



            //PointStruct pointStruct;

            //pointStruct = new PointStruct { X = 5, Y = 3 };
            //pointStruct.X = 10;
            //Console.WriteLine(pointStruct.X); 
            #endregion

            #region Indexer


            Student student = new Student { Name = "Azer", Fin = "c", Gender=Gender.Male };
            Student student2 = new Student { Name = "Ayshen", Fin = "c1",Gender=Gender.Female };
            //Student student3= new Student { Name="Nicat",Fin="c2"};
            //Student student4= new Student { Name="Nurlan",Fin="c3"};


            //Group group= new Group
            //{
            //    Name="AB202",
            //    _students=new Student[] { student, student2, student3,student4 }  
            //};

            //this[int index]
            //group[3]

            //Console.WriteLine(group.Students[0].Name);
            //Console.WriteLine(group[0].Name);


            //Student searched = group["c3"];
            //if (searched is null)
            //{
            //    Console.WriteLine("Bele telebe movcud deyil");
            //}
            //else
            //{
            //    Console.WriteLine(searched.Name);
            //}





            //int[] arr = new int[5];
            //arr[0] = 1;
            //int[] arr2 = {1,2,3,4,5};





            //customArr[4] = 67;
            //Console.WriteLine(customArr[34]);
            //ListInt customArr2 = new ListInt(1, 2, 3, 4, 6, 8, 9, 0);
            //customArr2.Add(29);

            //for (int i = 0; i < customArr2.Count; i++)
            //{
            //    Console.WriteLine(customArr2[i]);
            //}

            //List<int> nums = new List<int> { 1,2,3,4};
            //for (int i = 0; i < nums.Count; i++)
            //{

            //}
            //nums.Add(5);
            //nums.Remove(1);
            //nums.AddRange();
            //nums.RemoveRange();

            CustomList<int> list=new CustomList<int>(1,2,3,4,5);

            CustomList<string> list2 = new CustomList<string>("Salam", "Shalom", "Hello");


            #endregion

            Console.WriteLine("Please choose day of week:");
            foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine((int)day+" "+day);
            }

            int choice;
            string str=Console.ReadLine();
            int.TryParse(str, out choice);

            switch (choice)
            {
                case (int)WeekDay.Monday:
                    Console.WriteLine(WeekDay.Monday);
                    break;
                case (int)WeekDay.Tuesday:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;
                case (int)WeekDay.Wednesday:
                    Console.WriteLine(WeekDay.Wednesday);
                    break;
                case (int)WeekDay.Thursday:
                    Console.WriteLine(WeekDay.Thursday);
                    break;
                case (int)WeekDay.Friday:
                    Console.WriteLine(WeekDay.Friday);
                    break;
                case (int)WeekDay.Saturday:
                    Console.WriteLine(WeekDay.Saturday);
                    break;
                case (int)WeekDay.Sunday:
                    Console.WriteLine(WeekDay.Sunday);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }


            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wenesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong input");
            //        break;
            //}






        }
        //public static void Test(PointClass point)
        //{

        //}


        //public static void Test(PointStruct structPoint) 
        //{ 

        //}
    }
}