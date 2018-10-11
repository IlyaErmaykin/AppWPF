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
            string result = "";

            for (int i = int.Parse(Console.ReadLine()); i <= 100; i = int.Parse(Console.ReadLine()))
            {
                if (i < 10)
                {
                    continue;
                }
                result = result + i + "\n";
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
