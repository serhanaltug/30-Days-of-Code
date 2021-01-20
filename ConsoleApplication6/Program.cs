using System;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Palindrome class object p.
            Palindrome p = new Palindrome();

            // push all the characters of string s to stack.
            foreach (char c in s)
            {
                p.pushCharacter(c);
            }

            // enqueue all the characters of string s to queue.
            foreach (char c in s)
            {
                p.enqueueCharacter(c);
            }

            bool f = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length; i++)
            {
                if (p.popCharacter() != p.dequeueCharacter())
                {
                    f = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (f)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }

            Console.ReadLine();
        }

        class Palindrome
        {
            Queue<char> q = new Queue<char>();
            Stack<char> s = new Stack<char>();
            
            public void pushCharacter(char ch) { 
                s.Push(ch);
            }

            public void enqueueCharacter(char ch) { 
                q.Enqueue(ch);
            }

            public char popCharacter() { 
                return s.Pop();
            }

            public char dequeueCharacter(){
                return q.Dequeue();
            }
        }
    }
}
