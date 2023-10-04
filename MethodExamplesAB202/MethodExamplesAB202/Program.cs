namespace MethodExamplesAB202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(GetDiscount(90, 10));

            //int num = GetDiscount(80, 20);

            //Console.WriteLine(num);

            //------------------------------------------------------------

            //Console.WriteLine(GetFullname());
            //-------------------------------------------------------------


            //int[] numbers = { 1, 2, 5, 7, 3, 12 };

            //int[] numbers2 = { 4, 5, 6 };

            //int result=GetSum(numbers);

            //Console.WriteLine(result);

            //Console.WriteLine(GetSum(numbers2));

            //-------------------------------------------------------------


            //GetFullname("sabir");

            //------------------------------------------------------------

            //Console.WriteLine(GetSentence("salam", "gencler"));


            //Console.WriteLine(GetSentence("salam", "gencler", "necesiz", "qara", "Gunler"));


            //-----------------------------------------------------------

            //Sum(1, 2, 3);
            //Sum(4.5, 6.7);


            //Sum(5, 4.5);
            //Sum(4.5, 5);



            //Sum(5, 2,1,1);

            //---------------------------------------------------------





            //Console.WriteLine(IsEven(8));


            //CheckAge(19);
            //---------------------------------------------------------



            int[] numbers = { 1, 2, 3, 4,50 };

            CheckArrayEven(numbers);
        }
       
        public static void CheckArrayEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsEven(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
         
        public static bool IsEven(int num)
        {
            if (num%2!=0)
            {
                return true;
            }


           return false;
        }
        //public static void CheckAge(int age)
        //{
        //    if (age < 18)
        //    {
        //        Console.WriteLine("Yashiniz azdir");
        //        return;
        //    }

        //    Console.WriteLine("Ishe qebul oldunuz");


        //}
















        //public static void Sum(int num,int num2)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}

        //public static void Sum(int num, int num2, int num3 = 3)
        //{
        //    Console.WriteLine("2ci method ishe dushdu");
        //}
        //public static void Sum(params int[] numbers)
        //{
        //    Console.WriteLine("2ci method ishe dushdu");
        //}

        //public static void Sum(double num,double num2)
        //{
        //    Console.WriteLine("3cu ishe dushdu");
        //}




        //public static void Sum(int num,double num2)
        //{
        //    Console.WriteLine("1ci int olan method ishe dushdu");

        //}
        //public static void Sum(double num2, int num)
        //{
        //    Console.WriteLine("1ci double olan method ishe dushdu");

        //}









        //public static string GetSentence(string name,params string[] words)
        //{
        //    string sentence = "";
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        sentence += words[i];
        //        sentence += " ";
        //    }
        //    Console.WriteLine(name);
        //    return sentence;

        //}


        //public static void GetFullname(string name,string surname="xxxx")
        //{
        //    Console.WriteLine(surname + " " + name);

        //}





        //public static int GetSum(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;

        //}




        //public static string GetFullname()
        //{
        //    Console.WriteLine("Adinizi daxil edin:");

        //    string name=Console.ReadLine();

        //    Console.WriteLine("Soyadinizi daxil edin:");

        //    string surname=Console.ReadLine();


        //    return name + " " + surname;
        //}








        //public static int GetDiscount(int price,int percent)
        //{
        //    int result = price * percent / 100;

        //    return result;



        //}



    }
}