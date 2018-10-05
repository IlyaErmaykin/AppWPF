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

            int absX = Math.Abs(X1 - X2);
            int absY = Math.Abs(Y1 - Y2);

            string result;

            if ((X1 == X2) && (Y1 == Y2) ||
                (absX == 1) && (absY == 1) ||
                (absX == 2) && (absY == 2) ||
                (absX == 3) && (absY == 3) ||
                (absX == 4) && (absY == 4) ||
                (absX == 5) && (absY == 5) ||
                (absX == 6) && (absY == 6) ||
                (absX == 7) && (absY == 7)
                )
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
