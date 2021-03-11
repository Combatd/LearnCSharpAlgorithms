using static System.Console;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
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
            for (int = 0; int < a.Length; int++)
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
