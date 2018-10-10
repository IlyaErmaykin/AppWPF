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

            for (int i = 0; i < 20; i++)
            {
                int growth = int.Parse(Console.ReadLine());
                if (growth > 160)
                {
                    result++;
                }
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
