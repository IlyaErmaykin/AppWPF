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
            int valueA = int.Parse(Console.ReadLine());
            int valueB = int.Parse(Console.ReadLine());
            int count = 0;

            double result = 0;

            for (int i = valueA; valueA <= valueB; i++)
            {
                if (valueA % 3 == 0)
                {
                    result = result + valueA;
                    count++;
                }
                valueA++;
            }

            Console.WriteLine(result / count);

            Console.ReadKey();
        }
    }
}
