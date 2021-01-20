using System;
using System.Collections.Generic;

namespace ConsoleApplication12
{

    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class Program
    {
        public static Node removeDuplicates(Node head)
        {
            if (head == null || head.next == null)
                return head;

            Node currentNode = head.next;
            Node previousNode = head;

            while (currentNode != null)
            {
                if (previousNode.data != currentNode.data)
                {
                    previousNode.next = currentNode;
                    previousNode = currentNode;
                }
                currentNode = currentNode.next;
            }
            previousNode.next = currentNode;

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {
            Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = insert(head, data);
            //}

            head = insert(head, 1);
            head = insert(head, 2);
            head = insert(head, 2);
            head = insert(head, 2);
            head = insert(head, 3);
            head = insert(head, 3);
            head = insert(head, 4);
            
            head = removeDuplicates(head);
            display(head);
            Console.ReadLine();
        }
    }
}
