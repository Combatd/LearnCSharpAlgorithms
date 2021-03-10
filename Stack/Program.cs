using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray; // contains the pointers
        private int top; // represents node at the top of the stack

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1; // always the lsat item in the array
        }

    }
}
