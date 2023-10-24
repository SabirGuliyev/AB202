namespace ThreadTask
{
    internal class Program
    {
        public static int Count=0;
        public static object BlockObject=new object();
        public static object BlockObject2=new object();
        static void Main(string[] args)
        {
            //Thread thread = new Thread(Loop);
            //Thread thread2 = new Thread(Loop2);

            //thread.Start();
            //thread2.Start();



            //thread.Join();
            //thread2.Join();

            //Console.WriteLine(Count);


            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine($"1ci dovr ishe dushur {i}");

            //    }
            //}).Wait();

            
            
             var task= Task.WhenAll(MakeLoop(), MakeLoop2());

            task.Wait();

            Console.WriteLine("Program bitdi");
            Console.WriteLine(task.IsCompletedSuccessfully);

            //Console.ReadKey();
            
        }

        public static async Task MakeLoop()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"1ci dovr ishe dushur {i}");

                }
            });
        }
        public static async Task MakeLoop2()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"2ci dovr {i}");


                }
            });
        }



        public static void Loop()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //lock (BlockObject)
                //{

                //        Count++;

                //}

                Console.WriteLine($"1ci dovr ishe dushur {i}");
            }
        }

        public static void Loop2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //lock (BlockObject)
                //{

                //        Count--;

                //}

                Console.WriteLine($"2ci dovr {i}");
            }
        }
    }
}