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
            Task.CheckPairs("Console.ReadLine();", '(', ')'); /* Все в порядке */

            Console.ReadKey();
        }
    }

    public class Task
    {
        public static void CheckPairs(string text, char openSimbol, char closeSimbol)
        {
            int countOpenSimbol = 0;
            int countCloseSimbol = 0;
            string result = "Все в порядке";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == openSimbol)
                {
                    countOpenSimbol++;
                    //Console.WriteLine(text[i]);
                }
                else if (text[i] == closeSimbol)
                {
                    countCloseSimbol++;
                    //Console.WriteLine(text[i]);
                }
            }
            //Console.WriteLine(text);

            if (countOpenSimbol == countCloseSimbol)
            {
                for (int i = 0; i < countOpenSimbol; i++)
                {
                    int search = text.IndexOf(openSimbol);
                    int search1 = text.IndexOf(closeSimbol);

                    if (search < search1)
                    {
                        text = text.Remove(search, 1);
                        text = text.Remove(search1 - 1, 1);
                        //Console.WriteLine($"{search} {search1}");
                        //Console.WriteLine(text);
                    }
                    else
                    {
                        result = "Найдены ошибки";
                    }
                }
            }
            else
            {
                result = "Найдены ошибки";
            }

            Console.WriteLine(result);
        }
    }
}

