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
            Task.PrintColoredText("This text should be red", ConsoleColor.Red);
            Task.PrintColoredText("This text should be yellow", ConsoleColor.Yellow);

            Console.ReadKey();
        }
    }

    class Task
    {
        public static void PrintColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text, Console.ForegroundColor);
        }
    }
}
