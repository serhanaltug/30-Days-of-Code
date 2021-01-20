using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication11
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = insert(root, data);
            //}

            root = insert(root, 3);
            root = insert(root, 5);
            root = insert(root, 4);
            root = insert(root, 7);
            root = insert(root, 2);
            root = insert(root, 1);

            levelOrder(root);
            Console.ReadLine();
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static int getHeight(Node root)
        {
            if (root == null)
                return 0;

            int ldepth = getHeight(root.left);
            int rdepth = getHeight(root.right);
            return ldepth > rdepth ? ldepth + 1 : rdepth + 1;
        }

        static void levelOrder(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            if (root != null)
            {
                while (true)
                {
                    if (q.Count == 0)
                    { return; }
                    else
                    {
                        Node current = q.Dequeue();
                        Console.Write(current.data.ToString() + ' ');
                        if (current.left != null)
                            q.Enqueue(current.left);
                        if (current.right != null)
                            q.Enqueue(current.right);
                    }
                }                
            }
        }

    }
}
