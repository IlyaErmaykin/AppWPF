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
            int value = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = value; i >= 2; i--)
            {
                if (value % i == 0)
                {
                    result = i;
                }
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
