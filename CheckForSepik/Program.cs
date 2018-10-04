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
            int ageValue = int.Parse(Console.ReadLine());

            if (ageValue > 70)
            {
                Console.WriteLine("старик");
            }
            else if (ageValue < 18)
            {
                Console.WriteLine("ребёнок");
            }
            else
            {
                Console.WriteLine("взрослый");
            }

            Console.ReadKey();
        }
    }
}
