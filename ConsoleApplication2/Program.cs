using System;
using System.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            
            Console.Read();
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            elements = a;
            Array.Sort(elements);
        }

        public void computeDifference() {
            maximumDifference = elements[elements.Length - 1] - elements[0];
        }

    }


}
