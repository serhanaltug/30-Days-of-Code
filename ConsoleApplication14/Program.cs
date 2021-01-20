using System;
using System.Linq;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            // D M Y
            int[] actual = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] expected = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //int[] actual = new int[] { 9, 6, 2015 };
            //int[] expected = new int[] { 6, 6, 2015 };
            int Fine = 0;

            //If the book is returned on or before the expected return date, no fine will be charged, in other words fine is 0.
            //If the book is returned in the same month as the expected return date, Fine = 15 Hackos × Number of late days
            //If the book is not returned in the same month but in the same year as the expected return date, Fine = 500 Hackos × Number of late months
            //If the book is not returned in the same year, the fine is fixed at 10000 Hackos.

            if (actual[2] <= expected[2])
            {
                if (actual[1] <= expected[1])
                {
                    if (actual[0] <= expected[0])
                    {

                    }
                    else
                    {
                        Fine = 15 * (actual[0] - expected[0]);
                    }

                }
                else
                {
                    Fine = 500 * (actual[1] - expected[1]);
                }
            }
            else {
                Fine = 10000;
            }



            Console.WriteLine(Fine);
            Console.ReadLine();
        }
    }
}
