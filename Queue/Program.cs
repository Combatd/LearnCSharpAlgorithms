//using static System.Console;
using System;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
        }
    }

    public class Queue
    {
        private int maxSize;
        private long[] myQueue; // array of 64-bit integers
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0; // track number of pointers
        }

        public void insert(long j)
        {
            if (isFull())
            {
                Console.WriteLine("The queue is full.");
            }

            if (rear == maxSize - 1)
            {
                rear = -1; // assign the -1 to rear
            }
            rear++;
            myQueue[rear] = j;
            items++;
        }

        public long remove()
        {
            long temp = myQueue[front];
            front++; // we are removing from the front, so the next node is front now

            if (front == maxSize)
            {
                front = 0; // when we do this, we can use the entire array again
            }

            return temp;
        }

        public long peekFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("The queue is empty");
                return 0;
            }

            return myQueue[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);
        }

        public void view()
        {
            Console.Write("[");

            for (int i = 0; i < myQueue.Length; i++)
            {
                Console.Write(myQueue[i] + " ");
            }

            Console.WriteLine("]");
        }
    }
}
