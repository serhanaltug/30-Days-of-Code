using System;

namespace ConsoleApplication3
{
    class Program
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            Node temp = new Node(data);
            Node current = head;

            if (head == null) 
                head = temp;
            else
            {
                while(current.next != null){
                    current = current.next;
                }
                current.next = temp;
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

        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
            Console.ReadLine();
        }
    }

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

}
