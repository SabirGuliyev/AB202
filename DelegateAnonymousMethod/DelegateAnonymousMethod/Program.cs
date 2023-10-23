namespace DelegateAnonymousMethod
{
    //internal delegate bool CheckNumber(int item);

    //internal delegate void PrintText<T>(T text);



    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> names=new List<string> { "Aqshin","Ali","Shems"};

            names.RemoveAll(n => n.Length > 3);

            names.ForEach(x => Console.WriteLine(x));




            //string search= names.Find(x => x.Length==3);


            // Console.WriteLine(search);

            #region Delegate and Anonymous method example



            //int[] numbers = { 1, 2, 3, 4, 5, 12,14,21 };
            //int result=Sum(numbers,CheckEven);
            //int result2=Sum(numbers,CheckOdd);





            //int result3 = Sum(numbers, x => x > 2 && x < 10);
            //int result4 = Sum(numbers, delegate (int num)
            //{
            //    return num % 7 == 0 && num % 3 != 0;
            //});
            //Console.WriteLine(result);



            //int result = Sum(numbers, CheckEven);
            //int result2 = Sum(numbers, CheckOdd);
            //int result3 = Sum(numbers, CheckDivideThree);

            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3); 
            #endregion

            #region Action, Func, Predicate

            //Action<string> print = PrintLower;

            //print += PrintUpper;
            //print += PrintCapitalize;
            //print += delegate (string word)
            //{
            //    Console.WriteLine(word[0] + " " + word[word.Length - 1]);
            //};
            //print += x => Console.WriteLine(x[0]+" " + x[x.Length-1]);


            //Action<int> printNums = x => Console.WriteLine(x*x);


            //print("saLaM");

            Func<int, bool> func = x => x > 6;

            Predicate<int> predicate = x => x > 6;



            //Func<int,string>
            //Action action = () => Console.WriteLine("Salam gencler ");
            //action();


            #endregion
        }
        //public static void Print<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}
        public static void PrintLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }
        public static void PrintUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        public static void PrintCapitalize(string name)
        {
            Console.WriteLine(Char.ToUpper(name[0])+name.Substring(1).ToLower());
        }

        public static int Sum(int[] arr,Predicate<int> func)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (func(arr[i]))
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        //public static int Sum(int[] arr, CheckNumber func)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (func(arr[i]))
        //        {
        //            sum += arr[i];
        //        }
        //    }

        //    return sum;
        //}

        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool CheckOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool CheckDivideThree(int num)
        {
            return num % 3 == 0;
        }

    }
}