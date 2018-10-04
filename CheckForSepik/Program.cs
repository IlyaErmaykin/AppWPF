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
            int aValue = int.Parse(Console.ReadLine());
            int bValue = int.Parse(Console.ReadLine());
            int cValue = int.Parse(Console.ReadLine());

            string result;

            if ((aValue + bValue > cValue) && (aValue + cValue > bValue) && (bValue + cValue > aValue))
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
