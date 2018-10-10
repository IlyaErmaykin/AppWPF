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
            int result = 0;

            for (int i = int.Parse(Console.ReadLine()); i > 0; i = int.Parse(Console.ReadLine()))
            {
                result++;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
