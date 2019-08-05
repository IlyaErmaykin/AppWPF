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

//namespace ConsoleForTest
//{
//    //Написать программу сортировки 
//    //координат точек в массиве структур, 
//    //содержащих объединения по 
//    //убыванию их евклидового расстояния 
//    //относительно точки (0, 0)

//    // + //1 создание двумерного массива;
//    // + // 1.1 Заполененый массив (Array)
//    // 1.2 Массив заполняемый случайными числами (Array + random)
//    // 1.3 Список (List)
//    // 1.4 Список заполняемый случайными числами (List + random)
//    //2 расчет евклидового расстояния; 
//    //3 сортировка по убыванию 
//    //class Program
//    //{
//    //    /// <summary> 
//    //    /// Run program function
//    //    /// </summary> 
//    //    /// <param name="args"></param> 
//    //    static void Main(string[] args)
//    //    {
//    //        int[,] array = null;
//    //        double[] arrayDistence = null;
//    //        double[] arraySorted = null;

//    //        CountValue countValue = new CountValue();

//    //        array = countValue.CreateArr();
//    //        arrayDistence = countValue.DistanceCalculation(array);
//    //        arraySorted = countValue.SortingFunction(arrayDistence);

//    //        foreach (int i in arraySorted)
//    //        {
//    //            Console.WriteLine(i);
//    //        }

//    //        Console.ReadKey();
//    //    }
//    //}

//    class Program
//    {

//    }

//    class Counter
//    {
//        public Encoding GetFileEncoding(string srcFile)
//        {
//            return null;
//        }
//    }
//}

public class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();

        try
        {
            double time = 1000;
            bool flag = false;

            Flows.createFlows(new ParameterizedThreadStart(program.runFunction), time, flag);
            Thread.Sleep(60000);
        }
        catch
        {
            new Exception();
        }

        //Console.ReadKey();
    }

    /// <summary>
    /// Run function
    /// </summary>
    /// <param name="obj"></param>
    public void runFunction(object obj)
    {
        var objArray = (object[])obj;
        double inputTime = (double)objArray[0];
        bool resultFlag = (bool)objArray[1];

        var timer = new ConsoleForTest.Timer();

        timer.SetTimer(inputTime, resultFlag);
        timer.Stop();
        timer.Dispose();
    }
}