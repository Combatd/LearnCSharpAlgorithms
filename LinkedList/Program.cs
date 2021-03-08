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
            SinglyLinkedList myList = new SinglyLinkedList();

            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);

            myList.insertLast(999000);

            myList.displayList();
            myList.deleteFirst();

            myList.displayList();
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

        public void displayList()
        {
            Console.WriteLine("List (first -- last ");
            Node current = first;

            // loop through nodes and display their data
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }

            Console.WriteLine();
        }

        public void insertLast(int data)
        {
            Node current = first;
            // loop to find the last node to set it to current
            while (current.next != null)
            {
                current = current.next;
            }

            // the next node after current is going to be the last node
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
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
