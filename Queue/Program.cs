using static System.Console;

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
            //if (isFull())
            //{
            //    Console.WriteLine("The queue is full.");
            //}

            if (rear == maxSize - 1)
            {
                rear = -1; // assign the -1 to rear
            }
            rear++;
            myQueue[rear] = j;
            items++;
        }
    }
}
