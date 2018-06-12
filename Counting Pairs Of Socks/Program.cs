using System;
using System.Linq;

namespace Counting_Pairs_Of_Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "gray", "black", "red", "purple", "purple", "gray", "black", "green", "black" };
            Console.WriteLine(NumberOfPairs(array));
        }

        static int NumberOfPairs(string[] array)
        {
            int num = 0;
            array = array.OrderBy(x => x).ToArray();

            for (int i = 0; i < array.Length;)
            {
                int last_index = Array.LastIndexOf(array, array[i]);
                num += (last_index - i + 1) / 2;
                i = ++last_index;
            }

            return num;
        }

    }
}
