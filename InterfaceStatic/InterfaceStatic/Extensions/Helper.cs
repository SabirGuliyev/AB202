using InterfaceStatic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Extensions
{
    internal static class Helper
    {
        //public static string Capitalize(string word)
        //{
        //    return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        //}
        public static string Capitalize(this string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

        public static void Power(this int num,int times)
        {
            int result = num;
            for (int i = 1; i < times; i++)
            {
                result *= num;
            }

            Console.WriteLine(result);
        }


        public static void GetName(this Person person)
        {
            Console.WriteLine(person.Name);
        }

    }
}
