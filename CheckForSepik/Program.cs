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
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine(n + "^" + e + "=" + Task.Power(n, e));
            Console.ReadKey();
        }
    }

    public class Task
    {
        public static double Power(int number, int exponent)
        {
            double result = Math.Pow(number, exponent);
            return result;
        }
    }
}

