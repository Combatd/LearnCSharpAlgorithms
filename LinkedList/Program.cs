using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO
        }
    }

    public class SinglyLinkedList
    {
        private Node first; // the head
        // if the first node is null, we know we have no nodes
        public bool isEmpty()
        {
            return (first == null);
        }

        // we need to be able to insert the node at the front of the LinkedList
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data; // takes value of param data
            newNode.next = first; // points to the first node
            first = newNode;
        }

        // delete the first Node, the head, in the LinkedList
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp; // returns the removed Node, formerly the first
        }



    }

    public class Node
    {
        public int data;
        public Node next; // should be able to show the next node

        public void displayNode()
        {
            Console.WriteLine($"<  {data}  >");
        }
    }



}
