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
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            string result;

            if ((k - (m * n/2)) % m == 0 || (k - (m * n / 2)) % n == 0)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
