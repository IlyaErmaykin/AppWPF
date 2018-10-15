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
            Task.PrintAsteriskBox(5, 3);

            Console.ReadKey();
        }
    }

    class Task
    {
        static internal void PrintAsteriskBox(int numberColuns, int numberRows)
        {
            for (int i = 1; i <= numberRows; i++)
            {
                PrintAsterisks(numberColuns);
            }
        }

        static internal void PrintAsterisks(int number)
        {
            string count = "";
            for (int i = 1; i <= number; i++)
            {
                count = count + "*";
            }

            Console.WriteLine(count);
        }
    }
}
