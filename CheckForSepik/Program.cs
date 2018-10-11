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
            double x = int.Parse(Console.ReadLine());
            int xCommon = int.Parse(Console.ReadLine());

            int result = 1;

            while (xCommon > x)
            {
                x = x + (x * 0.1);
                result++;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
