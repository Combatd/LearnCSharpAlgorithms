using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// a = array
        /// x = what we are searching for
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>

        public static int binarySearch(int[] a, int x)
        { // Step 1: initialize the variables
            int p = 0; // beginning of the range
            int r = a.Length - 1; // end of the array

            // Step 2: We search for our value

            while (p <= r)
            {
                int q = (p + r) / 2; // midpoint index of the array
                if (x < a[q])
                {
                    r = q - 1; // r will be the midpoint as we check left side
                } else if (x > a[q])
                {
                    p = q + 1; // the beginning is higher than the midpoint, being the right side of array
                } else
                {
                    return q;
                }
            }

            // Step 3: indicate x was not found
            return -1;
        }
    }
}
