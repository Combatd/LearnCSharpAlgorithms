// using static System.Console;
using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 7;
            int[] array = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a linear search for {theValue} is: ");
            Console.WriteLine(linearSearch(array, theValue));
        }

        /// <summary>
		/// a = array of integers
		/// x = value to search for
		/// </summary>
		/// <param name="a"></param>
		/// <param name="x"></param>
		/// <returns></returns>

        static int linearSearch(int [] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
