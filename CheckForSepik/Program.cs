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
            int i = int.Parse(Console.ReadLine());

            int result = 0;

            while (i > 0)
            {
                if (i > 0)
                {
                    result++;
                    i = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
