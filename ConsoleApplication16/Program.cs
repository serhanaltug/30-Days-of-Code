using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            int T = Convert.ToInt32(Console.ReadLine());
            while (T > 0) {
                string patern = Console.ReadLine();

                try
                {
                    //patern.isRegex();
                    Console.WriteLine("Valid");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid"); ;
                }
                finally
                {
                    T--;
                }
            
            }

        }

    }
}
