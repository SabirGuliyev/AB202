using System.Text;
using System.Text.RegularExpressions;

namespace StringStringBuilderRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String methods


            //string name = "  sA1   ";

            //name =Capitalize(name.Trim().ToLower().Replace("1", "bir")) ;
            //Console.WriteLine(name);
            //string word = "Salam necesiz gencler";
            //string[] words = { "Salam", "Guys", "How", "are", "you" };
            //word.Trim();
            //word.ToLower();
            //word.ToUpper();
            //word.Contains("Sa");
            //word.Replace(" ","");
            //word.IndexOf("622");
            //word.LastIndexOf();
            //word.StartsWith('0')
            //word.EndsWith('2');
            // string[] words= word.Split('e');
            //char[] elements= word.ToCharArray();
            //word.Substring(6, 50);

            //string.Join(' ', words);
            //string.Concat("Sabir", " ", "Quliyev")

            //for (int i = 0; i < elements.Length; i++)
            //{
            //    Console.WriteLine(elements[i]);
            //} 
            #endregion
            #region Stringbuilder Char methods

            //Mutable Immutable

            //string name = "Sabir";
            //name += "Quliyev";

            //Console.WriteLine(name);
            //string name=Console.ReadLine().Trim();

            //name=Capitalize(name);


            //Console.WriteLine(name);


            //string name = "Sa1";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (Char.IsLetter(name[i]) ) 
            //    {
            //        Console.WriteLine("Duzdu " + name[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine(name[i]);
            //    }
            //} 
            #endregion
            #region Array methods
            //int[] nums = { 4, 1, 8, 3, 9, 0, 5 };
            //nums.Min();
            //nums.Max();
            //nums.Sum();
            //nums.Average();
            //nums= nums.Append(23).ToArray();
            //Array.Sort(nums);
            //Array.Reverse(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.WriteLine();

            //int[] numbers = { 1, 2, 3 };

            //int[] nums=new int[3] {1,2, 3};

            //Array.ForEach(numbers, num => Console.WriteLine(num));

            //foreach (int num in numbers)
            //{
            //    if (num%2==0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            #endregion

            #region Regex
            //string sentence = "salam \"Azer\" necesen ";
            //Console.WriteLine(sentence);

            //string answer=Console.ReadLine().ToLower();

            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //if (regex.IsMatch(answer))
            //{
            //    Console.WriteLine("Duzdu");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong");
            //}

            #endregion
        }



        public static string Capitalize(string name)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Char.ToUpper(name[0]));

            for (int i = 1; i < name.Length; i++)
            {
                sb.Append(Char.ToLower(name[i]));
            }

            return sb.ToString();
        }
    }
}