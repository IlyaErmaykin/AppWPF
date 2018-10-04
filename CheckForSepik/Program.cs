using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForSepik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            if (a > 5)
            {
                a = 5;
                if (b < 20)
                {
                    a = 7;
                }
            }
            b = 10;
            if (c < b)
            {
                c = 100;
            }
            else if (c < 40)
            {
                c = 50;
            }
            else
            {
                c = 10;
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
