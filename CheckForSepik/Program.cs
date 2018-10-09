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
            int X1 = int.Parse(Console.ReadLine());
            int Y1 = int.Parse(Console.ReadLine());
            int X2 = int.Parse(Console.ReadLine());
            int Y2 = int.Parse(Console.ReadLine());

            int absX = Math.Abs(X1 - Y1);
            int absY = Math.Abs(X2 - Y2);

            string result;

            if (absX % 2 == absY % 2)
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
