namespace RefOutAB202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Refereance examples
            //int a = 5;
            //int b = 5;

            //Console.WriteLine(a==b);

            //Console.WriteLine(a);


            //int[] numbers= {1,2,3};
            //int[] numbers2 = {1,2,3};


            //Console.WriteLine(numbers==numbers2);

            //Console.WriteLine(numbers[0]); 
            #endregion

            #region Ref and Out

            //int[] numbers = { 1, 2, 3 };

            //ChangeIndex(numbers);

            //Console.WriteLine(numbers[0]);


            //ref ve out

            //int a = 5;

            //ChangeValue(ref a);


            //Console.WriteLine(a);



            //int[] nums = { 1, 2, 3, 4, 5 };

            //ResetArray(ref nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}



            //int a;

            //Change(out a);

            //Console.WriteLine(a); 
            #endregion


            #region Array Resize
            //int[] numbers = { 1, 2, 3 };


            //Array.Resize(ref numbers, numbers.Length + 1);

            //numbers[numbers.Length - 1] = 30;


            ////ArrayResize(ref numbers,20);
            ////ArrayResize(ref numbers,900);
            ////ArrayResize(ref numbers,1200);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion



            #region TryParse
            //string str = Console.ReadLine();

            //int num;

            //bool result = int.TryParse(str, out num);

            //if (result)
            //{
            //    Console.WriteLine(num + " Istifadeciden gelen deyer");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlish deyer daxil etdiniz");
            //} 
            #endregion




            if (true)
            {
                //int a = 5;

                int[] numbers = { 1, 2, 3 };
                
            }
            
        }












        #region Array Resize method
        public static void ArrayResize(ref int[] arr, int num)
        {
            int[] copy = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            copy[copy.Length - 1] = num;

            arr = copy;

        } 
        #endregion


        #region Ref out Methods
        //public static void Change(out int num)
        //{

        //    num += 20;
        //}





        //public static void ResetArray(ref int[] arr)
        //{
        //    arr=new int[arr.Length];

        //}





        //public static void ChangeValue(ref int num)
        //{
        //    num += 10;
        //}

        #endregion


        //public static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 200;
        //}


    }
}