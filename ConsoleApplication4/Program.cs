using System;
using System.Collections.Generic;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(arr_temp, Int32.Parse);

            if (arr_temp.Length == n)
            {

                Array.Sort(a);

                int minDiff = Math.Abs(a[a.Length - 1]) - 1;
                if (Math.Abs(a[0]) > Math.Abs(a[a.Length - 1])) minDiff = Math.Abs(a[0]) - 1;

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (Math.Abs(a[i] - a[i + 1]) < minDiff)
                    {
                        minDiff = Math.Abs(a[i] - a[i + 1]);
                    }
                }

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (Math.Abs(a[i] - a[i + 1]) == minDiff)
                    {
                        Console.Write(a[i].ToString() + ' ' + a[i + 1].ToString() + ' ');
                    }
                }
            }
            Console.ReadLine();
        
        }
    }
}
