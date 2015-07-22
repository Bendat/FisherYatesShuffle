using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayShuffle shuffle = new ArrayShuffle();
            int[] array = {1, 3, 5, 2, 8, 9, 0};
            Console.Out.WriteLine("Input list: " + ArrayToString(array));
            Console.Out.WriteLine("Shuffling...");
            shuffle.Shuffle(array);
            Console.Out.WriteLine("Output list: " + ArrayToString(array));
            Console.WriteLine("\n***************List Test****************\n");
            List<int> list = new List<int>(array);
            Console.Out.WriteLine("Input list: " + ListToString(list));
            Console.Out.WriteLine("Shuffling...");
            shuffle.Shuffle(list);
            Console.Out.WriteLine("Output list: " + ListToString(list));
            Console.ReadKey();

        }

        public static string ArrayToString<T>(T[] array, string delim = " ")
        {
            string result = "";
            foreach (var item in array)
            {
                result += item.ToString();
                result += delim;
            }
            return result;
        }
        public static string ListToString<T>(List<T> list, string delim = " ")
        {
            string result = "";
            foreach (var item in list)
            {
                result += item.ToString();
                result += delim;
            }
            return result;
        }

    }
}
