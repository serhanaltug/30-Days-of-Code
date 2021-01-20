using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            String s = Console.ReadLine();
            //var words = s.Split(new char[] { ' ', '!', '[', ',', '?', '.', '\\', '_', '\'', '@', '+', ']' });

            var splitter = @" ![,?.\_'@+]".ToCharArray();

            var words = s.Split(splitter, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine(words.Length);
            foreach (var x in words)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();




        }
    }
}
