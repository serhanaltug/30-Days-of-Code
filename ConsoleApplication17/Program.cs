using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            int T = Convert.ToInt32(Console.ReadLine());
            while (T > 0)
            {
                char[] s = Console.ReadLine().ToCharArray();
                char[] r = new char[s.Length];
                for(int x = 0; x<s.Length; x++){
                    r[x] = s[s.Length-1-x];
                }

                string message = String.Empty;
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (Math.Abs(s[i + 1] - s[i]) == Math.Abs(r[i + 1] - r[i]))
                    {
                        message = "Funny\n";
                    }
                    else
                    {
                        message = "Not Funny\n";
                        break;
                    }
                }
                result += message;
                T--;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
