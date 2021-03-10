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
            top = -1; // always the last item in the array
        }

        public void push(string m)
        {
            // First, check to see if the stack is full
            if (isFull())
            {
                Console.WriteLine("This stack is full"); 
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty.");
                return "--";
            } else
            {
                int old_top = top; // temp variable to copy index position
                top--;
                return stackArray[old_top]; // return the stack array with the index position with the pointer/node at the top removed
            }
        }

        public string peek()
        {
            // peek at the node at the top of the stack
            return stackArray[top];
        }

        private bool isEmpty()
        {
            // safety check to see if stack is empty
            return (top == -1);
        }

        private bool isFull()
        {
            // maxSize is a value set passed in
            // the array is initalized at 0, so we have to -1 to get the index
            return (maxSize - 1 == top);
        }

    }
}
