using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (isPrime(a[i]))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }


            Console.ReadLine();
        }

        public static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}
