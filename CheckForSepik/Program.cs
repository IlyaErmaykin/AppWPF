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

            if ((X1 == X2 || Y1 == Y2) || (absX == absY))
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
