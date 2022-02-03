using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Timers;
using System.Threading;
using ConsoleForTest;
using System.Windows.Forms;
using System.Windows;

namespace ConsoleForTest
{
    //Написать программу сортировки 
    //координат точек в массиве структур, 
    //содержащих объединения по 
    //убыванию их евклидового расстояния 
    //относительно точки (0, 0)

    // + //1 создание двумерного массива;
    // + // 1.1 Заполененый массив (Array)
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
    //        double[] arrayDistence = null;
    //        double[] arraySorted = null;

    //        CountValue countValue = new CountValue();

    //        array = countValue.CreateArr();
    //        arrayDistence = countValue.DistanceCalculation(array);
    //        arraySorted = countValue.SortingFunction(arrayDistence);

    //        foreach (int i in arraySorted)
    //        {
    //            Console.WriteLine(i);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 3 };
            TwoSum(nums, 6);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] {0, 0};
            var i = 0;
            for (int y = 0; y < nums.Length; y++)
            {
                for (int z = 0; z < nums.Length; z++)
                {
                    if (Array.IndexOf(nums, y) != Array.IndexOf(nums, z) && nums[y] + nums[z] == target) 
                    {
                        result[i] = Array.IndexOf(nums, y);
                        result[i + 1] = Array.IndexOf(nums, z);
                        return result;
                    }
                }
            }
            return null;
        }
    }


}