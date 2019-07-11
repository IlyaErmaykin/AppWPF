using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleForTest
{
    //Написать программу сортировки 
    //координат точек в массиве структур, 
    //содержащих объединения по 
    //убыванию их евклидового расстояния 
    //относительно точки (0, 0)

    //1 создание двумерного массива;
    // 1.1 Заполененый массив (Array)
    // 1.2 Массив заполняемый случайными числами (Array + random)
    // 1.3 Список (List)
    // 1.4 Список заполняемый случайными числами (List + random)
    //2 расчет евклидового расстояния; 
    //3 сортировка по убыванию 
    //class Program
    //{
    //    /// <summary> 
    //    /// Run program function
    //    /// </summary> 
    //    /// <param name="args"></param> 
    //    static void Main(string[] args)
    //    {
    //        int[,] array = null;

    //        CountValue countValue = new CountValue();

    //        array = countValue.CreateArr();
    //        countValue.DistanceCalculation(array);
    //        //var arr = CreateArr
    //        //DistanceCalculation(int MyArray[,]);

    //        Console.ReadKey();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "акт сверки"; //Строка с кириллическими символами
            string s2 = "aкт cвepки"; //Строка с латинскими символами

            // Не подошедшая реализация
            //if (Regex.IsMatch(s2, @"\p{IsCyrillic}"))
            //{
            //    Console.WriteLine("Успех!");
            //} else
            //{
            //    Console.WriteLine("Не сегодня!");
            //}

            foreach (char ch in s2)
            {
                if ((int)ch >= 97 && (int)ch <= 128)
                {
                    Console.WriteLine(ch);
                }
            }
            

            //if (s1 == s2)
            //    Console.WriteLine("Успех!");
            //Console.WriteLine("Не сегодня!");
            Console.ReadKey();
        }
    }

    class Counter
    {
        public Encoding GetFileEncoding(string srcFile)
        {
            return null;
        }
    }
}
