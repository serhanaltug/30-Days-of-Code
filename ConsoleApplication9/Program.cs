using System;

namespace ConsoleApplication9
{
    class Program
    {

        public static void printArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }
    }
}
